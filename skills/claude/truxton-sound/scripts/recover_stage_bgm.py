"""Recover when a stage changes music: the BGMEntryClips on its main timeline (and nested ones).

A BGMEntryClip names a playlist section (_sectionKind: outset, ontheway1, ontheway2, boss, ...)
and the stage (_stageKind). StagePlayList (DefaultBGMPlaylist etc.) maps the section to a
BGM id. Game files are read-only.

  python recover_stage_bgm.py --stage BG03Stage.prefab
Writes extractor/sound-source/<stage>-bgm.json.
"""
import argparse, json, struct, sys
from pathlib import Path

ROOT = next((p for p in Path(__file__).resolve().parents if (p/'extractor/export_selection.py').exists()), Path('D:/games/Truxton Extreme'))
sys.path.insert(0, str(ROOT/'extractor'))
from export_selection import Index  # noqa: E402


def enum_names(names):
    """Enum constant tables for nested enums with these type names, from IL2CPP metadata."""
    meta = (ROOT/'TATSUJIN EXTREME_Data/il2cpp_data/Metadata/global-metadata.dat').read_bytes()
    sec = [struct.unpack_from('<III', meta, 8+i*12) for i in range(31)]
    def table(i, fmt):
        off, size, count = sec[i]; n = struct.calcsize(fmt)
        return [struct.unpack_from(fmt, meta, off+k*n) for k in range(count)]
    def s(i):
        o = sec[2][0]+i; return meta[o:meta.index(b'\0', o)].decode()
    def cint(o):
        b = meta[o]
        v = b if b < 0x80 else ((b & 0x3F) << 8) | meta[o+1] if b < 0xC0 else struct.unpack_from('<I', meta, o+1)[0]
        return (v >> 1) ^ -(v & 1)
    types, fields = table(19, '<IIiiiH9I8HII'), table(11, '<III')
    defaults = {d[0]: d for d in table(7, '<III')}
    out = {}
    for t in types:
        if s(t[0]) in names:
            vals = {cint(sec[8][0]+defaults[f][2]): s(fields[f][0]) for f in range(t[7], t[7]+t[17]) if f in defaults}
            out.setdefault(s(t[0]), []).append(vals)
    return out


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--stage', default='BG03Stage.prefab')
    a = ap.parse_args()
    idx = Index(ROOT)
    stage = idx.select(a.stage)
    comps = [idx.ref(stage[0], p['component']) for p in idx.tree(stage)['m_Component']]
    config = next(idx.tree(c) for c in comps if '_mainTL' in idx.tree(c))
    def playable(key):
        d = idx.tree(key)
        if idx.obj(key).type.name == 'GameObject':
            for p in d['m_Component']:
                cd = idx.tree(idx.ref(key[0], p['component']))
                if 'm_PlayableAsset' in cd:
                    return idx.ref(key[0], cd['m_PlayableAsset'])
        return idx.ref(key[0], d['m_PlayableAsset']) if 'm_PlayableAsset' in d else key
    entries = []
    def walk(key, origin=0., scale=1., stack=()):
        if key in stack: return
        d = idx.tree(key)
        if d.get('m_Muted'): return
        for c in d.get('m_Clips', []):
            ck = idx.ref(key[0], c['m_Asset']); cd = idx.tree(ck)
            start = origin + c['m_Start']/scale
            if '_sectionKind' in cd:
                entries.append(dict(start=round(start, 4), duration=round(c['m_Duration']/scale, 4), track=d.get('m_Name', ''),
                                    easeIn=c.get('m_EaseInDuration'), easeOut=c.get('m_EaseOutDuration'),
                                    blendIn=c.get('m_BlendInDuration'), blendOut=c.get('m_BlendOutDuration'), clipIn=c.get('m_ClipIn'),
                                    stageKind=cd['_stageKind'], sectionKind=cd['_sectionKind'],
                                    fields={k: v for k, v in cd.items() if not k.startswith('m_')}))
            if '_timelinePrefab' in cd:
                cs = scale*c['m_TimeScale']
                walk(playable(idx.ref(ck[0], cd['_timelinePrefab'])), start - c['m_ClipIn']/cs, cs, stack+(key,))
        for child in d.get('m_Children', []) + d.get('m_Tracks', []):
            if child.get('m_PathID'): walk(idx.ref(key[0], child), origin, scale, stack+(key,))
    walk(playable(idx.ref(stage[0], config['_mainTL'])))
    enums = enum_names({'PlaySection'})
    out = ROOT/'extractor/sound-source'/(a.stage.replace('.prefab', '').lower()+'-bgm.json')
    out.write_text(json.dumps(dict(stage=a.stage, stageOrder=config.get('_stageOrder'), entries=sorted(entries, key=lambda e: e['start']),
                                   enums={k: [{str(i): n for i, n in v.items()} for v in vs] for k, vs in enums.items()}), indent=1))
    print(json.dumps(sorted(entries, key=lambda e: e['start']))); print(json.dumps(enums)); print('->', out)


if __name__ == '__main__':
    main()
