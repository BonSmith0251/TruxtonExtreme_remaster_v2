# Frame-stepped model of an Ene_Mc01 spawn: SplineMover route chain (route mode, EnemyData.attribute bit 16 clear)
# + route Delay events (pause) + Ene_Mc01.LocalLateUpdate fire/animation timer. Read-only study tool.
# usage: C:\Python311\python.exe -I mc01_sim.py <BG0x.json> <definition name> [--every 15] [--secs 30]
import sys, json, math, struct
DT = 1 / 60
FireTime, AnimationTime, AnimationLoopTime, NoDamageTime, NoDamageDuration = 0.4, 0.75, 0.75, 1.2, 0.4
def f32(x): return struct.unpack('<f', struct.pack('<f', x))[0]                # _currentRate is a float (as ../tools/m7_sim.py)
def cosf(deg): return math.cos(math.radians(int(deg * 10) % 3600 / 10))     # VectorUtility.Cosf 0x1DF6FA0, 0.1 deg table
def ease(kind, u):                                   # EasingUtility.Easing01 (only the kinds used here)
    if kind == 7:                                    # InOutSine01 0x1DE86F0 through the Cosf table
        return (1 - cosf(2 * u * 90)) * .5 if u < .5 else 1 - (1 - cosf(2 * (1 - u) * 90)) * .5
    if kind == 0: return u
    raise SystemExit('easing %d not modelled' % kind)
def sample(r, u):                                    # [I] EvalCachedPosition ~ piecewise-linear over knot times
    ts, ps = r['times'], r['points']
    if u <= ts[0]: return [ps[0][k] for k in 'xyz']
    if u >= ts[-1]: return [ps[-1][k] for k in 'xyz']
    i = max(j for j in range(len(ts)) if ts[j] <= u); j = min(i + 1, len(ts) - 1)
    f = (u - ts[i]) / max(1e-6, ts[j] - ts[i]); return [ps[i][k] + (ps[j][k] - ps[i][k]) * f for k in 'xyz']
def main():
    a = sys.argv[1:]; o = {a[i][2:]: a[i + 1] for i in range(2, len(a) - 1, 2)}
    j = json.load(open(a[0], encoding='utf-8-sig')); d = next(x for x in j['definitions'] if x['name'] == a[1])
    R = {r['name']: r for r in j['routes']}
    for r in R.values(): r['length'] = sum(math.dist([p[k] for k in 'xyz'], [q[k] for k in 'xyz']) for p, q in zip(r['points'], r['points'][1:]))
    pl = d['placements'][0]; speed = pl['moveSpeed']; easing = pl['easeType']
    routes = [R[n] for n in d['routes']]; evs = sorted(d['events'], key=lambda e: e['awakeRate'])
    every = int(o.get('every', 15)); frames = int(float(o.get('secs', 30)) * 60)
    start = [d['position'][k] + pl['offset'][k] for k in 'xyz']           # clip offset (0,0,0) for these spawns
    pos = list(start); ri = 0; rate = 0.0; off = 0.0; last_rate = -1.0; ev_i = 0
    sp0 = sample(routes[0], 0); spc = [0, 0, 0]; pause = 0.0; timer = 0.0; t = 0.0; log = []; rows = []
    log.append('spawn %s at (%.1f, %.1f, %.1f) speed %g easing %d routes %s' % (a[1], *start, speed, easing, d['routes']))
    log.append('%6.3f anim "open" (ReStart)' % t)
    for f in range(frames):
        # ---- PawnEnemy.LocalLateUpdate -> EnemyMover.Progress -> SplineMover.Progress (route mode)
        if pause > 0:
            pause -= DT                                                     # IsPausing: _ProgressSpline returns
        else:
            r = routes[ri]; prev = off
            rate = f32(rate + DT * speed / r['length']); done = rate >= 1
            off = 1.0 if done else ease(easing, rate)
            delta = off - prev                                              # SplineMover.UpdateEvent
            lo, hi = prev + ri, prev + ri + delta
            if delta > 0 and last_rate < hi:
                last_rate = hi
                while ev_i < len(evs) and not (hi <= evs[ev_i]['awakeRate']):
                    e = evs[ev_i]; ev_i += 1
                    if lo <= e['awakeRate']:
                        log.append('%6.3f route event type %d awake %g: pause %.2f s (value0 %g)' % (t, e['eventType'], e['awakeRate'], e['dotime'], e['value0']))
                        if e['eventType'] == 1 and e['dotime'] > 0: pause = e['dotime']
            p = sample(r, off); spc = [p[k] - sp0[k] for k in range(3)]
            if done:
                if ri + 1 < len(routes):
                    start = list(pos); ri += 1; rate = 0.0; off = 0.0     # _startPosition = current position
                    sp0 = sample(routes[ri], 0); spc = [0, 0, 0]           # SetSpline resets current offset
                    log.append('%6.3f route %d -> %d (%s, len %.1f, %.2f s) at (%.1f, %.1f)' % (t, ri - 1, ri, d['routes'][ri], routes[ri]['length'], routes[ri]['length'] / speed, pos[0], pos[2]))
                else:
                    log.append('%6.3f last route done -> EndRoute at (%.1f, %.1f)' % (t, pos[0], pos[2])); break
            pos = [start[k] + spc[k] for k in range(3)]                    # route matrix = identity [I]
        # ---- Ene_Mc01.LocalLateUpdate (after the mover)
        prevt = timer; timer += DT
        if prevt <= FireTime < timer: log.append('%6.3f fire mc01_fire1 (muzzle01, +0 s) + mc01_fire2 (muzzle02, +0.04 s)' % t)
        if prevt <= NoDamageTime < timer: log.append('%6.3f nodamage 0.4 s' % t)
        if prevt <= AnimationTime < timer: pass                            # anim "close"
        if prevt <= AnimationLoopTime < timer:
            timer = min(max(timer - math.floor(timer / AnimationLoopTime) * AnimationLoopTime, 0), AnimationLoopTime)
        t += DT; rows.append((t, pos[0], pos[2], ri))
    print('\n'.join(log)); print('-- (t, x, z, route index) every %d frames' % every)
    for k, row in enumerate(rows):
        if k % every == every - 1 or k == len(rows) - 1: print('  %6.3f  (%7.2f, %7.2f)  r%d' % row)
main()
