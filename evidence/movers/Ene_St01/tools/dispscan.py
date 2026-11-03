# Find instructions reading [reg+DISP] (e.g. a vtable slot) in an RVA range and name the containing method. Read-only.
# usage: python -I dispscan.py <disphex> [lo hi]   (default range: the InGame code 0x1C80000..0x1E40000)
import sys, bisect
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True; md.skipdata = True
disp = int(sys.argv[1], 16); lo = int(sys.argv[2], 16) if len(sys.argv) > 2 else 0x1C80000; hi = int(sys.argv[3], 16) if len(sys.argv) > 3 else 0x1E40000
starts = sorted(il2.MNAME)
seen = set()
for s in starts:
    if not lo <= s < hi: continue
    i = bisect.bisect_right(starts, s); e = starts[i] if i < len(starts) else s + 0x4000
    data = il2.rd(s, min(e - s, 0x8000))
    for ins in md.disasm(data, s):
        if ins.mnemonic not in ('mov', 'call', 'jmp'): continue
        for op in ins.operands:
            if op.type == X86_OP_MEM and op.mem.disp == disp and op.mem.base != 0:
                print(hex(ins.address), ins.mnemonic, ins.op_str, '|', il2.MNAME[s][0]); break
