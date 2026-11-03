"""Point the materials Codex moved from TATSUJIN/TXE_Lit to URP Lit back at the (now recovered) TXE_Lit shader.

For every material listed in evidence/scene-integration/material-and-comic-compatibility.json with
sourceShader TATSUJIN/TXE_Lit, restore from the pristine export exactly these blocks: m_Shader, m_ValidKeywords,
m_InvalidKeywords and disabledShaderPasses. Property values were never changed by the migration and are kept.
Each file is backed up once; a log records before/after hashes.

usage: restore_txe_lit_materials.py <reconstruction root> [--dry-run]
"""
import hashlib, json, os, re, shutil, sys

root = sys.argv[1]
dry = '--dry-run' in sys.argv
proj = os.path.join(root, 'Reconstructed')
pristine = os.path.join(root, 'extraction', 'pristine-export', 'ExportedProject')
backup = os.path.join(root, 'backups', 'before-shader-recovery')
changes = json.load(open(os.path.join(root, 'evidence', 'scene-integration', 'material-and-comic-compatibility.json')))['materialChanges']
BLOCKS = ['m_Shader', 'm_ValidKeywords', 'm_InvalidKeywords', 'disabledShaderPasses']

def block(lines, key):
    """Index range [start, end) of a top-level material field (key line plus its indented '- ' list items)."""
    for i, l in enumerate(lines):
        if l.startswith('  ' + key + ':'):
            j = i + 1
            while j < len(lines) and lines[j].startswith('  - '):
                j += 1
            return i, j
    return None

log, missing = [], []
for c in changes:
    if c.get('sourceShader') != 'TATSUJIN/TXE_Lit':
        continue
    rel = c['asset']
    cur = os.path.join(proj, rel)
    src = os.path.join(pristine, rel.replace('Assets/OriginalGame/', 'Assets/', 1))
    if not os.path.exists(cur) or not os.path.exists(src):
        missing.append(rel)
        continue
    a = open(cur, encoding='utf-8').read().split('\n')
    b = open(src, encoding='utf-8').read().split('\n')
    before = hashlib.sha256('\n'.join(a).encode()).hexdigest()
    for key in BLOCKS:
        ra, rb = block(a, key), block(b, key)
        if ra and rb:
            a[ra[0]:ra[1]] = b[rb[0]:rb[1]]
    text = '\n'.join(a)
    after = hashlib.sha256(text.encode()).hexdigest()
    shader = re.search(r'm_Shader: \{[^}]*guid: ([0-9a-f]+)', text)
    log.append({'asset': rel, 'shaderGuid': shader.group(1) if shader else None, 'sha256Before': before, 'sha256After': after})
    if not dry and before != after:
        dest = os.path.join(backup, rel)
        os.makedirs(os.path.dirname(dest), exist_ok=True)
        if not os.path.exists(dest):
            shutil.copy2(cur, dest)
        with open(cur, 'w', encoding='utf-8', newline='\n') as h:
            h.write(text)
out = os.path.join(root, 'evidence', 'shader-recovery', 'txe-lit-material-restore.json')
if not dry:
    json.dump({'restored': log, 'missing': missing}, open(out, 'w'), indent=1)
guids = {}
for x in log:
    guids[x['shaderGuid']] = guids.get(x['shaderGuid'], 0) + 1
print(len(log), 'materials', 'missing', len(missing), 'shader guids', guids, '(dry run)' if dry else '')
