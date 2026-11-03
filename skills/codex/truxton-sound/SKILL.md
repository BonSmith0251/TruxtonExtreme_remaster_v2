---
name: truxton-sound
description: Extract every sound of TATSUJIN EXTREME (Truxton Extreme) — background music, player shots and lasers, hit ticks, enemy and boss explosions, enemy fire, item/power-up/bomb/extend cues, UI and comic sounds, DLC soundtracks — recover how the original triggers each one (sound ids, SoundDatabase volume/polyphony/loop rows, explosion sound palettes, per-stage BGM sections), and install them with a matching sound player into the Unity 2023 remaster. Use whenever the user asks for audio, sound, SE/SFX, BGM or music in the remaster, says the game is silent, a sound is missing, wrong, too loud, cut off or repeats, wants the music to change like the original, wants another stage's music or sounds, or asks to re-extract or re-install the sounds — even if they only say "add the sounds", "no music", or "the explosion sounds wrong".
---

# Truxton sound

The original plays no AudioSource components. Every sound is an integer id passed to `TXEKernel.Sound.SoundUtility` (over `KANAI.Sound.SoundManager`); clips are Addressables loaded by name. So "extract all sounds" has two halves: the 560 AudioClips, and the rules that say which id plays when. This skill recovers both from the installed game and installs them into the remaster.

Workspace `D:/games/Truxton Extreme` (game files are read-only). Staging project `extractor/UnityProject`; the user's project `C:/Users/Administrator/Documents/TruxtonRemaster` (often open in the editor — never batch against it). Unity **2023.2.22f1**. Python 3.11 with `UnityPy==1.25.4`, `soundfile` (libsndfile 1.2 with Vorbis), `numpy`, `capstone`. Read [references/original-sound.md](references/original-sound.md) for the recovered rules and their evidence before changing behaviour.

## Pipeline

Run from the workspace root, in order; each step writes to `extractor/sound-source/` (data) or `extractor/sound-output/` (audio). All scripts are in this skill's `scripts/`.

1. `recover_sound_wiring.py` (~15 s) — the id enums from IL2CPP metadata (`ID` 454 SE, `BGM` 128, `ExpSound`, `InGameBGM`, `BossBGM`) → `sound-ids.json`; every component field that holds a sound id (weapons, effects, items, lasers, playlists, `BulletSounds00`, `EffectPalette00`, BGMEntryClips) → `sound-wiring.json`; the `SoundDatabase` (579 rows, keys XOR 0x3c like EnemyDatabase) → `sound-database.json`.
2. `scan_native_sound_calls.py` (~10 s) — every constant id passed to `SoundUtility.Play*`/`StopCh`/`PlayQue` in game code → `native-sound-calls.json`. Ids loaded from fields or tables show as `null`; read those call sites with `extractor/analyze_player_native.py`'s `disassemble` (see the reference for the ones already read).
3. `recover_stage_bgm.py --stage BG03Stage.prefab` — the stage timeline's BGMEntryClips (start, duration, ease-out, PlaySection) → `bg03stage-bgm.json`. Add a stage by running it with that stage's `BGxxStage.prefab` and passing `--stages bg03stage,bgxxstage` to step 5.
4. `extract_audio.py` (~4 min) — decodes all 560 clips (UnityPy's FMOD) and writes Ogg Vorbis at libsndfile level 0.15 into `BGM/` (+`BGM/dlc01..03`), `SE/`, `Comic/` (`txe_se_c*`), `Village/`, with `manifest.json` (source CAB/PathID, length, PCM SHA-1, peak, database row). It must report 560 clips, no failures, no duplicate names, no length warnings. `--only a,b` re-extracts a few into a scratch `--out`. `--format wav` keeps PCM (≈5× larger). Ogg is a re-encode: FSB5 strips the Vorbis setup headers, so the original bitstream cannot be copied out as-is.
5. `build_sound_rules.py` — merges it all into `truxton-sound.json` (JsonUtility-shaped arrays) and copies it to staging `Assets/Resources/Truxton/`. Each rule carries its evidence tag: [D] data, [N] native code, [I] inferred.
6. `install_sound.py --project <project>` (`--dry-run` first) — copies the audio to `Assets/Resources/TruxtonAudio/`, the rules, `unity/Round1Sound.cs` → `Assets/Truxton/`, `unity/TruxtonAudioImport.cs` and `unity/Round1SoundCheck.cs` → `Assets/Editor/`, and applies the one-line hooks to the game scripts by anchor. Hooks are idempotent; if an anchor is missing (the script changed) it stops before writing anything — adapt that hook in `HOOKS` by hand. Overwritten files go to `extractor/Backups/before-sound-install-<project>-<time>/`; installs are logged in `extractor/sound-source/installs.jsonl`.
7. Verify on staging (no editor may hold it: `extractor/UnityProject/Temp/UnityLockfile` absent):
   ```powershell
   & 'C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe' -batchmode -projectPath 'D:\games\Truxton Extreme\extractor\UnityProject' `
     -executeMethod Round1SoundCheck.RunBatch -logFile 'D:\games\Truxton Extreme\extractor\sound-source\unity-sound-check.log'
   ```
   The first run imports ~420 MB of audio (several minutes). It writes `round1-sound-validation.json` in the project: all 560 clips load with their original lengths; music by section at 10/194/200/420/30 s and the ease-out fade; a 240 s autopilot run that must play the shot, hit, Sa01 death, meteor and enemy-fire sounds. `played` lists counts per clip, `music` the BGM changes.

Install into the user's project only when they ask, after staging passes. Copying while their editor is open is fine — Unity imports on focus; tell them the first import takes a few minutes.

## In the remaster

`Round1Sound` boots with any scene that has a `Round1Playback` (`RuntimeInitializeOnLoadMethod`), keeps 32 SE channels, a BGM source and a pause-proof system source, and loads clips on demand with `Resources.Load`. Static hooks (`Hit`, `Fire`, `WeaponLoop`, `Dead`, `EnemyFire`, `EnemyLaser`, `Bomb`, `Pickup`, `Event(name)`, `Play(clip)`) no-op in edit mode, so edit-mode checks stay silent unless they call `Round1Sound.Ensure()` and `Tick(dt)`. `SeVolume`/`BgmVolume` are global multipliers. The hooks sit in `Round1Effects` (hit, death), `Round1WeaponMotion` (volley, laser loop), `Round1Weapon` (death, bomb, power-up, weapon change, pickups), `Round1EnemyAttacks` (enemy fire, beam charge/loop) and `Round1Boss` (cover break, defeat).

Music follows `Round1Playback.elapsed` through the stage's BGMEntryClips, so seeking moves it; the boss section keeps playing while `Round1Boss.HoldsStage`; game over and clear switch to the playlist's game-over/result BGM; pausing pauses everything and plays `se_pause_001`.

## When something sounds wrong

- Find the clip and its row: `truxton-sound.json` → `clips[name]` (volume 0–1, polyphony, guarantee, loop, overwrite). Volume and limits come from the original SoundDatabase; change the rule, not the clip.
- Missing sound for an event: look for the event in `native-sound-calls.json` (by method) or `sound-wiring.json` (by component), then add a hook. Keep new hooks in `install_sound.py`'s `HOOKS` so reinstalls carry them.
- Not yet wired (clips are installed and play by name with `Round1Sound.Play`): the speed-change button (`speed_up`/`speed_down`; the remaster has no such button), jewel/pipiru/score-rush sounds, `app_fighter`/`landing_demo_se_01` (the original's intro is a movie with its own audio), menus, comics (`txe_se_c*` voices/sfx for the comic player), result-screen counters, other stages' bosses and gimmicks.
- Rules tagged [I] are the first to doubt; see the reference for what each is based on.
