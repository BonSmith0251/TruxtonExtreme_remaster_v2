# Read-only disassembler for Ene_Bos02 evidence. usage: python -I dis.py <typeSubstring|rva> ...
import json, struct, sys, collections, re
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
GA=r'D:\games\Truxton Extreme\GameAssembly.dll'
META=r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat'
b=open(GA,'rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
IMG=struct.unpack_from('<Q',b,opt+24)[0]
sect=[]
for i in range(ns):
    off=opt+osz+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8); sect.append((name,va,vs,sz,ptr))
def raw(rva):
    for n,va,vs,sz,p in sect:
        if va<=rva<va+max(vs,sz):
            return p+rva-va if rva-va<sz else None
    return None
def secname(rva):
    for n,va,vs,sz,p in sect:
        if va<=rva<va+max(vs,sz): return n
mb=open(META,'rb').read()
lit_off,lit_size,lit_count,dat_off,dat_size,_=struct.unpack_from('<6i',mb,8)
offs=struct.unpack_from('<%di'%lit_count,mb,lit_off)
lits=[mb[dat_off+offs[i]:dat_off+(offs[i+1] if i+1<lit_count else dat_size)].decode('utf-8','replace') for i in range(lit_count)]
meths={}; byname=collections.defaultdict(list)
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
    m=json.loads(line)
    a=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
    if not a or not a[0]['fields'].get('RVA'): continue
    r=int(a[0]['fields']['RVA'],16); L=int(a[0]['fields']['Length'],16)
    meths.setdefault(r,[]).append((m['signature'],L))
# field offsets of Bos02 + bases
KTOK={}
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
    m=json.loads(line)
    if m['assembly']!='InGame.Kernel': continue
    t=[x for x in m['attributes'] if x['type'].endswith('TokenAttribute')]
    if t: KTOK[int(t[0]['fields']['Token'],16)&0xffffff]=m['signature'].split('::')[-1]
TYPES={}
for l in open(r'D:\games\TruxtonExRecon\code\types.jsonl',encoding='utf-8-sig'):
    d=json.loads(l); TYPES[d['type']]=d
def fieldmap(t):
    fm={}
    while t in TYPES:
        for f in TYPES[t]['fields']:
            o=[a['fields'].get('Offset') for a in f['attributes'] if a['type'].endswith('FieldOffsetAttribute')]
            if o and 'Static' not in f['flags']: fm.setdefault(int(o[0],16),f['name'])
        t=TYPES[t]['baseType']
    return fm
sys.path.insert(0, __import__("os").path.dirname(__import__("os").path.abspath(__file__))); import vtable
VT=vtable.build(vtable.CHAIN)
CURFM={}
def sig(r):
    s=meths.get(r)
    if not s: return None
    names=[x[0] for x in s]
    return names[0] if len(names)==1 else names[0]+' (+%d aliases)'%(len(names)-1)
md=Cs(CS_ARCH_X86,CS_MODE_64); md.detail=False
def decode_slot(rva):
    o=raw(rva)
    if o is None: return None
    v=struct.unpack_from('<Q',b,o)[0]
    if v & 1 and v < (1<<33):
        t=(v>>29)&7; idx=(v&0x1FFFFFFE)>>1
        if t==5 and idx<len(lits): return 'STR[%d] "%s"'%(idx,lits[idx])
        if t==3 and (idx-68446) in KTOK: return 'MethodDef %d = %s'%(idx,KTOK[idx-68446])
        return 'usage t%d idx%d'%(t,idx)
    return None
def dis(rva,L,out):
    o=raw(rva); data=b[o:o+L]
    for ins in md.disasm(data,rva):
        ann=''
        if ins.mnemonic in ('call','jmp') and ins.op_str.startswith('0x'):
            t=int(ins.op_str,16); s=sig(t)
            if s: ann=' ; '+s
        m=re.search(r'\[rip ([+-]) (0x[0-9a-f]+)\]',ins.op_str)
        if m:
            t=ins.address+ins.size+(int(m.group(2),16)*(1 if m.group(1)=='+' else -1))
            sn=secname(t); oo=raw(t)
            if sn=='.rdata' and oo is not None:
                f=struct.unpack_from('<f',b,oo)[0]; dd=struct.unpack_from('<d',b,oo)[0]
                if 'ss' in ins.mnemonic and 'sd' not in ins.mnemonic or ins.mnemonic in('movss','addss','mulss','subss','divss','comiss','ucomiss','maxss','minss'):
                    ann+=' ; f32 %r @%x'%(f,t)
                elif ins.mnemonic.endswith('sd'):
                    ann+=' ; f64 %r @%x'%(dd,t)
                else:
                    ann+=' ; @%x f32 %r / q %s'%(t,f,b[oo:oo+16].hex())
            else:
                ds=decode_slot(t)
                ann+=' ; [%s %x]%s'%(sn,t,(' '+ds) if ds else '')
        for mm in re.finditer(r'\[(r\w+) \+ (0x[0-9a-f]+)\]',ins.op_str):
            off=int(mm.group(2),16)
            if mm.group(1) in ('rsp','rbp','rip'): continue
            if off in CURFM: ann+=' ; ~%s'%CURFM[off]
            elif off in VT and ins.mnemonic in ('mov','call') and off>=0x178: ann+=' ; vt?%s'%VT[off][0]
        out.append('%08x  %-8s %s%s'%(ins.address,ins.mnemonic,ins.op_str,ann))
if __name__=='__main__':
    for a in sys.argv[1:]:
        if a.startswith('0x'):
            r=int(a,16); s=meths.get(r)
            L=s[0][1] if s else 0x400
            CURFM.clear(); CURFM.update(fieldmap(sig(r).split('::')[0].split(' ')[-1]))
            out=['## %s RVA 0x%X len 0x%X'%(sig(r),r,L)]; dis(r,L,out); print('\n'.join(out)); print()
        else:
            for r,s in sorted(meths.items(), key=lambda kv: kv[0]):
                for name,L in s:
                    if a in name.split('::')[0]:
                        CURFM.clear(); CURFM.update(fieldmap(name.split('::')[0].split(' ')[-1]))
                        out=['## %s RVA 0x%X len 0x%X'%(name,r,L)]; dis(r,L,out); print('\n'.join(out)); print()
