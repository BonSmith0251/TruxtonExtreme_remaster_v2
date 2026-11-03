"""Install recovered shaders over the exporter's dummy stubs, keeping every stub's GUID and .meta.

Inputs
  specs.json (beside this script): { "<original shader name>": {"kind": "sg-lit"|"sg-unlit"|"custom",
        "body": "<file in Assets/Shaders/Recovered>", "defines": [...], "pragmas": [...],
        "passes": [...optional subset for sg kinds...], "note": "..."} }
  evidence/shader-recovery/<safe name>/passes.json   original pass names, tags and render states
  the stub files (found by their 'RecoveredStub/<name>' header, or a previous install's marker), backed up once

sg kinds generate Forward/GBuffer/ShadowCaster/DepthOnly/DepthNormals passes around TruxtonRecoveredSG.hlsl with the
original states of the matching pass. custom kind generates one pass per original pass that runs the body's
vert/frag (body may define TX_PASS_<index> branches). Properties come from the stub (the exporter recovered them).

usage: build_shaders.py <reconstruction root> [name ...]
"""
import json, os, re, shutil, sys, time

root = sys.argv[1]
assets = os.path.join(root, 'Reconstructed', 'Assets')
here = os.path.dirname(os.path.abspath(__file__))
specs = json.load(open(os.path.join(here, 'specs.json'), encoding='utf-8'))
for extra in sorted(os.listdir(os.path.join(here, 'specs.d'))) if os.path.isdir(os.path.join(here, 'specs.d')) else []:
    if extra.endswith('.json'):
        specs.update(json.load(open(os.path.join(here, 'specs.d', extra), encoding='utf-8')))
only = set(sys.argv[2:])
MARK = '// TRUXTON-RECOVERED-SHADER '
BACKUP = os.path.join(root, 'backups', 'before-shader-recovery')

BLEND = ['Zero', 'One', 'DstColor', 'SrcColor', 'OneMinusDstColor', 'SrcAlpha', 'OneMinusSrcColor', 'DstAlpha',
         'OneMinusDstAlpha', 'SrcAlphaSaturate', 'OneMinusSrcAlpha']
BLENDOP = ['Add', 'Sub', 'RevSub', 'Min', 'Max']
CMP = ['Disabled', 'Never', 'Less', 'Equal', 'LEqual', 'Greater', 'NotEqual', 'GEqual', 'Always']
CULL = ['Off', 'Front', 'Back']
STENCILOP = ['Keep', 'Zero', 'Replace', 'IncrSat', 'DecrSat', 'Invert', 'IncrWrap', 'DecrWrap']

def safe(name):
    return re.sub(r'[^A-Za-z0-9_.-]+', '_', name)

def val(v, table=None):
    if isinstance(v, list):
        return '[%s]' % v[1]
    v = int(round(v))
    return table[v] if table and 0 <= v < len(table) else str(v)

def state_lines(st, force_zwrite=None):
    b = st['blend']
    lines = []
    if [val(x) for x in b] != ['1', '0', '1', '0']:
        lines.append('Blend %s %s, %s %s' % tuple(val(x, BLEND) for x in b))
        if st['blendOp'] != [0.0, 0.0]:
            lines.append('BlendOp %s, %s' % tuple(val(x, BLENDOP) for x in st['blendOp']))
    cm = st['colMask']
    if cm != 15.0:
        lines.append('ColorMask %s' % ('[%s]' % cm[1] if isinstance(cm, list) else {0: '0'}.get(int(cm), ''.join(c for bit, c in ((8, 'R'), (4, 'G'), (2, 'B'), (1, 'A')) if int(cm) & bit))))
    lines.append('ZWrite %s' % (force_zwrite or ('[%s]' % st['zWrite'][1] if isinstance(st['zWrite'], list) else ('On' if st['zWrite'] else 'Off'))))
    lines.append('ZTest %s' % val(st['zTest'], CMP))
    lines.append('Cull %s' % val(st['culling'], CULL))
    if st['offsetFactor'] not in (0, 0.0) or st['offsetUnits'] not in (0, 0.0):
        lines.append('Offset %s, %s' % (val(st['offsetFactor']), val(st['offsetUnits'])))
    if st['stencilComp'] not in (8, 8.0) or st['stencilRef'] not in (0, 0.0):
        extra = ''
        for key, word, table in (('stencilReadMask', 'ReadMask', None), ('stencilWriteMask', 'WriteMask', None),
                                 ('stencilFail', 'Fail', STENCILOP), ('stencilZFail', 'ZFail', STENCILOP)):
            if key in st and st[key] not in ((255, 255.0) if 'Mask' in key else (0, 0.0)):
                extra += ' %s %s' % (word, val(st[key], table))
        lines.append('Stencil { Ref %s Comp %s Pass %s%s }' % (val(st['stencilRef']), val(st['stencilComp'], CMP), val(st['stencilPass'], STENCILOP), extra))
    return lines

def tags(d, keep=None):
    items = [(k, v) for k, v in d.items() if keep is None or k.upper() in keep]
    fix = {'QUEUE': 'Queue', 'LIGHTMODE': 'LightMode', 'RENDERTYPE': 'RenderType', 'IGNOREPROJECTOR': 'IgnoreProjector',
           'PREVIEWTYPE': 'PreviewType', 'FORCENOSHADOWCASTING': 'ForceNoShadowCasting', 'CANUSESPRITEATLAS': 'CanUseSpriteAtlas'}
    return 'Tags { %s }' % ' '.join('"%s"="%s"' % (fix.get(k.upper(), k), v) for k, v in items)

def find_stubs(name):
    found = []
    for dp, dn, fn in os.walk(assets):
        for f in fn:
            if not f.endswith('.shader'):
                continue
            p = os.path.join(dp, f)
            with open(p, encoding='utf-8', errors='replace') as h:
                head = h.read(400)
            if head.startswith('Shader "RecoveredStub/%s"' % name) or (MARK + name + '\n') in head:
                found.append(p)
    return found

def backup_path(p):
    return os.path.join(BACKUP, os.path.relpath(p, os.path.join(root, 'Reconstructed')))

def properties_of(stub):
    text = open(stub, encoding='utf-8', errors='replace').read()
    i = text.index('Properties {')
    depth, j = 0, i + len('Properties ')
    while True:
        c = text[j]
        depth += c == '{'
        depth -= c == '}'
        j += 1
        if depth == 0:
            break
    return text[i:j]

def sg_passes(spec, orig):
    unlit = spec['kind'] == 'sg-unlit'
    defines = list(spec.get('defines', []))
    if unlit:
        defines.append('TX_UNLIT')
    by = {}
    for p in orig['passes']:
        by.setdefault(p['tags'].get('LIGHTMODE', p['tags'].get('LightMode', '')).upper(), p)
    fwd = by.get('UNIVERSALFORWARD') or orig['passes'][0]
    b = fwd['state']['blend']
    if [val(x) for x in b] != ['1', '0', '1', '0'] and 'TX_TRANSPARENT' not in defines:
        defines.append('TX_TRANSPARENT')
    q = orig['passes'][0]['subShaderTags'].get('QUEUE', '')
    if q.startswith('AlphaTest') and 'TX_ALPHATEST' not in defines:
        defines.append('TX_ALPHATEST')
    common = ['#pragma target 4.5', '#pragma multi_compile_instancing'] + ['#define %s' % d for d in defines] + spec.get('pragmas', [])
    lit = ['#pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN',
           '#pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS',
           '#pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS',
           '#pragma multi_compile_fragment _ _SHADOWS_SOFT'] if not unlit else []
    want = spec.get('passes', ['Universal Forward', 'GBuffer', 'ShadowCaster', 'DepthOnly', 'DepthNormals'])
    table = [('Universal Forward', 'UNIVERSALFORWARD', 'UniversalForward', 'TxVert', 'TxFragForward', lit + ['#pragma multi_compile_fog']),
             ('GBuffer', 'UNIVERSALGBUFFER', 'UniversalGBuffer', 'TxVert', 'TxFragGBuffer', lit + ['#pragma multi_compile_fragment _ _GBUFFER_NORMALS_OCT']),
             ('ShadowCaster', 'SHADOWCASTER', 'ShadowCaster', 'TxVertShadow', 'TxFragDepth', ['#pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW']),
             ('DepthOnly', 'DEPTHONLY', 'DepthOnly', 'TxVert', 'TxFragDepth', []),
             ('DepthNormals', 'DEPTHNORMALS', 'DepthNormals', 'TxVert', 'TxFragDepthNormals', [])]
    out = []
    for name, key, mode, vs, ps, pr in table:
        o = by.get(key) or (by.get('DEPTHNORMALSONLY') if key == 'DEPTHNORMALS' else None)
        if name not in want or o is None:
            continue
        st = state_lines(o['state'])
        out.append('\t\tPass {\n\t\t\tName "%s"\n\t\t\tTags { "LightMode"="%s" }\n%s\n\t\t\tHLSLPROGRAM\n%s\n\t\t\t#pragma vertex %s\n\t\t\t#pragma fragment %s\n\t\t\t#include "Assets/Shaders/TruxtonRecoveredSG.hlsl"\n\t\t\t#include "Assets/Shaders/Recovered/%s"\n\t\t\tENDHLSL\n\t\t}' % (
            name, mode, '\n'.join('\t\t\t' + x for x in st), '\n'.join('\t\t\t' + x for x in common + pr), vs, ps, spec['body']))
    return out

def custom_passes(spec, orig):
    out = []
    for n, p in enumerate(orig['passes']):
        if 'passes' in spec and n not in spec['passes']:
            continue
        st = state_lines(p['state'])
        pt = {k: v for k, v in p['tags'].items()}
        name = '\t\t\tName "%s"\n' % p['name'] if p.get('name') else ''
        prag = ['#pragma target 3.5', '#define TX_PASS_%d' % n] + ['#define %s' % d for d in spec.get('defines', [])] + spec.get('pragmas', [])
        out.append('\t\tPass {\n%s\t\t\t%s\n%s\n\t\t\tHLSLPROGRAM\n%s\n\t\t\t#pragma vertex vert\n\t\t\t#pragma fragment frag\n\t\t\t#include "Assets/Shaders/Recovered/%s"\n\t\t\tENDHLSL\n\t\t}' % (
            name, tags(pt) if pt else 'Tags { }', '\n'.join('\t\t\t' + x for x in st), '\n'.join('\t\t\t' + x for x in prag), spec['body']))
    return out

def build(name, spec):
    orig = json.load(open(os.path.join(root, 'evidence', 'shader-recovery', safe(name), 'passes.json')))
    stubs = find_stubs(name)
    if not stubs:
        raise SystemExit('no stub for ' + name)
    for s in stubs:
        b = backup_path(s)
        if not os.path.exists(b):
            os.makedirs(os.path.dirname(b), exist_ok=True)
            shutil.copy2(s, b)
    props = properties_of(backup_path(stubs[0]))
    sub = orig['passes'][0]['subShaderTags']
    passes = custom_passes(spec, orig) if spec['kind'] == 'custom' else sg_passes(spec, orig)
    lod = orig['passes'][0].get('lod')
    text = '%s%s\n// Generated by tools/shader_recovery/build_shaders.py from the original D3D11 programs.\n// %s\nShader "%s" {\n\t%s\n\tSubShader {\n\t\t%s\n%s%s\n\t}\n\tFallback Off\n}\n' % (
        MARK, name, spec.get('note', ''), name, props.replace('\n', '\n\t'), tags(sub), ('\t\tLOD %d\n' % lod) if lod else '', '\n'.join(passes))
    for s in stubs:
        with open(s, 'w', encoding='utf-8', newline='\n') as h:
            h.write(text)
    return stubs

log = []
for name, spec in specs.items():
    if only and name not in only:
        continue
    stubs = build(name, spec)
    log.append({'shader': name, 'kind': spec['kind'], 'body': spec['body'], 'files': [os.path.relpath(s, root).replace(os.sep, '/') for s in stubs]})
    print(name, '->', len(stubs), 'files')
os.makedirs(os.path.join(root, 'evidence', 'shader-recovery'), exist_ok=True)
json.dump({'time': time.strftime('%Y-%m-%dT%H:%M:%S'), 'installed': log}, open(os.path.join(root, 'evidence', 'shader-recovery', 'install-log.json'), 'w'), indent=1)
