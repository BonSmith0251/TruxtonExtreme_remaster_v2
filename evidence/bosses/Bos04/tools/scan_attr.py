import sys; sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos04\tools')
import nat
for sig, (r, l) in nat.methods.items():
    if not any(k in sig for k in ('Collision', 'Hybrid', 'PawnEnemy::', 'Bullet')): continue
    p = nat.raw(r)
    if p is None or l > 0x3000: continue
    for ins in nat.md.disasm(nat.b[p:p+l], r):
        if ('0x100000' in ins.op_str and ins.mnemonic in ('test','and','bt','cmp','or')) or (ins.mnemonic=='bt' and ins.op_str.endswith(', 0x14')):
            print(hex(ins.address), ins.mnemonic, ins.op_str, '|', sig[:150]); break
