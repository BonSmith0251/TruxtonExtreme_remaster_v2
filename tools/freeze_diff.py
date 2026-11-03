"""Hash Assets/Packages/ProjectSettings (as scene-work/freeze_project.py does), write a new revision manifest beside the
stage-presentation evidence, and list every path added, removed or changed relative to the previous frozen manifest.

usage: freeze_diff.py <revision label> <previous manifest> <output manifest> <output diff>
"""
from pathlib import Path
import datetime, hashlib, json, sys

revision, previous, output, diff_out = sys.argv[1:5]
project = Path(r'D:\Games\TruxtonExRecon\Reconstructed')
rows = []
for folder in ['Assets', 'Packages', 'ProjectSettings']:
    for f in (project / folder).rglob('*'):
        if not f.is_file():
            continue
        h = hashlib.sha256()
        with f.open('rb') as q:
            for b in iter(lambda: q.read(8 * 1024 * 1024), b''):
                h.update(b)
        rows.append({'path': str(f.relative_to(project)).replace('\\', '/'), 'bytes': f.stat().st_size, 'sha256': h.hexdigest()})
rows.sort(key=lambda x: x['path'])
out = {'revision': revision, 'timeUTC': datetime.datetime.now(datetime.timezone.utc).isoformat(), 'project': str(project),
       'files': len(rows), 'logicalBytes': sum(x['bytes'] for x in rows), 'scope': ['Assets', 'Packages', 'ProjectSettings'], 'entries': rows}
Path(output).write_text(json.dumps(out, indent=2))
old = {e['path']: e['sha256'] for e in json.loads(Path(previous).read_text())['entries']}
new = {e['path']: e['sha256'] for e in rows}
diff = {'previous': previous, 'previousRevision': json.loads(Path(previous).read_text()).get('revision'), 'revision': revision,
        'manifestSha256': hashlib.sha256(Path(output).read_bytes()).hexdigest(),
        'added': sorted(set(new) - set(old)), 'removed': sorted(set(old) - set(new)),
        'changed': sorted(p for p in set(new) & set(old) if new[p] != old[p])}
Path(diff_out).write_text(json.dumps(diff, indent=1))
print(revision, len(rows), 'added', len(diff['added']), 'removed', len(diff['removed']), 'changed', len(diff['changed']), diff['manifestSha256'])
