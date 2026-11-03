# Read-only annotated disassembly for the death-bullet study. Wraps evidence/bosses/Bos08/tools/bdis.py
# (il2.py PE/metadata usages, fields.py offsets) and widens the instance-field hierarchy to bullets/ground enemies.
# usage: C:\Python311\python.exe -I ddis.py <Class> <methodSubstring | RVAhex lenhex>
import sys
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import bdis, fields
HIER = {
 'InGameDestuctible': ['HybridCollisions', 'InGameCollisionBase', 'InGameBullet', 'InGameDestuctible'],
 'InGameBullet': ['HybridCollisions', 'InGameCollisionBase', 'InGameBullet'],
 'Ene_bg05tree': ['HybridCollisions', 'InGameCollisionBase', 'PawnEnemy', 'PawnEnemyGround', 'Ene_bg05tree'],
 'PawnEnemyGround': ['HybridCollisions', 'InGameCollisionBase', 'PawnEnemy', 'PawnEnemyGround'],
}
def inst_fields(cls):
    m = {}
    for c in HIER.get(cls, ['HybridCollisions', 'InGameCollisionBase', 'PawnEnemy', 'Ene_BosBase', cls]):
        for k, v in fields.fields(c).items():
            if k.split('/')[-1] != c.split('/')[-1]: continue
            for s, o, t, n in v:
                if not s and o >= 0x20: m[o] = n
    return m
bdis.inst_fields = inst_fields
if __name__ == '__main__':
    import re
    cls = sys.argv[1]; key = sys.argv[2]
    if re.fullmatch(r'[0-9A-Fa-f]{6,}', key):
        print(bdis.dis(int(key, 16), int(sys.argv[3], 16), cls))
    else:
        for r, n, t, sig in bdis.find(cls, key):
            print('#### %s::%s RVA %x len %x' % (t, sig, r, n)); print(bdis.dis(r, n, cls.split('/')[0]))
