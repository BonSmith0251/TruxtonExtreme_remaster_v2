"""Rebuild the enemy attack data (Round1EnemyAttacks.Data schema) for every stage of TATSUJIN EXTREME.

usage: C:\\Python311\\python.exe -I enemy_attacks.py [<TruxtonExRecon root>] [--game <game install dir>]

Inputs (read only, Unity YAML as text; the game's global-metadata.dat for native string literals/static data):
  Reconstructed/Assets/OriginalGame/InGame/InGameReference/BulletTemplate/**.asset   (BulletTemplate)
  .../BulletSelecter/*.asset                                                              (BulletTemplateSelecter)
  .../Resident/BulletSpeeds00.asset (BulletSpeeds), .../Resident/BulletPallet.asset (BulletPalette)
  Samples/Prefabs/Reference/Enemy/{bullet,laser}/Prefabs/*.prefab                       (bullet / laser prefabs)
  every model prefab (Pf_*.prefab) and Samples/EnemyData/**.asset                       (EnemyData)
  Reconstructed/Assets/Resources/StageEnemies/BG01..BG08.json                           (stage schedules)
  code/types.jsonl                                                                      (field types, script classes)
Outputs:
  Reconstructed/Assets/Resources/StageCombat/enemy-attacks.json   (schema of Resources/Truxton/round1-enemy-attacks.json)
  evidence/stage-combat/enemy-attacks-provenance.json             (per item: stages, sources; bullet prefabs; unresolved)
  evidence/stage-combat/enemy-attacks-validation.json             (BG03 restriction vs the earlier BG03 reference)

Source -> schema mapping
  patterns[]   = BulletTemplate assets (m_Name -> name, then every serialized field in file order; Single fields are
                 float32-rounded, Int32/enum/bool fields ints; curveAnime without serializedVersion). Included when some
                 stage needs it (see "needed" below) - unreferenced test templates are left out and listed.
  selectors[]  = BulletTemplateSelecter assets: name + btpalette (pmode, _btName, _rate).
  models[]     = air (non-ground), non-boss models of a stage schedule, plus any reachable model prefab with
                 _muzzlePacks; packs = EnemyMover._muzzlePacks (keyName -> transform paths below the prefab root).
  speeds[]     = BulletSpeeds00.palette (whole table, as the original loads it).
  laserCharge/Width/CollisionWidth/Dissolve = enemylaser000's EnemyLaserCollision (_chargeTime, _laserWidth,
                 _collisionWidth, nDissolveTimeMax): the default laser. lasers[] = the same four for every other laser
                 bullet a needed pattern fires (nIrradiation > 0).
  aimSteps     = BulletTemplate._limitArcTable (static readonly float[8]); its initial data is read from the field
                 data blob of global-metadata.dat (located by the LimitArcKind enum: entries 1..7 are 360/4..360/64).
"Needed" = reachable from any stage by these sources:
  S  schedule: EnemyData eventDatas of eventType 8 (Bullet) / 83 (BulletSelecter) in StageEnemies/BGxx definitions.
  N  native: IL2CPP string literals that name a template/selector ("BossNN/<name>" for boss classes, plain names for
     native movers such as Md01 -> md01_fire1_sel); owned by Pf_Ene_BosNN* or by the model named by the name prefix
     (md01 -> Pf_Ene_Md01). Literals naming EnemyData assets add that EnemyData's fire events.
  P  prefab: serialized strings in a stage model prefab (recursively through nested prefab sources) that name a
     template/selector (_deadBullet, _deadBulletSelecter, _bulletName, _damageBullet, ...) or an EnemyData
     (_enemyDataName, ...), whose fire events are added.
  R  resident: BulletPalette.names (Regident/...), preloaded by InGameBulletManager.
  X  selector expansion of every needed selector.
"""
import collections, glob, json, os, re, struct, sys

ROOT = 'D:/games/TruxtonExRecon'
GAME = 'D:/games/Truxton Extreme'
args = sys.argv[1:]
if '--game' in args:
    i = args.index('--game'); GAME = args[i + 1]; del args[i:i + 2]
if args: ROOT = args[0]
REC = os.path.join(ROOT, 'Reconstructed', 'Assets')
ORIG = os.path.join(REC, 'OriginalGame')
REF = os.path.join(ORIG, 'InGame', 'InGameReference')
OUT = os.path.join(REC, 'Resources', 'StageCombat', 'enemy-attacks.json')
EVD = os.path.join(ROOT, 'evidence', 'stage-combat')
REFERENCE = os.path.join(REC, 'Resources', 'Truxton', 'round1-enemy-attacks.json')
STAGES = ['BG0%d' % i for i in range(1, 9)]
FIRE_EVENTS = (8, 83)
rel = lambda p: os.path.relpath(p, REC).replace('\\', '/')

# ---------------------------------------------------------------- Unity YAML (subset) -------------------------------
HDR = re.compile(r'^--- !u!(\d+) &(-?\d+)( stripped)?')

def scalar(s):
    s = s.strip()
    if s.startswith('{') and s.endswith('}'):
        d = {}
        for part in s[1:-1].split(','):
            if ':' in part:
                k, v = part.split(':', 1); d[k.strip()] = v.strip()
        return d
    if len(s) >= 2 and s[0] == s[-1] and s[0] in '\'"': return s[1:-1]
    return s

def parse_block(lines, i, ind):
    """Mapping whose keys sit at indent `ind`; Unity writes list items at the parent key's indent."""
    out = {}
    while i < len(lines):
        ln = lines[i]; cur = len(ln) - len(ln.lstrip(' '))
        body = ln.strip()
        if not body: i += 1; continue
        if cur < ind or (cur == ind and body.startswith('- ')) or cur > ind and not out: break
        if cur > ind:  # continuation of a multi-line scalar
            if out:
                k = list(out)[-1]
                if isinstance(out[k], str): out[k] += ' ' + body
            i += 1; continue
        key, _, rest = body.partition(':')
        rest = rest.strip(); i += 1
        if rest:
            out[key] = scalar(rest); continue
        if i < len(lines):
            nxt = lines[i]; ni = len(nxt) - len(nxt.lstrip(' ')); nb = nxt.strip()
            if nb.startswith('- ') and ni >= ind:
                out[key], i = parse_list(lines, i, ni); continue
            if ni > ind and nb:
                out[key], i = parse_block(lines, i, ni); continue
        out[key] = ''
    return out, i

def parse_list(lines, i, ind):
    out = []
    while i < len(lines):
        ln = lines[i]; cur = len(ln) - len(ln.lstrip(' ')); body = ln.strip()
        if cur != ind or not body.startswith('- '): break
        item = body[2:]
        if item.startswith('{') or ':' not in item:
            out.append(scalar(item)); i += 1; continue
        sub = [' ' * (ind + 2) + item]; j = i + 1
        while j < len(lines):
            l2 = lines[j]; c2 = len(l2) - len(l2.lstrip(' '))
            if c2 <= ind and l2.strip(): break
            sub.append(l2); j += 1
        d, _ = parse_block(sub, 0, ind + 2); out.append(d); i = j
    return out, i

def load_yaml(path):
    """-> list of (classID, fileID, stripped, typeName, body dict)."""
    docs = []; cur = None
    with open(path, encoding='utf-8', errors='replace') as fh:
        for ln in fh:
            ln = ln.rstrip('\n').rstrip('\r')
            m = HDR.match(ln)
            if m:
                cur = [int(m.group(1)), int(m.group(2)), bool(m.group(3)), []]; docs.append(cur); continue
            if cur is not None and not ln.startswith('%'): cur[3].append(ln)
    out = []
    for cid, fid, stripped, lines in docs:
        if not lines: continue
        tname = lines[0].rstrip(':'); body, _ = parse_block(lines[1:], 0, 2)
        out.append((cid, fid, stripped, tname, body))
    return out

# ---------------------------------------------------------------- script classes / field types ----------------------
def md4(msg):
    F = lambda x, y, z: (x & y) | (~x & z); G = lambda x, y, z: (x & y) | (x & z) | (y & z); H = lambda x, y, z: x ^ y ^ z
    rol = lambda v, s: ((v << s) | (v >> (32 - s))) & 0xffffffff
    m = bytearray(msg); ml = len(m) * 8; m.append(0x80)
    while len(m) % 64 != 56: m.append(0)
    m += struct.pack('<Q', ml); a, b, c, d = 0x67452301, 0xefcdab89, 0x98badcfe, 0x10325476
    for i in range(0, len(m), 64):
        X = struct.unpack('<16I', m[i:i + 64]); A, B, C, D = a, b, c, d
        for k in range(16): A = rol((A + F(B, C, D) + X[k]) & 0xffffffff, [3, 7, 11, 19][k % 4]); A, B, C, D = D, A, B, C
        for k in range(16): A = rol((A + G(B, C, D) + X[(k % 4) * 4 + k // 4] + 0x5a827999) & 0xffffffff, [3, 5, 9, 13][k % 4]); A, B, C, D = D, A, B, C
        for k, o in enumerate([0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]): A = rol((A + H(B, C, D) + X[o] + 0x6ed9eba1) & 0xffffffff, [3, 9, 11, 15][k % 4]); A, B, C, D = D, A, B, C
        a, b, c, d = (a + A) & 0xffffffff, (b + B) & 0xffffffff, (c + C) & 0xffffffff, (d + D) & 0xffffffff
    return struct.pack('<4I', a, b, c, d)

def file_id(full):
    ns, _, name = full.rpartition('.')
    return struct.unpack('<i', md4(('s\0\0\0' + ns + name).encode('utf-8'))[:4])[0]

TYPES = {}
for line in open(os.path.join(ROOT, 'code', 'types.jsonl'), encoding='utf-8'):
    t = json.loads(line); TYPES[t['type']] = t
CLASS_OF = {file_id(n): n for n in TYPES if n.startswith('InGame.Kernel')}
def script_class(body):
    s = body.get('m_Script')
    return CLASS_OF.get(int(s['fileID'])) if isinstance(s, dict) and 'fileID' in s else None

def inherits(cls, base):
    while cls:
        if cls == base: return True
        cls = (TYPES.get(cls) or {}).get('baseType')
    return False

f32 = lambda v: struct.unpack('<f', struct.pack('<f', float(v)))[0]
BT_FIELDS = [f for f in TYPES['InGame.Kernel.Enemy.BulletTemplate']['fields'] if 'NotSerialized' not in f['flags'] and 'Static' not in f['flags']]
BT_TYPE = {f['name']: f['type'] for f in BT_FIELDS}

def conv(v, typ):
    if typ == 'System.Single': return f32(v)
    if typ == 'System.String': return v if isinstance(v, str) else ''
    try: return int(v)
    except (TypeError, ValueError): return int(float(v))

def curve(c):
    out = {}
    for k, v in (c or {}).items():
        if k == 'serializedVersion': continue
        if k == 'm_Curve':
            keys = []
            for key in (v if isinstance(v, list) else []):
                kd = {}
                for kk, vv in key.items():
                    if kk == 'serializedVersion': continue
                    try: kd[kk] = f32(vv) if kk in ('time', 'value', 'inSlope', 'outSlope', 'inWeight', 'outWeight') else int(vv)
                    except (TypeError, ValueError): kd[kk] = vv
                keys.append(kd)
            out[k] = keys
        else:
            out[k] = int(v)
    return out

# ---------------------------------------------------------------- GUID index ---------------------------------------
GUID = {}
for meta in glob.glob(os.path.join(ORIG, '**', '*.meta'), recursive=True):
    with open(meta, encoding='utf-8', errors='replace') as fh:
        for ln in fh:
            if ln.startswith('guid:'): GUID[ln.split(':', 1)[1].strip()] = meta[:-5]; break

# ---------------------------------------------------------------- templates, selectors, speeds ----------------------
templates, template_path, selectors, selector_path = {}, {}, {}, {}
for p in sorted(glob.glob(os.path.join(REF, 'BulletTemplate', '**', '*.asset'), recursive=True)):
    for cid, fid, _, tn, body in load_yaml(p):
        if script_class(body) != 'InGame.Kernel.Enemy.BulletTemplate': continue
        name = body['m_Name']; d = {'name': name}
        for key in body:
            if key in BT_TYPE:
                d[key] = curve(body[key]) if key == 'curveAnime' else conv(body[key], BT_TYPE[key])
        if name in templates: raise SystemExit('duplicate template ' + name)
        templates[name] = d; template_path[name] = rel(p)
for p in sorted(glob.glob(os.path.join(REF, 'BulletSelecter', '**', '*.asset'), recursive=True)):
    for cid, fid, _, tn, body in load_yaml(p):
        if script_class(body) != 'InGame.Kernel.Enemy.BulletTemplateSelecter': continue
        ch = [{'pmode': int(s.get('pmode', 0)), '_btName': s.get('_btName', '') or '', '_rate': f32(s.get('_rate', 0))}
              for s in (body.get('btpalette') or [])]
        selectors[body['m_Name']] = {'name': body['m_Name'], 'choices': ch}; selector_path[body['m_Name']] = rel(p)

def resident_asset(cls):
    for p in sorted(glob.glob(os.path.join(REF, 'Resident', '*.asset'))):
        for _, _, _, _, body in load_yaml(p):
            if script_class(body) == cls: return p, body
    raise SystemExit('missing ' + cls)
speeds_path, speeds_body = resident_asset('InGame.Kernel.Enemy.BulletSpeeds')
speeds = [{'_bulletName': s['_bulletName'], '_aSecondPass': f32(s['_aSecondPass'])} for s in speeds_body['palette']]
pallet_path, pallet_body = resident_asset('InGame.Kernel.Enemy.BulletPalette')
resident_names = [n.split('/')[-1] for n in (pallet_body.get('names') or [])]

# ---------------------------------------------------------------- native metadata ------------------------------------
meta_path = os.path.join(GAME, 'TATSUJIN EXTREME_Data', 'il2cpp_data', 'Metadata', 'global-metadata.dat')
mb = open(meta_path, 'rb').read()
sanity, version = struct.unpack_from('<Ii', mb, 0)
if sanity != 0xFAB11BAF or version != 39: raise SystemExit('unexpected metadata %x v%d' % (sanity, version))
lit_off, lit_size, lit_count, dat_off, dat_size, _ = struct.unpack_from('<6i', mb, 8)
offs = struct.unpack_from('<%di' % lit_count, mb, lit_off)
literals = [mb[dat_off + offs[i]:dat_off + (offs[i + 1] if i + 1 < lit_count else dat_size)].decode('utf-8', 'replace') for i in range(lit_count)]
divs = [int(n[4:]) for n in ['_div4', '_div8', '_div16', '_div24', '_div32', '_div48', '_div64']]
tail = struct.pack('<7f', *[360.0 / n for n in divs])
hits = [m.start() for m in re.finditer(re.escape(tail), mb)]
if len(hits) != 1: raise SystemExit('limit arc table: %d candidate blobs' % len(hits))
aim_steps = [f32(x) for x in struct.unpack_from('<8f', mb, hits[0] - 4)]
aim_evidence = {'file': meta_path.replace('\\', '/'), 'offset': hits[0] - 4, 'values': aim_steps,
                'locator': 'unique float32 run 360/{4,8,16,24,32,48,64} (LimitArcKind _div4.._div64) preceded by entry 0'}

# ---------------------------------------------------------------- prefabs ------------------------------------------
prefab_index = {}
for p in glob.glob(os.path.join(ORIG, '**', '*.prefab'), recursive=True):
    prefab_index.setdefault(os.path.basename(p)[:-7], []).append(p)
_prefab_cache = {}
def prefab(path):
    if path not in _prefab_cache: _prefab_cache[path] = load_yaml(path)
    return _prefab_cache[path]

def transform_paths(docs):
    names = {fid: b.get('m_Name', '') for cid, fid, _, tn, b in docs if cid == 1}
    tr = {fid: b for cid, fid, s, tn, b in docs if cid in (4, 224) and not s}
    def path(fid, seen=()):
        b = tr.get(fid)
        if b is None or fid in seen: return None
        fa = int(b.get('m_Father', {}).get('fileID', 0))
        if fa == 0: return ''
        up = path(fa, seen + (fid,))
        if up is None: return None
        me = names.get(int(b.get('m_GameObject', {}).get('fileID', 0)), '')
        return me if up == '' else up + '/' + me
    return {fid: path(fid) for fid in tr}

def model_info(name, unresolved):
    """packs, serialized name strings and nested prefab sources of one model prefab."""
    paths = prefab_index.get(name)
    if not paths: unresolved.append({'item': name, 'kind': 'model', 'reason': 'no prefab named ' + name}); return None
    docs = prefab(paths[0]); tp = transform_paths(docs)
    packs, strings, nested = [], [], []
    for cid, fid, stripped, tn, b in docs:
        if cid == 1001:
            src = b.get('m_SourcePrefab', {}).get('guid')
            if src in GUID and GUID[src].endswith('.prefab'): nested.append(GUID[src])
            elif src: unresolved.append({'item': name, 'kind': 'nested prefab', 'reason': 'guid %s not found' % src})
        if cid != 114: continue
        cls = script_class(b)
        for k, v in b.items():
            if isinstance(v, str) and v and not k.startswith('m_'): strings.append((cls, k, v))
        if isinstance(b.get('_muzzlePacks'), list):  # EnemyMover._muzzlePacks
            for pk in b['_muzzlePacks']:
                ps = []
                for m in pk.get('muzzles') or []:
                    q = tp.get(int(m.get('fileID', 0))) if isinstance(m, dict) else None
                    if q is None: unresolved.append({'item': '%s/%s' % (name, pk.get('keyName')), 'kind': 'muzzle pack', 'reason': 'muzzle %s is not a transform of the prefab' % m}); continue
                    ps.append(q)
                packs.append({'name': pk.get('keyName', ''), 'paths': ps})
    return {'prefab': rel(paths[0]), 'packs': packs, 'strings': strings, 'nested': nested,
            'paths': set(p for p in tp.values() if p is not None)}

# ---------------------------------------------------------------- EnemyData ------------------------------------------
enemy_data = {}
for p in glob.glob(os.path.join(ORIG, 'Samples', 'EnemyData', '**', '*.asset'), recursive=True):
    for cid, fid, _, tn, b in load_yaml(p):
        if 'eventDatas' not in b and 'objectName' not in b: continue
        evs = [e for e in (b.get('eventDatas') or []) if isinstance(e, dict)]
        enemy_data[b.get('m_Name')] = {'path': rel(p), 'objectName': b.get('objectName', ''),
                                       'fires': [{'eventType': int(e.get('eventType', 0)), 'stringValue': e.get('stringValue', '') or '',
                                                  'nameValue': e.get('nameValue', '') or '', 'subnameValue': e.get('subnameValue', '') or ''}
                                                 for e in evs if int(e.get('eventType', 0)) in FIRE_EVENTS]}

# ---------------------------------------------------------------- reachability ----------------------------------------
unresolved = []
need = collections.defaultdict(lambda: {'stages': set(), 'sources': set()})   # name -> stages / sources
model_need = collections.defaultdict(lambda: {'stages': set(), 'sources': set()})
fire_uses = []   # (stage, model, event, source) for muzzle checks

def mark(name, stage, source):
    if not name: return
    if name not in templates and name not in selectors:
        unresolved.append({'item': name, 'kind': 'template/selector', 'reason': 'named by %s (%s) but no asset' % (source, stage)}); return
    e = need[name]; e['sources'].add(source)
    if stage: e['stages'].add(stage)

def boss_models(nn): return [m for m in prefab_index if re.fullmatch(r'Pf_Ene_Bos%s[A-Z]?' % nn, m)]
def owner_models(lit):
    m = re.fullmatch(r'Boss(\d\d)/.*', lit)
    if m: return boss_models(m.group(1))
    m = re.match(r'(?:ene_)?([a-z]+\d+)', lit)
    if m:
        k = m.group(1).lower(); mm = [x for x in prefab_index if x.lower() in ('pf_ene_' + k, 'pf_eneobj_' + k)]
        if mm: return mm
        m2 = re.fullmatch(r'bos(\d\d)\w*', k)
        if m2: return boss_models(m2.group(1))
    return []

stage_models, stage_air = {}, {}
for st in STAGES:
    d = json.load(open(os.path.join(REC, 'Resources', 'StageEnemies', st + '.json'), encoding='utf-8'))
    defs = {x['id']: x for x in d['definitions']}
    stage_models[st] = [m['name'] for m in d['models']]
    air = []
    for ev in d['events']:
        m = defs[ev['enemy']]['model']
        if not ev['ground'] and m not in air: air.append(m)
    stage_air[st] = air
    for df in d['definitions']:
        for e in df['events']:
            if e['eventType'] in FIRE_EVENTS:
                mark(e['stringValue'], st, 'S:' + df['name']); fire_uses.append((st, df['model'], e, 'S:' + df['name']))

native_names = sorted(set(l for l in literals if l.split('/')[-1] in templates or l.split('/')[-1] in selectors))
native_data = sorted(set(l for l in literals if l in enemy_data))
model_cache = {}
def info(m):
    if m not in model_cache: model_cache[m] = model_info(m, unresolved)
    return model_cache[m]

for st in STAGES:
    reach, todo, seen_p = [], list(stage_models[st]), set()
    # P: prefab strings, recursively through nested prefab sources and EnemyData named there
    while todo:
        m = todo.pop(0)
        if m in reach: continue
        reach.append(m); mi = info(m)
        if not mi: continue
        stack = [(m, mi)]
        while stack:
            owner, x = stack.pop()
            for cls, k, v in x['strings']:
                if v in templates or v in selectors: mark(v, st, 'P:%s.%s' % (os.path.basename(x['prefab'])[:-7], k))
                elif v in enemy_data:
                    ed = enemy_data[v]
                    for e in ed['fires']:
                        mark(e['stringValue'], st, 'P:%s.%s->%s' % (os.path.basename(x['prefab'])[:-7], k, v))
                        fire_uses.append((st, ed['objectName'], e, 'P:' + v))
                    if ed['objectName'] and ed['objectName'] in prefab_index and ed['objectName'] not in reach: todo.append(ed['objectName'])
            for np_ in x['nested']:
                if np_ in seen_p: continue
                seen_p.add(np_); nm = os.path.basename(np_)[:-7]
                if nm not in reach: todo.append(nm)
    for m in reach:
        mi = info(m)
        if mi and any(p['paths'] for p in mi['packs']): model_need[m]['stages'].add(st); model_need[m]['sources'].add('packs')
    for m in stage_air[st]:
        if not m.startswith('Pf_Ene_Bos'): model_need[m]['stages'].add(st); model_need[m]['sources'].add('air')
    # N: native literals owned by a model of this stage
    for lit in native_names:
        own = owner_models(lit)
        if any(o in reach for o in own): mark(lit.split('/')[-1], st, 'N:"%s"' % lit)
    for lit in native_data:
        ed = enemy_data[lit]; own = owner_models(lit) or [ed['objectName']]
        if any(o in reach for o in own):
            for e in ed['fires']:
                mark(e['stringValue'], st, 'N:"%s"' % lit); fire_uses.append((st, ed['objectName'], e, 'N:' + lit))
for lit in native_names:
    if not owner_models(lit): mark(lit.split('/')[-1], None, 'N:"%s" (owner unknown)' % lit)
for n in resident_names: mark(n, None, 'R:BulletPallet')
# X: selector expansion
for name in list(need):
    if name in selectors:
        for c in selectors[name]['choices']:
            if c['_btName']:
                if c['_btName'] not in templates:
                    unresolved.append({'item': c['_btName'], 'kind': 'template', 'reason': 'choice of selector ' + name + ' has no asset'}); continue
                e = need[c['_btName']]; e['sources'].add('X:' + name); e['stages'] |= need[name]['stages']
for name in need:
    if name in templates and name in selectors: unresolved.append({'item': name, 'kind': 'name clash', 'reason': 'both template and selector'})

# ---------------------------------------------------------------- muzzle checks -----------------------------------------
muzzle_issues = []
for st, model, e, src in fire_uses:
    mi = info(model) if model in prefab_index else None
    if not mi: muzzle_issues.append({'stage': st, 'model': model, 'event': e['stringValue'], 'nameValue': e['nameValue'], 'source': src, 'reason': 'model prefab not found'}); continue
    nv = e['nameValue']
    if nv and not any(p['name'] == nv for p in mi['packs']) and nv not in mi['paths']:
        muzzle_issues.append({'stage': st, 'model': model, 'event': e['stringValue'], 'nameValue': nv, 'source': src, 'reason': 'neither a _muzzlePacks key nor a transform path of ' + mi['prefab']})
    sv = e.get('subnameValue') or ''
    if sv and sv not in mi['paths']:
        muzzle_issues.append({'stage': st, 'model': model, 'event': e['stringValue'], 'subnameValue': sv, 'source': src, 'reason': 'aim reference is not a transform path of ' + mi['prefab']})
seen = set(); muzzle_issues = [x for x in muzzle_issues if not (json.dumps(x, sort_keys=True) in seen or seen.add(json.dumps(x, sort_keys=True)))]

# ---------------------------------------------------------------- lasers / bullet prefabs ------------------------------
def bullet_prefab(name):
    c = [p for p in prefab_index.get(name, []) if re.search(r'[\\/]Enemy[\\/](bullet|laser)[\\/]', p)] or prefab_index.get(name, [])
    return c[0] if c else None

def laser_spec(name):
    p = bullet_prefab(name)
    if not p: return None, 'no prefab'
    for cid, fid, _, tn, b in prefab(p):
        cls = script_class(b) if cid == 114 else None
        if cls == 'InGame.Kernel.Enemy.EnemyLaserCollision':
            return {'bulletName': name, 'charge': f32(b['_chargeTime']), 'width': f32(b['_laserWidth']),
                    'collisionWidth': f32(b['_collisionWidth']), 'dissolve': f32(b['nDissolveTimeMax'])}, cls
        if cls == 'InGame.Kernel.Enemy.EnemyLaserCollision2':
            return {'bulletName': name, 'collisionWidth': f32(b['_collisionWidth']), 'dissolve': f32(b['_dissolveTimeMax'])}, cls
    return None, 'no EnemyLaserCollision component'

def build(stage_filter):
    keep = lambda e: stage_filter is None or stage_filter in e['stages']
    pats = [templates[n] for n in sorted(need) if n in templates and keep(need[n])]
    sels = [selectors[n] for n in sorted(need) if n in selectors and keep(need[n])]
    mods = []
    for m in sorted(model_need):
        if stage_filter is None or stage_filter in model_need[m]['stages']:
            mi = info(m); mods.append({'name': m, 'packs': mi['packs'] if mi else []})
    default, _ = laser_spec('enemylaser000')
    lasers, laser_notes = [], []
    for b in sorted(set(p['bulletName'] for p in pats)):
        spec, how = laser_spec(b)
        irr = sorted(p['name'] for p in pats if p['bulletName'] == b and p['nIrradiation'] > 0)
        if spec is None:   # not a laser prefab
            if irr: laser_notes.append({'bulletName': b, 'kind': 'irradiation without laser', 'patterns': irr,
                                        'reason': 'nIrradiation > 0 but %s is a plain bullet prefab (%s); Round1EnemyAttacks would draw it as a beam' % (b, how)})
            continue
        if b == 'enemylaser000': continue   # the default laser (laserCharge/laserWidth/...)
        if 'width' not in spec:
            laser_notes.append({'bulletName': b, 'kind': 'laser', 'reason': '%s has no _laserWidth/_chargeTime (VFX-graph beam); charge and width left out, so JsonUtility reads 0 for them' % how})
        lasers.append(spec)
    data = {'version': 2, 'stage': stage_filter or 'ALL', 'patterns': pats, 'selectors': sels, 'models': mods,
            'laserCharge': default['charge'], 'laserWidth': default['width'], 'laserCollisionWidth': default['collisionWidth'],
            'laserDissolve': default['dissolve'], 'lasers': lasers, 'speeds': speeds, 'aimSteps': aim_steps}
    return data, laser_notes

data, laser_notes = build(None)
os.makedirs(os.path.dirname(OUT), exist_ok=True); os.makedirs(EVD, exist_ok=True)
with open(OUT, 'w', encoding='utf-8', newline='\n') as fh: json.dump(data, fh, indent=1, ensure_ascii=False); fh.write('\n')

bullets = sorted(set(p['bulletName'] for p in data['patterns']) | set(s['_bulletName'] for s in speeds))
bullet_list = []
for b in bullets:
    p = bullet_prefab(b); used = sorted(set(st for n in need if n in templates and templates[n]['bulletName'] == b for st in need[n]['stages']))
    color = next((int(bd['_colorType']) for cid, _, _, _, bd in (prefab(p) if p else []) if cid == 114 and '_colorType' in bd), None)
    lspec, lcls = laser_spec(b) if p else (None, None)
    bullet_list.append({'bulletName': b, 'prefab': rel(p) if p else None, '_colorType': color, 'laserComponent': lcls if lspec else None, 'guid': next((g for g, q in GUID.items() if p and os.path.normcase(q) == os.path.normcase(p)), None),
                        'usedByPatterns': any(x['bulletName'] == b for x in data['patterns']), 'stages': used})
    if not p: unresolved.append({'item': b, 'kind': 'bullet prefab', 'reason': 'no prefab named %s under OriginalGame' % b})
for n in laser_notes: unresolved.append(dict(item=n['bulletName'], **{k: v for k, v in n.items() if k != 'bulletName'}))
for mi in muzzle_issues: unresolved.append(dict(kind='muzzle', **mi))
unref = sorted(n for n in templates if n not in need) + sorted(n for n in selectors if n not in need)
dedup = []; seen = set()
for u in unresolved:
    k = json.dumps(u, sort_keys=True)
    if k not in seen: seen.add(k); dedup.append(u)
prov = {
    'output': rel(OUT),
    'counts': {k: len(data[k]) for k in ('patterns', 'selectors', 'models', 'lasers', 'speeds')},
    'items': {n: {'kind': 'selector' if n in selectors else 'template', 'asset': selector_path.get(n) or template_path.get(n),
                  'stages': sorted(need[n]['stages']), 'sources': sorted(need[n]['sources'])} for n in sorted(need) if n in templates or n in selectors},
    'models': {m: {'stages': sorted(v['stages']), 'sources': sorted(v['sources']), 'prefab': (info(m) or {}).get('prefab')} for m, v in sorted(model_need.items())},
    'bullets': bullet_list, 'aimSteps': aim_evidence,
    'speedsAsset': rel(speeds_path), 'residentPalette': {'asset': rel(pallet_path), 'names': pallet_body.get('names')},
    'nativeLiterals': {'templatesOrSelectors': native_names, 'enemyData': native_data},
    'unreferencedAssets': unref, 'unresolved': dedup,
}
with open(os.path.join(EVD, 'enemy-attacks-provenance.json'), 'w', encoding='utf-8', newline='\n') as fh: json.dump(prov, fh, indent=1); fh.write('\n')

# ---------------------------------------------------------------- BG03 validation ---------------------------------------
ref = json.load(open(REFERENCE, encoding='utf-8'))
mine, mine_notes = build('BG03')
def cmp_list(key, ident):
    a = {ident(x): x for x in ref[key]}; b = {ident(x): x for x in mine[key]}
    rows = []
    for k in sorted(set(a) | set(b)):
        if k not in b: rows.append({'name': k, 'result': 'missing', 'reference': a[k]})
        elif k not in a: rows.append({'name': k, 'result': 'extra', 'ours': b[k]})
        elif a[k] == b[k]: rows.append({'name': k, 'result': 'match'})
        else:
            diff = {f: {'reference': a[k].get(f), 'ours': b[k].get(f)} for f in sorted(set(a[k]) | set(b[k])) if a[k].get(f) != b[k].get(f)}
            rows.append({'name': k, 'result': 'differs', 'fields': diff})
    return rows
val = {'reference': rel(REFERENCE), 'ours': rel(OUT) + ' restricted to BG03 (build(stage_filter="BG03"))', 'sections': {}}
for key, ident in [('patterns', lambda x: x['name']), ('selectors', lambda x: x['name']), ('models', lambda x: x['name']),
                   ('lasers', lambda x: x['bulletName']), ('speeds', lambda x: x['_bulletName'])]:
    rows = cmp_list(key, ident)
    for r in rows:
        if r['result'] == 'extra' and r['name'] in need:
            r['evidence'] = {'sources': sorted(need[r['name']]['sources'])}
    val['sections'][key] = {'summary': dict(collections.Counter(r['result'] for r in rows)), 'items': rows,
                            'orderMatches': [ident(x) for x in ref[key]] == [ident(x) for x in mine[key]]}
for key in ('version', 'laserCharge', 'laserWidth', 'laserCollisionWidth', 'laserDissolve', 'aimSteps'):
    val['sections'][key] = {'reference': ref[key], 'ours': mine[key], 'result': 'match' if ref[key] == mine[key] else 'differs'}
extras = [(k, r['name']) for k in ('patterns', 'selectors', 'models', 'lasers', 'speeds') for r in val['sections'][k]['items'] if r['result'] == 'extra']
others = [(k, r['name'], r['result']) for k in ('patterns', 'selectors', 'models', 'lasers', 'speeds') for r in val['sections'][k]['items'] if r['result'] not in ('match', 'extra')]
val['verdict'] = {'everyReferenceItemMatchesExactly': not others and all(val['sections'][k]['result'] == 'match' for k in ('version', 'laserCharge', 'laserWidth', 'laserCollisionWidth', 'laserDissolve', 'aimSteps')),
                  'missingOrDiffering': others, 'extras': extras,
                  'listOrder': 'patterns/selectors/models are written sorted by name; the reference kept discovery order (order is not used: the consumer indexes them by name)'}
val['explanations'] = {
    'bma01_fired_sel / bsc01_fired_sel (+ bma01_fired, bsc01_fired)': 'Source P: Pf_Ene_BMa01 and Pf_Ene_BSc01 (ground enemies of BG03) serialize InGameEnemy._deadBulletSelecter = bma01_fired_sel / bsc01_fired_sel, the bullet fired when the enemy dies. The BG03 reference only took fire events and native literals, and the remaster implements no death bullets. Both selectors fire only for pmode 3 (pmode 0 -> "").',
    'muzzleChecks': '%d fire events (schedule, prefab-named EnemyData, native-literal EnemyData) checked; every nameValue is a _muzzlePacks key or a transform path of its model prefab, every subnameValue a transform path, unless listed in the provenance unresolved list' % len(fire_uses)}
val['sections']['stage'] = {'reference': ref['stage'], 'ours': mine['stage'], 'result': 'match' if ref['stage'] == mine['stage'] else 'differs'}
with open(os.path.join(EVD, 'enemy-attacks-validation.json'), 'w', encoding='utf-8', newline='\n') as fh: json.dump(val, fh, indent=1); fh.write('\n')

print('ALL:', prov['counts'], 'bullets:', len(bullet_list), 'unresolved:', len(dedup), 'unreferenced assets:', len(unref))
for k, v in val['sections'].items(): print('BG03', k, v.get('summary') or v.get('result'), '' if 'orderMatches' not in v else 'order=' + str(v['orderMatches']))
