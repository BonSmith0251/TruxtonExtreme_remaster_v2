# usage: python bdis.py <Class> <methodNameSubstring|RVA hex> [len hex]   annotated disassembly (read-only)
import sys, struct, json, re, il2, fields
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_OP_REG, X86_REG_RIP
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
def inst_fields(cls):
    m = {}
    for c in ['HybridCollisions', 'InGameCollisionBase', 'PawnEnemy', 'Ene_BosBase', cls]:
        for k, v in fields.fields(c).items():
            if k.split('/')[-1] != c.split('/')[-1]: continue
            for s, o, t, n in v:
                if not s and o >= 0x20: m[o] = n
    return m
def static_fields(cls):
    m = {}
    for k, v in fields.fields(cls.split('/')[0]).items():
        for s, o, t, n in v:
            if s: m.setdefault(k.split('/')[-1], {})[o] = n
    return m
import functools
@functools.lru_cache(None)
def vt(cls):
    td = il2.find_typedef(cls.split('/')[0])
    return dict(il2.vtable(td[0])) if td else {}
def dis(rva, n, cls):
    IF = inst_fields(cls); data = il2.rd(rva, n); lines = []
    regtype = {}; regstat = {}; regklass = set(); VT = vt(cls)
    for ins in md.disasm(data, rva):
        out = []
        if ins.mnemonic in ('call', 'jmp') and ins.op_str.startswith('0x'):
            t = int(ins.op_str, 16); nm = il2.MNAME.get(t)
            if nm: out.append(' | '.join(nm[:2]))
        dst = ins.operands[0].reg if len(ins.operands) and ins.operands[0].type == X86_OP_REG else None
        newtype = None; newstat = None
        for op in ins.operands:
            if op.type != X86_OP_MEM: continue
            if op.mem.base == X86_REG_RIP:
                t = ins.address+ins.size+op.mem.disp; s = il2.sect_of(t)
                if not s: continue
                if s[0] == '.rdata':
                    d = il2.rd(t, 16); f = struct.unpack('<4f', d); dd = struct.unpack('<d', d[:8])[0]
                    out.append('rdata %x f=%.7g,%.7g,%.7g,%.7g d=%.10g' % (t, *f, dd))
                elif s[0] == '.data':
                    v = il2.q(t); u = il2.decode_usage(v) if v is not None else None
                    if u is None and v: u = hex(v)
                    out.append('[%x] %s' % (t, u or 'bss'))
                    if u and u.startswith('TypeInfo '): newtype = u[9:]
            else:
                b = op.mem.base; disp = op.mem.disp
                if b in regklass and disp >= 0x138 and (disp-0x138) % 16 in (0, 8):
                    out.append('vcall %s' % VT.get((disp-0x138)//16))
                elif b in regstat:
                    cname = regstat[b].split('.')[-1]; sf = static_fields(cls).get(cname, {})
                    if sf.get(disp): out.append('static %s.%s' % (cname, sf[disp]))
                    else: out.append('static %s+%x' % (cname, disp))
                elif b in regtype and disp == 0xb8:
                    newstat = regtype[b]
                elif disp in IF:
                    out.append('.'+IF[disp])
        if dst is not None:
            regtype.pop(dst, None); regstat.pop(dst, None); regklass.discard(dst)
            if ins.mnemonic == 'mov' and len(ins.operands) == 2 and ins.operands[1].type == X86_OP_MEM and ins.operands[1].mem.disp == 0 and ins.operands[1].mem.base != X86_REG_RIP and ins.operands[1].mem.index == 0: regklass.add(dst)
            if newtype and ins.mnemonic == 'mov': regtype[dst] = newtype
            if newstat and ins.mnemonic == 'mov': regstat[dst] = newstat
        if ins.mnemonic == 'call': regtype.clear(); regstat.clear(); regklass.clear()
        lines.append('%08x  %-8s %s%s' % (ins.address, ins.mnemonic, ins.op_str, ('   ; '+' ; '.join(out)) if out else ''))
    return '\n'.join(lines)
def find(cls, key):
    res = []
    for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
        m = json.loads(line)
        if not (m['type'].endswith('.'+cls) or ('.'+cls+'/') in m['type']): continue
        a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
        if not a or not a[0]['fields'].get('RVA'): continue
        sig = m['signature'].split('::')[-1]
        if key in sig: res.append((int(a[0]['fields']['RVA'], 16), int(a[0]['fields']['Length'], 16), m['type'], sig))
    return res
if __name__ == '__main__':
    cls = sys.argv[1]; key = sys.argv[2]
    if re.fullmatch(r'[0-9A-Fa-f]{6,}', key):
        print(dis(int(key, 16), int(sys.argv[3], 16), cls))
    else:
        for r, n, t, sig in find(cls, key):
            print('#### %s::%s RVA %x len %x' % (t, sig, r, n)); print(dis(r, n, cls.split('/')[0]))
