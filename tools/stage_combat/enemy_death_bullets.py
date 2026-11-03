"""Death and damage bullets of every original prefab, read from the serialized YAML (no game code runs).

Enemies (PawnEnemy and subclasses): _deadBullet (a BulletTemplate), _deadBulletSelecter (a selector), _explosionOffset.
Damage bullets (e.g. Pf_BGObj_tree01b_upper): _damageBullet with its _damage* parameters and the _muz transform path.
Bullets (EnemyBullet prefabs): _HitPoint, _isLockonTarget and _deadBullet ("Regident/<template>").
Output: Assets/Resources/StageCombat/enemy-death-bullets.json, with every named template/selector checked against
enemy-attacks.json. The firing rules themselves are in evidence/death-bullets/SPEC.md.
"""
import glob, json, os, re

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
ORIG = os.path.join(BASE, 'Reconstructed', 'Assets', 'OriginalGame')
ATTACKS = os.path.join(BASE, 'Reconstructed', 'Assets', 'Resources', 'StageCombat', 'enemy-attacks.json')
OUT = os.path.join(BASE, 'Reconstructed', 'Assets', 'Resources', 'StageCombat', 'enemy-death-bullets.json')


def docs(path):
    text = open(path, encoding='utf-8', errors='replace').read()
    out = {}
    for d in re.split(r'\n--- !u!', text):
        m = re.match(r'(\d+) &(-?\d+)', d)
        if m:
            out[m.group(2)] = (m.group(1), d)
    return out


def field(d, name):
    m = re.search(r'\n  %s: ?(.*)' % re.escape(name), d)
    return m.group(1).strip() if m else None


def vec(s):
    m = re.match(r'\{x: ([^,]+), y: ([^,]+), z: ([^}]+)\}', s or '')
    return {'x': float(m.group(1)), 'y': float(m.group(2)), 'z': float(m.group(3))} if m else None


def transform_path(ds, fid):
    names = []
    while fid and fid != '0' and fid in ds:
        cls, d = ds[fid]
        g = re.search(r'm_GameObject: \{fileID: (-?\d+)', d)
        go = ds.get(g.group(1)) if g else None
        n = re.search(r'm_Name: (.*)', go[1]) if go else None
        names.insert(0, n.group(1).strip() if n else '?')
        p = re.search(r'm_Father: \{fileID: (-?\d+)', d)
        fid = p.group(1) if p else None
    return '/'.join(names[1:])  # relative to the prefab root


def main():
    attacks = json.load(open(ATTACKS, encoding='utf-8'))
    patterns = {p['name'] for p in attacks['patterns']}
    selectors = {s['name'] for s in attacks['selectors']}
    # Prefer the top-level OriginalGame prefab over the Samples/Reference copy of the same name.
    files = {}
    for p in sorted(glob.glob(os.path.join(ORIG, '**', '*.prefab'), recursive=True), key=lambda p: ('Samples' in p, p)):
        files.setdefault(os.path.splitext(os.path.basename(p))[0], p)
    enemies, damage, bullets, problems = [], [], [], []
    for name, path in sorted(files.items()):
        text = open(path, encoding='utf-8', errors='replace').read()
        if '_deadBullet' not in text and '_damageBullet' not in text:
            continue
        ds = docs(path)
        for fid, (cls, d) in ds.items():
            if cls != '114':
                continue
            dead, sel, dmg = field(d, '_deadBullet'), field(d, '_deadBulletSelecter'), field(d, '_damageBullet')
            if field(d, '_bulletRender') is not None and dead:  # EnemyBullet prefabs (enemies have _HitPoint too)
                tmpl = dead.split('/')[-1]
                bullets.append({'model': name, 'hitPoint': float(field(d, '_HitPoint')), 'lockOn': field(d, '_isLockonTarget') == '1',
                                'deadBullet': tmpl, 'deadBulletPath': dead})
                if tmpl not in patterns:
                    problems.append('%s: bullet death template %s not extracted' % (name, dead))
            elif dead or sel:
                enemies.append({'model': name, 'deadBullet': dead or '', 'deadSelector': sel or '',
                                'explosionOffset': vec(field(d, '_explosionOffset')) or {'x': 0, 'y': 0, 'z': 0}})
                if dead and dead not in patterns:
                    problems.append('%s: death template %s not extracted' % (name, dead))
                if sel and sel not in selectors:
                    problems.append('%s: death selector %s not extracted' % (name, sel))
            if dmg:
                muz = re.search(r'\n  _muz: \{fileID: (-?\d+)', d)
                damage.append({'model': name, 'damageBullet': dmg, 'expOffsetY': float(field(d, '_damageExpOffsetY') or 0),
                               'ways': int(field(d, '_damageShotWays') or 0), 'count': int(field(d, '_damageShotCount') or 0),
                               'muzzle': transform_path(ds, muz.group(1)) if muz else ''})
                if dmg not in patterns:
                    problems.append('%s: damage template %s not extracted' % (name, dmg))
    out = {'version': 1, 'note': 'tools/stage_combat/enemy_death_bullets.py; rules in evidence/death-bullets/SPEC.md',
           'enemies': enemies, 'damage': damage, 'bullets': bullets, 'problems': problems}
    json.dump(out, open(OUT, 'w', encoding='utf-8'), indent=1)
    print(len(enemies), 'enemies,', len(damage), 'damage,', len(bullets), 'bullets; problems:', problems)
    for e in enemies + damage + bullets:
        print(' ', e)


if __name__ == '__main__':
    main()
