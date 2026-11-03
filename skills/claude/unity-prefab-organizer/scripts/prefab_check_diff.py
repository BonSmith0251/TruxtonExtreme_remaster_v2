"""Compare two PrefabCheck snapshots (before and after a move) by GUID.

Reports prefabs or scenes that disappeared, and any prefab whose type, variant base, missing-script count, nested
instance count, missing nested instances or child count changed, and any scene whose instance or missing counts
changed. Moves are expected to change paths only. Exit code 0 when nothing but paths changed.

    python -I prefab_check_diff.py before.json after.json
"""
import json, sys


def main():
    if len(sys.argv) != 3:
        sys.exit(__doc__)
    b, a = (json.load(open(p, encoding='utf-8')) for p in sys.argv[1:])
    problems, moved = [], 0
    for kind, keys in (('prefabs', ('type', 'baseGuid', 'missingScripts', 'nested', 'nestedMissing', 'children')),
                       ('scenes', ('instances', 'instancesMissing', 'missingScripts'))):
        before = {r['guid']: r for r in b[kind]}
        after = {r['guid']: r for r in a[kind]}
        for g, r in before.items():
            if g not in after:
                problems.append('%s gone: %s' % (kind[:-1], r['path']))
                continue
            n = after[g]
            moved += r['path'] != n['path']
            for k in keys:
                if (r.get(k) or '') != (n.get(k) or ''):
                    problems.append('%s %s: %s %s -> %s' % (kind[:-1], n['path'], k, r.get(k), n.get(k)))
        for g in after.keys() - before.keys():
            problems.append('%s new: %s' % (kind[:-1], after[g]['path']))
    for e in a.get('errors', []):
        problems.append('error after: ' + e)
    print('%d prefabs, %d scenes compared; %d moved; %d problems' % (len(b['prefabs']), len(b['scenes']), moved, len(problems)))
    for p in problems:
        print('  ' + p)
    sys.exit(1 if problems else 0)


if __name__ == '__main__':
    main()
