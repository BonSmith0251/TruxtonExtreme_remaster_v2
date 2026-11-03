"""Combine the recovered sound data into the one rules file the remaster reads.

Inputs (extractor/sound-source): sound-ids.json, sound-database.json, sound-wiring.json,
native-sound-calls.json, <stage>-bgm.json; extractor/sound-output/manifest.json.
Output: truxton-sound.json (copy it to Assets/Resources/Truxton/ in the Unity project).

Every rule says where it came from: [D] serialized data, [N] native code read in
native-sound-calls.json / the disassembly notes in the skill, [I] inferred.

  python build_sound_rules.py --root "D:/games/Truxton Extreme" [--unity extractor/UnityProject]
"""
import argparse, json, shutil
from pathlib import Path

# Native constants (scan_native_sound_calls.py + disassembly read for the variable ones).
EVENTS = {
    'hit': ('enemy_hit_01', '[N] WeaponNormalCollision static hit SE = 18; WeaponLaserCollision._lockOnSE [D]'),
    'playerDead': ('exp_fighter', '[N] PlayerControll.StartDeadEffect PlayQue(0)'),
    'powerUp': ('shot_powerup', '[N] PlayerControll.PowerUpWeapon PlayQue(14) after ArmLevelUp'),
    'powerFull': ('item_def', '[N] PlayerControll.PowerUpWeapon PlayQue(30) on the other branch'),
    'weaponChange': ('weapon_change_on', '[N] PlayerControll.ChangeWeaponByIndex PlayQue(33)'),
    'speedUp': ('speed_up', '[N] PlayerControll.ChangeSpeed: delta>0 ? 32 : 13'),
    'speedDown': ('speed_down', '[N] PlayerControll.ChangeSpeed / _playerControllSpeedChange'),
    'itemSpeedUp': ('item_speedup', '[N] ItemEffects.ItemEffectResult PlayQue(20) when AddSpeedCapacity succeeds'),
    'itemBomb': ('item_bomb', '[N] ItemEffects.ItemEffectResult PlayQue(21) when BomberStockCountUp succeeds'),
    'extend1': ('item_1up_01', '[N] ItemEffectResult kind 9 -> 22, 10 -> 23, else 228; ItemCollision._getSound [D]'),
    'extend2': ('item_2up_01', '[N] ItemEffectResult item kind 9'),
    'extend3': ('item_3up_01', '[N] ItemEffectResult item kind 10'),
    'pause': ('se_pause_001', '[N] InGameManager.OnPauseRequested PlaySE(2005)'),
    'cancel': ('se_cancel_001', '[N] PauseWindowMenu._Selecting'),
    'bossDefeat': ('boss_defeat01_01', '[N] Ene_BosBase.StopBossTimer PlayQue(177)'),
    'bossCoverBreak': ('boss_parts_destruction_g_01', '[N] Ene_Bos03.CheckCoverBreak PlayQue(212)'),
    'score5000': ('item_5000p', '[D] Score5000 InGameEffect._callSoundID'),
    'score1000': ('item_1000p', '[D] RushBonus InGameEffect._callSoundID'),
}
BOMBS = (['bomb_def_01', 'bomb_lv2_01', 'bomb_lv3_01'],
         '[N] WeaponNormalBomb.Bomb PlayQue(table[level]); [I] table = ids 10/38/39 by bomb level (names)')


def unity_shape(o):
    """JsonUtility reads no dictionaries: turn every keyed table into an array of records."""
    pairs = lambda d, k, v: [{k: a, v: b} for a, b in d.items()]
    return dict(version=o['version'], note=o['note'],
                clips=[dict(name=k, **v) for k, v in o['clips'].items()],
                se=[dict(id=int(k), name=v) for k, v in o['se'].items()], bgm=[dict(id=int(k), name=v) for k, v in o['bgm'].items()],
                events=[dict(name=k, **v) for k, v in o['events'].items()], bombs=o['bombs'],
                effects=[dict(effect=k, sounds=v) for k, v in o['effects'].items()],
                deadOverplay=pairs(o['deadOverplay'], 'model', 'clip'), bulletSounds=pairs(o['bulletSounds'], 'bullet', 'clip'),
                bulletSoundLap=pairs(o['bulletSoundLap'], 'template', 'lap'),
                enemyLasers=[dict(bullet=k, first=v['first'] or '', loop=v['loop'] or '') for k, v in o['enemyLasers'].items()],
                weapons=[dict(arms=int(k), **v) for k, v in o['weapons'].items()],
                playlists=[dict(name=k, gameover=v['gameover'], result=v['result'],
                                stages=[dict(stage=int(s), sections=pairs(sec, 'section', 'clip')) for s, sec in v['stages'].items()])
                           for k, v in o['playlists'].items()],
                stages=[dict(name=k, **v) for k, v in o['stages'].items()],
                rules=pairs(o['rules'], 'name', 'text'))


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--root', default='D:/games/Truxton Extreme')
    ap.add_argument('--unity', default='extractor/UnityProject', help='also copy into <unity>/Assets/Resources/Truxton')
    ap.add_argument('--stages', default='bg03stage')
    a = ap.parse_args()
    root = Path(a.root); src = root/'extractor/sound-source'
    load = lambda p: json.loads(p.read_text(encoding='utf-8'))
    ids, db = load(src/'sound-ids.json'), load(src/'sound-database.json')['records']
    wiring = load(src/'sound-wiring.json')['rows']
    manifest = load(root/'extractor/sound-output/manifest.json')['clips']
    se, bgm = ids['ID'], ids['BGM']
    dbn = {r['clip']: r for r in db}

    clips = {}
    for c in manifest:
        r = dbn.get(c['name'])
        clips[c['name']] = dict(path='TruxtonAudio/'+c['file'].rsplit('.', 1)[0], group=c['group'], length=round(c['length'], 4),
                                volume=(r['_volume'] if r else 100)/100, priority=r['_priority'] if r else 0,
                                polyphony=r['_polyphony'] if r else 0, guarantee=round(r['_guarantee'], 4) if r else 0,
                                loop=bool(r['_isLoop']) if r else False, overwrite=bool(r['_isOverwrite']) if r else False,
                                kind=r['_kind'] if r else 2, title=r['displayName'] if r else '')
    need = lambda name: name if name in clips else (_ for _ in ()).throw(KeyError(name))
    rows = lambda script: [r for r in wiring if r['script'] == script]

    effects = {}
    for p in rows('EffectPalette')[0]['data']['palette']:
        if p['callRate'] > 0:
            effects.setdefault(p['effectName'], []).append(dict(clip=need(se[str(p['soundID'])]), rate=p['callRate']))
    for r in rows('InGameEffect') + rows('EffectScore5000'):
        name = r['gameObject']; sid = r['data'].get('_callSoundID', -1)
        if sid >= 0 and name and name not in effects:
            effects[name] = [dict(clip=need(se[str(sid)]), rate=100)]
    overplay = {r['gameObject']: need(se[str(r['data']['_overplayDeadSound'])])
                for r in wiring if r['data'].get('_overplayDeadSound', -1) >= 0 and r['gameObject']}
    bullets = {p['_bulletName']: need(se[str(p['_seID'])]) for p in rows('BulletSounds')[0]['data']['palette']}
    laps = {r['name']: r['data']['nSoundLap'] for r in rows('BulletTemplate')}
    lasers = {}
    for r in rows('EnemyLaserCollision') + rows('EnemyLaserCollision2'):
        d = r['data']; f = d.get('_firstSound', {}).get('SoundId', -1); l = d.get('_loopSound', {}).get('SoundId', -1)
        lasers[r['gameObject']] = dict(first=se.get(str(f)) if f >= 0 else None, loop=se.get(str(l)) if l >= 0 else None)
    weapons = {}
    for r in rows('WeaponNormalShot') + rows('WeaponGrowShot') + rows('WeaponLaserShot'):
        if r['gameObject'] != 'player01': continue
        d = r['data']; levels = d.get('_requestSounds') or d.get('_requestLptSounds')
        weapons[d['_armKind']] = dict(clips=[need(se[str(i)]) for i in levels], laser=r['script'] == 'WeaponLaserShot',
                                      pipiru=se.get(str(d.get('_pipiruShotSound', -1))))
    playlists = {}
    for r in rows('StagePlayList'):
        d = r['data']; names = {'_outset': 'Outset', '_ontheway1': 'OnTheWay1', '_ontheway2': 'OnTheWay2', '_boss': 'Boss',
                                '_epilogue': 'Epilogue', '_finale': 'Finale'}
        playlists[r['name']] = dict(stages={str(p['_stage']): {v: bgm.get(str(p[k])) for k, v in names.items() if p[k] >= 0}
                                            for p in d['palette']},
                                    gameover=bgm.get(str(d['_gameoverBGM'])), result=bgm.get(str(d['_resultBGM'])))
    stages = {}
    for stage in a.stages.split(','):
        s = load(src/f'{stage}-bgm.json'); sections = s['enums']['PlaySection'][0]
        stages[stage] = dict(stageOrder=s['stageOrder'], playlist='DefaultBGMPlaylist',
                             entries=[dict(start=e['start'], duration=e['duration'], easeIn=e['easeIn'], easeOut=e['easeOut'],
                                           stageKind=e['stageKind'], section=sections[str(e['sectionKind'])]) for e in s['entries']])
    out = dict(version=1, note='Recovered by the truxton-sound skill. [D] data, [N] native, [I] inferred.',
               clips=clips, se=se, bgm=bgm,
               events={k: dict(clip=need(v[0]), source=v[1]) for k, v in EVENTS.items()},
               bombs=dict(clips=[need(x) for x in BOMBS[0]], source=BOMBS[1]),
               effects=effects, deadOverplay=overplay, bulletSounds=bullets, bulletSoundLap=laps, enemyLasers=lasers,
               weapons={str(k): v for k, v in sorted(weapons.items())}, playlists=playlists, stages=stages,
               rules={'deadSound': '[N] PawnEnemy._callDeadEffect: ExplosionQue(effect, playSound=true) and, if _overplayDeadSound != -1, PlayQue(it) too',
                      'effectSound': '[N] InGameEffectManager.GetEffectSound: weighted pick by callRate (rand%100), else InGameEffect._callSoundID',
                      'polyphony': '[N] SoundUtility.Play: polyphony>0 and playing>=polyphony -> overwrite oldest same-clip channel if isOverwrite else drop',
                      'guarantee': '[I] seconds before the same SE may sound again (PlayQue _lastPlayTime)',
                      'enemyFire': '[N] InGameBulletManager.BulletFire PlayQue(template SE from BulletSounds palette); [I] nSoundLap 0 = first rapid shot only',
                      'bgm': '[D] BGMEntryClip on the stage timeline picks a PlaySection; StagePlayList maps it to a BGM; clip ease-out fades it'})
    path = src/'truxton-sound.json'
    path.write_text(json.dumps(unity_shape(out), indent=1, ensure_ascii=False), encoding='utf-8')
    print('rules ->', path, f"({len(clips)} clips, {len(effects)} effects, {len(overplay)} overplays, {len(weapons)} weapons)")
    if a.unity:
        dest = root/a.unity/'Assets/Resources/Truxton/truxton-sound.json'
        shutil.copyfile(path, dest); print('copied ->', dest)


if __name__ == '__main__':
    main()
