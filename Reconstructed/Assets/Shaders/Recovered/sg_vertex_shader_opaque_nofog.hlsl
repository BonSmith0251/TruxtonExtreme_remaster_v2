// Recovered from Shader Graphs/sg_vertex_shader_opaque_nofog, Universal Forward vs/ps (evidence/shader-recovery).
// Vertex (every pass): Shader Graph Simple Noise (deterministic Tchou hash) of object-space XY + _SeedV3.xy scrolled
// by -t * _LocalNoiseSpeed in Y, scale _LocalNoiseScale, times 1.48, inflates the vertex along its own position:
// pos += pos * _VertexInflat * noise; t = _TimeParameters.x * _Tx_SpeedRate. Normals are not changed.
// Surface: Lit PBR from UV0 maps (albedo RGB, normal map, metallic R / smoothness A * _Smooth, no occlusion map);
// emission = F * HDR(_FresnelEdgeColor) + HDR(_EmissionColor) * emissionMap.rgb, F = pow(1 - saturate(N.V),
// _FrensnelIntencity) on the vertex normal, zero when _FresnelOn = 0. No fog. _LocalNoisePower is unused.
CBUFFER_START(UnityPerMaterial)
    float _LocalNoiseScale;
    float _FrensnelIntencity;
    float4 _EmissionColor;
    float4 _FresnelEdgeColor;
    float4 _Tx_Albed_TexelSize;
    float4 _Tx_Metaric_TexelSize;
    float4 _Tx_Normal_TexelSize;
    float4 _Tx_Emission_TexelSize;
    float _Smooth;
    float _FresnelOn;
    float _VertexInflat;
    float _LocalNoiseSpeed;
    float _LocalNoisePower;
    float3 _SeedV3;
CBUFFER_END
float _Tx_SpeedRate; // global set by the game (0 if never set: the noise then holds still)
TEXTURE2D(_Tx_Normal); SAMPLER(sampler_Tx_Normal);
TEXTURE2D(_Tx_Metaric); SAMPLER(sampler_Tx_Metaric);
TEXTURE2D(_Tx_Albed); SAMPLER(sampler_Tx_Albed);
TEXTURE2D(_Tx_Emission); SAMPLER(sampler_Tx_Emission);

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

void TxVertexFunction(inout TxVertexInput v)
{
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float2 uv = v.positionOS.xy + _SeedV3.xy - float2(0.0, t * _LocalNoiseSpeed);
    float n = RecSimpleNoise(uv, _LocalNoiseScale) * 1.48;
    v.positionOS += n * (v.positionOS * _VertexInflat);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy;
    float3 albedo = SAMPLE_TEXTURE2D(_Tx_Albed, sampler_Tx_Albed, uv).rgb;
    float3 normalTS = TxUnpackNormal(SAMPLE_TEXTURE2D(_Tx_Normal, sampler_Tx_Normal, uv));
    float4 metal = SAMPLE_TEXTURE2D(_Tx_Metaric, sampler_Tx_Metaric, uv);
    float3 em = SAMPLE_TEXTURE2D(_Tx_Emission, sampler_Tx_Emission, uv).rgb;

    float fresnel = TxPow(1.0 - saturate(dot(i.normalWS, i.viewDirWS)), _FrensnelIntencity);
    fresnel = _FresnelOn != 0 ? fresnel : 0.0;

    s.albedo = albedo;
    s.normalWS = TxTangentToWorld(normalTS, i);
    s.metallic = saturate(metal.r);
    s.smoothness = saturate(metal.a * _Smooth);
    s.occlusion = 1;
    s.emission = fresnel * RecHdrColor(_FresnelEdgeColor.rgb) + RecHdrColor(_EmissionColor.rgb) * em;
}
