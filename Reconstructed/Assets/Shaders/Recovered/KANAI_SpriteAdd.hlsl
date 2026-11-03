// Recovered from KANAI/SpriteAdd (evidence/shader-recovery/KANAI_SpriteAdd, pass 0).
// Unity's Sprites-Default program with Blend One One (additive, from the pass state):
// vs: vertex.xy *= flip, ObjectToWorld -> MatrixVP; colour = vcolor * _Color * renderer colour; uv unscaled.
//     PIXELSNAP_ON: clip.xy snapped to the pixel grid (round(clip.xy / w * _ScreenParams.xy / 2) ...).
// ps: c = _MainTex * colour (ETC1_EXTERNAL_ALPHA: tex.a = lerp(tex.a, _AlphaTex.r, _EnableExternalAlpha));
//     out = (c.rgb * c.a, c.a).
// The original reads the renderer colour / flip from UnityPerDrawSprite (_RendererColor, _Flip); URP 16 delivers
// them as unity_SpriteColor / unity_SpriteProps.xy (as URP's own Sprite-Unlit-Default does).
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _Color;
    float _EnableExternalAlpha;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);
#if defined(ETC1_EXTERNAL_ALPHA)
TEXTURE2D(_AlphaTex); SAMPLER(sampler_AlphaTex);
#endif

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
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    float3 positionOS = float3(v.positionOS.xy * unity_SpriteProps.xy, v.positionOS.z);
    o.positionCS = TransformObjectToHClip(positionOS);
#if defined(PIXELSNAP_ON)
    float2 halfScreen = _ScreenParams.xy * 0.5;
    o.positionCS.xy = round((o.positionCS.xy / o.positionCS.w) * halfScreen) / halfScreen * o.positionCS.w;
#endif
    o.color = v.color * _Color * unity_SpriteColor;
    o.uv = v.uv;
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv);
#if defined(ETC1_EXTERNAL_ALPHA)
    float alpha = SAMPLE_TEXTURE2D(_AlphaTex, sampler_AlphaTex, i.uv).r;
    tex.a = lerp(tex.a, alpha, _EnableExternalAlpha);
#endif
    float4 c = tex * i.color;
    c.rgb *= c.a;
    return c;
}
