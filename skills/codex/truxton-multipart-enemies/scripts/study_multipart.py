"""Study how a multi-part TATSUJIN EXTREME enemy is built and destroyed, from its original prefab.

For each prefab: every PawnEnemy-derived component (its script class), PartsList (name, flags, BreakEffect, renderer and
collision counts, _damageObject path), _deadExplosion, _explosionOffset, _delayDeadTime / _delayDeadVector, the
_explosionOrder resolved to component paths (each _target is a MeshRenderer that is hidden; _ekind is the Explosion enum
mapped to its prefab; _effectTransform is where it plays), and summon fields (_summonNameStr, _summonEnemyCount,
_children, _isChildrenSolidarity, _deadEnemyStr). Prints JSON; --out writes it.

Usage (from the game folder, extractor/ on sys.path is added automatically):
  C:\\Python311\\python.exe study_multipart.py Pf_Ene_Lb01 Pf_Ene_Mj01h [--out file.json]
"""
import argparse, json, sys
from pathlib import Path

GAME = Path(r'D:/games/Truxton Extreme')
sys.path.insert(0, str(GAME / 'extractor'))
from export_selection import Index, ROOT, safe_tree  # noqa: E402
from extract_enemy_colliders import transform_of  # noqa: E402

# Native enum InGame.Kernel.Enemy.Explosion (metadata): None 0, E4Little 1, E1Small 2, E2Middle 3, E3Large 4, E5Huge 5,
# Meteo01..03 6..8. The E-number names the prefab.
EXPLOSIONS = {0: None, 1: 'pf_eff_explposion04', 2: 'pf_eff_explposion01', 3: 'pf_eff_explposion02', 4: 'pf_eff_explposion03',
              5: 'pf_eff_explposion05', 6: 'pf_eff_explosion_meteor01', 7: 'pf_eff_explosion_meteor02', 8: 'pf_eff_explosion_meteor03'}
SUMMON = ('_summonNameStr', '_summonEnemyCount', '_isChildrenSolidarity', '_deadEnemyStr', '_separationParent', '_deadEnemyIsGround')


def walk(idx, g, path=''):
    yield g, path
    t = transform_of(idx, None, g)
    for ch in idx.tree(t).get('m_Children', []):
        c = idx.ref(t[0], idx.tree(idx.ref(t[0], ch))['m_GameObject'])
        name = idx.tree(c)['m_Name']
        yield from walk(idx, c, f'{path}/{name}' if path else name)


def script(idx, k, d):
    try:
        return idx.tree(idx.ref(k[0], d['m_Script']))['m_ClassName']
    except Exception:
        return ''


def study(idx, model):
    prefab = idx.select(model + '.prefab')
    where = {}  # path id of GameObject / Transform / component -> (path, kind)
    pawns = []
    for go, path in walk(idx, prefab):
        where[go[1]] = (path, 'GameObject')
        for c in idx.tree(go)['m_Component']:
            k = idx.ref(go[0], c['component'])
            where[k[1]] = (path, idx.obj(k).type.name)
    for go, path in walk(idx, prefab):
        for c in idx.tree(go)['m_Component']:
            k = idx.ref(go[0], c['component']); d = idx.tree(k)
            if '_deadExplosion' not in d:
                continue
            ref = lambda p: where.get(int(p['m_PathID']), (None,))[0] if p and int(p['m_PathID']) else None
            pawn = dict(path=path, script=script(idx, k, d), hitPoint=d.get('_HitPoint'), lockOn=bool(d.get('_isLockonTarget')),
                        laserBlock=bool(d.get('_isLaserBlock')), simpleCalc=bool(d.get('_isSimpleCalc')),
                        deadExplosion=d['_deadExplosion'], explosionOffset=safe_tree(d.get('_explosionOffset')),
                        deadSound=d.get('_overplayDeadSound'), delayDeadTime=d.get('_delayDeadTime'),
                        delayDeadVector=safe_tree(d.get('_delayDeadVector')),
                        parts=[dict(name=p.get('_partsName'), flags=p.get('_partsFlags'), breakEffect=p.get('BreakEffect'),
                                    renderers=len(p.get('_renderers', [])), collisions=len(p.get('_collisions', [])),
                                    damageObject=ref(p.get('_damageObject')), explosionRoot=ref(p.get('_explosionRoot')),
                                    breakToAwake=len(p.get('_breakToAwake', [])))
                               for p in d.get('PartsList', [])],
                        explosionOrder=[dict(wait=round(e['_WaitTime'], 3), kind=e['_ekind'], effect=EXPLOSIONS.get(e['_ekind']),
                                             target=where.get(int(e['_target']['m_PathID']), (e['_target']['m_PathID'], '?')),
                                             at=ref(e.get('_effectTransform')))
                                        for e in d.get('_explosionOrder', [])],
                        summon={f: safe_tree(d[f]) for f in SUMMON if f in d},
                        children=len(d.get('_children', [])) if '_children' in d else None)
            pawns.append(pawn)
    return dict(model=model, pawns=pawns)


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument('models', nargs='+')
    ap.add_argument('--out')
    a = ap.parse_args()
    idx = Index(ROOT)
    result = [study(idx, m) for m in a.models]
    text = json.dumps(result, indent=1)
    if a.out:
        Path(a.out).write_text(text)
    print(text)


if __name__ == '__main__':
    main()
