# Decode the static route-event programs that Ene_* .cctors build with the RouteEvent factory methods (read-only).
# Linear register-tracking pass over the .cctor: strings/floats/ints in registers and stack slots, RouteEvent factory
# calls, static-field stores ([TypeInfo+0xb8]+off) and List<RouteEvent>.Add / List<List<RouteEvent>>.Add (inline
# fast path recognised by `inc dword [list+0x1c]`).
# usage: C:\Python311\python.exe -I cctor_programs.py <cctorRVAhex> <lenhex> [ClassName]
import sys, struct, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_OP_REG, X86_OP_IMM, X86_REG_RIP, X86_REG_RSP
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
# factory RVA -> (name, eventType, [(argkind, field)])   argkind: i=int reg, f=float(xmm), s=pointer(str), v=Vector3*, b=bool
FACT = {
    0x1D3E5A0: ('BSelector', 83, [('s', 'stringValue'), ('i', 'repeatCount'), ('f', 'repeatDelay'), ('f', 'randomFire'), ('f', 'randomWait'), ('s', 'nameValue'), ('b', 'flag0')]),
    0x1D3E6B0: ('Bullet', 8, [('s', 'stringValue'), ('i', 'repeatCount'), ('f', 'repeatDelay'), ('f', 'randomFire'), ('f', 'randomWait'), ('s', 'nameValue'), ('b', 'flag0')]),
    0x1D3F1B0: ('SplineMove', 15, [('s', 'stringValue')]),
    0x1D3EC70: ('Label', 5, [('s', 'stringValue')]),
    0x1D3ED40: ('Loop', 101, [('s', 'stringValue'), ('i', 'intValue1')]),
    0x1D3E920: ('Delay', 1, [('f', 'dotime'), ('b', 'isAbsolute?')]),
    0x1D3EBA0: ('Idle', 20, [('f', 'dotime')]),
    0x1D3F280: ('TaskWait', 80, [('i', 'intValue1')]),
    0x1D3F000: ('SetFlag', 10, [('i', 'intValue1')]),
    0x1D3EE20: ('ResetFlag', 11, [('i', 'intValue1')]),
    0x1D3F0D0: ('Speed', 14, [('f', 'value0'), ('f', 'dotime')]),
    0x1D3F350: ('Translate', 13, [('v', 'vectorValue'), ('f', 'dotime'), ('f', 'value0 preWait'), ('f', 'value1 postWait'), ('s', 'nameValue'), ('b', 'flag0 isRelative')]),
    0x1D3EEF0: ('Rotate', 2, [('f', 'dotime'), ('f', 'value0 before'), ('f', 'value1 after'), ('v', 'vectorValue'), ('s', 'nameValue'), ('b', 'flag0 abs'), ('i', 'intValue1 easing')]),
    0x1D3EAC0: ('ForwardMove', 12, [('f', 'dotime'), ('f', 'value0 wait')]),
    0x1D3EA00: ('Finish', 1000, []),
    0x1D3E7C0: ('Clone', None, []),
}
GP = ['rcx', 'rdx', 'r8', 'r9']
R64 = {}
for a, b4 in [('rax', 'eax'), ('rbx', 'ebx'), ('rcx', 'ecx'), ('rdx', 'edx'), ('rsi', 'esi'), ('rdi', 'edi'), ('rbp', 'ebp')]:
    R64[a] = a; R64[b4] = a; R64[a[1] + 'l' if a != 'rsi' and a != 'rdi' and a != 'rbp' else a[1:] + 'l'] = a
for n in range(8, 16):
    for s in ('', 'd', 'w', 'b'): R64['r%d%s' % (n, s)] = 'r%d' % n
R64.update({'sil': 'rsi', 'dil': 'rdi', 'bpl': 'rbp', 'al': 'rax', 'bl': 'rbx', 'cl': 'rcx', 'dl': 'rdx'})
def canon(r): return R64.get(r, r)
def run(rva, n, cls=None):
    data = il2.rd(rva, n)
    ins = list(md.disasm(data, rva))
    reg = {}; xmm = {}; stk = {}; statics = {}; objs = {}; evs = []; out = []
    nobj = [0]
    def rip_target(i, op): return i.address + i.size + op.mem.disp
    def usage(t):
        s = il2.sect_of(t)
        if not s: return None
        if s[0] == '.rdata':
            return ('f', struct.unpack('<f', il2.rd(t, 4))[0])
        if s[0] == '.data':
            v = il2.q(t); u = il2.decode_usage(v) if v is not None else None
            if u and u.startswith('str:'): return ('str', u[4:].strip('"'))
            if u and u.startswith('TypeInfo'): return ('type', u.split()[-1])
            return ('usage', u)
    def val(op, i):
        if op.type == X86_OP_REG:
            nm = i.reg_name(op.reg)
            if nm.startswith('xmm'): return xmm.get(nm)
            return reg.get(canon(nm))
        if op.type == X86_OP_IMM: return ('i', op.imm)
        if op.type == X86_OP_MEM:
            if op.mem.base == X86_REG_RIP: return usage(rip_target(i, op))
            if op.mem.base == X86_REG_RSP and op.mem.index == 0: return stk.get(op.mem.disp)
            b = reg.get(canon(i.reg_name(op.mem.base))) if op.mem.base else None
            if b and b[0] == 'type' and op.mem.disp == 0xb8: return ('statics', b[1])
            if b and b[0] == 'statics': return statics.get(op.mem.disp, ('statref', op.mem.disp))
            return None
    def setdst(op, v, i):
        if op.type == X86_OP_REG:
            nm = i.reg_name(op.reg)
            if nm.startswith('xmm'): xmm[nm] = v
            else: reg[canon(nm)] = v
        elif op.type == X86_OP_MEM:
            if op.mem.base == X86_REG_RSP and op.mem.index == 0:
                if v and v[0] == 'pair': stk[op.mem.disp] = ('f', v[1]); stk[op.mem.disp + 4] = ('f', v[2])
                else: stk[op.mem.disp] = v
            elif op.mem.base:
                b = reg.get(canon(i.reg_name(op.mem.base)))
                if b and b[0] == 'statics': statics[op.mem.disp] = v; out.append(('static', op.mem.disp, v, i.address))
    k = 0
    while k < len(ins):
        i = ins[k]; m = i.mnemonic; ops = i.operands
        if m in ('mov', 'movss', 'movaps', 'movsd', 'movzx', 'movsxd', 'lea') and len(ops) == 2:
            if m == 'lea':
                b = reg.get(canon(i.reg_name(ops[1].mem.base))) if ops[1].mem.base and ops[1].mem.base != X86_REG_RIP else None
                if ops[1].mem.base == X86_REG_RSP: b = 'rsp'
                setdst(ops[0], ('lea', b, ops[1].mem.disp) if b else None, i)
            else:
                setdst(ops[0], val(ops[1], i), i)
        elif m == 'unpcklps' and ops[0].type == X86_OP_REG and ops[1].type == X86_OP_REG:
            a = xmm.get(i.reg_name(ops[0].reg)); b = xmm.get(i.reg_name(ops[1].reg))
            xmm[i.reg_name(ops[0].reg)] = ('pair', a[-1] if a else None, b[-1] if b else None)
        elif m in ('xor', 'xorps', 'pxor') and len(ops) == 2 and ops[0].type == X86_OP_REG and ops[1].type == X86_OP_REG and ops[0].reg == ops[1].reg:
            nm = i.reg_name(ops[0].reg)
            if nm.startswith('xmm'): xmm[nm] = ('f', 0.0)
            else: reg[canon(nm)] = ('i', 0)
        elif m == 'inc' and ops[0].type == X86_OP_MEM and ops[0].mem.disp == 0x1c and ops[0].mem.base:
            lst = reg.get(canon(i.reg_name(ops[0].mem.base)))
            # item: register stored by the inline fast path `mov qword ptr [rX + rcx*8 + 0x20], REG`
            item = None
            for j in range(k + 1, min(k + 30, len(ins))):
                jj = ins[j]
                if jj.mnemonic == 'mov' and jj.operands[0].type == X86_OP_MEM and jj.operands[0].mem.index and jj.operands[0].mem.disp == 0x20                         and jj.operands[1].type == X86_OP_REG:
                    item = reg.get(canon(jj.reg_name(jj.operands[1].reg))); break
            if lst and lst[0] == 'obj':
                objs.setdefault(lst[1], []).append(item); out.append(('add', lst, item, i.address))
        elif m == 'call' and i.op_str.startswith('0x'):
            t = int(i.op_str, 16)
            if t == 0x4e0cb0:
                nobj[0] += 1; reg['rax'] = ('obj', nobj[0], (reg.get('rcx') or ('?',))[-1])
            elif t in FACT:
                name, et, args = FACT[t]
                fields = {}; gi = 0
                for slot, (kind, fld) in enumerate(args):
                    if slot < 4:
                        v = xmm.get('xmm%d' % slot) if kind == 'f' else reg.get(GP[slot])
                    else:
                        v = stk.get(0x20 + 8 * (slot - 4))
                    if kind == 'v' and v and v[0] == 'lea':
                        v = ('vec', tuple((stk.get(v[2] + 4 * c) or ('?',))[-1] for c in range(3)))
                    fields[fld] = v[-1] if v else None
                evs.append((name, et, fields, i.address)); reg['rax'] = ('ev', len(evs) - 1)
            elif t == 0x2500 and reg.get('r8') and reg['r8'][0] == 'usage' and '::Add' in (reg['r8'][1] or ''):
                lst = reg.get('rcx'); item = reg.get('rdx')
                if lst and lst[0] == 'obj': objs.setdefault(lst[1], []).append(item); out.append(('add', lst, item, i.address))
            else:
                reg['rax'] = ('ret', t)
            for r in ('rcx', 'rdx', 'r8', 'r9', 'r10', 'r11'): reg.pop(r, None)
            for x in range(6): xmm.pop('xmm%d' % x, None)
        k += 1
    return evs, objs, statics, out
def fmt_ev(evs, v):
    if not v: return '?'
    if v[0] == 'ev':
        n, et, f, a = evs[v[1]]
        fs = ' '.join('%s=%s' % (k, ('%g' % x if isinstance(x, float) else repr(x))) for k, x in f.items())
        return '%-11s(%d) %s   @%x' % (n, et if et is not None else -1, fs, a)
    if v[0] == 'statref': return 'static+0x%x' % v[1]
    return repr(v)
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    rva, n = int(sys.argv[1], 16), int(sys.argv[2], 16)
    evs, objs, statics, out = run(rva, n)
    print('## static fields')
    for off, v in sorted(statics.items()):
        print('  +0x%x = %s' % (off, fmt_ev(evs, v) if v and v[0] == 'ev' else ('obj#%d' % v[1] if v and v[0] == 'obj' else v)))
    print('## lists (obj id: items in Add order)')
    for oid, items in objs.items():
        print('-- obj#%d (%d items)' % (oid, len(items)))
        for k, it in enumerate(items):
            print('   [%2d] %s' % (k, ('list obj#%d' % it[1]) if it and it[0] == 'obj' else fmt_ev(evs, it)))
