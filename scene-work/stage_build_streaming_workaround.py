from pathlib import Path
import json,hashlib,shutil
r=Path(r'D:\Games\TruxtonExRecon');rows=json.loads((r/'scene-work/media-copy-ledger.json').read_text());ok=[]
for row in rows:
 p=r/'Reconstructed/Assets/StreamingAssets'/row['relative'];h=hashlib.sha256(p.read_bytes()).hexdigest();assert h==row['sha256'],str(p);ok.append({'path':str(p),'sha256':h,'bytes':p.stat().st_size})
(r/'scene-work/project-media-after-failed-builds.json').write_text(json.dumps({'hashVerified':len(ok),'movies':ok},indent=2))
s=r/'Reconstructed/Assets/StreamingAssets';d=r/'scene-work/streamingassets-build-hold';assert s.resolve().is_relative_to(r.resolve()) and d.resolve().is_relative_to(r.resolve());assert not d.exists();shutil.move(str(s),d)
if Path(str(s)+'.meta').exists():shutil.move(str(s)+'.meta',str(d)+'.meta')
print('All98projectmovies still match source; StreamingAssets safely held outsideAssets for the Bee copy workaround.')
