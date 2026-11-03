"""Exact-string patches that keep a file's own line endings (CRLF or LF).

usage: patch_text.py <patch.json>   where patch.json = [{"file": path, "old": text, "new": text}, ...]
Texts in the JSON use \n; they are converted to the file's line ending. Every "old" must occur exactly once.
"""
import json, sys

for p in json.load(open(sys.argv[1], encoding='utf-8')):
    raw = open(p['file'], 'rb').read().decode('utf-8')
    nl = '\r\n' if '\r\n' in raw else '\n'
    old, new = p['old'].replace('\n', nl), p['new'].replace('\n', nl)
    n = raw.count(old)
    if n != 1:
        raise SystemExit('%s: expected 1 match, found %d for %r' % (p['file'], n, p['old'][:80]))
    raw = raw.replace(old, new)
    open(p['file'], 'wb').write(raw.encode('utf-8'))
    print('patched', p['file'])
