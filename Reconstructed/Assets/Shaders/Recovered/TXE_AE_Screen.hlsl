// Recovered from TXE/AE/Screen (evidence/shader-recovery/TXE_AE_Screen). After-Effects-style uGUI blend mode.
// vs (all TXE/AE shaders share it, UI-Default): ObjectToWorld -> MatrixVP, color = vcolor * _Color,
//     uv = TRANSFORM_TEX(uv, _MainTex), worldPosition = object-space vertex (for the clip rect).
// ps: c = (_MainTex + _TextureSampleAdd) * color
//     UNITY_UI_CLIP_RECT: c.a *= UnityGet2DClipping(worldPosition.xy, _ClipRect) (hard step test)
//     UNITY_UI_ALPHACLIP: discard where c.a < 0.001
// out = (c.rgb * c.a, c.a) with Blend One OneMinusSrcColor: dst + s - s * dst (screen).
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _Color;
    float4 _MainTex_ST;
CBUFFER_END
// Set by the UI system (not in the Properties block).
float4 _TextureSampleAdd;
float4 _ClipRect;
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
    float4 worldPosition : TEXCOORD1;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
    o.color = v.color * _Color;
    o.uv = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
    o.worldPosition = v.positionOS;
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 c = (SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv) + _TextureSampleAdd) * i.color;
#if defined(UNITY_UI_CLIP_RECT)
    float2 inside = step(_ClipRect.xy, i.worldPosition.xy) * step(i.worldPosition.xy, _ClipRect.zw);
    c.a *= inside.x * inside.y;
#endif
#if defined(UNITY_UI_ALPHACLIP)
    clip(c.a - 0.001);
#endif
    return float4(c.rgb * c.a, c.a);
}
