// Recovered from TATSUJIN/NormalShot (evidence/shader-recovery/TATSUJIN_NormalShot, pass 0).
// vs: ObjectToWorld -> MatrixVP, colour passed through, uv = TRANSFORM_TEX(uv, _MainTex).
// ps: col = 2 * vcolor * _TintColor * _MainTex, alpha saturated (alpha blend, ZTest Always, RGB mask from state).
// Fog (FOG_* variants): rgb faded towards black by the fog factor (UNITY_APPLY_FOG_COLOR(.., 0)).
// Soft particles (SOFTPARTICLES_ON): vertex alpha *= saturate(_InvFade * (sceneEyeZ - eyeZ)).
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
#if defined(SOFTPARTICLES_ON)
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
#endif

CBUFFER_START(UnityPerMaterial)
    float4 _TintColor;
    float4 _MainTex_ST;
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
    float3 uvFog : TEXCOORD0;   // xy uv, z fog factor
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
    o.uvFog.xy = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
    o.uvFog.z = ComputeFogFactor(o.positionCS.z);
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
    col.rgb = MixFogColor(col.rgb, float3(0.0, 0.0, 0.0), i.uvFog.z);
    col.a = saturate(col.a);
    return col;
}
