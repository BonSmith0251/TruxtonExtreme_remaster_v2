# Frame-stepped model of Ene_Ml01._moveState (read-only study). 60 fps. Foods (Pf_Ene_Sj01) are STATIC points given on the
# command line (the real fish follow their own spline routes - not modelled). Eaten = within _biteRange of the Ml01 centre
# while the jaw is Open. usage: python -I ml01_sim.py [--spawn x,z] [--yaw 0] [--foods "x,z;x,z;..."] [--player x,z] [--secs 12]
import math, struct, sys
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]
DT = f32(1 / 60); TAN10 = math.tan(math.radians(10)); ASPECT = 16 / 9
def viewport(p): h = 2 * (400 - p[1]) * TAN10; return (.5 + p[0] / (h * ASPECT), .5 + p[2] / h)
def wide_area(p): v = viewport(p); return -.5 <= v[0] < 1.5 and -.5 <= v[1] < 1.5     # IsGameWideArea (+-0.5)
a = sys.argv[1:]; o = {a[i][2:]: a[i + 1] for i in range(0, len(a) - 1, 2)}
sx, sz = (float(v) for v in o.get('spawn', '0,150').split(','))
foods = [tuple(float(v) for v in f.split(',')) for f in o.get('foods', '-40,40;-20,50;0,40;20,50;40,40').split(';') if f]
foods = [[f[0], 0.0, f[1]] for f in foods]
player = [float(v) for v in o.get('player', '0,-49').split(',')]; secs = float(o.get('secs', 12)); every = int(o.get('every', 6))
LIMX, LIMY, BITE, EAT, GETAWAY, TURNSPEED = 90.0, 70.0, 20.0, 1.8, 10.0, 20.0
pos = [sx, 0.0, sz]; yaw = float(o.get('yaw', 0)); state = 0; st = 0.0; tot = 0.0; speed = 0.0; smax = 0.0
turn = 0.0; tmax = 0.0; target = -1; last = [0, 0, 0]; jaw = 0; eat_end = False; t = 0.0; log = []; rows = []; NAMES = 'Init Find PreWait Search Attack PostWait PlayerSearch PlayerAttack Release'.split()
def say(m): log.append('%7.3f  %-44s pos=(%7.2f,%7.2f) yaw=%7.2f v=%6.1f turn=%5.2f' % (t, m, pos[0], pos[2], yaw % 360, speed, turn))
def fwd(): r = math.radians(yaw); return (math.sin(r), 0.0, math.cos(r))
def step():
    f = fwd()
    for k in range(3): pos[k] += f[k] * speed * DT
def set_near():                                    # _setNearFood: LAST food with |x|<90 and |y|<70 (min distance never updated)
    global target
    target = -1
    for i, fd in enumerate(foods):
        if fd is not None and abs(fd[0]) < LIMX and abs(fd[1]) < LIMY: target = i
    return target
def rotate_towards(d, delta):                     # _rotateTowards: RotateTowards(rot, LookRotation(d), delta*_turnSpeed) (yaw only here)
    global yaw
    want = math.degrees(math.atan2(d[0], d[2])); diff = (want - yaw + 180) % 360 - 180
    m = delta * TURNSPEED; yaw += max(-m, min(m, diff))
def wrap180(e): e = math.fmod(e % 360, 360); return e - 360 if e > 180 else e
def aimed(d): return abs(math.degrees(math.atan2(d[0], d[2])) - wrap180(yaw)) < 2 and math.hypot(d[0], d[1], d[2]) < 80
def check_pos(rng):                                # _checkPosition: point rng ahead OUTSIDE the x/y limits
    f = fwd(); return not (abs(pos[0] + f[0] * rng) < LIMX and abs(pos[1] + f[1] * rng) < LIMY)
def go(s, m=''):
    global state; state = s; say('-> %s %s' % (NAMES[s], m))
say('spawn, foods %s' % [(f[0], f[2]) for f in foods])
while t < secs and state <= 8:
    if state == 0: go(2); speed = 50.0                                                       # Init: _foodListup
    elif state == 1:                                                                          # Find
        jaw = 0
        if set_near() != -1: go(3, 'target %d' % target); speed, smax, turn, tmax, st = 20.0, 50.0, 1.0, 12.0, 0.0; last = list(foods[target])
        else: go(6); speed = 50.0; st = 0.0
    elif state == 2:                                                                          # PreWait
        if st >= .1: go(1)
        step()
    elif state == 3:                                                                          # Search
        speed = min(smax, speed + DT * 16); turn = min(tmax, turn + DT * 32); skip = False
        if st >= EAT - .2:
            if math.dist(last, pos) > 100: st *= .5; skip = True
            else: speed = max(0.0, speed - DT * 100); jaw = 1
        if not skip and st >= EAT:
            if foods[target] is None: jaw = 0; go(1)
            else: st = 0.0; speed = 100.0 if check_pos(60) else 200.0; go(4, 'bite timer')
            skip = True
        if not skip:
            if target == -1 or foods[target] is None or (abs(foods[target][0]) < LIMX and abs(foods[target][1]) < LIMY):
                if set_near() == -1: st = 0.0; speed, turn = 50.0, 4.0; go(6, 'no food'); skip = True
        if not skip:
            tg = foods[target] if foods[target] is not None else last; last = list(tg)
            d = (tg[0] - pos[0], 0 - pos[1], tg[2] - pos[2])
            rotate_towards(d, DT * turn); step()
            if aimed(d): jaw = 1; st = 0.0; speed = 200.0; turn = 4.0; go(4, 'aimed'); speed = 100.0 if check_pos(60) else speed
    elif state in (4, 7):                                                                     # Attack / PlayerAttack
        step()
        if st >= .1:
            if jaw != 2: say('jaw close (SE 0x94)'); jaw = 2
            speed -= DT * 400
        if state == 4 and speed <= 20: st = 0.0; speed = 20.0; go(5)
        if state == 7 and speed <= 0: speed = 50.0; jaw = 0; go(8)
    elif state == 5:                                                                          # PostWait
        step()
        if st >= .4: go(1)
    elif state == 6:                                                                          # PlayerSearch
        if not wide_area(pos): jaw = 0; go(8, 'outside wide area')
        else:
            d = (player[0] - pos[0], -pos[1], player[1] - pos[2]); turn += DT * 10
            rotate_towards(d, DT * turn); speed = max(100.0, speed + DT * 10)
            if aimed(d): st = 0.0; speed = 200.0; jaw = 1; go(7)
            step()
    elif state == 8:                                                                          # Release
        if not wide_area(pos): state = 9; say('outside wide area -> CallDisabled next frame')
        step(); speed += DT * 100
    if jaw == 1:                                                                              # _foodEatCheck(_biteRange)
        for i, fd in enumerate(foods):
            if fd is not None and math.dist(fd, pos) <= BITE: foods[i] = None; say('ate food %d' % i)
    if tot >= GETAWAY and not eat_end:
        eat_end = True; say('getAway: CommonEvent(1) to all food (flee) [modelled: removed]'); foods = [None] * len(foods)
    st = f32(st + DT); tot = f32(tot + DT); t += DT; rows.append((t, pos[0], pos[2], yaw % 360, speed, state))
say('end (state %d)' % state)
print('\n'.join(log)); print('-- track (t, x, z, yaw, speed, state) every %d frames' % every)
for k, r in enumerate(rows):
    if k % every == every - 1: print('   (%.3f, %.2f, %.2f, %.1f, %.1f, %d)' % r)
