// Recovered from Shader Graphs/sg_distortion_fade, Universal Forward ps (evidence/shader-recovery). URP Unlit, alpha blend.
// Screen-space refraction: samples _CameraOpaqueTexture at the fragment's screen UV offset (both axes by the same
// amount) by lerp(-0.001, 0.001, v) * _Intensity, where v is either Shader Graph Gradient Noise of
// (uv0 + t*_ScrollSpeed) at scale _Scale (_NoizeOrRipple on), or a ripple sin(d*_Scale - 1) * frac(sin(d*_Scale - t*_ScrollSpeed))
// with d = length(viewZ.xx - 0.5) of the fragment's view-space z (off). t = _TimeParameters.x * _Tx_SpeedRate (game
// global). Same graph as sg_distortion except output alpha = _Transparency (no vertex colour). No fog in the original.
// Needs the URP asset's Opaque Texture enabled.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

CBUFFER_START(UnityPerMaterial)
    float _Scale;
    float _ScrollSpeed;
    float _NoizeOrRipple;
    float _Intensity;
    float _Transparency;
CBUFFER_END

// Game-wide time scale (a global set by the game's code; 0 when never set, which freezes the animation).
float _Tx_SpeedRate;

// Shader Graph (Core RP 16) Hash_Tchou_2_1 + deterministic Gradient Noise, as compiled in the original.
float TxBHash01(float2 p)
{
    uint2 v = (uint2)(int2)round(p);
    v.y ^= 1103515245u;
    v.x += v.y;
    v.x *= v.y;
    v.x ^= v.x >> 5u;
    v.x *= 0x27d4eb2du;
    return (v.x >> 8) * (1.0 / float(0x00ffffff));
}
float2 TxBGradientDir(float2 p)
{
    float x = TxBHash01(p);
    return normalize(float2(x - floor(x + 0.5), abs(x) - 0.5));
}
float TxBGradientNoise(float2 uv, float scale)
{
    float2 p = uv * scale;
    float2 ip = floor(p);
    float2 fp = frac(p);
    float d00 = dot(TxBGradientDir(ip), fp);
    float d01 = dot(TxBGradientDir(ip + float2(0, 1)), fp - float2(0, 1));
    float d10 = dot(TxBGradientDir(ip + float2(1, 0)), fp - float2(1, 0));
    float d11 = dot(TxBGradientDir(ip + float2(1, 1)), fp - float2(1, 1));
    fp = fp * fp * fp * (fp * (fp * 6 - 15) + 10);
    return lerp(lerp(d00, d01, fp.y), lerp(d10, d11, fp.y), fp.x) + 0.5;
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float scroll = t * _ScrollSpeed;
    float noise = TxBGradientNoise(i.uv0.xy + scroll, _Scale);

    float viewZ = TransformWorldToView(i.positionWS).z;
    float d = length(float2(viewZ, viewZ) - 0.5);
    float ripple = sin(d * _Scale - 1) * frac(sin(d * _Scale - scroll));

    float v = (_NoizeOrRipple != 0) ? noise : ripple;
    float offset = v * 0.002 - 0.001;
    float2 uv = i.screenPosition.xy + offset * _Intensity;

    s.albedo = SampleSceneColor(uv);
    s.alpha = _Transparency;
}
