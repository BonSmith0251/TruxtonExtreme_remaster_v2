import json,pathlib,hashlib,datetime
r=pathlib.Path(r'D:\Games\TruxtonExRecon');mp=r/'evidence/scene-integration/freeze-manifest.json';m=json.loads(mp.read_text());project=pathlib.Path(m['project']);bad=[];missing=[];checked=0
for e in m['entries']:
 p=project/e['path']
 if not p.is_file():missing.append(e['path']);continue
 h=hashlib.sha256()
 with p.open('rb') as f:
  while b:=f.read(1024*1024):h.update(b)
 if h.hexdigest()!=e['sha256']:bad.append({'path':e['path'],'expected':e['sha256'],'actual':h.hexdigest()})
 checked+=1
expected={e['path'] for e in m['entries']};added=[]
for scope in m['scope']:
 for p in (project/scope).rglob('*'):
  if p.is_file() and p.relative_to(project).as_posix() not in expected:added.append(p.relative_to(project).as_posix())
report={'utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'revision':m['revision'],'manifest_sha256':hashlib.sha256(mp.read_bytes()).hexdigest(),'scope':m['scope'],'files_checked':checked,'changed':bad,'missing':missing,'added':added,'unchanged':not bad and not missing and not added};(r/'verification/post-test-freeze-check.json').write_text(json.dumps(report,indent=2));print(json.dumps({k:v for k,v in report.items() if k not in ['changed','missing','added']},indent=2));print('changed',bad[:12],'missing',missing[:12],'added',added[:12])
