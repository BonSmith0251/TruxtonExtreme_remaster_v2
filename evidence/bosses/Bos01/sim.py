# Derived timeline (NOT original code): frame-stepped re-implementation of Ene_Bos01.StateExec (0x1d7b330),
# PatternMove1/2/6, WingAttackPatternLogic and the inlined CoreAttackPatternLogic, to give an implementer
# reference times. Assumptions [I]: 60 fps, spawn localPosition z=200 (ene_boss01 position), PT1 entered on the
# first frame (mover _isFinishDelay true at once), no damage taken, every shoulder cannon alive.
# usage: C:/Python311/python.exe -I sim.py   (reads wing_patterns.json, writes sim_timeline.txt)
import math, json

dt = 1 / 60
HOME = (0, 0, 40); RUSH = (0, 0, -30); K = 8.0; C = 5.6
pos = [0, 0, 200.0]; vel = [0, 0, 0.0]; tgt = list(pos); phys = False; spring = 1.0
state = 1; mode = 0; localT = 0; t1 = 0; offs = 0; wait = 0; pt1wait = 5.0; entry = True
wingOpen = False; arc = 0.0; cannonBits = 0xff; orderBits = 0xff; wingLaser = 0x1ff800
rate = [1.0] * 8
patterns = json.load(open('wing_patterns.json'))
allp = [p['items'] for p in patterns if p['field'] in ('_pattern1', '_pattern2', '_pattern3')]
W = dict(state=1, idx=0, tl=0, last=-1, wait=0, done=False, left=True); active = []
core = dict(mode=0, wait=10, n=0)
alive = None; T = 0.0; log = []
SN = ['EntryWait', 'PT1', 'PT2', 'PT6', 'Destruction']
SH = ['L4', 'L3', 'L2', 'L1', 'R4', 'R3', 'R2', 'R1']
WN = ['WL5', 'WL4', 'WL3', 'WL2', 'WL1', 'WR5', 'WR4', 'WR3', 'WR2', 'WR1']


def ev(s): log.append('%7.2f  %s' % (T, s))


def setstate(s):
    global state, mode, spring
    if state != s:
        state = s; mode = 0; spring = 1.0; ev('-> state %s' % SN[s])


def fire(bits, param, bt, src):
    names = []
    for i, n in enumerate(SH):
        if bits >> i & 1: names.append(n + ('(laser %s)' % bt if rate[i] >= 1 else '(bos01bullet01)'))
    for i in range(10):
        b = 1 << (i + 11)
        if bits & b: names.append(WN[i] + ('(laser %s)' % bt if wingLaser & b else '(bos01bullet01)'))
    if bits & 0x100: names.append('BodyL(%s)' % bt)
    if bits & 0x200: names.append('BodyR(%s)' % bt)
    if bits & 0x400: names.append('Core(%s)' % ('bos01bullet11' if param else 'bos01bullet10'))
    ev('FIRE %s: %s' % (src, ' '.join(names)))


ev('-> state PT1')
frame = 0
while T < 130:
    T += dt; frame += 1
    if alive is not None: alive += dt
    # wings (StateExec head)
    if wingOpen:
        moving_w = arc < 1; arc = min(1, max(0, arc + dt * 0.5))
    else:
        moving_w = arc > 0; arc = min(1, max(0, arc - dt))
    # UpdateVelocityMovement
    body = False
    if phys:
        rem = dt
        while rem > 0:
            h = min(rem, 0.05); d = [tgt[i] - pos[i] for i in range(3)]
            if not body: body = sum(v * v for v in vel) > 0.01 or sum(x * x for x in d) > 0.01
            k = K * spring; c = C * spring
            vel = [vel[i] + (d[i] * k - vel[i] * c) * h for i in range(3)]
            pos = [pos[i] + vel[i] * h for i in range(3)]
            rem -= h
    # cannon roll loop
    rot = cannonBits != orderBits
    if rot:
        for i in range(8):
            b = 1 << i
            if (cannonBits & b) != (orderBits & b):
                las = bool(orderBits & b); mv = (rate[i] < 1) if las else (rate[i] > 0)
                rate[i] = min(1, max(0, rate[i] + (dt if las else -dt)))
                if not mv: cannonBits = (cannonBits | b) if las else (cannonBits & ~b)
    if wait > 0: wait -= dt
    if state == 1:
        if mode == 0:
            localT = 0; t1 = 0; offs = 1.5 * math.pi - math.fmod(3.0, 2 * math.pi)
            if wingOpen: ev('SE bg1_boss_wing_close_01 (107)')
            wingOpen = False; mode = 1
        localT += dt; t1 += dt; bl = min(1, max(0, localT / 1.5))
        hov = math.sin(2 * t1 + offs) * 5; tgt = [RUSH[0], RUSH[1], RUSH[2] + hov * bl]; phys = True
        if localT >= pt1wait:
            if entry:
                entry = False; alive = 0; ev('entry over: OffLockon|NoDamaged cleared, ResetBossTimer(true)')
            setstate(2)
    elif state == 2:
        if mode < 11:
            t1 += dt; tgt = [RUSH[0], RUSH[1], RUSH[2] + 5 * math.sin(2 * t1 + offs)]
        if mode == 0:
            wingOpen = False; orderBits = 0xff
            if not moving_w: mode = 10
        elif mode == 10:
            if not rot:
                sv = wingLaser; wingLaser |= 0x1ff800
                fire(0x1ffb00, 0, 'bos01laser02', 'PT2'); wingLaser = sv; wait = 1.0; mode = 11
        elif mode == 11:
            if wait <= 0:
                if not wingOpen: ev('SE bg1_boss_wing_open_01 (105); target=home, spring scale 0.4')
                wait = 0.1; tgt = list(HOME); spring = 0.4; mode = 12
        elif mode == 12:
            if wait <= 0: wingOpen = True; mode = 13
        elif mode == 13:
            if math.dist(pos, HOME) < 0.5: localT = 0; mode = 14; ev('home reached (|d|<0.5)')
        elif mode == 14:
            localT += dt
            if localT >= 1.5: setstate(3)
    elif state == 3:
        if mode == 0:
            W.update(state=1, idx=0, tl=0, last=-1, wait=0, done=False); active.clear(); wingLaser |= 0x1ff800
            core.update(mode=0, wait=10, n=0); t1 = 0; offs = 0; tgt = list(HOME); vel = [0, 0, 0]; phys = True; mode = 1
        t1 += dt; tgt = [0, 0, 40 + 5 * math.sin(2 * t1)]; phys = True
        # WingAttackPatternLogic.Update -> ProcessActiveAttacks
        for a in list(reversed(active)):
            if not a['rt']:
                if a['c'] & 0xff == 0:
                    wb = a['c'] & 0x1ff800
                    if wb: wingLaser = (wingLaser | wb) if a['las'] else (wingLaser & ~wb)
                elif bool(cannonBits & a['c']) != a['las']:
                    orderBits = (orderBits | a['c']) if a['las'] else (orderBits & ~a['c'])
                a['rt'] = True
            a['w'] -= dt
            if a['w'] <= 0:
                if a['c'] & 0xff and bool(cannonBits & a['c']) != a['las']: continue
                if a['c'] & 0x300 == 0: fire(a['c'], 0, 'bos01laser01', 'wing pattern')
                else: ev('FIRE wing pattern: %s(%s)' % ('BodyL' if a['c'] == 0x100 else 'BodyR', 'bos01laser01' if a['las'] else 'bos01bullet01'))
                active.remove(a)
        if W['state'] == 0:
            W['wait'] -= dt
            if W['wait'] <= 0:
                W['idx'] = (W['idx'] + 1) % 3; W.update(state=1, tl=0, last=-1)
        elif W['state'] == 1:
            W['tl'] += dt; p = allp[W['idx']]
            for i in range(W['last'] + 1, len(p)):
                if W['tl'] >= p[i]['Time']:
                    if W['last'] == -1:
                        ev('wing pattern %d starts' % (W['idx'] + 1))
                        if alive is not None and alive < 60:
                            ev('CallAsteroids %s set' % ('LEFT (ene_asteroid_bs_l_l,m_l,s_l)' if W['left'] else 'RIGHT (ene_asteroid_bs_l_r,m_r,s_r)'))
                            W['left'] = not W['left']
                    m = p[i]['Cannon']
                    while m:
                        lb = m & -m; active.append(dict(c=lb, las=p[i]['IsLaser'], w=1.0, rt=False)); m &= m - 1
                    W['last'] = i
            if W['last'] >= len(p) - 1 and not active:
                if W['idx'] < 2: W.update(wait=5.0, state=0)
                else: W.update(state=2, wait=3.0); ev('wing cycle: Resetting 3 s')
        elif W['state'] == 2:
            W['wait'] -= dt
            if W['wait'] <= 0:
                orderBits = 0xff; wingLaser |= 0x1ff800; W.update(done=True, state=0, wait=10.0)
        if W['done']:
            W['done'] = False; pt1wait = 2.0; setstate(1); continue
        # CoreAttackPatternLogic (inlined in PatternMove6)
        if core['wait'] > 0: core['wait'] -= dt
        if core['mode'] == 0:
            if core['wait'] <= 0: core['mode'] = 1
        elif core['mode'] == 1: core.update(mode=2, wait=0, n=0)
        elif core['mode'] == 2:
            if core['wait'] <= 0:
                if core['n'] >= 8: core['wait'] += 10; core['mode'] = 3
                else: fire(0x400, core['n'] % 2, '', 'core'); core['wait'] += 0.5; core['n'] += 1
        elif core['mode'] == 3:
            if core['wait'] <= 0: core['mode'] = 1
    if frame % 30 == 0 and T < 16: log.append('%7.2f    pos z=%.1f' % (T, pos[2]))
open('sim_timeline.txt', 'w').write('# derived by sim.py (not original code); times in s since PT1 start\n' + '\n'.join(log) + '\n')
print('\n'.join(log))
