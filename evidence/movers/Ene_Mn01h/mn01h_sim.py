# Frame-stepped model of Ene_Mn01h (Pf_Ene_Mn01) + its 13 Ene_Mn01c shield bits (read-only study, 60 fps, float32 counters).
# usage: C:\Python311\python.exe -I mn01h_sim.py [--x 0] [--y 0] [--secs 12] [--seed 1] [--every 30] [--kill T]
# Sky plane: x right, z up the screen. Neither class reads the player, so no player position is needed.
# Random draws use Python's RNG (the game's RandomUtility stream is not reproduced) -> bit radii/masses are examples.
import sys, math, struct, random
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]
DT = f32(1 / 60); TAN10 = math.tan(math.radians(10))
def view_h(y): return 2 * (400 - y) * TAN10
def in_area(p, half):                       # IsInGameAreaWorld: viewport rect (-half, -half, 1+2half, 1+2half)
    h = view_h(p[1]); vx = .5 + p[0] / (h * 16 / 9); vz = .5 + p[2] / h
    return -half <= vx < 1 + half and -half <= vz < 1 + half
# prefab Pf_Ene_Mn01 (Ene_Mn01h) values
STARTPOS, SLOW_WAIT, SLOW_LINE, R_MIN, R_MAX, SHOT_WAIT, COUNT = 110.0, 10.0, 45.0, 15.0, 25.0, 1.0, 13
IN_CURVE = [(0, 1, -1.0396208, -1.0396208), (0.50231755, 0.5010671, -1.1646425, -1.1646425), (1, 0, 0.04044206, 0.04044206)]
SPIN_CURVE = [(0, 0, 0, 0), (0.5020712, 1, -0.027776208, -0.027776208), (1, 0, 0, 0)]
# Ene_Mn01c statics (.cctor 0x1CFAF70)
DECEL, ACCEL, SEPA, MASS_MIN, MASS_MAX, GAP, APPEAR, ROT_IN, ROT_OUT = 20.0, 400.0, 120.0, 0.9, 1.3, 5.0, 1.8, 2.0, 10.0


def curve(keys, t):                         # AnimationCurve.Evaluate, non-weighted Hermite, clamped ends
    if t <= keys[0][0]: return keys[0][1]
    if t >= keys[-1][0]: return keys[-1][1]
    for (t0, v0, _, m0), (t1, v1, m1, _) in zip(keys, keys[1:]):
        if t0 <= t <= t1:
            d = t1 - t0; u = (t - t0) / d; u2, u3 = u * u, u * u * u
            return (2*u3 - 3*u2 + 1) * v0 + (u3 - 2*u2 + u) * d * m0 + (-2*u3 + 3*u2) * v1 + (u3 - u2) * d * m1


def norm(v):
    m = math.sqrt(sum(c * c for c in v)); return [c / m for c in v] if m > 1e-5 else [0.0, 0.0, 0.0]


def roty(deg, v):                           # Quaternion.Euler(0,deg,0) * v  (+deg turns +Z toward +X = clockwise on screen)
    a = math.radians(deg); c, s = math.cos(a), math.sin(a); return [v[0] * c + v[2] * s, v[1], -v[0] * s + v[2] * c]


class Bit:                                  # Ene_Mn01c set up by Ene_Mn01h._createChildren (0x1CFC850)
    def __init__(s, i, rng):
        s.i = i; s.mass = rng.uniform(MASS_MIN, MASS_MAX)
        a = math.radians((rng.random() - .5) * (180 / COUNT) + i / COUNT * 360 + 20)
        r = rng.uniform(R_MIN, R_MAX)
        s.off = [math.cos(a) * r, 0.0, math.sin(a) * r]            # _offsetFormation
        s.pos = [math.cos(a) * 200, 0.0, math.sin(a) * 120]         # _localPosition = root.localPosition (enemy-root frame)
        s.state, s.step, s.wait, s.speed = 'SHIELD', 0, 0.0, 0.0
        s.vel = [0.0, 0.0, 0.0]; s.spin = 0.0; s.sepa = 0.0; s.sepa_done = False; s.gone = None; s.log = []

    def frame(s, t, parent, dt):
        if s.gone: return
        if s.state == 'SHIELD':                                     # _shieldModeState 0x1CFB470
            if s.step == 0: s.step, s.speed, s.wait = 1, 50.0, 0.0
            if s.step == 1:
                s.wait = f32(s.wait + dt)
                if s.wait >= APPEAR: s.step, s.wait = 2, 0.0
                else:
                    s.speed = max(0.0, s.speed - DECEL * s.mass * dt)
                    d = [parent[k] + s.off[k] - s.pos[k] for k in range(3)]; dl = math.hypot(*d); st = s.mass * s.speed * dt
                    if dl > .001 and st > 0:
                        n = norm(d); s.vel = [c * s.speed for c in n]
                        if dl > st: s.pos = [s.pos[k] + s.vel[k] * s.mass * dt for k in range(3)]
                        else: s.pos = [parent[k] + s.off[k] for k in range(3)]
            elif s.step == 2:
                s.speed += ACCEL * s.mass * dt
                d = [parent[k] + s.off[k] - s.pos[k] for k in range(3)]; dl = math.hypot(*d)
                if s.mass * s.speed * dt >= dl:
                    k = min(s.mass * s.speed / 60, GAP); s.vel = [c * k for c in norm(s.vel)]
                    s.state, s.step, s.spin = 'GATHER', 0, 0.0
                    s.log.append('%6.3f bit %2d docks (SE 186) at (%.1f,%.1f), approach speed %.0f' % (t, s.i, s.pos[0], s.pos[2], s.mass * s.speed))
                else:
                    s.vel = [c * s.speed for c in norm(d)]; s.pos = [s.pos[k] + s.vel[k] * s.mass * dt for k in range(3)]
        elif s.state == 'GATHER':                                   # _gatherModeState 0x1CFB130
            e = math.exp(-6 * dt); s.vel = [c * e for c in s.vel]; s.spin += dt * 60
            o = roty(s.spin, [s.off[k] + s.vel[k] for k in range(3)]); s.pos = [parent[k] + o[k] for k in range(3)]
        elif s.state == 'AWAY':                                     # _awayModeState 0x1CFAC50, then IsGamePlayArea check
            s.pos = [s.pos[k] + s.vel[k] * s.mass * dt for k in range(3)]
            if not in_area(s.pos, .15):
                s.gone = t; s.log.append('%6.3f bit %2d CallDisabled (left play area) at (%.1f,%.1f)' % (t, s.i, s.pos[0], s.pos[2]))
        if s.sepa > 0:                                              # LocalLateUpdate _sepaTimer
            s.sepa = f32(s.sepa - dt)
            if s.sepa <= 0 and not s.sepa_done: s.sepa_done = True; s.separate(t)

    def separate(s, t):                                             # ToSeparate 0x1CFA9C0
        if s.state == 'AWAY' or s.gone: return
        v = roty(s.spin, s.off) if s.state == 'GATHER' else s.vel
        s.vel = [c * s.mass * SEPA for c in norm(v)]; s.state = 'AWAY'
        s.log.append('%6.3f bit %2d separates, %.1f u/s heading %.1f deg' % (t, s.i, SEPA * s.mass * s.mass, math.degrees(math.atan2(s.vel[0], s.vel[2])) % 360))


def run(x=0.0, y=0.0, secs=12.0, seed=1, every=30, kill=None):
    rng = random.Random(seed)
    pos = [x, y, STARTPOS]; state, st, velz, accz = 0, 0.0, 0.0, 0.0
    summon_start, summon_state, summon_t, summon_end = False, 0, 0.0, False
    spin_flag, spin_t, eul = False, 0.0, [0.0, 0.0]
    bits = []; log = []; track = []; t = 0.0; fire_at = None
    for fr in range(int(secs * 60)):
        # ---- Ene_Mn01h.LocalLateUpdate 0x1CFC220: pawn code BEFORE base PawnEnemy.LocalLateUpdate (mover) ----
        if state == 0: spin_flag = summon_start = False; summon_state = 0; state, st = 1, 0.0
        elif state == 1:
            if st >= 1 and not summon_start: summon_start = True
            if st < 3: pos[2] = SLOW_LINE + curve(IN_CURVE, st / 3) * (STARTPOS - SLOW_LINE)
            else:
                state, st, pos[2], velz, summon_start = 2, 0.0, SLOW_LINE, 0.0, True; log.append('%6.3f IN done at z %.2f' % (t, pos[2]))
        elif state == 2:
            if st < SLOW_WAIT and not summon_end:
                accz = -2.0; velz = max(velz - 2 * DT, -2.0); pos[2] += velz * DT
            else:
                accz = -32.0; state, st = 3, 0.0; log.append('%6.3f OUT starts at z %.2f' % (t, pos[2]))
        elif state == 3: velz += accz * DT; pos[2] += velz * DT
        if summon_start and state != -1:
            summon_t = f32(summon_t + DT)
            if summon_state == 0:
                bits = [Bit(i, rng) for i in range(COUNT)]; summon_state, summon_t = 1, 0.0; log.append('%6.3f _createChildren: %d bits' % (t, COUNT))
            elif summon_state == 1 and summon_t >= 4.5:
                spin_flag, spin_t = True, 0.0
                for b in bits: b.sepa = 1.0                       # SendChildEvent(2) -> CommonEvent(2): _sepaTimer = 1
                fire_at = t + SHOT_WAIT; summon_state, summon_t = 3, 0.0
                log.append('%6.3f spin burst; bits separate in 1 s; _fire in %.1f s' % (t, SHOT_WAIT))
            elif summon_state == 3 and summon_t >= 2: summon_end = True; summon_state, summon_t = 4, 0.0
        s = 32.0
        if spin_flag:
            spin_t = f32(spin_t + DT)
            if spin_t > 2: spin_t, spin_flag = 0.0, False
            s += curve(SPIN_CURVE, spin_t * .5) * 960
        eul[1] += s * DT; eul[0] += s * DT * .3
        st = f32(st + DT)
        if fire_at is not None and t >= fire_at:
            log.append('%6.3f BulletFireAsync mn01_fire1 from _muzzle, Mn01h at (%.1f,%.1f)' % (t, pos[0], pos[2])); fire_at = None
        if kill is not None and t >= kill and state != -1:
            log.append('%6.3f Mn01h killed -> SendChildEvent(0): every bit separates now' % t)
            for b in bits: b.separate(t)
            state = -1
        for b in bits: b.frame(t, pos, DT)
        if state not in (-1,) and not in_area(pos, .3):            # after base: !_isInGamePlayArea -> CallDisabled (Large = AreaL)
            log.append('%6.3f Mn01h CallDisabled (left AreaL) at z %.2f' % (t, pos[2])); state = -1
        t += DT
        if fr % every == every - 1:
            track.append((round(t, 3), round(pos[2], 2), round(eul[1] % 360, 1),
                          [(round(b.pos[0], 1), round(b.pos[2], 1), b.state[0]) for b in bits[:3] if not b.gone]))
        if state == -1 and bits and all(b.gone for b in bits): break
    for b in bits: log += b.log
    log.sort(key=lambda l: float(l.split()[0]))
    print('\n'.join(log)); print('-- track every %d frames: (t, Mn01h z, modelTop yaw, bits 0-2 (x, z, state S/G/A))' % every)
    for r in track: print('  ', r)


if __name__ == '__main__':
    a = sys.argv[1:]; o = {a[i][2:]: a[i + 1] for i in range(0, len(a) - 1, 2)}
    run(float(o.get('x', 0)), float(o.get('y', 0)), float(o.get('secs', 12)), int(o.get('seed', 1)), int(o.get('every', 30)),
        float(o['kill']) if 'kill' in o else None)
