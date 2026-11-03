"""Per-stage music windows for Round1Sound, from each stage's BGMEntryClips.

Source: extraction/stage-enemies/raw-stage-timelines.json. A BGMEntryClip on BGxxMain carries _stageKind (the
DefaultBGMPlaylist stage whose tracks it plays) and _sectionKind (TXEKernel.PlaySection: 0 Outset, 1 OnTheWay1,
2 OnTheWay2, 3 Boss, 10 Epilogue, 20 Finale); its start, duration and ease-in/out are the window and fades.
Writes the 'stages' list of Assets/Resources/Truxton/truxton-sound.json (one 'bgxxstage' per stage; BG03's existing
entries, recovered earlier by the truxton-sound skill, must come out identical) and evidence/stage-enemies/music-validation.json.
"""
import collections, json, os

BASE = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
RAW = os.path.join(BASE, 'extraction', 'stage-enemies', 'raw-stage-timelines.json')
SOUND = os.path.join(BASE, 'Reconstructed', 'Assets', 'Resources', 'Truxton', 'truxton-sound.json')
VALIDATION = os.path.join(BASE, 'evidence', 'stage-enemies', 'music-validation.json')
SECTIONS = {0: 'Outset', 1: 'OnTheWay1', 2: 'OnTheWay2', 3: 'Boss', 10: 'Epilogue', 20: 'Finale'}


def mono(c):
    j = c['json'] if isinstance(c['json'], dict) else json.loads(c['json'])
    return j.get('MonoBehaviour', j)


def main():
    raw = json.load(open(RAW, encoding='utf-8'))
    raw_text = open(SOUND, encoding='utf-8').read()
    sound = json.loads(raw_text)
    old = {s['name']: s for s in sound['stages']}
    playlist = sound['playlists'][0]['name']
    available = {(ps['stage'], x['section']) for ps in sound['playlists'][0]['stages'] for x in ps['sections']}
    stages, report = [], {'stages': {}}
    for s in raw['stages']:
        entries = []
        for tl in s['timelines']:
            for c in tl['clips']:
                if c.get('clipType') != 'BGMEntryClip' or c.get('muted'):
                    continue
                m = mono(c)
                entries.append({'start': round(c['start'], 4), 'duration': round(c['duration'], 4), 'easeIn': c.get('easeIn', 0.0),
                                'easeOut': c.get('easeOut', 0.0), 'stageKind': m['_stageKind'], 'section': SECTIONS.get(m['_sectionKind'], str(m['_sectionKind']))})
        entries.sort(key=lambda e: e['start'])
        order = collections.Counter(e['stageKind'] for e in entries if e['section'] != 'Boss').most_common(1)[0][0]
        name = s['stage'].lower() + 'stage'
        stages.append({'name': name, 'playlist': playlist, 'stageOrder': order, 'entries': entries})
        report['stages'][name] = {'entries': entries, 'missing_tracks': [(e['stageKind'], e['section']) for e in entries if (e['stageKind'], e['section']) not in available]}
        print(name, 'stage', order, [(e['start'], e['section'], e['stageKind']) for e in entries], 'missing', report['stages'][name]['missing_tracks'])
    if 'bg03stage' in old:
        mine = next(x for x in stages if x['name'] == 'bg03stage')
        key = lambda e: (e['start'], e['duration'], e['easeIn'], e['easeOut'], e['stageKind'], e['section'])
        same = sorted(map(key, mine['entries'])) == sorted(map(key, old['bg03stage']['entries'])) and mine['stageOrder'] == old['bg03stage']['stageOrder']
        report['bg03_identical'] = same
        print('BG03 identical to the existing entries:', same)
        if not same:
            raise SystemExit('BG03 differs from the validated entries; not writing')
    sound['stages'] = stages
    nl = '\r\n' if '\r\n' in raw_text else '\n'
    with open(SOUND, 'w', encoding='utf-8', newline='') as f:
        f.write(json.dumps(sound, ensure_ascii=False, indent=1).replace('\n', nl))
    os.makedirs(os.path.dirname(VALIDATION), exist_ok=True)
    json.dump(report, open(VALIDATION, 'w', encoding='utf-8'), indent=1)


if __name__ == '__main__':
    main()
