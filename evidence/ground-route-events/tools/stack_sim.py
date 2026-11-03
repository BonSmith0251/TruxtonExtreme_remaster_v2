# Frame-stepped model of the native EnemyMover event stack (EnemyData.attribute & 16) for ground enemies, written
# from the disassembly in ../SPEC.md. Yaw-only rotation, parent frame = identity. Not game code: an evidence aid.
# usage: C:\Python311\python.exe -I stack_sim.py <stage.json> <definitionName> [yawDeg] [speedOverride] [seconds]
import json, math, sys
DT = 1 / 60
ROTATE, TRANSLATE, ANIM, MOVING = 1, 4, 16, 256
ENDCHECK = 0x214
class Mover:
    def __init__(self, d, yaw, speed):
        self.ev = d['events']; self.idx = 0; self.delay = 0.0; self.finish_wait = False; self.ended = None
        self.labels = {e['stringValue']: i for i, e in enumerate(self.ev) if e['eventType'] == 5}
        self.loops = {}; self.flags = 0; self.objflags = 0; self.tasks = []
        self.pos = [0.0, 0.0, 0.0]; self.yaw = yaw; self.speed = speed; self.t = 0.0; self.log = []
    def say(self, s): self.log.append('%7.3f  %-58s pos=(%8.2f,%8.2f) yaw=%7.2f flags=%d obj=%d' % (self.t, s, self.pos[0], self.pos[2], self.yaw, self.flags, self.objflags))
    def start(self, g):  # an async task runs synchronously to its first await
        try: next(g); self.tasks.append(g)
        except StopIteration: pass
    # ---- async bodies (_execEventWithRepeat cases) -------------------------------------------------------------
    def wait_flag(self, f):
        while self.flags & f: yield
    def rotate(self, e):
        dot = e['dotime']
        if dot <= 0.001: self.yaw = e['vectorValue']['y']; return  # instant, absolute Euler
        self.flags |= ROTATE
        for _ in self.wait_secs(e['value0']): yield
        start = self.yaw; target = e['vectorValue']['y'] if e['flag0'] else start + e['vectorValue']['y']
        ease = (lambda u: -(math.cos(math.pi * u) - 1) / 2) if e['intValue1'] else (lambda u: u)
        el = 0.0
        while True:
            yield; el += DT; u = min(1, el / dot); self.yaw = start + (target - start) * ease(u)
            if u >= 1: break
        for _ in self.wait_secs(e['value1']): yield
        self.flags &= ~ROTATE
    def forward(self, e):
        for _ in self.wait_flag(MOVING): yield
        dirx, dirz = math.sin(math.radians(self.yaw)), math.cos(math.radians(self.yaw))  # snapshot at start
        left = e['dotime']; self.flags |= MOVING
        while True:  # first step happens in the start frame
            step = DT * self.speed; self.pos[0] += dirx * step; self.pos[2] += dirz * step; left -= DT
            if left <= 0: break
            yield
        self.flags &= ~MOVING
    def translate(self, e):
        for _ in self.wait_flag(TRANSLATE): yield
        v = e['vectorValue']; self.flags |= TRANSLATE
        for _ in self.wait_secs(e['value0']): yield
        start = list(self.pos); tgt = [start[0] + v['x'], start[1] + v['y'], start[2] + v['z']] if e['flag0'] else [v['x'], v['y'], v['z']]
        dur = math.dist(start, tgt) / self.speed if self.speed > 0 else 0; el = 0.0
        while dur > 0:
            yield; el += DT; u = min(1, el / dur); self.pos = [a + (b - a) * u for a, b in zip(start, tgt)]
            if u >= 1: break
        for _ in self.wait_secs(e['value1']): yield
        self.flags &= ~TRANSLATE
    def objflag(self, e, on):
        for _ in self.wait_secs(e['value0']): yield
        if on: self.objflags |= e['intValue1']
        else: self.objflags &= ~e['intValue1']
        self.say('%s obj flag %d' % ('set' if on else 'reset', e['intValue1']))
    def bullet(self, e):  # entry-area wait not modelled (assumed visible); fires repeatCount+1 times
        first = e['value1']; n = 0
        while n <= e['repeatCount']:
            w = first if n == 0 and first > 0 else (0 if n == 0 and e['repeatCount'] <= 0 else e['value0'])
            for _ in self.wait_secs(w): yield
            self.say('Bullet %s shot %d' % (e['stringValue'], n)); n += 1
            for _ in self.wait_secs(e['repeatDelay'] if n <= e['repeatCount'] else 0): yield
    def wait_secs(self, s):
        while s > 0: yield; s -= DT
    # ---- EnemyMover._execStackEvent ------------------------------------------------------------------------------
    def stack(self):
        self.delay -= DT
        if self.delay > 0 or self.finish_wait: return
        self.delay = 0
        for _ in range(1001):
            if self.idx >= len(self.ev): break
            e = self.ev[self.idx]; t = e['eventType']
            if t == 101:
                c = self.loops.setdefault(self.idx, e['intValue1']) - 1; self.loops[self.idx] = c
                if c >= 0: self.idx = self.labels.get(e['stringValue'], 0); continue
                del self.loops[self.idx]
            elif t == 1000:
                if self.flags & ENDCHECK: self.idx = len(self.ev); break
                self.ended = 'FinishDestroy'; self.say('EndRoute (FinishDestroy)'); return
            elif t == 1001: self.finish_wait = True; self.say('FinishWait: stack stops'); return
            elif t == 80:
                if self.flags & (e['intValue1'] or 0x7fffffff): return
            elif t in (1, 20):
                self.delay = e['dotime']; self.idx += 1; self.say('%s %.2f' % ('Delay' if t == 1 else 'Idle', e['dotime']))
                if self.delay > 0: return
                continue
            elif t == 5: pass
            elif t in (2, 8, 10, 11, 12, 13):
                self.say('start %d' % t)
                self.start({2: self.rotate, 8: self.bullet, 12: self.forward, 13: self.translate}[t](e) if t not in (10, 11) else self.objflag(e, t == 10))
            self.idx += 1
        if self.idx >= len(self.ev) and not self.flags & ENDCHECK and not self.ended:
            self.ended = 'events exhausted'; self.say('EndRoute (events exhausted)')
    def frame(self):
        self.stack()
        for g in list(self.tasks):
            try: next(g)
            except StopIteration: self.tasks.remove(g)
        self.t += DT
if __name__ == '__main__':
    src, name = sys.argv[1], sys.argv[2]
    d = next(x for x in json.load(open(src, encoding='utf-8-sig'))['definitions'] if x['name'] == name)
    yaw = float(sys.argv[3]) if len(sys.argv) > 3 else 0.0; speed = float(sys.argv[4]) if len(sys.argv) > 4 else d['speed']
    secs = float(sys.argv[5]) if len(sys.argv) > 5 else 12
    m = Mover(d, yaw, speed); m.say('spawn (stack starts; InAreaStart delays this in game)')
    while m.t < secs and not m.ended: m.frame()
    m.say('end of simulation')
    print('\n'.join(m.log))
