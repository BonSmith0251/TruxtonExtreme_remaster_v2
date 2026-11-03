# Find direct E8/E9 rel32 call/jmp sites to given RVAs across GameAssembly.dll code sections (read only).
import struct,sys,numpy as np
b=open(r'D:\games\Truxton Extreme\GameAssembly.dll','rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
secs=[]
for i in range(ns):
    off=opt+osz+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8)
    if name in ('.text','il2cpp'): secs.append((va,sz,ptr))
res={s:[] for s in sys.argv[1:]}
for tva,tsz,tptr in secs:
    a=np.frombuffer(b,dtype=np.uint8,count=tsz,offset=tptr)
    idx=np.nonzero((a[:-5]==0xE8)|(a[:-5]==0xE9))[0]
    rel=a[idx+1].astype(np.int64)|(a[idx+2].astype(np.int64)<<8)|(a[idx+3].astype(np.int64)<<16)|(a[idx+4].astype(np.int64)<<24)
    rel=np.where(rel>=2**31,rel-2**32,rel)
    tgt=tva+idx+5+rel
    for s in res: res[s]+= [hex(h) for h in (idx[tgt==int(s,16)]+tva)[:20]]
for s,v in res.items(): print(s,v)
