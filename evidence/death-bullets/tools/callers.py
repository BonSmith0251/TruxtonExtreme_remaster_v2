# Find direct E8/E9 callers of an RVA in GameAssembly.dll .text and name the containing method (read-only).
# usage: C:\Python311\python.exe -I callers.py <RVAhex> [...]
import sys, bisect
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
import re
CODE = [s for s in il2.SECT if s[0] in ('.text', 'il2cpp')]
starts = sorted(il2.MNAME)
def owner(rva):
    i = bisect.bisect_right(starts, rva) - 1
    return (hex(starts[i]), il2.MNAME[starts[i]][:2]) if i >= 0 else None
for arg in sys.argv[1:]:
    tgt = int(arg, 16); print('== callers of', hex(tgt), il2.MNAME.get(tgt, [''])[:1])
    for name, va, vsz, ptr, rsz, ch in CODE:
        data = il2.b[ptr:ptr+rsz]
        for m in re.finditer(b'[\\xe8\\xe9]', data):
            i = m.start(); rel = int.from_bytes(data[i+1:i+5], 'little', signed=True); src = va + i
            if src + 5 + rel == tgt: print('  ', hex(src), 'jmp' if data[i] == 0xE9 else 'call', owner(src))
