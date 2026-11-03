// Recovered from Shader Graphs/sg_flame02_additive (and, with TXB_FLAME_MULTIPLY, sg_flame02_multiply), Universal Forward
// vs/ps (evidence/shader-recovery). URP Unlit, two-sided, alpha clip at 0.5 (a constant in the graph).
// Vertex: positionOS += normalOS * 0.05 * SimpleNoise(uv0 + t*_VertexNoiseScrollSpeed, _VertexNoiseScale)
//         * _VertexNoiseIntensity * sin((t - u)*8) * sin((t - v)*16).
// Pixel: two scrolled samples of _Tx_Mask (uv0*_Tx1Scale + t*_Tx1SxrollSpeed, uv0*_Tx2Scale + t*_Tx2ScrollSpeed),
//        c = ((a*b + 1) * (_TxIntensity + 1) * 0.5 - 1) * (1 - v*_AlphaIntensity), then
//        c = saturate(c * (1 - 2*length(uv0 - (0.5, 0.2)) * v*_AlphaIntensity)). alpha = c.r * vertexColor.a;
//        colour = c * vertexColor.rgb * _ColoerIntensity. Additive (SrcAlpha One) outputs colour; Multiply
//        (DstColor Zero) outputs lerp(1, colour, alpha) as Shader Graph's multiply mode does.
// t = _TimeParameters.x * _Tx_SpeedRate (game global). No fog in the original graph. The alpha-to-mask sharpening path
// (_AlphaToMaskAvailable, MSAA only) is omitted: plain clip, as the original does without alpha-to-coverage.
CBUFFER_START(UnityPerMaterial)
    float4 _Tx_Mask_TexelSize;
    float2 _Tx1SxrollSpeed;
    float2 _Tx2ScrollSpeed;
    float2 _Tx1Scale;
    float2 _Tx2Scale;
    float _ColoerIntensity;
    float2 _VertexNoiseScrollSpeed;
    float _VertexNoiseScale;
    float _VertexNoiseIntensity;
    float _TxIntensity;
    float _AlphaIntensity;
CBUFFER_END
TEXTURE2D(_Tx_Mask); SAMPLER(sampler_Tx_Mask);

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

void TxVertexFunction(inout TxVertexInput v)
{
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float noise = TxBSimpleNoise(v.uv0.xy + t * _VertexNoiseScrollSpeed, _VertexNoiseScale) * _VertexNoiseIntensity;
    float wave = sin((t - v.uv0.y) * 16) * sin((t - v.uv0.x) * 8);
    v.positionOS += v.normalOS * (noise * wave * 0.05);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float2 uv = i.uv0.xy;
    float3 a = SAMPLE_TEXTURE2D(_Tx_Mask, sampler_Tx_Mask, uv * _Tx1Scale + t * _Tx1SxrollSpeed).rgb;
    float3 b = SAMPLE_TEXTURE2D(_Tx_Mask, sampler_Tx_Mask, uv * _Tx2Scale + t * _Tx2ScrollSpeed).rgb;
    float3 c = (a * b + 1) * (_TxIntensity + 1) * 0.5 - 1;
    float k = uv.y * _AlphaIntensity;
    c *= 1 - k;
    float d = length(uv - float2(0.5, 0.2));
    c = saturate(c * (1 - 2 * d * k));

    float alpha = c.r * i.color.a;
    float3 col = c * (i.color.rgb * _ColoerIntensity);
#ifdef TXB_FLAME_MULTIPLY
    s.albedo = alpha * (col - 1) + 1;
#else
    s.albedo = col;
#endif
    s.alpha = alpha;
    s.alphaClip = 0.5;
}
