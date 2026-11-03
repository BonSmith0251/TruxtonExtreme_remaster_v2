"""Dump original D3D11 shader programs from the installed game for reconstruction.

For each requested shader (by name, or --all-custom) this writes into <out>/<safe name>/:
  shader.txt      UnityPy's property/state export (not a valid shader; reference only)
  passes.json     per pass: name, tags, render state, every player variant (blob index + keyword names)
  <pass>_<stage>.asm  D3DDisassemble output of the minimal-keyword variant of each pass/stage
                      (plus any variants whose keyword set matches --keywords)

The decompressed D3D11 blob begins with int32 count, then count x (offset, length, segment) int32 triples. Player
subprograms reference entries by m_BlobIndex. Each code entry carries a DXBC container after a Unity prefix; its
size is the uint32 at +24 of the container, validated before disassembly with the system d3dcompiler_47.dll.
The game folder is only read.

usage: dump_shaders.py <game dir> <out dir> (--all-custom | name ...) [--keywords KW,KW]
"""
import ctypes, glob, json, os, re, struct, sys
import UnityPy
from UnityPy.helpers import CompressionHelper

STAGES = {'progVertex': 'vs', 'progFragment': 'ps', 'progGeometry': 'gs', 'progHull': 'hs', 'progDomain': 'ds'}
CUSTOM = re.compile(r'^(Shader Graphs/|TATSUJIN/|TXE/|KANAI/|UI/Trasition)')

class Blob(ctypes.Structure):
    pass
def disassemble(code):
    d3d = ctypes.WinDLL('d3dcompiler_47.dll')
    out = ctypes.c_void_p()
    hr = d3d.D3DDisassemble(code, len(code), 0, None, ctypes.byref(out))
    if hr != 0 or not out:
        return '// D3DDisassemble failed hr=0x%08x\n' % (hr & 0xffffffff)
    vtbl = ctypes.cast(ctypes.cast(out, ctypes.POINTER(ctypes.c_void_p))[0], ctypes.POINTER(ctypes.c_void_p))
    get_ptr = ctypes.WINFUNCTYPE(ctypes.c_void_p, ctypes.c_void_p)(vtbl[3])
    get_size = ctypes.WINFUNCTYPE(ctypes.c_size_t, ctypes.c_void_p)(vtbl[4])
    release = ctypes.WINFUNCTYPE(ctypes.c_ulong, ctypes.c_void_p)(vtbl[2])
    text = ctypes.string_at(get_ptr(out), get_size(out)).decode('utf-8', 'replace').rstrip('\0')
    release(out)
    return text

def entries(raw):
    n = struct.unpack_from('<i', raw, 0)[0]
    return [struct.unpack_from('<iii', raw, 4 + 12 * i) for i in range(n)]

def dxbc(entry):
    i = entry.find(b'DXBC')
    if i < 0:
        return None
    size = struct.unpack_from('<I', entry, i + 24)[0]
    if size < 32 or i + size > len(entry):
        return None
    return entry[i:i + size]

def names_of(p):
    return {i: n for n, i in p['m_NameIndices']}

# Common parameters of one stage: constant buffers (slot, size, members at byte offsets), textures (register, sampler).
# Disassembly cbN[i].c is byte offset 16*i + 4*c in the buffer bound at slot N.
def bindings(cp, names):
    n = lambda i: names.get(i, '#%d' % i)
    slots = {n(b['m_NameIndex']): b['m_Index'] for b in cp.get('m_ConstantBufferBindings', [])}
    cbs = []
    for cb in cp.get('m_ConstantBuffers', []):
        members = [{'name': n(v['m_NameIndex']), 'offset': v['m_Index'], 'dim': v['m_Dim'], 'array': v['m_ArraySize']} for v in cb.get('m_VectorParams', [])]
        members += [{'name': n(v['m_NameIndex']), 'offset': v['m_Index'], 'matrix': v.get('m_RowCount'), 'array': v['m_ArraySize']} for v in cb.get('m_MatrixParams', [])]
        cbs.append({'name': n(cb['m_NameIndex']), 'slot': slots.get(n(cb['m_NameIndex'])), 'size': cb['m_Size'],
                    'members': sorted(members, key=lambda m: m['offset'])})
    tex = [{'name': n(t['m_NameIndex']), 'register': t['m_Index'], 'sampler': t['m_SamplerIndex'], 'dim': t['m_Dim']} for t in cp.get('m_TextureParams', [])]
    samplers = [{'sampler': s.get('sampler'), 'bindPoint': s.get('bindPoint')} for s in cp.get('m_Samplers', [])]
    return {'constantBuffers': sorted(cbs, key=lambda c: (c['slot'] is None, c['slot'] or 0)), 'textures': sorted(tex, key=lambda t: t['register']), 'samplers': samplers}

def tokens(e):
    out = []; k = 4
    while k + 4 <= len(e):
        v = struct.unpack_from('<i', e, k)[0]
        if 2 <= v <= 96 and k + 4 + v <= len(e) and all(32 < c < 127 for c in e[k + 4:k + 4 + v]):
            out.append(e[k + 4:k + 4 + v].decode()); k += 4 + ((v + 3) // 4) * 4
        else:
            out.append(v); k += 4
    return out

# Per-variant parameter blob (version 202012090): constant buffers with member offsets, then texture entries
# (name, 0, register, sampler, dim) and constant-buffer bindings (name, 1, slot, 0). Parsed by that observed shape.
def variant_bindings(entry, common_cbs):
    t = tokens(entry)
    tex, slots, members = [], {}, {}
    cb = None
    for i, x in enumerate(t):
        if not isinstance(x, str):
            continue
        nxt = t[i + 1:i + 7]
        if len(nxt) >= 3 and nxt[0] == 1 and nxt[2] == 0 and all(isinstance(y, int) for y in nxt[:3]) and (len(nxt) < 4 or not isinstance(nxt[3], int) or nxt[3] == 0) and x in slots_names(t):
            slots[x] = nxt[1]
        elif len(nxt) >= 4 and all(isinstance(y, int) for y in nxt[:4]):
            if nxt[0] == 0 and nxt[1] >= 0 and nxt[3] in (2, 3, 4, 5, 6, 8) and (len(nxt) < 5 or isinstance(nxt[4], str)) and x not in members:
                tex.append({'name': x, 'register': nxt[1], 'sampler': nxt[2], 'dim': nxt[3]})
            elif nxt[0] == 1 and nxt[2] == 0 and x in slots_names(t):
                slots[x] = nxt[1]
            elif len(nxt) >= 6 and nxt[0] == 0 and all(isinstance(y, int) for y in nxt[:6]) and cb:
                members.setdefault(cb, []).append((x, nxt[5]))
            elif nxt[0] > 4:
                cb = x
    for name, ms in common_cbs.items():
        members.setdefault(name, ms)
    return {'textures': tex, 'cbSlots': slots, 'members': members}

def slots_names(t):
    return {x for i, x in enumerate(t) if isinstance(x, str) and i + 1 < len(t) and isinstance(t[i + 1], int) and t[i + 1] > 4}

def annotate(b):
    lines = []
    for name, slot in sorted(b['cbSlots'].items(), key=lambda x: x[1]):
        lines.append('// cb%d = %s' % (slot, name))
        for m, off in sorted(b['members'].get(name, []), key=lambda x: x[1]):
            lines.append('//   cb%d[%d].%s = %s' % (slot, off // 16, 'xyzw'[(off % 16) // 4], m))
    for x in sorted(b['textures'], key=lambda x: x['register']):
        lines.append('// t%d = %s (sampler index %d, dim %d)' % (x['register'], x['name'], x['sampler'], x['dim']))
    return '\n'.join(lines) + '\n'

def safe(name):
    return re.sub(r'[^A-Za-z0-9_.-]+', '_', name)

def state_summary(st):
    v = lambda x: (x['val'], x['name']) if x['name'] != '<noninit>' else x['val']
    b = st['rtBlend0']
    return {'blend': [v(b['srcBlend']), v(b['destBlend']), v(b['srcBlendAlpha']), v(b['destBlendAlpha'])],
            'blendOp': [v(b['blendOp']), v(b['blendOpAlpha'])], 'colMask': v(b['colMask']),
            'zTest': v(st['zTest']), 'zWrite': v(st['zWrite']), 'culling': v(st['culling']),
            'offsetFactor': v(st['offsetFactor']), 'offsetUnits': v(st['offsetUnits']),
            'stencilRef': v(st['stencilRef']), 'stencilComp': v(st['stencilOp']['comp']), 'stencilPass': v(st['stencilOp']['pass']),
            'stencilFail': v(st['stencilOp']['fail']), 'stencilZFail': v(st['stencilOp']['zFail']),
            'stencilReadMask': v(st['stencilReadMask']), 'stencilWriteMask': v(st['stencilWriteMask'])}

def main():
    args = sys.argv[1:]
    game, out = args[0], args[1]
    want_kw = set()
    if '--keywords' in args:
        i = args.index('--keywords'); want_kw = set(args[i + 1].split(',')); del args[i:i + 2]
    names = set(args[2:])
    allc = '--all-custom' in names
    os.makedirs(out, exist_ok=True)
    index = []
    for bundle in sorted(glob.glob(os.path.join(game, 'TATSUJIN EXTREME_Data', 'StreamingAssets', 'aa', 'StandaloneWindows64', '*.bundle'))):
        env = UnityPy.load(bundle)
        for obj in env.objects:
            if obj.type.name != 'Shader':
                continue
            t = obj.read_typetree()
            pf = t['m_ParsedForm']
            name = pf['m_Name']
            if not ((allc and CUSTOM.match(name)) or name in names):
                continue
            d = os.path.join(out, safe(name))
            os.makedirs(d, exist_ok=True)
            for old in glob.glob(os.path.join(d, '*.asm')):  # this tool's own earlier disassembly
                os.remove(old)
            try:
                open(os.path.join(d, 'shader.txt'), 'w', encoding='utf-8').write(obj.read().export())
            except Exception as e:
                open(os.path.join(d, 'shader.txt'), 'w').write('// export failed: %s\n' % e)
            kwn = pf['m_KeywordNames']
            blob = bytes(t['compressedBlob'])
            # Large blobs are split into several LZ4 chunks; table entries are (offset, length, chunk).
            segs = [CompressionHelper.decompress_lz4(blob[o:o + c], d) for o, c, d in
                    zip(t['offsets'][0], t['compressedLengths'][0], t['decompressedLengths'][0])]
            raw = segs[0]
            entry = lambda e: segs[e[2]][e[0]:e[0] + e[1]]
            table = entries(raw)
            passes = []
            for si, sub in enumerate(pf['m_SubShaders']):
                for pi, p in enumerate(sub['m_Passes']):
                    # Pass name and tags live in the pass state; the pass-level m_Tags is usually empty.
                    tags = dict(p['m_Tags']['tags'])
                    tags.update(dict(p['m_State'].get('m_Tags', {}).get('tags', [])))
                    pname = p['m_State'].get('m_Name') or p.get('m_Name') or ''
                    label = '%d_%d_%s' % (si, pi, safe(pname or tags.get('LIGHTMODE', 'pass')))
                    rec = {'label': label, 'name': pname, 'useName': p.get('m_UseName'), 'tags': tags,
                           'subShaderTags': dict(sub['m_Tags']['tags']), 'lod': sub.get('m_LOD'),
                           'state': state_summary(p['m_State']), 'programs': {}}
                    for key, stage in STAGES.items():
                        progs = [x for tier in p[key]['m_PlayerSubPrograms'] for x in tier]
                        if not progs:
                            continue
                        params = [i for tier in p[key]['m_ParameterBlobIndices'] for i in tier]
                        variants = [{'blob': x['m_BlobIndex'], 'params': params[n] if n < len(params) else None,
                                     'keywords': [kwn[k] for k in x['m_KeywordIndices']]} for n, x in enumerate(progs)]
                        common = {c['name']: [(m['name'], m['offset']) for m in c['members']]
                                  for c in bindings(p[key]['m_CommonParameters'], names_of(p))['constantBuffers']}
                        rec['programs'][stage] = variants
                        rec.setdefault('bindings', {})[stage] = bindings(p[key]['m_CommonParameters'], names_of(p))
                        chosen = [min(variants, key=lambda v: len(v['keywords']))]
                        chosen += [v for v in variants if want_kw and want_kw <= set(v['keywords']) and v not in chosen]
                        for n, v in enumerate(chosen):
                            code = dxbc(entry(table[v['blob']]))
                            asm = disassemble(code) if code else '// no DXBC in blob entry %d\n' % v['blob']
                            if v['params'] is not None:
                                asm = annotate(variant_bindings(entry(table[v['params']]), common)) + asm
                            fn = '%s_%s%s.asm' % (label, stage, '' if n == 0 else '_' + safe('-'.join(v['keywords']))[:80])
                            open(os.path.join(d, fn), 'w', encoding='utf-8').write('// keywords: %s\n%s' % (' '.join(v['keywords']), asm))
                    passes.append(rec)
            json.dump({'name': name, 'bundle': os.path.basename(bundle), 'path_id': str(obj.path_id), 'keywordNames': kwn,
                       'passes': passes}, open(os.path.join(d, 'passes.json'), 'w'), indent=1)
            index.append({'name': name, 'dir': safe(name), 'passes': [(x['label'], x['tags'].get('LightMode')) for x in passes]})
            print(name, len(passes), 'passes')
    json.dump(index, open(os.path.join(out, 'index.json'), 'w'), indent=1)

if __name__ == '__main__':
    main()
