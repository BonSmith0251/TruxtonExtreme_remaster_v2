"""Read-only survey of every prefab in a Unity project (text serialization), for organising them.

For each prefab: path, GUID, name; the components it holds (built-in class names and MonoBehaviour script names);
whether its root is UI (RectTransform/Canvas); whether it is a variant and of what; which prefabs it nests; who uses it
(scenes, other prefabs, other assets - by GUID); whether code or data name it as a quoted string (name lookups break on
rename); whether it sits in a Resources folder or is listed in Addressables.

    python -I prefab_survey.py <ProjectRoot> [--scope Assets/Prefabs] [--extra DIR ...] [--out prefabs.json]

--scope limits which prefabs are listed (usage is always searched project-wide). Needs Asset Serialization = Force Text.
"""
import argparse, collections, json, os, re, sys

CLASS = {1: 'GameObject', 4: 'Transform', 20: 'Camera', 23: 'MeshRenderer', 33: 'MeshFilter', 50: 'Rigidbody2D',
         54: 'Rigidbody', 58: 'CircleCollider2D', 60: 'PolygonCollider2D', 61: 'BoxCollider2D', 64: 'MeshCollider',
         65: 'BoxCollider', 70: 'CapsuleCollider2D', 82: 'AudioSource', 95: 'Animator', 96: 'TrailRenderer',
         108: 'Light', 111: 'Animation', 114: 'MonoBehaviour', 120: 'LineRenderer', 135: 'SphereCollider',
         136: 'CapsuleCollider', 137: 'SkinnedMeshRenderer', 143: 'CharacterController', 195: 'NavMeshAgent',
         198: 'ParticleSystem', 199: 'ParticleSystemRenderer', 212: 'SpriteRenderer', 222: 'CanvasRenderer',
         223: 'Canvas', 224: 'RectTransform', 225: 'CanvasGroup', 1001: 'PrefabInstance', 2083052967: 'VisualEffect',
         320: 'PlayableDirector', 328: 'VideoPlayer', 331: 'SpriteMask', 483693784: 'TilemapRenderer'}
TEXT_ASSETS = ('.unity', '.prefab', '.asset', '.playable', '.controller', '.overrideController', '.mat', '.anim',
               '.spriteatlas', '.lighting')
CODE = ('.cs', '.py', '.json', '.txt', '.csv', '.xml', '.yaml', '.yml', '.lua', '.js', '.ts')
SKIP = {'Library', 'Temp', 'Logs', 'obj', '.git', '.vs', '__pycache__', 'node_modules', 'UserSettings', 'Build', 'Builds'}
GUID_RE = re.compile(r'guid: ([0-9a-f]{32})')
HEADER_RE = re.compile(r'^--- !u!(\d+) &(-?\d+)( stripped)?', re.M)


def meta_guid(path):
    try:
        with open(path + '.meta', encoding='utf-8', errors='ignore') as fh:
            m = re.search(r'^guid: ([0-9a-f]{32})', fh.read(), re.M)
            return m.group(1) if m else None
    except OSError:
        return None


def walk(root, exts):
    for d, dirs, files in os.walk(root):
        dirs[:] = [x for x in dirs if x not in SKIP and not x.startswith('.')]
        for f in files:
            if f.endswith(exts):
                yield os.path.join(d, f).replace('\\', '/')


def is_text(path):
    try:
        with open(path, 'rb') as fh:
            return fh.read(5) == b'%YAML'
    except OSError:
        return False


def parse_prefab(text, scripts):
    blocks = list(HEADER_RE.finditer(text))
    comps, script_names, nested, variant_of, root_ui = collections.Counter(), collections.Counter(), [], None, False
    for i, b in enumerate(blocks):
        cid = int(b.group(1))
        body = text[b.end(): blocks[i + 1].start() if i + 1 < len(blocks) else len(text)]
        if b.group(3):          # stripped: belongs to a nested prefab instance, not this file's own content
            continue
        if cid == 1001:
            src = re.search(r'm_SourcePrefab: \{fileID: \d+, guid: ([0-9a-f]{32})', body)
            parent = re.search(r'm_TransformParent: \{fileID: (-?\d+)', body)
            if src:
                if parent and parent.group(1) == '0':
                    variant_of = src.group(1)
                else:
                    nested.append(src.group(1))
            continue
        name = CLASS.get(cid, 'Class%d' % cid)
        comps[name] += 1
        if cid == 114:
            m = re.search(r'm_Script: \{fileID: (-?\d+), guid: ([0-9a-f]{32})', body)
            if m:
                script_names[scripts.get(m.group(2), 'dll:' + m.group(1) if m.group(1) != '11500000' else 'missing:' + m.group(2)[:8])] += 1
        if cid in (224, 223) and re.search(r'm_Father: \{fileID: 0\}', body):
            root_ui = True
    return comps, script_names, nested, variant_of, root_ui


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument('project')
    ap.add_argument('--scope', action='append', default=[], help='only list prefabs under this folder (repeatable)')
    ap.add_argument('--extra', action='append', default=[], help='more folders to search for name references')
    ap.add_argument('--exclude', action='append', default=[],
                    help='skip files whose path contains this text in the name-reference search (e.g. a one-off generator)')
    ap.add_argument('--out', default='prefabs.json')
    a = ap.parse_args()
    project = os.path.abspath(a.project).replace('\\', '/')
    a.out = os.path.abspath(a.out)                      # before chdir: never write into the project by accident
    a.extra = [os.path.abspath(x) for x in a.extra]
    os.chdir(project)
    settings = open('ProjectSettings/EditorSettings.asset', encoding='utf-8', errors='ignore').read()
    if 'm_SerializationMode: 2' not in settings:
        print('WARNING: Asset Serialization is not Force Text; binary assets cannot be read.')

    # Scripts from the project and from packages (a TextMeshPro script is not missing just because it is not in Assets).
    scripts = {}
    for root in ('Assets', 'Packages', 'Library/PackageCache'):
        for p in walk(root, ('.cs',)) if os.path.isdir(root) else []:
            g = meta_guid(p)
            if g:
                scripts[g] = os.path.splitext(os.path.basename(p))[0]
    prefabs = {}
    for p in walk('Assets', ('.prefab',)):
        g = meta_guid(p)
        if g:
            prefabs[g] = p
    scoped = {g: p for g, p in prefabs.items() if not a.scope or any(p.startswith(s.rstrip('/') + '/') for s in a.scope)}
    print('%d prefabs in the project, %d in scope' % (len(prefabs), len(scoped)), file=sys.stderr)

    # Usage by GUID, project-wide (text assets only).
    users = collections.defaultdict(collections.Counter)
    for p in walk('Assets', TEXT_ASSETS):
        if os.path.getsize(p) > 200_000_000 or not is_text(p):
            continue
        with open(p, encoding='utf-8', errors='ignore') as fh:
            text = fh.read()
        for g in set(GUID_RE.findall(text)):
            if g in prefabs and prefabs[g] != p:
                users[g][p] += 1
    addressables = set()
    for p in walk('Assets/AddressableAssetsData', ('.asset',)) if os.path.isdir('Assets/AddressableAssetsData') else []:
        addressables |= set(re.findall(r'm_GUID: ([0-9a-f]{32})', open(p, encoding='utf-8', errors='ignore').read()))

    # Name references: a prefab's name as a whole quoted string in code or data.
    names = collections.defaultdict(list)
    for g, p in scoped.items():
        names[os.path.splitext(os.path.basename(p))[0]].append(g)
    name_refs = collections.defaultdict(list)
    if names:
        rx = re.compile(r'''["'](%s)["']''' % '|'.join(re.escape(n) for n in sorted(names, key=len, reverse=True)))
        for root in ['Assets'] + a.extra:
            for p in walk(root, CODE):
                if any(x in p for x in a.exclude):
                    continue
                try:
                    text = open(p, encoding='utf-8', errors='ignore').read()
                except OSError:
                    continue
                for n in set(rx.findall(text)):
                    name_refs[n].append(p)

    out = []
    for g, p in sorted(scoped.items(), key=lambda x: x[1].lower()):
        text = open(p, encoding='utf-8', errors='ignore').read() if is_text(p) else ''
        comps, sn, nested, variant_of, root_ui = parse_prefab(text, scripts)
        u = users.get(g, {})
        name = os.path.splitext(os.path.basename(p))[0]
        out.append({
            'path': p, 'guid': g, 'name': name, 'binary': not text,
            'components': dict(comps), 'scripts': dict(sn), 'rootUI': root_ui,
            'variantOf': prefabs.get(variant_of, variant_of) if variant_of else None,
            'nests': sorted({prefabs.get(x, x) for x in nested}),
            'usedInScenes': sorted(x for x in u if x.endswith('.unity')),
            'usedInPrefabs': sorted(x for x in u if x.endswith('.prefab')),
            'usedElsewhere': sorted(x for x in u if not x.endswith(('.unity', '.prefab'))),
            'nameRefs': sorted(set(name_refs.get(name, []))),
            'inResources': '/Resources/' in p,
            'addressable': g in addressables,
            'missingScripts': sum(v for k, v in sn.items() if k.startswith('missing:')),
        })
    json.dump({'project': project, 'scope': a.scope, 'prefabs': out}, open(a.out, 'w', encoding='utf-8'), indent=1)

    folders = collections.Counter(os.path.dirname(x['path']) for x in out)
    print('\nPrefabs by folder:')
    for f, n in sorted(folders.items()):
        print('  %5d  %s' % (n, f))
    print('\nvariants %d   with nested prefabs %d   used only by other prefabs %d   unused %d' % (
        sum(1 for x in out if x['variantOf']), sum(1 for x in out if x['nests']),
        sum(1 for x in out if x['usedInPrefabs'] and not x['usedInScenes'] and not x['usedElsewhere']),
        sum(1 for x in out if not (x['usedInScenes'] or x['usedInPrefabs'] or x['usedElsewhere']))))
    print('named in code/data %d   in Resources %d   addressable %d   missing scripts %d   binary %d' % (
        sum(1 for x in out if x['nameRefs']), sum(1 for x in out if x['inResources']),
        sum(1 for x in out if x['addressable']), sum(1 for x in out if x['missingScripts']),
        sum(1 for x in out if x['binary'])))
    print('wrote ' + a.out)


if __name__ == '__main__':
    main()
