"""Rewrite old asset paths to new ones after LayoutMover.Run, from its manifest (moves.json).

Scans the project's Assets (scripts, shaders, text data) plus any --extra folders (tools, docs, skills) and replaces
every old path with its new one: longest paths first, whole names only (Assets/Game does not match Assets/GameArt),
in '/' form and the escaped '\\\\' / '\\' forms used in C# and Python strings. Line endings and BOMs are kept. Each
changed file is copied to --backup (same relative path) before it is written. The plan, manifest and LayoutMover.cs are
skipped: their old paths are the undo map.

Then it reports leftovers: mentions of dissolved folders (moved-from folders that no longer exist) it could not map,
such as joined path pieces, bare-name tests (Contains("Imported")) or folders a generator creates. Fix those by hand.

    python -I rewrite_paths.py --project <ProjectRoot> --manifest moves.json [--extra DIR ...]
                               [--backup DIR] [--dry-run] [--ext .cs --ext .shader ...]
"""
import argparse, json, os, re, shutil, sys

DEFAULT_EXT = ('.cs', '.shader', '.hlsl', '.cginc', '.compute', '.uss', '.uxml', '.py', '.sh', '.ps1', '.bat', '.cmd',
               '.md', '.txt', '.json', '.yaml', '.yml', '.xml', '.js', '.ts')
SKIP_DIRS = {'Library', 'Temp', 'Logs', 'obj', 'Build', 'Builds', '.git', '.vs', '__pycache__', 'node_modules', 'UserSettings'}
SKIP_FILES = ('LayoutMover.cs', 'layout-plan.json', 'moves.json', 'rewrite_paths.py')


def norm(p):
    return p.replace('\\', '/')


def walk(root, exts):
    for d, dirs, files in os.walk(root):
        dirs[:] = [x for x in dirs if x not in SKIP_DIRS]
        for f in files:
            p = norm(os.path.join(d, f))
            # This skill's own self-test fixture deliberately holds old paths.
            if f.endswith(exts) and f not in SKIP_FILES and '/unity-project-layout/tests/' not in p:
                yield p


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument('--project', required=True)
    ap.add_argument('--manifest', required=True)
    ap.add_argument('--extra', action='append', default=[], help='more folders to rewrite (tools, docs, skills)')
    ap.add_argument('--backup', help='copy each changed file here first (default <project>/../layout-backup)')
    ap.add_argument('--ext', action='append', help='file extensions to scan (default: code, shaders, text)')
    ap.add_argument('--exclude', action='append', default=[], help='skip files whose path contains this text')
    ap.add_argument('--dry-run', action='store_true')
    a = ap.parse_args()

    project = norm(os.path.abspath(a.project))
    exts = tuple(a.ext) if a.ext else DEFAULT_EXT
    backup = norm(os.path.abspath(a.backup or os.path.join(project, '..', 'layout-backup')))
    m = json.load(open(a.manifest, encoding='utf-8'))
    if m.get('errors'):
        sys.exit('the manifest records move errors; resolve them first: %s' % m['errors'][:3])

    pairs = {}
    for e in m['steps'] + m['assets']:
        if e['from'] != e['to']:
            pairs[e['from'].rstrip('/')] = e['to'].rstrip('/')
    variants = {}
    for old, new in pairs.items():
        variants[old] = new
        variants[old.replace('/', '\\\\')] = new.replace('/', '\\\\')
        variants[old.replace('/', '\\')] = new.replace('/', '\\')
    keys = sorted(variants, key=len, reverse=True)
    pattern = re.compile('|'.join(re.escape(k) + r'(?![A-Za-z0-9_\-])' for k in keys)) if keys else None
    # Folders that were moved away and do not exist any more: mentions of them that remain are leftovers.
    gone = sorted({s['from'] for s in m['steps'] if not os.path.exists(os.path.join(project, s['from']))}
                  | set(m.get('removed', [])), key=len, reverse=True)
    gone = [g for g in gone if os.path.splitext(g)[1] == '']
    gone_re = re.compile('|'.join(re.escape(g) + r'(?![A-Za-z0-9_\-])' for g in gone)) if gone else None
    # Their last names as a whole quoted string too (os.path.join(ASSETS, 'Imported'), Contains("Imported")): the
    # forms that broke code after a real move. Unquoted words in comments or "Name/..." Resources paths are not paths
    # to the moved folder, so they are not reported. Names the new layout also uses are skipped.
    common = {'Assets', 'Editor', 'Scripts', 'Scenes', 'Prefabs', 'Materials', 'Textures', 'Models', 'Animations',
              'Audio', 'Shaders', 'Settings', 'Data', 'Runtime', 'Resources', 'Plugins', 'Art', 'UI', 'Fonts'}
    bare = sorted({os.path.basename(g) for g in gone} - common)
    bare_re = re.compile(r'''(["'])(''' + '|'.join(re.escape(b) for b in bare) + r')\1') if bare else None

    roots = [project + '/Assets'] + [norm(os.path.abspath(x)) for x in a.extra]
    files = sorted({f for r in roots for f in walk(r, exts) if not any(x in f for x in a.exclude)})
    changed = total = 0
    leftovers = []
    for path in files:
        try:
            with open(path, encoding='utf-8', newline='') as fh:
                text = fh.read()
        except (UnicodeDecodeError, OSError):
            continue
        new, n = pattern.subn(lambda mo: variants[mo.group(0)], text) if pattern and 'Assets' in text else (text, 0)
        for rx in (gone_re, bare_re):
            if not rx:
                continue
            for mo in rx.finditer(new):
                line = new.count('\n', 0, mo.start()) + 1
                entry = '%s:%d  %s' % (path, line, new.splitlines()[line - 1].strip()[:160])
                if entry not in leftovers:
                    leftovers.append(entry)
        if n == 0:
            continue
        changed += 1
        total += n
        print('%5d  %s' % (n, path))
        if a.dry_run:
            continue
        rel = path[len(project) + 1:] if path.startswith(project + '/') else re.sub(r'^[A-Za-z]:/', '', path).lstrip('/')
        dest = os.path.join(backup, rel)
        os.makedirs(os.path.dirname(dest), exist_ok=True)
        if not os.path.exists(dest):
            shutil.copy2(path, dest)
        with open(path, 'w', encoding='utf-8', newline='') as fh:
            fh.write(new)
    print('%s %d replacements in %d files (scanned %d)' % ('would make' if a.dry_run else 'made', total, changed, len(files)))
    if not a.dry_run and changed:
        print('backups in ' + backup)
    print('%d mentions of dissolved folders left (check by hand):' % len(leftovers))
    for l in leftovers:
        print('  ' + l)


if __name__ == '__main__':
    main()
