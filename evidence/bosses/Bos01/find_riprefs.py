# Find RIP-relative references (disp32 as last 4 bytes of the instruction) to given data RVAs; report containing methods.
import struct,sys,json,bisect,numpy as np
b=open(r'D:\games\Truxton Extreme\GameAssembly.dll','rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
secs=[]
for i in range(ns):
    off=opt+osz+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8)
    if name in ('.text','il2cpp'): secs.append((va,sz,ptr))
M=[]
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
    m=json.loads(line); a=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
    if a and a[0]['fields'].get('RVA'): M.append((int(a[0]['fields']['RVA'],16),int(a[0]['fields']['Length'],16),m['type'].split('.')[-1]+'::'+m['signature'].split('::')[-1][:70]))
M.sort(); starts=[x[0] for x in M]
def owner(r):
    k=bisect.bisect_right(starts,r)-1
    return M[k][2] if k>=0 and r<M[k][0]+M[k][1] else '?'
for s in sys.argv[1:]:
    t=int(s,16); out=set()
    for va,sz,ptr in secs:
        a=np.frombuffer(b,dtype=np.uint8,count=sz,offset=ptr)
        d=a[:-4].astype(np.int64)|(a[1:-3].astype(np.int64)<<8)|(a[2:-2].astype(np.int64)<<16)|(a[3:-1].astype(np.int64)<<24)
        d=np.where(d>=2**31,d-2**32,d)
        pos=np.nonzero(va+np.arange(len(d))+4+d==t)[0]
        for p in pos[:400]: out.add(owner(va+p))
    print(s,len(out)); [print('   ',o) for o in sorted(out)[:40]]
