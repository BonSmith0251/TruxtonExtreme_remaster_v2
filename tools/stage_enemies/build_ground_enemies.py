"""Ground-enemy data for every stage, in the Round1GroundEnemies format (round1-ground-enemies.json).

Input: Assets/Resources/StageEnemies/BGxx.json (build_stage_enemies.py; ground = EnemyEntryClips on the stage's BGxx_ge
timeline) and Resources/StageCombat/enemy-database.json (decoded EnemyDatabase: HP, score, lock-on, laser blocking,
item drops). Output: Assets/Resources/StageEnemies/Ground/BGxx.json, one per stage with ground entries, plus
evidence/stage-enemies/ground-validation.json.

Validation: BG03 is compared with the old validated table (Resources/Truxton/round1-ground-enemies.json, which BG03 keeps
using). Clips must match on start, enemy, offset, rotate and delay; definitions on every field. Clip end times differ
where the old table ran past the BG03_ge timeline end (400 s); the schedule ends them with the timeline, which is what
the old table's own recording note says ("the 250-400 s batch ends at 399.99 s").
Bosses on a ge timeline (Ene_Bos08A) are left to the stage boss.
"""
import collections, json, os

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
RES = os.path.join(BASE, 'Reconstructed', 'Assets', 'Resources')
OUT = os.path.join(RES, 'StageEnemies', 'Ground')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-enemies', 'ground-validation.json')
HANDLED = {1, 2, 5, 8, 9, 13, 80, 83, 101}  # event types Round1GroundEnemies runs


def load(p):
    return json.load(open(p, encoding='utf-8'))


def is_item(model):
    return 'ColorBox' in model or 'Item_Box' in model


def build(stage, db):
    data = load(os.path.join(RES, 'StageEnemies', stage + '.json'))
    defs = {d['id']: d for d in data['definitions']}
    clips, used = [], {}
    for e in data['events']:
        if not e.get('ground'):
            continue
        d = defs[e['enemy']]
        if d['model'].startswith('Pf_Ene_Bos'):
            continue
        clips.append({'start': e['start'], 'duration': round(e['end'] - e['start'], 5), 'enemy': d['name'], 'index': 0,
                      'offset': e['offset'], 'rotate': e['rotate'], 'delay': e.get('startDelay', 0.0), 'source': e['id']})
        used[d['name']] = d
    definitions, missing, types = [], [], collections.Counter()
    for name, d in sorted(used.items()):
        row = db.get(d['model'])
        if row is None:
            missing.append(d['model'])
        item = (row or {}).get('item') or {}
        speed = d['placements'][0]['moveSpeed'] if d.get('placements') else 0.0
        for a in d.get('events') or []:
            types[a['eventType']] += 1
        definitions.append({'name': name, 'model': d['model'], 'attribute': d['attribute'], 'duration': d['duration'],
                            'item': is_item(d['model']), 'health': float((row or {}).get('health') or 500),
                            'lockOn': bool((row or {}).get('lockOn', True)), 'laserBlock': bool((row or {}).get('blocksLaser', True)),
                            'score': int((row or {}).get('score') or 0), 'drop': int(item.get('drop') or 0),
                            'swapDrop': int(item.get('swapDrop') or 0), 'speed': speed, 'events': d.get('events') or []})
    out = {'version': 1, 'stage': stage, 'timeline': stage + '_ge', 'frame': 'stage-world', 'clips': clips, 'definitions': definitions}
    return out, missing, types


def compare_bg03(mine):
    ref = load(os.path.join(RES, 'Truxton', 'round1-ground-enemies.json'))
    R = lambda v: (round(v['x'], 2), round(v['y'], 2), round(v['z'], 2))
    key = lambda c: (round(c.get('start', 0), 3), c['enemy'], R(c['offset']), R(c['rotate']), round(c.get('delay', 0), 3))
    a, b = collections.Counter(map(key, ref['clips'])), collections.Counter(map(key, mine['clips']))
    ends = collections.Counter((round(c.get('start', 0), 1), round(c['duration'], 1)) for c in ref['clips'])
    mends = collections.Counter((round(c['start'], 1), round(c['duration'], 1)) for c in mine['clips'])
    rd = {d['name']: d for d in ref['definitions']}
    fields = ['model', 'attribute', 'duration', 'item', 'health', 'lockOn', 'laserBlock', 'score', 'drop', 'swapDrop', 'speed']
    diffs = [(d['name'], f, rd[d['name']][f], d[f]) for d in mine['definitions'] if d['name'] in rd for f in fields if rd[d['name']][f] != d[f]]
    ev = sum(1 for d in mine['definitions'] if d['name'] in rd and d['events'] == rd[d['name']]['events'])
    return {'clips_ref': sum(a.values()), 'clips_mine': sum(b.values()), 'clips_matched': sum((a & b).values()),
            'clip_windows_ref': {str(k): v for k, v in ends.items()}, 'clip_windows_mine': {str(k): v for k, v in mends.items()},
            'clip_windows_exact': sum((ends & mends).values()),
            'definitions_ref': len(rd), 'definitions_mine': len(mine['definitions']), 'definition_field_diffs': diffs,
            'definition_events_equal': ev}


def main():
    db = {m['model']: m for m in load(os.path.join(RES, 'StageCombat', 'enemy-database.json'))['models']}
    os.makedirs(OUT, exist_ok=True)
    report = {'stages': {}}
    for i in range(1, 9):
        stage = 'BG%02d' % i
        out, missing, types = build(stage, db)
        if not out['clips']:
            report['stages'][stage] = {'clips': 0}
            continue
        json.dump(out, open(os.path.join(OUT, stage + '.json'), 'w', encoding='utf-8'), indent=1)
        report['stages'][stage] = {'clips': len(out['clips']), 'definitions': len(out['definitions']),
                                   'models': dict(collections.Counter(d['model'] for d in out['definitions'])),
                                   'missing_database': sorted(set(missing)),
                                   'event_types': {str(k): v for k, v in sorted(types.items())},
                                   'unhandled_event_types': sorted(k for k in types if k not in HANDLED)}
        if stage == 'BG03':
            report['bg03_vs_validated_table'] = compare_bg03(out)
        print(stage, report['stages'][stage]['clips'], 'clips', len(out['definitions']), 'definitions',
              'missing', sorted(set(missing)), 'unhandled', report['stages'][stage]['unhandled_event_types'])
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    json.dump(report, open(VALIDATION, 'w', encoding='utf-8'), indent=1)
    v = report.get('bg03_vs_validated_table')
    if v:
        print('BG03 clips %d/%d, windows exact %d, definition diffs %d, events equal %d/%d' % (
            v['clips_matched'], v['clips_ref'], v['clip_windows_exact'], len(v['definition_field_diffs']),
            v['definition_events_equal'], v['definitions_ref']))
        for d in v['definition_field_diffs'][:10]:
            print('  diff', d)


if __name__ == '__main__':
    main()
