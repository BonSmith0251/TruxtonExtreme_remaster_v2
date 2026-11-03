from pathlib import Path
import shutil,json,hashlib
src=Path(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\StreamingAssets\movies')
dst=Path(r'D:\Games\TruxtonExRecon\scene-work\original-media\movies');dst.mkdir(parents=True,exist_ok=True)
rows=[]
for f in src.iterdir():
 if not f.is_file() or f.suffix.lower() not in {'.mp4','.webm'} or 'comic' in f.name.lower():continue
 assert f.parent==src and 'comic' not in str(f).lower()
 d=dst/f.name;shutil.copy2(f,d)
 h=hashlib.sha256(f.read_bytes()).hexdigest();assert h==hashlib.sha256(d.read_bytes()).hexdigest()
 rows.append({'source':str(f),'relative':'movies/'+f.name,'bytes':f.stat().st_size,'sha256':h,'mode':'independent-copy'})
Path(r'D:\Games\TruxtonExRecon\scene-work\media-copy-ledger.json').write_text(json.dumps(rows,indent=2));print(len(rows),sum(r['bytes'] for r in rows))
