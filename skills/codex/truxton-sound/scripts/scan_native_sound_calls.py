"""List hard-coded sound ids in the original native code (read-only disassembly).

Most gameplay sounds are not in serialized data: e.g. the player's death, item pickups, bombs
and the enemy hit tick are passed as constants to TXEKernel.Sound.SoundUtility.PlaySE & co.
This walks every game method (InGame.*, TXEKernel.*, OutGame.*), tracks the last constant put
in ecx/edx/r8d/r9d, and records it at each call to a sound entry point. Ids are resolved with
sound-ids.json from recover_sound_wiring.py.

  python scan_native_sound_calls.py --root "D:/games/Truxton Extreme"
Writes extractor/sound-source/native-sound-calls.json.
"""
import argparse, json, sys
from collections import defaultdict
from pathlib import Path

import capstone

TARGET_PREFIXES = ('TXEKernel.Sound.SoundUtility.Play', 'KANAI.Sound.SoundManager.Play',
                   'InGame.Kernel.Effect.InGameEffect.SetSoundID', 'InGame.Kernel.Effect.InGameEffect.SetCallSoundID',
                   'InGame.Kernel.Enemy.PawnEnemy.SetOverplayDeadSound', 'InGame.Kernel.InGameEffectManager.GetEffectSound',
                   'InGame.Kernel.Enemy.LaserSoundRequestData.SetSoundID', 'InGame.Kernel.Enemy.EnemyLaserCollision.SetSoundId',
                   'TXEKernel.Sound.SoundUtility.StopCh', 'TXEKernel.Sound.SoundUtility.EntryQue')
CALLER_PREFIXES = ('InGame.', 'TXEKernel.', 'OutGame.', 'KANAI.')
REG32 = {'ecx': 0, 'rcx': 0, 'edx': 1, 'rdx': 1, 'r8d': 2, 'r8': 2, 'r9d': 3, 'r9': 3}


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--root', default='D:/games/Truxton Extreme')
    ap.add_argument('--out', default='extractor/sound-source/native-sound-calls.json')
    a = ap.parse_args()
    root = Path(a.root)
    sys.path.insert(0, str(root/'extractor'))
    import analyze_player_native as n  # builds lookup: address -> method names
    ids = json.loads((root/'extractor/sound-source/sound-ids.json').read_text(encoding='utf-8'))
    se, bgm = ids['ID'], ids['BGM']
    targets = {addr: names[0] for addr, names in n.lookup.items() if any(x.startswith(TARGET_PREFIXES) for x in names)}
    addrs = sorted(n.lookup)
    md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
    calls = []
    for i, addr in enumerate(addrs):
        names = n.lookup[addr]
        if not any(x.startswith(CALLER_PREFIXES) for x in names):
            continue
        end = addrs[i+1] if i+1 < len(addrs) else addr+0x4000
        start = n.raw(addr)
        regs = [None]*4
        for ins in md.disasm(n.binary[start:start+min(end-addr, 0x8000)], addr):
            ops = ins.op_str.split(', ')
            if ins.mnemonic in ('call', 'jmp'):
                try:
                    tgt = int(ins.op_str, 16)
                except ValueError:
                    tgt = None
                if tgt in targets:
                    calls.append(dict(caller=names, rva=hex(ins.address-n.base), target=targets[tgt],
                                      args=list(regs), tail=ins.mnemonic == 'jmp'))
                if ins.mnemonic == 'call':
                    regs = [None]*4
                continue
            if len(ops) == 2 and ops[0] in REG32:
                r = REG32[ops[0]]
                if ins.mnemonic == 'mov':
                    try: regs[r] = int(ops[1], 16) if ops[1].startswith('0x') else int(ops[1])
                    except ValueError: regs[r] = None
                elif ins.mnemonic == 'xor' and ops[0] == ops[1]:
                    regs[r] = 0
                elif ins.mnemonic == 'or' and ops[1] in ('0xffffffff', '-1'):
                    regs[r] = -1
                else:
                    regs[r] = None
    for c in calls:
        c['resolved'] = {}
        for k, v in enumerate(c['args']):
            if v is None: continue
            if v > 0x7fffffff: v -= 1 << 32
            c['args'][k] = v
            table = bgm if 'BGM' in c['target'] else se
            if str(v) in table and v >= 0:
                c['resolved'][f'arg{k}'] = table[str(v)]
    by_caller = defaultdict(list)
    for c in calls:
        by_caller[c['caller'][0]].append(dict(target=c['target'].split('.')[-1], args=c['args'], resolved=c['resolved'], rva=c['rva']))
    out = root/a.out
    out.write_text(json.dumps(dict(calls=len(calls), byCaller=by_caller), indent=1), encoding='utf-8')
    print(len(calls), 'calls in', len(by_caller), 'methods ->', out)


if __name__ == '__main__':
    main()
