"""Extract enemy hit shapes (collision circles) from the original TATSUJIN EXTREME prefabs.

Reads the Unity YAML prefabs exported under Reconstructed/Assets/OriginalGame as text (Unity is not run) and
writes Reconstructed/Assets/Resources/StageCombat/enemy-hitshapes.json (schema of Truxton/round1-enemy-hitshapes.json,
plus optional parts/sources/excluded/warnings per model and an 'unresolved' list) for every model of
StageEnemies/BG01..BG08.json and the BG03 reference, then validates against that reference into
evidence/stage-combat/enemy-hitshapes-validation.json.

Run: C:\\Python311\\python.exe -I tools\\stage_combat\\enemy_hitshapes.py
"""
import glob
import json
import math
import os
import re
import sys

BASE = r'D:\games\TruxtonExRecon'
RECON = os.path.join(BASE, 'Reconstructed')
ORIG = os.path.join(RECON, 'Assets', 'OriginalGame')
REFERENCE = os.path.join(RECON, 'Assets', 'Resources', 'Truxton', 'round1-enemy-hitshapes.json')
STAGES = os.path.join(RECON, 'Assets', 'Resources', 'StageEnemies')
OUT = os.path.join(RECON, 'Assets', 'Resources', 'StageCombat', 'enemy-hitshapes.json')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-combat', 'enemy-hitshapes-validation.json')

# ---------------------------------------------------------------- minimal Unity YAML reader

def _split_flow(s):
    parts, depth, cur, q = [], 0, '', None
    for ch in s:
        if q:
            cur += ch
            if ch == q:
                q = None
            continue
        if ch in '"\'':
            q = ch
        if ch in '{[':
            depth += 1
        elif ch in '}]':
            depth -= 1
        if ch == ',' and depth == 0:
            parts.append(cur)
            cur = ''
        else:
            cur += ch
    if cur.strip():
        parts.append(cur)
    return [p.strip() for p in parts]


def parse_scalar(s):
    s = s.strip()
    if s.startswith('{') and s.endswith('}'):
        d = {}
        for p in _split_flow(s[1:-1]):
            k, _, v = p.partition(':')
            d[k.strip()] = parse_scalar(v)
        return d
    if s.startswith('[') and s.endswith(']'):
        return [parse_scalar(p) for p in _split_flow(s[1:-1])]
    if len(s) >= 2 and s[0] == s[-1] and s[0] in '"\'':
        return s[1:-1]
    if re.fullmatch(r'[-+]?\d+', s):
        return int(s)
    if re.fullmatch(r'[-+]?(\d+\.?\d*|\.\d+)([eE][-+]?\d+)?|[-+]?(Infinity|NaN)', s):
        return float(s.replace('Infinity', 'inf'))
    return s


def _ind(line):
    return len(line) - len(line.lstrip(' '))


def _keysplit(c):
    m = re.match(r'^([^\s:{\[][^:]*?):(?:\s+(.*))?$', c)
    if not m:
        return None, None
    return m.group(1), (m.group(2) or '')


def _parse_block(lines, i, ind):
    if lines[i].lstrip().startswith('- ') or lines[i].strip() == '-':
        return _parse_seq(lines, i, ind)
    return _parse_map(lines, i, ind)


def _parse_map(lines, i, ind):
    d = {}
    n = len(lines)
    while i < n:
        line = lines[i]
        if not line.strip():
            i += 1
            continue
        li = _ind(line)
        c = line.strip()
        if li != ind or c.startswith('- ') or c == '-':
            break
        k, rest = _keysplit(c)
        if k is None:
            i += 1
            continue
        i += 1
        if rest == '':
            if i < n and _ind(lines[i]) > ind:
                v, i = _parse_block(lines, i, _ind(lines[i]))
            elif i < n and _ind(lines[i]) == ind and (lines[i].strip().startswith('- ') or lines[i].strip() == '-'):
                v, i = _parse_seq(lines, i, ind)
            else:
                v = None
        else:
            while i < n and _ind(lines[i]) > ind and lines[i].strip():  # wrapped scalar
                rest += ' ' + lines[i].strip()
                i += 1
            v = parse_scalar(rest)
        d[k] = v
    return d, i


def _parse_seq(lines, i, ind):
    out = []
    n = len(lines)
    while i < n:
        line = lines[i]
        c = line.strip()
        if _ind(line) != ind or not (c.startswith('- ') or c == '-'):
            break
        body = c[2:] if c.startswith('- ') else ''
        k, rest = _keysplit(body)
        if body and k is not None and not body.startswith('{'):
            sub = [' ' * (ind + 2) + body]
            j = i + 1
            while j < n and _ind(lines[j]) > ind:
                sub.append(lines[j])
                j += 1
            v, _ = _parse_map(sub, 0, ind + 2)
            out.append(v)
            i = j
        else:
            i += 1
            while i < n and _ind(lines[i]) > ind and lines[i].strip():
                body += ' ' + lines[i].strip()
                i += 1
            out.append(parse_scalar(body) if body else None)
    return out, i


DOC_RE = re.compile(r'^--- !u!(\d+) &(-?\d+)(?: stripped)?\s*$')


def read_unity_yaml(path):
    docs = {}
    cur = None
    with open(path, encoding='utf-8', errors='replace') as f:
        for line in f:
            line = line.rstrip('\r\n')
            m = DOC_RE.match(line)
            if m:
                cur = [int(m.group(1)), int(m.group(2)), []]
                docs[cur[1]] = cur
                continue
            if cur is not None and not line.startswith('%'):
                cur[2].append(line)
    out = {}
    for fid, (cid, _, lines) in docs.items():
        if not lines:
            continue
        top = lines[0].rstrip(':')
        body, _ = _parse_map(lines[1:], 0, 2) if len(lines) > 1 else ({}, 0)
        body['_classID'] = cid
        body['_typeName'] = top
        body['_fid'] = fid
        out[fid] = body
    return out

# ---------------------------------------------------------------- script class names

SCRIPT_GUID = 'e1f38f7444bde25d3daf9193fd376658'  # InGame.Kernel / KANAI assemblies script guid in these exports
_script_names = None


def script_names():
    """fileID -> full class name, using the MD4 rule from tools/common/script_fileid.py."""
    global _script_names
    if _script_names is None:
        sys.path.insert(0, os.path.join(BASE, 'tools', 'common'))
        src = open(os.path.join(BASE, 'tools', 'common', 'script_fileid.py'), encoding='utf-8').read()
        ns = {}
        exec(compile(src.split('want = set(')[0], 'script_fileid', 'exec'), ns)
        _script_names = {}
        for line in open(os.path.join(BASE, 'code', 'types.jsonl'), encoding='utf-8'):
            t = json.loads(line)
            full = t['type']
            if '/' in full or '<' in full:
                continue
            nsp, _, name = full.rpartition('.')
            _script_names[ns['file_id'](nsp, name)] = (full, t['baseType'], t['assembly'])
    return _script_names

# ---------------------------------------------------------------- prefab model

_prefab_index = None


def find_prefab(name):
    global _prefab_index
    if _prefab_index is None:
        _prefab_index = {}
        for p in glob.glob(os.path.join(ORIG, '**', '*.prefab'), recursive=True):
            _prefab_index.setdefault(os.path.splitext(os.path.basename(p))[0], []).append(p)
    hits = _prefab_index.get(name, [])
    return hits[0] if len(hits) == 1 else (hits or None)


def fid(ref):
    return ref.get('fileID', 0) if isinstance(ref, dict) else 0


class Prefab:
    def __init__(self, path):
        self.path_ = path
        self.docs = read_unity_yaml(path)
        self.names = script_names()
        self.go_tr = {}
        for d in self.docs.values():
            if d['_typeName'] in ('Transform', 'RectTransform'):
                self.go_tr[fid(d.get('m_GameObject'))] = d
            if d['_typeName'] == 'MonoBehaviour':
                s = d.get('m_Script') or {}
                info = self.names.get(s.get('fileID'))
                d['_cls'] = info[0] if info else 'script:%s' % s.get('fileID')

    def monos(self):
        return [d for d in self.docs.values() if d['_typeName'] == 'MonoBehaviour']

    def pawns(self):
        """HybridCollisions-derived owners: carry a _collisions list and a _HitPoint."""
        return [d for d in self.monos() if '_HitPoint' in d and isinstance(d.get('_collisions'), list)]

    def collision_models(self):
        return [(d['_fid'], d) for d in self.monos() if '_shapeType' in d]

    def go(self, comp):
        return self.docs.get(fid(comp.get('m_GameObject')))

    def goname(self, comp):
        g = self.go(comp)
        return g.get('m_Name') if g else None

    def goname_t(self, t):
        g = self.docs.get(fid(t.get('m_GameObject')))
        return g.get('m_Name') if g else None

    def tr_of(self, comp):
        return self.go_tr.get(fid(comp.get('m_GameObject')))

    def chain(self, comp, stop=None):
        """Transforms from the component's own up to the root (inclusive), or up to `stop` (exclusive)."""
        out = []
        t = self.tr_of(comp)
        while t is not None and t is not stop:
            out.append(t)
            t = self.docs.get(fid(t.get('m_Father')))
        return out

    def path(self, comp, stop=None):
        return '/'.join(reversed([self.goname_t(t) or '?' for t in self.chain(comp, stop)]))

    def active_chain(self, comp):
        return all((self.docs.get(fid(t.get('m_GameObject'))) or {}).get('m_IsActive', 1) == 1 for t in self.chain(comp))

# ---------------------------------------------------------------- transforms

def qmul(a, b):
    ax, ay, az, aw = a
    bx, by, bz, bw = b
    return (aw * bx + ax * bw + ay * bz - az * by,
            aw * by - ax * bz + ay * bw + az * bx,
            aw * bz + ax * by - ay * bx + az * bw,
            aw * bw - ax * bx - ay * by - az * bz)


def qrot(q, v):
    x, y, z, w = q
    vx, vy, vz = v
    # v' = v + 2w(q x v) + 2 q x (q x v)
    cx, cy, cz = y * vz - z * vy, z * vx - x * vz, x * vy - y * vx
    ccx, ccy, ccz = y * cz - z * cy, z * cx - x * cz, x * cy - y * cx
    return (vx + 2 * (w * cx + ccx), vy + 2 * (w * cy + ccy), vz + 2 * (w * cz + ccz))


def _v(d, default=0.0):
    d = d or {}
    return (float(d.get('x', default)), float(d.get('y', default)), float(d.get('z', default)))


def _q(d):
    d = d or {}
    return (float(d.get('x', 0)), float(d.get('y', 0)), float(d.get('z', 0)), float(d.get('w', 1)))


def world_of(chain):
    """chain = [node, parent, ..., top]; returns (pos, rot, scale) of node in top's parent frame
    (Unity TRS, scale treated per-axis: lossy scale = product, exact while rotations are about Y or identity)."""
    pos, rot, scl = (0.0, 0.0, 0.0), (0.0, 0.0, 0.0, 1.0), (1.0, 1.0, 1.0)
    for t in reversed(chain):
        lp, lr, ls = _v(t.get('m_LocalPosition')), _q(t.get('m_LocalRotation')), _v(t.get('m_LocalScale'), 1.0)
        sp = (lp[0] * scl[0], lp[1] * scl[1], lp[2] * scl[2])
        rp = qrot(rot, sp)
        pos = (pos[0] + rp[0], pos[1] + rp[1], pos[2] + rp[2])
        rot = qmul(rot, lr)
        scl = (scl[0] * ls[0], scl[1] * ls[1], scl[2] * ls[2])
    return pos, rot, scl


def yaw_deg(q):
    x, y, z, w = q
    return math.degrees(math.atan2(2 * (w * y + x * z), 1 - 2 * (y * y + x * x)))


def is_identity_rot(q, eps=1e-4):
    return abs(abs(q[3]) - 1) < eps


# ---------------------------------------------------------------- shapes -> circles

SHAPE_NAMES = {0: 'None', 1: 'Circle', 2: 'Box', 3: 'Polygon', 4: 'Edge', 5: 'Capsule', 6: 'CircleNR', 7: 'BoxNR'}
SIMPLE_CALC_RADIUS = 1.61   # PawnEnemy._isSimpleCalc: single circle, radius scaled (matches all 5 simpleCalc reference models)
CAPSULE_STEP = 1.5          # max spacing between consecutive circle centres = 1.5 x half-width
POLYGON_FACTOR = 0.8        # polygon -> one circle at the vertex centroid, 0.8 x farthest vertex distance


def strip_circles(cx, cz, ax, az, box):
    """Capsule / box with half extents (ax along X, az along Z) -> circles along the long axis.
    Centres run from -(long-short) to +(long-short) with spacing <= CAPSULE_STEP*short; capsule radius = short,
    box radius = covering radius of each cell sqrt(short^2 + (spacing/2)^2); a square box -> one equal-area circle."""
    if abs(ax - az) < 1e-9:
        if box:
            return [(cx, cz, 2.0 * ax / math.sqrt(math.pi))]
        return [(cx, cz, ax)]
    long_, short = (ax, az) if ax > az else (az, ax)
    span = 2.0 * (long_ - short)
    gaps = max(1, math.ceil(span / (CAPSULE_STEP * short) - 1e-9))
    step = span / gaps
    r = math.sqrt(short * short + (step / 2) ** 2) if box else short
    out = []
    for i in range(gaps + 1):
        o = -(long_ - short) + i * step
        out.append((cx + o, cz, r) if ax > az else (cx, cz + o, r))
    return out


POLYGON_COMPACT_ASPECT = 2.0  # Md01 wing (reference) has bbox aspect 2.0 -> one circle


def _clip_slab(poly, axis, lo, hi):
    """Sutherland-Hodgman clip of a polygon [(x,z)] to lo <= p[axis] <= hi."""
    def clip(pts, keep, inter):
        out = []
        for k in range(len(pts)):
            a, b = pts[k - 1], pts[k]
            ia, ib = keep(a), keep(b)
            if ib:
                if not ia:
                    out.append(inter(a, b))
                out.append(b)
            elif ia:
                out.append(inter(a, b))
        return out

    def at(v):
        def f(a, b):
            t = (v - a[axis]) / (b[axis] - a[axis])
            return (a[0] + t * (b[0] - a[0]), a[1] + t * (b[1] - a[1]))
        return f
    pts = clip(poly, lambda p: p[axis] >= lo - 1e-9, at(lo))
    return clip(pts, lambda p: p[axis] <= hi + 1e-9, at(hi)) if pts else []


def polygon_circles(verts):
    """verts in the node's scaled local frame -> (circles, method)."""
    verts = [v for i, v in enumerate(verts) if abs(v[0] - verts[i - 1][0]) > 1e-9 or abs(v[1] - verts[i - 1][1]) > 1e-9] or verts
    xs, zs = [v[0] for v in verts], [v[1] for v in verts]
    w, h = max(xs) - min(xs), max(zs) - min(zs)
    long_, short = max(w, h), min(w, h)
    if short <= 1e-9 or long_ / short <= POLYGON_COMPACT_ASPECT + 1e-9:
        mx, mz = sum(xs) / len(xs), sum(zs) / len(zs)
        r = max(math.hypot(x - mx, z - mz) for x, z in verts) * POLYGON_FACTOR
        return [(mx, mz, r)], 'polygon-compact'
    axis = 0 if w >= h else 1
    lo = min(xs) if axis == 0 else min(zs)
    n = len(strip_circles(0, 0, long_ / 2, short / 2, box=True))
    step = long_ / n
    out = []
    for k in range(n):
        piece = _clip_slab(verts, axis, lo + k * step, lo + (k + 1) * step)
        if len(piece) < 3:
            continue
        px, pz = [p[0] for p in piece], [p[1] for p in piece]
        cx, cz = (min(px) + max(px)) / 2, (min(pz) + max(pz)) / 2
        out.append((cx, cz, max(math.hypot(x - cx, z - cz) for x, z in piece)))
    return out, 'polygon-sliced'


def shape_local_circles(model, sx, sz, simple):
    """-> (circles in the node's local scaled frame [(x,z,r)], method, problem)"""
    st = int(model.get('_shapeType') or 0)
    pts = [(float(p.get('x', 0)), float(p.get('y', 0))) for p in (model.get('_points') or []) if isinstance(p, dict)]
    k = SIMPLE_CALC_RADIUS if simple else 1.0
    if st in (1, 6):
        if not pts:
            return [], None, 'circle without _points'
        return [(0.0, 0.0, pts[0][0] * k * max(sx, sz))], 'circle', None
    if st in (2, 7, 5):
        if not pts:
            return [], None, '%s without _points' % SHAPE_NAMES[st]
        box = st != 5
        return strip_circles(0.0, 0.0, pts[0][0] * k * sx, pts[0][1] * k * sz, box), ('box' if box else 'capsule'), None
    if st == 3:
        if len(pts) < 3:
            return [], None, 'polygon with %d points' % len(pts)
        c, method = polygon_circles([(x * k * sx, z * k * sz) for x, z in pts])
        return c, method, None
    return [], None, 'unsupported shape %s' % SHAPE_NAMES.get(st, st)


ATTRIBUTE_FLAGS = [(1, 'NoLockOn'), (4, 'LaserBlock'), (16, 'NoDamage'), (32, 'NoHitBullet'), (64, 'NoHitSubject'),
                   (128, 'NoClip'), (1024, 'OnlyHitBlue'), (2048, 'OnlyHitGreen'), (4096, 'OnlyHitRed'),
                   (8192, 'OnlyHitGold'), (16384, 'OnlyHitSilver'), (32768, 'OnlyHitBlack'), (65536, 'OnlyHitBomb'),
                   (131072, 'OnlyHitBoost'), (262144, 'OnlyHitPurple'), (1048576, 'OnlyHitPlayer')]
SUBJECTS = {0: 'All', 1: 'OnlyBullet', 2: 'OnlyBody'}
HIT_MODEL_CLASS = 'InGame.Kernel.Enemy.EnemyCollisionModel'


def attr_names(a):
    a = int(a or 0)
    return [n for b, n in ATTRIBUTE_FLAGS if a & b]


def rnd(v):
    v = round(v, 3)
    return 0.0 if v == 0 else v


def go_path(pf, go_fid):
    t = pf.go_tr.get(go_fid)
    out = []
    while t is not None:
        out.append(pf.goname_t(t) or '?')
        t = pf.docs.get(fid(t.get('m_Father')))
    return '/'.join(reversed(out)) if out else None

# ---------------------------------------------------------------- per model


def extract_model(name, rotate=True):
    found = find_prefab(name)
    if not isinstance(found, str):
        return None, {'model': name, 'reason': 'prefab not found' if not found else 'ambiguous prefab: %s' % found}
    pf = Prefab(found)
    roots = [d for d in pf.docs.values() if d['_typeName'] == 'Transform' and fid(d.get('m_Father')) == 0]
    pawns = pf.pawns()
    root_pawns = [p for p in pawns if roots and pf.tr_of(p) is roots[0]]
    prefab_rel = os.path.relpath(found, RECON).replace('\\', '/')
    if len(roots) != 1 or not root_pawns:
        return None, {'model': name, 'prefab': prefab_rel,
                      'reason': 'no HybridCollisions owner (PawnEnemy) on the single prefab root'}
    pawn = root_pawns[0]
    root_t = pf.tr_of(pawn)
    simple = int(pawn.get('_isSimpleCalc') or 0) == 1
    listed = [fid(r) for r in pawn.get('_collisions') or []]
    entry = {'model': name, 'simpleCalc': simple, 'circles': []}
    sources, excluded, warnings, walls = [], [], [], []
    by_model_id = {}
    for cid in listed:
        c = pf.docs.get(cid)
        if c is None:
            excluded.append({'path': None, 'fileID': cid, 'reason': 'listed collision not in prefab'})
            continue
        path = pf.path(c)
        cls = c.get('_cls')
        chain = pf.chain(c, stop=root_t)
        pos, rot, scl = world_of(chain)
        if cls != HIT_MODEL_CLASS:
            excluded.append({'path': path, 'class': cls, 'shape': SHAPE_NAMES.get(c.get('_shapeType')),
                             'reason': 'not an EnemyCollisionModel (no enemy hit circle)'})
            if c.get('_shapeType') == 3:
                walls.append({'path': path, 'class': cls,
                              'polygon': [[rnd(pos[0] + float(p['x']) * scl[0]), rnd(pos[2] + float(p['y']) * scl[2])]
                                          for p in c.get('_points') or []]})
            continue
        if not pf.active_chain(c) or c.get('m_Enabled', 1) == 0:
            warnings.append('%s: inactive/disabled at rest, kept' % path)
        sx, sz = abs(scl[0]), abs(scl[2])
        if sx < 1e-6 or sz < 1e-6:
            excluded.append({'path': path, 'class': cls, 'reason': 'zero scale at rest pose (scaled up by animation)'})
            continue
        local, method, problem = shape_local_circles(c, sx, sz, simple)
        if problem:
            excluded.append({'path': path, 'class': cls, 'reason': problem})
            continue
        # 2D orientation: the node's local X axis projected on the XZ plane
        ax = qrot(rot, (1.0, 0.0, 0.0))
        yaw = math.degrees(math.atan2(-ax[2], ax[0]))
        X = (ax[0], ax[2]) if rotate else (1.0, 0.0)
        n = math.hypot(*X) or 1.0
        X = (X[0] / n, X[1] / n)
        Z = (-X[1], X[0])
        st = c.get('_shapeType')
        if abs(qrot(rot, (0.0, 1.0, 0.0))[1] - 1.0) > 1e-3 and st not in (1, 6):
            warnings.append('%s: non-yaw rotation in chain, shape oriented by its projected X axis' % path)
        if simple and st not in (1, 6):
            warnings.append('%s: simpleCalc %s points scaled by %.2f (rule verified on circles only)' %
                            (path, SHAPE_NAMES.get(st), SIMPLE_CALC_RADIUS))
        if method == 'polygon-sliced':
            warnings.append('%s: elongated polygon covered by slices (no reference sample)' % path)
        elif method == 'polygon-compact' and len(c.get('_points') or []) != 3:
            warnings.append('%s: compact polygon rule verified on a triangle only' % path)
        first = len(entry['circles'])
        for (lx, lz, r) in local:
            entry['circles'].append({'x': rnd(pos[0] + lx * X[0] + lz * Z[0]), 'z': rnd(pos[2] + lx * X[1] + lz * Z[1]),
                                     'r': rnd(r)})
        src = {'path': path, 'shape': SHAPE_NAMES.get(st), 'method': method,
               'points': [[p.get('x'), p.get('y')] for p in c.get('_points') or []],
               'first': first, 'count': len(local), 'yaw': rnd(yaw),
               'subject': SUBJECTS.get(c.get('_subjectType'), c.get('_subjectType')),
               'attribute': int(c.get('_attribute') or 0), 'attributeFlags': attr_names(c.get('_attribute'))}
        if st == 3:
            k = SIMPLE_CALC_RADIUS if simple else 1.0
            verts = []
            for p in c.get('_points'):
                lx, lz = float(p['x']) * k * sx, float(p['y']) * k * sz
                verts.append([rnd(pos[0] + lx * X[0] + lz * Z[0]), rnd(pos[2] + lx * X[1] + lz * Z[1])])
            src['polygon'] = verts
        sources.append(src)
        by_model_id[cid] = src
    for cid, c in pf.collision_models():
        if cid not in listed:
            excluded.append({'path': pf.path(c), 'class': c.get('_cls'), 'shape': SHAPE_NAMES.get(c.get('_shapeType')),
                             'reason': "not in the owner's _collisions list"})
    parts_list = [p for p in (pawn.get('PartsList') or []) if isinstance(p, dict)]
    if len(parts_list) > 1 or any(p.get('_partsName') for p in parts_list):
        parts = []
        for p in parts_list:
            circles, paths = [], []
            for r in p.get('_collisions') or []:
                s = by_model_id.get(fid(r))
                if s:
                    paths.append(s['path'])
                    circles.extend(entry['circles'][s['first']:s['first'] + s['count']])
            parts.append({'name': p.get('_partsName') or '', 'flags': int(p.get('_partsFlags') or 0),
                          'root': go_path(pf, fid(p.get('_partsRoot'))), 'collisions': paths, 'circles': circles})
        entry['parts'] = parts
    entry['owner'] = pawn.get('_cls')
    entry['prefab'] = prefab_rel
    entry['sources'] = sources
    if excluded:
        entry['excluded'] = excluded
    if warnings:
        entry['warnings'] = warnings
    if not entry['circles']:
        return None, {'model': name, 'owner': pawn.get('_cls'), 'prefab': prefab_rel,
                      'reason': 'no EnemyCollisionModel hit shape; collisions: ' + ', '.join(sorted(set(
                          '%s(%s)' % ((e.get('class') or '?').split('.')[-1], e.get('shape')) for e in excluded))),
                      'excluded': excluded, 'wallPolygons': walls}
    return entry, None

# ---------------------------------------------------------------- main


def stage_models():
    names = []
    for p in sorted(glob.glob(os.path.join(STAGES, 'BG0*.json'))):
        for m in json.load(open(p, encoding='utf-8'))['models']:
            n = m['name'] if isinstance(m, dict) else m
            if n not in names:
                names.append(n)
    return names


TOL = 0.0015


def compare(ref_model, got):
    if got is None:
        return {'model': ref_model['model'], 'match': False, 'difference': 'not extracted'}
    diffs = []
    if bool(ref_model.get('simpleCalc')) != bool(got.get('simpleCalc')):
        diffs.append('simpleCalc reference %s, extracted %s' % (ref_model.get('simpleCalc'), got.get('simpleCalc')))
    rc, gc = ref_model['circles'], got['circles']
    if len(rc) != len(gc):
        diffs.append('circle count reference %d, extracted %d' % (len(rc), len(gc)))
    worst = 0.0
    for i, (a, b) in enumerate(zip(rc, gc)):
        d = max(abs(a[k] - b[k]) for k in ('x', 'z', 'r'))
        worst = max(worst, d)
        if d > TOL:
            src = next((s['path'] for s in got.get('sources', []) if s['first'] <= i < s['first'] + s['count']), None)
            diffs.append({'index': i, 'source': src, 'reference': a, 'extracted': b})
    return {'model': ref_model['model'], 'match': not diffs, 'circles': len(rc), 'maxAbsDiff': round(worst, 6),
            **({'differences': diffs} if diffs else {})}


def main():
    ref = json.load(open(REFERENCE, encoding='utf-8'))
    stage = stage_models()
    names = list(stage) + [m['model'] for m in ref['models'] if m['model'] not in stage]
    models, unresolved = [], []
    for n in names:
        e, u = extract_model(n)
        if e:
            models.append(e)
        else:
            unresolved.append(u)
    out = {
        'version': 1,
        'units': 'source',
        'note': ('hit circles per model, enemy-local X/Z (tools/stage_combat/enemy_hitshapes.py): the root PawnEnemy '
                 '_collisions EnemyCollisionModel shapes placed by the prefab transform chain (Y dropped, shapes turned '
                 'by their yaw); capsules/boxes as rows of circles, simpleCalc owners x1.61; parts = PartsList; sources '
                 'map circle ranges to collision objects with their EnemyCollisionAttribute flags'),
        'models': models,
        'unresolved': unresolved,
    }
    os.makedirs(os.path.dirname(OUT), exist_ok=True)
    with open(OUT, 'w', encoding='utf-8', newline='\n') as f:
        json.dump(out, f, indent=1)
    got = {m['model']: m for m in models}
    rows = [compare(r, got.get(r['model'])) for r in ref['models']]
    legacy = [compare(r, extract_model(r['model'], rotate=False)[0]) for r in ref['models']]
    warned = {m['model']: m['warnings'] for m in models if m.get('warnings')}
    val = {
        'reference': os.path.relpath(REFERENCE, BASE).replace('\\', '/'),
        'output': os.path.relpath(OUT, BASE).replace('\\', '/'),
        'tolerance': TOL,
        'summary': {
            'referenceModels': len(rows),
            'matched': sum(r['match'] for r in rows),
            'matchedWithShapeYawIgnored': sum(r['match'] for r in legacy),
            'stageModels': len(stage),
            'stageModelsResolved': sum(1 for n in stage if n in got),
            'extractedModels': len(models),
            'unresolved': [u['model'] for u in unresolved],
            'modelsWithExtrapolatedRules': sorted(warned),
        },
        'rules': {
            'included': "EnemyCollisionModel entries of the root owner's (PawnEnemy subclass) _collisions, in list order; "
                        'BulletBlockModel / InGameWallCollisionModel / other HybridCollisionModel classes excluded',
            'Circle/CircleNR': 'r = _points[0].x * max(lossyScale.x, lossyScale.z)',
            'Capsule': '_points = half extents (x, y->z); circles of r = short along the long axis, centres evenly from '
                       '-(long-short) to +(long-short), gaps = ceil(span / (%.1f*short)); equal extents -> one circle' % CAPSULE_STEP,
            'Box/BoxNR': 'centres as capsule, r = sqrt(short^2 + (gap/2)^2); square -> one equal-area circle r = 2a/sqrt(pi)',
            'Polygon': 'bbox aspect <= 2: one circle at the vertex mean, r = %.1f * farthest vertex (Md01); else slices along '
                       'the long axis (count as box rule), each covered by its own circle (extrapolated)' % POLYGON_FACTOR,
            'simpleCalc': 'PawnEnemy._isSimpleCalc: shape points x %.2f' % SIMPLE_CALC_RADIUS,
            'transform': 'position = Unity TRS composition of the chain below the prefab root, Y dropped; extents x lossy '
                         'scale (x, z); shape turned by the projected yaw of its node (the reference ignored it)',
        },
        'models': rows,
        'withShapeYawIgnored': legacy,
        'extrapolationWarnings': warned,
    }
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    with open(VALIDATION, 'w', encoding='utf-8', newline='\n') as f:
        json.dump(val, f, indent=1)
    s = val['summary']
    print('models %d (stage %d/%d), unresolved %d, reference matched %d/%d (shape yaw ignored: %d/%d)' % (
        len(models), s['stageModelsResolved'], len(stage), len(unresolved), s['matched'], len(rows),
        s['matchedWithShapeYawIgnored'], len(rows)))
    for tag, rr in (('DIFF', rows), ('DIFF(yaw ignored)', legacy)):
        for r in rr:
            if not r['match']:
                print('  %s %s %s' % (tag, r['model'], json.dumps(r.get('differences') or r.get('difference'))[:700]))
    for u in unresolved:
        print('  UNRESOLVED', u['model'], u['reason'])
    for m, w in warned.items():
        print('  WARN', m, w)


if __name__ == '__main__':
    main()


