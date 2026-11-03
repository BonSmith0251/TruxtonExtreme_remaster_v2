from pathlib import Path
import re,json,gzip,shutil,hashlib
r=Path(r'D:\Games\TruxtonExRecon');target=r/'Reconstructed';assets=target/'Assets'
comic=assets/'OriginalRecovered/Audio/COMIC';names={p.stem.lower() for p in comic.glob('*.ogg')};sourceObjects=[]
with gzip.open(r/'extraction/objects.jsonl.gz','rt',encoding='utf8') as f:
 for line in f:
  j=json.loads(line)
  if j.get('class_id')==83 and j.get('name','').lower() in names:sourceObjects.append(j['id'])
rows=[];guids={}
for p in assets.rglob('*'):
 if not p.is_file() or p.suffix.lower() not in {'.ogg','.wav','.mp3','.aiff'}:continue
 if p.stem.lower() not in names and 'comic' not in [x.lower() for x in p.parts]:continue
 rel=p.relative_to(assets);meta=Path(str(p)+'.meta');guid=re.search(r'^guid: (\S+)',meta.read_text(),re.M).group(1) if meta.exists() else None
 rows.append({'path':str(rel),'guid':guid,'bytes':p.stat().st_size,'sha256':hashlib.sha256(p.read_bytes()).hexdigest(),'kind':'original-native' if rel.parts[0]=='OriginalRecovered' else 'independent-remaster-seed'});guids[guid]=str(rel)
assert len(sourceObjects)==173,len(sourceObjects)
print(json.dumps({'sourceExcludedAudioObjects':len(sourceObjects),'nativePaths':sum(x['kind']=='original-native' for x in rows),'targetPayloads':len(rows)},indent=2))
for row in rows:
 p=assets/row['path'];d=r/'scene-work/user-excluded-comic-audio'/row['path'];d.parent.mkdir(parents=True,exist_ok=True)
 assert str(p.resolve()).lower().startswith(str(assets.resolve()).lower()+'\\')
 shutil.move(str(p),str(d))
 meta=Path(str(p)+'.meta')
 if meta.exists():shutil.move(str(meta),str(d)+'.meta')
changes=[]
pattern=re.compile(r'\{fileID: 8300000, guid: ([0-9a-f]{32}), type: 3\}')
for p in assets.rglob('*'):
 if p.suffix not in {'.asset','.prefab','.unity','.controller','.playable','.anim','.mat'}:continue
 text=p.read_text(encoding='utf-8-sig',errors='strict');hits=[]
 def replace(m):
  guid=m.group(1)
  if guid not in guids:return m.group(0)
  hits.append({'originalReference':m.group(0),'excludedClip':guids[guid],'substitution':'intentional null per user Comic exclusion'});return '{fileID: 0}'
 out=pattern.sub(replace,text)
 if out!=text:p.write_text(out,encoding='utf8');changes.append({'asset':str(p.relative_to(target)),'changes':hits})
(r/'scene-work/comic-exclusion-ledger.json').write_text(json.dumps({'scope':'User-directed exclusion of Comic content. Original270371 object inventory is retained as evidence;173AudioClip source objects intentionally excluded, plus81opaqueComicbundles not reconstructed. One shared transparentPNG replaces ComicPlayer display.','sourceAudioObjectIds':sourceObjects,'payloads':rows,'intentionalReferenceNulls':changes},indent=2))
pre=json.loads((r/'code/simple-native-recovery/integration-preconditions.json').read_text());patched=[]
for row in pre['baselineHashChecks']:
 name=row['assembly'].split(',')[0]+'.dll';p=assets/'OriginalRecovered/Plugins'/name
 actual=hashlib.sha256(p.read_bytes()).hexdigest();assert actual==row['expected'],(name,actual,row['expected'])
 c=r/'code/simple-native-recovery/patched'/name;shutil.copy2(c,p);patched.append({'name':name,'baselineSHA256':actual,'targetSHA256':hashlib.sha256(p.read_bytes()).hexdigest()})
(r/'scene-work/native-simple-method-integration.json').write_text(json.dumps({'methods':91,'assemblies':patched},indent=2))
for name in ['ReconstructionCompatibilityFinish.cs','ReconstructionDeepAudit.cs','ReconstructionStageInspection.cs']:shutil.copy2(r/'scene-work'/name,assets/'Editor'/name)
for name in ['ReconstructionPlayTwiceVerification.cs','ReconstructionStagePreviewVerification.cs']:shutil.copy2(r/'verification'/name,assets/'Editor'/name)
print('Comic cleanup, asserted native patches, and final editor tools staged.')
