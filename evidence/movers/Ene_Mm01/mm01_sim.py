# Frame-stepped model of Ene_Mm01._StateExec (RVA 0x1DCDE30) for one spawn. Read-only study tool.
# usage: C:\Python311\python.exe -I mm01_sim.py <behavior 0..5> [--player x,z] [--speed 35] [--off x,y,z] [--every 15]
#   behavior = clip spawn index (_indexValue): 0 Horizon, 1 Vertical, 2 Up, 3 Down, 4 Left, 5 Right
# Sky plane: x right, z up, y toward camera. Player is held fixed. 60 fps, float32 not emulated (+-1 frame).
import sys, math
DT = 1 / 60
# statics (.cctor 0x1DCF830)
InTime, InWait, SafeTime, CloseSECall, CloseTime, WaitTime, OutTime, PostWait = 1.0, 1.0, 0.6, 0.9, 1.0, 0.5, 1.5, 0.5
AwaySpeed, InSpin, OutSpin, SoloAway = 60.0, 2.0, 2.0, 1.0
DefaultPosition = [(0, 0, 200), (0, 0, 200), (0, 0, 120), (0, 0, -120), (-180, 0, 0), (180, 0, 0)]
# instance (ctor 0x1DCFDD0 / prefab Pf_Ene_Mm01)
inWidthH, outWidthH, inWidthV, outWidthV, offsetZ = 160.0, 115.0, 120.0, 65.0, 0.0
def hermite(k0, k1, t):                       # Unity AnimationCurve, weightedMode 0 (non-weighted Hermite)
    (t0, v0, o0), (t1, v1, i1) = k0, k1
    d = t1 - t0; s = min(max((t - t0) / d, 0), 1)
    h00 = 2*s**3 - 3*s**2 + 1; h10 = s**3 - 2*s**2 + s; h01 = -2*s**3 + 3*s**2; h11 = s**3 - s**2
    return h00*v0 + h10*o0*d + h01*v1 + h11*i1*d
curveIn = lambda t: hermite((0, 1, -0.7560472), (1, 0, -1.7989875), t)
curveOut = lambda t: hermite((0, 0, 1.0051994), (1, 1, 0.4387774), t)
GAME = (-163.0, 163.0, -91.7, 91.7)           # gameScreenArea at y=0 (Small) [?] for IsGamePlayArea
def inside(p): return GAME[0] <= p[0] < GAME[1] and GAME[2] <= p[1] < GAME[3]
def main():
    a = sys.argv[1:]; beh = int(a[0]); o = {a[i][2:]: a[i+1] for i in range(1, len(a) - 1, 2)}
    px, pz = (float(v) for v in o.get('player', '0,-49').split(','))
    speed = float(o.get('speed', 35)); off = [float(v) for v in o.get('off', '0,0,0').split(',')]
    every = int(o.get('every', 15))
    start_offset = (off[0], 0.0, off[2]); laser_len = off[1]           # ReStart: _startOffset (y=0), _laserLength = y
    root = list(DefaultPosition[min(max(beh, 0), 5)])                 # ReStart parks the root here
    state, passed, tpos, org, velz, md, rot90 = 0, 0.0, 0.0, [0, 0, 0], 0, (0, 0, 0), False
    t = 0.0; rows = []; log = []
    def halves():                                                     # world (x,z) of right / left half
        if 15 <= state <= 18: h = laser_len * 0.5; r, l = h, -h
        else: r, l = tpos, -tpos
        if rot90: return (root[0], root[2] - r), (root[0], root[2] - l)   # yaw 90: local +x -> world -z
        return (root[0] + r, root[2]), (root[0] + l, root[2])
    for f in range(60 * 30):
        p = passed; nxt = None; end = None
        if state == 0:
            if beh == 0:
                state, rot90 = 1, False; org = [0.0, 0.0, pz]; tpos = inWidthH + 60
            elif beh == 1:
                state, rot90 = 8, True; org = [px, 0.0, offsetZ]; tpos = inWidthV + 10
            else:
                dirs = {2: (0, 0, -1), 3: (0, 0, 1), 4: (1, 0, 0), 5: (-1, 0, 0)}
                state = 15 + beh - 2; rot90 = beh >= 4
                root = [root[i] + start_offset[i] for i in range(3)]; md = tuple(speed * c for c in dirs[beh])
            if beh in (0, 1): root = list(org); tpos = -tpos                 # SetupHV: left=+tpos, right=-tpos (1 frame)
            log.append('%6.3f INIT -> state %d root (%.1f, %.1f)' % (t, state, root[0], root[2]))
        elif state in (1, 8):
            st, ed = (inWidthH + 20, outWidthH) if state == 1 else (inWidthV, outWidthV)
            u = min(max(min(p, InTime) / InTime, 0), 1); tpos = (ed - st) * u + st + 10
            if p >= InWait + InTime: nxt = state + 1
        elif state in (2, 9):
            pt = min(p, CloseTime); tpos = curveIn(pt / CloseTime) * (outWidthH if state == 2 else outWidthV) + 10
            if pt >= CloseTime: nxt = state + 1                                 # (sibling dead -> 7 / 14)
        elif state in (3, 10):
            if min(p, WaitTime) >= WaitTime: nxt = state + 1                    # laser + burners on
        elif state in (4, 11):
            pt = min(p, OutTime); tpos = curveOut(pt / OutTime) * (outWidthH if state == 4 else outWidthV) + 10
            if pt >= OutTime:
                velz = (1 if pz >= org[2] else -1) if state == 4 else (1 if px >= org[0] else -1); nxt = state + 1
        elif state in (5, 12):
            if min(p, PostWait) >= PostWait: nxt = state + 1
        elif state in (6, 13):
            state = 19; log.append('%6.3f -> AWAY velZ %+d' % (t, velz))
        elif state == 19:
            if beh == 0: org[2] += velz * AwaySpeed * DT
            else: org[0] += velz * AwaySpeed * DT
            root = list(org)
            if not any(inside(h) for h in halves()): end = 'AWAY: IsGamePlayArea false -> EndRoute + CallDisabled'
        elif 15 <= state <= 18:
            root = [root[i] + md[i] * DT for i in range(3)]
            if root[2] > 120 or root[2] < -120 or root[0] < -180 or root[0] > 180: end = 'combined: past DefaultPosition bound -> EndRoute'
        if nxt is not None:
            log.append('%6.3f state %d -> %d (tpos %.2f)' % (t, state, nxt, tpos)); state = nxt; passed = 0.0
        if end: log.append('%6.3f %s root (%.1f, %.1f)' % (t, end, root[0], root[2])); break
        passed += DT; t += DT
        r, l = halves(); rows.append((t, state, root[0], root[2], r, l))
        if t >= 60: log.append('60 s: SplineMover duration (EnemyData.duration 60) -> EndRoute'); break
    print('\n'.join(log)); print('-- (t, state, root x, root z, right half, left half) every %d frames' % every)
    for k, (tt, s, x, z, r, l) in enumerate(rows):
        if k % every == every - 1 or k == len(rows) - 1:
            print('  %6.3f  st%2d  root (%7.2f,%7.2f)  R (%7.2f,%7.2f)  L (%7.2f,%7.2f)' % (tt, s, x, z, r[0], r[1], l[0], l[1]))
main()
