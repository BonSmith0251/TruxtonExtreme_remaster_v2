from pathlib import Path
import shutil,json,os,hashlib
src=Path(r'D:\Games\TruxtonExRecon\extraction\pristine-export\ExportedProject\Assets')
dst=Path(r'D:\Games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered')
ledger=[]
immutable={'.png','.tga','.ogg','.wav','.exr','.hdr','.jpg','.jpeg','.mp4','.ttf','.otf'}
for f in src.rglob('*'):
 if not f.is_file():continue
 rel=f.relative_to(src)
 if rel.parts[0] in {'StreamingAssets','Editor','Plugins','Scripts'}:continue
 dest=dst/rel;dest.parent.mkdir(parents=True,exist_ok=True)
 if dest.exists():continue
 mode='hardlink-immutable-payload' if f.suffix.lower() in immutable else 'copy'
 if mode.startswith('hardlink'):os.link(f,dest)
 else:shutil.copy2(f,dest)
 ledger.append({'source':str(f),'target':str(dest),'bytes':f.stat().st_size,'mode':mode,'sha256':hashlib.sha256(f.read_bytes()).hexdigest()})
p=Path(r'D:\Games\TruxtonExRecon\scene-work\original-native-copy-ledger.json');p.write_text(json.dumps(ledger,indent=2))
print(json.dumps({'files':len(ledger),'logicalBytes':sum(x['bytes'] for x in ledger),'physicalCopyBytes':sum(x['bytes'] for x in ledger if x['mode']=='copy')}))
