import sys, struct, bisect, json
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
import numpy as np
starts=[]
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
    m=json.loads(line)
    a=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
    if not a or not a[0]['fields'].get('RVA'): continue
    starts.append((int(a[0]['fields']['RVA'],16), m['type'].split('.')[-1]+'::'+m['signature'].split('::')[-1].split('(')[0]))
starts.sort(); S=[s[0] for s in starts]
b=il2.b
for nm in ('.text','il2cpp'):
    pass
targets=[int(x,16) for x in sys.argv[1:]]
res={t:[] for t in targets}
for s in il2.SECT:
    if s[0] not in ('.text','il2cpp'): continue
    name,va,vs,ptr,sz,ch=s
    arr=np.frombuffer(b,dtype=np.uint8,count=sz,offset=ptr)
    idx=np.nonzero((arr[:-5]==0xE8)|(arr[:-5]==0xE9))[0]
    rel=(arr[idx+1].astype(np.int64)|(arr[idx+2].astype(np.int64)<<8)|(arr[idx+3].astype(np.int64)<<16)|(arr[idx+4].astype(np.int64)<<24))
    rel=np.where(rel>=2**31,rel-2**32,rel)
    dest=va+idx+5+rel
    for tg in targets:
        for i in idx[dest==tg]:
            rva=va+int(i); k=bisect.bisect_right(S,rva)-1
            res[tg].append('  %x %s %s'%(rva,'call' if arr[i]==0xE8 else 'jmp ',starts[k][1]))
for tg in targets:
    print('== callers of %x %s'%(tg, il2.MNAME.get(tg,['?'])[0]))
    print('\n'.join(res[tg]))
