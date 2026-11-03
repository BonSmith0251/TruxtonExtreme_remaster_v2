import re, pathlib, functools
ROOT = pathlib.Path(r'D:\games\TruxtonExRecon\code\type-model-source\DiffableCs')
@functools.lru_cache(None)
def index():
    idx = {}
    for p in ROOT.rglob('*.cs'):
        idx.setdefault(p.stem, []).append(p)
    return idx
def fields(cls):
    """returns {nested_path: [(static, off, type, name)]} for file named cls"""
    out = {}
    for p in index().get(cls, []):
        stack = []; depth = 0; pending = None
        for line in p.read_text(encoding='utf-8', errors='replace').splitlines():
            m = re.search(r'\b(class|struct|enum|interface)\s+([^\s:<]+(?:<[^>]*>)?)', line)
            if m and not line.strip().startswith('['): pending = m.group(2)
            for ch in line:
                if ch == '{':
                    depth += 1
                    if pending: stack.append((pending, depth)); pending = None
                elif ch == '}':
                    if stack and stack[-1][1] == depth: stack.pop()
                    depth -= 1
            fm = re.match(r'\s*(?:public|private|protected|internal)[^;]*?\s([\w<>\[\],`\.]+)\s+([<>\w\.]+);\s*//Field offset: (0x[0-9A-Fa-f]+)', line)
            if fm:
                key = '/'.join(s[0] for s in stack)
                out.setdefault(key, []).append(('static' in line.split('//')[0].split(), int(fm.group(3), 16), fm.group(1), fm.group(2)))
    return out
if __name__ == '__main__':
    import sys
    for k, v in fields(sys.argv[1]).items():
        print('==', k)
        for s, o, t, n in v: print('  %s %4x %s %s' % ('S' if s else ' ', o, t, n))
