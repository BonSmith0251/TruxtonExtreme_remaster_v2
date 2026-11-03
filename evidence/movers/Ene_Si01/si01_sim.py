# Frame-stepped model of Ene_Si01 (ReStart 0x1CFF860, _stateExec 0x1D00370, Repulsion 0x1CFFDD0) following its
# queen Ene_Mk01 (_move / _childRepulsion re-implemented from ../Ene_Mk01/SPEC.md and mk01_sim.py). Read-only study.
# usage: C:\Python311\python.exe -I si01_sim.py [--def a|b] [--player x,z] [--secs 3] [--every 15] [--seed 1]
#        [--sway0 <rad for child 1, default random>] [--child 1..10] [--all 1]
# Sky frame: x right, z up the screen, y toward the camera. Yaw about +Y, 0 = +Z.
# Assumptions [I]: one LateUpdate per frame at dt = f32(1/60); Mk01 updates before its children each frame
# (spawn-list order); queen localPosition == GetSkyRootPosition(queen) (same parent root); player at y = 0.
import math, struct, sys, re, os, random
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]
DT = f32(1 / 60)
# ---- Ene_Si01 static constants (.cctor 0x1D000E0) ----
PARENT_DIST, PARENT_APART, PARENT_BODY = 50.0, 60.0, 40.0
SWAY_T_X, SWAY_T_Y, SWAY_A_X, SWAY_A_Y = 5.0, 3.0, 30.0, 15.0
FOLLOW_RATE, BODY, ACCEL, SHOT_INT, TURN_T, DIST_LIMIT = f32(0.1), 20.0, 100.0, 1.0, 1.0, 100.0
# ---- vector / quaternion helpers (Unity conventions) ----
def add(a, b): return [a[i] + b[i] for i in range(3)]
def sub(a, b): return [a[i] - b[i] for i in range(3)]
def mul(a, s): return [a[i] * s for i in range(3)]
def mag(a): return math.sqrt(sum(x * x for x in a))
def nrm(a):
    m = mag(a); return mul(a, 1 / m) if m > 1e-5 else [0.0, 0.0, 0.0]
def dot(a, b): return sum(a[i] * b[i] for i in range(3))
def qyaw(deg): h = math.radians(deg) / 2; return (0.0, math.sin(h), 0.0, math.cos(h))
def qpitch(deg): h = math.radians(deg) / 2; return (math.sin(h), 0.0, 0.0, math.cos(h))
def qmul(a, b):
    ax, ay, az, aw = a; bx, by, bz, bw = b
    return (aw*bx + ax*bw + ay*bz - az*by, aw*by + ay*bw + az*bx - ax*bz, aw*bz + az*bw + ax*by - ay*bx, aw*bw - ax*bx - ay*by - az*bz)
def qrot(q, v):
    x, y, z, w = q; vx, vy, vz = v
    tx = 2 * (y*vz - z*vy); ty = 2 * (z*vx - x*vz); tz = 2 * (x*vy - y*vx)
    return [vx + w*tx + (y*tz - z*ty), vy + w*ty + (z*tx - x*tz), vz + w*tz + (x*ty - y*tx)]
def slerp(a, b, t):                                  # Quaternion.Slerp (clamped, shortest path)
    t = min(max(t, 0.0), 1.0); d = sum(a[i] * b[i] for i in range(4))
    if d < 0: b = tuple(-x for x in b); d = -d
    if d > 0.9995: r = [a[i] + (b[i] - a[i]) * t for i in range(4)]
    else:
        th = math.acos(d); s = math.sin(th); wa = math.sin((1 - t) * th) / s; wb = math.sin(t * th) / s
        r = [a[i] * wa + b[i] * wb for i in range(4)]
    m = math.sqrt(sum(x * x for x in r)); return tuple(x / m for x in r)
def bearing(frm, to): return math.degrees(math.atan2(to[0] - frm[0], to[2] - frm[2]))
def turn(rt, ra, target_deg):                        # shared RotatePlayer law (Mk01 0x1DC8920 / Si01 0x1D01047)
    rt = min(max(f32(rt + DT), 0.0), TURN_T); k = min(max(rt / TURN_T, 0.0), 1.0) ** 2      # InQuad01
    a = target_deg - ra; a -= math.floor(a / 360) * 360; a = min(max(a, 0.0), 360.0)
    if a > 180: a -= 360
    return rt, f32(ra + k * a)
# ---- queen Ene_Mk01 (route LUTs, InOutSine legs, 1 s waits) ----
LUT = r'D:\games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\InGame\RouteLUT'
def lut(name):
    s = open(os.path.join(LUT, name + '.asset')).read()
    p = [tuple(map(float, m)) for m in re.findall(r'x: ([-\d.e]+), y: ([-\d.e]+), z: ([-\d.e]+)', re.search(r'_positions:\n((?:  - .*\n)+)', s).group(1))]
    return p
def cosf_tab(deg): return math.cos(math.radians(int(deg * 10) % 3600 / 10))   # VectorUtility.Cosf 0.1 deg table
def inoutsine(t):
    if t < .5: return (1 - cosf_tab(2 * t * 90)) * .5
    return 1 - (1 - cosf_tab(2 * (1 - t) * 90)) * .5
class Queen:
    def __init__(s, which, spawn, speed=30.0):
        s.routes = iter(['move_mk01%s_%02d' % (which, i) for i in range(1, 10)]); s.pos = list(spawn); s.yaw = 180.0
        s.state = 0; s.speed = speed; s.alive = True; s.retarget = False
    def nxt(s):
        n = next(s.routes, None)
        if n is None: return False
        p = lut(n); s.a, s.b = p[0], p[-1]; s.L = f32(math.dist(s.a, s.b)); s.off = 0.0; s.sp = list(s.pos); return True
    def move(s):                                     # _move 0x1DC9CF0 (rotation omitted: Si01 does not read it)
        s.retarget = False
        if s.state == 0: s.state = 1 if s.nxt() else 3
        elif s.state == 1:
            s.off = min(f32(s.off + s.speed * DT), s.L); u = inoutsine(s.off / s.L)
            s.pos = [s.a[k] + (s.b[k] - s.a[k]) * u - s.a[k] + s.sp[k] for k in range(3)]
            if s.off >= s.L:
                if not s.nxt(): s.state = 3
                else: s.wait = 0.0; s.state = 2
        elif s.state == 2:
            s.wait = f32(s.wait + DT)
            if s.wait >= 1.0: s.retarget = True; s.state = 1      # SetChildTarget(_targetPlayer, false)
        elif s.state == 3: s.alive = False                     # CallDisabled -> IsAlive false
# ---- Ene_Si01 ----
class Si01:
    def __init__(s, n, pos, queen_pos, queen_yaw, sway0):
        s.n = n; s.pos = list(pos); s.alive = True
        # SetTargetAndParent(i, player, queen, immediate=true) from Mk01.ReStart -> _rotateTime = 1 ... then ReStart:
        lp = qrot(qyaw(-queen_yaw), sub(pos, queen_pos))     # queen.InverseTransformPoint (scale drops out on normalize)
        s.first = mul(nrm(lp), PARENT_DIST)                    # _firstPosition
        s.swx = sway0; s.swy = 0.0; s.follow = (0.0, 0.0, 0.0, 1.0); s.acc = [0.0, 0.0, 0.0]
        s.shot = f32(SHOT_INT); s.rt = 0.0; s.ra = 0.0; s.shots = []; s.yaw = 0.0
    def step(s, q, P, t):                               # _stateExec 0x1D00370
        if not q.alive: s.alive = False; return             # _queenEnemy = null; CallDisabled
        Q = q.pos
        b = bearing(Q, P)
        s.swy = f32(s.swy + DT / SWAY_T_Y * math.pi * 2)
        s.swx = f32(s.swx + DT / SWAY_T_X * math.pi * 2)
        C = qmul(qyaw(b + SWAY_A_Y * math.cos(s.swy)), qpitch(SWAY_A_X * math.cos(s.swx)))
        s.follow = slerp(s.follow, C, min(DT * 60 * FOLLOW_RATE, 1.0))
        T = sub(Q, qrot(s.follow, s.first)); d = sub(T, s.pos)
        if dot(s.acc, d) < 0: s.acc = sub(s.acc, mul(nrm(s.acc), ACCEL * DT * 0.8))
        s.acc = add(s.acc, mul(nrm(d), ACCEL * DT))
        e = sub(s.pos, Q); r = mag(e)
        if PARENT_BODY - r > 0: s.acc = add(s.acc, mul(nrm(e), (PARENT_BODY - r) * 0.5))
        if r - PARENT_APART > 0: s.acc = sub(s.acc, mul(nrm(e), (r - PARENT_APART) * 0.5))
        np_ = add(s.pos, mul(s.acc, DT)); f = sub(np_, Q)
        if mag(f) > DIST_LIMIT: np_ = add(Q, mul(nrm(f), DIST_LIMIT))
        s.rt, s.ra = turn(s.rt, s.ra, bearing(np_, P)); s.pos = np_; s.yaw = s.ra
        s.shot = f32(s.shot - DT)
        if s.shot <= 0: s.shot = f32(s.shot + SHOT_INT); s.shots.append(t)
def repulse(a, b):                                    # Repulsion 0x1CFFDD0 (called by Mk01._childRepulsion, i < j)
    v = sub(a.pos, b.pos); k = BODY - mag(v)
    if k > 0:
        n = nrm(v); a.acc = add(a.acc, mul(n, k * 0.8)); b.acc = sub(b.acc, mul(n, k * 0.8))
DEFS = {'a': ((-30.0, 0.0, 150.0), 'a'), 'b': ((30.0, 0.0, 150.0), 'b')}
OFFS = [(20, -30), (10, -30), (0, -30), (-10, -30), (-20, -30)] + [(-20, -30)] * 5
if __name__ == '__main__':
    a = sys.argv[1:]; o = {a[i][2:]: a[i + 1] for i in range(0, len(a) - 1, 2)}
    spawn, which = DEFS[o.get('def', 'a')]; px, pz = map(float, o.get('player', '0,-49').split(','))
    P = [px, 0.0, pz]; secs = float(o.get('secs', 3)); every = int(o.get('every', 15)); rnd = random.Random(int(o.get('seed', 1)))
    child = int(o.get('child', 1)); show_all = o.get('all', '0') == '1'
    q = Queen(which, spawn); kids = []
    for i, (ox, oz) in enumerate(OFFS):
        sw = rnd.uniform(0, 2 * math.pi)                      # Random.Range(0, 6.283185)
        if i == 0 and 'sway0' in o: sw = float(o['sway0'])
        kids.append(Si01(i + 1, (spawn[0] + ox, 0.0, spawn[2] + oz), spawn, 180.0, sw))
    print('# def ene_mk01%s spawn %s player %s; child %d first=%s swayX0=%.3f' % (which, spawn, P, child,
          ['%.3f' % v for v in kids[child - 1].first], kids[child - 1].swx))
    print('#  t(s)   child x      y       z    yaw   |v|   r(queen)  queen x     z   state')
    print('  0.000  %7.2f %6.2f %7.2f %6.1f  %5.1f  %6.2f   %7.2f %7.2f' % (*kids[child-1].pos, 0.0, 0.0,
          mag(sub(kids[child-1].pos, q.pos)), q.pos[0], q.pos[2]))
    t = 0.0; fr = 0
    while t < secs - 1e-6:
        fr += 1; t = fr * DT
        q.move()
        for i in range(len(kids)):
            for j in range(i + 1, len(kids)): repulse(kids[i], kids[j])
        for k in kids:
            if q.retarget: k.rt = 0.0                         # SetTargetAndParent(.., immediate=false)
            k.step(q, P, t)
        if fr % every == 0:
            c = kids[child - 1]
            print('  %5.3f  %7.2f %6.2f %7.2f %6.1f  %5.1f  %6.2f   %7.2f %7.2f  %d' % (t, c.pos[0], c.pos[1], c.pos[2],
                  c.yaw % 360, mag(c.acc), mag(sub(c.pos, q.pos)), q.pos[0], q.pos[2], q.state))
            if show_all:
                print('         all: ' + ' '.join('(%.1f,%.1f,%.1f)' % tuple(k.pos) for k in kids))
    print('# shots child %d at t = %s' % (child, ', '.join('%.3f' % s for s in kids[child - 1].shots)))
