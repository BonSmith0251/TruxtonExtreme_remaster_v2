"""Decode TATSUJIN EXTREME's EnemyDatabase.asset into per-model combat stats for every stage (BG01..BG08).

Run: C:\\Python311\\python.exe -I D:\\games\\TruxtonExRecon\\tools\\stage_combat\\enemy_database.py

Reads only (Unity YAML text, never Unity):
  Reconstructed/Assets/OriginalGame/InGame/InGameReference/Database/EnemyDatabase.asset
  Reconstructed/Assets/OriginalGame/**/*.prefab        (the model prefabs)
  Reconstructed/Assets/Resources/StageEnemies/BG0*.json      (the model names per stage)
  Reconstructed/Assets/Resources/Truxton/*.json              (BG03 reference values, validation only)
Writes:
  Reconstructed/Assets/Resources/StageCombat/enemy-database.json
  evidence/stage-combat/enemy-database-validation.json

Decoding (from GameAssembly.dll, disassembled with capstone; RVAs are IL2CPP method addresses):
  Record.get_TargetKey 0x2721850 -> ProtectValue.Mask(string) 0x1E2AC80: every UTF-16 char XOR 0x3C.
  Record.get_hitpoint  0x2721920 -> ProtectValue.Conversion(float,int) 0x1E2AB10 with key 0x00CF7A89:
                                    the float's IEEE-754 bits XOR 0x00CF7A89.
  Record.get_score     0x2721980 -> ProtectValue.Conversion(int,int)   0x1E2AA10 with key 0x00136ACF: int XOR.
  get_pipil/get_jewel/get_priority/get_galleryNo/get_ModelSize/get_PartsName/get_aliasCnt are plain field reads.
  EnemyDataBaseRecords.GetDatas(name) 0x2720970: key = Mask(GetDBKey(name)); returns every palette row whose
  _targetKey equals it. GetDBKey 0x2720740: split name on '_'; with 3+ pieces join pieces[2:] with '_', else the
  name itself (Pf_Ene_Sa01 -> Sa01, Pf_EneObj_Meteo_La01 -> Meteo_La01, Pf_BGObj_ColorBox00_UN -> ColorBox00_UN).
  PawnEnemy.SetRecords lambdas 0x1D1AA30 / 0x1D1AB00: base record = row with empty _partsName; each prefab
  PartsList entry takes the row whose _partsName equals its _partsName.
"""
import json, os, re, struct, subprocess, sys

ROOT = r'D:\games\TruxtonExRecon'
ASSETS = os.path.join(ROOT, 'Reconstructed', 'Assets')
RECOVERED = os.path.join(ASSETS, 'OriginalGame')
DB_PATH = os.path.join(RECOVERED, 'InGame', 'InGameReference', 'Database', 'EnemyDatabase.asset')
STAGES = os.path.join(ASSETS, 'Resources', 'StageEnemies')
REFS = os.path.join(ASSETS, 'Resources', 'Truxton')
OUT = os.path.join(ASSETS, 'Resources', 'StageCombat', 'enemy-database.json')
EVIDENCE = os.path.join(ROOT, 'evidence', 'stage-combat', 'enemy-database-validation.json')
TYPES = os.path.join(ROOT, 'code', 'types.jsonl')
FILEID_TOOL = os.path.join(ROOT, 'tools', 'common', 'script_fileid.py')

STRING_MASK = 0x3C
HITPOINT_KEY = 0x00CF7A89
SCORE_KEY = 0x00136ACF
# Literal constants of TXEKernel.Enemy.EnemyDataBaseRecords (types.jsonl); the serialized _mScore/_mJewel/_mPi are
# these seeds XOR the real value (no in-game reader of them was needed here; decoded for completeness).
SEEDS = {'_mScore': 73783, '_mJewel': 225298, '_mPi': 471095}
SIZES = ['Small', 'Medium', 'Large', 'ExtraLarge', 'BOSS']                    # TXEKernel.Enemy.EnemySize
TOLE = ['normal', 'veryhigh', 'high', 'low', 'verylow']                        # TXEKernelHybridCollisions/toleType
TOLE_FIELDS = ['toleBlack', 'toleBlue', 'toleGreen', 'toleRed', 'toleGold', 'toleSilver', 'toleBomb', 'tolePink']
FLAGS = ['isBreakthrough', 'isLockOn', 'isGround', 'isRangeFire', 'isDamageScore', 'isRateTarget']
# Ground item models (ItemEffects.GetGroundItemName, as in Round1GroundEnemies.cs) -> item ids (ItemEffects..cctor,
# Round1Weapon.SourceItemKind). "ItemOfIndex" draws the next ItemReferenceTable entry (item 1000).
RUIN_ITEMS = {'pf_item_1up': 1, 'pf_item_power': 2, 'pf_item_speedup': 4, 'pf_item_bomstock': 7, 'pf_item_bonus01': 8,
              'pf_item_2up': 9, 'pf_item_3up': 10, 'pf_item_change_red': 100, 'pf_item_change_green': 101,
              'pf_item_change_blue': 102, 'pf_item_change_purple': 103, 'pf_item_change_silver': 104,
              'pf_item_change_gold': 105, 'pf_item_change_black': 106, 'itemofindex': 1000}


# ---------------------------------------------------------------- YAML scalars
def yaml_scalar(s):
    s = s.strip()
    if s.startswith("'"):
        assert s.endswith("'") and len(s) >= 2, s
        return s[1:-1].replace("''", "'")
    if s.startswith('"'):
        assert s.endswith('"') and len(s) >= 2, s
        body, out, i = s[1:-1], [], 0
        simple = {'n': '\n', 't': '\t', 'r': '\r', '0': '\0', '\\': '\\', '"': '"', '/': '/', 'a': '\a', 'b': '\b',
                  'e': '\x1b', 'f': '\f', 'v': '\v', ' ': ' ', 'N': '\x85', '_': '\xa0'}
        while i < len(body):
            c = body[i]
            if c != '\\':
                out.append(c); i += 1; continue
            e = body[i + 1]
            if e in simple:
                out.append(simple[e]); i += 2
            elif e in 'xuU':
                n = {'x': 2, 'u': 4, 'U': 8}[e]
                out.append(chr(int(body[i + 2:i + 2 + n], 16))); i += 2 + n
            else:
                raise ValueError('escape %r in %s' % (e, s))
        return ''.join(out)
    return s


def unmask(s):
    return ''.join(chr(ord(c) ^ STRING_MASK) for c in s)


def f32_bits(text):
    return struct.unpack('<I', struct.pack('<f', float(text)))[0]


def bits_f32(b):
    return struct.unpack('<f', struct.pack('<I', b & 0xffffffff))[0]


def nice(v):
    return int(v) if float(v).is_integer() else v


# ---------------------------------------------------------------- database
def read_database():
    rows, top, cur = [], {}, None
    for line in open(DB_PATH, encoding='utf-8').read().splitlines():
        m = re.match(r'  - (\w+): ?(.*)$', line)
        if m:
            cur = {m[1]: m[2]}; rows.append(cur); continue
        m = re.match(r'    (\w+): ?(.*)$', line)
        if m and cur is not None:
            cur[m[1]] = m[2]; continue
        m = re.match(r'  (\w+): ?(.*)$', line)
        if m:
            top[m[1]] = m[2]; cur = None
    decoded = []
    for i, r in enumerate(rows):
        hp_bits = f32_bits(r['_hitpoint'])
        hp = bits_f32(hp_bits ^ HITPOINT_KEY)
        score = int(r['_score']) ^ SCORE_KEY
        decoded.append({
            'index': i,
            'key': unmask(yaml_scalar(r['_targetKey'])),
            'partsName': yaml_scalar(r['_partsName']),
            **{f: r[f] == '1' for f in FLAGS},
            'hitpoint': nice(hp),
            'score': score,
            'pipil': int(r['_pipil']),
            'jewel': int(r['_jewel']),
            'priority': int(r['_priority']),
            'galleryNo': int(r['_galleryNo']),
            'aliasCnt': yaml_scalar(r['_aliasCnt']),
            'modelSize': SIZES[int(r['_modelSize'])],
            'tolerance': {f[4:].lower(): TOLE[int(r[f])] for f in TOLE_FIELDS},
            'raw': {'_targetKey': yaml_scalar(r['_targetKey']), '_hitpoint': r['_hitpoint'],
                    '_hitpointBits': '0x%08X' % hp_bits, '_score': int(r['_score'])},
        })
    meta = {k: {'raw': int(top[k]), 'seed': SEEDS[k], 'decoded': int(top[k]) ^ SEEDS[k]} for k in SEEDS}
    return decoded, meta


def db_key(name):
    """EnemyDataBaseRecords.GetDBKey (RVA 0x2720740)."""
    parts = name.split('_')
    return '_'.join(parts[2:]) if len(parts) > 2 else name


# ---------------------------------------------------------------- prefabs
def prefab_index():
    idx = {}
    for dp, dn, fn in os.walk(RECOVERED):
        for f in fn:
            if f.endswith('.prefab'):
                idx.setdefault(f[:-7], []).append(os.path.join(dp, f))
    return idx


def pick_prefab(idx, model):
    """Exact-case asset name; the root export is preferred, then Samples/Prefabs/Reference."""
    cands = idx.get(model, [])
    def rank(p):
        rel = os.path.relpath(p, RECOVERED)
        return (0 if os.sep not in rel else 1 if rel.startswith(os.path.join('Samples', 'Prefabs', 'Reference')) else 2, rel)
    return sorted(cands, key=rank)[0] if cands else None


def yaml_docs(path):
    text = open(path, encoding='utf-8').read()
    for chunk in re.split(r'^--- ', text, flags=re.M)[1:]:
        head, _, body = chunk.partition('\n')
        m = re.match(r'!u!(\d+) &(-?\d+)', head)
        if m:
            yield int(m[1]), m[2], body


def read_pawn(path):
    docs = list(yaml_docs(path))
    roots = set()
    for cid, fid, body in docs:
        if cid == 4 and re.search(r'^  m_Father: \{fileID: 0\}', body, re.M):
            g = re.search(r'^  m_GameObject: \{fileID: (-?\d+)\}', body, re.M)
            if g: roots.add(g[1])
    pawns = []
    for cid, fid, body in docs:
        if cid != 114 or not re.search(r'^  _HitPoint: ', body, re.M) or not re.search(r'^  PartsList:', body, re.M):
            continue
        go = re.search(r'^  m_GameObject: \{fileID: (-?\d+)\}', body, re.M)[1]
        script = int(re.search(r'^  m_Script: \{fileID: (-?\d+)', body, re.M)[1])
        def field(name):
            m = re.search(r'^  %s: ?(.*)$' % name, body, re.M)
            return yaml_scalar(m[1]) if m else None
        parts = []
        plist = body.split('\n  PartsList:\n', 1)[1] if '\n  PartsList:\n' in body else ''   # "PartsList: []"
        for m in re.finditer(r'^  - _partsFlags: (\d+)\n    _partsName: ?(.*)$', plist, re.M):
            parts.append({'flags': int(m[1]), 'name': yaml_scalar(m[2])})
        pawns.append({'root': go in roots, 'script': script, 'hitPoint': nice(float(field('_HitPoint'))),
                      'lockOn': field('_isLockonTarget') == '1', 'laserBlock': field('_isLaserBlock') == '1',
                      'ruinName': field('_ruinName'), 'swapDrop': int(field('_SwapDrop')) if field('_SwapDrop') else 0,
                      'parts': parts})
    pawns.sort(key=lambda p: not p['root'])
    return pawns[0] if pawns else None, len(pawns)


def class_names(file_ids):
    if not file_ids:
        return {}
    out = subprocess.run([sys.executable, '-I', FILEID_TOOL, TYPES] + [str(x) for x in sorted(file_ids)],
                         capture_output=True, text=True, encoding='utf-8').stdout
    names = {}
    for line in out.splitlines():
        bits = line.split()
        if len(bits) >= 3:
            names[int(bits[0])] = bits[2]
    return names


# ---------------------------------------------------------------- models
def stage_models():
    models = {}
    for i in range(1, 9):
        d = json.load(open(os.path.join(STAGES, 'BG0%d.json' % i), encoding='utf-8-sig'))
        for m in d['models']:
            models.setdefault(m['name'], []).append('BG0%d' % i)
    return models


def build_models(rows):
    idx = prefab_index()
    entries, pawn_scripts = [], set()
    for model, stages in sorted(stage_models().items()):
        key = db_key(model)
        matches = [r for r in rows if r['key'] == key]
        base = next((r for r in matches if not r['partsName']), None)
        path = pick_prefab(idx, model)
        pawn, npawns = read_pawn(path) if path else (None, 0)
        if pawn: pawn_scripts.add(pawn['script'])
        e = {'model': model, 'key': key, 'stages': stages}
        if base is None:
            e.update({'resolved': False, 'reason': ('no palette row with _targetKey == Mask("%s")' % key) if not matches
                      else 'rows exist only with a _partsName (no base record)'})
        else:
            e.update({'resolved': True, 'row': base['index'], 'health': base['hitpoint'], 'score': base['score'],
                      'lockOn': base['isLockOn'], 'blocksLaser': not base['isBreakthrough'], 'ground': base['isGround'],
                      'rangeFire': base['isRangeFire'], 'damageScore': base['isDamageScore'],
                      'rateTarget': base['isRateTarget'], 'priority': base['priority'], 'size': base['modelSize'],
                      'pipil': base['pipil'], 'jewel': base['jewel'], 'galleryNo': base['galleryNo'],
                      'aliasCnt': base['aliasCnt'] or None, 'tolerance': base['tolerance']})
        item = None
        if pawn and pawn['ruinName'] and pawn['ruinName'].lower() in RUIN_ITEMS:
            item = {'drop': RUIN_ITEMS[pawn['ruinName'].lower()], 'swapDrop': pawn['swapDrop'], 'ruinName': pawn['ruinName']}
        e['item'] = item
        if item is None:
            e['itemNote'] = ('ground wreck/ruin "%s", not an item' % pawn['ruinName']) if pawn and pawn['ruinName'] else \
                'no item on the model; air-enemy drops are set per timeline entry (carrier _drops / ItemReferenceTable)'
        parts = []
        for p in (pawn['parts'] if pawn else []):
            if not p['name']:
                continue
            r = next((r for r in matches if r['partsName'] == p['name']), None)
            parts.append({'name': p['name'], 'flags': p['flags'], 'row': r['index'] if r else None,
                          **({'health': r['hitpoint'], 'score': r['score'], 'lockOn': r['isLockOn'],
                              'blocksLaser': not r['isBreakthrough'], 'priority': r['priority'], 'pipil': r['pipil'],
                              'jewel': r['jewel'], 'size': r['modelSize']} if r else
                             {'note': 'no palette row for this part; SetRecords leaves the prefab values'})})
        if parts: e['parts'] = parts
        unused = [r['index'] for r in matches if r['partsName'] and r['partsName'] not in {p['name'] for p in parts}]
        if unused: e['unmatchedPartRows'] = unused
        e['prefab'] = os.path.relpath(path, ASSETS).replace('\\', '/') if path else None
        if pawn:
            e['prefabPawn'] = {'script': pawn['script'], 'hitPoint': pawn['hitPoint'], 'lockOn': pawn['lockOn'],
                               'laserBlock': pawn['laserBlock'], 'ruinName': pawn['ruinName'], 'pawnComponents': npawns}
        entries.append(e)
    names = class_names(pawn_scripts)
    for e in entries:
        if 'prefabPawn' in e:
            e['prefabPawn']['class'] = names.get(e['prefabPawn']['script'])
    return entries


# ---------------------------------------------------------------- validation
def validate(models):
    by = {m['model']: m for m in models}
    checks = []
    def check(source, subject, field, expected, actual, note=None):
        c = {'source': source, 'subject': subject, 'field': field, 'expected': expected, 'actual': actual,
             'match': expected == actual}
        if note: c['note'] = note
        checks.append(c)
    def load(name):
        return json.load(open(os.path.join(REFS, name), encoding='utf-8-sig'))

    for e in load('round1-combat-balance.json')['enemies']:
        m = by.get(e['name']); src = 'round1-combat-balance.json'
        if not m:
            check(src, e['name'], 'model', e['name'], None, 'model not in any BG0x models list'); continue
        check(src, e['name'], 'databaseKey', e['databaseKey'], m['key'])
        check(src, e['name'], 'health', e['health'], m.get('health'))
        check(src, e['name'], 'prefabDefault', e['prefabDefault'], m.get('prefabPawn', {}).get('hitPoint'),
              'prefab PawnEnemy._HitPoint (overridden by the database at SetRecords)')

    for d in load('round1-ground-enemies.json')['definitions']:
        m = by.get(d['model']); src = 'round1-ground-enemies.json'; subj = '%s (%s)' % (d['name'], d['model'])
        if not m:
            check(src, subj, 'model', d['model'], None, 'model not in any BG0x models list'); continue
        check(src, subj, 'health', d['health'], m.get('health'))
        check(src, subj, 'lockOn', d['lockOn'], m.get('lockOn'))
        check(src, subj, 'laserBlock', d['laserBlock'], m.get('blocksLaser'))
        check(src, subj, 'score', d['score'], m.get('score'))
        check(src, subj, 'item', d['item'], m['item'] is not None)
        check(src, subj, 'drop', d['drop'], m['item']['drop'] if m['item'] else 0)
        check(src, subj, 'swapDrop', d['swapDrop'], m['item']['swapDrop'] if m['item'] else 0)
        # "size" is null in the file; Round1GroundEnemies.Size() hard-codes BMa01/Mx01 as the medium-sized ones.
        check(src, subj, 'size (Round1GroundEnemies.Size rule)',
              'Medium' if d['model'] in ('Pf_Ene_BMa01', 'Pf_Ene_Mx01') else 'Small', m.get('size'),
              'reference JSON stores size=null; expected value is the C# Size() rule')

    for e in load('player-weapon-behavior.json')['enemies']:
        m = by.get(e['name']); src = 'player-weapon-behavior.json'
        if not m:
            check(src, e['name'], 'model', e['name'], None, 'model not in any BG0x models list'); continue
        check(src, e['name'], 'lockOn', e['lockOn'], m.get('lockOn'))
        check(src, e['name'], 'blocksLaser', e['blocksLaser'], m.get('blocksLaser'))
        check(src, e['name'], 'priority', e['priority'], m.get('priority'))

    summary = {}
    for c in checks:
        s = summary.setdefault(c['source'], {'checks': 0, 'matched': 0, 'mismatched': 0})
        s['checks'] += 1; s['matched' if c['match'] else 'mismatched'] += 1
    total = {'checks': len(checks), 'matched': sum(c['match'] for c in checks)}
    total['mismatched'] = total['checks'] - total['matched']
    return {'version': 1, 'summary': summary, 'total': total,
            'mismatches': [c for c in checks if not c['match']], 'checks': checks}


DECODING = (
    "EnemyDatabase.asset (TXEKernel.Enemy.EnemyDataBaseRecords) holds one palette Record per enemy body or part. "
    "_targetKey is KANAI.Unsafe.ProtectValue.Mask(string): every char XOR 0x3C ('}NQc~P]_W' -> 'Arm_Black'). "
    "_hitpoint is a float whose IEEE-754 bits are XOR 0x00CF7A89 (Record.get_hitpoint RVA 0x2721920 -> "
    "ProtectValue.Conversion(float,int) 0x1E2AB10: movd eax,xmm0; xor eax,edx); _score is an int XOR 0x00136ACF "
    "(get_score 0x2721980 -> Conversion(int,int) 0x1E2AA10). Both keys are immediates in the getters, not the "
    "jseed/sseed/pseed literals (those mask the asset-level _mScore/_mJewel/_mPi). _pipil, _jewel, _priority, "
    "_galleryNo, _modelSize (EnemySize Small..BOSS), the tole* fields (toleType normal/veryhigh/high/low/verylow), "
    "_partsName and _aliasCnt are stored in clear. A model finds its rows with GetDatas(prefabName): "
    "key = GetDBKey(name) (split on '_', join pieces 2.. with '_': Pf_Ene_Sa01 -> Sa01, Pf_EneObj_Meteo_La01 -> "
    "Meteo_La01) masked and compared with _targetKey; the row with an empty _partsName is the body, and each prefab "
    "PartsList entry takes the row with its _partsName. isBreakthrough means the laser passes through (blocksLaser = "
    "!isBreakthrough); isLockOn = lock-on target; isGround/isRangeFire/isDamageScore/isRateTarget are copied as is.")


def main():
    rows, meta = read_database()
    models = build_models(rows)
    os.makedirs(os.path.dirname(OUT), exist_ok=True)
    doc = {'version': 1, 'source': 'EnemyDatabase.asset', 'decoding': DECODING, 'assetFields': meta,
           'rows': rows, 'models': models}
    with open(OUT, 'w', encoding='utf-8', newline='\n') as f:
        json.dump(doc, f, indent=1, ensure_ascii=False); f.write('\n')
    v = validate(models)
    odd = [r['index'] for r in rows if not float(r['hitpoint']).is_integer()]
    used = {m['row'] for m in models if m['resolved']} | {p['row'] for m in models for p in m.get('parts', []) if p['row'] is not None}
    v['sanity'] = {'rows': len(rows), 'nonIntegerHitpoints': odd,
                   'rowsNotUsedByAnyStageModel': sorted({r['key'] + ('/' + r['partsName'] if r['partsName'] else '')
                                                         for r in rows if r['index'] not in used}),
                   'negativeScores': [r['index'] for r in rows if r['score'] < 0],
                   'unresolvedModels': [m['model'] for m in models if not m['resolved']]}
    os.makedirs(os.path.dirname(EVIDENCE), exist_ok=True)
    with open(EVIDENCE, 'w', encoding='utf-8', newline='\n') as f:
        json.dump(v, f, indent=1, ensure_ascii=False); f.write('\n')

    print('rows %d, models %d (resolved %d)' % (len(rows), len(models), sum(m['resolved'] for m in models)))
    print('asset fields:', {k: x['decoded'] for k, x in meta.items()})
    print('== validation')
    for src, s in v['summary'].items():
        print('  %-28s %3d checks  %3d matched  %d mismatched' % (src, s['checks'], s['matched'], s['mismatched']))
    print('  %-28s %3d checks  %3d matched  %d mismatched' % ('TOTAL', v['total']['checks'], v['total']['matched'],
                                                              v['total']['mismatched']))
    for c in v['mismatches']:
        print('  MISMATCH %s %s %s expected=%r actual=%r %s' % (c['source'], c['subject'], c['field'], c['expected'],
                                                                c['actual'], c.get('note', '')))
    print('  sanity:', v['sanity'])
    print('wrote', OUT); print('wrote', EVIDENCE)
    return 0 if v['total']['mismatched'] == 0 and not v['sanity']['unresolvedModels'] else 1


if __name__ == '__main__':
    sys.exit(main())
