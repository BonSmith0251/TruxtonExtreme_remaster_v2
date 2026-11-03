import hashlib, json, os, sys
from datetime import datetime, timezone

# Appends the 2026-11-01 stage-presentation skill improvements to installed-updates.json.
root = os.path.dirname(os.path.abspath(__file__))
refs = os.path.expanduser('~/.codex/skills/unity-project-reconstruction/references')
sha = lambda p: hashlib.sha256(open(p, 'rb').read()).hexdigest()
ledger_path = os.path.join(root, 'installed-updates.json')
ledger = json.load(open(ledger_path, encoding='utf-8-sig'))
now = datetime.now(timezone.utc).isoformat()
for name, backup, scope, evidence in [
    ('version-migration.md', 'version-migration.before-propertyname.md',
     'Conditional diagnostic + repair recipe for player-format PropertyName ids in exposed references; verified on 20 Truxton timelines (60 blocks).',
     ['tools/repair_exposed_names.py', 'evidence/stage-presentation/exposed-name-repair.json', 'verification/stage-presentation/report.json']),
    ('scenes-and-engine-features.md', 'scenes-and-engine-features.before-manual-directors.md',
     'Method for presenting Manual-update timelines whose ticking code is stubbed; verified on BG01-BG08 in edit-mode evaluation and editor Play.',
     ['Reconstructed/Assets/Reconstruction/StagePresentation.cs', 'verification/stage-presentation/report.json', 'verification/stage-presentation/play-mode.jsonl']),
]:
    ledger['updates'].append({
        'installed': True, 'skill': 'unity-project-reconstruction',
        'file': os.path.join(refs, name),
        'before_sha256': sha(os.path.join(root, backup)), 'after_sha256': sha(os.path.join(refs, name)),
        'backup': os.path.join(root, backup), 'evidence': evidence, 'scope': scope,
        'maintainer': 'Claude (Opus 5.5) session 2026-11-01', 'timestamp_utc': now})
json.dump(ledger, open(ledger_path, 'w', encoding='utf-8'), indent=4, ensure_ascii=False)
print(len(ledger['updates']))
