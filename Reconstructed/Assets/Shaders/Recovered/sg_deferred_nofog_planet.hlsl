// Recovered from Shader Graphs/sg_deferred_nofog_planet, Universal Forward ps (evidence/shader-recovery).
// Unlit planet sphere (no fog, even in FOG_* variants). Rim colour: lerp(_Color_In, _ColorEdge, Fresnel) where
// Fresnel = pow(1 - saturate(dot(N, V)), _FresnelInt) and _ColorEdge is HDR (sRGB-converted in a gamma project),
// times MainTex(uv0). Night side: d = dot(normalize(_NightPos), N) * 0.5 + 0.5, t = smoothstep(_NightVol,
// _NightEdge, d), night tint = lerp(_Color, 1, t); output = night tint * rim colour, alpha 1.
// UnityPerMaterial layout confirmed from passes.json bindings (_NightPos is a float3 packed after _FresnelInt).
CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_TexelSize;
    float4 _ColorEdge;
    float4 _Color_In;
    float _FresnelInt;
    float3 _NightPos;
    float _NightEdge;
    float _NightVol;
    float4 _Color;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);

float3 TxA_HDRColor(float3 c)
{
#ifdef UNITY_COLORSPACE_GAMMA
    return LinearToSRGB(c);
#else
    return c;
#endif
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float3 n = normalize(i.normalWS);
    float fresnel = TxPow(1 - saturate(dot(n, i.viewDirWS)), _FresnelInt);
    float3 rim = lerp(_Color_In.rgb, TxA_HDRColor(_ColorEdge.rgb), fresnel);
    rim *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv0.xy).rgb;

    float d = dot(normalize(_NightPos), n) * 0.5 + 0.5;
    float t = TxSmoothstep(_NightVol, _NightEdge, d);
    float3 night = lerp(_Color.rgb, float3(1, 1, 1), t);

    s.albedo = night * rim;
    s.alpha = 1;
}
