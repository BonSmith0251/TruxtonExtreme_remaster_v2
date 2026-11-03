# Map Transform fileIDs in a Unity prefab (YAML) to GameObject names and local TRS; print selected MonoBehaviour fields. Read-only.
# usage: python -I pfnode.py <prefab> [fileID ...]
import re, sys
t = open(sys.argv[1], encoding='utf-8').read()
docs = re.split(r'\n--- !u!(\d+) &(\d+)', t)
objs = {}
for i in range(1, len(docs) - 2, 3):
    objs[docs[i + 1]] = (docs[i], docs[i + 2])
names = {fid: re.search(r'm_Name: (.*)', body).group(1) for fid, (cls, body) in objs.items() if cls == '1'}
def tr(fid):
    cls, body = objs.get(fid, (None, ''))
    go = re.search(r'm_GameObject: \{fileID: (\d+)\}', body)
    pos = re.search(r'm_LocalPosition: (\{[^}]*\})', body); rot = re.search(r'm_LocalRotation: (\{[^}]*\})', body)
    par = re.search(r'm_Father: \{fileID: (\d+)\}', body)
    return names.get(go.group(1)) if go else None, pos and pos.group(1), rot and rot.group(1), par and par.group(1)
for fid in sys.argv[2:]:
    n, p, r, par = tr(fid); chain = []
    f = par
    while f and f != '0':
        chain.append(tr(f)[0]); f = tr(f)[3]
    print(fid, n, 'pos', p, 'rot', r, 'parents', '/'.join(reversed(chain)))
