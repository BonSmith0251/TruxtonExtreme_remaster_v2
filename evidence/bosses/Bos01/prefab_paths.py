# Resolve transform fileIDs of Pf_Ene_Bos01 to hierarchy paths + local pos/rot/scale (read only).
import re,sys,json
P=r'D:/games/TruxtonExRecon/Reconstructed/Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos01.prefab'
txt=open(P,encoding='utf8').read()
docs={}
for m in re.finditer(r'--- !u!(\d+) &(\d+)[^\n]*\n(.*?)(?=\n--- !u!|\Z)',txt,re.S):
    docs[m.group(2)]=(int(m.group(1)),m.group(3))
go_name={}; tr={}
for fid,(cls,body) in docs.items():
    if cls==1:
        n=re.search(r'm_Name: (.*)',body); go_name[fid]=n.group(1).strip() if n else '?'
for fid,(cls,body) in docs.items():
    if cls in (4,224):
        g=re.search(r'm_GameObject: \{fileID: (\d+)\}',body).group(1)
        f=re.search(r'm_Father: \{fileID: (\d+)\}',body).group(1)
        lp=re.search(r'm_LocalPosition: \{([^}]*)\}',body).group(1)
        lr=re.search(r'm_LocalRotation: \{([^}]*)\}',body).group(1)
        ls=re.search(r'm_LocalScale: \{([^}]*)\}',body).group(1)
        tr[fid]=dict(go=g,father=f,pos=lp,rot=lr,scale=ls)
def path(fid):
    p=[];
    while fid in tr:
        p.append(go_name.get(tr[fid]['go'],'?')); fid=tr[fid]['father']
    return '/'.join(reversed(p))
go2tr={v['go']:k for k,v in tr.items()}
if __name__=='__main__':
    for a in sys.argv[1:]:
        if a in tr: print(a,'T',path(a),'| pos',tr[a]['pos'],'| rot',tr[a]['rot'],'| scale',tr[a]['scale'])
        elif a in go2tr: print(a,'GO',path(go2tr[a]))
        elif a in docs:
            g=re.search(r'm_GameObject: \{fileID: (\d+)\}',docs[a][1])
            print(a,'C',docs[a][0],path(go2tr.get(g.group(1),'')) if g else '?')
        else: print(a,'??')
