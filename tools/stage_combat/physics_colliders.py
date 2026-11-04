"""Extract the original 3D physics colliders of PhysicsEnemy users (evidence/physics/SPEC.md sec. 3).

Each PhysicsEnemy / PhysicsLb01 component lists _node entries (_origins: a model transform, _targets: the physics node that
copies it every frame). Node 0 copies its origin's pose; node i > 0 copies its origin's pose relative to origin 0, y set to 0.
For every collider under a node target this writes its shape in that node's frame (the chain of local transforms from the
collider up to the node, the node's own scale included; collider centre and size scaled by it).
Output: Reconstructed/Assets/Resources/StageCombat/physics-colliders.json.
usage: python -I physics_colliders.py <reconstruction root>
"""
import json, math, os, re, sys

root = sys.argv[1]
src = os.path.join(root, 'Reconstructed', 'Assets', 'OriginalGame')
PREFABS = ['Pf_Ene_Lb01.prefab', 'Pf_Ene_Sl01.prefab'] + ['Samples/Prefabs/Reference/Enemy/Pf_Ene_%s.prefab' % m for m in
           ('Bos03', 'Ma01', 'Mb01', 'Mc01', 'Md01', 'Mi01', 'Mj01b', 'Mj01h', 'Mo01', 'Mp01', 'Mp02', 'Mq01')]

def vec(s, key):
    m = re.search(key + r': \{x: ([^,]+), y: ([^,]+), z: ([^,}]+)(?:, w: ([^}]+))?\}', s)
    return tuple(float(v) for v in m.groups() if v is not None) if m else None

def qmul(a, b):
    ax, ay, az, aw = a; bx, by, bz, bw = b
    return (aw * bx + ax * bw + ay * bz - az * by, aw * by - ax * bz + ay * bw + az * bx,
            aw * bz + ax * by - ay * bx + az * bw, aw * bw - ax * bx - ay * by - az * bz)

def qrot(q, v):
    x, y, z, w = q; vx, vy, vz = v
    tx, ty, tz = 2 * (y * vz - z * vy), 2 * (z * vx - x * vz), 2 * (x * vy - y * vx)
    return (vx + w * tx + y * tz - z * ty, vy + w * ty + z * tx - x * tz, vz + w * tz + x * ty - y * tx)

def load(path):
    txt = open(path, encoding='utf-8').read()
    docs = re.split(r'\n--- !u!(\d+) &(-?\d+)[^\n]*', txt)
    objs = {docs[i + 1]: (docs[i], docs[i + 2]) for i in range(1, len(docs), 3)}
    names = {k: re.search(r'm_Name: (.*)', b).group(1) for k, (t, b) in objs.items() if t == '1'}
    tr, by_go = {}, {}
    for k, (t, b) in objs.items():
        if t == '4':
            go = re.search(r'm_GameObject: \{fileID: (-?\d+)', b).group(1)
            tr[k] = dict(go=go, parent=re.search(r'm_Father: \{fileID: (-?\d+)', b).group(1), pos=vec(b, 'm_LocalPosition'),
                         rot=vec(b, 'm_LocalRotation'), scale=vec(b, 'm_LocalScale'), name=names.get(go, '?'))
            by_go[go] = k
    return objs, tr, by_go

def path(tr, k):
    parts = []
    while k in tr:
        parts.append(tr[k]['name']); k = tr[k]['parent']
    return '/'.join(reversed(parts[:-1]))  # relative to the prefab root

def to_node(tr, k, node):
    """Pose of transform k in node's frame (node's own scale applied, not its position/rotation)."""
    pos, rot, scale = (0.0, 0.0, 0.0), (0.0, 0.0, 0.0, 1.0), (1.0, 1.0, 1.0)
    while True:
        t = tr[k]
        if k == node:
            s = t['scale']
            return tuple(p * si for p, si in zip(pos, s)), rot, tuple(a * b for a, b in zip(scale, s))
        p = qrot(t['rot'], tuple(a * b for a, b in zip(pos, t['scale'])))
        pos = tuple(a + b for a, b in zip(p, t['pos'])); rot = qmul(t['rot'], rot)
        scale = tuple(a * b for a, b in zip(scale, t['scale'])); k = t['parent']
        if k not in tr:
            raise ValueError('collider not under its node')

out = []
for rel in PREFABS:
    objs, tr, by_go = load(os.path.join(src, rel))
    model = os.path.basename(rel)[:-7]
    comp = [b for t, b in objs.values() if t == '114' and '  _node:' in b]
    if not comp:
        print('no PhysicsEnemy', model); continue
    pairs = re.findall(r'_origins: \{fileID: (-?\d+)\}\s*\n\s*_targets: \{fileID: (-?\d+)\}', comp[0])
    attack = re.search(r'_attkAttr: \{fileID: (-?\d+)\}', comp[0]).group(1) != '0'
    targets = [t for _, t in pairs]
    nodes = [dict(origin=path(tr, o), target=tr[t]['name'], shapes=[]) for o, t in pairs]
    for k, (t, b) in objs.items():
        if t not in ('135', '65', '136'):
            continue
        go = re.search(r'm_GameObject: \{fileID: (-?\d+)', b).group(1); tk = by_go[go]
        n, a = None, tk
        while a in tr:
            if a in targets:
                n = targets.index(a); break
            a = tr[a]['parent']
        if n is None:
            continue
        pos, rot, scale = to_node(tr, tk, targets[n])
        centre = vec(b, 'm_Center'); trigger = re.search(r'm_IsTrigger: (\d)', b).group(1) == '1'
        c = qrot(rot, tuple(x * s for x, s in zip(centre, scale))); c = tuple(p + q for p, q in zip(pos, c))
        shape = dict(kind={'135': 'sphere', '65': 'box', '136': 'capsule'}[t], trigger=trigger, centre=[round(x, 4) for x in c],
                     rotation=[round(x, 6) for x in rot])
        if t == '135':
            shape['radius'] = float(re.search(r'm_Radius: ([^\n]+)', b).group(1)) * max(abs(x) for x in scale)
        elif t == '65':
            shape['size'] = [round(x * abs(s), 4) for x, s in zip(vec(b, 'm_Size'), scale)]
        else:
            d = int(re.search(r'm_Direction: (\d)', b).group(1))
            other = [abs(scale[i]) for i in range(3) if i != d]
            shape['radius'] = float(re.search(r'm_Radius: ([^\n]+)', b).group(1)) * max(other)
            shape['height'] = float(re.search(r'm_Height: ([^\n]+)', b).group(1)) * abs(scale[d]); shape['direction'] = d
        nodes[n]['shapes'].append(shape)
    out.append(dict(model=model, attack=attack, nodes=nodes))
    print(model, 'attack' if attack else '', [(nd['origin'] or '<root>', nd['target'], len(nd['shapes'])) for nd in nodes])
dst = os.path.join(root, 'Reconstructed', 'Assets', 'Resources', 'StageCombat', 'physics-colliders.json')
json.dump(dict(version=1, source='evidence/physics/SPEC.md', models=out), open(dst, 'w', encoding='utf-8'), indent=1)
print('wrote', dst)
