# Read-only annotated disassembly for the EnemyMover / route-event study (GameAssembly.dll, IL2CPP x64).
# Reuses evidence/bosses/Bos08/tools/{il2,fields}.py (PE mapping, metadata usages, DiffableCs field offsets).
# usage: C:\Python311\python.exe -I rdis.py <TypeSubstring> <methodSubstring | RVAhex lenhex> [--sm StateMachineName]
#   instance-field annotation uses the mover hierarchy (this) and RouteEvent (ev.) offsets; with --sm the
#   state-machine struct fields (sm.) are added.
import sys, struct, json, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2, fields
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from capstone.x86 import X86_OP_MEM, X86_OP_REG, X86_REG_RIP
md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
HIER = ['InGameObjectBase', 'InGameObject', 'InGameObjectWithEvent', 'InGameEnemyMoveBase', 'SplineMover', 'EnemyMover',
        'EnemyMoverGround', 'EnemyMoverTurrets']
def cls_fields(c, nested=''):
    out = {}
    for k, v in fields.fields(c).items():
        if k.split('/')[-1] != (nested or c): continue
        for s, o, t, n in v:
            if not s: out[o] = n
    return out
EV = cls_fields('RouteEvent')
def sm_fields(outer, name):
    # own nested-type parser (fields.py drops names that start with '<')
    for p in fields.index().get(outer, []):
        stack = []; depth = 0; pending = None; out = {}
        for line in p.read_text(encoding='utf-8', errors='replace').splitlines():
            m = re.search(r'(?:^|\s)(class|struct|enum|interface)\s+(\S+)', line)
            if m and not line.strip().startswith('['): pending = m.group(2)
            for ch in line:
                if ch == '{':
                    depth += 1
                    if pending: stack.append((pending, depth)); pending = None
                elif ch == '}':
                    if stack and stack[-1][1] == depth: stack.pop()
                    depth -= 1
            fm = re.search(r'\s(\S+);\s*//Field offset: (0x[0-9A-Fa-f]+)', line)
            if fm and stack and (len(stack) == 1 and stack[0][0] == name if name == outer else name in stack[-1][0]) and ' static ' not in line:
                out[int(fm.group(2), 16)] = fm.group(1)
        if out: return out
    return {}
THIS = {}
for c in HIER: THIS.update({o: n for o, n in sm_fields(c, c).items() if o >= 0x30})
def dis(rva, n, SM=None):
    data = il2.rd(rva, n); lines = []
    for ins in md.disasm(data, rva):
        out = []
        if ins.mnemonic in ('call', 'jmp') and ins.op_str.startswith('0x'):
            t = int(ins.op_str, 16); nm = il2.MNAME.get(t)
            if nm: out.append(' | '.join(nm[:2]))
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
                    out.append('[%x] %s' % (t, u or ('=%x' % v if v else 'bss')))
            elif op.mem.index == 0:
                disp = op.mem.disp; cand = []
                if SM and disp in SM: cand.append('sm.'+SM[disp])
                if disp in EV and disp >= 0x10: cand.append('ev.'+EV[disp])
                if disp in THIS: cand.append('.'+THIS[disp])
                if cand: out.append('/'.join(cand))
        lines.append('%08x  %-8s %s%s' % (ins.address, ins.mnemonic, ins.op_str, ('   ; '+' ; '.join(out)) if out else ''))
    return '\n'.join(lines)
def find(typ, key):
    res = []
    for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
        m = json.loads(line)
        if typ not in m['type']: continue
        a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
        if not a or not a[0]['fields'].get('RVA'): continue
        sig = m['signature'].split('::')[-1]
        if key in sig: res.append((int(a[0]['fields']['RVA'], 16), int(a[0]['fields']['Length'], 16), m['type'], sig))
    return res
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    args = sys.argv[1:]; SM = None
    if '--sm' in args:
        i = args.index('--sm'); outer, name = args[i+1].split(':'); SM = sm_fields(outer, name); del args[i:i+2]
    typ, key = args[0], args[1]
    if re.fullmatch(r'(0x)?[0-9A-Fa-f]{6,}', key):
        print(dis(int(key, 16), int(args[2], 16), SM))
    else:
        for r, n, t, sig in find(typ, key):
            print('#### %s::%s RVA %x len %x' % (t, sig, r, n)); print(dis(r, n, SM))
