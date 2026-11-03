"""Points StagePlay_BG03's enemy visuals for the meteors at the original prefabs every other stage uses.

BG03 was built from the Round1 remaster, whose meteors are Assets/Prefabs/Enemies/Pf_EneObj_Meteo_{Sa,Ma,La}02 (their own
copies of the mesh and a URP Lit material). OriginalGame/Pf_EneObj_Meteo_*02 are the game's prefabs (TXE_Lit, nesting
TXE_GraphicData/Enemy/EneObj/Prefabs/pf_ene_obj_meteo_*), the same geometry and transforms. Only the visuals entries
('prefab: {fileID: <root>, guid: <prefab>}') change; the old Round1/Stage01 scenes keep theirs. Backs the scene up first.
"""
import os, re, shutil, time

ROOT = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
ASSETS = os.path.join(ROOT, 'Reconstructed', 'Assets')
SCENE = os.path.join(ASSETS, 'Scenes', 'StagePlay', 'StagePlay_BG03.unity')


def guid(path):
    return re.search(r'^guid: (\w+)', open(path + '.meta', encoding='utf-8').read(), re.M).group(1)


def root_go(path):
    text = open(path, encoding='utf-8').read()
    for doc in re.split(r'^--- ', text, flags=re.M):
        if doc.startswith('!u!4 ') and re.search(r'^  m_Father: \{fileID: 0\}', doc, re.M):
            return re.search(r'm_GameObject: \{fileID: (\d+)\}', doc).group(1)
    raise SystemExit('no root in ' + path)


def main():
    text = open(SCENE, encoding='utf-8', newline='').read()
    backup = os.path.join(ROOT, 'Backups', 'before-shared-meteors-' + time.strftime('%Y%m%dT%H%M%S'))
    os.makedirs(backup, exist_ok=True); shutil.copy2(SCENE, backup); shutil.copy2(SCENE + '.meta', backup)
    for size in ('Sa', 'Ma', 'La'):
        old = os.path.join(ASSETS, 'Prefabs', 'Enemies', f'Pf_EneObj_Meteo_{size}02.prefab')
        new = os.path.join(ASSETS, 'OriginalGame', f'Pf_EneObj_Meteo_{size}02.prefab')
        a = f'prefab: {{fileID: {root_go(old)}, guid: {guid(old)}, type: 3}}'
        b = f'prefab: {{fileID: {root_go(new)}, guid: {guid(new)}, type: 3}}'
        n = text.count(a)
        text = text.replace(a, b)
        print(f'Pf_EneObj_Meteo_{size}02: {n} visual entr{"y" if n == 1 else "ies"} -> OriginalGame')
    open(SCENE, 'w', encoding='utf-8', newline='').write(text)
    print('backup', backup)


if __name__ == '__main__':
    main()
