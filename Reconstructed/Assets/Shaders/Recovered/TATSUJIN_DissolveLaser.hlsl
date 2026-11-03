// Recovered from TATSUJIN/DissolveLaser (evidence/shader-recovery/TATSUJIN_DissolveLaser, pass 0).
// vs: ObjectToWorld -> MatrixVP, colour passed through, uv = TRANSFORM_TEX(uv, _MainTex).
// ps: the strip is one cell of a horizontal sheet of floor(_Divided) cells:
//       u' = (fmod(int(_StartIndex), floor(_Divided)) + uv.x) / _Divided, v' = uv.y
//     _DisolveTex at (u',v'): discard where dot(rgb, (0.3,0.6,0.1)) < _Threshold.
//     col = _MainTex(u',v') * vcolor * _TintColor * (2 - _Threshold); alpha saturated.
// Soft particles (SOFTPARTICLES_ON): alpha *= saturate(_InvFade * (sceneEyeZ - eyeZ)), as the original variant.
// FOG_* variants of the original compute a fog coordinate but the ps never applies it, so no fog here.
// _FlipStartPos / FRIP_START_POS is not a keyword of the compiled shader (no variants use it): ignored.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
#if defined(SOFTPARTICLES_ON)
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
#endif

CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_ST;
    float _Divided;
    float _StartIndex;   // declared int in the original program (itof)
    float _Threshold;
    float4 _TintColor;
    float _InvFade;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);
TEXTURE2D(_DisolveTex); SAMPLER(sampler_DisolveTex);

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

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    float3 positionWS = TransformObjectToWorld(v.positionOS.xyz);
    o.positionCS = TransformWorldToHClip(positionWS);
    o.color = v.color;
    o.uv = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
#if defined(SOFTPARTICLES_ON)
    o.projPos = ComputeScreenPos(o.positionCS);
    o.projPos.z = -TransformWorldToView(positionWS).z;
#endif
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float cells = floor(_Divided);
    float start = (float)(int)_StartIndex;
    float2 uv = float2((fmod(start, cells) + i.uv.x) * (1.0 / _Divided), i.uv.y);

    float3 dissolve = SAMPLE_TEXTURE2D(_DisolveTex, sampler_DisolveTex, uv).rgb;
    clip(dot(dissolve, float3(0.3, 0.6, 0.1)) < _Threshold ? -1.0 : 1.0);

    float4 vcol = i.color;
#if defined(SOFTPARTICLES_ON)
    float sceneZ = LinearEyeDepth(SampleSceneDepth(i.projPos.xy / i.projPos.w), _ZBufferParams);
    vcol.a *= saturate(_InvFade * (sceneZ - i.projPos.z));
#endif
    float4 col = vcol * (2.0 - _Threshold) * _TintColor;
    col *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv);
    col.a = saturate(col.a);
    return col;
}
