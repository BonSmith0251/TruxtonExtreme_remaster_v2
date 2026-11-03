"""Every original model's death explosion for Round1Effects, from the prefabs' PawnEnemy fields.

Source: Reconstructed/Assets/OriginalGame/**/*.prefab. PawnEnemy._deadExplosion names the InGameEffectManager
explosion (pf_eff_explposion01..06, meteor01..03, ...) and _explosionOffset is its model-local offset (Y up).
Round1Effects keeps its hand table for the BG03 models (validated against recordings) and reads this file for the rest;
the BG03 entries must come out identical. Writes Assets/Resources/StageCombat/enemy-dead-explosions.json and
evidence/stage-enemies/dead-explosions-validation.json.
"""
import glob, json, os, re

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
ASSETS = os.path.join(BASE, 'Reconstructed', 'Assets')
OUT = os.path.join(ASSETS, 'Resources', 'StageCombat', 'enemy-dead-explosions.json')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-enemies', 'dead-explosions-validation.json')
# Round1Effects.DeadExplosions (BG03): model -> (effect, offset y).
HAND = {'Pf_EneObj_Meteo_Sa02': ('pf_eff_explosion_meteor01', 0), 'Pf_EneObj_Meteo_Ma02': ('pf_eff_explosion_meteor02', 0),
        'Pf_EneObj_Meteo_La02': ('pf_eff_explosion_meteor03', 0), 'Pf_Ene_Sa01': ('pf_eff_explposion01', 0),
        'Pf_Ene_Se01': ('pf_eff_explposion01', 0), 'Pf_Ene_Sd01': ('pf_eff_explposion01', 0), 'Pf_Ene_Md01': ('pf_eff_explposion02', 0),
        'Pf_Ene_Mj01b': ('pf_eff_explposion01', 0), 'Pf_Ene_Mj01h': ('pf_eff_explposion02', 0), 'Pf_Ene_Ma01': ('pf_eff_explposion03', 0),
        'Pf_Ene_Me01': ('pf_eff_explposion03', 0), 'Pf_Ene_BSa01': ('pf_eff_explposion01', 10), 'Pf_Ene_BSc01': ('pf_eff_explposion01', 10),
        'Pf_Ene_BSb01': ('pf_eff_explposion04', 10), 'Pf_Ene_BMa01': ('pf_eff_explposion02', 20), 'Pf_Ene_Mx01': ('pf_eff_explposion02', 5),
        'Pf_Item_Box01': ('pf_eff_explposion01', -3), 'Pf_Item_Box02': ('pf_eff_explposion01', 5),
        'Pf_BGObj_ColorBox01': ('pf_eff_explposion01', 20), 'Pf_BGObj_ColorBox00_UN': ('pf_eff_explposion01', 20)}
FIELD = re.compile(r'^  _deadExplosion: ?(\S*)\s*$', re.M)
OFFSET = re.compile(r'^  _explosionOffset: \{x: ([-\d.e]+), y: ([-\d.e]+), z: ([-\d.e]+)\}', re.M)


def main():
    models, report = {}, {'duplicates': [], 'hand': {}}
    for path in sorted(glob.glob(os.path.join(ASSETS, 'OriginalGame', '**', '*.prefab'), recursive=True)):
        text = open(path, encoding='utf-8', errors='replace').read()
        m = FIELD.search(text)
        if not m:
            continue
        o = OFFSET.search(text, m.end())
        name = os.path.splitext(os.path.basename(path))[0]
        row = {'model': name, 'effect': m.group(1),
               'offset': {k: float(v) for k, v in zip('xyz', o.groups())} if o else {'x': 0, 'y': 0, 'z': 0}}
        if name in models:
            if models[name] != row:
                report['duplicates'].append(name)
            continue
        models[name] = row
    for name, (effect, up) in HAND.items():
        row = models.get(name)
        same = bool(row) and row['effect'] == effect and row['offset'] == {'x': 0, 'y': float(up), 'z': 0}
        report['hand'][name] = 'same' if same else 'differs: ' + json.dumps(row)
    rows = [r for r in models.values() if r['effect']]
    json.dump({'models': rows}, open(OUT, 'w', encoding='utf-8', newline='\n'), indent=1)
    report['models'] = len(rows)
    report['empty'] = sorted(n for n, r in models.items() if not r['effect'])
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    json.dump(report, open(VALIDATION, 'w', encoding='utf-8', newline='\n'), indent=1)
    differs = {k: v for k, v in report['hand'].items() if v != 'same'}
    print(len(rows), 'models;', len(report['hand']) - len(differs), '/', len(HAND), 'hand entries identical')
    for k, v in differs.items():
        print(' ', k, v)
    if report['duplicates']:
        print('conflicting duplicates:', report['duplicates'])


if __name__ == '__main__':
    main()
