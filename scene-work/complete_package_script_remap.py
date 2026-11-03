from pathlib import Path
import re,json,collections,sys
sys.path.insert(0,str(Path(__file__).parent));from md4 import md4
r=Path(r'D:\Games\TruxtonExRecon');target=r/'Reconstructed';base=r/'extraction/pristine-export/ExportedProject/Assets';candidates=collections.defaultdict(list)
for root in [target/'Packages',target/'Library/PackageCache']:
 for p in root.rglob('*.cs'):
  if Path(str(p)+'.meta').exists():candidates[p.stem].append(p)
refs=collections.Counter()
for p in (target/'Assets/OriginalRecovered').rglob('*'):
 if p.suffix in {'.prefab','.asset','.unity','.controller','.playable','.anim'}:
  text=p.read_text(encoding='utf8')
  for m in re.finditer(r'm_Script: (\{fileID: (-?\d+), guid: ([0-9a-f]{32}), type: 3\})',text):refs[m.group(1)]+=1
rows=[];mapping={}
for line in (r/'code/types.jsonl').open(encoding='utf8'):
 t=json.loads(line);assembly=t['assembly'];full=t['type'];name=full.rsplit('.',1)[-1];ns=full.rsplit('.',1)[0] if '.' in full else ''
 if '/' in name or '+' in name or '`' in name:continue
 oldmeta=base/'Plugins'/(assembly+'.dll.meta')
 if not oldmeta.exists() or name not in candidates:continue
 oldguid=re.search(r'^guid: (\S+)',oldmeta.read_text(),re.M).group(1);oldid=str(int.from_bytes(md4(('s\0\0\0'+ns+name).encode())[:4],'little',signed=True));old='{fileID: '+oldid+', guid: '+oldguid+', type: 3}'
 if old not in refs:continue
 found=[]
 for p in candidates[name]:
  code=p.read_text(encoding='utf-8-sig',errors='replace')
  if ns and not re.search(r'namespace\s+'+re.escape(ns)+r'\b',code):continue
  if not re.search(r'\b(class|struct)\s+'+re.escape(name)+r'\b',code):continue
  found.append(p)
 if len(found)!=1:continue
 p=found[0];guid=re.search(r'^guid: (\S+)',Path(str(p)+'.meta').read_text(),re.M).group(1);new='{fileID: 11500000, guid: '+guid+', type: 3}';mapping[old]=new;rows.append({'type':full,'sourceAssembly':assembly,'source':old,'target':new,'targetScript':str(p),'references':refs[old]})
changes=[]
for p in (target/'Assets/OriginalRecovered').rglob('*'):
 if p.suffix not in {'.prefab','.asset','.unity','.controller','.playable','.anim'}:continue
 s=p.read_text(encoding='utf8');out=s;hits=[]
 for old,new in mapping.items():
  count=out.count(old)
  if count:out=out.replace(old,new);hits.append({'source':old,'target':new,'count':count})
 if out!=s:p.write_text(out,encoding='utf8');changes.append({'asset':str(p),'changes':hits})
(r/'scene-work/additional-package-script-remap.json').write_text(json.dumps({'mappings':rows,'changes':changes,'reason':'First sourceMonoScript attachment census omitted globalgamemanagers built-in debugUI/URP/TMP managed headers; exact all-type matching closes those references.'},indent=2))
print('additional types',len(rows),'changed assets',len(changes),'refs',sum(x['references'] for x in rows))
p=target/'Assets/Editor/ReconstructionCompatibilityFinish.cs';s=p.read_text(encoding='utf-8-sig');s=s.replace('try{foreach(var image in root.GetComponentsInChildren<Image>(true))if(image.gameObject.name=="ComicPlayer"){image.sprite=blank;report.comicImagesReplaced++;}PrefabUtility.SaveAsPrefabAsset(root,prefab);}', '''try{var player=root.transform.Find("ComicPlayer");if(!player)throw new Exception("ComicPlayer source container missing");var child=player.Find("ComicBlank");GameObject graphic=child?child.gameObject:new GameObject("ComicBlank",typeof(RectTransform));graphic.transform.SetParent(player,false);var rect=(RectTransform)graphic.transform;rect.anchorMin=Vector2.zero;rect.anchorMax=Vector2.one;rect.offsetMin=Vector2.zero;rect.offsetMax=Vector2.zero;var image=graphic.GetComponent<Image>();if(!image)image=graphic.AddComponent<Image>();image.sprite=blank;image.raycastTarget=false;report.comicImagesReplaced=1;PrefabUtility.SaveAsPrefabAsset(root,prefab);}''');p.write_text(s,encoding='utf8')
