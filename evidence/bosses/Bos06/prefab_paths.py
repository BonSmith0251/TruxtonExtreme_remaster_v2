"""Resolve fileIDs in Pf_Ene_Bos06.prefab to transform paths (read-only). Usage: python -I prefab_paths.py <prefab> [fileID ...]"""
import sys, re
txt = open(sys.argv[1], encoding='utf-8').read()
docs = re.split(r'^--- !u!(\d+) &(\d+).*$', txt, flags=re.M)
objs = {}
for i in range(1, len(docs), 3):
    objs[docs[i + 1]] = (docs[i], docs[i + 2])
name = {}; father = {}; go_of = {}; tr_of_go = {}
for fid, (cls, body) in objs.items():
    if cls == '1':
        m = re.search(r'm_Name: (.*)', body); name[fid] = m.group(1).strip() if m else '?'
    if cls in ('4', '224'):
        g = re.search(r'm_GameObject: \{fileID: (\d+)\}', body).group(1); go_of[fid] = g; tr_of_go[g] = fid
        f = re.search(r'm_Father: \{fileID: (\d+)\}', body); father[fid] = f.group(1) if f else '0'
def tpath(t):
    p = []
    while t and t != '0' and t in go_of:
        p.append(name.get(go_of[t], '?')); t = father.get(t, '0')
    return '/'.join(reversed(p))
def resolve(fid):
    if fid in go_of: return 'T:' + tpath(fid)
    if fid in objs:
        cls, body = objs[fid]
        m = re.search(r'm_GameObject: \{fileID: (\d+)\}', body)
        if m: return 'C%s on %s' % (cls, tpath(tr_of_go.get(m.group(1), '0')))
        if cls == '1': return 'GO:' + tpath(tr_of_go.get(fid, '0'))
    return '?'
if len(sys.argv) > 2:
    for f in sys.argv[2:]: print(f, resolve(f))
else:
    for t in sorted(go_of, key=tpath): print(t, tpath(t))
