"""Models that flash when hit and blink when damaged, for Round1Effects, from the original prefabs' materials.

PawnEnemy's EnePartsGroup writes _FadeColor (damage blink) and the hit flash on its renderers' materials; only TXE_Lit has
_FadeColor, so a model blinks when its prefab draws with TXE_Lit (TATSUJIN/TXE_Lit or TXEKernel TXE_Lit). Item and colour
boxes use other shaders and never blink. Source: Reconstructed/Assets/OriginalGame/**/Pf_*.prefab (flat rips; a
material is read from each MeshRenderer / SkinnedMeshRenderer m_Materials). Round1Effects' BG03 hand list must be a subset.
Writes Assets/Resources/StageCombat/enemy-blink-models.json and evidence/stage-enemies/blink-models-validation.json.
"""
import glob, json, os, re

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
ASSETS = os.path.join(BASE, 'Reconstructed', 'Assets')
OUT = os.path.join(ASSETS, 'Resources', 'StageCombat', 'enemy-blink-models.json')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-enemies', 'blink-models-validation.json')
HAND = ['Pf_EneObj_Meteo_Sa02', 'Pf_EneObj_Meteo_Ma02', 'Pf_EneObj_Meteo_La02', 'Pf_Ene_Sa01', 'Pf_Ene_Se01', 'Pf_Ene_Sd01',
        'Pf_Ene_Md01', 'Pf_Ene_Mj01h', 'Pf_Ene_Mj01b', 'Pf_Ene_Ma01', 'Pf_Ene_Me01', 'Pf_Ene_Lb01', 'Pf_Ene_BSa01', 'Pf_Ene_BSb01',
        'Pf_Ene_BSc01', 'Pf_Ene_BMa01', 'Pf_Ene_Mx01']
NEVER = ['Pf_Item_Box01', 'Pf_Item_Box02', 'Pf_BGObj_ColorBox01', 'Pf_BGObj_ColorBox00_UN']
RENDERER = re.compile(r'^--- !u!(23|137) &', re.M)


def guid_paths():
    paths = {}
    for meta in glob.glob(os.path.join(ASSETS, '**', '*.meta'), recursive=True):
        try:
            m = re.search(r'^guid: (\w+)', open(meta, encoding='utf-8', errors='ignore').read(4000), re.M)
        except OSError:
            continue
        if m:
            paths[m.group(1)] = meta[:-5]
    return paths


def main():
    paths = guid_paths()
    lit = {g for g, p in paths.items() if p.endswith('.shader') and 'TXE_Lit' in os.path.basename(p)}
    shader_of = {}

    def txe(material_guid):
        if material_guid not in shader_of:
            p = paths.get(material_guid, '')
            s = None
            if p.endswith('.mat'):
                m = re.search(r'm_Shader: \{fileID: -?\d+, guid: (\w+)', open(p, encoding='utf-8', errors='ignore').read())
                s = m and m.group(1)
            shader_of[material_guid] = s in lit
        return shader_of[material_guid]

    models = {}
    for path in sorted(glob.glob(os.path.join(ASSETS, 'OriginalGame', '**', 'Pf_*.prefab'), recursive=True)):
        name = os.path.splitext(os.path.basename(path))[0]
        if name in models:
            continue
        text = open(path, encoding='utf-8', errors='replace').read()
        guids = []
        for doc in re.split(r'^--- ', text, flags=re.M):
            if doc.startswith('!u!23 ') or doc.startswith('!u!137 '):
                block = doc.split('m_Materials:', 1)[1] if 'm_Materials:' in doc else ''
                block = re.split(r'\n  m_\w+:', block, maxsplit=1)[0]
                guids += re.findall(r'guid: (\w+)', block)
        models[name] = any(txe(g) for g in guids)
    rows = sorted(n for n, b in models.items() if b)
    json.dump({'models': rows}, open(OUT, 'w', encoding='utf-8', newline='\n'), indent=1)
    report = {'models': len(rows), 'hand_missing': [n for n in HAND if n not in rows],
              'never_listed': [n for n in NEVER if n in rows], 'no_txe_lit': sorted(n for n, b in models.items() if not b)}
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    json.dump(report, open(VALIDATION, 'w', encoding='utf-8', newline='\n'), indent=1)
    print(len(rows), 'of', len(models), 'models blink; hand list missing:', report['hand_missing'],
          '; boxes listed:', report['never_listed'])


if __name__ == '__main__':
    main()
