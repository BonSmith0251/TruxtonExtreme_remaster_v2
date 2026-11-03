# Frame-stepped models for the classes Ene_Sq01, Ene_Mb01, Ene_Mp02, Ene_Mf01, Ene_Mx02, Ene_Mi01, Ene_X01 (read-only study;
# spec: ../<Class>/SPEC.md). Not game code: an evidence aid.
#  - Stack mode (EnemyData.attribute & 16, no routes): ../../air-route-events/tools/air_sim.py Mover, with the program that the
#    class's CreateRouteData installs (Sq01/Mb01: decoded from the .cctor by cctor_programs.py) and the extra spline routes read
#    from Assets/OriginalRecovered/InGame/RouteLUT (lut_routes.py), because the stage JSON only carries routes named by definitions.
#  - Route mode (SplineMover._ProgressSpline 0x1D44AE0 + SplineMover.Progress 0x1D43DF0 + SplineMover.UpdateEvent 0x1D44720):
#    implemented here (RouteMover), for Mp02 (routes chosen by Ene_Mp02.CreateRouteData), Mx02 and X01 (definition routes).
# Sky plane: x right, z up the screen, y toward the camera; yaw about +Y, 0 = up the screen. 60 fps, float32 counters.
# usage: C:\Python311\python.exe -I m7_sim.py <case> [--secs s] [--every k] [--player x,z] [--seed n] [--json out.json]
#   cases: sq01 sq01r mb01 mp02a mp02b mx02 x01 mi01 mf01
import sys, json, math, os, struct
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\air-route-events\tools')
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import air_sim, lut_routes
f32 = air_sim.f32; DT = air_sim.DT
STAGES = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageEnemies'
def stage(bg):
    j = json.load(open(os.path.join(STAGES, bg + '.json'), encoding='utf-8-sig'))
    routes = {r['name']: r for r in j['routes']}
    return j, routes
def add_lut(routes, names):
    for n in names:
        if n not in routes: routes[n] = lut_routes.load(n)
    for r in routes.values():
        r['length'] = f32(sum(math.dist([p[k] for k in 'xyz'], [q[k] for k in 'xyz']) for p, q in zip(r['points'], r['points'][1:])))
def cosf(deg): return math.cos(math.radians(int(deg * 10) % 3600 / 10))     # VectorUtility.Cosf 0x1DF6FA0, 0.1 deg table
def easing01(kind, t):                                                        # EasingUtility.Easing01 0x1DE8100
    if kind == 7:                                                             # InOutSine01 0x1DE86F0 (Cosf table)
        return (1 - cosf(2 * t * 90)) * .5 if t < .5 else 1 - (1 - cosf(2 * (1 - t) * 90)) * .5
    return air_sim.ease(kind, t)
# ---- RouteEvent factory defaults (RouteEvent::Xxx static methods, see cctor_programs.FACT) -----------------------------
def EV(t, **kw):
    e = {'eventType': t, 'repeatCount': 0, 'repeatDelay': 0.0, 'awakeRate': 0.0, 'value0': 0.0, 'value1': 0.0,
         'vectorValue': {'x': 0.0, 'y': 0.0, 'z': 0.0}, 'stringValue': '', 'intValue1': 0, 'intValue2': 0, 'intValue3': 0,
         'dotime': 0.0, 'randomFire': 0.0, 'randomWait': 0.0, 'nameValue': '', 'subnameValue': '', 'flag0': False, 'rpidf': False}
    e.update(kw); return e
SPL = lambda r: EV(15, stringValue=r); TW = lambda m: EV(80, intValue1=m); LBL = lambda n: EV(5, stringValue=n)
LOOP = lambda n, c: EV(101, stringValue=n, intValue1=c); IDLE = lambda t: EV(20, dotime=t); SPD = lambda v, t: EV(14, value0=v, dotime=t)
BSEL = lambda n: EV(83, stringValue=n, nameValue='pf_ene_sq01/ene_sq/muzzle', flag0=True)
DELAY = lambda t: EV(1, dotime=t); BUL = lambda n, h: EV(8, stringValue=n, nameValue=h)
ROT = lambda dt, v, ab, ez: EV(2, dotime=dt, vectorValue={'x': v[0], 'y': v[1], 'z': v[2]}, flag0=ab, intValue1=ez)
# Ene_Sq01 .cctor 0x1D043A0: _routeEventLists[0..3]; laser1/laser2 = BSelector fire1/fire2, stop1/stop2 = Idle 0.1 / 2.
def sq01_program(i):
    if i in (0, 1):
        a, b = ('move_sq01_r', 'move_sq01_l') if i == 0 else ('move_sq01_l', 'move_sq01_r')
        return [SPL('common_D50'), TW(256), LBL('LP1'), IDLE(.1), BSEL('sq01_fire1_sel'), SPL(a), TW(256), IDLE(.1),
                BSEL('sq01_fire1_sel'), SPL(b), TW(256), LOOP('LP1', 2), SPD(60, 0), IDLE(.1), SPL('common_D150'), TW(256)]
    r = 'move_sq01_dl' if i == 2 else 'move_sq01_dr'
    return [SPL(r), SPD(20, 3), TW(32), BSEL('sq01_fire2_sel'), IDLE(2), SPD(60, .5), TW(256)]
# Ene_Mb01 .cctor 0x1DBFB80: _routeEventLists[0] (list[1] is replaced by list[0] in CreateRouteData 0x1DBF1C0).
def mb01_program():
    p = [ROT(0, (0, 180, 0), True, 0), SPL('common_D50'), TW(256), SPD(10, 1), SPL('common_D200')]
    for k in range(4):
        p += [ROT(1, (0, 0, -180), False, 1)]
        if k < 3: p += [TW(1), DELAY(.1), BUL('mb01_fire1', 'fire1A'), BUL('mb01_fire2', 'fire2A'), BUL('mb01_fire3', 'fire3A'),
                        DELAY(.5), BUL('mb01_fire4', 'fire4A'), DELAY(.5)]
    return p + [EV(10, intValue1=256), SPD(50, 1), TW(256), EV(1000)]
# Ene_Mp02 prefab _routeNames (CreateRouteData 0x1CFD8C0 picks _routeNames[_indexValue].arrays)
MP02_ROUTES = [['common_D150', 'common_L300'], ['common_D150', 'common_R300'], ['common_R150', 'common_U200'], ['common_L150', 'common_U200']]

# InGameEnemyMoveBase._AddDriftAngle 0x1CDB930 with the static arrays from the .cctor 0x1CDBD00 (index lookAt-30):
DRIFT_ARCS, DRIFT_SPEED, DRIFT_BACK = (45, 30, 20), (3, 2, 1), (180, 90, 45)
def add_drift(roll, look, xsub, nlimit=.2, dt=DT):
    k = look - 30; g = xsub * DRIFT_SPEED[k]
    if abs(g) < nlimit:                                       # return toward 0 at DriftBackSpeed deg-units/s
        back = dt * DRIFT_BACK[k]
        roll = 0.0 if back >= abs(roll) else (roll - back if roll > 0 else roll + back)
    else:
        roll += g * 2 if g * roll < 0 else g * .25            # reversing: x2, continuing: x0.25
    roll = min(max(roll, -100), 100)
    return roll, roll / 100 * DRIFT_ARCS[k]                   # Euler z (deg) composed as _firstRotate * Euler(0,0,z)
class DriftMover(air_sim.Mover):
    """air_sim.Mover plus the drift roll of lookAt 30..32 (SplineMove per-frame _getRotate 0x1CDC830, stack waits)."""
    roll = 0.0; bank = 0.0
    def frame(s):
        air_sim.Mover.frame(s)
        if 30 <= s.look <= 32:
            if s.move_type == 6:
                r = s.routes[s.route]; L = r['length']; step = DT * s.speed
                r1 = min(1, s.ldur / L); r0 = min(1, max(0, (s.ldur - step) / L)); k = air_sim.ease(s.ease, r1)
                xsub = air_sim.sample(r, min(1, k + (r1 - r0)))[0] - air_sim.sample(r, k)[0]
            else: xsub = 0.0                                  # [I] no spline: _isExecStackEvent waits call it with 0
            s.roll, s.bank = add_drift(s.roll, s.look, xsub)
        t = s.track[-1]; s.track[-1] = t + (round(s.bank, 2),)
class RouteMover:
    """SplineMover route mode: routes played one after another by eased rate, events fired by awakeRate."""
    def __init__(s, d, spawn, yaw, speed, routes, names, ease, look, player, seed, stack=False):
        s.d = d; s.routes = routes; s.names = names; s.ease = ease; s.look = look; s.pos = list(spawn); s.yaw = yaw
        s.first_yaw = yaw; s.speed = speed; s.player = player; s.t = 0.0; s.log = []; s.track = []; s.ended = None
        s.idx = 0; s.rate = 0.0; s.offset = 0.0; s.start = list(spawn); s.cur = [0.0, 0.0, 0.0]; s.last_rate = 0.0; s.ev_i = 0
        s.speed_tasks = []; s.flags = 0
        # SplineMover.SetEventData 0x1D44240 (route mode): Rotate/Scale/Translate with dotime 0 and awakeRate 0 run at once,
        # the rest go through InsertEventSorted 0x1D43BE0 (ascending awakeRate) [I: stable for equal awakeRate].
        # In stack mode (attribute & 16) EnemyMover.UpdateEvent 0x1D6CDB0 returns at once: the events belong to the stack.
        s.events = [] if stack else sorted([e for e in d['events'] if not (e['eventType'] in (2, 4, 13) and e['dotime'] == 0 and e['awakeRate'] == 0)],
                          key=lambda e: e['awakeRate'])
        s.load(0)
    def say(s, m): s.log.append('%7.3f  %-58s pos=(%8.2f,%7.2f,%8.2f) yaw=%7.2f v=%6.2f' % (s.t, m, *s.pos, s.yaw % 360, s.speed))
    def load(s, i):
        s.route = s.routes[s.names[i]]; s.len = s.route['length']
        p0 = s.route['points'][0]; s.p0 = [p0[k] for k in 'xyz']; s.cur = [0.0, 0.0, 0.0]
    def speed_task(s, e):                                     # 14 Speed: same as air_sim (EarlyUpdate, first step at once)
        while s.flags & 32: yield
        if e['dotime'] <= 0: s.speed = e['value0']; return
        s.flags |= 32; tt = min(max(f32(e['dotime']), 0), 100); tp = 0.0; b = s.speed; r = e['value0']
        while tt > tp:
            tp = f32(tp + DT); s.speed = f32(b + (r - b) * min(1, tp / tt)); yield
        s.flags &= ~32
    def exec_event(s, e):                                     # ExecEvent (vslot 0x2C8): only what changes motion is modelled
        t = e['eventType']
        if t == 14:
            g = s.speed_task(e)
            try: next(g); s.speed_tasks.append(g)
            except StopIteration: pass
        s.say('event %d %s awake=%.2f%s' % (t, {14: 'Speed', 8: 'Bullet', 2: 'Rotate(child)', 10: 'SetObjFlag'}.get(t, ''), e['awakeRate'],
              (' -> %.1f over %.2f s' % (e['value0'], e['dotime'])) if t == 14 else (' ' + e['stringValue'] if t == 8 else '')))
    def update_event(s, prev, delta):                         # SplineMover.UpdateEvent 0x1D44720
        if not s.events or delta <= 0: return
        r0 = s.idx + prev; r1 = r0 + delta
        if s.last_rate >= r1: return
        s.last_rate = r1
        while s.ev_i < len(s.events):
            a = s.events[s.ev_i]['awakeRate']
            if r0 > a: s.ev_i += 1; continue                    # already passed: skipped for good
            if r1 <= a: break
            s.exec_event(s.events[s.ev_i]); s.ev_i += 1
    def sample(s, u): return air_sim.sample(s.route, u)
    def frame(s):
        for g in list(s.speed_tasks):                         # EarlyUpdate
            try: next(g)
            except StopIteration: s.speed_tasks.remove(g)
        # ---- SplineMover._ProgressSpline (dt) ----
        prev = s.offset
        if s.len > 0: s.rate = f32(s.rate + DT * s.speed / s.len)
        done = s.rate >= 1
        if done: s.rate = 1.0; k = 1.0
        else: k = easing01(s.ease, s.rate)
        s.offset = k
        s.update_event(prev, k - prev)
        q = s.sample(s.offset); s.cur = [q[i] - s.p0[i] for i in range(3)]
        if done:
            if s.idx + 1 < len(s.names):
                s.idx += 1; s.start = list(s.pos)               # _startPosition = localPosition (still last frame's)
                s.load(s.idx); s.rate = 0.0; s.offset = 0.0   # updateRouteData(0) 0x1D452D0: dt zeroed on the done frame (0x1D44BF7, 0x1D44E22; Ene_Mc01/SPEC.md sec. 3)
                s.say('route %d -> %s (len %.1f)' % (s.idx, s.names[s.idx], s.len))
            else:
                s.ended = 'route-end'; s.say('EndRoute: last route finished'); s.t = f32(s.t + DT); return
        # ---- SplineMover.Progress: pos = _startPosition + _routeRotate(identity [I]) * _splineCurrentPosition ----
        s.pos = [s.start[i] + s.cur[i] for i in range(3)]
        if s.look == 1:                                        # [I] nose along the eased path (lookAt Forward)
            a = s.sample(min(1, s.offset + .01)); b = s.sample(max(0, s.offset - .01))
            if (a[0] - b[0]) ** 2 + (a[2] - b[2]) ** 2 > 1e-8: s.yaw = math.degrees(math.atan2(a[0] - b[0], a[2] - b[2])) % 360
        s.t = f32(s.t + DT); s.track.append((s.t, *s.pos, s.yaw % 360, s.speed))

def placement(d): return d['placements'][0]
def spawn_of(d, clip): pl = placement(d); return [d['position'][k] + clip[i] + pl['offset'][k] for i, k in enumerate('xyz')]
def run(case, o):
    player = tuple(float(v) for v in o.get('player', '0,-49').split(','))
    seed = int(o.get('seed', 1)); secs = float(o.get('secs', 12))
    if case in ('sq01', 'sq01r', 'mb01', 'mi01', 'mf01'):
        bg, name, clip, index = {'sq01': ('BG06', 'ene_sq01', (20, 0, 0), 2), 'sq01r': ('BG06', 'ene_sq01', (-20, 0, 0), 3),
                                 'mb01': ('BG06', 'ene_mb01', (-50, 0, 0), 0), 'mi01': ('BG04', 'ene_mi01_1a', (0, 0, 0), 0),
                                 'mf01': ('BG07', 'ene_mf01_5a1', (0, 0, 0), 0)}[case]
        j, routes = stage(bg); d = dict(next(x for x in j['definitions'] if x['name'] == name))
        if case.startswith('sq01'): d['events'] = sq01_program(index)
        if case == 'mb01': d['events'] = mb01_program()
        add_lut(routes, [e['stringValue'] for e in d['events'] if e['eventType'] == 15])
        pl = placement(d); sp = spawn_of(d, clip)
        m = DriftMover(d, sp, pl['rotate']['y'], f32(pl['moveSpeed']), player, routes, seed, d['model'])
        m.say('spawn %s %s clip %s index %d (lookAt %d, easeType %d)' % (bg, name, clip, index, pl['lookAt'], pl['easeType']))
        frames = int(round(secs * 60))
        while len(m.track) < frames and not m.ended: m.frame()
        m.say('ENDED: ' + m.ended if m.ended else 'end of simulation')
        return m
    bg, name, clip, names = {'mp02a': ('BG01', 'ene_mp02a', (-220, 0, 0), MP02_ROUTES[2]), 'mp02b': ('BG01', 'ene_mp02b', (40, 0, 150), MP02_ROUTES[1]),
                             'mx02': ('BG08', 'ene_mx02_1a', (0, 0, 0), None), 'x01': ('BG01', 'ene_x01', (0, 0, 0), None)}[case]
    j, routes = stage(bg); d = next(x for x in j['definitions'] if x['name'] == name)
    names = names or d['routes']; add_lut(routes, names)
    pl = placement(d); sp = spawn_of(d, clip)
    stack = (d['attribute'] & 16) != 0
    m = RouteMover(d, sp, pl['rotate']['y'], f32(pl['moveSpeed']), routes, names, pl['easeType'], pl['lookAt'], player, seed, stack)
    if stack: m.say('stack mode + routes: the stack only fires (%s); SplineMover.Progress moves it' % ', '.join(str(e['eventType']) for e in d['events']))
    m.say('spawn %s %s clip %s routes %s (lookAt %d, easeType %d, speed %g)' % (bg, name, clip, names, pl['lookAt'], pl['easeType'], pl['moveSpeed']))
    frames = int(round(secs * 60))
    while len(m.track) < frames and not m.ended: m.frame()
    if not m.ended: m.say('end of simulation')
    return m
if __name__ == '__main__':
    a = sys.argv[1:]; case = a[0]; o = {a[i][2:]: a[i + 1] for i in range(1, len(a) - 1, 2)}
    m = run(case, o); every = int(o.get('every', 15))
    print('\n'.join(m.log)); print('-- track (t, x, y, z, yaw, speed[, bank roll deg]) every %d frames' % every)
    for k, row in enumerate(m.track):
        if k % every == every - 1 or k == len(m.track) - 1: print('   ', tuple(round(v, 3 if i == 0 else 2) for i, v in enumerate(row)))
    if 'json' in o:
        json.dump({'case': case, 'end': m.ended or '', 'frames': len(m.track), 'track': [[round(v, 4) for v in r] for r in m.track]},
                  open(o['json'], 'w'), indent=None)
