// Recovered from Shader Graphs/sg_overlaid_fire, Universal Forward ps (evidence/shader-recovery). URP Unlit, additive
// (SrcAlpha One). A Shader Graph Triplanar (Default, blend 1) of _Texture2D whose projection position is the
// object-space position and whose blend normal is the object-space normal, both run through a Hue node (Degrees,
// offset t*_TexScrollSpeed) first, so the projection churns over time; position scaled by _Tiling. Then
// c = tri.rgb * _TexIntensity * SimpleNoise(uv0 + t*_NoizeScroolSpeed, _NoizeScal) * _NoizeIntensity,
// m = smoothstep(_AlphaEdge1, _AlphaEdge2, c*_Intensity), rgb = c*_Intensity*sRGB(_ColorOut) * m*sRGB(_ColorIn), alpha = m.r.
// Colour properties go through the graph's linear->sRGB Colorspace Conversion. t = _TimeParameters.x * _Tx_SpeedRate.
// No fog and no vertex colour in the original graph.
CBUFFER_START(UnityPerMaterial)
    float4 _Texture2D_TexelSize;
    float _Tiling;
    float _TexScrollSpeed;
    float4 _ColorOut;
    float4 _ColorIn;
    float _NoizeScroolSpeed;
    float _NoizeScal;
    float _NoizeIntensity;
    float _Intensity;
    float _TexIntensity;
    float _AlphaEdge2;
    float _AlphaEdge1;
CBUFFER_END
TEXTURE2D(_Texture2D); SAMPLER(sampler_Texture2D);

// Game-wide time scale (a global set by the game's code; 0 when never set, which freezes the animation).
float _Tx_SpeedRate;

// Shader Graph (Core RP 16) Hash_Tchou_2_1 + deterministic Simple Noise (3-octave value noise), as compiled.
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
float TxBValueNoise(float2 uv)
{
    float2 i = floor(uv);
    float2 f = frac(uv);
    f = f * f * (3.0 - 2.0 * f);
    float r0 = TxBHash01(i);
    float r1 = TxBHash01(i + float2(1, 0));
    float r2 = TxBHash01(i + float2(0, 1));
    float r3 = TxBHash01(i + float2(1, 1));
    return lerp(lerp(r0, r1, f.x), lerp(r2, r3, f.x), f.y);
}
float TxBSimpleNoise(float2 uv, float scale)
{
    return TxBValueNoise(uv * scale) * 0.125
         + TxBValueNoise(uv * (scale * 0.5)) * 0.25
         + TxBValueNoise(uv * (scale * 0.25)) * 0.5;
}

// Shader Graph Hue node, Degrees mode.
float3 TxBHueDegrees(float3 In, float offset)
{
    float4 K = float4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
    float4 P = lerp(float4(In.bg, K.wz), float4(In.gb, K.xy), step(In.b, In.g));
    float4 Q = lerp(float4(P.xyw, In.r), float4(In.r, P.yzx), step(P.x, In.r));
    float D = Q.x - min(Q.w, Q.y);
    float E = 1e-10;
    float V = (D == 0) ? Q.x : (Q.x + E);
    float3 hsv = float3(abs(Q.z + (Q.w - Q.y) / (6.0 * D + E)), D / (Q.x + E), V);
    float hue = hsv.x + offset / 360;
    hsv.x = (hue < 0) ? hue + 1 : (hue > 1) ? hue - 1 : hue;
    float4 K2 = float4(1.0, 2.0 / 3.0, 1.0 / 3.0, 3.0);
    float3 P2 = abs(frac(hsv.xxx + K2.xyz) * 6.0 - K2.www);
    return hsv.z * lerp(K2.xxx, saturate(P2 - K2.xxx), hsv.y);
}

// Shader Graph Colorspace Conversion Linear -> RGB, constants as in the original bytecode.
float3 TxBLinearToSRGB(float3 c)
{
    float3 lo = c * 12.92321;
    float3 hi = pow(abs(c), float3(1.0 / 2.4, 1.0 / 2.4, 1.0 / 2.4)) * 1.055 - 0.055;
    return float3(c.x <= 0.0031308 ? lo.x : hi.x, c.y <= 0.0031308 ? lo.y : hi.y, c.z <= 0.0031308 ? lo.z : hi.z);
}

// Shader Graph Smoothstep as compiled: saturate((x - e1) / (e2 - e1)), cubic.
float3 TxBSmoothstep3(float e1, float e2, float3 x)
{
    float3 k = saturate((x - e1) * (1.0 / (e2 - e1)));
    return k * k * (3 - 2 * k);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float hueOffset = t * _TexScrollSpeed;

    float noise = TxBSimpleNoise(i.uv0.xy + t * _NoizeScroolSpeed, _NoizeScal) * _NoizeIntensity;

    float3 nOS = TransformWorldToObjectNormal(i.normalWS); // normalized, as in the original
    float3 w = max(abs(TxBHueDegrees(nOS, hueOffset)), 1.192092896e-07); // SafePositivePow(x, 1)
    w /= dot(w, 1.0);
    float3 p = TxBHueDegrees(i.positionOS, hueOffset) * _Tiling;
    float3 tri = TxTriplanar(TEXTURE2D_ARGS(_Texture2D, sampler_Texture2D), p, w).rgb * _TexIntensity;

    float3 c = noise * tri * _Intensity;
    float3 m = TxBSmoothstep3(_AlphaEdge1, _AlphaEdge2, c);
    s.albedo = c * TxBLinearToSRGB(_ColorOut.rgb) * (m * TxBLinearToSRGB(_ColorIn.rgb));
    s.alpha = m.r;
}
