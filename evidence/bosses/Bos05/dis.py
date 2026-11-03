"""Annotated disassembly of IL2CPP methods in GameAssembly.dll (read-only evidence tool for the Bos05 spec).

usage: C:\\Python311\\python.exe -I dis.py <out.txt> <TypeSubstring|0xRVA> [...]
Annotates: direct call targets (methods.jsonl), RIP-relative .rdata constants (float32/double/4xfloat),
.data metadata-usage slots (TypeInfo / Il2CppType / MethodDef / FieldInfo / StringLiteral / MethodRef) decoded
from global-metadata.dat + the metadata registration (Cpp2IL: metareg VA 0x183DB4460), and field offsets of
Ene_Bos05 / Ene_BosBase / PawnEnemy / Ene_Bos05_Arm (instance) and Ene_Bos05 / Arm statics.
"""
import json, struct, sys, re, collections
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_REG_RIP

GAME = r'D:\games\Truxton Extreme'
CODE = r'D:\games\TruxtonExRecon\code'
DIFF = CODE + r'\type-model-source\DiffableCs\InGame.Kernel\InGame\Kernel\Enemy'
b = open(GAME + r'\GameAssembly.dll', 'rb').read()
mb = open(GAME + r'\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat', 'rb').read()
BASE = 0x180000000
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe + 6)[0]
osz = struct.unpack_from('<H', b, pe + 20)[0]; opt = pe + 24
sect = []
for i in range(ns):
    off = opt + osz + i * 40; name = b[off:off + 8].rstrip(b'\0').decode()
    vs, va, sz, ptr = struct.unpack_from('<4I', b, off + 8); sect.append((name, va, max(vs, sz), ptr, sz))
def raw(rva):
    for n, va, sz, p, rs in sect:
        if va <= rva < va + sz:
            return p + rva - va if rva - va < rs else None
    return None
def secname(rva):
    for n, va, sz, p, rs in sect:
        if va <= rva < va + sz: return n
    return '?'

# metadata header triplets (offset,size,count)
H = struct.unpack_from('<99i', mb, 8)
sec = lambda k: (H[3 * k], H[3 * k + 1], H[3 * k + 2])
LIT, LITD, STR, METH, TDEF, FREF = sec(0), sec(1), sec(2), sec(5), sec(19), sec(25)
FIELDS = sec(11)
loffs = [struct.unpack_from('<2i', mb, LIT[0] + 8 * i) for i in range(LIT[2])] if False else None
def lit(i):
    # v39 string literal: (length,dataIndex)? detect: entries are 4 bytes -> dataIndex only
    o = struct.unpack_from('<i', mb, LIT[0] + 4 * i)[0]
    e = struct.unpack_from('<i', mb, LIT[0] + 4 * (i + 1))[0] if i + 1 < LIT[2] else LITD[1]
    return mb[LITD[0] + o:LITD[0] + e].decode('utf-8', 'replace')
def sstr(i):
    o = STR[0] + i; e = mb.index(b'\0', o); return mb[o:e].decode('utf-8', 'replace')
def tdname(k):
    o = TDEF[0] + 82 * k; n, nsp = struct.unpack_from('<2i', mb, o)
    decl = None
    return (sstr(nsp) + '.' if sstr(nsp) else '') + sstr(n)
def methdef(k):
    o = METH[0] + 32 * k; v = struct.unpack_from('<6i4H', mb, o)
    return dict(name=sstr(v[0]), decl=v[1], token=v[5], flags=v[6], slot=v[8])
# metadata registration
mr = raw(0x3DB4460 - 0) if False else raw(0x183DB4460 - BASE)
MR = struct.unpack_from('<16Q', b, mr)
TYPES_CNT, TYPES = MR[6], MR[7]
SPEC_CNT, SPECS = MR[8], MR[9]
def il2type(i):
    p = struct.unpack_from('<Q', b, raw(TYPES - BASE) + 8 * i)[0]
    data, bits = struct.unpack_from('<QI', b, raw(p - BASE))
    t = (bits >> 16) & 0xff
    if t in (0x11, 0x12): return tdname(data)
    prim = {1: 'void', 2: 'bool', 3: 'char', 4: 'sbyte', 5: 'byte', 6: 'short', 7: 'ushort', 8: 'int', 9: 'uint', 0xa: 'long',
            0xb: 'ulong', 0xc: 'float', 0xd: 'double', 0xe: 'string', 0x1c: 'object'}
    if t in prim: return prim[t]
    if t == 0x1d: return 'SZARRAY'
    if t == 0x15: return 'GENERICINST'
    return 'type%x' % t
def fieldref(i):
    ti, fi = struct.unpack_from('<2i', mb, FREF[0] + 8 * i)
    return il2type(ti), fi
def methodspec(i):
    md, ci, mi = struct.unpack_from('<3i', b, raw(SPECS - BASE) + 12 * i)
    m = methdef(md); return tdname(m['decl']) + '::' + m['name'] + '<spec>'
def usage(v):
    if not (v & 1): return None
    kind = (v >> 29) & 7; idx = (v & 0x1fffffff) >> 1
    try:
        if kind == 1: return 'TypeInfo ' + il2type(idx)
        if kind == 2: return 'Il2CppType ' + il2type(idx)
        if kind == 3:
            m = methdef(idx); return 'MethodDef ' + tdname(m['decl']) + '::' + m['name']
        if kind == 4:
            t, f = fieldref(idx); return 'FieldInfo %s field#%d' % (t, f)
        if kind == 5: return 'String "%s"' % lit(idx)
        if kind == 6: return 'MethodRef ' + methodspec(idx)
    except Exception as e:
        return 'usage%d idx%d (%s)' % (kind, idx, e)
    return None

# methods by RVA
addr = collections.defaultdict(list); bytype = collections.defaultdict(list)
for line in open(CODE + r'\methods.jsonl', encoding='utf-8-sig'):
    m = json.loads(line)
    a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
    if not a or not a[0].get('fields', {}).get('RVA'): continue
    f = a[0]['fields']; rva = int(f['RVA'], 16); ln = int(f['Length'], 16)
    t = m['type']; sig = m['signature']
    short = re.sub(r'^\S+ ', '', sig); short = short.replace('InGame.Kernel.Enemy.', '').replace('System.', '').replace('UnityEngine.', '')
    addr[rva].append(short)
    bytype[t].append((rva, ln, sig))

# field offset tables from DiffableCs
def fields(fn):
    d = {}; st = {}
    cur = None
    for line in open(DIFF + '\\' + fn, encoding='utf-8-sig'):
        m = re.search(r'\s(static\s+)?(?:readonly\s+)?(?:const\s+)?[\w\.<>\[\],` ]+?\s(\S+); //Field offset: (0x[0-9A-F]+)', line)
        if m and '\t\t\t' not in line[:3] and line.startswith('\t') and not line.startswith('\t\t'):
            off = int(m.group(3), 16)
            (st if m.group(1) or ' static ' in line else d)[off] = m.group(2)
    return d, st
inst = {}; stat = {}
for fn in ['PawnEnemy.cs', 'Ene_BosBase.cs', 'Ene_Bos05.cs']:
    d, s = fields(fn); inst.update(d)
    if fn == 'Ene_Bos05.cs': stat.update(s)
arm_i, arm_s = fields('Ene_Bos05_Arm.cs')

import os, glob
_files = {}
for p in glob.glob(os.path.join(CODE, 'type-model-source', 'DiffableCs', '**', '*.cs'), recursive=True):
    _files.setdefault(os.path.basename(p)[:-3], p)
_ftab = {}
FTYPE = {}
def ftype(cls, off):
    cls = cls.split('.')[-1]
    while cls:
        if (cls, off) in FTYPE: return FTYPE[(cls, off)]
        cls = BASES.get(cls)
    return None
BASES = {}
def ftab(cls):
    cls = cls.split('.')[-1]
    if cls in _ftab: return _ftab[cls]
    inst, st = {}, {}
    p = _files.get(cls)
    if p:
        for line in open(p, encoding='utf-8-sig'):
            if not line.startswith('	') or line.startswith('		'): continue
            m = re.search(r'\s(\S+); //Field offset: (0x[0-9A-F]+)', line)
            if m:
                (st if ' static ' in line else inst)[int(m.group(2), 16)] = m.group(1)
                mt = re.search(r'(\S+)\s+' + re.escape(m.group(1)) + ';', line)
                if mt and ' static ' not in line: FTYPE[(cls, int(m.group(2), 16))] = mt.group(1)
        # base class chain
        txt = open(p, encoding='utf-8-sig').read()
        mm = re.search(r'class ' + re.escape(cls) + r'\s*:\s*([\w\.]+)', txt)
        if mm: BASES[cls] = mm.group(1).split('.')[-1]
        if mm and mm.group(1) not in ('MonoBehaviour', 'Object', 'ScriptableObject'):
            bi, _ = ftab(mm.group(1)); bi = dict(bi); bi.update(inst); inst = bi
    _ftab[cls] = (inst, st)
    return _ftab[cls]
R64 = {}
for r in ['ax','bx','cx','dx','si','di','bp','sp']:
    for v in ('r'+r, 'e'+r, r): R64[v] = 'r'+r
R64.update({'al':'rax','bl':'rbx','cl':'rcx','dl':'rdx','sil':'rsi','dil':'rdi'})
for i in range(8, 16):
    for v in ('r%d' % i, 'r%dd' % i, 'r%dw' % i, 'r%db' % i): R64[v] = 'r%d' % i
HIER = set()
for c in ['Ene_Bos05', 'Ene_BosBase', 'PawnEnemy', 'InGameCollisionBase', 'InGameObject', 'Ene_Bos05_Arm']:
    p = _files.get(c)
    if p:
        for line in open(p, encoding='utf-8-sig'):
            m = re.search(r'(?:virtual|override|abstract)[^(]*?\s(\w+)\(', line)
            if m: HIER.add(m.group(1))
SLOTS = collections.defaultdict(set)
for k in range(METH[2]):
    o = METH[0] + 32 * k
    sl = struct.unpack_from('<H', mb, o + 28)[0]
    if sl == 0xffff: continue
    try: nm = sstr(struct.unpack_from('<i', mb, o)[0])
    except Exception: continue
    if nm in HIER: SLOTS[sl].add(nm)
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
VOL = ['rax','rcx','rdx','r8','r9','r10','r11']
def dis(rva, ln, title, ctx):
    cls = 'Ene_Bos05_Arm' if ctx == 'arm' else ('<>c__DisplayClass123_0' if 'DisplayClass' in title else 'Ene_Bos05')
    ofs = raw(rva); data = b[ofs:ofs + ln]; out = ['== %s  RVA 0x%X len 0x%X' % (title, rva, ln)]
    regs = {'rcx': ('this', cls)}
    if 'DisplayClass' in title: regs = {'rcx': ('this', 'DC'), 'rdx': ('arg', 'InGameBulletInterface')}
    for ins in md.disasm(data, rva):
        ann = []
        if ins.mnemonic.startswith('call') or ins.mnemonic.startswith('j'):
            if ins.op_str.startswith('0x'):
                t = int(ins.op_str, 16)
                if t in addr: ann.append(' || '.join(addr[t][:3]))
        newlab = None
        for op in ins.operands:
            if op.type == X86_OP_MEM:
                if op.mem.base == X86_REG_RIP:
                    tgt = ins.address + ins.size + op.mem.disp
                    sn = secname(tgt); r = raw(tgt)
                    if sn == '.rdata' and r is not None:
                        f = struct.unpack_from('<f', b, r)[0]; dd = struct.unpack_from('<d', b, r)[0]
                        f4 = struct.unpack_from('<4f', b, r)
                        if ins.mnemonic in ('movaps', 'movups', 'movdqa', 'movdqu', 'andps', 'xorps', 'andnps', 'orps', 'mulps', 'addps', 'subps'):
                            ann.append('rdata[%X] 4f=%s' % (tgt, ','.join('%g' % x for x in f4)))
                        elif ins.mnemonic.endswith('sd') or ins.mnemonic in ('cvtsd2ss','movsd','andpd','xorpd'):
                            ann.append('rdata[%X] d=%r' % (tgt, dd))
                        else:
                            ann.append('rdata[%X] f=%r' % (tgt, f))
                    elif sn == '.data' and r is not None:
                        v = struct.unpack_from('<Q', b, r)[0]; u = usage(v)
                        ann.append('data[%X] %s' % (tgt, u if u else hex(v)))
                        if u and u.startswith('TypeInfo ') and ins.mnemonic == 'mov': newlab = ('ti', u[9:])
                    elif sn == '.data':
                        ann.append('bss[%X]' % tgt)
                else:
                    disp = op.mem.disp; base = ins.reg_name(op.mem.base) if op.mem.base else None
                    lab = regs.get(R64.get(base, base)) if base else None
                    if lab is None and base and disp == 0 and ins.mnemonic == 'mov' and op.mem.index == 0 and ins.operands[0].type == 1:
                        newlab = ('vt', '?')
                    if lab is None and op.mem.index == 0 and disp >= 0x1b0 and base not in ('rsp', 'rbp') and disp in ftab(cls)[0]:
                        ann.append('~this.' + ftab(cls)[0][disp])
                    if lab and op.mem.index == 0:
                        if lab[0] == 'this':
                            nm = ftab(lab[1])[0].get(disp) if lab[1] != 'DC' else {0x10: 'isLeftSide'}.get(disp)
                            if nm:
                                ann.append(('this.' if lab[1] == cls else lab[1].split('.')[-1] + '.') + nm)
                                ft = ftype(lab[1], disp)
                                if ft and ft.split('.')[-1] in _files and ins.mnemonic == 'mov' and ins.operands[0].type == 1 and ins.operands[0].size == 8:
                                    newlab = ('this', ft.split('.')[-1])
                            elif disp >= 0x10: ann.append('%s+%X' % (lab[1].split('.')[-1], disp))
                        elif lab[0] == 'st':
                            nm = ftab(lab[1])[1].get(disp)
                            ann.append('%s::%s' % (lab[1].split('.')[-1], nm if nm else hex(disp)))
                        elif lab[0] == 'vt' and disp >= 0x138 and (disp - 0x138) % 16 in (0, 8):
                            sl = (disp - 0x138) // 16
                            ann.append('vslot %d %s%s' % (sl, '/'.join(sorted(SLOTS.get(sl, []))[:6]), ' (methodInfo)' if (disp - 0x138) % 16 else ''))
                        elif lab[0] == 'ti' and disp == 0xb8 and ins.mnemonic == 'mov':
                            newlab = ('st', lab[1])
        # register tracking
        try:
            rd, wr = ins.regs_access()
        except Exception:
            rd, wr = [], []
        wr = [R64.get(ins.reg_name(x), ins.reg_name(x)) for x in wr]
        if newlab and newlab[0] == 'vt' and ins.mnemonic == 'mov' and ins.operands[0].type == 1:
            regs[R64.get(ins.reg_name(ins.operands[0].reg))] = newlab
        elif ins.mnemonic == 'mov' and len(ins.operands) == 2 and ins.operands[1].type == 1 and ins.operands[0].type == 1:
            src = R64.get(ins.reg_name(ins.operands[1].reg)); dst = R64.get(ins.reg_name(ins.operands[0].reg))
            if dst: 
                if src in regs: regs[dst] = regs[src]
                else: regs.pop(dst, None)
        else:
            for w in wr:
                if ins.mnemonic not in ('pop', 'push'): regs.pop(w, None)
            if newlab and ins.operands and ins.operands[0].type == 1:
                regs[R64.get(ins.reg_name(ins.operands[0].reg))] = newlab
        if ins.mnemonic == 'call':
            for v in VOL: regs.pop(v, None)
        if lab_note := ' '.join('%s=%s' % (k, v[0]) for k, v in regs.items() if v[0] == 'this' and False): pass
        out.append('%08x %-8s %s%s' % (ins.address, ins.mnemonic, ins.op_str, ('    ; ' + ' | '.join(ann)) if ann else ''))
    return out

if __name__ == '__main__':
    outp = sys.argv[1]; res = []
    for q in sys.argv[2:]:
        if q.startswith('0x'):
            rva = int(q, 16)
            for t, lst in bytype.items():
                for r, ln, sig in lst:
                    if r == rva:
                        res += dis(r, ln, sig, 'arm' if 'Bos05_Arm' in t else 'bos'); res.append('')
                        break
                else: continue
                break
        else:
            for t, lst in bytype.items():
                if t == q or t.startswith(q + '/'):
                    for r, ln, sig in sorted(lst, key=lambda x: x[2]):
                        res += dis(r, ln, sig, 'arm' if 'Bos05_Arm' in t else 'bos'); res.append('')
    open(outp, 'w', encoding='utf-8').write('\n'.join(res))
    print(outp, len(res))
