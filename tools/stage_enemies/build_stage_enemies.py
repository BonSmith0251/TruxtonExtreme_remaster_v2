"""Build per-stage enemy schedules (Round1EnemyWaves.Data schema) from the raw original timeline export.

Input: extraction/stage-enemies/raw-stage-timelines.json (Editor/ReconstructionStageEnemyExport.Export).
Output: Reconstructed/Assets/Resources/StageEnemies/BGxx.json (+ a summary on stdout).

Rules (InGame.Kernel timeline layer, as reproduced and validated for BG03 by the earlier Round 1 extraction):
- Air: each TLEntryClip on the stage's mainTL instantiates its _timelinePrefab wave timeline at the clip start; wave time
  runs at the clip's timeScale and is cut at the clip end. Each EnemyEntryClip there is one event:
  start = TL start + entry start / TL timeScale, end = TL start + entry end / TL timeScale (bounded by TL end),
  offset = TL _objectOffset + entry _offset, rotate = entry _rotate, gameModeMask = TL _gameModeFlag,
  zone = TL _clipFlag & AllZone: a zone clip starts only while InGameManager's TL flag for it is set
  (TLEntryBehaviour.IsCheckStartTL 0x1D51BB0). A TL with a _conditionFlag (NoBomber 1, NoDead 2, Extinction 4, Pipil50 8)
  clears its _failedFlag|_successedFlag when it starts and sets one of them when it ends (OnBehaviourPlay 0x1D522C0 /
  OnBehaviourPause 0x1D51F50); the condition never gates the TL itself. Only BG08 uses this: ZONE A -> B (failed) / C
  (succeeded) -> D / E -> F / G. Those TLs are listed in 'zones'. wipeoutOnly is only for EnemyWaveClip bonus spawns.
- Ground: EnemyEntryClips directly on the stage's BGxx_ge timeline, flagged ground.
- Definitions come from EnemyData (objectName, routeNames, durationTime, startPosition, placements, events, repeats);
  routes from RouteLUT (_t, _positions, _tangents), plus the routes a model's prefab lists in its own _routeNames
  (Pf_Ene_Lb01: the pawn picks one by the clip's indexValue).
usage: build_stage_enemies.py <reconstruction root> [--compare-bg03 <round1-enemy-waves.json>]
"""
import collections, json, os, sys

root = sys.argv[1]
raw = json.load(open(os.path.join(root, 'extraction', 'stage-enemies', 'raw-stage-timelines.json'), encoding='utf-8'))
out_dir = os.path.join(root, 'Reconstructed', 'Assets', 'Resources', 'StageEnemies')
waves = {w['guid']: w for w in raw['waves']}
mono = lambda j: json.loads(j)['MonoBehaviour']
enemy_data = {e['guid']: mono(e['json']) for e in raw['enemyData']}
enemy_by_name = {d['m_Name']: g for g, d in enemy_data.items()}
routes = {}
for r in raw['routes']:
    m = mono(r['json'])
    routes[m['_routeName'] or m['m_Name']] = {'name': m['_routeName'] or m['m_Name'], 'source': r['guid'],
                                              'times': m['_t'], 'points': m['_positions'], 'tangents': m['_tangents']}
def prefab_route_names(model):
    """A pawn prefab's own _routeNames (Ene_Lb01.CreateRouteData 0x1DBCC90 replaces the definition's routes with
    _routeNames[_indexValue]); empty when the prefab has none."""
    path = os.path.join(root, 'Reconstructed', 'Assets', 'OriginalGame', model + '.prefab')
    if not model or not os.path.exists(path):
        return []
    names, inside = [], False
    for line in open(path, encoding='utf-8'):
        if line.startswith('  _routeNames:'):
            inside = True
        elif inside and line.startswith('  - '):
            names.append(line[4:].strip())
        elif inside:
            break
    return names
V0 = {'x': 0.0, 'y': 0.0, 'z': 0.0}
ALL_ZONE = 0x3FFC00  # TLEntryClip.TLClipFlag ZoneA..ZoneL
add = lambda a, b: {k: a.get(k, 0) + b.get(k, 0) for k in 'xyz'}

def guid_of(ref):
    return ref.get('guid') if isinstance(ref, dict) else None

ACTION_INTS = {'eventType', 'repeatCount', 'intValue1', 'intValue2', 'intValue3', 'flag0', 'rpidf'}


def event(stage, group, tl_start, tl_end, ts, entry, base_offset, mode, wipe, ground, zone=0):
    m = mono(entry['json'])
    g = guid_of(m.get('_enemyData'))
    if not g or g not in enemy_data:
        g = enemy_by_name.get(m.get('_enemyDataName') or '')  # ground entries name their data instead
    if not g or g not in enemy_data:
        return None
    start = tl_start + entry['start'] / ts
    end = min(tl_end, tl_start + (entry['start'] + entry['duration']) / ts)
    return {'id': '%s/%s:%.4f' % (group, enemy_data[g]['m_Name'], start), 'source': entry['asset'], 'group': group,
            'start': round(start, 6), 'end': round(end, 6), 'enemy': g, 'gameModeMask': mode, 'wipeoutOnly': wipe, 'zone': zone,
            'offset': add(base_offset, m.get('_offset', V0)), 'rotate': m.get('_rotate', V0),
            'loop': bool(m.get('_isLoopWave')), 'loopMax': m.get('_loopWaveMax', 0), 'startDelay': m.get('_StartDelaySecond', 0.0),
            'loopDelay': m.get('_LoopDelaySecond', 0.0), 'offsets': m.get('_offsetTables', []) or [],
            'outMeansDestroy': bool(m.get('_isOutMeanDestroy')), 'timeScale': ts, 'indexValue': m.get('_indexValue', 0),
            'ground': ground or bool(m.get('_isGround')), 'groundSky': bool(m.get('_isGroundSky')), 'ruin': m.get('_ruinObject', '')}

def wave_events(stage, wave_guid, group, s, e, ts, offset, mode, wipe, depth, events, zone=0):
    """A wave timeline instantiated at stage time s (cut at e), running at ts. Nested TLEntry clips spawn sub-waves."""
    if depth > 8:
        return
    for c in waves[wave_guid]['clips']:
        if c.get('muted'):
            continue
        if c['clipType'] == 'EnemyEntryClip':
            ev = event(stage, group, s, e, ts, c, offset, mode, wipe, False, zone)
            if ev:
                events.append(ev)
        elif c['clipType'] == 'EnemyWaveClip':
            # Bonus spawn: EnemyData named by _enemyDataName at _ePos/_eRot, only when the wave was wiped out.
            m = mono(c['json'])
            name = m.get('_enemyDataName') or ''
            g = enemy_by_name.get(name)
            if not g:
                continue
            start = s + c['start'] / ts
            if start >= e:
                continue
            events.append({'id': '%s/bonus/%s:%.4f' % (group, name, start), 'source': c['asset'], 'group': group,
                           'start': round(start, 6), 'end': round(min(e, s + (c['start'] + c['duration']) / ts), 6), 'enemy': g,
                           'gameModeMask': mode, 'wipeoutOnly': True, 'zone': zone, 'offset': add(offset, m.get('_ePos', V0)),
                           'rotate': m.get('_eRot', V0), 'loop': False, 'loopMax': 0, 'startDelay': 0.0, 'loopDelay': 0.0,
                           'offsets': [], 'outMeansDestroy': False, 'timeScale': ts, 'indexValue': m.get('_enemyCallIndexValue', 0),
                           'ground': False, 'groundSky': False, 'bonus': m.get('_bonus', 0)})
        elif c['clipType'] == 'TLEntryClip' and c.get('waveGuid') in waves:
            m = mono(c['json'])
            cs = s + c['start'] / ts
            if cs >= e:
                continue
            ce = min(e, s + (c['start'] + c['duration']) / ts)
            wave_events(stage, c['waveGuid'], group, cs, ce, ts * (c['timeScale'] or 1.0), add(offset, m.get('_objectOffset', V0)),
                        m.get('_gameModeFlag', 0) or mode, wipe, depth + 1, events, zone | (m.get('_clipFlag', 0) & ALL_ZONE))

def build(stage):
    events, zones = [], []
    by_name = {t['name']: t for t in stage['timelines']}
    for placed in stage['rootClips']:
        tl = by_name[placed['timeline']]
        t0 = placed['start']
        for n, c in enumerate(tl['clips']):
            if c.get('muted'):
                continue
            if c['clipType'] == 'TLEntryClip' and c.get('waveGuid') in waves:
                m = mono(c['json'])
                s, e = t0 + c['start'], t0 + c['start'] + c['duration']
                group = 'main/%s:%d:%.6f' % (c['asset'], n, s)
                zone = m.get('_clipFlag', 0) & ALL_ZONE
                if zone or m.get('_conditionFlag', 0):
                    zones.append({'name': c['asset'], 'start': round(s, 6), 'end': round(e, 6), 'zone': zone,
                                  'condition': m.get('_conditionFlag', 0), 'failed': m.get('_failedFlag', 0),
                                  'succeeded': m.get('_successedFlag', 0)})
                wave_events(stage['stage'], c['waveGuid'], group, s, e, c['timeScale'] or 1.0, m.get('_objectOffset', V0),
                            m.get('_gameModeFlag', 0), False, 0, events, zone)
            elif c['clipType'] == 'EnemyEntryClip':
                ev = event(stage['stage'], 'ground/%s' % tl['name'], t0, t0 + placed['duration'], 1.0, c, V0, 0, False, True)
                if ev:
                    events.append(ev)
    used = sorted({e['enemy'] for e in events})
    definitions, used_routes, models = [], set(), {}
    for g in used:
        d = enemy_data[g]
        rnames = list(d.get('routeNames') or [])
        # ActionData's int fields are read by JsonUtility, which drops a JSON true/false in an int field (flag0 came out 0
        # everywhere in game): write them as integers.
        acts = [{k: (int(v) if isinstance(v, bool) and k in ACTION_INTS else v) for k, v in a.items()} for a in (d.get('eventDatas') or [])]
        for a in acts:
            if a.get('eventType') == 15 and a.get('stringValue') in routes:
                used_routes.add(a['stringValue'])
        used_routes.update(r for r in rnames if r in routes)
        used_routes.update(r for r in prefab_route_names(d.get('objectName', '')) if r in routes)
        definitions.append({'id': g, 'name': d['m_Name'], 'model': d.get('objectName', ''), 'attribute': d.get('attribute', 0),
                            'duration': d.get('durationTime', 0.0), 'position': d.get('startPosition', V0),
                            'placements': d.get('placementDatas') or [], 'repeats': d.get('repeatDatas') or [],
                            'events': acts, 'routes': [r for r in rnames if r in routes]})
        models[d.get('objectName', '')] = 1
        for p in d.get('placementDatas') or []:
            if p.get('objectName'):
                models[p['objectName']] = 1
    # BGSlideRangeClips on the root-placed timelines: the enemy layer's horizontal slide range over time.
    slides = []
    for placed in stage['rootClips']:
        for c in by_name[placed['timeline']]['clips']:
            if c['clipType'] == 'BGSlideRangeClip' and not c.get('muted'):
                s = placed['start'] + c['start']
                slides.append({'start': round(s, 6), 'end': round(s + c['duration'], 6), 'range': mono(c['json']).get('_slideRange', 0.0),
                               'easeIn': round(max(c.get('easeIn', 0), c.get('blendIn', 0)), 6), 'easeOut': round(max(c.get('easeOut', 0), c.get('blendOut', 0)), 6)})
    # AreaEntryClips (e.g. BG01_BOSSST / BOSSLP / BOSSED): named stage sections; the boss encounter uses the BOSS ones.
    areas = []
    for placed in stage['rootClips']:
        for c in by_name[placed['timeline']]['clips']:
            if c['clipType'] == 'AreaEntryClip' and not c.get('muted'):
                s = placed['start'] + c['start']
                areas.append({'name': mono(c['json']).get('_AreaName', ''), 'start': round(s, 6), 'end': round(s + c['duration'], 6)})
    events.sort(key=lambda e: (e['start'], e['id']))
    return {'version': 1, 'stage': stage['stage'], 'round': int(stage['stage'][2:]), 'sourceHeight': 200.0, 'gameModeMask': 2,
            'events': events, 'definitions': definitions, 'routes': [routes[r] for r in sorted(used_routes)],
            'models': [{'name': m, 'health': 0.0} for m in sorted(models) if m], 'slides': sorted(slides, key=lambda x: x['start']),
            'areas': sorted(areas, key=lambda x: x['start']), 'zones': sorted(zones, key=lambda x: (x['start'], x['zone']))}

def key(e, names):
    o, r = e['offset'], e['rotate']
    return (round(e['start'], 3), round(e['end'], 3), names[e['enemy']], round(o['x'], 2), round(o['y'], 2), round(o['z'], 2),
            round(r['y'], 1), e['loop'], round(e['loopDelay'], 3), e['gameModeMask'], e['wipeoutOnly'])

os.makedirs(out_dir, exist_ok=True)
built = {}
for stage in raw['stages']:
    data = build(stage)
    built[stage['stage']] = data
    json.dump(data, open(os.path.join(out_dir, stage['stage'] + '.json'), 'w', encoding='utf-8'), indent=1)
    air = [e for e in data['events'] if not e['ground']]
    print(stage['stage'], 'air', len(air), 'ground', len(data['events']) - len(air), 'definitions', len(data['definitions']),
          'routes', len(data['routes']), 'models', len(data['models']), 'story-visible air', sum(1 for e in air if not e['wipeoutOnly'] and (e['gameModeMask'] == 0 or e['gameModeMask'] & 2)))

if '--compare-bg03' in sys.argv:
    ref = json.load(open(sys.argv[sys.argv.index('--compare-bg03') + 1], encoding='utf-8'))
    rnames = {d['id']: d['name'] for d in ref['definitions']}
    mine = built['BG03']
    mnames = {d['id']: d['name'] for d in mine['definitions']}
    a = collections.Counter(key(e, rnames) for e in ref['events'])
    b = collections.Counter(key(e, mnames) for e in mine['events'] if not e['ground'])
    print('BG03 compare: reference', sum(a.values()), 'mine', sum(b.values()), 'matching', sum((a & b).values()))
    for k, n in list((a - b).items())[:8]:
        print('  only in reference', n, k)
    for k, n in list((b - a).items())[:8]:
        print('  only in mine', n, k)
    ra = {d['name']: d for d in ref['definitions']}
    for d in mine['definitions']:
        if d['name'] in ra:
            x = ra[d['name']]
            for f in ('model', 'duration', 'routes'):
                if x[f] != d[f]:
                    print('  definition differs', d['name'], f, x[f], d[f])
