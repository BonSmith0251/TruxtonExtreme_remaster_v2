# Offline model of the ported movers (same rules as Round1EventStack route mode / SplineMove and Round1EnemyWaves.SnakeBones).
# usage: python -I native_movers_sim.py <StageEnemies dir> <out dir>
import json, math, os, sys
from PIL import Image, ImageDraw

src, out = sys.argv[1], sys.argv[2]
DT = 1 / 60
H = 2 * 400 * math.tan(math.radians(10))  # visible height at y=0 (141.06)
W = H * 16 / 9
def load(st): return json.load(open(os.path.join(src, st + '.json'), encoding='utf-8-sig'))
def rlen(r):
    p = r['points']; return sum(math.dist([p[i][k] for k in 'xz'], [p[i + 1][k] for k in 'xz']) for i in range(len(p) - 1))
def sample(r, u):
    ts, ps = r['times'], r['points']
    if u <= ts[0]: return (ps[0]['x'], ps[0]['z'])
    if u >= 1: return (ps[-1]['x'], ps[-1]['z'])
    lo, hi = 0, len(ts) - 1
    while hi - lo > 1:
        m = (lo + hi) // 2
        if ts[m] <= u: lo = m
        else: hi = m
    f = (u - ts[lo]) / max(1e-6, ts[hi] - ts[lo])
    return (ps[lo]['x'] + (ps[hi]['x'] - ps[lo]['x']) * f, ps[lo]['z'] + (ps[hi]['z'] - ps[lo]['z']) * f)
def on_screen(p): return abs(p[0]) <= W / 2 and abs(p[1]) <= H / 2

def lb01(st):
    d = load(st); R = {r['name']: r for r in d['routes']}
    df = [x for x in d['definitions'] if x['model'] == 'Pf_Ene_Lb01'][0]
    rows = []
    for e in [e for e in d['events'] if e['enemy'] == df['id']]:
        name = 'move_lb01_%02d' % min(14, max(0, e['indexValue'])); r = R[name]; L = rlen(r)
        o = (e['offset']['x'] + df['position']['x'], e['offset']['z'] + df['position']['z']); p0 = sample(r, 0)
        rate, f, frames = 0, 0, []
        while True:
            rate += DT * 40 / L
            if rate >= 1: break
            hp = sample(r, rate)
            head = (o[0] + hp[0] - p0[0], o[1] + hp[1] - p0[1])
            bones = []
            for i in range(8):
                u = min(1, max(0, rate - (14.5 + 26 * i) / L)); bp = sample(r, u)
                bones.append((head[0] + bp[0] - hp[0], head[1] + bp[1] - hp[1]))
            frames.append((head, bones)); f += 1
        shown = [i for i, (h, b) in enumerate(frames) if on_screen(h) or any(on_screen(x) for x in b)]
        last = frames[-1]
        edge = max(abs(last[0][0]) - W / 2, abs(last[0][1]) - H / 2)
        rows.append(dict(stage=st, start=e['start'], index=e['indexValue'], route=name, length=round(L), life=round(len(frames) * DT, 2),
                         shown=(round(shown[0] * DT, 2), round(shown[-1] * DT, 2)) if shown else None,
                         head_beyond_edge=round(edge), body_on_screen_at_end=any(on_screen(x) for x in last[1]), frames=frames))
    return rows

def route_mode(st, model, first_duration_frame):
    """Non-stack event spline (Sk01, La01): rate DT/duration on frame 0, then by distance; events by eased rate."""
    d = load(st); R = {r['name']: r for r in d['routes']}; res = []
    for df in [x for x in d['definitions'] if x['model'] == model]:
        ev = sorted(df['events'], key=lambda e: e['awakeRate']); sp = [e for e in ev if e['eventType'] == 15][0]
        r = R[sp['stringValue']]; L = rlen(r); speed = df['placements'][0]['moveSpeed']
        ramps, busy, rate, prev, t, log, path, nxt = [], 0, 0, 0, 0, [], [], 0
        while rate < 1:
            # Speed tasks (EarlyUpdate): a ramp waits while another holds SpeedTask 32
            if ramps and t >= busy:
                a = ramps[0]
                if 'start' not in a: a['start'] = t; a['from'] = speed; busy = t + a['dotime']
                k = min(1, (t - a['start'] + DT) / a['dotime']) if a['dotime'] > 0 else 1
                speed = a['from'] + (a['to'] - a['from']) * k
                if k >= 1: ramps.pop(0)
            rate = df['duration'] and DT / df['duration'] if (first_duration_frame and t == 0) else rate + DT * speed / L
            k = min(rate, 1)
            while nxt < len(ev) and ev[nxt]['awakeRate'] < k:
                e = ev[nxt]; nxt += 1
                if e['eventType'] == 14: ramps.append(dict(to=e['value0'], dotime=e['dotime']))
                log.append((round(t, 3), e['eventType'], e['stringValue'] or ('speed->%g/%gs' % (e['value0'], e['dotime']) if e['eventType'] == 14 else ''), round(k, 3)))
            path.append(sample(r, k)); t += DT
        res.append(dict(name=df['name'], route=r['name'], length=round(L), life=round(t, 2), events=log, path=path,
                        offsets=[(e['offset']['x'] + df['position']['x'], e['offset']['z'] + df['position']['z']) for e in d['events'] if e['enemy'] == df['id']]))
    return res

def stack_spline(st, model):
    d = load(st); R = {r['name']: r for r in d['routes']}; res = []
    for df in [x for x in d['definitions'] if x['model'] == model]:
        sp = [e for e in df['events'] if e['eventType'] == 15][0]; r = R[sp['stringValue']]; L = rlen(r); speed = df['placements'][0]['moveSpeed']
        res.append(dict(name=df['name'], route=r['name'], length=round(L), life=round(L / speed, 2), path=[sample(r, i / 100) for i in range(101)],
                        offsets=[(e['offset']['x'] + df['position']['x'], e['offset']['z'] + df['position']['z']) for e in d['events'] if e['enemy'] == df['id']]))
    return res

def draw(title, items, fn, scale=0.9):
    S = 900; img = Image.new('RGB', (S, S), (16, 20, 28)); g = ImageDraw.Draw(img)
    c = lambda p: (S / 2 + p[0] * scale, S / 2 - p[1] * scale)
    g.rectangle([c((-W / 2, H / 2)), c((W / 2, -H / 2))], outline=(200, 200, 200))
    g.text((10, 10), title, fill=(255, 255, 255))
    for col, pts, marks in items:
        g.line([c(p) for p in pts], fill=col, width=2)
        for m in marks:
            for a, b in zip(m, m[1:]): g.line([c(a), c(b)], fill=(255, 255, 255), width=3)
            for p in m: g.ellipse([c(p)[0] - 3, c(p)[1] - 3, c(p)[0] + 3, c(p)[1] + 3], fill=col)
    img.save(os.path.join(out, fn))

os.makedirs(out, exist_ok=True)
cols = [(255, 99, 71), (100, 200, 255), (255, 210, 80), (120, 230, 120), (220, 120, 255), (255, 150, 200), (90, 255, 220), (255, 255, 140), (180, 180, 255), (255, 170, 90)]
rows = lb01('BG03') + lb01('BG08'); items = []
for i, rw in enumerate(rows):
    fr = rw['frames']; marks = [[fr[j][0]] + fr[j][1] for j in range(0, len(fr), max(1, len(fr) // 5))]
    items.append((cols[i % len(cols)], [f[0] for f in fr], marks))
    print('Lb01', {k: v for k, v in rw.items() if k != 'frames'})
draw('Lb01 native routes + EnemyMoverSnake bones (BG03 x8, BG08 x2); box = visible screen', items, 'lb01_routes.png', 0.75)
for model in ('Pf_Ene_Sk01', 'Pf_Ene_La01'):
    res = route_mode('BG02', model, True); items = []
    for i, rw in enumerate(res):
        print(model, rw['name'], rw['route'], 'len', rw['length'], 'life', rw['life'], 'spawns at', sorted(set(rw['offsets'])))
        for e in rw['events']: print('   t=%.3f type %d %s at rate %.3f' % e)
        for o in sorted(set(rw['offsets'])):
            items.append((cols[i % len(cols)], [(o[0] + p[0], o[1] + p[1]) for p in rw['path']], []))
    draw(model + ' BG02 (route mode, speed ramps)', items, model[7:].lower() + '_routes.png')
res = stack_spline('BG02', 'Pf_Ene_Mh01'); items = []
for i, rw in enumerate(res):
    print('Mh01', rw['name'], rw['route'], 'len', rw['length'], 'life', rw['life'], 'spawns at', sorted(set(rw['offsets'])))
    for o in sorted(set(rw['offsets'])): items.append((cols[i % len(cols)], [(o[0] + p[0], o[1] + p[1]) for p in rw['path']], []))
draw('Mh01 BG02 (stack SplineMove, speed 50, drift bank)', items, 'mh01_routes.png')
