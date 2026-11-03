# Pawn-aware annotated disassembly (read-only). Movers study.
# usage: python -I pdis.py <Class> <methodSubstring | RVAhex lenhex> [--sm Outer:Nested]
#  this-fields: <Class> and its base chain (prefix '.'), mover fields (prefix 'mv.', EnemyMover chain),
#  statics: '[TypeInfo X]' then '+0xb8' -> 'S:X.field' when disp matches X's static fields.
import sys, re, struct, json, pathlib
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\ground-route-events\tools')
import il2, fields
import rdis
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_REG_RIP
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
def base_of(c):
    for p in fields.index().get(c, []):
        m = re.search(r'class\s+' + re.escape(c) + r'\s*:\s*([\w\.]+)', p.read_text(encoding='utf-8', errors='replace'))
        if m: return m.group(1).split('.')[-1]
def chain(c):
    out = []
    while c and c not in out and len(out) < 20:
        out.append(c); c = base_of(c)
    return out
def inst(c):
    d = {}
    for k in reversed(chain(c)):
        for o, n in rdis.sm_fields(k, k).items(): d[o] = n
    return d
def statics(c):
    d = {}
    for k, v in fields.fields(c).items():
        if k.split('/')[-1] != c: continue
        for s, o, t, n in v:
            if s: d[o] = n
    return d
def dis(cls, rva, n, SM=None):
    P = inst(cls); MV = inst('EnemyMover'); EV = rdis.EV
    data = il2.rd(rva, n); lines = []; lastti = None; stat_regs = {}
    for ins in md.disasm(data, rva):
        out = []
        if ins.mnemonic in ('call', 'jmp') and ins.op_str.startswith('0x'):
            t = int(ins.op_str, 16); nm = il2.MNAME.get(t)
            if nm: out.append(' | '.join(nm[:2]))
        for op in ins.operands:
            if op.type != X86_OP_MEM: continue
            if op.mem.base == X86_REG_RIP:
                t = ins.address + ins.size + op.mem.disp; s = il2.sect_of(t)
                if not s: continue
                if s[0] == '.rdata':
                    d = il2.rd(t, 16); f = struct.unpack('<4f', d); dd = struct.unpack('<d', d[:8])[0]
                    out.append('rdata %x f=%.7g,%.7g,%.7g,%.7g d=%.10g' % (t, *f, dd))
                elif s[0] == '.data':
                    v = il2.q(t); u = il2.decode_usage(v) if v is not None else None
                    out.append('[%x] %s' % (t, u or ('=%x' % v if v else 'bss')))
                    if u and u.startswith('TypeInfo '):
                        lastti = u.split()[-1].split('.')[-1]
                        stat_regs[ins.reg_name(ins.operands[0].reg) if ins.operands[0].type == 1 else None] = lastti
            elif op.mem.index == 0:
                disp = op.mem.disp; cand = []; br = ins.reg_name(op.mem.base)
                if disp == 0xb8 and br in stat_regs:
                    cand.append('statics')
                    if ins.operands[0].type == 1: stat_regs[ins.reg_name(ins.operands[0].reg)] = ('S', stat_regs[br])
                elif br in stat_regs and isinstance(stat_regs[br], tuple):
                    st = statics(stat_regs[br][1])
                    if disp in st: cand.append('S:%s.%s' % (stat_regs[br][1], st[disp]))
                if not cand and not (disp == 0xb8 and br in stat_regs):
                    if SM and disp in SM: cand.append('sm.' + SM[disp])
                    if disp in P and disp >= 0x30: cand.append('.' + P[disp])
                    if disp in MV and disp >= 0x30 and MV.get(disp) != P.get(disp): cand.append('mv.' + MV[disp])
                    if disp in EV and disp >= 0x10 and not cand: cand.append('ev.' + EV[disp])
                if cand: out.append('/'.join(cand))
        if ins.operands and ins.operands[0].type == 1 and ins.mnemonic in ('mov', 'lea', 'movzx', 'movsxd', 'xor', 'add', 'pop'):
            r = ins.reg_name(ins.operands[0].reg)
            if r in stat_regs and not ('TypeInfo' in ''.join(out) or (len(ins.operands) > 1 and ins.operands[1].type == 3 and ins.operands[1].mem.disp == 0xb8)):
                del stat_regs[r]
        if ins.mnemonic == 'mov' and len(ins.operands) == 2 and ins.operands[1].type == 2:
            iv = ins.operands[1].imm & 0xffffffff
            if 0x3a000000 <= iv <= 0x4f000000 or 0xba000000 <= iv <= 0xcf000000: out.append('f=%.7g' % struct.unpack('<f', struct.pack('<I', iv))[0])
        lines.append('%08x  %-8s %s%s' % (ins.address, ins.mnemonic, ins.op_str, ('   ; ' + ' ; '.join(out)) if out else ''))
    return '\n'.join(lines)
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    a = sys.argv[1:]; SM = None
    if '--sm' in a:
        i = a.index('--sm'); o, nm = a[i+1].split(':'); SM = rdis.sm_fields(o, nm); del a[i:i+2]
    cls, key = a[0], a[1]
    if re.fullmatch(r'(0x)?[0-9A-Fa-f]{6,}', key):
        print(dis(cls, int(key, 16), int(a[2], 16), SM))
    else:
        for r, n, t, sig in rdis.find(cls, key):
            if t.split('.')[-1] != cls and not t.split('.')[-1].startswith(cls + '/'): continue
            print('#### %s::%s RVA %x len %x' % (t, sig, r, n)); print(dis(cls, r, n, SM))
