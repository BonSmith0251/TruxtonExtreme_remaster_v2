// Recovered from TATSUJIN/EffectCommon (evidence/shader-recovery/TATSUJIN_EffectCommon, pass 0).
// vs: ObjectToWorld -> MatrixVP, uv = TRANSFORM_TEX(uv, _MainTex), colour passed through.
// ps: col = 2 * vcolor * _TintColor * _MainTex (alpha NOT saturated). Blend/ZTest/ZWrite/Cull are material enums.
// Fog (FOG_LINEAR/EXP/EXP2 variants): rgb faded towards black by the fog factor, alpha untouched
// (UNITY_APPLY_FOG_COLOR(.., 0) in the original).
// The original SOFTPARTICLES_ON variant is identical to the base one (no depth fade), so it is not implemented.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_ST;
    float4 _TintColor;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);

struct Attributes
{
    float4 positionOS : POSITION;
    float2 uv : TEXCOORD0;
    float4 color : COLOR;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
    float3 uvFog : TEXCOORD0;   // xy uv, z fog factor
    float4 color : COLOR;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
    o.uvFog.xy = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
    o.uvFog.z = ComputeFogFactor(o.positionCS.z);
    o.color = v.color;
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 col = (i.color + i.color) * _TintColor;
    col *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uvFog.xy);
    col.rgb = MixFogColor(col.rgb, float3(0.0, 0.0, 0.0), i.uvFog.z);
    return col;
}
