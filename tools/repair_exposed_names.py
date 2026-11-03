"""Repair ExposedReference names in recovered Timeline assets for the Unity 2023 editor format.

The Unity 6 player serializes PropertyName as an integer id:

    sourceGameObject:
      exposedName:
        id: 1348633240

The 2023 editor format stores PropertyName as a string, so that block deserializes as id 0 and no ControlTrack clip
resolves its GameObject. The directors' reference tables were exported as `- 1348633240: {fileID: ...}`, which the
editor reads as the string "1348633240". Writing the timeline side as `exposedName: 1348633240` makes both sides the
same PropertyName again. Only that block shape is rewritten; files are backed up first and every change is logged.

usage: repair_exposed_names.py <Assets dir> <backup dir> <log.json> [file ...]
"""
import json, os, re, shutil, sys, hashlib

BLOCK = re.compile(r'^([ \t]+)exposedName:[ \t]*\r?\n\1[ \t]+id: (-?\d+)[ \t]*(\r?\n)', re.M)

def main():
    assets, backup, log_path = sys.argv[1:4]
    only = set(os.path.normcase(os.path.abspath(p)) for p in sys.argv[4:])
    log = []
    for dp, dn, fn in os.walk(assets):
        for f in fn:
            if not f.endswith('.playable'):
                continue
            path = os.path.join(dp, f)
            if only and os.path.normcase(os.path.abspath(path)) not in only:
                continue
            data = open(path, 'rb').read()
            text = data.decode('utf-8')
            new, count = BLOCK.subn(lambda m: f'{m.group(1)}exposedName: {m.group(2)}{m.group(3)}', text)
            if not count:
                continue
            rel = os.path.relpath(path, os.path.dirname(assets))
            dest = os.path.join(backup, rel)
            os.makedirs(os.path.dirname(dest), exist_ok=True)
            if not os.path.exists(dest):
                shutil.copy2(path, dest)
            open(path, 'wb').write(new.encode('utf-8'))
            log.append({'file': rel.replace(os.sep, '/'), 'blocks': count,
                        'sha256Before': hashlib.sha256(data).hexdigest(),
                        'sha256After': hashlib.sha256(new.encode('utf-8')).hexdigest()})
    json.dump({'repair': 'ExposedReference PropertyName id -> editor string name', 'files': log,
               'blocks': sum(x['blocks'] for x in log)}, open(log_path, 'w'), indent=1)
    print(len(log), 'files', sum(x['blocks'] for x in log), 'blocks')

if __name__ == '__main__':
    main()
