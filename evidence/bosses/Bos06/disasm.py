"""Disassemble a GameAssembly.dll RVA range with capstone, annotating calls (methods.jsonl) and .rdata floats.
Usage: python -I disasm.py <startRVA hex> <endRVA hex>   (read-only)"""
import sys, json, struct, pathlib
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
b = pathlib.Path(r'D:\games\Truxton Extreme\GameAssembly.dll').read_bytes()
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe + 6)[0]; osz = struct.unpack_from('<H', b, pe + 20)[0]
opt = pe + 24; base = struct.unpack_from('<Q', b, opt + 24)[0]; sect = []
for i in range(ns):
    off = opt + osz + i * 40; name = b[off:off + 8].rstrip(b'\0').decode(); vs, va, sz, ptr = struct.unpack_from('<4I', b, off + 8)
    sect.append((name, va, max(vs, sz), ptr, sz))
def raw(rva):
    for n, s, sz, p, rs in sect:
        if s <= rva < s + sz and rva - s < rs: return p + rva - s, n
    return None, None
names = {}
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
    m = json.loads(line)
    for a in m['attributes']:
        if a['type'] == 'Cpp2ILInjected.AddressAttribute' and a.get('fields', {}).get('RVA'):
            names.setdefault(int(a['fields']['RVA'], 16), m['type'].split('.')[-1] + '::' + m['signature'].split('::')[-1])
s, e = int(sys.argv[1], 16), int(sys.argv[2], 16)
p, _ = raw(s); md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = False
for ins in md.disasm(b[p:p + (e - s)], s):
    note = ''
    if ins.mnemonic in ('call', 'jmp') and ins.op_str.startswith('0x'):
        t = int(ins.op_str, 16); note = names.get(t, '')
    if 'rip' in ins.op_str:
        import re
        m = re.search(r'\[rip ([+-]) 0x([0-9a-f]+)\]', ins.op_str)
        if m:
            t = ins.address + ins.size + (int(m.group(2), 16) * (1 if m.group(1) == '+' else -1))
            q, n = raw(t)
            note = 'rva=%x' % t
            if n == '.rdata' and q is not None:
                note += ' f=%.7g' % struct.unpack_from('<f', b, q)[0]
                d = struct.unpack_from('<d', b, q)[0]
                if 1e-6 < abs(d) < 1e7: note += ' d=%.10g' % d
    print('%08x %-8s %-50s %s' % (ins.address, ins.mnemonic, ins.op_str, ('; ' + note) if note else ''))
