# Resolve fileIDs in Pf_Ene_Bos07.prefab to transform paths and dump collision components (read-only).
import re, sys, json
P=r'D:\games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\Samples\Prefabs\Reference\Enemy\Pf_Ene_Bos07.prefab'
txt=open(P,encoding='utf-8').read()
docs={}
for m in re.finditer(r'^--- !u!(\d+) &(-?\d+).*?\n(.*?)(?=^--- !u!|\Z)',txt,re.S|re.M):
    docs[m.group(2)]=(int(m.group(1)),m.group(3))
go_name={}; tr_go={}; tr_father={}; go_tr={}; go_comps={}
for fid,(cls,body) in docs.items():
    if cls==1:
        n=re.search(r'm_Name: (.*)',body); go_name[fid]=n.group(1).strip() if n else '?'
    if cls==4:
        g=re.search(r'm_GameObject: \{fileID: (-?\d+)\}',body).group(1); tr_go[fid]=g; go_tr[g]=fid
        f=re.search(r'm_Father: \{fileID: (-?\d+)\}',body).group(1); tr_father[fid]=f
def path(tr):
    out=[]
    while tr and tr!='0' and tr in tr_go:
        out.append(go_name.get(tr_go[tr],'?')); tr=tr_father.get(tr)
    return '/'.join(reversed(out))
def any_path(fid):
    if fid in tr_go: return path(fid)
    if fid in go_tr: return path(go_tr[fid])
    if fid in docs:
        g=re.search(r'm_GameObject: \{fileID: (-?\d+)\}',docs[fid][1])
        if g and g.group(1) in go_tr: return path(go_tr[g.group(1)])+' [comp %d]'%docs[fid][0]
    return '?'
if __name__=='__main__':
    if sys.argv[1]=='ids':
        for f in sys.argv[2:]: print(f, any_path(f))
    elif sys.argv[1]=='comp':
        for f in sys.argv[2:]:
            print('==',f,any_path(f)); print(docs[f][1][:3000])
    elif sys.argv[1]=='find':
        for fid,(cls,body) in docs.items():
            if sys.argv[2] in body: print(fid,cls,any_path(fid))
