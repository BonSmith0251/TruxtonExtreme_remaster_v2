from pathlib import Path
import shutil,hashlib,json,os
r=Path(r'D:\Games\TruxtonExRecon');src=r/'Reconstructed/Assets/StreamingAssets';dst=r/'Build/TruxtonExRecon_Data/StreamingAssets';rows=[]
assert src.exists()
for p in src.rglob('*'):
 if not p.is_file() or p.suffix=='.meta':continue
 rel=p.relative_to(src);d=dst/rel;d.parent.mkdir(parents=True,exist_ok=True)
 assert d.resolve().is_relative_to(dst.resolve())
 if d.exists():d.unlink()
 shutil.copy2(p,d);a=hashlib.sha256(p.read_bytes()).hexdigest();b=hashlib.sha256(d.read_bytes()).hexdigest();assert a==b and not os.path.samefile(p,d)
 rows.append({'relative':str(rel),'bytes':p.stat().st_size,'sha256':a,'independentCopy':True})
expected=json.loads((r/'scene-work/media-copy-ledger.json').read_text());by={x['relative'].replace('\\','/'):x for x in rows}
for e in expected:assert by[e['relative']]['sha256']==e['sha256']
report={'build':'Windows64 Mono2023.2.22f1','nativeOriginalMoviesVerified':len(expected),'allStreamingPayloads':len(rows),'bytes':sum(x['bytes'] for x in rows),'workaround':'BuildPipeline with targetStreamingAssets temporarily held outsideAssets/restored in finally; independent verified postbuild copy avoids repeated Bee zero-byte movie copy failures. Root cause remains unknown.','payloads':rows}
(r/'evidence/scene-integration/player-streaming-hashes.json').write_text(json.dumps(report,indent=2));print('Independent streamed payloads',len(rows),'originalnative moviehashes',len(expected),'bytes',report['bytes'])
