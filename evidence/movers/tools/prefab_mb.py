# Print the serialized MonoBehaviour blocks (class-named) of a prefab, with the owning GameObject name (read-only).
# usage: C:\Python311\python.exe -I prefab_mb.py <prefab> [classSubstr ...]
import sys, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\ground-route-events\tools')
import script_fileid as sf
p = sys.argv[1]; want = sys.argv[2:]
txt = open(p, encoding='utf-8').read()
docs = re.split(r'^--- !u!(\d+) &(-?\d+).*$', txt, flags=re.M)
objs = {}
for k in range(1, len(docs), 3):
    objs[docs[k + 1]] = (docs[k], docs[k + 2])
names = {fid: re.search(r'm_Name: (.*)', body).group(1) for fid, (cid, body) in objs.items() if cid == '1' and re.search(r'm_Name: (.*)', body)}
for fid, (cid, body) in objs.items():
    if cid != '114': continue
    m = re.search(r'm_Script: \{fileID: (-?\d+)', body)
    cls = sf.table.get(int(m.group(1)), m.group(1)) if m else '?'
    if want and not any(w in cls for w in want): continue
    go = re.search(r'm_GameObject: \{fileID: (-?\d+)', body).group(1)
    print('=== %s on GameObject %r (fileID %s)' % (cls, names.get(go), fid))
    keep = [l for l in body.splitlines() if not re.match(r'\s*(m_ObjectHideFlags|m_CorrespondingSourceObject|m_PrefabInstance|m_PrefabAsset|m_Enabled|m_EditorHideFlags|m_EditorClassIdentifier|m_GameObject|m_Script|MonoBehaviour:)', l)]
    print('\n'.join(keep[:int(want and 400 or 60)]))
