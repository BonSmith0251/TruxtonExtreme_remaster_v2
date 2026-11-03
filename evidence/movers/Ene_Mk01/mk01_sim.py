# Frame-stepped model of Ene_Mk01._move / RotatePlayer / _fire (read-only study). 60 fps, float32 where it matters.
# usage: python -I mk01_sim.py [--index 0|1] [--spawn x,z] [--speed 30] [--player x,z] [--secs 30] [--every 15]
import math, struct, sys, re, glob, os
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]
DT = f32(1 / 60)
LUT = r'D:\games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\InGame\RouteLUT'
A = ['move_mk01a_%02d' % i for i in range(1, 10)]; B = ['move_mk01b_%02d' % i for i in range(1, 10)]
def lut(name):
    s = open(os.path.join(LUT, name + '.asset')).read()
    t = [float(x) for x in re.findall(r'^  - ([-\d.e]+)$', re.search(r'_t:\n((?:  - .*\n)+)', s).group(1), re.M)]
    p = [tuple(map(float, m)) for m in re.findall(r'x: ([-\d.e]+), y: ([-\d.e]+), z: ([-\d.e]+)', re.search(r'_positions:\n((?:  - .*\n)+)', s).group(1))]
    return t, p
def ev(l, u):                                   # RouteLutAsset.EvaluatePosition: piecewise linear in _t [I]
    t, p = l
    for i in range(len(t) - 1):
        if u <= t[i + 1] or i == len(t) - 2:
            f = (u - t[i]) / (t[i + 1] - t[i]); return tuple(p[i][k] + (p[i + 1][k] - p[i][k]) * f for k in range(3))
def cosf(deg): return math.cos(math.radians(int(deg * 10) % 3600 / 10))   # VectorUtility.Cosf 0.1 deg table
def inoutsine(t):                               # EasingUtility.InOutSine01 0x1DE86F0
    if t < .5: return (1 - cosf(2 * t * 90)) * .5
    return 1 - (1 - cosf(2 * (1 - t) * 90)) * .5
a = sys.argv[1:]; o = {a[i][2:]: a[i + 1] for i in range(0, len(a) - 1, 2)}
idx = int(o.get('index', 0)); spawn = [float(v) for v in o.get('spawn', '-30,150').split(',')]
speed = float(o.get('speed', 30)); player = [float(v) for v in o.get('player', '0,-49').split(',')]
secs = float(o.get('secs', 40)); every = int(o.get('every', 15))
routes = iter(A if idx == 0 else B)
pos = [spawn[0], 0.0, spawn[1]]; yaw = 180.0; state = 0; off = 0.0; L = None; cur = None
sp = (0, 0, 0); spawnp = list(pos); wait = 0.0; rt = 1.0; ra = 0.0; fire = 0.0; t = 0.0; log = []; rows = []
def say(m): log.append('%7.3f  %-46s pos=(%7.2f,%7.2f) yaw=%7.2f' % (t, m, pos[0], pos[2], yaw % 360))
def length(l): return sum(math.dist(p, q) for p, q in zip(l[1], l[1][1:]))
def next_route():
    global cur, L, off, sp, spawnp
    n = next(routes, None)
    if n is None: return False
    cur = lut(n); L = f32(length(cur)); off = 0.0; sp = ev(cur, 0.0); spawnp = list(pos); say('route %s len %.2f (%.2f s)' % (n, L, L / speed)); return True
def rotate_player():                            # RotatePlayer 0x1DC8920
    global rt, ra, yaw
    rt = min(max(f32(rt + DT), 0), 1.0); k = min(max(rt / 1.0, 0), 1) ** 2
    ang = math.degrees(math.atan2(player[0] - pos[0], player[1] - pos[2])) - ra
    ang -= math.floor(ang / 360) * 360; ang = min(max(ang, 0), 360)
    if ang > 180: ang -= 360
    ra = f32(ra + k * ang); yaw = ra
def do_fire():                                  # _fire 0x1DC9C00: every FireTime 2 s, first on the first call
    global fire
    fire = f32(fire - DT)
    if fire <= 0: fire = f32(fire + 2); say('Bullet mk01_fire1')
say('spawn (index %d, speed %g, player %s)' % (idx, speed, player))
while t < secs:
    if state == 0:                              # Entering
        state = 1 if next_route() else 3
    elif state == 1:                            # Forward
        off = min(f32(off + speed * DT), L); u = inoutsine(off / L); p = ev(cur, u)
        pos = [p[k] - sp[k] + spawnp[k] for k in range(3)]
        rotate_player()
        if off >= L:
            say('leg done')
            if not next_route(): state = 3
            else: wait = 0.0; state = 2
        do_fire()
    elif state == 2:                            # Wait
        wait = f32(wait + DT)
        if wait >= 1.0: rt = 0.0; state = 1; say('wait done, retarget (rotateTime 0)')
        rotate_player(); do_fire()
    elif state == 3:
        say('Leaving -> CallDisabled (removed)'); break
    t += DT; rows.append((t, pos[0], pos[2], yaw % 360, state))
print('\n'.join(log)); print('-- track (t, x, z, yaw, state) every %d frames' % every)
for k, r in enumerate(rows):
    if k % every == every - 1: print('   (%.3f, %.2f, %.2f, %.2f, %d)' % r)
