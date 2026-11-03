# Print vtable slots (byte offset in klass = 0x138 + 16*i) of named methods for a class, and scan .text for
# 'mov reg, [reg+off]' loads of a given slot offset (candidate virtual callers). Read-only.
# usage: python -I vslot.py <Class> <methodSubstring> [--scan]
import sys, bisect, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
cls, key = sys.argv[1], sys.argv[2]
td = il2.find_typedef(cls)
offs = []
for i, nm in il2.vtable(td[0]):
    if nm and key in str(nm): print(hex(0x138+16*i), i, nm); offs.append(0x138+16*i)
if '--scan' in sys.argv:
    starts = sorted(il2.MNAME)
    def owner(rva):
        j = bisect.bisect_right(starts, rva)-1; return il2.MNAME[starts[j]][0] if j >= 0 else '?'
    for off in offs:
        pat = re.compile(rb'[\x48\x4c][\x8b](?:[\x80-\xbf])' + re.escape(off.to_bytes(4, 'little')))
        for name, va, vsz, ptr, rsz, ch in il2.SECT:
            if name not in ('.text', 'il2cpp'): continue
            data = il2.b[ptr:ptr+rsz]; seen = set()
            for m in pat.finditer(data):
                o = owner(va+m.start())
                if o not in seen: seen.add(o); print('  slot %x load in %s @%x' % (off, o, va+m.start()))
