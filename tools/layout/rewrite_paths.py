"""Rewrite asset paths after the project layout change (Editor/ReconstructionLayout.Run).

Reads verification/layout/moves.json (every moved folder and asset, old -> new) and replaces the old paths in the
remaster's code, shaders (including the recovered shaders' absolute #includes inside OriginalGame), the tools and the
Truxton skills. A path only matches as a whole name (Assets/Truxton does not match Assets/TruxtonImported); longer
paths win. Every changed file is copied to backups/before-layout first.

    python -I tools/layout/rewrite_paths.py [--dry-run]
"""
import json, os, re, shutil, sys

ROOT = 'D:/games/TruxtonExRecon'
PROJECT = ROOT + '/Reconstructed'
BACKUP = ROOT + '/backups/before-layout'
SKILLS = os.path.expanduser('~/.claude/skills')
TEXT = ('.cs', '.shader', '.hlsl', '.cginc', '.py', '.sh', '.ps1', '.md', '.json', '.txt')


def targets():
    for base, exts in ((PROJECT + '/Assets/Scripts', ('.cs',)), (PROJECT + '/Assets/Shaders', ('.shader', '.hlsl')),
                       (PROJECT + '/Assets/OriginalGame', ('.shader', '.hlsl', '.cginc')), (ROOT + '/tools', TEXT)):
        for d, _, files in os.walk(base):
            if 'skill-validation-deps' in d or 'typetree-deps' in d:
                continue
            for f in files:
                if f.endswith(exts):
                    yield os.path.join(d, f).replace('\\', '/')
    if os.path.isdir(SKILLS):
        for name in os.listdir(SKILLS):
            if name.startswith('truxton-'):
                for d, _, files in os.walk(os.path.join(SKILLS, name)):
                    for f in files:
                        if f.endswith(TEXT):
                            yield os.path.join(d, f).replace('\\', '/')


def main():
    dry = '--dry-run' in sys.argv
    moves = json.load(open(ROOT + '/verification/layout/moves.json', encoding='utf-8'))
    if moves['errors']:
        sys.exit('moves.json has errors; fix the move first: %s' % moves['errors'][:3])
    pairs = {}
    for e in moves['steps'] + moves['assets']:
        pairs[e['from']] = e['to']
    # The folders the layout dissolved: anything else still pointing at them is reported, not guessed.
    gone = ['Assets/Reconstruction', 'Assets/TruxtonImported', 'Assets/TruxtonGameplay', 'Assets/OriginalRecovered']
    olds = sorted(pairs, key=len, reverse=True)
    variants = {}
    for o in olds:
        variants[o] = pairs[o]
        variants[o.replace('/', '\\\\')] = pairs[o].replace('/', '\\\\')   # "Assets\\Foo" in C#/Python strings
        variants[o.replace('/', '\\')] = pairs[o].replace('/', '\\')
    keys = sorted(variants, key=len, reverse=True)
    pattern = re.compile('|'.join(re.escape(k) + r'(?![A-Za-z0-9_\-])' for k in keys))
    changed = total = 0
    leftovers = []
    for path in sorted(set(targets())):
        if '/tools/layout/' in path or path.endswith('/ReconstructionLayout.cs'):
            continue   # the layout's own move list and undo map keep the old paths on purpose
        try:
            text = open(path, encoding='utf-8', newline='').read()   # keep CRLF files as they are
        except (UnicodeDecodeError, OSError):
            continue
        if 'Assets' not in text:
            continue
        new, n = pattern.subn(lambda m: variants[m.group(0)], text)
        for g in gone:
            for m in re.finditer(re.escape(g) + r'(?![A-Za-z0-9_\-])', new):
                line = new.count('\n', 0, m.start()) + 1
                leftovers.append('%s:%d %s' % (path, line, new.splitlines()[line - 1].strip()[:140]))
        if n == 0:
            continue
        changed += 1
        total += n
        print('%4d  %s' % (n, path))
        if not dry:
            rel = path.replace(ROOT + '/', '').replace(SKILLS.replace('\\', '/') + '/', 'skills/')
            if rel.startswith('C:') or rel.startswith('/'):
                rel = 'skills/' + os.path.basename(path)
            dest = os.path.join(BACKUP, rel)
            os.makedirs(os.path.dirname(dest), exist_ok=True)
            if not os.path.exists(dest):
                shutil.copy2(path, dest)
            open(path, 'w', encoding='utf-8', newline='').write(new)
    print('%s %d replacements in %d files' % ('would make' if dry else 'made', total, changed))
    print('%d references to dissolved folders left (fix by hand):' % len(leftovers))
    for l in leftovers:
        print('  ' + l)


if __name__ == '__main__':
    main()
