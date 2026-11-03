from pathlib import Path
import hashlib,json,datetime
r=Path(r'D:\Games\TruxtonExRecon');p=r/'Reconstructed';rows=[]
for folder in ['Assets','Packages','ProjectSettings']:
 for f in (p/folder).rglob('*'):
  if not f.is_file():continue
  h=hashlib.sha256()
  with f.open('rb') as q:
   for b in iter(lambda:q.read(8*1024*1024),b''):h.update(b)
  rows.append({'path':str(f.relative_to(p)).replace('\\','/'),'bytes':f.stat().st_size,'sha256':h.hexdigest()})
rows.sort(key=lambda x:x['path']);out={'revision':'reconstruction-2023.2.22f1-native-assets-v2','timeUTC':datetime.datetime.now(datetime.timezone.utc).isoformat(),'project':str(p),'files':len(rows),'logicalBytes':sum(x['bytes'] for x in rows),'scope':['Assets','Packages','ProjectSettings'],'scopeFileCounts':{f:sum(x['path'].split('/')[0]==f for x in rows) for f in ['Assets','Packages','ProjectSettings']},'entries':rows};dest=r/'evidence/scene-integration/freeze-manifest.json';dest.write_text(json.dumps(out,indent=2));print(out['revision'],len(rows),out['logicalBytes'],hashlib.sha256(dest.read_bytes()).hexdigest())
