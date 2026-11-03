import json, pathlib, struct, re, hashlib, shutil, collections
from capstone import Cs,CS_ARCH_X86,CS_MODE_64
root=pathlib.Path(r'D:\Games\TruxtonExRecon\code'); game=pathlib.Path(r'D:\games\Truxton Extreme'); prev=pathlib.Path(r'C:\Users\Administrator\Documents\TruxtonRemaster')
# Fully qualified source evidence; do not execute the original module.
b=(game/'GameAssembly.dll').read_bytes(); pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; os=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24; base=struct.unpack_from('<Q',b,opt+24)[0]; sect=[]
for i in range(ns):
 off=opt+os+i*40; name=b[off:off+8].rstrip(b'\0').decode(); vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8); sect.append((va,max(vs,sz),ptr))
def raw(rva):
 for va,sz,p in sect:
  if va<=rva<va+sz:return p+rva-va
 raise ValueError(hex(rva))
methods=[]
for line in (root/'methods.jsonl').open(encoding='utf-8-sig'):
 m=json.loads(line)
 attrs=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
 if not attrs:continue
 a=attrs[0].get('fields',{})
 if not a.get('RVA'):continue
 typ=m['type'].split('/')[0].split('.')[-1]
 methods.append(dict(assembly=m['assembly'],file=typ+'.cs',originalType=m['type'],rva=int(a['RVA'],16),length=int(a['Length'],16),signature=m['signature']))
addr=collections.defaultdict(list)
for m in methods:addr[m['rva']].append(m['assembly']+':'+pathlib.Path(m['file']).stem+':'+m['signature'])
selected=[m for m in methods if pathlib.Path(m['file']).stem in {'BootTXE','BootOutGame','TXEBootChekcer','PlayerControll','VectorUtility','GameManager','ApplicationUtility'} and (pathlib.Path(m['file']).stem not in {'PlayerControll','VectorUtility'} or any(s in m['signature'] for s in ['_moveYaw','_playerControll',' Sinf(']))]
md=Cs(CS_ARCH_X86,CS_MODE_64); dst=root/'native';dst.mkdir(exist_ok=True); calls=[]
for i,m in enumerate(selected):
 data=b[raw(m['rva']):raw(m['rva'])+m['length']]; lines=[json.dumps(m), 'source_sha256='+hashlib.sha256(b).hexdigest()]
 for ins in md.disasm(data,m['rva']):
  annotation=''
  if ins.mnemonic in ('call','jmp') and ins.op_str.startswith('0x'):
   target=int(ins.op_str,16); syms=addr.get(target,[]);annotation=' ; '+' || '.join(syms[:5]);calls.append(dict(caller=m,targetRva=hex(target),candidates=syms))
  lines.append(f'{ins.address:08x} {ins.bytes.hex():30s} {ins.mnemonic:10s} {ins.op_str}{annotation}')
 (dst/f'{i:03d}_{pathlib.Path(m["file"]).stem}_{m["rva"]:x}.txt').write_text('\n'.join(lines),encoding='utf-8')
(root/'native-call-edges.json').write_text(json.dumps(calls,indent=2),encoding='utf-8')
(root/'native-selected-methods.json').write_text(json.dumps(selected,indent=2),encoding='utf-8')
# Prior reimplementation is a candidate, never renamed original code.
dest=root/'prior-round1-reimplementation'/'Assets'/'Truxton'; dest.mkdir(parents=True,exist_ok=True)
records=[]
for p in (prev/'Assets'/'Truxton').iterdir():
 if p.suffix in ('.cs','.meta','.shader'):
  q=dest/p.name; shutil.copy2(p,q);records.append(dict(source=str(p),target=str(q),sha256=hashlib.sha256(p.read_bytes()).hexdigest(),provenance='prior_evidence_based_reimplementation_with_documented_approximations'))
for name in ['README.md']:
 shutil.copy2(prev/name,root/'prior-round1-reimplementation'/('prior-'+name))
checks=[]
for p in (prev/'SourceAssets').rglob('*fingerprints.json'):
 d=json.loads(p.read_text('utf-8-sig')); checked=[]
 for k,v in d.items():
  if isinstance(v,str) and len(v)==64:
   source=game/k
   checked.append(dict(source=k,expected=v,actual=hashlib.sha256(source.read_bytes()).hexdigest() if source.is_file() else None))
 checks.append(dict(file=str(p),checks=checked))
(root/'prior-round1-reimplementation'/'provenance.json').write_text(json.dumps(dict(files=records,fingerprintChecks=checks,classification='editable Round1 reimplementation; not original full-game source; runtime asset dependency closure required'),indent=2),encoding='utf-8')
print(json.dumps(dict(selectedNativeMethods=len(selected),mappedAddressRecords=len(methods),priorFiles=len(records),fingerprintFiles=len(checks))))
