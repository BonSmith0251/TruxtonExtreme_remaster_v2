// Recovered from TATSUJIN/Particle/Additive (evidence/shader-recovery/TATSUJIN_Particle_Additive, pass 0).
// vs: uv = TRANSFORM_TEX(uv, _MainTex), colour passed through, ObjectToWorld -> MatrixVP, then clip-space
//     z += _shifter (depth bias used to sort the effect against other geometry).
// ps: col = _MainTex * vcolor; discard where tex.a * vcolor.a < _ClipLevel. Blend SrcAlpha One from the state.
// _USEFOG_OFF (every compiled variant of the original): no fog, even under FOG_* keywords.
// _USEFOG_ON: no compiled variant exists in the game; inferred as Unity's additive-particle fog
//     (rgb faded towards black by the fog factor). Instancing as in the original INSTANCING_ON variants.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_ST;
    float _ClipLevel;
    float _shifter;
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
    float3 uvFog : TEXCOORD0;   // xy uv, z fog factor (_USEFOG_ON only)
    float4 color : COLOR;
    float4 positionCS : SV_POSITION;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    o.uvFog.xy = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
    o.color = v.color;
    o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
#if defined(_USEFOG_ON)
    o.uvFog.z = ComputeFogFactor(o.positionCS.z);
#else
    o.uvFog.z = 0.0;
#endif
    o.positionCS.z += _shifter;
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uvFog.xy);
    clip(tex.a * i.color.a - _ClipLevel);
    float4 col = tex * i.color;
#if defined(_USEFOG_ON)
    col.rgb = MixFogColor(col.rgb, float3(0.0, 0.0, 0.0), i.uvFog.z);
#endif
    return col;
}
