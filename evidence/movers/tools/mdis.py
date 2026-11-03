# Annotated disassembly for the air-mover pawn classes (read-only). Wraps evidence/bosses/Bos08/tools/bdis.py with the
# PawnEnemy/RookEnemy hierarchy and static-field lookup in the class that owns the TypeInfo.
# usage: C:\Python311\python.exe -I mdis.py <Class> <methodSubstring | RVAhex lenhex>
import sys, re
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import bdis, fields
HIER = ['HybridCollisions', 'InGameCollisionBase', 'PawnEnemy', 'RookEnemy']
def inst_fields(cls):
    m = {}
    for c in HIER + [cls]:
        for k, v in fields.fields(c).items():
            if k.split('/')[-1] != c.split('/')[-1]: continue
            for s, o, t, n in v:
                if not s and o >= 0x20: m[o] = n
    if cls in ('Ene_Ss01',): pass
    return m
_orig_static = bdis.static_fields
def static_fields(cls):
    out = {}
    import pathlib
    for c in set(list(fields.index().keys())):
        pass
    return _orig_static(cls)
class SF(dict):
    def get(self, cname, default=None):
        d = _orig_static(cname)
        return d.get(cname, {}) or default or {}
bdis.inst_fields = inst_fields
bdis.static_fields = lambda cls: SF()
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    cls = sys.argv[1]; key = sys.argv[2]
    if re.fullmatch(r'(0x)?[0-9A-Fa-f]{6,}', key):
        print(bdis.dis(int(key, 16), int(sys.argv[3], 16), cls))
    else:
        for r, n, t, sig in bdis.find(cls, key):
            print('#### %s::%s RVA %x len %x' % (t, sig, r, n)); print(bdis.dis(r, n, cls.split('/')[0]))
