"""Recover how the original game wires sounds: id enums from IL2CPP metadata and every
serialized component field that carries an SE/BGM id. Game files are read-only.

Outputs (under --out, default extractor/sound-source):
  sound-ids.json     enum name -> {id: clip name} for ID, BGM, ExpSound, InGameBGM, BossBGM
  sound-wiring.json  one row per component instance with its sound fields, GameObject and
                     prefab/container names, resolved to clip names where the id is an SE/BGM

  python recover_sound_wiring.py --root "D:/games/Truxton Extreme"
"""
import argparse, gc, json, re, struct
from collections import Counter, defaultdict
from pathlib import Path

import UnityPy

# script class -> fields that hold sound ids (or data that selects one)
SOUND_FIELDS = {
    'InGameEffect': ['_callSoundID', '_timelimitSecond'],
    'EffectScore5000': ['_callSoundID'],
    'ItemCollision': ['_getSound'],
    'WeaponNormalShot': ['_armKind', '_requestSounds', '_pipiruShotSound'],
    'WeaponGrowShot': ['_armKind', '_requestSounds', '_pipiruShotSound'],
    'WeaponLaserShot': ['_armKind', '_requestLptSounds', '_pipiruShotSound'],
    'WeaponLaserCollision': ['_lockOnSE'], 'WeaponBLaserCollision': ['_lockOnSE'],
    'WeaponGoldCollision': ['_lockOnSE'], 'WeaponGoldCollisionChild': ['_lockOnSE'],
    'EnemyLaserCollision': ['_firstSound', '_loopSound'], 'EnemyLaserCollision2': ['_loopSound'],
    'EnemySEPlayer': ['_appearSE', '_bastaredSE'],
    'SimpleMoveRocket': ['_fireSound', '_fireSoundSec'],
    'InGameEnemyBomber': ['_hitSoundID'], 'InGameNapalm': ['_hitSoundID'],
    'InGameBulletBow': ['_spawnSound'],
    'InGameResident': ['_bulletSEPalette'],
    'Ene_Mn01c': ['_attachSE'], 'Ene_Bos01': ['_ShortLaserSEVolume'],
    'StagePlayList': None, 'BGMPlayList': None, 'BulletSounds': None,
    'BGMEntryClip': None, 'BGMEntryBehaviour': None,
    'BulletTemplate': ['bulletName', 'nSoundLap', 'nRapidCount', 'SeKind', 'isLaser'],
    'SoundDataBaseRecords': None, 'EffectPalette': None,
}
DEAD_FIELDS = ['_deadExplosion', '_overplayDeadSound', '_explosionOffset']


def metadata_enums(root, wanted=('ID', 'BGM', 'ExpSound', 'InGameBGM', 'BossBGM')):
    meta = (root/'TATSUJIN EXTREME_Data/il2cpp_data/Metadata/global-metadata.dat').read_bytes()
    assert struct.unpack_from('<II', meta) == (0xFAB11BAF, 39), 'metadata version changed'
    sec = [struct.unpack_from('<III', meta, 8+i*12) for i in range(31)]
    def table(i, fmt):
        off, size, count = sec[i]; n = struct.calcsize(fmt)
        return [struct.unpack_from(fmt, meta, off+k*n) for k in range(count)]
    def s(i):
        o = sec[2][0]+i
        return meta[o:meta.index(b'\0', o)].decode('utf-8', 'replace')
    def cint(o):  # metadata v29+ compressed uint32, then zigzag for signed
        b = meta[o]
        if b & 0x80 == 0: v = b
        elif b & 0xC0 == 0x80: v = ((b & 0x3F) << 8) | meta[o+1]
        elif b & 0xE0 == 0xC0: v = ((b & 0x1F) << 24) | (meta[o+1] << 16) | (meta[o+2] << 8) | meta[o+3]
        elif b == 0xF0: v = struct.unpack_from('<I', meta, o+1)[0]
        else: raise ValueError(hex(b))
        return (v >> 1) ^ -(v & 1)
    types = table(19, '<IIiiiH9I8HII'); fields = table(11, '<III')
    defaults = {d[0]: d for d in table(7, '<III')}
    out = {}
    for t in types:
        name = s(t[0])
        if name not in wanted or s(t[1]) != '':
            continue
        values = {}
        for fi in range(t[7], t[7]+t[17]):
            if fi in defaults:
                values[cint(sec[8][0]+defaults[fi][2])] = s(fields[fi][0])
        if name == 'ID' and 'exp_fighter' not in values.values():
            continue  # other nested enums are also called ID
        out[name] = {str(k): v for k, v in sorted(values.items())}
    missing = set(wanted) - set(out)
    assert not missing, f'enums not found: {missing}'
    return out


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--root', default='D:/games/Truxton Extreme')
    ap.add_argument('--out', default='extractor/sound-source')
    a = ap.parse_args()
    root = Path(a.root); out = root/a.out; out.mkdir(parents=True, exist_ok=True)
    enums = metadata_enums(root)
    (out/'sound-ids.json').write_text(json.dumps(enums, indent=1), encoding='utf-8')
    se, bgm = enums['ID'], enums['BGM']

    scripts = {}
    for line in (root/'analysis/objects.jsonl').open(encoding='utf-8'):
        if '"MonoScript"' in line:
            r = json.loads(line)
            scripts[(r['serialized_file'].lower(), int(r['path_id']))] = r['details'].get('m_ClassName', '')
    inv = json.loads((root/'analysis/inventory.json').read_text(encoding='utf-8'))
    containers = defaultdict(list)
    for src in inv['sources']:
        for c in src.get('containers', []):
            containers[(c['serialized_file'].lower(), int(c['path_id']))].append(c['name'])

    rows, counts = [], Counter()
    for src in inv['sources']:
        if not src.get('serialized_files'):
            continue
        try:
            env = UnityPy.load(str(root/src['source']))
        except Exception:
            continue
        for asset in env.assets:
            cab = asset.name.lower()
            ext = [x.path.replace('\\', '/').split('/')[-1].lower() for x in asset.externals]
            def key(ptr):
                return None if not ptr['m_PathID'] else (cab if ptr['m_FileID'] == 0 else ext[ptr['m_FileID']-1], int(ptr['m_PathID']))
            go_names, parents, go_of_tr, tr_of_go = {}, {}, {}, {}
            for obj in asset.objects.values():
                if obj.type.name == 'GameObject':
                    go_names[obj.path_id] = obj.peek_name()
            for obj in asset.objects.values():
                if obj.type.name != 'MonoBehaviour':
                    continue
                try:
                    tree = obj.read_typetree()
                except Exception:
                    continue
                cls = scripts.get(key(tree['m_Script']) or ('', 0), '')
                dead = all(f in tree for f in DEAD_FIELDS[:2])
                if cls not in SOUND_FIELDS and not dead:
                    continue
                wanted = SOUND_FIELDS.get(cls)
                data = {k: v for k, v in tree.items() if not k.startswith('m_')} if wanted is None else \
                       {k: tree[k] for k in (wanted or []) if k in tree}
                if dead:
                    data.update({k: tree[k] for k in DEAD_FIELDS if k in tree})
                go = tree.get('m_GameObject', {}).get('m_PathID', 0)
                rows.append(dict(script=cls, name=tree.get('m_Name', ''), gameObject=go_names.get(go, ''),
                                 containers=containers.get((cab, go), []) or containers.get((cab, obj.path_id), []),
                                 source=src['source'].split('/')[-1], cab=cab, pathId=str(obj.path_id),
                                 goPathId=str(go), data=json.loads(json.dumps(data, default=str))))
                counts[cls or 'dead-enemy'] += 1
        del env; gc.collect()

    def label(v):
        return se.get(str(v)) if isinstance(v, int) else None
    for r in rows:
        r['clips'] = {}
        def visit(v, path):
            if isinstance(v, dict):
                for k, x in v.items(): visit(x, f'{path}.{k}' if path else k)
            elif isinstance(v, list):
                for i, x in enumerate(v): visit(x, f'{path}[{i}]')
            elif isinstance(v, int) and not isinstance(v, bool):
                leaf = re.sub(r'\[\d+\]$', '', path.split('.')[-1]).lower()
                if 'bgm' in leaf or leaf in ('_ontheway1', '_ontheway2', '_boss', '_outset', '_epilogue', '_finale'):
                    if str(v) in bgm: r['clips'][path] = bgm[str(v)]
                elif re.search(r'(sound|se)(s|id)?$', leaf) and 'lap' not in leaf and label(v):
                    r['clips'][path] = label(v)
        visit(r['data'], '')
    (out/'sound-wiring.json').write_text(json.dumps(dict(counts=counts, rows=rows), indent=1), encoding='utf-8')

    # SoundDatabase (TXEKernel.Sound.SoundDataBaseRecords): per-clip volume, polyphony and loop
    # flags. Strings are XOR 0x3c, the same ProtectValue scheme as EnemyDatabase.
    db = [r for r in rows if r['script'] == 'SoundDataBaseRecords']
    assert len(db) == 1, f'expected one SoundDatabase, found {len(db)}'
    unmask = lambda s: ''.join(chr(ord(c) ^ 0x3c) for c in s)
    records = []
    for p in db[0]['data']['palette']:
        rec = dict(p, clip=unmask(p['_targetKey']), displayName=unmask(p['_displayname']))
        del rec['_targetKey'], rec['_displayname']
        records.append(rec)
    (out/'sound-database.json').write_text(json.dumps(dict(source=db[0]['source'], cab=db[0]['cab'], pathId=db[0]['pathId'],
                                                            records=records), indent=1), encoding='utf-8')
    counts['soundDatabaseRecords'] = len(records)
    print(json.dumps(counts, indent=1))


if __name__ == '__main__':
    main()
