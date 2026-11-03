# Frame-stepped model of the pawn-class movers Ene_St01 / Ene_So01 / Ene_Ss01 / Ene_Sj01 (escape) / Ene_Mp01 / Ene_Sh01,
# written from the disassembly cited in ../<Class>/SPEC.md. Reuses ../../air-route-events/tools/air_sim.py for the
# EnemyMover event stack (Mp01, Su01/Sv01). Sky plane: x right, z up the screen, y toward the camera; yaw about +Y,
# 0 = +Z (up the screen), 90 = +X. Player fixed (default (0,-49)). Not game code: an evidence aid.
# usage: C:\Python311\python.exe -I movers_sim.py <st01|so01|ss01|sj01|mp01|sh01> [--secs s] [--every k] [--seed n]
#        [--player x,z] [--spawn x,y,z] [--yaw deg] [--speed v] [--index n]
import sys, math, random, json, struct
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\air-route-events\tools')
import air_sim
f32 = air_sim.f32; DT = air_sim.DT
STAGES = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageEnemies'
GAME_AREA = air_sim.GAME_AREA                           # gameScreenAreas[Small] = (-.15,-.15,1.3,1.3)
SCREEN = (0.0, 0.0, 1.0, 1.0)                           # [I] stand-in for HybridCollisions.IsGamePlayArea (collider on screen)
def in_rect(p, r): return air_sim.in_rect(p, r)
def yaw_of(dx, dz): return math.degrees(math.atan2(dx, dz)) % 360 if dx * dx + dz * dz > 1e-10 else None
def fwd(yaw): a = math.radians(yaw); return (math.sin(a), 0.0, math.cos(a))
def rot_towards(cur, tgt, maxdeg):                      # yaw-only Quaternion.RotateTowards / Vector3.RotateTowards
    if tgt is None: return cur
    d = (tgt - cur + 180) % 360 - 180
    if d == -180: d = 180                               # [?] exact 180 deg: Slerp direction undefined, take +
    return tgt if abs(d) <= maxdeg else cur + math.copysign(maxdeg, d)
def mag(v): return math.sqrt(sum(c * c for c in v))
def norm(v):
    m = mag(v); return tuple(c / m for c in v) if m > 1e-5 else (0.0, 0.0, 0.0)
class Log:
    def __init__(s, every): s.rows = []; s.events = []; s.every = every; s.t = 0.0; s.k = 0
    def ev(s, msg, p, yaw, extra=''): s.events.append('%7.3f  %-58s pos=(%8.2f,%6.2f,%8.2f) yaw=%7.2f %s' % (s.t, msg, p[0], p[1], p[2], yaw % 360, extra))
    def row(s, p, yaw, extra=''):
        s.k += 1; s.t = round(s.k * DT, 6)
        s.rows.append((s.k, s.t, p, yaw % 360, extra))
    def dump(s):
        print('\n'.join(s.events)); print('-- track (frame, t, x, y, z, yaw, extra) every %d frames' % s.every)
        for i, (k, t, p, yaw, extra) in enumerate(s.rows):
            if k % s.every == 0 or i == len(s.rows) - 1 or k <= 3:
                print('  %4d %7.3f %8.2f %6.2f %8.2f %7.2f %s' % (k, t, p[0], p[1], p[2], yaw, extra))
# ------------------------------------------------------------------------------------------------ Ene_St01 (0x1D066C0)
def sim_st01(o, L):
    pos = list(o['spawn']); pl = o['player3']; index = o['index']
    S = dict(InvincibleTime=1.0, StartSpeed=150.0, LifeTime=8.0, MoveSpeed=100.0, DeceleSpeed=300.0, AcceleSpeed=100.0,
             DecelDist=50.0, KeepDist=50.0, WaitTime=0.0, ShotInterval=1.5)
    state = 0; nohit = S['InvincibleTime']; life = S['LifeTime']; msp = 1.0; mv = (0.0, 0.0, 1.0); yaw = 0.0  # ReStart
    shot = S['ShotInterval']; finish = False; wp = None; collision = False; names = 'Start Blow Move Wait Leave Exit'.split()
    L.ev('spawn (indexValue %d); ReStart: OffCollision on, _moveVector=fwd, _selfAngle=Euler(0,0,1)' % index, pos, yaw)
    while L.t < o['secs']:
        dt = DT
        if nohit > 0:                                       # top of ActionMove
            nohit = f32(nohit - dt)
            if nohit <= 0: collision = True; L.ev('_nohitTime ran out: ResetObjectFlag(OffCollision)', pos, yaw)
        st0 = state
        if state == 0:
            if finish:                                      # mover._isFinishDelay (FinishWait already ran)
                mv = tuple(c * S['StartSpeed'] for c in norm(tuple(pos[i] - pl[i] for i in range(3))))
                yaw = yaw_of(mv[0], mv[2]) or 0.0; wp = list(pl)
                wp[0] += S['KeepDist'] if pl[0] - pos[0] < 0 else -S['KeepDist']
                state = 1; L.ev('Start: blow vector away from player, waypoint (%.1f,%.1f)' % (wp[0], wp[2]), pos, yaw, 'v=%.1f' % mag(mv))
        elif state == 1:
            sp = 0.0 if index > 0 else mag(mv); n = norm(mv); ns = max(0.01, sp - dt * S['DeceleSpeed'])
            mv = tuple(c * ns for c in n)
            if sp <= 0.02: nohit = 0.0; collision = True; state = 2; L.ev('Blow ends -> Move (collision on)', pos, yaw)
            yaw = rot_towards(yaw, yaw_of(pl[0] - pos[0], pl[2] - pos[2]), 720 * dt)
            pos = [pos[i] + mv[i] * dt for i in range(3)]
        elif state in (2, 3):
            if state == 2:
                d = tuple(wp[i] - pos[i] for i in range(3)); dist = mag(d); n = norm(d)
                if dist >= S['DecelDist']:
                    mv = tuple(mv[i] + n[i] * S['AcceleSpeed'] * dt for i in range(3))
                    if mag(mv) > S['MoveSpeed']: mv = tuple(c * S['MoveSpeed'] for c in norm(mv))
                else:
                    s2 = mag(mv) * math.exp(-2 * dt); mv = tuple(c * s2 for c in norm(mv))
                    if s2 < 5: state = 3; wt = S['WaitTime']
                yaw = rot_towards(yaw, yaw_of(pl[0] - pos[0], pl[2] - pos[2]), 720 * dt)
                pos = [pos[i] + mv[i] * dt for i in range(3)]
            else:
                s2 = mag(mv) * math.exp(-2 * dt); mv = tuple(c * s2 for c in norm(mv))
                pos = [pos[i] + mv[i] * dt for i in range(3)]
                yaw = rot_towards(yaw, yaw_of(pl[0] - pos[0], pl[2] - pos[2]), 720 * dt)
            shot = f32(shot - dt)
            if shot <= 0: shot = f32(shot + S['ShotInterval']); L.ev('fire st01_fire1 from muzzle (z +3.64)', pos, yaw)
            if state == 3 and st0 == 3:
                wt = f32(wt - dt)
                if wt <= 0:
                    wp = list(pl); wp[0] += S['KeepDist'] if pl[0] - pos[0] < 0 else -S['KeepDist']; state = 2
            life = f32(life - dt)
            if life <= 0: state = 4; L.ev('lifetime 8 s over -> Leave (SetObjectFlag NoBullet)', pos, yaw)
        elif state == 4:
            n = norm(tuple(pos[i] - pl[i] for i in range(3)))
            mv = tuple(mv[i] + n[i] * S['AcceleSpeed'] * dt for i in range(3))
            pos = [pos[i] + mv[i] * dt * msp for i in range(3)]
            yaw = rot_towards(yaw, yaw_of(mv[0], mv[2]), 720 * dt)
            if not in_rect(pos, SCREEN): state = 5; L.ev('IsGamePlayArea false -> Exit', pos, yaw, 'v=%.1f' % mag(mv))
        elif state == 5:
            L.ev('Exit: CallDisabled (removed)', pos, yaw); L.row(pos, yaw, names[5]); break
        if state == 3 and st0 == 2: wt = S['WaitTime']
        finish = True                                       # stack runs after ActionMove: FinishWait on frame 1
        L.row(pos, yaw, '%-5s v=%6.2f%s' % (names[state], mag(mv), '' if collision else ' nocol'))
# ------------------------------------------------------------------------------------------------ Ene_So01 (0x1D035E0)
def sim_so01(o, L):
    pos = list(o['spawn']); yaw = o['yaw']; pl = o['player3']
    InSlow, Charge, AwayAcc, AwayMax = f32(0.35), 1.0, 480.0, 240.0
    state = 0; speed = 0.0; wait = 0.0; lp = list(pos)                 # GetStart: _localPosition, _state 0
    L.ev('spawn / GetStart', pos, yaw)
    while L.t < o['secs']:
        dt = DT; in_play = in_rect(pos, GAME_AREA)                     # PawnEnemy.LocalLateUpdate, before ProgressEvent
        aim = False
        if state == 0: speed = 60.0; wait = 0.0; state = 1; L.ev('state0: speed 60', pos, yaw)
        elif state == 1:
            if in_rect(pos, SCREEN):
                wait = f32(wait + dt)
                if wait >= InSlow: state = 2; L.ev('in play area for 0.35 s -> brake', pos, yaw)
        elif state == 2:
            speed = f32(speed - dt * 60); aim = True
            if speed <= 0: speed = 0.0; wait = 0.0; state = 3; L.ev('stopped -> charge (chargeEffect.Play)', pos, yaw)
        elif state == 3:
            wait = f32(wait + dt); aim = True
            if wait >= Charge: state = 4; L.ev('charged 1 s -> dash (colliders NoHitBullet, fireEffect.Play)', pos, yaw)
        elif state == 4:
            speed = min(speed + dt * AwayAcc, AwayMax)
            if not in_play: state = 5; L.ev('outside gameScreenArea -> state 5', pos, yaw, 'v=%.1f' % speed)
        else:
            L.ev('CallDisabled (removed)', pos, yaw); L.row(pos, yaw, 's5'); break
        if aim: yaw = rot_towards(yaw, yaw_of(pl[0] - pos[0], pl[2] - pos[2]), math.degrees(dt + dt))
        if speed >= 0:
            f = fwd(yaw); lp = [lp[i] + f[i] * speed * dt for i in range(3)]
        pos = list(lp)
        L.row(pos, yaw, 's%d v=%6.2f' % (state, speed))
# ------------------------------------------------------------------------------------------------ Ene_Ss01 (0x1D05840)
def sim_ss01(o, L):
    pl = o['player3']; spd = o['speed']
    maxD, minD, rollSpd, rollSec, stopSec, turnSec = 300.0, 50.0, -90.0, 8.0, f32(0.2), 0.5
    st = 0; length = maxD; rot = 0.0; off = 0.0; rs = rollSec; fired = False; flip = 0.0
    names = 'Starting Forward Rolling StopFire Turn Back Done'.split()
    while L.t < o['secs']:
        dt = DT
        if st == 0: st = 1
        elif st == 1:
            length = f32(length - dt * spd)
            if length <= minD: L.ev('Forward done: sound 0xBA, Rolling', pos, yaw); st = 2; length = minD
        elif st == 2:
            rot = rot + dt * rollSpd; rs = f32(rs - dt)
            if rs <= 0: rs = stopSec; st = 3; L.ev('Rolling done (8 s)', pos, yaw)
        elif st == 3:
            rs = f32(rs - dt)
            if rs <= 0: st = 4; rs = 0.0; L.ev('StopFire done -> Turn', pos, yaw)
        elif st == 4:
            rs = f32(rs + dt); flip = 180 * min(1.0, max(0.0, rs / turnSec))
            if rs >= turnSec: rs = f32(0.2); st = 5; L.ev('Turn done (model pitched 180) -> Back', pos, yaw)
            elif rs >= turnSec / 3 and not fired: fired = True; L.ev('fire shot06 from muzzle (angle arg %.1f)' % rot, pos, yaw)
        elif st == 5:
            length = f32(length + dt * spd)
            if length >= maxD: st = 6
        elif st == 6:
            L.ev('Done: CallDisabled (removed)', pos, yaw); L.row(pos, yaw, names[6]); break
        a = rot + off; yaw = -90 - a
        pos = [pl[0] + air_sim.tcos(a) * length, pl[1], pl[2] + air_sim.tsin(a) * length]
        if L.k == 0: L.ev('first frame placed at radius 300 (angle 0 = +X of player)', pos, yaw)
        L.row(pos, yaw, '%-8s r=%6.1f ang=%7.1f flip=%5.1f' % (names[st], length, a, flip))
# ------------------------------------------------------------------------------------------------ Ene_Sj01 (0x1D015A0)
def sim_sj01(o, L):
    rng = random.Random(o['seed']); pos = list(o['spawn']); yaw = o['yaw']
    state = 1; stime = 0.0                                     # CommonEvent(1) at t=0 (Ml01._foodGoAway / _moveState)
    wave = rng.random() * 90; wrate = rng.random() * 20; wmult = 1.0; away = rng.random() * 10 + 60   # last state-0 frame
    L.ev('CommonEvent(1): escape (wave %.1f, rate %.1f, away %.1f)' % (wave, wrate, away), pos, yaw)
    while L.t < o['secs']:
        dt = DT; stime += dt
        if state == 1:
            yaw = 90.0 if pos[0] > 0 else -90.0; state = 2; L.ev('mover paused, face %s' % ('+X' if yaw > 0 else '-X'), pos, yaw)
        elif state == 2:
            f = fwd(yaw); s = math.sin(math.radians(wave)); wave += wrate + 20
            zf = s * 0.5 * wmult; wmult *= 0.93; wrate *= 0.95
            away = max(90.0, away + dt * 4)
            pos = [pos[0] + away * f[0] * dt, pos[1] + away * f[1] * dt, pos[2] + away * zf * dt]
            if not in_rect(pos, GAME_AREA): state = 3; L.ev('left gameScreenArea -> state 3', pos, yaw, 'v=%.2f' % away)
        else:
            L.ev('CallDisabled (+ dieCallback unless _parentDie)', pos, yaw); L.row(pos, yaw, 's3'); break
        stime += dt
        L.row(pos, yaw, 's%d v=%6.2f' % (state, away))
# ------------------------------------------------------------------------------------------------ Ene_Mp01 (0x1CFCEF0)
class MpMover(air_sim.Mover):
    def frame(s):
        for g in list(s.speed_tasks):
            try: next(g)
            except StopIteration: s.speed_tasks.remove(g)
        for g in list(s.tasks):
            if s.ended: break
            try: next(g)
            except StopIteration: s.tasks.remove(g)
        s.in_play = in_rect(s.pos, GAME_AREA)
        if not s.ended: s.stack()
        s.laser()                                                   # Ene_Mp01.ActionMove after PawnEnemy.LocalLateUpdate
        s.t += DT; s.track.append((round(s.t, 4), round(s.pos[0], 2), round(s.pos[1], 2), round(s.pos[2], 2), round(s.yaw % 360, 2), s.seq))
    def laser(s):
        if not hasattr(s, 'seq'): s.seq = 0; s.lt = 3.0; s.started = False; s.roll = 15.0
        if s.in_play: s.lt = f32(s.lt - DT)
        if s.seq == 0:
            if s.in_play: s.started = True; s.roll = 90.0; s.seq = 1; s.say('laser START: turret RollSpeed 90'); return
        elif s.seq == 1:
            if s.lt <= 0: s.say('laser FIRE mp01_fire1 (BulletDirFireAsync muzzle01->mzzle01t)'); s.lt = 0.5; s.seq = 2
        elif s.seq == 2:
            if s.lt <= 0: s.roll = 30.0; s.lt = 1.0; s.seq = 3; s.say('laser after: turret RollSpeed 30')
        elif s.seq == 3:
            if s.lt <= 0: s.lt = 0.5; s.seq = 0
        if not s.in_play and s.started: s.started = False; s.seq = -1; s.say('left play area: laser token cancelled')
def sim_stack(o, L, cls, stage, name):
    j = json.load(open('%s\\%s.json' % (STAGES, stage), encoding='utf-8-sig'))
    d = next(x for x in j['definitions'] if x['name'] == name)
    routes = {}
    for r in j['routes']:
        r['length'] = sum(math.dist([p[k] for k in 'xyz'], [q[k] for k in 'xyz']) for p, q in zip(r['points'], r['points'][1:]))
        routes[r['name']] = r
    pl = d['placements'][0]
    m = cls(d, o['clip'], o['yaw'] if o['yaw'] is not None else pl['rotate']['y'], o['speed'] or pl['moveSpeed'], o['player'], routes, o['seed'], d['model'])
    m.say('spawn (%s %s)' % (stage, name))
    while m.t < o['secs'] and not m.ended: m.frame()
    m.say('end of simulation' if not m.ended else 'ENDED: ' + m.ended)
    print('\n'.join(m.log)); print('-- track (t, x, y, z, yaw, laserSeq) every %d frames' % o['every'])
    for k, row in enumerate(m.track):
        if k % o['every'] == o['every'] - 1 or k == len(m.track) - 1: print('   ', row)
# ------------------------------------------------------------------------------------------------ Ene_Sh01 (0x1CFEEB0)
def sim_sh01(o, L):
    table = [(0, 0, 0), (0, 0, 360), (0, 0, -360), (360, 0, 0), (-360, 0, 0)]
    idx = o['index'] if 0 <= o['index'] < 5 else 0; e = [0.0, 0.0, 0.0]
    print('indexValue %d -> RotateSpeedTable[%d] = %s deg/s on _rotateTarget (ene_sh01 node)' % (o['index'], idx, table[idx]))
    for k in range(1, int(o['secs'] / DT) + 1):
        e = [e[i] + table[idx][i] * DT for i in range(3)]
        if k % o['every'] == 0: print('  %4d %6.3f  model localEuler = (%.1f, %.1f, %.1f)' % (k, k * DT, *(c % 360 for c in e)))
if __name__ == '__main__':
    a = sys.argv[1:]; which = a[0]; opt = {a[i][2:]: a[i + 1] for i in range(1, len(a) - 1, 2)}
    pz = [float(v) for v in opt.get('player', '0,-49').split(',')]
    o = dict(secs=float(opt.get('secs', 12)), every=int(opt.get('every', 15)), seed=int(opt.get('seed', 1)),
             player=(pz[0], pz[1]), player3=(pz[0], 0.0, pz[1]), index=int(opt.get('index', 1)),
             yaw=float(opt['yaw']) if 'yaw' in opt else None, speed=float(opt['speed']) if 'speed' in opt else None,
             clip=[float(v) for v in opt.get('clip', '0,0,0').split(',')])
    if 'spawn' in opt: o['spawn'] = [float(v) for v in opt['spawn'].split(',')]
    L = Log(o['every'])
    if which == 'st01': o.setdefault('spawn', [0, 0, 100]); sim_st01(o, L); L.dump()
    elif which == 'so01':
        if 'spawn' not in o:
            rng = random.Random(o['seed']); o['spawn'] = [-35 + 80 + rng.random() * 70, 0, 100 + rng.random() * 20]
        o['yaw'] = 180.0 if o['yaw'] is None else o['yaw']; sim_so01(o, L); L.dump()
    elif which == 'ss01': o['speed'] = o['speed'] or 200.0; sim_ss01(o, L); L.dump()
    elif which == 'sj01': o.setdefault('spawn', [40, 0, 30]); o['yaw'] = 0.0 if o['yaw'] is None else o['yaw']; sim_sj01(o, L); L.dump()
    elif which == 'mp01': o['clip'] = o['clip'] if 'clip' in opt else [-90, 0, 95]; sim_stack(o, L, MpMover, 'BG01', opt.get('def', 'ene_mp01l'))
    elif which == 'sh01': o['index'] = int(opt.get('index', 2)); sim_sh01(o, L)
