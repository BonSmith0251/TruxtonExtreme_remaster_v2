"""Find every serialized object in the original game that points at an AudioClip.

The game plays no AudioSource components: sound goes through KANAI.Sound.SoundManager,
and gameplay objects hold integer SE/BGM ids. This scan finds the tables that turn those
ids into clips, plus any direct clip references, so the id -> clip map is recovered from
data instead of guessed from names. Game files are read-only.

  python scan_sound_refs.py --root "D:/games/Truxton Extreme" --out extractor/sound-source/clip-refs.json
"""
import argparse, gc, json
from collections import Counter
from pathlib import Path

import UnityPy


def walk(value, path=''):
    if isinstance(value, dict):
        if 'm_FileID' in value and 'm_PathID' in value:
            yield path, value
            return
        for k, v in value.items():
            yield from walk(v, f'{path}.{k}' if path else k)
    elif isinstance(value, list):
        for i, v in enumerate(value):
            yield from walk(v, f'{path}[{i}]')


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--root', default='D:/games/Truxton Extreme')
    ap.add_argument('--out', default='extractor/sound-source/clip-refs.json')
    a = ap.parse_args()
    root = Path(a.root)
    clips, scripts = {}, {}
    for line in (root/'analysis/objects.jsonl').open(encoding='utf-8'):
        r = json.loads(line)
        if r['type'] == 'AudioClip':
            clips[(r['serialized_file'].lower(), int(r['path_id']))] = r['name']
        elif r['type'] == 'MonoScript':
            d = r['details']
            scripts[(r['serialized_file'].lower(), int(r['path_id']))] = f"{d.get('m_Namespace','')}.{d.get('m_ClassName','')}".lstrip('.')
    inv = json.loads((root/'analysis/inventory.json').read_text(encoding='utf-8'))
    files = [s['source'] for s in inv['sources'] if s.get('serialized_files')]
    refs, counts = [], Counter()
    for source in files:
        p = root/source
        try:
            env = UnityPy.load(str(p))
        except Exception as exc:
            counts['load-error'] += 1
            print('skip', source, exc)
            continue
        for asset in env.assets:
            cab = asset.name.lower()
            ext = [x.path.replace('\\', '/').split('/')[-1].lower() for x in asset.externals]
            def resolve(ptr):
                fid, pid = ptr['m_FileID'], ptr['m_PathID']
                if not pid:
                    return None
                return (cab if fid == 0 else ext[fid-1], int(pid))
            for obj in asset.objects.values():
                if obj.type.name != 'MonoBehaviour':
                    continue
                counts['monobehaviour'] += 1
                try:
                    tree = obj.read_typetree()
                except Exception:
                    counts['typetree-error'] += 1
                    continue
                hits = []
                for path, ptr in walk(tree):
                    key = resolve(ptr)
                    if key in clips:
                        hits.append(dict(field=path, clip=clips[key], cab=key[0], pathId=str(key[1])))
                if hits:
                    script = scripts.get(resolve(tree.get('m_Script', {}) or {}) or ('', 0), '?')
                    refs.append(dict(source=source, cab=cab, pathId=str(obj.path_id), name=tree.get('m_Name', ''),
                                     script=script, clipRefs=hits))
                    counts['referencing-objects'] += 1
        del env
        gc.collect()
    out = root/a.out
    out.parent.mkdir(parents=True, exist_ok=True)
    out.write_text(json.dumps(dict(counts=counts, objects=refs), indent=1), encoding='utf-8')
    print(json.dumps(counts), '->', out)
    for r in refs:
        print(r['script'], r['name'], len(r['clipRefs']), r['source'].split('/')[-1][:30])


if __name__ == '__main__':
    main()
