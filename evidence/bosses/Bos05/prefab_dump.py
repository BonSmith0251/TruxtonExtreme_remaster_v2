"""Resolve Pf_Ene_Bos05 / Pf_EneObj_Bos05_Arm prefab references to transform paths (read-only evidence helper).
usage: C:\\Python311\\python.exe -I prefab_dump.py <prefab> [fileID ...]
Prints: transform path table (localPosition/rotation/scale), every MonoBehaviour with collision-model fields,
and the path of each fileID given."""
import re, sys, collections
path = sys.argv[1]
txt = open(path, encoding='utf-8').read()
docs = {}
for m in re.finditer(r'^--- !u!(\d+) &(-?\d+)(?: stripped)?\n(.*?)(?=^--- |\Z)', txt, re.S | re.M):
    docs[m.group(2)] = (int(m.group(1)), m.group(3))
go_name = {}; comp_go = {}; tr = {}
for fid, (cls, body) in docs.items():
    if cls == 1:
        n = re.search(r'm_Name: ?(.*)', body); go_name[fid] = n.group(1).strip() if n else ''
    g = re.search(r'm_GameObject: \{fileID: (-?\d+)\}', body)
    if g: comp_go[fid] = g.group(1)
    if cls in (4, 224):
        fa = re.search(r'm_Father: \{fileID: (-?\d+)\}', body)
        lp = re.search(r'm_LocalPosition: \{x: ([^,]+), y: ([^,]+), z: ([^}]+)\}', body)
        lr = re.search(r'm_LocalRotation: \{x: ([^,]+), y: ([^,]+), z: ([^,]+), w: ([^}]+)\}', body)
        ls = re.search(r'm_LocalScale: \{x: ([^,]+), y: ([^,]+), z: ([^}]+)\}', body)
        tr[fid] = dict(father=fa.group(1) if fa else '0', go=g.group(1) if g else None,
                       pos=tuple(float(x) for x in lp.groups()) if lp else None,
                       rot=tuple(float(x) for x in lr.groups()) if lr else None,
                       scl=tuple(float(x) for x in ls.groups()) if ls else None)
go_tr = {v['go']: k for k, v in tr.items()}
def tpath(tid):
    out = []
    while tid and tid != '0' and tid in tr:
        out.append(go_name.get(tr[tid]['go'], '?')); tid = tr[tid]['father']
    return '/'.join(reversed(out))
def ref(fid):
    if fid in tr: return 'T:' + tpath(fid)
    if fid in comp_go:
        cls = docs[fid][0]
        return '%s:%s' % ({23: 'MeshRenderer', 137: 'SkinnedMR', 114: 'MB', 95: 'Animator'}.get(cls, 'c%d' % cls), tpath(go_tr.get(comp_go[fid])))
    if fid in go_name: return 'GO:' + tpath(go_tr.get(fid))
    return '?' + fid
if __name__ == '__main__':
    print('# transforms')
    for tid in sorted(tr, key=tpath):
        t = tr[tid]
        print('%-70s pos=%s rot=%s scl=%s' % (tpath(tid), t['pos'], t['rot'], t['scl']))
    print('# monobehaviours')
    for fid, (cls, body) in docs.items():
        if cls == 114:
            s = re.search(r'm_Script: \{fileID: (-?\d+)', body).group(1)
            fields = [l for l in body.split('\n') if re.match(r'  [_A-Za-z]', l) and not l.startswith('  m_')]
            print('MB', fid, 'script', s, 'on', tpath(go_tr.get(comp_go.get(fid))))
            for l in fields[:40]: print('    ', l.strip()[:160])
        if cls == 95:
            print('Animator on', tpath(go_tr.get(comp_go.get(fid))), re.search(r'm_Controller: (.*)', body).group(1))
    for f in sys.argv[2:]: print(f, ref(f))
