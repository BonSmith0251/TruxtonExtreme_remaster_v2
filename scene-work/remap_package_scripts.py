from pathlib import Path
import re,json,sys,collections
sys.path.insert(0,str(Path(__file__).parent));from md4 import md4
r=Path(r'D:\Games\TruxtonExRecon\Reconstructed');base=r.parent/'extraction/pristine-export/ExportedProject/Assets'
scripts=json.loads((r.parent/'code/monoscript-type-map.json').read_text())
roots=[r/'Packages',r/'Library/PackageCache'];candidates=collections.defaultdict(list)
for root in roots:
 for p in root.rglob('*.cs'):
  meta=Path(str(p)+'.meta')
  if meta.exists():candidates[p.stem].append(p)
rows=[];mapping={};unresolved=[]
for s in scripts:
 if s['runtimeStatus']!='must_map_to_target_editor_or_compatible_package' or s['sourceComponentReferenceCount']==0:continue
 oldmeta=base/'Plugins'/(s['assembly']+'.dll.meta')
 if not oldmeta.exists():unresolved.append({'type':s['fullType'],'reason':'no exported assembly meta'});continue
 oldguid=re.search(r'^guid: (\S+)',oldmeta.read_text(),re.M).group(1)
 oldid=str(int.from_bytes(md4(('s\0\0\0'+s['namespace']+s['className']).encode())[:4],'little',signed=True))
 found=[]
 for p in candidates[s['className']]:
  text=p.read_text(encoding='utf-8-sig',errors='replace')
  if s['namespace'] and not re.search(r'namespace\s+'+re.escape(s['namespace'])+r'\b',text):continue
  if not re.search(r'\b(class|struct)\s+'+re.escape(s['className'])+r'\b',text):continue
  found.append(p)
 if len(found)!=1:unresolved.append({'type':s['fullType'],'reason':'target source candidates '+str(len(found)),'paths':[str(p) for p in found]});continue
 p=found[0];newguid=re.search(r'^guid: (\S+)',Path(str(p)+'.meta').read_text(),re.M).group(1)
 old='{fileID: '+oldid+', guid: '+oldguid+', type: 3}';new='{fileID: 11500000, guid: '+newguid+', type: 3}';mapping[old]=new
 rows.append({'type':s['fullType'],'assembly':s['assembly'],'sourceReference':old,'targetReference':new,'targetScript':str(p),'sourceAttachmentCount':s['sourceComponentReferenceCount']})
changes=[]
for p in (r/'Assets/OriginalRecovered').rglob('*'):
 if p.suffix not in {'.prefab','.asset','.unity','.playable','.controller','.overrideController','.anim'}:continue
 text=p.read_text(encoding='utf-8-sig',errors='strict');out=text
 hits=[]
 for old,new in mapping.items():
  count=out.count(old)
  if count:out=out.replace(old,new);hits.append({'old':old,'new':new,'count':count})
 if out!=text:p.write_text(out,encoding='utf-8');changes.append({'path':str(p),'changes':hits})
p=r.parent/'scene-work/package-script-remap.json';p.write_text(json.dumps({'mappings':rows,'unresolved':unresolved,'changes':changes},indent=2))
print(json.dumps({'mappedTypes':len(rows),'changedAssets':len(changes),'unresolved':unresolved},indent=2))
p=r/'Packages/manifest.json';j=json.loads(p.read_text());j['dependencies']['com.unity.modules.screencapture']='1.0.0';p.write_text(json.dumps(j,indent=2))
