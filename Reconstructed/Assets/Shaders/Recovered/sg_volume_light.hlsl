// Recovered from Shader Graphs/sg_volume_light, Universal Forward ps (evidence/shader-recovery).
// Unlit transparent light shaft (SrcAlpha/OneMinusSrcAlpha, ZWrite off, cull off, no fog). Colour = _Color (HDR,
// sRGB-converted in a gamma project). Alpha a = depth fade saturate(Linear01Depth(scene) * far - fragment eye depth)
//   * _Opacity * (1 - min(Fresnel(_EdgeFalloff), 1))          (soft rim on the shaft's silhouette)
//   * saturate(cameraDistance - 0.5) * (1 - smoothstep(0, _FarAlpha, cameraDistance))
//   * uv0.y                                                    (fades along the shaft)
// then Blend(Dodge, opacity 0.5) of a*0.5 with c = 0.9 * _TextuerAlpha * (1 - (noise(uv0*(2,1) + t*0.05) +
// noise(uv0*(2,1) + t*0.02)).r), t = _TimeParameters.x: two scrolling reads of _NoiseTextuer.
// Note: with _FarAlpha = 0 (the property default) the far fade is 0 and the shaft is invisible, as in the original.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

CBUFFER_START(UnityPerMaterial)
    float _Opacity;
    float4 _Color;
    float _EdgeFalloff;
    float4 _NoiseTextuer_TexelSize;
    float _TextuerAlpha;
    float _FarAlpha;
CBUFFER_END
TEXTURE2D(_NoiseTextuer); SAMPLER(sampler_NoiseTextuer);

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
    float sceneDepth01 = Linear01Depth(SampleSceneDepth(i.screenPosition.xy), _ZBufferParams);
    float depthFade = saturate(sceneDepth01 * _ProjectionParams.z - i.screenRaw.w);

    float3 n = normalize(i.normalWS);
    float fresnel = min(TxPow(1 - saturate(dot(n, i.viewDirWS)), _EdgeFalloff), 1);
    float a = depthFade * (_Opacity * (1 - fresnel));

    float dist = length(_WorldSpaceCameraPos - i.positionWS);
    a *= saturate(dist - 0.5);
    a *= 1 - TxSmoothstep(0, _FarAlpha, dist);
    a *= i.uv0.y;

    float4 scroll = _TimeParameters.x * float4(0.05, 0.05, 0.02, 0.02) + i.uv0.xyxy * float4(2, 1, 2, 1);
    float n0 = SAMPLE_TEXTURE2D(_NoiseTextuer, sampler_NoiseTextuer, scroll.xy).r;
    float n1 = SAMPLE_TEXTURE2D(_NoiseTextuer, sampler_NoiseTextuer, scroll.zw).r;
    float c = (1 - (n0 + n1)) * _TextuerAlpha * 0.9;

    float base = a * 0.5;
    float dodge = base / (1 - clamp(c, 0.000001, 0.999999));
    s.albedo = TxA_HDRColor(_Color.rgb);
    s.alpha = lerp(base, dodge, 0.5);
}
