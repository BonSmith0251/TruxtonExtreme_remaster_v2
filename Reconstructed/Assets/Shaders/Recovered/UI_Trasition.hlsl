// Recovered from UI/Trasition (evidence/shader-recovery/UI_Trasition, pass 0 "Trasition").
// Rule-texture screen transition for uGUI. color = vcolor * _Color; the vertex/colour ALPHA is the progress:
//     discard where _RuleTex.a - (1 - color.a) * 1.001 < 0      (_RuleTex sampled at the _MainTex uv)
//     c = (_MainTex + _TextureSampleAdd) * float4(color.rgb, 1)
//     UNITY_UI_CLIP_RECT: c.a *= soft rect mask (2022 UI-Default style, _UIMaskSoftnessX/Y)
//     UNITY_UI_ALPHACLIP: discard where c.a < 0.001
//     out = (c.rgb * c.a, c.a)   (premultiplied, Blend One OneMinusSrcAlpha from the state)
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _Color;
    float4 _MainTex_ST;
CBUFFER_END
// Set by the UI system (not in the Properties block).
float4 _TextureSampleAdd;
float4 _ClipRect;
float _UIMaskSoftnessX;
float _UIMaskSoftnessY;
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);
TEXTURE2D(_RuleTex); SAMPLER(sampler_RuleTex);

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
    float4 mask : TEXCOORD2;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
    o.color = v.color * _Color;
    o.uv = v.uv * _MainTex_ST.xy + _MainTex_ST.zw;
    o.worldPosition = v.positionOS;
    float2 pixelSize = o.positionCS.w / abs(mul((float2x2)GetViewToHClipMatrix(), _ScreenParams.xy));
    float4 clampedRect = clamp(_ClipRect, -2e10, 2e10);
    o.mask = float4(v.positionOS.xy * 2.0 - clampedRect.xy - clampedRect.zw,
                    0.25 / (0.25 * float2(_UIMaskSoftnessX, _UIMaskSoftnessY) + abs(pixelSize)));
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float rule = SAMPLE_TEXTURE2D(_RuleTex, sampler_RuleTex, i.uv).a;
    clip(rule - (1.0 - i.color.a) * 1.001);

    float4 c = (SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv) + _TextureSampleAdd) * float4(i.color.rgb, 1.0);
#if defined(UNITY_UI_CLIP_RECT)
    float2 m = saturate((_ClipRect.zw - _ClipRect.xy - abs(i.mask.xy)) * i.mask.zw);
    c.a *= m.x * m.y;
#endif
#if defined(UNITY_UI_ALPHACLIP)
    clip(c.a - 0.001);
#endif
    c.rgb *= c.a;
    return c;
}
