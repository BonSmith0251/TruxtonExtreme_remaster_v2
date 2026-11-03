import pathlib,json,struct,collections,hashlib
from capstone import *
from capstone.x86 import *
r=pathlib.Path(r'D:\Games\TruxtonExRecon\code'); out=r/'simple-native-recovery';out.mkdir(exist_ok=True)
b=(pathlib.Path(r'D:\games\Truxton Extreme')/'GameAssembly.dll').read_bytes(); assert hashlib.sha256(b).hexdigest()=='b3ee81c6bf8506e8134512e14640b7bdae6092269893ccdea40f2afe758b5ab6', 'Source binary changed; rebuild matching metadata evidence first'; assert hashlib.sha256(pathlib.Path(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat').read_bytes()).hexdigest()=='8dc5e099564bd7de4c5f7a6c6d102f4d192da9ec704729c981ab4f217493d685', 'Source metadata changed'; ph=struct.unpack_from('<I',b,60)[0];nsec=struct.unpack_from('<H',b,ph+6)[0];sh=ph+24+struct.unpack_from('<H',b,ph+20)[0];sections=[]
for i in range(nsec):
 vs,va,size,off=struct.unpack_from('<4I',b,sh+i*40+8);sections.append((va,max(vs,size),off))
def raw(va):
 for start,size,off in sections:
  if start<=va<start+size:return off+va-start
 raise ValueError(hex(va))
def attr(row,name,key):
 for a in row['attributes']:
  if a['type']=='Cpp2ILInjected.'+name+'Attribute':return a.get('fields',{}).get(key)
def original_token(m):return attr(m,'Token','Token')
types={}
for line in (r/'types.jsonl').open(encoding='utf-8'):
 t=json.loads(line);types[(t['assembly'],t['type'])]=t
methods=[];rvas=collections.Counter()
for line in (r/'methods.jsonl').open(encoding='utf-8'):
 m=json.loads(line);rv=attr(m,'Address','RVA')
 if original_token(m) and rv:rvas[int(rv,16)]+=1
 if m['assembly'].startswith(('TXEKernel','InGame.','KANAI.')) or m['assembly']=='OutGame':methods.append(m)
md=Cs(CS_ARCH_X86,CS_MODE_64);md.detail=True
ints={'System.Boolean':(1,False),'System.Byte':(1,False),'System.SByte':(1,True),'System.Char':(2,False),'System.Int16':(2,True),'System.UInt16':(2,False),'System.Int32':(4,True),'System.UInt32':(4,False),'System.Int64':(8,True),'System.UInt64':(8,False)}
def underlying(asm,typ):
 t=types.get((asm,typ))
 if t and t['baseType']=='System.Enum':return next((f['type'] for f in t['fields'] if f['name']=='value__'),None)
 return typ
def isref(asm,typ):
 if typ in ['System.String','System.Object'] or typ.endswith('[]'):return True
 t=types.get((asm,typ))
 if not t:
  candidates=[x for (a,n),x in types.items() if n==typ]
  if len(candidates)==1:t=candidates[0]
 return t is not None and t['baseType'] not in ['System.Enum','System.ValueType'] and '*' not in typ and '&' not in typ
reject=collections.Counter();accepted=[];eligible=0
for m in methods:
 if not original_token(m):reject['injected_method']+=1;continue
 ty=types[(m['assembly'],m['type'])];flags=m['flags'].split(', ')
 if any(c in m['type'] for c in '<>`') or ty['baseType'] in ['System.Enum','System.ValueType'] or '::.ctor(' in m['signature'] or '::.cctor(' in m['signature']:reject['generated_generic_value_or_constructor']+=1;continue
 rv=attr(m,'Address','RVA');length=attr(m,'Address','Length')
 if not rv or not length:reject['no_native_address']+=1;continue
 rv=int(rv,16);length=int(length,16)
 if rvas[rv]!=1:reject['shared_native_address']+=1;continue
 if length>20 or length<2:reject['outside_small_straight_line_scope']+=1;continue
 eligible+=1;off=raw(rv);data=b[off:off+length];ins=list(md.disasm(data,rv))
 if sum(i.size for i in ins)!=length:reject['incomplete_disassembly']+=1;continue
 if not ins or ins[-1].mnemonic!='ret' or ins[-1].op_str:reject['not_plain_ret']+=1;continue
 kind=None;field=None;constant=None
 if len(ins)==2 and len(ins[0].operands)==2:
  x=ins[0];a,z=x.operands
  # This-pointer field getters: only direct declared offsets, exact return identity.
  if 'Static' not in flags and len(m['parameters'])==0 and a.type==X86_OP_REG and z.type==X86_OP_MEM and z.mem.base==X86_REG_RCX and z.mem.index==0 and z.mem.segment==0:
   matches=[f for f in ty['fields'] if 'Static' not in f['flags'].split(', ') and attr(f,'FieldOffset','Offset') and int(attr(f,'FieldOffset','Offset'),16)==z.mem.disp and f['type']==m['returnType']]
   if len(matches)==1:
    f=matches[0];u=underlying(m['assembly'],f['type']);reg=md.reg_name(a.reg);ok=False
    if u in ints:
     size,signed=ints[u];op='mov' if size>=4 else ('movsx' if signed else 'movzx');ok=x.mnemonic==op and z.size==size and reg==('rax' if size==8 else 'eax')
    elif u in ['System.Single','System.Double']:ok=x.mnemonic==('movss' if u=='System.Single' else 'movsd') and reg=='xmm0' and z.size==(4 if u=='System.Single' else 8)
    elif isref(m['assembly'],u):ok=x.mnemonic=='mov' and reg=='rax' and z.size==8
    if ok:kind='instance_field_getter';field=f
  # Scalar setters only. Managed references excluded because barrier semantics need calls.
  elif 'Static' not in flags and len(m['parameters'])==1 and m['returnType']=='System.Void' and a.type==X86_OP_MEM and z.type==X86_OP_REG and a.mem.base==X86_REG_RCX and a.mem.index==0 and a.mem.segment==0:
   matches=[f for f in ty['fields'] if 'Static' not in f['flags'].split(', ') and attr(f,'FieldOffset','Offset') and int(attr(f,'FieldOffset','Offset'),16)==a.mem.disp and f['type']==m['parameters'][0]['type']]
   if len(matches)==1:
    f=matches[0];u=underlying(m['assembly'],f['type']);reg=md.reg_name(z.reg);ok=False
    if u in ints:
     size,signed=ints[u];ok=x.mnemonic=='mov' and a.size==size and reg=={1:'dl',2:'dx',4:'edx',8:'rdx'}[size]
    elif u in ['System.Single','System.Double']:ok=x.mnemonic==('movss' if u=='System.Single' else 'movsd') and reg=='xmm1' and a.size==(4 if u=='System.Single' else 8)
    if ok:kind='instance_scalar_field_setter';field=f
  elif len(m['parameters'])==0 and a.type==X86_OP_REG and z.type==X86_OP_IMM and x.mnemonic=='mov':
   u=underlying(m['assembly'],m['returnType'])
   if u in ints:
    size,signed=ints[u];reg=md.reg_name(a.reg)
    if (size<=4 and reg=='eax') or (size==8 and reg=='rax'):
     constant=z.imm & ((1<<(size*8))-1)
     if signed and constant&(1<<(size*8-1)):constant-=1<<(size*8)
     if u!='System.Boolean' or constant in (0,1):kind='integer_constant'
 if not kind:reject['instruction_or_field_semantics_not_supported']+=1;continue
 accepted.append(dict(assembly=m['assembly'],type=m['type'],signature=m['signature'],originalToken=original_token(m),rva=hex(rv),nativeBytes=data.hex(),instructions=[i.mnemonic+' '+i.op_str for i in ins],nativeAddressAliases=rvas[rv],kind=kind,field=field,constant=constant,sourceGameAssemblySha256=hashlib.sha256(b).hexdigest(),status='native_recovered_candidate_not_integrated'))
(out/'candidates.json').write_text(json.dumps(accepted,indent=2),encoding='utf-8')
summary=dict(gameMethodsConsidered=len(methods),smallUniqueNonGenericCandidatesDisassembled=eligible,accepted=len(accepted),acceptedKinds=dict(collections.Counter(x['kind'] for x in accepted)),acceptedAssemblies=dict(collections.Counter(x['assembly'] for x in accepted)),rejected=dict(reject),policy='Unique RVA only, exactly one supported instruction and ret, exact declared field offset and managed type, no calls/branches/reference setters/value type or generic layout/constructors. Other methods unrecovered.')
(out/'summary.json').write_text(json.dumps(summary,indent=2));print(json.dumps(summary,indent=2));print('\n'.join(x['signature']+' :: '+str(x['instructions']) for x in accepted[:16]))
