// Recovered from TATSUJIN/DamageFlush (evidence/shader-recovery/TATSUJIN_DamageFlush, pass 0).
// vs: position only, ObjectToWorld then MatrixVP. ps: returns _Color unchanged (no texture, no vertex colour).
// Used as a flat hit-flash overlay; blend SrcAlpha/OneMinusSrcAlpha comes from the pass state.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _Color;
CBUFFER_END

struct Attributes
{
    float4 positionOS : POSITION;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    return _Color;
}
