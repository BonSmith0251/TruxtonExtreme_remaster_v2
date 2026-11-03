"""Annotate Cpp2IL ISIL dumps with .rdata float constants and Ene_Bos06 field names.
Usage: python -I annotate_isil.py <isil.txt> <out.txt>
ISIL produced by: Cpp2IL.exe --game-path "D:\games\Truxton Extreme" --output-as isil (Cpp2IL 2022.1.0-pre21, code\tools).
Read-only on the game; writes only <out.txt>."""
import sys, re, struct, json, pathlib
GAME = pathlib.Path(r'D:\games\Truxton Extreme\GameAssembly.dll')
b = GAME.read_bytes()
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe + 6)[0]; osz = struct.unpack_from('<H', b, pe + 20)[0]
opt = pe + 24; base = struct.unpack_from('<Q', b, opt + 24)[0]; sect = []
for i in range(ns):
    off = opt + osz + i * 40; name = b[off:off + 8].rstrip(b'\0').decode(); vs, va, sz, ptr = struct.unpack_from('<4I', b, off + 8)
    sect.append((name, va, max(vs, sz), ptr, sz))
def raw(va):
    rva = va - base
    for n, s, sz, p, rs in sect:
        if s <= rva < s + sz and rva - s < rs: return p + rva - s, n
    return None, None
def fl(x):
    v = struct.unpack('<f', struct.pack('<I', x))[0]
    return ('%.7g' % v)
def rd(va):
    p, n = raw(va)
    if p is None or n not in ('.rdata',): return None
    f = struct.unpack_from('<f', b, p)[0]; d = struct.unpack_from('<d', b, p)[0]
    s = 'f=%.7g' % f
    if 1e-6 < abs(d) < 1e7: s += ' d=%.10g' % d
    q = struct.unpack_from('<4f', b, p)
    if any(q[1:]): s += ' v4=(%s)' % ','.join('%.6g' % x for x in q)
    return s
src = pathlib.Path(sys.argv[1]).read_text(encoding='utf-8', errors='replace').splitlines()
out = []
for line in src:
    notes = []
    for m in re.finditer(r'\[0x(18[0-9A-Fa-f]{7})\]', line):
        r = rd(int(m.group(1), 16))
        if r: notes.append('[%s]=%s' % (m.group(1), r))
    for m in re.finditer(r'(?<![\[\w])0x([34][0-9A-Fa-f]{7}|[BC][0-9A-Fa-f]{7})\b', line):
        notes.append('%s=%s' % (m.group(0), fl(int(m.group(1), 16))))
    out.append(line + ('    ; ' + ' '.join(notes) if notes else ''))
pathlib.Path(sys.argv[2]).write_text('\n'.join(out), encoding='utf-8')
