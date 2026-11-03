# Read-only disassembler for Ene_Bos01 evidence (GameAssembly.dll IL2CPP x64).
# usage: C:/Python311/python.exe -I dis.py <typeSubstring|0xRVA> ...   -> prints annotated disassembly
# Annotations: call targets -> method names; RIP-relative .rdata loads -> float/double value;
# RIP-relative .data qwords holding an encoded metadata usage -> StringLiteral text / usage kind+index.
import json, struct, sys, collections
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_REG_RIP
GA=r'D:\games\Truxton Extreme\GameAssembly.dll'
META=r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat'
b=open(GA,'rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
sect=[]
for i in range(ns):
    off=opt+osz+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8); sect.append((name,va,vs,sz,ptr))
def raw(rva):
    for n,va,vs,sz,p in sect:
        if va<=rva<va+max(vs,sz): return p+rva-va if rva-va<sz else None
def secname(rva):
    for n,va,vs,sz,p in sect:
        if va<=rva<va+max(vs,sz): return n
mb=open(META,'rb').read()
lit_off,lit_size,lit_count,dat_off,dat_size,_=struct.unpack_from('<6i',mb,8)
offs=struct.unpack_from('<%di'%lit_count,mb,lit_off)
lits=[mb[dat_off+offs[i]:dat_off+(offs[i+1] if i+1<lit_count else dat_size)].decode('utf-8','replace') for i in range(lit_count)]
meths={}; bytype=collections.defaultdict(list)
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
    m=json.loads(line)
    a=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
    if not a or not a[0]['fields'].get('RVA'): continue
    rva=int(a[0]['fields']['RVA'],16); ln=int(a[0]['fields']['Length'],16)
    nm=m['type'].split('.')[-1]+'::'+m['signature'].split('::',1)[-1]
    meths.setdefault(rva,[]).append(nm); bytype[m['type']].append((rva,ln,nm))
KIND={1:'TypeInfo',2:'Il2CppType',3:'MethodDef',4:'FieldInfo',5:'StringLiteral',6:'MethodRef'}
md=Cs(CS_ARCH_X86,CS_MODE_64); md.detail=True
def dis(rva,ln,title):
    print('=====',title,hex(rva),'len',hex(ln))
    o=raw(rva)
    for ins in md.disasm(b[o:o+ln],rva):
        ann=''
        if ins.mnemonic in ('call','jmp') and ins.op_str.startswith('0x'):
            t=int(ins.op_str,16)
            if t in meths: ann=' ; '+' | '.join(meths[t][:3])
        for op in ins.operands:
            if op.type==X86_OP_MEM and op.mem.base==X86_REG_RIP:
                t=ins.address+ins.size+op.mem.disp; s=secname(t); ro=raw(t)
                if ro is None: ann+=' ; [%s %x bss]'%(s,t); continue
                q=struct.unpack_from('<Q',b,ro)[0]
                if s=='.rdata':
                    f=struct.unpack_from('<f',b,ro)[0]; d=struct.unpack_from('<d',b,ro)[0]
                    ann+=' ; [rdata %x] f32=%r f64=%r'%(t,f,d) + (' xmm4=%s'%[round(x,6) for x in struct.unpack_from('<4f',b,ro)] if ins.mnemonic in('movaps','movups','xorps','andps','mulps','addps') else '')
                elif q&1 and (q>>32)==0:
                    k=(q&0xE0000000)>>29; idx=(q&0x1FFFFFFE)>>1
                    if k==5 and idx<len(lits): ann+=' ; [%x] Literal %r'%(t,lits[idx])
                    else: ann+=' ; [%x] %s#%d'%(t,KIND.get(k,k),idx)
                else: ann+=' ; [%s %x]=%x'%(s,t,q)
        print('%08x  %-8s %s%s'%(ins.address,ins.mnemonic,ins.op_str,ann))
for a in sys.argv[1:]:
    if a.startswith('0x'):
        r=int(a,16); 
        for t,l in bytype.items():
            pass
        found=[x for v in bytype.values() for x in v if x[0]==r]
        dis(r,found[0][1] if found else 0x200,found[0][2] if found else '?')
    else:
        for t in sorted(bytype):
            if t.endswith(a) or ('/' in a and a in t):
                for rva,ln,nm in sorted(bytype[t]): dis(rva,ln,nm)
