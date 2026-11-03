"""Read-only survey of a Unity project's Assets layout, for planning a reorganisation.

Prints: Unity version; whether an editor has the project open; the Assets tree two levels deep with file counts, sizes
and the main file types; Unity's special folders wherever they are; asmdef files; Build Settings scenes; and every
hard-coded asset path string ("Assets/...") in code, shaders and the --extra folders (tools, docs), grouped by the
top-level folder it points into, so you know how much rewriting a move will need.

    python -I survey_layout.py <ProjectRoot> [--extra DIR ...] [--depth 2] [--json out.json]
"""
import argparse, collections, json, os, re, subprocess, sys

SPECIAL = {'Resources', 'StreamingAssets', 'Plugins', 'Editor', 'Editor Default Resources', 'Gizmos',
           'AddressableAssetsData', 'WebGLTemplates', 'Standard Assets', 'TextMesh Pro'}
CODE = ('.cs', '.shader', '.hlsl', '.cginc', '.compute', '.uss', '.uxml', '.py', '.sh', '.ps1', '.bat', '.md', '.json', '.txt')
SKIP = {'Library', 'Temp', 'Logs', 'obj', '.git', '.vs', '__pycache__', 'node_modules', 'UserSettings', 'Build', 'Builds'}
PATH_RE = re.compile(r'Assets[/\\]{1,2}[A-Za-z0-9_ .\-]+')


def human(n):
    for unit in ('B', 'K', 'M', 'G'):
        if n < 1024:
            return '%.0f%s' % (n, unit)
        n /= 1024
    return '%.1fT' % n


def editor_open(project):
    lock = os.path.join(project, 'Temp', 'UnityLockfile')
    held = False
    if os.path.exists(lock):
        try:
            os.rename(lock, lock)          # Windows: fails while an editor holds the lock
        except OSError:
            held = True
    procs = ''
    try:
        if os.name == 'nt':
            procs = subprocess.run(['wmic', 'process', 'where', "name='Unity.exe'", 'get', 'commandline'],
                                   capture_output=True, text=True, timeout=20).stdout
        else:
            procs = subprocess.run(['ps', '-eo', 'args'], capture_output=True, text=True, timeout=20).stdout
    except Exception:
        pass
    key = os.path.normcase(os.path.abspath(project)).replace('\\', '/').lower()
    running = [l.strip() for l in procs.splitlines() if 'unity' in l.lower() and key in l.lower().replace('\\', '/')
               and 'assetimportworker' not in l.lower()]
    return held, running


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument('project')
    ap.add_argument('--extra', action='append', default=[])
    ap.add_argument('--depth', type=int, default=2)
    ap.add_argument('--json')
    a = ap.parse_args()
    project = os.path.abspath(a.project)
    assets = os.path.join(project, 'Assets')
    if not os.path.isdir(assets):
        sys.exit('no Assets folder in ' + project)
    out = {}

    ver = os.path.join(project, 'ProjectSettings', 'ProjectVersion.txt')
    if os.path.exists(ver):
        out['unity'] = open(ver, encoding='utf-8').readline().split(':', 1)[-1].strip()
    held, running = editor_open(project)
    out['editorOpen'] = bool(held or running)
    print('Unity %s   editor open: %s%s' % (out.get('unity', '?'), 'YES' if out['editorOpen'] else 'no',
                                            ' (lockfile held)' if held else ''))
    for r in running:
        print('  ' + r[:160])

    # Tree with counts.
    stats = collections.defaultdict(lambda: [0, 0, collections.Counter()])
    special, asmdefs = [], []
    for d, dirs, files in os.walk(assets):
        dirs[:] = [x for x in dirs if not x.startswith('.')]
        rel = os.path.relpath(d, project).replace('\\', '/')
        if os.path.basename(d) in SPECIAL and rel != 'Assets':
            special.append(rel)
        parts = rel.split('/')
        for f in files:
            if f.endswith('.meta'):
                continue
            p = os.path.join(d, f)
            size = os.path.getsize(p)
            ext = os.path.splitext(f)[1].lower() or '(none)'
            if ext == '.asmdef':
                asmdefs.append(rel + '/' + f)
            for depth in range(1, min(len(parts), a.depth + 1) + 1):
                key = '/'.join(parts[:depth]) if depth <= len(parts) else rel
                stats[key][0] += 1
                stats[key][1] += size
                stats[key][2][ext] += 1
            if len(parts) == 1:
                key = 'Assets/' + f
                stats[key][0] += 1
                stats[key][1] += size
                stats[key][2][ext] += 1
    print('\nAssets tree (files, size, main types):')
    for key in sorted(stats):
        if key == 'Assets':
            continue
        n, size, types = stats[key]
        indent = '  ' * (key.count('/') - 1)
        print('  %s%-40s %7d %7s  %s' % (indent, key.split('/')[-1], n, human(size),
                                         ' '.join('%s:%d' % t for t in types.most_common(5))))
    out['tree'] = {k: {'files': v[0], 'bytes': v[1], 'types': dict(v[2])} for k, v in stats.items()}

    print('\nSpecial folders (keep them special):')
    for s in sorted(special):
        print('  ' + s)
    out['special'] = sorted(special)
    print('\nAssembly definitions:' + ('' if asmdefs else ' none'))
    for x in asmdefs:
        print('  ' + x)
    out['asmdefs'] = asmdefs

    bs = os.path.join(project, 'ProjectSettings', 'EditorBuildSettings.asset')
    if os.path.exists(bs):
        scenes = re.findall(r'path: (\S+)', open(bs, encoding='utf-8').read())
        out['buildScenes'] = scenes
        print('\nBuild Settings scenes: %d' % len(scenes))
        for s in scenes[:12]:
            print('  ' + s)
        if len(scenes) > 12:
            print('  ...')

    # Hard-coded paths.
    refs = collections.defaultdict(lambda: collections.Counter())
    for root in [assets] + [os.path.abspath(x) for x in a.extra]:
        for d, dirs, files in os.walk(root):
            dirs[:] = [x for x in dirs if x not in SKIP]
            for f in files:
                if not f.endswith(CODE) or f in ('LayoutMover.cs', 'rewrite_paths.py', 'survey_layout.py'):
                    continue
                p = os.path.join(d, f)
                try:
                    text = open(p, encoding='utf-8', errors='ignore').read()
                except OSError:
                    continue
                for mo in PATH_RE.finditer(text):
                    top = re.split(r'[/\\]+', mo.group(0))[1]
                    refs[top][os.path.relpath(p, project if p.startswith(project) else root).replace('\\', '/')] += 1
    print('\nHard-coded "Assets/..." strings, by the folder they point into:')
    for top in sorted(refs, key=lambda t: -sum(refs[t].values())):
        files = refs[top]
        print('  Assets/%-30s %4d refs in %3d files' % (top, sum(files.values()), len(files)))
        for f, n in files.most_common(4):
            print('      %4d  %s' % (n, f))
    out['pathRefs'] = {k: dict(v) for k, v in refs.items()}
    if a.json:
        json.dump(out, open(a.json, 'w', encoding='utf-8'), indent=1)
        print('\nwrote ' + a.json)


if __name__ == '__main__':
    main()
