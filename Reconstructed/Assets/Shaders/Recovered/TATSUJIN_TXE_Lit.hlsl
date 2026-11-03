// Recovered from TATSUJIN/TXE_Lit (evidence/shader-recovery/TATSUJIN_TXE_Lit; the evidence .asm files are empty because
// the program blob spans 11 LZ4 segments, so the variants were re-dumped segment-aware to a scratch dir).
// The original is a copy of URP Lit (metallic workflow). Its surface inputs, BRDF, GI, main/additional lights and fog
// are stock URP Lit, read from the Forward and GBuffer ps of these variants: minimal, _NORMALMAP, _EMISSION,
// _METALLICSPECGLOSSMAP, _DETAIL_MULX2, _SURFACE_TYPE_TRANSPARENT, FOG_LINEAR with and without _FOGUSE_OFF.
// UnityPerMaterial is URP LitInput's buffer (176 bytes) with three TXE fields after _Surface:
//   128 _RimColor, 144 _RimFactor, 160 _FadeColor.
// TXE terms (identical formulas in both passes, N = interpolated vertex normal NOT renormalised, V = normalized view dir):
//   fade(c) = lerp(c, _FadeColor.rgb * 2 * (0.3 + 0.7 * dot(c, (0.2126, 0.7152, 0.0722))), _FadeColor.a)
//   rim     = pow(1 - saturate(dot(N, V)), _RimColor.a * 10) * _RimColor.rgb * _RimFactor
//   Forward : out.rgb = fade(MixFog(litColor)) + rim      (MixFog skipped when _FOGUSE_OFF, i.e. _FogUSE = 0)
//   GBuffer : albedo  = fade(baseMap * _BaseColor) + rim  (before the BRDF split, so rim/fade are lit)
// Forward and GBuffer need hooks after the surface function (TxPostFog, TxGBufferAlbedo below); the fog switch is the
// TX_NOFOG define driven by _FOGUSE_OFF in the spec pragmas. The output alpha is albedo alpha only when _Surface != 0.
// _PARALLAXMAP, _SPECULAR_SETUP, _ALPHAPREMULTIPLY_ON/_ALPHAMODULATE_ON and clear coat were stripped from the game's
// build (no variant exists) and are not implemented.

#if defined(_DETAIL_MULX2) || defined(_DETAIL_SCALED)
    #define TXE_DETAIL 1
#endif

CBUFFER_START(UnityPerMaterial)
    float4 _BaseMap_ST;
    float4 _DetailAlbedoMap_ST;
    float4 _BaseColor;
    float4 _SpecColor;
    float4 _EmissionColor;
    float _Cutoff;
    float _Smoothness;
    float _Metallic;
    float _BumpScale;
    float _Parallax;
    float _OcclusionStrength;
    float _ClearCoatMask;
    float _ClearCoatSmoothness;
    float _DetailAlbedoMapScale;
    float _DetailNormalMapScale;
    float _Surface;
    float4 _RimColor;
    float _RimFactor;
    float4 _FadeColor;
CBUFFER_END
TEXTURE2D(_BaseMap); SAMPLER(sampler_BaseMap);
TEXTURE2D(_BumpMap); SAMPLER(sampler_BumpMap);
TEXTURE2D(_EmissionMap); SAMPLER(sampler_EmissionMap);
TEXTURE2D(_MetallicGlossMap); SAMPLER(sampler_MetallicGlossMap);
TEXTURE2D(_OcclusionMap); SAMPLER(sampler_OcclusionMap);
TEXTURE2D(_DetailMask); SAMPLER(sampler_DetailMask);
TEXTURE2D(_DetailAlbedoMap); SAMPLER(sampler_DetailAlbedoMap);
TEXTURE2D(_DetailNormalMap); SAMPLER(sampler_DetailNormalMap);

// URP CommonMaterial BlendNormalRNM (matches the _DETAIL_MULX2 asm: t = n1 + (0,0,1), u = n2 * (-1,-1,1)).
float3 TxeBlendNormalRNM(float3 n1, float3 n2)
{
    float3 t = n1 + float3(0, 0, 1);
    float3 u = n2 * float3(-1, -1, 1);
    return (t / t.z) * dot(t, u) - u;
}

// TXE fade: lerp towards _FadeColor scaled by the colour's luminance (0.3 floor), weight _FadeColor.a.
float3 TxeFade(float3 c)
{
    float lum = dot(c, float3(0.2126, 0.7152, 0.0722));
    float3 target = _FadeColor.rgb * (lum * 0.7 + 0.3) * 2.0;
    return c + _FadeColor.a * (target - c);
}

// TXE rim: exponent _RimColor.a * 10, strength _RimFactor. normalWSRaw is the interpolated vertex normal (the original
// reads the varying directly, without renormalising and without the normal map).
float3 TxeRim(float3 normalWSRaw, float3 viewDirWS)
{
    float rim = TxPow(1.0 - saturate(dot(normalWSRaw, viewDirWS)), _RimColor.a * 10.0);
    return rim * _RimColor.rgb * _RimFactor;
}

float3 TxeFadeRim(float3 c, float3 normalWSRaw, float3 viewDirWS)
{
    return TxeFade(c) + TxeRim(normalWSRaw, viewDirWS);
}

// Forward hook: called on the lit colour AFTER MixFog (or after lighting when TX_NOFOG), last before output.
half3 TxPostFog(TxVaryings v, TxSurfaceInput i, half3 color)
{
    return half3(TxeFadeRim(color, v.normalWS, i.viewDirWS));
}

// GBuffer hook: called on the surface albedo after TxSurfaceFunction, before BRDF/GBuffer packing.
half3 TxGBufferAlbedo(TxVaryings v, TxSurfaceInput i, half3 albedo)
{
    return half3(TxeFadeRim(albedo, v.normalWS, i.viewDirWS));
}

// Stock URP Lit surface (LitInput.hlsl InitializeStandardLitSurfaceData, metallic workflow).
void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy * _BaseMap_ST.xy + _BaseMap_ST.zw;
    float4 albedoAlpha = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, uv);

#if defined(_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A)
    float alpha = _BaseColor.a;
#else
    float alpha = albedoAlpha.a * _BaseColor.a;
#endif
#if defined(_ALPHATEST_ON)
    clip(alpha - _Cutoff);
#endif

    float3 albedo = albedoAlpha.rgb * _BaseColor.rgb;

#if defined(_METALLICSPECGLOSSMAP)
    float4 specGloss = SAMPLE_TEXTURE2D(_MetallicGlossMap, sampler_MetallicGlossMap, uv);
    float metallic = specGloss.r;
    #if defined(_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A)
        float smoothness = albedoAlpha.a * _Smoothness;
    #else
        float smoothness = specGloss.a * _Smoothness;
    #endif
#else
    float metallic = _Metallic;
    #if defined(_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A)
        float smoothness = albedoAlpha.a * _Smoothness;
    #else
        float smoothness = _Smoothness;
    #endif
#endif

#if defined(_NORMALMAP)
    float3 normalTS = UnpackNormalScale(SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv), _BumpScale);
#else
    float3 normalTS = float3(0, 0, 1);
#endif

#if defined(_OCCLUSIONMAP)
    float occlusion = lerp(1.0, SAMPLE_TEXTURE2D(_OcclusionMap, sampler_OcclusionMap, uv).g, _OcclusionStrength);
#else
    float occlusion = 1.0;
#endif

#if defined(_EMISSION)
    float3 emission = SAMPLE_TEXTURE2D(_EmissionMap, sampler_EmissionMap, uv).rgb * _EmissionColor.rgb;
#else
    float3 emission = 0;
#endif

#if defined(TXE_DETAIL)
    float detailMask = SAMPLE_TEXTURE2D(_DetailMask, sampler_DetailMask, uv).a;
    float2 detailUv = uv * _DetailAlbedoMap_ST.xy + _DetailAlbedoMap_ST.zw;
    float3 detailAlbedo = SAMPLE_TEXTURE2D(_DetailAlbedoMap, sampler_DetailAlbedoMap, detailUv).rgb;
    #if defined(_DETAIL_SCALED)
        detailAlbedo = 2.0 * detailAlbedo * _DetailAlbedoMapScale - _DetailAlbedoMapScale + 1.0;
    #else
        detailAlbedo = 2.0 * detailAlbedo;
    #endif
    albedo *= lerp(float3(1, 1, 1), detailAlbedo, detailMask);
    float3 detailNormalTS = normalize(UnpackNormalScale(SAMPLE_TEXTURE2D(_DetailNormalMap, sampler_DetailNormalMap, detailUv), _DetailNormalMapScale));
    normalTS = lerp(normalTS, TxeBlendNormalRNM(normalTS, detailNormalTS), detailMask);
#endif

    s.albedo = albedo;
#if defined(_NORMALMAP) || defined(TXE_DETAIL)
    s.normalWS = TxTangentToWorld(normalTS, i);
#else
    s.normalWS = i.normalWS;
#endif
    s.metallic = metallic;
    s.smoothness = smoothness;
    s.occlusion = occlusion;
    s.emission = emission;
    // URP OutputAlpha: opaque surfaces write 1 (original: movc o0.w, _Surface != 0, alpha, 1).
    s.alpha = (_Surface != 0) ? alpha : 1.0;
    s.alphaClip = 0; // _ALPHATEST_ON clipped above against _Cutoff with the unforced alpha
}
