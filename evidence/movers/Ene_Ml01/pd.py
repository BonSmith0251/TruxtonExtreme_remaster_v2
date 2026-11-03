# Wrapper over ../tools/pdis.py for Ml01/Mk01: no mover-field annotation (this = pawn), plus jump-table resolver.
# usage: python -I pd.py <Class> <RVAhex> <ENDhex>
import sys, re, struct
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\movers\tools')
import pdis, il2
_inst = pdis.inst
pdis.inst = lambda c: {} if c == 'EnemyMover' else _inst(c)
def tables(text):
    out = []
    for m in re.finditer(r'mov\s+\w+, dword ptr \[r(\w+) \+ r\w+\*4 \+ 0x([0-9a-f]+)\]', text):
        t = int(m.group(2), 16); ent = []
        for i in range(64):
            v = struct.unpack('<i', il2.rd(t + 4 * i, 4))[0]
            if not (0x1000000 < v < 0x3000000): break
            ent.append(v)
        out.append('table %x: ' % t + ' '.join('%d->%x' % (i, v) for i, v in enumerate(ent)))
    return out
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    cls, a, b = sys.argv[1], int(sys.argv[2], 16), int(sys.argv[3], 16)
    t = pdis.dis(cls, a, b - a); print(t); print('\n'.join(tables(t)))
