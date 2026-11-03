"""Item carriers (Pf_Item_Box01 pickup drones) for every stage, in the Round1PickupDrones format.

Source: extraction/stage-enemies/raw-stage-timelines.json (Editor/ReconstructionStageEnemyExport.cs). A carrier is an
EventEntryClip with _eventType 1 (EventEntryBehaviour._eventFire): on the stage's Main timeline, or in a wave it places
through a TLEntryClip (tl_start_ppp / tl_start_p at 0 s in every stage). Its reward is the first _drops entry (a local
table) when there is one, else _itemValue: 1000 draws the shared ItemReferenceTable at run time, other values are
ItemEffects item ids. Muted clips are skipped (tl_start_ppp mutes its three middle carriers), TLEntry game-mode masks
are kept for StoryA (2), times add up through nested TLEntry starts and time scales, offsets through _objectOffset.

Output: Assets/Resources/StageEnemies/Pickups/BGxx.json (the BG03 carrier motion constants of round1-pickup-drones.json)
and evidence/stage-enemies/pickups-validation.json, which compares BG03 with the validated round1-pickup-drones.json.
"""
import collections, json, os

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
RES = os.path.join(BASE, 'Reconstructed', 'Assets', 'Resources')
RAW = os.path.join(BASE, 'extraction', 'stage-enemies', 'raw-stage-timelines.json')
OUT = os.path.join(RES, 'StageEnemies', 'Pickups')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-enemies', 'pickups-validation.json')
STORY_A = 2
# ItemEffects item id -> Round1PickupKind (Power 0, OneUp 3, TwoUp 4, ThreeUp 5, Bonus 6, BombStock 7, SpeedUp 9,
# Black 10, Blue 11, Gold 12, Green 13, Purple 14, Red 15, Silver 16), as Round1Weapon.SourceItemKind.
KIND = {1: 3, 2: 0, 4: 9, 7: 7, 8: 6, 9: 4, 10: 5, 100: 15, 101: 13, 102: 11, 103: 14, 104: 16, 105: 12, 106: 10}


def mono(c):
    j = c['json'] if isinstance(c['json'], dict) else json.loads(c['json'])
    return j.get('MonoBehaviour', j)


def walk(clips, waves, t0, scale, offset, out, depth=0):
    for c in clips:
        if c.get('muted'):
            continue
        start = t0 + c['start'] / scale
        if c.get('clipType') == 'EventEntryClip':
            m = mono(c)
            if m.get('_eventType') != 1:
                continue
            v, drops, item = m.get('_vectorValue') or {}, m.get('_drops') or [], m.get('_itemValue', 0)
            table = not drops and item == 1000
            src = drops[0] if drops else item
            kind = 0 if table else KIND.get(src)
            if kind is None:
                out['unmapped'].append({'time': start, 'item': item, 'drops': drops})
                continue
            out['events'].append({'time': round(start, 4), 'kind': kind, 'source': c.get('name', ''), 'table': table,
                                  'offset': {'x': v.get('x', 0) + offset[0], 'y': v.get('y', 0) + offset[1], 'z': v.get('z', 0) + offset[2]},
                                  'drops': drops, 'item': item})
        elif c.get('clipType') == 'TLEntryClip' and c.get('waveGuid') in waves and depth < 8:
            m = mono(c)
            mode = m.get('_gameModeFlag', 0)
            if mode and not mode & STORY_A:
                continue
            o = m.get('_objectOffset') or {}
            ts = c.get('timeScale') or 1.0
            walk(waves[c['waveGuid']]['clips'], waves, start - c.get('clipIn', 0) / ts, scale * ts,
                 (offset[0] + o.get('x', 0), offset[1] + o.get('y', 0), offset[2] + o.get('z', 0)), out, depth + 1)


def main():
    raw = json.load(open(RAW, encoding='utf-8'))
    waves = {w['guid']: w for w in raw['waves']}
    ref = json.load(open(os.path.join(RES, 'Truxton', 'round1-pickup-drones.json'), encoding='utf-8'))
    motion = {k: v for k, v in ref.items() if k != 'events'}
    os.makedirs(OUT, exist_ok=True)
    report = {'stages': {}}
    for s in raw['stages']:
        out = {'events': [], 'unmapped': []}
        for tl in s['timelines']:
            if tl['name'].endswith('Main'):
                walk(tl['clips'], waves, 0.0, 1.0, (0.0, 0.0, 0.0), out)
        events = sorted(out['events'], key=lambda e: (e['time'], e['offset']['x']))
        data = dict(motion, events=[{k: e[k] for k in ('time', 'kind', 'source', 'offset', 'table')} for e in events])
        json.dump(data, open(os.path.join(OUT, s['stage'] + '.json'), 'w', encoding='utf-8'), indent=1, ensure_ascii=False)
        report['stages'][s['stage']] = {'carriers': len(events), 'table': sum(e['table'] for e in events),
                                        'fixed': dict(collections.Counter(e['kind'] for e in events if not e['table'])),
                                        'unmapped': out['unmapped']}
        print(s['stage'], len(events), 'carriers,', report['stages'][s['stage']]['table'], 'from the shared table, unmapped', len(out['unmapped']))
        if s['stage'] == 'BG03':
            key = lambda e: (round(e['time'], 2), e['table'], None if e['table'] else e['kind'],
                             round(e['offset']['x'], 2), round(e['offset']['y'], 2), round(e['offset']['z'], 2))
            a, b = collections.Counter(map(key, ref['events'])), collections.Counter(map(key, events))
            report['bg03_vs_validated'] = {'ref': sum(a.values()), 'mine': sum(b.values()), 'matched': sum((a & b).values()),
                                           'only_ref': [list(k) for k in (a - b)], 'only_mine': [list(k) for k in (b - a)]}
            print('BG03 vs validated table: %d/%d matched (mine %d)' % (sum((a & b).values()), sum(a.values()), sum(b.values())))
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    json.dump(report, open(VALIDATION, 'w', encoding='utf-8'), indent=1, ensure_ascii=False)


if __name__ == '__main__':
    main()
