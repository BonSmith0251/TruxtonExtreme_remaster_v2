"""Read-only Pf_Ene_Bos02.prefab helper: transform paths and fileID resolution. python -I prefab.py <prefab> [paths|resolve fid..|grep text]"""
import sys, re
txt = open(sys.argv[1], encoding='utf-8').read()
docs = re.split(r'^--- !u!(\d+) &(-?\d+).*$', txt, flags=re.M)
objs = {}
for i in range(1, len(docs), 3): objs[docs[i + 1]] = (docs[i], docs[i + 2])
name = {}; father = {}; go_of = {}; tr_of_go = {}
for fid, (cls, body) in objs.items():
    if cls == '1':
        m = re.search(r'm_Name: (.*)', body); name[fid] = m.group(1).strip() if m else '?'
    if cls in ('4', '224'):
        g = re.search(r'm_GameObject: \{fileID: (-?\d+)\}', body).group(1); go_of[fid] = g; tr_of_go[g] = fid
        f = re.search(r'm_Father: \{fileID: (-?\d+)\}', body); father[fid] = f.group(1) if f else '0'
def tpath(t):
    p = []
    while t and t != '0' and t in go_of:
        p.append(name.get(go_of[t], '?')); t = father.get(t, '0')
    return '/'.join(reversed(p))
def resolve(fid):
    if fid in go_of: return 'T:' + tpath(fid)
    if fid in objs:
        cls, body = objs[fid]
        m = re.search(r'm_GameObject: \{fileID: (-?\d+)\}', body)
        if m: return 'C%s on %s' % (cls, tpath(tr_of_go.get(m.group(1), '0')))
        if cls == '1': return 'GO:' + tpath(tr_of_go.get(fid, '0'))
    return '?'
mode = sys.argv[2] if len(sys.argv) > 2 else 'paths'
if mode == 'paths':
    for t in sorted(go_of, key=tpath):
        b = objs[t][1]; lp = re.search(r'm_LocalPosition: (\{.*?\})', b); lr = re.search(r'm_LocalRotation: (\{.*?\})', b); ls = re.search(r'm_LocalScale: (\{.*?\})', b)
        print(t, tpath(t), lp.group(1) if lp else '', lr.group(1) if lr else '', ls.group(1) if ls else '')
elif mode == 'resolve':
    for f in sys.argv[3:]: print(f, resolve(f))
elif mode == 'mb':  # dump MonoBehaviours whose body contains text, with fileIDs resolved
    for fid, (cls, body) in objs.items():
        if cls == '114' and sys.argv[3] in body:
            print('=== MB', fid, resolve(fid))
            print(re.sub(r'\{fileID: (-?\d+)\}', lambda m: '{%s=%s}' % (m.group(1), resolve(m.group(1)) if m.group(1) != '0' else 'null'), body))
