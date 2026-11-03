// Recovered from TATSUJIN/SpriteAnime (evidence/shader-recovery/TATSUJIN_SpriteAnime, pass 0).
// vs: ObjectToWorld -> MatrixVP, colour passed through. Sprite-sheet cell from _AIndex (an int in the original):
//       uv0  = TRANSFORM_TEX(uv, _MainTex)
//       col  = fmod(A, floor(_DividedH))
//       row  = fmod((_DividedV - 1) - floor(A / _DividedH), floor(_DividedH))   (sic: the vs reduces the row by
//              floor(_DividedH) too; identical to the original for sheets with V <= H)
//       uv   = (uv0 + (col, row)) / (_DividedH, _DividedV)     (row 0 = top of the sheet)
// ps: col = 2 * vcolor * _TintColor * _MainTex, alpha saturated. Blend factors / ops, cull, ztest, zwrite are
//     material enums.
// Soft particles (SOFTPARTICLES_ON): vertex alpha *= saturate(_InvFade * (sceneEyeZ - eyeZ)).
// _USEFOG_OFF (every compiled variant of the original): no fog. _USEFOG_ON: no compiled variant exists in the
//     game; inferred like the sibling EffectCommon/NormalShot fog (rgb towards black by the fog factor).
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
#if defined(SOFTPARTICLES_ON)
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
#endif

CBUFFER_START(UnityPerMaterial)
    float4 _TintColor;
    float4 _MainTex_ST;
    float _DividedH;
    float _DividedV;
    float _AIndex;     // declared int in the original program (itof)
    float _InvFade;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);

struct Attributes
{
    float4 positionOS : POSITION;
    float4 color : COLOR;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
    float4 color : COLOR;
    float3 uvFog : TEXCOORD0;   // xy uv, z fog factor (_USEFOG_ON only)
#if defined(SOFTPARTICLES_ON)
    float4 projPos : TEXCOORD2;
#endif
};

float2 TxSpriteSheetUV(float2 uv0)
{
    float a = (float)(int)_AIndex;
    float cellsH = floor(_DividedH);
    float col = fmod(a, cellsH);
    float row = fmod((_DividedV - 1.0) - floor(a / _DividedH), cellsH);
    return (uv0 + float2(col, row)) * (1.0 / float2(_DividedH, _DividedV));
}

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    float3 positionWS = TransformObjectToWorld(v.positionOS.xyz);
    o.positionCS = TransformWorldToHClip(positionWS);
    o.color = v.color;
    o.uvFog.xy = TxSpriteSheetUV(v.uv * _MainTex_ST.xy + _MainTex_ST.zw);
#if defined(_USEFOG_ON)
    o.uvFog.z = ComputeFogFactor(o.positionCS.z);
#else
    o.uvFog.z = 0.0;
#endif
#if defined(SOFTPARTICLES_ON)
    o.projPos = ComputeScreenPos(o.positionCS);
    o.projPos.z = -TransformWorldToView(positionWS).z;
#endif
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 vcol = i.color;
#if defined(SOFTPARTICLES_ON)
    float sceneZ = LinearEyeDepth(SampleSceneDepth(i.projPos.xy / i.projPos.w), _ZBufferParams);
    vcol.a *= saturate(_InvFade * (sceneZ - i.projPos.z));
#endif
    float4 col = (vcol + vcol) * _TintColor;
    col *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uvFog.xy);
#if defined(_USEFOG_ON)
    col.rgb = MixFogColor(col.rgb, float3(0.0, 0.0, 0.0), i.uvFog.z);
#endif
    col.a = saturate(col.a);
    return col;
}
