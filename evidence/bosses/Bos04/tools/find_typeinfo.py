import sys; sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos04\tools')
import nat
from capstone.x86 import X86_OP_MEM, X86_REG_RIP
targets = {0x43c16d8: '#48704', 0x438b958: '#43865', 0x43b17f8: '#37303'}
hits = {}
for sig, (r, l) in nat.methods.items():
    if '::.cctor' not in sig: continue
    p = nat.raw(r)
    if p is None: continue
    for ins in nat.md.disasm(nat.b[p:p+min(l, 0x400)], r):
        for op in ins.operands:
            if op.type == X86_OP_MEM and op.mem.base == X86_REG_RIP:
                t = ins.address + ins.size + op.mem.disp
                if t in targets and ins.mnemonic == 'mov':
                    hits.setdefault(targets[t], []).append(sig)
for k, v in hits.items(): print(k, sorted(set(v))[:8])
