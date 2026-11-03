# Frame-stepped model of the native EnemyMover event stack (EnemyData.attribute & 16) for AIR enemies, written from
# the disassembly cited in ../SPEC.md. Sky plane: x right, z up the screen, y toward the camera (camera (0,400,0),
# 20 deg vertical FOV, 16:9). Yaw about +Y: 0 = +Z (up the screen), 90 = +X (right). Not game code: an evidence aid.
# Ported 1:1 to Reconstructed/Assets/Truxton/Round1EventStack.cs (checked by Assets/Editor/ReconstructionEventStackCheck.cs):
# keep the two in step. Randomness: XorShift32 below (same sequence in C#). Counters are float32 like the native ones.
# usage: C:\Python311\python.exe -I air_sim.py <stage.json> <definitionName> [--clip x,y,z] [--yaw deg] [--speed v]
#        [--player x,z] [--secs s] [--seed n] [--every k] [--json out.json]
import json, math, os, sys, struct
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]   # native float32 counters
DT = f32(1 / 60)
ROTATE, ROTATET, TRANSLATE, ANIM, SPEED, MOVING, HORMING, DIRECTION = 1, 2, 4, 16, 32, 256, 512, 1024
ENDCHECK = 0x214
TAN10 = math.tan(math.radians(10)); ASPECT = 16 / 9
class XorShift32:                                                 # shared deterministic RNG, [0,1) with 24-bit steps
    def __init__(s, seed):
        s.x = ((seed & 0xFFFFFFFF) ^ 0x9E3779B9) or 0x6D2B79F5
    def u(s):
        x = s.x; x ^= (x << 13) & 0xFFFFFFFF; x ^= x >> 17; x ^= (x << 5) & 0xFFFFFFFF; s.x = x
        return (x >> 8) / 16777216.0
    def range(s, a, b): return a + (b - a) * s.u()
def view_h(y): return 2 * (400 - y) * TAN10                      # visible height at altitude y
def viewport(p): h = view_h(p[1]); return (.5 + p[0] / (h * ASPECT), .5 + p[2] / h)
def in_rect(p, r):                                                # Rect(x,y,w,h), as IsGameArea / IsInGameAreaWorld
    v = viewport(p); return r[0] <= v[0] < r[0] + r[2] and r[1] <= v[1] < r[1] + r[3]
GAME_AREA = (-.15, -.15, 1.3, 1.3); BULLET_AREA = (-.15, -.05, 1.3, 1.1)
def norm180(a): return (a + 180) % 360 - 180
def mround(v, m):                                                 # VectorUtility.MultipleRound (half away from 0)
    return math.floor(v / m + .5) * m if v >= 0 else math.ceil(v / m - .5) * m
def plane_yaw(dx, dz): return math.degrees(math.atan2(dx, dz)) % 360 if dx * dx + dz * dz >= .01 else 0.0
def tsin(deg): return math.sin(math.radians(int(deg * 10) % 3600 / 10))   # VectorUtility.Sinf/Cosf: 0.1 deg table
def tcos(deg): return math.cos(math.radians(int(deg * 10) % 3600 / 10))
def homing_dir(cur, aim, s, c):                                   # VectorUtility.HomingDirection (4-arg)
    l = math.hypot(*aim); t = (aim[0] / l, aim[1] / l) if l > 1e-5 else (0.0, 0.0)
    a = (c * cur[0] - s * cur[1], s * cur[0] + c * cur[1]); b = (c * cur[0] + s * cur[1], -s * cur[0] + c * cur[1])
    dot = lambda u, v: u[0] * v[0] + u[1] * v[1]
    if dot(t, cur) >= dot(a, cur): return t
    da, db = dot(a, aim), dot(b, aim)                             # aim straight behind: a/b tie; native float noise decides,
    return a if da >= db or abs(da - db) <= 1e-4 * l else b       # here a near-tie (1e-4 relative) picks a, like the C# port
EASE = {0: lambda u: u, 3: lambda u: 3 * u * u - 2 * u * u * u, 7: lambda u: -(math.cos(math.pi * u) - 1) / 2}
def ease(kind, u): return EASE.get(kind, EASE[0])(u)
class Mover:
    def __init__(s, d, spawn, yaw, speed, player, routes, seed, model):
        s.d = d; s.ev = d['events']; s.idx = 0; s.delay = 0.0; s.finish_wait = False; s.ended = None
        s.labels = {}
        for i, e in enumerate(s.ev):
            if e['eventType'] == 5: s.labels.setdefault(e['stringValue'], i)   # EnemyData.Coordinate keeps the first
        s.loops = {}; s.flags = 0; s.obj = 0; s.tasks = []; s.speed_tasks = []
        s.pos = list(spawn); s.yaw = yaw; s.speed = speed; s.player = player; s.routes = routes
        s.rng = XorShift32(seed); s.model = model
        pl = d['placements'][0] if d['placements'] else {'lookAt': 0, 'easeType': 0}
        s.look = pl['lookAt']; s.ease = pl['easeType']; s.first_yaw = yaw; s.next_ease = -1; s.next_look = 0; s.next_look_yaw = 0.0
        s.entered = False; s.in_play = False; s.paused = False; s.move_type = 0; s.t = 0.0; s.log = []; s.track = []
        s.sg_done = False; s.sm = None
    def say(s, m): s.log.append('%7.3f  %-52s pos=(%8.2f,%7.2f,%8.2f) yaw=%7.2f v=%6.2f flags=%d' % (s.t, m, *s.pos, s.yaw % 360, s.speed, s.flags))
    def end(s, reason, msg): s.ended = reason; s.say(msg)
    def start(s, g, lst=None):
        try: next(g); (s.tasks if lst is None else lst).append(g)
        except StopIteration: pass
    def wait_flag(s, f):
        while s.flags & f: yield
    def wait_secs(s, t):
        t = f32(t)
        while t > 0: yield; t = f32(t - DT)
    # ---- tasks -------------------------------------------------------------------------------------------------
    def tween_yaw(s, amount, dur, kind, flag, pre=0.0, post=0.0):    # DOTween relative yaw, Manual update
        s.flags |= flag
        yield from s.wait_secs(pre)
        start = s.yaw; el = 0.0; dur = f32(dur)
        while True:
            yield; el = f32(el + DT); done = el >= dur; s.yaw = start + amount * ease(kind, 1.0 if done else el / dur)
            if done: break
        yield from s.wait_secs(post)
        s.flags &= ~flag
    def rotate(s, e):                                                 # 2 Rotate (local), as the ground spec
        v = e['vectorValue']['y']
        if e['dotime'] <= .001: s.yaw = v; return
        amount = (v - s.yaw) if e['flag0'] else v
        yield from s.tween_yaw(amount, e['dotime'], 7 if e['intValue1'] else 0, ROTATE, e['value0'], e['value1'])
    def rotate_t(s, e):                                               # 3 RotateT -> DelayRotate(ev, target)
        yield from s.wait_flag(ROTATET)
        dx, dz = s.player[0] - s.pos[0], s.player[1] - s.pos[2]
        yt = plane_yaw(dx, dz); q = e['intValue1']
        if q > 0: yt = mround(yt, q)
        dot, rate = e['dotime'], e['value1']
        if dot <= .001 and rate <= 0:
            s.yaw = yt; s.say('RotateT instant -> %.1f' % yt); return   # world rotation = Euler(0, yt, 0)
        cur = s.yaw % 360
        if q > 0: cur = mround(cur, q)
        delta = norm180(yt - cur)
        if abs(delta) < 1e-3: delta = 0.0                             # already facing: float noise must not pick the spin sign
        rot = delta + e['vectorValue']['y']
        dur = dot
        if rate > 0:
            ang = math.sqrt(e['vectorValue']['x'] ** 2 + rot ** 2 + e['vectorValue']['z'] ** 2)
            if ang < 180 and e['flag0']:
                rot = rot + 360 if rot <= 0 else rot - 360; ang = 360 - ang
            dur = ang / rate
        if dur <= 0: return
        s.say('RotateT %+.1f deg over %.3f s (target yaw %.1f)' % (rot, dur, yt))
        yield from s.tween_yaw(rot, dur, 0, ROTATET, e['value0'], 0.0)
    def move(s, flag):                                                # _moveTypeUpdateAsync
        s.flags |= flag
        while True:
            if s.paused: yield; continue                              # SplineMover.IsPlaying false (Delay pause)
            gp = list(s.pos); step = DT * s.speed; done = False
            if s.move_type in (2, 4):
                s.pos[0] += s.mv[0] * step; s.pos[2] += s.mv[1] * step; s.ldur = f32(s.ldur - DT); done = s.ldur <= 0
            elif s.move_type in (3, 5):
                s.acc += s.mv0
                aim = (s.player[0] - gp[0], s.player[1] - gp[2])
                if aim[0] ** 2 + aim[1] ** 2 >= s.near2:
                    while s.acc >= s.mv0 and s.mv0 > 0:
                        s.acc -= s.mv0; s.mv = homing_dir(s.mv, aim, tsin(s.mv0), tcos(s.mv0)); s.face()
                else: s.acc = 0.0
                s.pos[0] += s.mv[0] * step; s.pos[2] += s.mv[1] * step; s.ldur = f32(s.ldur - DT); s.hdur = f32(s.hdur - DT)
                if s.hdur <= 0 or s.mv0 <= 0:
                    s.mv = homing_dir(s.mv, aim, tsin(s.acc), tcos(s.acc)); s.face()
                    done = s.ldur <= 0; s.move_type = 4; s.say('Horming ends (HormingMoveEnd)')
            elif s.move_type == 6:
                if step > 0:
                    r = s.routes[s.route]; s.ldur = f32(s.ldur + f32(step)); u = min(1.0, s.ldur / r['length'])
                    k = ease(s.ease, u); p = sample(r, k)
                    s.pos = [s.root[i] + p[i] for i in range(3)]
                    if u >= 1: done = True
                    elif s.look == 1: s.yaw = plane_yaw(*tangent(r, k))
            inside = in_rect(gp, GAME_AREA)                               # Small/Medium enemy: IsGameArea
            if s.entered:
                if not inside and s.move_type in (2, 3, 4):
                    s.end('area-exit', 'EndRoute (left gameScreenArea after entering)'); return
            else: s.entered = inside
            if done: break
            yield
        s.move_type = 999; s.flags &= ~flag
    def face(s):                                                      # updateHormingDirection
        if s.look == 0: s.yaw = s.first_yaw
        elif s.look == 1: s.yaw = plane_yaw(*s.mv)
    def forward(s, e):                                                # 12 ForwardMove
        yield from s.wait_flag(MOVING)
        s.move_type = 2; a = math.radians(s.yaw); sgn = -1 if s.look == 2 else 1
        s.mv = (sgn * math.sin(a), sgn * math.cos(a)); s.ldur = f32(e['dotime'])
        yield from s.move(MOVING)
    def direction(s, e):                                              # 7 Direction: raw vectorValue, not normalised
        yield from s.wait_flag(DIRECTION)
        s.move_type = 2; s.mv = (e['vectorValue']['x'], e['vectorValue']['z']); s.ldur = f32(e['dotime'])
        yield from s.move(DIRECTION)
    def horming(s, e):                                                # 6 Horming
        yield from s.wait_flag(MOVING | HORMING)
        s.move_type = 5 if e['flag0'] else 3
        if in_rect(s.pos, GAME_AREA):                                 # gameScreenAreas[0]: keep current facing
            a = math.radians(s.yaw); s.mv = (math.sin(a), math.cos(a))
        else:
            v = e['vectorValue']; l = math.hypot(v['x'], v['y'], v['z'])
            s.mv = (v['x'] / l, v['z'] / l) if l > 1e-5 else (0.0, 0.0)
        s.face()
        s.mv0 = e['value0'] + s.rng.u() * e['randomFire']; s.hdur = f32(e['value1'])
        s.near2 = e['intValue1'] ** 2; s.ldur = f32(e['dotime']); s.acc = s.mv0 if e['dotime'] < 1 else 0.0
        s.say('Horming turn %.1f deg/frame, %.2f s, near %d' % (s.mv0, s.hdur, e['intValue1']))
        yield from s.move(HORMING)
    def spline(s, e):                                                 # 15 SplineMove
        if e['stringValue'] not in s.routes: return
        yield from s.wait_flag(MOVING)
        if s.next_look == 0: s.first_yaw = s.yaw                     # SetRotate(localRotation, 0)
        else: s.look = s.next_look; s.yaw = s.first_yaw = s.next_look_yaw; s.next_look = 0
        if s.next_ease != -1: s.ease = s.next_ease; s.next_ease = -1
        s.route = e['stringValue']; s.move_type = 6; s.ldur = 0.0; s.root = list(s.pos)
        yield from s.move(MOVING)
    def translate(s, e):                                              # 13 Translate (ground spec), parent-local
        yield from s.wait_flag(TRANSLATE)
        v = [e['vectorValue'][k] for k in 'xyz']
        if abs(s.speed) < 1e-5: s.pos = v; return
        dist = math.sqrt(sum(c * c for c in v)) if e['flag0'] else math.dist(s.pos, v)
        dur = f32(dist / s.speed); s.flags |= TRANSLATE
        yield from s.wait_secs(e['value0'])
        start = list(s.pos); tgt = [start[i] + v[i] for i in range(3)] if e['flag0'] else v; el = 0.0
        while dur > 0:
            yield; el = f32(el + DT); done = el >= dur; u = 1.0 if done else el / dur
            s.pos = [start[i] + (tgt[i] - start[i]) * u for i in range(3)]
            if done: break
        yield from s.wait_secs(e['value1'])
        s.flags &= ~TRANSLATE
    def speed_task(s, e):                                             # 14 Speed (dotime > 0): linear, EarlyUpdate
        yield from s.wait_flag(SPEED)
        tt = f32(min(max(e['dotime'], 0), 100)); tp = 0.0; b = s.speed; r = e['value0']; s.flags |= SPEED
        while tt > tp:
            tp = f32(tp + DT); s.speed = b + (r - b) * min(1.0, tp / tt); yield
        s.flags &= ~SPEED
    def speed_now(s, e):
        yield from s.wait_flag(SPEED)
        s.speed = e['value0']
    def objflag(s, e, on):
        yield from s.wait_secs(e['value0'])
        s.obj = s.obj | e['intValue1'] if on else s.obj & ~e['intValue1']
    def play_pause(s, start, sec):                                    # _delayPlayPause: pause the mover for sec
        yield from s.wait_secs(start)
        s.paused = True
        yield from s.wait_secs(sec)
        s.paused = False
    def bullet(s, e):                                                 # log only; no effect on motion
        while not in_rect(s.pos, BULLET_AREA): yield
        first = e['value1']; n = 0
        while n <= e['repeatCount']:
            w = first if n == 0 and first > 0 else (0 if n == 0 and e['repeatCount'] <= 0 else e['value0'])
            yield from s.wait_secs(w)
            s.say('Bullet %s shot %d' % (e['stringValue'], n)); n += 1
            yield from s.wait_secs(e['repeatDelay'] if n <= e['repeatCount'] else 0)
    def rotate_r(s, e):                                               # 84 RotateR: instant random local offset
        v = e['vectorValue']; s.rng.range(-v['x'], v['x']); dy = s.rng.range(-v['y'], v['y']); s.rng.range(-v['z'], v['z'])
        s.yaw += dy; s.say('RotateR -> %.2f' % (s.yaw % 360))
    # ---- EnemyMover._execStackEvent ---------------------------------------------------------------------------
    def stack(s):
        s.delay = f32(s.delay - DT)
        if s.delay > 0 or s.finish_wait: return
        s.delay = 0
        for _ in range(1001):
            if s.idx >= len(s.ev): break
            e = s.ev[s.idx]; t = e['eventType']
            if t == 101:
                c = s.loops.setdefault(s.idx, e['intValue1']) - 1; s.loops[s.idx] = c
                if c >= 0: s.idx = s.labels.get(e['stringValue'], 0); continue
                del s.loops[s.idx]
            elif t == 100:
                if not (e['intValue1'] >= 100 or e['intValue1'] > int(s.rng.u() * 100)):
                    s.idx = s.labels.get(e['stringValue'], 0); continue
            elif t == 1000:
                if s.flags & ENDCHECK: s.idx = len(s.ev); break
                s.end('finish-destroy', 'EndRoute (FinishDestroy)'); return
            elif t == 1001: s.finish_wait = True; s.say('FinishWait: stack stops'); return
            elif t == 81: s.flags = s.flags & ~e['intValue1'] if e['intValue1'] else 0
            elif t == 80:
                if s.flags & (e['intValue1'] or 0x7fffffff): return
            elif t in (1, 20):
                delay = f32(e['dotime'])
                if e['flag0'] and e['value0'] < 0: delay = f32(delay + e['value0'])   # _wakeAfterSecond = 0 [I]
                s.idx += 1
                if t == 1 and delay > 0 and e['value0'] > 0: s.start(s.play_pause(e['value0'], delay)); delay = 0.0
                s.delay = delay; s.say('%s %.2f' % ('Delay' if t == 1 else 'Idle', e['dotime']))
                if delay > 0: return
                continue
            elif t == 16:
                if 0 <= e['intValue1'] <= 12: s.next_ease = e['intValue1']
            elif t == 19:
                if e['intValue1'] in (0, 1, 2, 3, 4, 5, 6, 7, 20, 30, 31, 32):
                    s.next_look = e['intValue1']; s.next_look_yaw = e['vectorValue']['y']
            elif t in (4, 5, 9, 17, 18, 21, 82, 83): pass             # no-op here (see Round1EventStack.cs)
            else:
                body = {2: s.rotate, 3: s.rotate_t, 6: s.horming, 7: s.direction, 8: s.bullet, 12: s.forward,
                        13: s.translate, 15: s.spline, 84: s.rotate_r}.get(t)
                if t == 14: s.start(s.speed_task(e) if e['dotime'] > 0 else s.speed_now(e), s.speed_tasks)
                elif t in (10, 11): s.start(s.objflag(e, t == 10))
                elif body:
                    s.say('start %d' % t); r = body(e)
                    if r is not None: s.start(r)
            s.idx += 1
        if s.idx >= len(s.ev) and not s.flags & ENDCHECK and not s.in_play and not s.ended:
            s.end('events-exhausted', 'EndRoute (events exhausted, not in play area)')
    # ---- Ene_Sg01.Progress / Ene_Sm01._progressMove ------------------------------------------------------------
    def pawn(s):
        if s.model == 'Pf_Ene_Sg01':
            if s.move_type in (3, 5):
                px = 1080 / view_h(0)                                     # [I] _ScreenSize.y = 1080
                dist = int(math.hypot(s.pos[0] - s.player[0], s.pos[2] - s.player[1]) * px)
                s.speed = min(max(dist, 50), 600) / 600 * 60 + 10; s.sg_done = True
            elif s.move_type == 2 and s.sg_done and s.speed < 20: s.speed = 20
        if s.model == 'Pf_Ene_Sm01' and not s.ended:
            if s.sm is None:
                sign = 1 if s.rng.u() < .5 else -1
                a = math.radians(sign * 135 + 90 + s.rng.range(-15, 15))
                s.sm = {'d': [math.cos(a) * s.speed, math.sin(a) * s.speed], 'st': 0.0, 'life': 0.0, 'state': 1}
            m = s.sm
            if m['state'] == 1:
                if s.entered: m['state'] = 2
                else:
                    m['st'] = f32(m['st'] + DT)
                    if m['st'] >= 5: s.end('sm01-not-entered', 'Ene_Sm01: never entered in 5 s'); return
            elif m['state'] == 2:
                v = viewport(s.pos); m['life'] = f32(m['life'] + DT)
                if m['life'] < 10:
                    if (v[1] >= 1 and m['d'][1] > 0) or (v[1] <= 0 and m['d'][1] < 0): m['d'][1] = -m['d'][1]
                    if (v[0] >= 1 and m['d'][0] > 0) or (v[0] <= 0 and m['d'][0] < 0): m['d'][0] = -m['d'][0]
                if not s.in_play: s.end('sm01-left-play-area', 'Ene_Sm01: left play area'); return
            s.pos[0] += m['d'][0] * DT; s.pos[2] += m['d'][1] * DT
    def frame(s):
        for g in list(s.speed_tasks):                                     # EarlyUpdate
            try: next(g)
            except StopIteration: s.speed_tasks.remove(g)
        s.pawn()
        for g in list(s.tasks):                                           # LastUpdate (moves, tweens) [I]
            if s.ended: break
            try: next(g)
            except StopIteration: s.tasks.remove(g)
        if s.model == 'Pf_Ene_Sm01' and not s.entered: s.entered = in_rect(s.pos, GAME_AREA)
        s.in_play = in_rect(s.pos, GAME_AREA)                             # PawnEnemy.LocalLateUpdate (Small)
        if not s.ended and not s.paused: s.stack()                       # LateUpdate (EnemyMover.Progress: IsPlaying)
        s.t += DT; s.track.append((s.t, s.pos[0], s.pos[1], s.pos[2], s.yaw % 360, s.speed))
def sample(r, u):
    ts, ps = r['times'], r['points']
    if u <= ts[0]: return [ps[0][k] for k in 'xyz']
    if u >= 1: return [ps[-1][k] for k in 'xyz']
    i = max(j for j in range(len(ts)) if ts[j] <= u); j = min(i + 1, len(ts) - 1)
    f = (u - ts[i]) / max(1e-6, ts[j] - ts[i]); return [ps[i][k] + (ps[j][k] - ps[i][k]) * f for k in 'xyz']
def tangent(r, u):
    a, b = sample(r, max(0, u - .01)), sample(r, min(1, u + .01)); return (b[0] - a[0], b[2] - a[2])
if __name__ == '__main__':
    a = sys.argv[1:]; src, name = a[0], a[1]
    opt = {a[i][2:]: a[i + 1] for i in range(2, len(a) - 1, 2)}
    j = json.load(open(src, encoding='utf-8-sig'))
    d = next(x for x in j['definitions'] if x['name'] == name)
    routes = {}
    for r in j['routes']:
        r['length'] = f32(sum(math.dist([p[k] for k in 'xyz'], [q[k] for k in 'xyz']) for p, q in zip(r['points'], r['points'][1:])))
        routes[r['name']] = r
    clip = [float(v) for v in opt.get('clip', '0,0,0').split(',')]
    pl = d['placements'][0]; seed = int(opt.get('seed', 1))
    yaw = float(opt.get('yaw', pl['rotate']['y']))
    spawn = [d['position'][k] + clip[i] + pl['offset'][k] for i, k in enumerate('xyz')]
    speed = float(opt['speed']) if 'speed' in opt else f32(min(max(pl['moveSpeed'] + XorShift32(seed + 1).u() * pl['_moveSpeedRange'], .0001), 999))
    player = tuple(float(v) for v in opt.get('player', '0,-49').split(','))
    frames = int(round(float(opt.get('secs', 12)) * 60)); every = int(opt.get('every', 15))
    model = pl['objectName'] or d['model']
    m = Mover(d, spawn, yaw, speed, player, routes, seed, model); m.say('spawn (model %s, player %s)' % (model, player))
    while len(m.track) < frames and not m.ended: m.frame()
    m.say('end of simulation' if not m.ended else 'ENDED: ' + m.ended)
    print('\n'.join(m.log)); print('-- track (t, x, y, z, yaw, speed) every %d frames' % every)
    for k, row in enumerate(m.track):
        if k % every == every - 1 or k == len(m.track) - 1: print('   ', tuple(round(v, 4 if i == 0 else 2) for i, v in enumerate(row)))
    if 'json' in opt:                                                 # machine-readable track for the Unity check
        out = {'stage': os.path.splitext(os.path.basename(src))[0], 'definition': name, 'model': model,
               'spawn': spawn, 'yaw0': yaw, 'speed': speed, 'player': [player[0], 0.0, player[1]], 'seed': seed,
               'maxFrames': frames, 'frames': len(m.track), 'endReason': m.ended or '', 'endFrame': len(m.track) if m.ended else -1,
               'flag0': [1 if e['flag0'] else 0 for e in d['events']],
               'x': [round(r[1], 5) for r in m.track], 'y': [round(r[2], 5) for r in m.track],
               'z': [round(r[3], 5) for r in m.track], 'yaws': [round(r[4], 5) for r in m.track]}
        json.dump(out, open(opt['json'], 'w', encoding='utf-8'), indent=None)
