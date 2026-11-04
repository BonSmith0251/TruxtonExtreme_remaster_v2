# Frame-stepped model of an EnemyMover in STACK mode WITH definition routes (EnemyData.attribute & 16 and routes != []):
# Pf_Ene_Sf01 (BG05 ene_sf01_5*) and Pf_Ene_Sr01 (BG06 ene_sr01_1a/1b). Spec: ./SPEC.md. Not game code: an evidence aid.
# Per LateUpdate (PawnEnemy.LocalLateUpdate 0x1D0E790 -> EnemyMover.Progress 0x1D6CB50):
#   _isInGamePlayArea from the position at the start of the frame, then _execStackEvent (events, Speed, Rotate, end rule 2),
#   then SplineMover.Progress (route mode: the ONLY position writer). Speed tasks run in EarlyUpdate, tweens/bullets in LastUpdate.
# Reuses ../../air-route-events/tools/air_sim.py (stack interpreter, tasks) and ../tools/m7_sim.py (stage loader, LUT
# lengths, Easing01 with the 0.1 deg Cosf table, drift roll). Those files are not modified.
# usage: C:\Python311\python.exe -I sf01_sim.py <case> [--secs s] [--every k] [--player x,z] [--seed n] [--json out.json] [--txt out.txt]
#   cases: sf01_5b3 (BG05, first clip 344.0 s, offset (-80,0,0))   sr01_1b (BG06, first clip 341.0 s, offset (0,0,0))
#          sf01_5a3 sf01_5b sr01_1a (extra, same rules)
import sys, os, json
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\movers\tools')
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\air-route-events\tools')
import air_sim, m7_sim
f32 = air_sim.f32; DT = air_sim.DT
CASES = {  # case: (stage, definition, first clip offset, clip time)
    'sf01_5b3': ('BG05', 'ene_sf01_5b3', (-80, 0, 0), 344.0),
    'sf01_5a3': ('BG05', 'ene_sf01_5a3', None, None),
    'sf01_5b':  ('BG05', 'ene_sf01_5b', None, None),
    'sf01_5a':  ('BG05', 'ene_sf01_5a', None, None),
    'sf01_5a2': ('BG05', 'ene_sf01_5a2', None, None),
    'sf01_5b2': ('BG05', 'ene_sf01_5b2', None, None),
    'sr01_1b':  ('BG06', 'ene_sr01_1b', (0, 0, 0), 341.0),
    'sr01_1a':  ('BG06', 'ene_sr01_1a', (0, 0, 0), 330.0),
}
def first_clip(j, d):
    cl = sorted((c for c in j['events'] if c.get('enemy') == d['id']), key=lambda c: c.get('start', c.get('time', 0)))
    if not cl: return (0, 0, 0), None
    c = cl[0]; o = c['offset']; return (o['x'], o['y'], o['z']), c.get('start', c.get('time'))
class StackRouteMover(air_sim.Mover):
    """air_sim.Mover (stack) + SplineMover route mode for the position (EnemyMover.Progress: stack first, then route)."""
    def __init__(s, d, spawn, yaw, speed, player, routes, names, seed):
        air_sim.Mover.__init__(s, d, spawn, yaw, speed, player, routes, seed, d['model'])
        s.names = names; s.ridx = 0; s.rate = 0.0; s.offset = 0.0; s.start_pos = list(spawn)
        s.drift = 30 <= s.look <= 32; s.roll = 0.0; s.bank = 0.0; s.entered_at = None
        s.load(0)
    def load(s, i):                                           # SetSpline via updateRouteData(0): rate 0, offset 0
        s.route = s.routes[s.names[i]]; s.len = s.route['length']; p0 = s.route['points'][0]; s.p0 = [p0[k] for k in 'xyz']
    def stack(s):                                             # EnemyMover._isExecStackEvent 0x1D6D3D0 drift branch + stack
        if s.drift and f32(s.delay - DT) > 0:                 # stack waiting on Idle/Delay: _AddDriftAngle(0, 0.2, dt)
            s.roll, s.bank = m7_sim.add_drift(s.roll, s.look, 0.0)
        air_sim.Mover.stack(s)
    def route_step(s):                                        # SplineMover._ProgressSpline 0x1D44AE0 + Progress 0x1D43DF0
        prev = s.offset
        s.rate = f32(s.rate + DT * s.speed / s.len)           # _currentRate += dt*_currentSpeed/_splineLength
        done = s.rate >= 1
        k = 1.0 if done else m7_sim.easing01(s.ease, s.rate)
        if done: s.rate = 1.0
        s.offset = k                                          # UpdateEvent (vslot 0x348) -> EnemyMover.UpdateEvent: stack mode, returns
        q = air_sim.sample(s.route, k); cur = [q[i] - s.p0[i] for i in range(3)]
        if not done and s.drift:                              # _getRotate 0x1CDC830, lookAt 30..32: drift from the eased x step
            xsub = air_sim.sample(s.route, min(1, k + (k - prev)))[0] - q[0]
            s.roll, s.bank = m7_sim.add_drift(s.roll, s.look, xsub)
        # lookAt 0 -> _splineRotate = identity: root yaw stays _firstRotate; s.yaw carries the child Rotate tween on top
        if done:
            if s.ridx + 1 < len(s.names):
                s.ridx += 1; s.start_pos = list(s.pos); s.load(s.ridx); s.rate = 0.0; s.offset = 0.0
                s.say('route %d -> %s' % (s.ridx, s.names[s.ridx])); return
            s.pos = [s.start_pos[i] + cur[i] for i in range(3)]
            s.end('route-end', 'EndRoute: last route finished (SplineMover._ProgressSpline)'); return
        s.pos = [s.start_pos[i] + cur[i] for i in range(3)]    # localPosition = _startPosition + _routeRotate(identity)*cur
    def frame(s):
        for g in list(s.speed_tasks):                         # EarlyUpdate: Speed ramps
            try: next(g)
            except StopIteration: s.speed_tasks.remove(g)
        for g in list(s.tasks):                               # LastUpdate / DOTween Manual: child Rotate tween, Bullet waits
            try: next(g)
            except StopIteration: s.tasks.remove(g)
        s.in_play = air_sim.in_rect(s.pos, air_sim.GAME_AREA)  # LocalLateUpdate: IsInGameAreaWorld(pos, Small)
        if s.in_play and s.entered_at is None: s.entered_at = s.t; s.say('first frame inside gameScreenArea')
        s.stack()                                             # EnemyMover.Progress: _execStackEvent first
        if not s.ended: s.route_step()                        # then SplineMover.Progress (IsSplineRoute); EndRoute -> moverState 3 stops it
        s.t = f32(s.t + DT)
        row = (s.t, *s.pos, s.yaw % 360, s.speed) + ((round(s.bank, 2),) if s.drift else ())
        s.track.append(row)
def run(case, o):
    bg, name, clip, ctime = CASES[case]
    j, routes = m7_sim.stage(bg); d = next(x for x in j['definitions'] if x['name'] == name)
    if clip is None: clip, ctime = first_clip(j, d)
    m7_sim.add_lut(routes, d['routes'])
    pl = d['placements'][0]; spawn = m7_sim.spawn_of(d, clip)
    player = tuple(float(v) for v in o.get('player', '0,-49').split(','))
    m = StackRouteMover(d, spawn, pl['rotate']['y'], f32(pl['moveSpeed']), player, routes, d['routes'], int(o.get('seed', 1)))
    m.say('spawn %s %s clip %s @%s s: attribute %d, routes %s (len %.2f), speed %g, easeType %d, lookAt %d' % (
        bg, name, clip, ctime, d['attribute'], d['routes'], m.len, pl['moveSpeed'], pl['easeType'], pl['lookAt']))
    m.say('stack events: ' + ', '.join(str(e['eventType']) for e in d['events']))
    frames = int(round(float(o.get('secs', 20)) * 60))
    while len(m.track) < frames and not m.ended: m.frame()
    if not m.ended: m.say('end of simulation')
    return m
if __name__ == '__main__':
    sys.stdout.reconfigure(encoding='utf-8')
    a = sys.argv[1:]; case = a[0]; o = {a[i][2:]: a[i + 1] for i in range(1, len(a) - 1, 2)}
    m = run(case, o); every = int(o.get('every', 15))
    out = list(m.log) + ['-- track (t, x, y, z, yaw = root+child visual yaw, speed%s) every %d frames' % (', bank roll deg' if m.drift else '', every)]
    for k, row in enumerate(m.track):
        if k % every == every - 1 or k == len(m.track) - 1: out.append('    ' + str(tuple(round(v, 3 if i == 0 else 2) for i, v in enumerate(row))))
    print('\n'.join(out))
    if 'txt' in o: open(o['txt'], 'w', encoding='utf-8').write('\n'.join(out) + '\n')
    if 'json' in o:
        json.dump({'case': case, 'end': m.ended or '', 'frames': len(m.track), 'track': [[round(v, 4) for v in r] for r in m.track]},
                  open(o['json'], 'w'), indent=None)
