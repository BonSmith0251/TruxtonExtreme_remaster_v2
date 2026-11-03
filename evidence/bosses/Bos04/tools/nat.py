"""Read-only disassembly helper for Ene_Bos04 (GameAssembly.dll, IL2CPP x64, metadata v39)."""
import json, struct, pathlib, collections, sys
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_REG_RIP
GAME = pathlib.Path(r'D:\games\Truxton Extreme')
CODE = pathlib.Path(r'D:\games\TruxtonExRecon\code')
b = (GAME/'GameAssembly.dll').read_bytes()
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe+6)[0]; osz = struct.unpack_from('<H', b, pe+20)[0]
opt = pe+24; base = struct.unpack_from('<Q', b, opt+24)[0]
sect = []
for i in range(ns):
    off = opt+osz+i*40; name = b[off:off+8].rstrip(b'\0').decode(); vs, va, sz, ptr = struct.unpack_from('<4I', b, off+8)
    sect.append((name, va, max(vs, sz), ptr, sz))
def secname(rva):
    for n, va, sz, p, rs in sect:
        if va <= rva < va+sz: return n
def raw(rva):
    for n, va, sz, p, rs in sect:
        if va <= rva < va+sz:
            if rva-va >= rs: return None
            return p+rva-va
    return None
methods = {}
bystart = collections.defaultdict(list)
for line in (CODE/'methods.jsonl').open(encoding='utf-8-sig'):
    m = json.loads(line)
    a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
    if not a: continue
    f = a[0].get('fields', {})
    if not f.get('RVA'): continue
    r = int(f['RVA'], 16); bystart[r].append(m['signature'].split(' ', 1)[-1] if ' ' in m['signature'] else m['signature'])
    methods[m['signature']] = (r, int(f['Length'], 16))
# ---- metadata string literals
meta = (GAME/'TATSUJIN EXTREME_Data'/'il2cpp_data'/'Metadata'/'global-metadata.dat').read_bytes()
lit_off, lit_size, lit_count, dat_off, dat_size, _ = struct.unpack_from('<6i', meta, 8)
offs = struct.unpack_from('<%di' % lit_count, meta, lit_off)
lits = [meta[dat_off+offs[i]:dat_off+(offs[i+1] if i+1 < lit_count else dat_size)].decode('utf-8', 'replace') for i in range(lit_count)]

import re as _re
DCS = CODE/'type-model-source'/'DiffableCs'
def _fields(rel):
    out = {}
    for line in (DCS/rel).read_text(encoding='utf-8-sig').splitlines():
        m = _re.match(r'^	(?:[\w]+ )*?([\w<>\[\]`.,]+) (\S+); //Field offset: (0x[0-9A-F]+)', line)
        if m and ' static ' not in line and 'const ' not in line: out[int(m.group(3), 16)] = m.group(2)
    return out
FIELDS = {}
for rel in ['KANAI.HybridCollision/KANAI/HybridCollision/HybridCollisions.cs', 'InGame.Kernel/InGame/Kernel/InGameCollisionBase.cs',
            'InGame.Kernel/InGame/Kernel/Enemy/PawnEnemy.cs', 'InGame.Kernel/InGame/Kernel/Enemy/Ene_BosBase.cs',
            'InGame.Kernel/InGame/Kernel/Enemy/Ene_Bos04.cs']:
    FIELDS.update({k: v for k, v in _fields(rel).items() if k >= 0x20})
BITF = {0x1b0: '_parent', 0x1b8: '_bulletTemplate'}
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
def q(rva):
    p = raw(rva)
    return None if p is None else struct.unpack_from('<Q', b, p)[0]
def decode_slot(v):
    if v is None: return None
    if v & 1 and v < (1 << 32):
        t = (v & 0xE0000000) >> 29; idx = (v & 0x1FFFFFFE) >> 1
        kinds = {1:'TypeInfo',2:'Il2CppType',3:'MethodDef',4:'FieldInfo',5:'String',6:'MethodRef',7:'FieldRVA'}
        if t == 5 and idx < len(lits): return 'STR "%s"' % lits[idx]
        return '%s#%d' % (kinds.get(t, '?%d' % t), idx)
    return None
def name_of(rva):
    s = bystart.get(rva)
    return ' || '.join(s[:3]) if s else None
def dis(rva, length, out=None):
    data = b[raw(rva):raw(rva)+length]; lines = []
    for ins in md.disasm(data, rva):
        ann = ''
        if ins.mnemonic in ('call', 'jmp') and ins.op_str.startswith('0x'):
            t = int(ins.op_str, 16); n = name_of(t)
            if n: ann = ' ; ' + n
        for op in ins.operands:
            if op.type == X86_OP_MEM and op.mem.base == X86_REG_RIP:
                tgt = ins.address+ins.size+op.mem.disp; sn = secname(tgt)
                p = raw(tgt)
                if sn == '.rdata' and p is not None:
                    f = struct.unpack_from('<f', b, p)[0]; d = struct.unpack_from('<d', b, p)[0]
                    vals = struct.unpack_from('<4f', b, p)
                    ann += ' ; [%s %x] f=%r d=%r v4=%s' % (sn, tgt, f, d, ['%g' % x for x in vals])
                else:
                    v = q(tgt); ds = decode_slot(v)
                    ann += ' ; [%s %x]%s' % (sn, tgt, (' ' + ds) if ds else (' =%x' % v if v is not None else ''))
        if not ann:
            for op in ins.operands:
                if op.type == X86_OP_MEM and op.mem.base != X86_REG_RIP and op.mem.index == 0 and op.mem.disp in FIELDS and op.mem.disp >= 0x88:
                    ann += ' ; ~' + FIELDS[op.mem.disp]
        lines.append('%08x %-10s %s%s' % (ins.address, ins.mnemonic, ins.op_str, ann))
    return lines
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    sig = sys.argv[1]
    hits = [(k, v) for k, v in methods.items() if sig in k]
    for k, (r, l) in hits:
        print('==', k, hex(r), hex(l)); print('\n'.join(dis(r, l)))

def dump_class(prefix, outdir):
    outdir = pathlib.Path(outdir); outdir.mkdir(exist_ok=True)
    for k, (r, l) in sorted(methods.items(), key=lambda kv: kv[1][0]):
        typ = k.split(' ', 1)[-1].split('::')[0]
        if typ == prefix or typ.startswith(prefix + '/'):
            nm = k.split('::', 1)[1].split('(')[0]
            nm = _re.sub(r'[^\w.]+', '_', nm)
            (outdir/('%x_%s_%s.txt' % (r, typ.split('.')[-1].replace('/', '_'), nm)))[:0] if False else None
            path = outdir/('%x_%s_%s.txt' % (r, _re.sub(r'[^\w]+', '_', typ.split('.')[-1]), nm))
            path.write_text('== %s RVA %x len %x\n' % (k, r, l) + '\n'.join(dis(r, l)), encoding='utf-8')
