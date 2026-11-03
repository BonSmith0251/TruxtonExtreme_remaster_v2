from pathlib import Path
import re,json,collections
r=Path(r'D:\Games\TruxtonExRecon');s=r/'extraction/pristine-export/ExportedProject/Assets';t=r/'Reconstructed/Assets/OriginalRecovered';rows=[];counts=collections.Counter();issues=[]
for p in s.rglob('*'):
 if p.suffix not in {'.prefab','.unity','.asset','.controller','.anim','.playable'} or not p.is_file():continue
 rel=p.relative_to(s)
 if rel.parts[0] in {'StreamingAssets','Editor','Plugins','Scripts'}:continue
 dest=t/rel
 if not dest.exists():issues.append({'path':str(rel),'reason':'destination absent'});continue
 a=p.read_text(encoding='utf-8-sig',errors='replace');b=dest.read_text(encoding='utf-8-sig',errors='replace');aa=re.findall(r'^--- !u!(\d+) &(-?\d+)',a,re.M);bb=re.findall(r'^--- !u!(\d+) &(-?\d+)',b,re.M)
 counts['assets']+=1;counts['serializedDocuments']+=len(aa)
 if aa!=bb:issues.append({'path':str(rel),'reason':'serialized class/localID order differs','source':aa,'target':bb})
 counts['sourceGameObjects']+=sum(c=='1' for c,_ in aa);counts['sourceMonoBehaviours']+=sum(c=='114' for c,_ in aa)
 if p.suffix in {'.prefab','.unity'}:rows.append({'path':str(rel),'objects':len(aa),'gameObjects':sum(c=='1' for c,_ in aa),'managedComponents':sum(c=='114' for c,_ in aa),'classAndLocalIDOrderEqual':aa==bb})
out={'scope':'Static YAML identity/document-order comparison before target native object reload. Does not prove serialized values or object references survived target import. All baseline class/localID sequences compared.','counts':dict(counts),'issues':issues,'sceneAndPrefabRows':rows}
(r/'scene-work/static-native-identity-comparison.json').write_text(json.dumps(out,indent=2));print(dict(counts),'issues',len(issues))
