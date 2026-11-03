# Frame-stepped model of the Ene_Mj01h head + 9 Ene_Mj01b bodies (LocalLateUpdate 0x1DC7590, CallMJ01Body 0x1DC7090,
# moveEndCallback 0x1DC8050, SendMessage 0x1DC7AE0, Ene_Mj01b.LocalLateUpdate 0x1DC6CD0 / SetParentKilled 0x1DC6F00).
# Head and bodies run the same spline route (definition attribute 1, routes[0]) by distance at _currentSpeed.
# Evidence aid, not game code. Sky plane: x right, z up, yaw 0 = +Z. 60 fps, float32 counters.
# Assumption [I]: bodies are updated after the head in the same LateUpdate (pool order), so a released body takes
# its first route step in the release frame, and a body detached by the head's SendMessage keeps the position it had
# at the end of the previous frame.
# usage: C:\Python311\python.exe -I mj01h_sim.py [stage.json] [definition] [--clip x,y,z] [--secs s] [--kill i@t]
import sys, json, math
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\air-route-events\tools')
from air_sim import f32, DT, in_rect, GAME_AREA, plane_yaw
ROOT = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageEnemies'
UNIT = f32(22.5); GRAV = (0.0, 0.0, -16.0); N = 9
def main():
    a = sys.argv[1:]; pa = [x for i, x in enumerate(a) if not x.startswith('--') and not (i and a[i - 1].startswith('--'))]
    opt = {a[i][2:]: a[i + 1] for i in range(len(a) - 1) if a[i].startswith('--')}
    src = pa[0] if pa else ROOT + r'\BG01.json'; name = pa[1] if len(pa) > 1 else 'ene_mj01_1a'
    j = json.load(open(src, encoding='utf-8-sig')); d = next(x for x in j['definitions'] if x['name'] == name)
    route = next(r for r in j['routes'] if r['name'] == d['routes'][0]); pl = d['placements'][0]
    pts = [[p[k] for k in 'xyz'] for p in route['points']]; ts = route['times']
    L = f32(sum(math.dist(p, q) for p, q in zip(pts, pts[1:])))
    def sample(u):
        if u >= 1: return pts[-1]
        i = max(k for k in range(len(ts)) if ts[k] <= u); k2 = min(i + 1, len(ts) - 1)
        f = (u - ts[i]) / max(1e-6, ts[k2] - ts[i]); return [pts[i][c] + (pts[k2][c] - pts[i][c]) * f for c in range(3)]
    clip = [float(v) for v in opt.get('clip', '-200,0,50').split(',')]
    start = [d['position'][k] + clip[i] + pl['offset'][k] for i, k in enumerate('xyz')]
    speed = f32(pl['moveSpeed']); kill = None
    if 'kill' in opt: ki, kt = opt['kill'].split('@'); kill = (int(ki), float(kt))
    def new(kind): return {'kind': kind, 'rate': 0.0, 'pos': list(start), 'state': 'READY', 'yaw': None}
    head = new('head'); head['state'] = 'ROUTE'; bodies = [new('body%d' % (i + 1)) for i in range(N)]
    passed, calls, brk, moveend = 0.0, 0, False, False; t = 0.0; log = []; frames = int(float(opt.get('secs', 5)) * 60)
    def route_step(e):                                                   # SplineMover._ProgressSpline 0x1D44AE0
        e['rate'] = f32(e['rate'] + f32(DT * speed / L)); done = e['rate'] >= 1
        p = sample(min(1.0, e['rate'])); e['pos'] = [start[c] + p[c] - pts[0][c] for c in range(3)]
        q = sample(min(1.0, e['rate'] + .002)); p0 = sample(max(0, e['rate'] - .002))
        if (q[0] - p0[0]) ** 2 + (q[2] - p0[2]) ** 2 > 1e-8: e['yaw'] = plane_yaw(q[0] - p0[0], q[2] - p0[2])
        return done
    def detach_all(reason):                                              # SendMessage -> SetParentKilled (state 0 only)
        for b in bodies:
            if b['state'] == 'ROUTE': b['state'] = 'WAIT'; b['stop'] = list(b['pos']); log.append('%6.3f  %s %s: stop at (%.1f,%.1f)' % (t, b['kind'], reason, b['pos'][0], b['pos'][2]))
    for fr in range(frames):
        # ---- head LateUpdate: base (route step) then own code
        if head['state'] == 'ROUTE':
            if route_step(head):
                head['state'] = 'FALL'; detach_all('head route end (SendMessage)'); moveend = True
                log.append('%6.3f  head route end at (%.1f,%.1f): sound %s, _moveEnd' % (t, head['pos'][0], head['pos'][2],
                           'bg2_ene_mj01_head_stop_r_01' if head['pos'][0] >= 0 else 'bg2_ene_mj01_head_stop_l_01'))
        if head['state'] == 'FALL':
            if in_rect(head['pos'], GAME_AREA): head['pos'][2] += GRAV[2] * DT
            else: head['state'] = 'GONE'; log.append('%6.3f  head CallDisabled (left play area) at (%.1f,%.1f)' % (t, head['pos'][0], head['pos'][2]))
        elif head['state'] == 'ROUTE' and not brk and calls < N:          # CallMJ01Body inlined
            passed = f32(passed + f32(DT * speed))
            if passed >= UNIT:
                b = bodies[calls]; b['state'] = 'ROUTE'; passed = f32(passed - UNIT); calls += 1
                log.append('%6.3f  release %s (head at x=%.2f, carry %.3f)' % (t, b['kind'], head['pos'][0], passed))
        # ---- body kill (ReceiveKill): bodies behind -> SetParentKilled / READY ones CallDisabled; no more releases
        if kill and abs(t - kill[1]) < DT / 2:
            k = kill[0] - 1; bodies[k]['state'] = 'GONE'; brk = True; log.append('%6.3f  body%d killed -> _breakChildren' % (t, k + 1))
            for b in bodies[k + 1:]:
                if b['state'] == 'READY': b['state'] = 'GONE'
                elif b['state'] == 'ROUTE': b['state'] = 'WAIT'; b['stop'] = list(b['pos'])
        # ---- bodies LateUpdate (own code before base)
        for b in bodies:
            if b['state'] == 'WAIT': b['state'] = 'AWAY'                   # one frame without motion
            elif b['state'] == 'AWAY':
                b['stop'][2] += GRAV[2] * DT; b['pos'] = list(b['stop'])
                if not b['inplay']: b['state'] = 'GONE'; log.append('%6.3f  %s ProgressDisable/CallDisabled at (%.1f,%.1f)' % (t, b['kind'], b['pos'][0], b['pos'][2]))
            if b['state'] == 'ROUTE' and route_step(b): b['state'] = 'ENDED'   # never reached: head ends first
            b['inplay'] = in_rect(b['pos'], GAME_AREA)
        t = f32(t + DT)
        if fr % 30 == 29:
            row = ' '.join('%s(%6.1f,%5.1f)' % ({'ROUTE': 'r', 'WAIT': 'w', 'AWAY': 'a', 'READY': '-', 'GONE': 'x', 'ENDED': 'e', 'FALL': 'f'}[e['state']], e['pos'][0], e['pos'][2])
                           for e in [head] + bodies if e['state'] not in ('READY', 'GONE'))
            log.append('   t=%5.2f  %s' % (t, row))
        if head['state'] == 'GONE' and all(b['state'] in ('GONE', 'READY') for b in bodies): log.append('%6.3f  all gone' % t); break
    print('Mj01h %s start=(%.1f,%.1f) route %s len %.2f speed %.0f yaw %.1f (lookAt %d)' % (name, start[0], start[2], route['name'], L, speed, head['yaw'] or 0, pl['lookAt']))
    print('\n'.join(log))
main()
