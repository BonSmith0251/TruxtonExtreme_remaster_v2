import json, hashlib, argparse, datetime
from pathlib import Path
p=argparse.ArgumentParser(description='Verify that all original build files remain unchanged against the initial SHA256 inventory.')
p.add_argument('--inventory',required=True);p.add_argument('--out',required=True)
a=p.parse_args(); inv=json.loads(Path(a.inventory).read_text()); root=Path(inv['root'])
issues=[]; checked=0
for row in inv['files']:
    path=root/row['path']
    try:
        digest=hashlib.file_digest(path.open('rb'),'sha256').hexdigest()
        if digest!=row['sha256']: issues.append({'path':row['path'],'status':'changed','before':row['sha256'],'after':digest})
        checked+=1
    except Exception as exc: issues.append({'path':row['path'],'status':'failed','reason':str(exc)})
known={r['path'] for r in inv['files']}
added=[x.relative_to(root).as_posix() for x in root.rglob('*') if x.is_file() and x.relative_to(root).as_posix() not in known]
result={'schema':'original-preservation-check/1','created_utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'inventory':str(Path(a.inventory).resolve()),'source':str(root),'checked_files':checked,'passed':not issues and not added,'issues':issues,'added_files':added}
Path(a.out).write_text(json.dumps(result,indent=2));print(json.dumps(result));raise SystemExit(0 if result['passed'] else 1)
