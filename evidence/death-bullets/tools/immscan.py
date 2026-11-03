# Scan .text for 'mov r8d, imm32' (41 B8 imm32) with the given immediates and print owning InGame/TXE methods. Read-only.
# usage: python -I immscan.py 64 6e 6f
import sys, bisect, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
starts = sorted(il2.MNAME)
def owner(rva):
    j = bisect.bisect_right(starts, rva)-1; return il2.MNAME[starts[j]][0] if j >= 0 else '?'
for a in sys.argv[1:]:
    v = int(a, 16); pat = re.compile(rb'\x41\xb8' + re.escape(v.to_bytes(4, 'little')))
    print('== mov r8d, %#x' % v)
    for name, va, vsz, ptr, rsz, ch in il2.SECT:
        if name not in ('.text', 'il2cpp'): continue
        data = il2.b[ptr:ptr+rsz]
        for m in pat.finditer(data):
            o = owner(va+m.start())
            if re.match(r'(Ene_|Pawn|InGame|Weapon|Player|Bullet|Enemy|Rook|HybridColl|TXE)', o): print('  %x %s' % (va+m.start(), o))
