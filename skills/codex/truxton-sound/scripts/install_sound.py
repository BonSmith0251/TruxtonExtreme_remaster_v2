"""Install the original sounds into a Unity remaster project (staging or the user's).

Copies extractor/sound-output/** to Assets/Resources/TruxtonAudio/, truxton-sound.json to Assets/Resources/Truxton/,
the skill's unity/*.cs scripts, and applies the one-line sound hooks to the game scripts by anchor. Each hook is
idempotent: a file that already has it is left alone; a file whose anchor is missing stops the install before anything
is written. Every overwritten file is backed up to extractor/Backups/before-sound-install-<project>-<timestamp>/.

  python install_sound.py --project "D:/games/Truxton Extreme/extractor/UnityProject"
  python install_sound.py --project "C:/Users/Administrator/Documents/TruxtonRemaster" --dry-run
"""
import argparse, filecmp, json, shutil, time
from pathlib import Path

SKILL = Path(__file__).resolve().parents[1]
ROOT = next((p for p in SKILL.parents if (p/'extractor/export_selection.py').exists()), Path('D:/games/Truxton Extreme'))

SCRIPTS = {'Round1Sound.cs': 'Assets/Truxton/Round1Sound.cs', 'TruxtonAudioImport.cs': 'Assets/Editor/TruxtonAudioImport.cs',
           'Round1SoundCheck.cs': 'Assets/Editor/Round1SoundCheck.cs'}
# (file, anchor, replacement): the replacement contains the anchor's text plus the Round1Sound call.
HOOKS = [
    ('Round1Effects.cs', "now))return false;Hits++;", "now))return false;Hits++;Round1Sound.Hit();"),
    ('Round1Effects.cs', "BlastsByModel[model]=n+1;LastBlast=t;}return played;",
     "BlastsByModel[model]=n+1;LastBlast=t;Round1Sound.Dead(model,e.effect);}return played;"),
    ('Round1WeaponMotion.cs', "    void AdvanceShotSimulation(float dt,bool firing)\n    {\n",
     "    void AdvanceShotSimulation(float dt,bool firing)\n    {\n        Round1Sound.WeaponLoop(Arms,Level,firing && IsLaser(Arms));\n"),
    ('Round1WeaponMotion.cs', "        VolleysFired++;\n", "        VolleysFired++;Round1Sound.Fire(Arms,Level);\n"),
    ('Round1Weapon.cs', "if(!SimulationRunning){PlaceBullets();", "if(!SimulationRunning){Round1Sound.WeaponLoop(Arms,Level,false);PlaceBullets();"),
    ('Round1Weapon.cs', "        Lives--;ClearBullets();", "        Lives--;Round1Sound.Event(\"playerDead\");ClearBullets();"),
    ('Round1Weapon.cs', "        Bombs--;bombTime=", "        Bombs--;Round1Sound.Bomb(BombLevel);bombTime="),
    ('Round1Weapon.cs', "if(Level<4){Level++;Tell(\"POWER UP\");}else{AddScore(1000);Tell(\"POWER MAX +1000\");}",
     "if(Level<4){Level++;Round1Sound.Event(\"powerUp\");Tell(\"POWER UP\");}else{AddScore(1000);Round1Sound.Event(\"powerFull\");Tell(\"POWER MAX +1000\");}"),
    ('Round1Weapon.cs', "if(Arms==arms)return;Arms=arms;", "if(Arms==arms)return;Arms=arms;Round1Sound.Event(\"weaponChange\");"),
    ('Round1Weapon.cs', "    public void ApplyPickup(Round1PickupKind kind)\n    {\n",
     "    public void ApplyPickup(Round1PickupKind kind)\n    {\n        Round1Sound.Pickup(kind);\n"),
    ('Round1EnemyAttacks.cs', "class Beam { public Shooter shooter;public Transform", "class Beam { public Shooter shooter;public string bullet;public Transform"),
    ('Round1EnemyAttacks.cs', "beams.Add(new Beam{shooter=s,muzzle=muzzle,", "beams.Add(new Beam{shooter=s,bullet=p.bulletName,muzzle=muzzle,"),
    ('Round1EnemyAttacks.cs', "Vector2 origin=Position(b.muzzle),axis=Direction(b);\n",
     "Vector2 origin=Position(b.muzzle),axis=Direction(b);Round1Sound.EnemyFire(p.name,p.bulletName,b.index);\n"),
    ('Round1EnemyAttacks.cs',
     "            float age=(now-beam.born)*beam.shooter.scale;\n            if(!Alive(beam.shooter) || combat.weapon.BombActive || age>beam.charge+beam.duration+beam.dissolve){beam.line.enabled=false;continue;}",
     "            float age=(now-beam.born)*beam.shooter.scale;\n            bool live=Alive(beam.shooter) && !combat.weapon.BombActive && age<=beam.charge+beam.duration+beam.dissolve;\n"
     "            Round1Sound.EnemyLaser(beam,beam.bullet,age,beam.charge,beam.duration,live);\n            if(!live){beam.line.enabled=false;continue;}"),
    ('Round1Boss.cs', "else if(part==cover){HideParts(coverNode);", "else if(part==cover){Round1Sound.Event(\"bossCoverBreak\");HideParts(coverNode);"),
    ('Round1Boss.cs', "State=EncounterState.Defeating;deathTime=0;combat.ClearHostiles();",
     "State=EncounterState.Defeating;deathTime=0;combat.ClearHostiles();Round1Sound.Dead(\"Pf_Ene_Bos03\",\"pf_eff_explposion_boss\");Round1Sound.Event(\"bossDefeat\");"),
]


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--project', required=True)
    ap.add_argument('--dry-run', action='store_true')
    ap.add_argument('--skip-audio', action='store_true', help='scripts and rules only')
    a = ap.parse_args()
    project = Path(a.project)
    assert (project/'Assets/Truxton').is_dir(), f'not a Truxton remaster project: {project}'
    stamp = time.strftime('%Y%m%d-%H%M%S')
    backup = ROOT/'extractor/Backups'/f'before-sound-install-{project.name}-{stamp}'
    plan, patched = [], {}

    # Hooks first: refuse to write anything if an anchor is missing.
    for name, anchor, new in HOOKS:
        path = project/'Assets/Truxton'/name
        text = patched.get(path) or path.open(encoding='utf-8', newline='').read()
        if '\r\n' in text:  # keep the file's own line endings
            anchor, new = anchor.replace('\n', '\r\n'), new.replace('\n', '\r\n')
        if new in text:
            continue
        if text.count(anchor) != 1:
            raise SystemExit(f'{name}: anchor found {text.count(anchor)} times, expected 1: {anchor[:60]!r}. Adapt the hook by hand.')
        patched[path] = text.replace(anchor, new)
    for path, text in patched.items():
        plan.append(('patch', path, text))
    for src, dst in SCRIPTS.items():
        s, d = SKILL/'unity'/src, project/dst
        if not d.exists() or not filecmp.cmp(s, d, shallow=False):
            plan.append(('copy', d, s))
    rules = ROOT/'extractor/sound-source/truxton-sound.json'
    dest = project/'Assets/Resources/Truxton/truxton-sound.json'
    if not dest.exists() or not filecmp.cmp(rules, dest, shallow=False):
        plan.append(('copy', dest, rules))
    audio = ROOT/'extractor/sound-output'
    if not a.skip_audio:
        manifest = json.loads((audio/'manifest.json').read_text(encoding='utf-8'))
        assert not manifest['summary']['failures'], 'extraction has failures'
        for c in manifest['clips']:
            s, d = audio/c['file'], project/'Assets/Resources/TruxtonAudio'/c['file']
            if not d.exists() or s.stat().st_size != d.stat().st_size or not filecmp.cmp(s, d, shallow=False):
                plan.append(('copy', d, s))

    print(f"{len(plan)} changes -> {project}" + (' (dry run)' if a.dry_run else ''))
    for kind, d, _ in plan[:40]:
        print(' ', kind, d.relative_to(project))
    if len(plan) > 40:
        print(f'  ... {len(plan)-40} more')
    if a.dry_run or not plan:
        return
    for kind, d, payload in plan:
        if d.exists() and d.suffix != '.ogg':
            target = backup/d.relative_to(project); target.parent.mkdir(parents=True, exist_ok=True); shutil.copy2(d, target)
        d.parent.mkdir(parents=True, exist_ok=True)
        if kind == 'patch':
            d.write_text(payload, encoding='utf-8', newline='')
        else:
            shutil.copyfile(payload, d)
    log = dict(project=str(project), time=stamp, backup=str(backup), changes=len(plan),
               patched=[str(p.relative_to(project)) for p in patched], scripts=list(SCRIPTS.values()))
    with (ROOT/'extractor/sound-source/installs.jsonl').open('a', encoding='utf-8') as f:
        f.write(json.dumps(log)+'\n')
    print('installed; backup ->', backup if backup.exists() else '(nothing overwritten)')


if __name__ == '__main__':
    main()
