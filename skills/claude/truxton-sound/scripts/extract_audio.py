"""Decode every AudioClip in the original game and write it as an Ogg Vorbis (or WAV) file.

UnityPy's FMOD decoder turns each clip's FSB5/Vorbis stream into PCM; soundfile (libsndfile)
writes it out. Ogg is a high-quality re-encode, not the original bitstream (FSB5 strips the
Vorbis headers). Files are grouped by role:
  BGM/      kind 0 in the SoundDatabase, or txe_bgm_*, *_bgm_*  (DLC packs in BGM/<pack>/)
  SE/       in-game and UI effects
  Comic/    txe_se_c* comic/story sounds
  Village/  pville (Pipiru village) clips
A manifest records source identity, format, length and the SoundDatabase row of every clip.

  python extract_audio.py --root "D:/games/Truxton Extreme" --out extractor/sound-output
  python extract_audio.py --only exp_S5,txe_bgm_f000      # a few clips
"""
import argparse, gc, hashlib, io, json, wave
from pathlib import Path

import numpy as np
import soundfile as sf
import UnityPy


def group(name, source, kind):
    if 'pville' in source: return 'Village'
    if name.startswith('txe_se_c'): return 'Comic'
    if kind == 0 or 'bgm' in name:
        for pack in ('dlc01', 'dlc02', 'dlc03'):
            if pack in source: return f'BGM/{pack}'
        return 'BGM'
    return 'SE'


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--root', default='D:/games/Truxton Extreme')
    ap.add_argument('--out', default='extractor/sound-output')
    ap.add_argument('--format', choices=('ogg', 'wav'), default='ogg')
    ap.add_argument('--quality', type=float, default=0.15, help='libsndfile Vorbis compression level 0 (best)..1')
    ap.add_argument('--only', default='', help='comma-separated clip names')
    a = ap.parse_args()
    root, out = Path(a.root), Path(a.root)/a.out
    db = {r['clip']: r for r in json.loads((root/'extractor/sound-source/sound-database.json').read_text(encoding='utf-8'))['records']}
    only = set(filter(None, a.only.split(',')))
    inv = json.loads((root/'analysis/inventory.json').read_text(encoding='utf-8'))
    sources = [s['source'] for s in inv['sources'] if s.get('counts', {}).get('AudioClip')]
    manifest, failures = [], []
    manifest_path = out/'manifest.json'
    for source in sources:
        env = UnityPy.load(str(root/source))
        for obj in env.objects:
            if obj.type.name != 'AudioClip': continue
            clip = obj.read()
            name = clip.m_Name
            if only and name not in only: continue
            rec = db.get(name)
            folder = group(name, source, rec['_kind'] if rec else None)
            row = dict(name=name, group=folder, source=source.split('/')[-1], cab=obj.assets_file.name,
                       pathId=str(obj.path_id), channels=clip.m_Channels, frequency=clip.m_Frequency,
                       length=clip.m_Length, loadType=clip.m_LoadType, database=rec)
            try:
                samples = clip.samples
                if len(samples) != 1: raise ValueError(f'{len(samples)} subsounds')
                pcm = next(iter(samples.values()))
                with wave.open(io.BytesIO(pcm)) as w:
                    ch, rate, width, frames = w.getnchannels(), w.getframerate(), w.getsampwidth(), w.getnframes()
                    data = np.frombuffer(w.readframes(frames), dtype={2: '<i2', 4: '<i4'}[width]).reshape(-1, ch)
                target = out/folder/f'{name}.{a.format}'
                target.parent.mkdir(parents=True, exist_ok=True)
                if a.format == 'wav':
                    target.write_bytes(pcm)
                else:
                    # libsndfile's Vorbis encoder overflows the stack on one big write; feed it blocks.
                    with sf.SoundFile(str(target), 'w', rate, ch, format='OGG', subtype='VORBIS', compression_level=a.quality) as f:
                        for i in range(0, frames, 4096):
                            f.write(data[i:i+4096])
                row.update(file=str(target.relative_to(out)).replace('\\', '/'), frames=frames, rate=rate,
                           pcmSha1=hashlib.sha1(data.tobytes()).hexdigest(), peak=int(np.abs(data).max()) if frames else 0,
                           bytes=target.stat().st_size)
                if abs(frames/rate - clip.m_Length) > 0.05:
                    row['warning'] = f'decoded {frames/rate:.3f}s vs header {clip.m_Length:.3f}s'
            except Exception as exc:  # keep going; report every failure
                row['error'] = repr(exc); failures.append(name)
            manifest.append(row)
            print(f"{row.get('error') and 'FAIL' or 'ok  '} {folder:12s} {name}")
            del clip; gc.collect()
        del env; gc.collect()
    manifest.sort(key=lambda r: (r['group'], r['name']))
    names = [r['name'] for r in manifest]
    summary = dict(clips=len(manifest), failures=failures, duplicateNames=sorted({n for n in names if names.count(n) > 1}),
                   bytes=sum(r.get('bytes', 0) for r in manifest), format=a.format, quality=a.quality,
                   notInDatabase=sorted(r['name'] for r in manifest if not r['database']))
    if not only:
        manifest_path.write_text(json.dumps(dict(summary=summary, clips=manifest), indent=1), encoding='utf-8')
    print(json.dumps(summary, indent=1))


if __name__ == '__main__':
    main()
