// Recovered from Shader Graphs/sg_emission_flicker_fogswitch, Universal Forward (evidence/shader-recovery).
// Same graph as sg_emission_FlickerDepth without the depth shift: Lit PBR from UV0 maps (albedo RGB, normal map,
// metallic R / smoothness A * _Smoothness, occlusion R); emission = HDR(_EmissionColir) * emissionMap.rgb * 4,
// Overlay-blended with black at opacity (sin(2pi * t * _FlickerSpeed) + 1) * 0.5 * _MaskPower * emissionMap.a,
// t = _TimeParameters.x * _Tx_SpeedRate. _USEFOG (KeywordEnum OFF/ON): ON = URP's standard fog, OFF = no fog
// (handled by the spec pragmas, which define TX_NOFOG for _USEFOG_OFF).
CBUFFER_START(UnityPerMaterial)
    float _FlickerSpeed;
    float4 _Tx_Emission_TexelSize;
    float4 _EmissionColir;
    float _MaskPower;
    float4 _Tx_Albedo_TexelSize;
    float4 _Tx_Metsllic_TexelSize;
    float _Smoothness;
    float4 _Tx_Normal_TexelSize;
    float4 _Tx_Occlusion_TexelSize;
CBUFFER_END
float _Tx_SpeedRate; // global set by the game (0 if never set: the flicker then holds still)
TEXTURE2D(_Tx_Emission); SAMPLER(sampler_Tx_Emission);
TEXTURE2D(_Tx_Albedo); SAMPLER(sampler_Tx_Albedo);
TEXTURE2D(_Tx_Metsllic); SAMPLER(sampler_Tx_Metsllic);
TEXTURE2D(_Tx_Normal); SAMPLER(sampler_Tx_Normal);
TEXTURE2D(_Tx_Occlusion); SAMPLER(sampler_Tx_Occlusion);

// Shader Graph HDR colour property: converted to sRGB in a Gamma-space project (the original build is Gamma).
float3 RecHdrColor(float3 c)
{
#ifdef UNITY_COLORSPACE_GAMMA
    return LinearToSRGB(c);
#else
    return c;
#endif
}

// Shader Graph Blend node, Overlay mode.
float3 RecBlendOverlay(float3 base, float3 blend, float opacity)
{
    float3 r1 = 1.0 - 2.0 * (1.0 - base) * (1.0 - blend);
    float3 r2 = 2.0 * base * blend;
    float3 zeroOrOne = step(base, 0.5);
    return lerp(base, r2 * zeroOrOne + (1.0 - zeroOrOne) * r1, opacity);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy;
    float3 albedo = SAMPLE_TEXTURE2D(_Tx_Albedo, sampler_Tx_Albedo, uv).rgb;
    float3 normalTS = TxUnpackNormal(SAMPLE_TEXTURE2D(_Tx_Normal, sampler_Tx_Normal, uv));
    float4 metal = SAMPLE_TEXTURE2D(_Tx_Metsllic, sampler_Tx_Metsllic, uv);
    float occlusion = SAMPLE_TEXTURE2D(_Tx_Occlusion, sampler_Tx_Occlusion, uv).r;
    float4 em = SAMPLE_TEXTURE2D(_Tx_Emission, sampler_Tx_Emission, uv);

    float3 emission = RecHdrColor(_EmissionColir.rgb) * em.rgb * 4.0;
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float flicker = (sin(t * _FlickerSpeed * 6.283185) + 1.0) * _MaskPower * em.a * 0.5;

    s.albedo = albedo;
    s.normalWS = TxTangentToWorld(normalTS, i);
    s.metallic = saturate(metal.r);
    s.smoothness = saturate(metal.a * _Smoothness);
    s.occlusion = occlusion;
    s.emission = RecBlendOverlay(emission, 0.0, flicker);
}
