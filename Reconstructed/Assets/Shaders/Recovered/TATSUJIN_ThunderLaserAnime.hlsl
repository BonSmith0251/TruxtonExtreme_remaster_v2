// Recovered from TATSUJIN/ThunderLaserAnime (evidence/shader-recovery/TATSUJIN_ThunderLaserAnime, pass 0).
// Same program as TATSUJIN/SpriteAnime without the fog keyword:
// vs: ObjectToWorld -> MatrixVP, colour passed through. Sprite-sheet cell from _AIndex (an int in the original):
//       uv0 = TRANSFORM_TEX(uv, _MainTex); col = fmod(A, floor(H));
//       row = fmod((V - 1) - floor(A / H), floor(H))   (sic, as the vs does)
//       uv  = (uv0 + (col, row)) / (H, V)
// ps: col = 2 * vcolor * _TintColor * _MainTex, alpha saturated. Blend/cull/ztest/zwrite are material enums.
// Soft particles (SOFTPARTICLES_ON): vertex alpha *= saturate(_InvFade * (sceneEyeZ - eyeZ)).
// FOG_* variants of the original compute nothing that the ps uses: no fog.
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
    float2 uv : TEXCOORD0;
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
    o.uv = TxSpriteSheetUV(v.uv * _MainTex_ST.xy + _MainTex_ST.zw);
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
    col *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv);
    col.a = saturate(col.a);
    return col;
}
