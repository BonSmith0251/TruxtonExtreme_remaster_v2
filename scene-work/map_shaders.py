from pathlib import Path
import re,json,collections
r=Path(r'D:\Games\TruxtonExRecon\Reconstructed');original=r/'Assets/OriginalRecovered'
known=collections.defaultdict(list)
for root in [r/'Library/PackageCache',r/'Packages']:
 for p in root.rglob('*.shader'):
  meta=Path(str(p)+'.meta')
  if not meta.exists():continue
  m=re.search(r'\bShader\s+"([^"]+)"',p.read_text(encoding='utf-8-sig',errors='replace'))
  if m:known[m.group(1)].append(p)
replace={};shaders=[]
for p in original.rglob('*.shader'):
 text=p.read_text(encoding='utf-8-sig');m=re.search(r'\bShader\s+"([^"]+)"',text)
 if not m:continue
 name=m.group(1);meta=Path(str(p)+'.meta');guid=re.search(r'^guid: (\S+)',meta.read_text(),re.M).group(1);hits=known[name]
 row={'path':str(p),'originalName':name,'targetName':'RecoveredStub/'+name,'status':'dummy-export shader; runtime visual behavior not recovered'}
 if len(hits)==1:
  dest=hits[0];newguid=re.search(r'^guid: (\S+)',Path(str(dest)+'.meta').read_text(),re.M).group(1)
  replace['{fileID: 4800000, guid: '+guid+', type: 3}']='{fileID: 4800000, guid: '+newguid+', type: 3}'
  row.update({'referenceMapping':'exact-name compatible target package shader','targetShaderPath':str(dest),'targetGUID':newguid})
 text=text[:m.start(1)]+'RecoveredStub/'+name+text[m.end(1):];p.write_text(text,encoding='utf8');shaders.append(row)
changes=[]
for p in original.rglob('*'):
 if p.suffix not in {'.mat','.prefab','.asset','.unity'}:continue
 text=p.read_text(encoding='utf-8-sig');out=text;count=0
 for a,b in replace.items():
  c=out.count(a)
  if c:out=out.replace(a,b);count+=c
 if out!=text:p.write_text(out,encoding='utf8');changes.append({'path':str(p),'exactShaderReferencesMapped':count})
(r.parent/'scene-work/shader-compatibility-map.json').write_text(json.dumps({'shaders':shaders,'mappedSourceShaderCount':len(replace),'changedAssets':changes},indent=2))
print('dummy shaders',len(shaders),'exact package shader mappings',len(replace),'changed assets',len(changes))
