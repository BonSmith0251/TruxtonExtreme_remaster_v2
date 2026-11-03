import json,pathlib,shutil,hashlib
root=pathlib.Path(r'D:\Games\TruxtonExRecon\code'); src=pathlib.Path(r'D:\Games\TruxtonExRecon\extraction\pristine-export\ExportedProject\Assets'); out=root/'integration-stubs'/'Assets'/'OriginalRecovered'; out.mkdir(parents=True,exist_ok=True)
manifest=[]
for p in (src/'Plugins').glob('*.dll'):
 n=p.name
 if n.startswith(('Unity.','UnityEngine.','System.')) or n in ['Newtonsoft.Json.dll','__Generated.dll']: continue
 q=out/'Plugins'/n;q.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(p,q)
 meta=p.with_name(p.name+'.meta');shutil.copy2(meta,q.with_name(q.name+'.meta'))
 manifest.append(dict(path=str(q.relative_to(root/'integration-stubs')),source=str(p),sha256=hashlib.sha256(p.read_bytes()).hexdigest(),status='metadata_only_stub',guid=next(x.split(': ')[1] for x in meta.read_text().splitlines() if x.startswith('guid:'))))
for subtree in ['Scripts','Plugins/Assembly-CSharp-firstpass']:
 if (src/subtree).exists():shutil.copytree(src/subtree,out/subtree,dirs_exist_ok=True)
(root/'integration-stubs'/'manifest.json').write_text(json.dumps(manifest,indent=2))
print('DLL stubs:',len(manifest))
