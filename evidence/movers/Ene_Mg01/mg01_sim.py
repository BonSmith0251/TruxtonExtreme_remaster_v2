# Frame-stepped model of Ene_Mg01 (CustomMove 0x1DC5D70) on top of its stack program (SplineMove + TaskWait 256).
# Evidence aid, not game code. Sky plane: x right, z up the screen, yaw 0 = +Z. 60 fps, float32 timers.
# usage: C:\Python311\python.exe -I mg01_sim.py [BG04.json] [definition] [--player x,z] [--off ox,oz] [--secs s]
import sys, json, math
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\air-route-events\tools')
from air_sim import f32, DT, in_rect, GAME_AREA, plane_yaw, norm180
ROOT = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageEnemies'
MOVE, BRAKE, HOMING, SHOT, TURN, RETURN = 1, 2, 3, 4, 5, 6
NAMES = {1: 'Move', 2: 'Brake', 3: 'Homing', 4: 'Shot', 5: 'Turn', 6: 'Return'}
T_MOVE, T_BRAKE, T_HOME, T_SHOT, T_TURN, T_RET, T_RAPID = 3.5, .5, .5, 0.0, .5, .5, 1.0     # .cctor 0x1DC69B0
def ease_in(a, b, t): return a + (b - a) * t * t                                    # EasingUtility 0x1DE8000
def ease_out(a, b, t): return a - (b - a) * t * (t - 2)                             # 0x1DE80D0
def ease_inout(a, b, t):                                                             # 0x1DE7FA0
    t *= 2
    if t < 1: return a + (b - a) * .5 * t * t
    t -= 1; return a - (b - a) * .5 * (t * (t - 2) - 1)
def clamp01(v): return 0.0 if v < 0 else 1.0 if v > 1 else v
def slerp_yaw(a, b, t): return (a + norm180(b - a) * t) % 360                        # yaw-only Quaternion.Slerp
def main():
    a = sys.argv[1:]; pos_args = [x for i, x in enumerate(a) if not x.startswith('--') and not (i and a[i - 1].startswith('--'))]
    opt = {a[i][2:]: a[i + 1] for i in range(len(a) - 1) if a[i].startswith('--')}
    src = pos_args[0] if pos_args else ROOT + r'\BG04.json'; name = pos_args[1] if len(pos_args) > 1 else 'ene_mg01_1a'
    j = json.load(open(src, encoding='utf-8-sig')); d = next(x for x in j['definitions'] if x['name'] == name)
    pl = d['placements'][0]; route = next(r for r in j['routes'] if r['name'] == d['events'][0]['stringValue'])
    pts = [[p[k] for k in 'xyz'] for p in route['points']]; ts = route['times']
    L = f32(sum(math.dist(p, q) for p, q in zip(pts, pts[1:])))
    def sample(u):
        if u >= 1: return pts[-1]
        i = max(k for k in range(len(ts)) if ts[k] <= u); k2 = min(i + 1, len(ts) - 1)
        f = (u - ts[i]) / max(1e-6, ts[k2] - ts[i]); return [pts[i][c] + (pts[k2][c] - pts[i][c]) * f for c in range(3)]
    off = [float(v) for v in opt.get('off', '0,0').split(',')]                       # U[0,1)*_offsetRange (x, z)
    spawn = [d['position']['x'] + pl['offset']['x'] + off[0], d['position']['y'], d['position']['z'] + pl['offset']['z'] + off[1]]
    root = [spawn[c] - pts[0][c] for c in range(3)]                                  # _splineRootPosition = pos - knot0
    player = [float(v) for v in opt.get('player', '0,-49').split(',')]
    speed = base = f32(pl['moveSpeed']); dist = 0.0; pos = list(spawn)
    t0 = sample(0.002); yaw = plane_yaw(t0[0] - pts[0][0], t0[2] - pts[0][2])
    mode, timer, ftimer, target = MOVE, 0.0, 0.0, -1; byaw = tyaw = yaw; done = False; t = 0.0; log = []
    frames = int(float(opt.get('secs', 12)) * 60)
    for fr in range(frames):
        # LastUpdate: SplineMove task (moveType 6), uses the speed written by last frame's CustomMove
        step = f32(DT * speed)
        if not done and step > 0:
            dist = f32(dist + step); u = min(1.0, dist / L); p = sample(u); pos = [root[c] + p[c] for c in range(3)]
            if u >= 1: done = True
            else:
                q = sample(min(1, u + .002)); yaw = plane_yaw(q[0] - p[0], q[2] - p[2])   # lookAt 1: nose on tangent
        inplay = in_rect(pos, GAME_AREA)
        if done and not inplay:                                                      # TaskWait passes, events exhausted
            log.append('%6.3f  EndRoute (route end, outside play area) pos=(%.1f,%.1f)' % (t, pos[0], pos[2])); break
        # LateUpdate: Ene_Mg01.LocalLateUpdate -> base (mover), then CustomMove (indexValue != 0)
        prev = mode; timer = f32(timer + DT)
        if mode == MOVE:
            if timer >= T_MOVE: mode, timer = BRAKE, 0.0
        elif mode == BRAKE:
            speed = f32(base * ease_out(0, 1, clamp01(1 - timer / T_BRAKE)))
            if timer >= T_BRAKE: mode, timer, target = HOMING, 0.0, -1
        elif mode == HOMING:
            e = ease_inout(0, 1, clamp01(timer / T_HOME))
            if target < 0: target = 0; byaw = yaw
            tyaw = plane_yaw(player[0] - pos[0], player[1] - pos[2])
            yaw = slerp_yaw(byaw, tyaw, e)
            if timer >= T_HOME: mode, timer, ftimer = SHOT, 0.0, 0.0
        elif mode == SHOT:
            yaw = tyaw; ftimer = f32(ftimer - DT)
            if ftimer <= 0:
                ftimer = f32(ftimer + T_RAPID); log.append('%6.3f  FIRE mg01sp1_1way yaw=%.1f pos=(%.1f,%.1f)' % (t, yaw, pos[0], pos[2]))
            if timer >= T_SHOT: mode, timer, target = TURN, 0.0, -1
        elif mode == TURN:
            yaw = slerp_yaw(tyaw, byaw, ease_inout(0, 1, clamp01(timer / T_HOME)))
            if timer >= T_TURN: mode, timer = RETURN, 0.0
        elif mode == RETURN:
            speed = f32(base * ease_in(0, 1, clamp01(timer / T_RET)))
            if timer >= T_RET: mode, timer = MOVE, 0.0
        if mode != prev: log.append('%6.3f  %-6s -> %-6s pos=(%7.2f,%7.2f) yaw=%6.1f v=%5.2f dist=%.1f' % (t, NAMES[prev], NAMES[mode], pos[0], pos[2], yaw, speed, dist))
        t = f32(t + DT)
        if fr % 15 == 14: log.append('   t=%6.3f pos=(%7.2f,%7.2f) yaw=%6.1f v=%5.2f %s' % (t, pos[0], pos[2], yaw, speed, NAMES[mode]))
    print('Mg01 %s spawn=(%.1f,%.1f) route %s len %.2f speed %.0f player %s' % (name, spawn[0], spawn[2], route['name'], L, base, player))
    print('\n'.join(log))
main()
