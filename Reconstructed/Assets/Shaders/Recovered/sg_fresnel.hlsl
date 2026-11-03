// Recovered from Shader Graphs/sg_fresnel, Universal Forward (evidence/shader-recovery).
// Lit PBR from UV0 maps: albedo RGB, normal map, metallic R / smoothness A * _Smoothness, occlusion R.
// Emission = lerp(_FresnelColor, HDR(_FresnelEdgeColor), F) + HDR(_EmissionColor) * emissionMap.rgb * 5, with the
// Fresnel term F = pow(1 - saturate(dot(vertex normal, view dir)), _FresnelIntensity) (geometric normal, not the
// normal map). _FresnelColor is a non-HDR colour and is used as stored. Standard URP fog.
CBUFFER_START(UnityPerMaterial)
    float _FresnelIntensity;
    float4 _FresnelEdgeColor;
    float4 _FresnelColor;
    float4 _Tx_Albedo_TexelSize;
    float4 _Tx_MetallicI_TexelSize;
    float4 _EmissionColor;
    float4 _Tx_Normal_TexelSize;
    float4 _Tx_Emission_TexelSize;
    float4 _Tx_Occlusion_TexelSize;
    float _Smoothness;
CBUFFER_END
TEXTURE2D(_Tx_Emission); SAMPLER(sampler_Tx_Emission);
TEXTURE2D(_Tx_Occlusion); SAMPLER(sampler_Tx_Occlusion);
TEXTURE2D(_Tx_MetallicI); SAMPLER(sampler_Tx_MetallicI);
TEXTURE2D(_Tx_Normal); SAMPLER(sampler_Tx_Normal);
TEXTURE2D(_Tx_Albedo); SAMPLER(sampler_Tx_Albedo);

// Shader Graph HDR colour property: converted to sRGB in a Gamma-space project (the original build is Gamma).
float3 RecHdrColor(float3 c)
{
#ifdef UNITY_COLORSPACE_GAMMA
    return LinearToSRGB(c);
#else
    return c;
#endif
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy;
    float3 albedo = SAMPLE_TEXTURE2D(_Tx_Albedo, sampler_Tx_Albedo, uv).rgb;
    float3 normalTS = TxUnpackNormal(SAMPLE_TEXTURE2D(_Tx_Normal, sampler_Tx_Normal, uv));
    float4 metal = SAMPLE_TEXTURE2D(_Tx_MetallicI, sampler_Tx_MetallicI, uv);
    float occlusion = SAMPLE_TEXTURE2D(_Tx_Occlusion, sampler_Tx_Occlusion, uv).r;
    float3 em = SAMPLE_TEXTURE2D(_Tx_Emission, sampler_Tx_Emission, uv).rgb;

    float fresnel = TxPow(1.0 - saturate(dot(i.normalWS, i.viewDirWS)), _FresnelIntensity);
    float3 rim = lerp(_FresnelColor.rgb, RecHdrColor(_FresnelEdgeColor.rgb), fresnel);

    s.albedo = albedo;
    s.normalWS = TxTangentToWorld(normalTS, i);
    s.metallic = saturate(metal.r);
    s.smoothness = saturate(metal.a * _Smoothness);
    s.occlusion = occlusion;
    s.emission = rim + RecHdrColor(_EmissionColor.rgb) * em * 5.0;
}
