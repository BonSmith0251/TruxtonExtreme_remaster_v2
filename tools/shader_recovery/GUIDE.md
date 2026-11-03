# Recovering a Truxton shader from its original bytecode

The reconstruction (`D:\games\TruxtonExRecon\Reconstructed`, Unity 2023.2.22f1, URP 16.0.6) contains dummy stubs for the
game's custom shaders: they keep the Properties block but render solid white. We replace each stub with an HLSL
reconstruction of the ORIGINAL program, read from its D3D11 bytecode. Do not invent looks; translate what the bytecode
does. Where it is genuinely ambiguous, choose the simplest reading and say so in a comment.

## Evidence per shader: `evidence/shader-recovery/<safe name>/`
- `shader.txt`: UnityPy export (properties, tags, pass states). Not valid ShaderLab; reference only.
- `passes.json`: every pass: name, tags (LIGHTMODE), render state, every variant (keywords), bindings.
- `<sub>_<pass>_<Name>_vs.asm` / `_ps.asm`: D3DDisassemble of the minimal-keyword variant of each pass/stage. The header
  comment maps registers to names, e.g. `// cb3[11].w = _GroundNormalIntensity`, `// t5 = _GrassAlbed`.
  `cbN[i].c` = byte offset 16*i+4*c of the buffer at slot N. Non-SRP CG shaders (TATSUJIN/*, TXE/AE/*) often have no
  header: their `cb0` is the material buffer in Properties order (Unity packs float4 / float in declaration order) and
  `t0..` follow texture declaration order. Built-in globals (unity_ObjectToWorld, unity_MatrixVP, _Time, fog params)
  appear as other cbuffers; recognise them by use.
- Vertex input/outputs: read the signatures at the top of each asm (POSITION, TEXCOORD0, COLOR...).

To dump a non-minimal variant (e.g. with `_USEFOG_ON`), you may run (read-only on the game):
`C:\Python311\python.exe -I D:\games\TruxtonExRecon\tools\shader_recovery\dump_shaders.py "D:/games/Truxton Extreme" <some scratch dir> "<shader name>" --keywords _USEFOG_ON`
Write such extra dumps to a scratch directory, NOT into evidence/.

## What you write
1. A body file `Reconstructed/Assets/Shaders/Recovered/<short name>.hlsl`.
2. A spec fragment `tools/shader_recovery/specs.d/<your batch>.json`: `{ "<exact original shader name>": {"kind": ...,
   "body": "<short name>.hlsl", "defines": [...], "pragmas": [...], "note": "<one line: what it does>"} }`.
Do NOT edit stub .shader files, specs.json, other batches' files, the shared include, or anything else in the project.
Do NOT run Unity (one editor owns the project); the coordinator compiles and renders. Make the HLSL compile-clean by
care: declare everything you use, match types, no undefined helpers.

### kind "sg-lit" / "sg-unlit" (Shader Graph URP Lit / Unlit sub-targets)
The generator wraps your body in Forward/GBuffer/ShadowCaster/DepthOnly/DepthNormals passes with the original render
states, after `#include "Assets/Shaders/TruxtonRecoveredSG.hlsl"` (read it: structs TxSurfaceInput,
TxSurface; helpers TxTriplanar, TxTriplanarNormalWS, TxWorldToTangent, TxTangentToWorld, TxNormalStrength). The body
declares `CBUFFER_START(UnityPerMaterial) ... CBUFFER_END` with every material property the shader uses, the textures
(`TEXTURE2D(_X); SAMPLER(sampler_X);`), and
`void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)` setting albedo (Unlit: the output colour), normalWS,
metallic, smoothness, occlusion, emission, alpha, alphaClip. Vertex displacement: `#define TX_HAS_VERTEX_FUNCTION` in
spec "defines" and implement `void TxVertexFunction(inout TxVertexInput v)` (object space). Time: `_TimeParameters.x`
(Shader Graph Time). Scene colour (distortion): `#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"` and
`SampleSceneColor(uv)`; scene depth: DeclareDepthTexture.hlsl + `SampleSceneDepth(uv)`, `LinearEyeDepth(d, _ZBufferParams)`.
Flags (spec "defines"): TX_TRANSPARENT / TX_ALPHATEST are set automatically from the original blend state and queue;
add TX_NOFOG if the graph does no fog (check the Forward ps for unity_FogParams use). Optional "passes": subset of
["Universal Forward","GBuffer","ShadowCaster","DepthOnly","DepthNormals"] (only those the original has are emitted).
Worked example: `Recovered/sg_bgmap_triplaner_grassrock1.hlsl` (verified in game frames).
In Shader Graph code, the Lit lighting (PBR, SH, shadows, additional lights loop, fog) after the surface values is
URP's own; stop reading once you know albedo/normal/metallic/smoothness/occlusion/emission/alpha.

### kind "custom" (hand-written CG/HLSL shaders: TATSUJIN/*, TXE/AE/*, KANAI/*, UI/*)
The generator emits one Pass per original pass with its original tags and render state, containing
`#pragma vertex vert`, `#pragma fragment frag`, `#define TX_PASS_<index>`, your spec "defines"/"pragmas", and
`#include` of your body. The body must be self-contained: include
`Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl`, declare the material CBUFFER
(`CBUFFER_START(UnityPerMaterial)`), textures, structs, `vert` and `frag` (use `#if defined(TX_PASS_1)` for multi-pass).
Use URP equivalents for built-ins: TransformObjectToHClip, TransformObjectToWorld, GetWorldSpaceViewDir, _Time,
`ComputeFogFactor`/`MixFog` (+ `#pragma multi_compile_fog`). Material keywords from KeywordEnum/Toggle properties
become `#pragma shader_feature_local _X_OFF _X_ON` (put pragmas in the spec). Keep the original property and keyword
names exactly; materials bind by name. Optional "passes": list of original pass indices to emit.

## Report back
For each shader: kind, what the original computes (2-3 lines), anything uncertain or deliberately omitted, and
which variants/keywords you covered. Keep the report concise.
