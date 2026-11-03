import json,pathlib,hashlib
r=pathlib.Path(r"D:\Games\TruxtonExRecon\code")
files=[]
for f in sorted(list(r.glob('*.ps1'))+list(r.glob('*.py'))):
 files.append({'path':f.name,'bytes':f.stat().st_size,'sha256':hashlib.sha256(f.read_bytes()).hexdigest()})
for dirname in ['integration-stubs','native-boot-patch','native-reconstructed-source','missing-type-shells','tools','unity2023-compat','simple-native-recovery','gdk-edition-data','rendering-layer-data','outgame-load-diagnostic','unitask-callback-compat']:
 for f in (r/dirname).rglob('*'):
  if f.is_file():files.append({'path':str(f.relative_to(r)),'bytes':f.stat().st_size,'sha256':hashlib.sha256(f.read_bytes()).hexdigest()})
(r/'handoff-artifacts.json').write_text(json.dumps(files,indent=2));print('Handoff complete:',len(files),'hashed artifacts')
