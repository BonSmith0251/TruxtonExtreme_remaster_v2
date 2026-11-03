"""Turn a prefab survey (prefab_survey.py) into a move plan for unity-project-layout's LayoutMover, plus a review table.

Each prefab in the survey gets a category from the rules (default_rules.json, first match wins) and a destination
<root>/<Category>/<Name>.prefab. Refinements:
  - variants go to their base prefab's category (same folder as the base),
  - parts (used only inside other prefabs in scope, never placed in a scene or referenced elsewhere) go to
    <parent's category>/Parts,
  - "keep" patterns (Resources, Editor, tool-generated folders such as Dedup) never move; nor do prefabs already
    where they belong,
  - two prefabs landing on the same file keep their old sub-folder name as an extra level.
Renames are explicit only (--renames old_name=new_name ...) and are refused for prefabs that code or data name as a
string, that sit in Resources, or that are addressable, unless --allow-named-renames.

    python -I prefab_plan.py prefabs.json [--rules rules.json] [--root Assets/Prefabs] [--renames map.json]
                             [--plan layout-plan.json] [--review prefab-plan.md]
"""
import argparse, collections, json, os, posixpath, re, sys

HERE = os.path.dirname(os.path.abspath(__file__))
IGNORED = {'GameObject', 'Transform', 'RectTransform'}


def matches(rule, p):
    names = set(p['components']) | set(p['scripts'])
    if 'rootUI' in rule and bool(p['rootUI']) != bool(rule['rootUI']):
        return False
    if 'name_re' in rule and not re.search(rule['name_re'], p['name'], re.I):
        return False
    if 'has_any' in rule and not names & set(rule['has_any']):
        return False
    if 'has_only' in rule and not (set(p['components']) - IGNORED) <= set(rule['has_only']):
        return False
    return True


def categorise(p, rules):
    for i, r in enumerate(rules['categories']):
        if matches(r, p):
            why = ', '.join('%s=%s' % (k, r[k]) for k in ('rootUI', 'name_re', 'has_any', 'has_only') if k in r)
            return r['name'], 'rule %d (%s)' % (i + 1, why[:60])
    return rules.get('fallback', 'Misc'), 'no rule matched'


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument('survey')
    ap.add_argument('--rules', default=os.path.join(HERE, 'default_rules.json'))
    ap.add_argument('--root', help='destination root (default: the rules file\'s "root")')
    ap.add_argument('--renames', help='JSON {"OldName": "NewName"} of explicit renames')
    ap.add_argument('--allow-named-renames', action='store_true')
    ap.add_argument('--plan', default='prefab-layout-plan.json')
    ap.add_argument('--review', default='prefab-plan.md')
    a = ap.parse_args()
    survey = json.load(open(a.survey, encoding='utf-8'))
    rules = json.load(open(a.rules, encoding='utf-8'))
    root = (a.root or rules.get('root', 'Assets/Prefabs')).rstrip('/')
    renames = json.load(open(a.renames, encoding='utf-8')) if a.renames else {}
    prefabs = survey['prefabs']
    by_path = {p['path']: p for p in prefabs}

    cat, why = {}, {}
    for p in prefabs:
        cat[p['path']], why[p['path']] = categorise(p, rules)
    # Variants follow their base (when the base is in the survey).
    for p in prefabs:
        base = p['variantOf']
        if base in by_path:
            cat[p['path']], why[p['path']] = cat[base], 'variant of ' + by_path[base]['name']
    # Parts: used only nested inside other surveyed prefabs (a prefab whose users include its own variants is a base,
    # not a part).
    part = {}
    for p in prefabs:
        parents = [x for x in p['usedInPrefabs'] if x in by_path and p['path'] in by_path[x]['nests']]
        if parents and len(parents) == len(p['usedInPrefabs']) and not p['usedInScenes'] and not p['usedElsewhere'] and not p['variantOf']:
            part[p['path']] = cat[parents[0]]
            why[p['path']] = 'part of ' + by_path[parents[0]]['name'] + (' (+%d more)' % (len(parents) - 1) if len(parents) > 1 else '')

    rows, steps, targets, blocked = [], [], collections.defaultdict(list), []
    for p in prefabs:
        path, name = p['path'], p['name']
        new_name = renames.get(name, name)
        flags = []
        if p['nameRefs']:
            flags.append('named in %d file(s)' % len(p['nameRefs']))
        if p['variantOf']:
            flags.append('variant')
        if p['nests']:
            flags.append('nests %d' % len(p['nests']))
        if not (p['usedInScenes'] or p['usedInPrefabs'] or p['usedElsewhere']):
            flags.append('unused')
        if p['missingScripts']:
            flags.append('MISSING SCRIPTS %d' % p['missingScripts'])
        if new_name != name and (p['nameRefs'] or p['inResources'] or p['addressable']) and not a.allow_named_renames:
            blocked.append('%s -> %s: %s' % (name, new_name, 'named in ' + ', '.join(p['nameRefs'][:3]) if p['nameRefs'] else 'Resources/Addressables'))
            new_name = name
        kept = next((k for k in rules.get('keep', []) if k in '/' + path), None)
        if kept or p['inResources']:
            rows.append((path, path, 'kept (%s)' % (kept or '/Resources/'), flags))
            continue
        folder = posixpath.join(root, cat[path] if path not in part else part[path] + '/Parts')
        dest = posixpath.join(folder, new_name + '.prefab')
        targets[dest].append(path)
        rows.append([path, dest, why[path], flags])
    # Collisions: keep the old parent folder's name as an extra level.
    for dest, sources in targets.items():
        if len(sources) > 1 or (os.path.exists(os.path.join(survey['project'], dest)) and sources[0] != dest):
            for row in rows:
                if row[0] in sources and row[1] == dest:
                    row[1] = posixpath.join(posixpath.dirname(dest), posixpath.basename(posixpath.dirname(row[0])), posixpath.basename(dest))
                    row[3] = row[3] + ['name clash']
    for row in rows:
        if row[0] != row[1]:
            steps.append({'from': row[0], 'to': row[1]})
    # Folders the plan leaves with nothing in them (checked on disk: any other file, e.g. a tool's manifest, keeps the
    # folder, and LayoutMover would report a listed folder that is not empty as an error).
    moved = {s['from'] for s in steps}
    project = survey['project']
    candidates = set()
    for s in steps:
        d = posixpath.dirname(s['from'])
        while d.startswith(root + '/') or (d.startswith('Assets/') and not root.startswith(d)):
            candidates.add(d)
            d = posixpath.dirname(d)
    emptied = []
    for d in sorted(candidates, key=len, reverse=True):
        rest = []
        for base, _, files in os.walk(os.path.join(project, d)):
            rest += [posixpath.join(d, posixpath.relpath(os.path.join(base, f).replace('\\', '/'), os.path.join(project, d).replace('\\', '/')))
                     for f in files if not f.endswith('.meta')]
        if all(r in moved for r in rest) and not any(r[1] == d or r[1].startswith(d + '/') for r in rows):
            emptied.append(d)

    json.dump({'steps': steps, 'emptied': emptied}, open(a.plan, 'w', encoding='utf-8'), indent=1)
    counts = collections.Counter(posixpath.relpath(posixpath.dirname(r[1]), root) if r[1].startswith(root + '/') else 'kept elsewhere' for r in rows)
    with open(a.review, 'w', encoding='utf-8') as fh:
        fh.write('# Prefab plan\n\n%d prefabs, %d moves, root `%s`.\n\n| Folder | Prefabs |\n| --- | --- |\n' % (len(rows), len(steps), root))
        for f, n in sorted(counts.items()):
            fh.write('| %s | %d |\n' % (f, n))
        if blocked:
            fh.write('\nRenames refused (name lookups would break):\n\n' + ''.join('- %s\n' % b for b in blocked))
        fh.write('\n| Prefab | Now | Goes to | Why | Notes |\n| --- | --- | --- | --- | --- |\n')
        for frm, to, reason, flags in sorted(rows, key=lambda r: r[1].lower()):
            fh.write('| %s | %s | %s | %s | %s |\n' % (posixpath.basename(frm)[:-7], posixpath.dirname(frm), 'same' if frm == to else posixpath.dirname(to), reason, ', '.join(flags)))
    print('%d prefabs: %d moves, %d kept; plan %s, review %s' % (len(rows), len(steps), len(rows) - len(steps), a.plan, a.review))
    for f, n in sorted(counts.items()):
        print('  %4d  %s' % (n, f))
    if blocked:
        print('renames refused: %d (see review)' % len(blocked))


if __name__ == '__main__':
    main()
