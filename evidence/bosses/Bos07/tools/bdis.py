"""Read-only disassembler for GameAssembly.dll methods (Bos07 spec work).
usage: python -I dis.py <name-substring-or-0xRVA> [...]   -> writes nothing, prints annotated listing"""
import json, struct, sys, collections, re, pickle, os
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_REG_RIP
GAME=r'D:\games\Truxton Extreme'
b=open(GAME+r'\GameAssembly.dll','rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
sect=[]
for i in range(ns):
    off=opt+osz+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8); sect.append((name,va,max(vs,sz),ptr,sz))
def secof(rva):
    for n,va,sz,p,rs in sect:
        if va<=rva<va+sz: return n
def raw(rva):
    for n,va,sz,p,rs in sect:
        if va<=rva<va+sz:
            if rva-va>=rs: return None
            return p+rva-va
cache=os.path.join(os.environ.get('TEMP','.'),'bos07_methods.pkl')
if os.path.exists(cache):
    addr,meth=pickle.load(open(cache,'rb'))
else:
    addr=collections.defaultdict(list); meth={}
    for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
        m=json.loads(line)
        for a in m['attributes']:
            if a['type']=='Cpp2ILInjected.AddressAttribute' and a['fields'].get('RVA'):
                r=int(a['fields']['RVA'],16); L=int(a['fields']['Length'],16)
                sig=m['signature']; sig=re.sub(r'System\.|UnityEngine\.|InGame\.Kernel\.','',sig)
                addr[r].append(sig); meth.setdefault(sig,(r,L))
    pickle.dump((dict(addr),meth),open(cache,'wb'))
# metadata literals
mb=open(GAME+r'\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat','rb').read()
lit_off,lit_size,lit_count,dat_off,dat_size,_=struct.unpack_from('<6i',mb,8)
offs=struct.unpack_from('<%di'%lit_count,mb,lit_off)
def literal(i):
    if not 0<=i<lit_count: return None
    e=offs[i+1] if i+1<lit_count else dat_size
    return mb[dat_off+offs[i]:dat_off+e].decode('utf-8','replace')
def slot(rva):
    o=raw(rva)
    if o is None: return 'bss'
    v=struct.unpack_from('<Q',b,o)[0]
    if v&1 and v<(1<<32):
        t=(v>>29)&7; idx=(v&0x1FFFFFFE)>>1
        kind={1:'TypeInfo',2:'Type',3:'MethodDef',4:'Field',5:'String',6:'MethodRef',7:'FieldRVA'}.get(t,str(t))
        if t==5: return 'STR %r'%literal(idx)
        return '%s#%d'%(kind,idx)
    return 'q=%x'%v
RT={0x578cb0:'fmodf',0x578460:'acosf',0x578890:'atan2f(y,x)',0x5d2df0:'Vector3.Magnitude',0x578040:'sinf',0x576bf0:'cosf',0x578740:'floorf',0x4e0a50:'il2cpp_init_metadata',0x4e0d90:'il2cpp_class_init',0x4e0d00:'ThrowNullRef'}
import bisect
starts=sorted(addr)
md=Cs(CS_ARCH_X86,CS_MODE_64); md.detail=True
def dis(rva,L,out):
    o=raw(rva)
    def gen():
        pc=rva
        while pc<rva+L:
            ins=next(md.disasm(b[o+pc-rva:o+pc-rva+16],pc,1),None)
            if ins is None: pc+=1; continue
            pc=ins.address+ins.size; yield ins
    for ins in gen():
        ann=''
        if ins.mnemonic in('call','jmp') and ins.op_str.startswith('0x'):
            t=int(ins.op_str,16)
            if not(rva<=t<rva+L): ann=' ; '+' || '.join(addr.get(t,[RT.get(t,'?')])[:3])
        for op in ins.operands:
            if op.type==X86_OP_MEM and op.mem.base==X86_REG_RIP:
                t=ins.address+ins.size+op.mem.disp; s=secof(t)
                if s=='.rdata':
                    oo=raw(t); f=struct.unpack_from('<f',b,oo)[0]; d=struct.unpack_from('<d',b,oo)[0]
                    f4=struct.unpack_from('<4f',b,oo)
                    ann+=' ; [%x] f=%r d=%r v4=%s'%(t,f,d,tuple(round(x,6) for x in f4)) if 'xmm' in ins.op_str else ' ; [%x] rdata'%t
                elif s=='.data': ann+=' ; [%x] %s'%(t,slot(t))
        m=re.search(r'\+ (0x[0-9a-f]+)\]$',ins.op_str)
        if ins.mnemonic=='mov' and '*4 +' in ins.op_str and m:
            tb=int(m.group(1),16); oo=raw(tb) if tb>0x100000 else None
            if oo is not None:
             ann+=' ; JT '+','.join('%x'%struct.unpack_from('<I',b,oo+4*k)[0] for k in range(12))
        out.append('%08x  %-8s %s%s'%(ins.address,ins.mnemonic,ins.op_str,ann))
if __name__=='__main__':
    for q in sys.argv[1:]:
        if q.startswith('0x'):
            r=int(q,16); hits=[(s,v) for s,v in meth.items() if v[0]==r] or [('?',(r,int(sys.argv[-1],16) if False else 0x400))]
        else: hits=[(s,v) for s,v in meth.items() if q in s]
        for s,(r,L) in hits:
            i=bisect.bisect_right(starts,r); L=max(L,(starts[i]-r) if i<len(starts) else L)
            out=['### %s  RVA=0x%X len=0x%X'%(s,r,L)]; dis(r,L,out); print('\n'.join(out)); print()
