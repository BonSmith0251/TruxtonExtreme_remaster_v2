"""Dump Pf_Ene_Bos04 serialized values used by Ene_Bos04 (read-only)."""
import re, json, sys, pathlib
P = pathlib.Path(r'D:\games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\Samples\Prefabs\Reference\Enemy')
def load(path):
    t = path.read_text(encoding='utf-8')
    docs = {}
    for m in re.finditer(r'--- !u!(\d+) &(-?\d+)[^\n]*\n(.*?)(?=\n--- |\Z)', t, re.S):
        docs[m.group(2)] = (int(m.group(1)), m.group(3))
    return docs
def tf_paths(docs):
    names = {}; father = {}; go_of = {}; tf_of_go = {}
    for i, (c, body) in docs.items():
        if c == 1:
            names[i] = re.search(r'm_Name: (.*)', body).group(1).strip()
        if c in (4, 224):
            g = re.search(r'm_GameObject: \{fileID: (-?\d+)\}', body).group(1)
            f = re.search(r'm_Father: \{fileID: (-?\d+)\}', body).group(1)
            go_of[i] = g; father[i] = f; tf_of_go[g] = i
    def path(tid):
        out = []
        while tid and tid != '0':
            out.append(names.get(go_of.get(tid), '?')); tid = father.get(tid, '0')
        return '/'.join(reversed(out))
    return path, go_of, tf_of_go, names
def localTRS(docs, tid):
    body = docs[tid][1]
    g = lambda k: re.search(k + r': \{x: ([^,]+), y: ([^,]+), z: ([^,}]+)(?:, w: ([^}]+))?\}', body)
    r = g('m_LocalRotation'); p = g('m_LocalPosition'); s = g('m_LocalScale')
    return dict(pos=[float(x) for x in p.groups()[:3]], rot=[float(x) for x in r.groups()], scale=[float(x) for x in s.groups()[:3]])
def curves(body, name):
    m = re.search(r'\n  %s:\n    serializedVersion: 2\n    m_Curve:\n(.*?)\n    m_PreInfinity: (\d+)\n    m_PostInfinity: (\d+)' % name, body, re.S)
    keys = []
    for k in re.finditer(r'time: ([^\n]+)\n\s+value: ([^\n]+)\n\s+inSlope: ([^\n]+)\n\s+outSlope: ([^\n]+)\n(?:\s+tangentMode: [^\n]+\n)?\s+weightedMode: ([^\n]+)\n\s+inWeight: ([^\n]+)\n\s+outWeight: ([^\n]+)', m.group(1)):
        keys.append([float(k.group(i)) for i in (1, 2, 3, 4)] + [int(k.group(5)), float(k.group(6)), float(k.group(7))])
    return dict(keys_time_value_inSlope_outSlope_weightedMode_inW_outW=keys, preInfinity=int(m.group(2)), postInfinity=int(m.group(3)))
def main():
    docs = load(P/'Pf_Ene_Bos04.prefab')
    path, go_of, tf_of_go, names = tf_paths(docs)
    out = {}
    boss = [b for c, b in docs.values() if c == 114 and '_wings:' in b][0]
    mover = [b for c, b in docs.values() if c == 114 and '_muzzlePacks:' in b][0]
    fid = lambda s: re.findall(r'\{fileID: (-?\d+)\}', s)
    out['modelTop'] = path(re.search(r'_modelTop: \{fileID: (-?\d+)\}', boss).group(1))
    out['upperCore'] = path(re.search(r'_upperCore: \{fileID: (-?\d+)\}', boss).group(1))
    out['wings'] = [path(x) for x in fid(boss.split('_wings:')[1].split('_upperCore')[0])]
    for k in ['_HitPoint', '_deadExplosion', '_overplayDeadSound', '_explosionOffset', '_isSimpleCalc', '_isLockonTarget', '_isLaserBlock']:
        m = re.search(r'\n  %s: ([^\n]*)' % k, boss); out[k] = m.group(1) if m else None
    out['curves'] = {n: curves(boss, n) for n in ['_pattern1EaseIn', '_pattern1EaseOut', '_pattern2EaseInOut', '_pattern3Position', '_pattern3RotateX', '_pattern5EaseIn', '_patternOpenWing']}
    packs = {}
    for m in re.finditer(r'- keyName: (\w+)\n    muzzles:\n((?:    - \{fileID: -?\d+\}\n?)+)', mover):
        packs[m.group(1)] = [dict(path=path(x), **localTRS(docs, x)) for x in fid(m.group(2))]
    out['muzzlePacks'] = packs
    # Boss04MZ muzzles: FindAlls(modelTop, name)
    mz = ['muzzle_body_under20', 'muzzle_body_under40', 'muzzle_body_under60', 'muzzle_body_under80', 'muzzle_body_under_ene_sg',
          'muzzle_body_upper02', 'muzzle_body_upper04', 'muzzle_body_upper05', 'muzzle_body_upper06', 'muzzle_body_upper08']
    tfs = [i for i, (c, _) in docs.items() if c in (4, 224)]
    out['Boss04MZ'] = {}
    for n in mz:
        hits = [dict(path=path(t), **localTRS(docs, t)) for t in tfs if names.get(go_of[t]) == n]
        out['Boss04MZ'][n] = hits
    for key in ['modelTop', 'upperCore']:
        pass
    # transforms of interest with local TRS
    interest = {}
    for t in tfs:
        p = path(t)
        if p.count('/') <= 3 or any(s in p for s in ('wing', 'core', 'collision', 'upper', 'target')):
            interest[p] = localTRS(docs, t)
    out['transforms'] = dict(sorted(interest.items()))
    # animators
    out['animator'] = [re.search(r'm_Controller: \{fileID: (-?\d+)(?:, guid: (\w+))?', b).groups() for c, b in docs.values() if c == 95]
    bit = load(P/'Pf_Ene_Bos04_bit.prefab')
    bpath = tf_paths(bit)[0]
    bb = [b for c, b in bit.values() if c == 114 and '_HitPoint' in b]
    out['bit'] = dict(scripts=[re.search(r'm_Script: \{fileID: (-?\d+)', b).group(1) for c, b in bit.values() if c == 114],
                      body={k: (re.search(r'\n  %s: ([^\n]*)' % k, bb[0]).group(1) if bb and re.search(r'\n  %s: ([^\n]*)' % k, bb[0]) else None)
                            for k in ['_HitPoint', '_deadExplosion', '_overplayDeadSound', '_isLockonTarget', '_isLaserBlock']},
                      transforms={bpath(i): localTRS(bit, i) for i, (c, _) in bit.items() if c in (4, 224)})
    json.dump(out, open(sys.argv[1], 'w'), indent=1)
main()
