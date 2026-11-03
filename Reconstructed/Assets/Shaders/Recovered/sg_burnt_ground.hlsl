// Recovered from Shader Graphs/sg_burnt_ground, Universal Forward ps (evidence/shader-recovery). Unlit, alpha-blended.
// colour = groundMap.rgb + HDR(_FlickerColor) * flickerMask.rgb * noise * pulse * 5, alpha = groundMap.a, where
// noise = Shader Graph Simple Noise (deterministic Tchou hash) of UV0 + t * _NoiseScrollSpeed at scale _NoiseScale,
// pulse = (sin(2pi * t * _FlickerSpeed) + 1) * 0.45 + 0.1, t = _TimeParameters.x * _Tx_SpeedRate. No fog.
CBUFFER_START(UnityPerMaterial)
    float2 _NoiseScrollSpeed;
    float _FlickerSpeed;
    float _NoiseScale;
    float4 _FlickerColor;
    float4 _Tx_BurntGround_TexelSize;
    float4 _Tx_FlickerMask_TexelSize;
CBUFFER_END
float _Tx_SpeedRate; // global set by the game (0 if never set: the embers then hold still)
TEXTURE2D(_Tx_BurntGround); SAMPLER(sampler_Tx_BurntGround);
TEXTURE2D(_Tx_FlickerMask); SAMPLER(sampler_Tx_FlickerMask);

// Shader Graph HDR colour property: converted to sRGB in a Gamma-space project (the original build is Gamma).
float3 RecHdrColor(float3 c)
{
#ifdef UNITY_COLORSPACE_GAMMA
    return LinearToSRGB(c);
#else
    return c;
#endif
}

// Shader Graph Simple Noise (Hash Type Deterministic): Hash_Tchou_2_1 value noise, 3 octaves.
float RecHashTchou(float2 p)
{
    uint2 v = (uint2)(int2)round(p);
    v.y ^= 1103515245u;
    v.x += v.y;
    v.x *= v.y;
    v.x ^= v.x >> 5u;
    v.x *= 0x27d4eb2du;
    return (v.x >> 8) * (1.0 / float(0x00ffffff));
}
float RecValueNoise(float2 uv)
{
    float2 i = floor(uv);
    float2 f = frac(uv);
    f = f * f * (3.0 - 2.0 * f);
    float r0 = RecHashTchou(i);
    float r1 = RecHashTchou(i + float2(1.0, 0.0));
    float r2 = RecHashTchou(i + float2(0.0, 1.0));
    float r3 = RecHashTchou(i + float2(1.0, 1.0));
    return lerp(lerp(r0, r1, f.x), lerp(r2, r3, f.x), f.y);
}
float RecSimpleNoise(float2 uv, float scale)
{
    return RecValueNoise(uv * scale) * 0.125 + RecValueNoise(uv * (scale * 0.5)) * 0.25 + RecValueNoise(uv * (scale * 0.25)) * 0.5;
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy;
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float pulse = (sin(t * _FlickerSpeed * 6.283185) + 1.0) * 0.45 + 0.1;
    float noise = RecSimpleNoise(uv + t * _NoiseScrollSpeed, _NoiseScale);
    float3 mask = SAMPLE_TEXTURE2D(_Tx_FlickerMask, sampler_Tx_FlickerMask, uv).rgb;
    float4 ground = SAMPLE_TEXTURE2D(_Tx_BurntGround, sampler_Tx_BurntGround, uv);

    s.albedo = ground.rgb + RecHdrColor(_FlickerColor.rgb) * mask * (noise * pulse * 5.0);
    s.alpha = ground.a;
}
