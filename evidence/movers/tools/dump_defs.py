# Dump stage definitions + spawn clips for given model substrings (read-only).
# usage: C:\Python311\python.exe -I dump_defs.py <modelSubstr> [...]
import json, glob, sys
ROOT = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageEnemies'
EVN = {0:'None',1:'Delay',2:'Rotate',3:'RotateT',4:'Scale',5:'Label',6:'Horming',7:'Direction',8:'Bullet',9:'Animation',10:'SetObjFlag',
       11:'ResetObjFlag',12:'ForwardMove',13:'Translate',14:'Speed',15:'SplineMove',16:'Easing',17:'CustomEvent',18:'GravityFM',19:'LookAt',
       20:'Idle',21:'Parts',80:'TaskWait',81:'TaskClear',82:'TaskCancel',83:'BSelector',84:'RotateR',100:'Goto',101:'Loop',1000:'FinishDestroy',1001:'FinishWait'}
def short(e):
    keys = ['value0','value1','dotime','intValue1','intValue2','intValue3','randomFire','randomWait','repeatCount','repeatDelay','awakeRate']
    s = ' '.join('%s=%g' % (k, e[k]) for k in keys if e.get(k))
    v = e['vectorValue']
    if any(v.values()): s += ' vec=(%g,%g,%g)' % (v['x'], v['y'], v['z'])
    for k in ('stringValue','nameValue','subnameValue'):
        if e.get(k): s += ' %s=%r' % (k, e[k])
    if e.get('flag0'): s += ' flag0'
    if e.get('rpidf'): s += ' rpidf'
    return '%4d %-13s %s' % (e['eventType'], EVN.get(e['eventType'], '?'), s)
subs = sys.argv[1:]
for f in sorted(glob.glob(ROOT + r'\BG0?.json')):
    d = json.load(open(f, encoding='utf-8-sig')); bg = f[-9:-5]
    defs = {x['id']: x for x in d['definitions']}
    for x in d['definitions']:
        if not any(s in x.get('model', '') for s in subs): continue
        print('=' * 100); print(bg, x['name'], x['model'], 'id', x['id'], 'attr', x['attribute'], 'dur', x['duration'], 'pos', tuple(x['position'].values()))
        for k, v in x.items():
            if k not in ('id','name','model','attribute','duration','position','placements','events','repeats'): print('  ', k, '=', json.dumps(v)[:400])
        for p in x['placements']: print('  placement', json.dumps(p))
        if x['repeats']: print('  repeats', json.dumps(x['repeats'])[:600])
        for e in x['events']: print('   ', short(e))
        for c in d['events']:
            if c.get('enemy') == x['id']:
                print('  SPAWN %-8s t=%.3f-%.3f off=(%g,%g,%g) rot=(%g,%g,%g) idx=%s loop=%s/%s outDestroy=%s ground=%s offsets=%s grp=%s' % (
                    c['source'], c['start'], c['end'], *c['offset'].values(), *c['rotate'].values(), c['indexValue'], c['loop'], c['loopMax'],
                    c['outMeansDestroy'], c['ground'], c['offsets'][:4], c['group']))
    if any(s.startswith('route:') for s in subs):
        for r in d['routes']:
            if any(s[6:] in r['name'] for s in subs if s.startswith('route:')):
                print('ROUTE', bg, r['name'], 'n', len(r['points']), 'times', r['times'][:3], '...', 'p0', r['points'][0], 'pN', r['points'][-1])
