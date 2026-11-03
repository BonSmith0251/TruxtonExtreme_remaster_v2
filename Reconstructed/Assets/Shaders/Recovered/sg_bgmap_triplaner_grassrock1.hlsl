// Recovered from Shader Graphs/sg_bgmap_triplaner_grassrock1, Universal Forward ps (evidence/shader-recovery).
// Ground and grass are world-space triplanar layers (Triplanar blend 1). Grass covers surfaces facing up
// (smoothstep of saturate(N.y) around _GrassAngle +- _GrassGradient) where a triplanar grey-scale mask passes
// smoothstep(_GrassMask_Edge1, _GrassMask_Edge2) * _GrassMask_Int. "GlayScale" maps pack metallic (R),
// occlusion (G) and smoothness (A); the grass map is sampled at grass tiling. No emission.
CBUFFER_START(UnityPerMaterial)
    float4 _GrassAlbed_TexelSize;
    float4 _GrassAlbed_Color;
    float _GrassTiling;
    float4 _GrassGlayScale_TexelSize;
    float4 _GrassNormal_TexelSize;
    float _GroundTiling;
    float4 _GroundAlbed_TexelSize;
    float4 _GroundGlayScale_TexelSize;
    float4 _GroundNormal_TexelSize;
    float4 _GroundAlbed_Color;
    float _GrassGradient;
    float _GrassAngle;
    float _GrassMask_Tiling;
    float _GrassMask_Edge2;
    float _GrassMask_Edge1;
    float _GrassMask_Int;
    float _GrassNormalIntensity;
    float _GroundNormalIntensity;
CBUFFER_END
TEXTURE2D(_GrassAlbed); SAMPLER(sampler_GrassAlbed);
TEXTURE2D(_GrassGlayScale); SAMPLER(sampler_GrassGlayScale);
TEXTURE2D(_GroundAlbed); SAMPLER(sampler_GroundAlbed);
TEXTURE2D(_GrassNormal); SAMPLER(sampler_GrassNormal);
TEXTURE2D(_GroundGlayScale); SAMPLER(sampler_GroundGlayScale);
TEXTURE2D(_GroundNormal); SAMPLER(sampler_GroundNormal);

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float3 n = i.normalWS;
    float3 w = TxTriplanarWeights(n, 1);
    float3 pGround = i.positionWS * _GroundTiling;
    float3 pGrass = i.positionWS * _GrassTiling;
    float3 pMask = i.positionWS * _GrassMask_Tiling;

    float3 ground = TxTriplanar(TEXTURE2D_ARGS(_GroundAlbed, sampler_GroundAlbed), pGround, w).rgb * _GroundAlbed_Color.rgb;
    float3 grass = TxTriplanar(TEXTURE2D_ARGS(_GrassAlbed, sampler_GrassAlbed), pGrass, w).rgb * _GrassAlbed_Color.rgb;

    float mask = TxTriplanar(TEXTURE2D_ARGS(_GrassGlayScale, sampler_GrassGlayScale), pMask, w).b;
    mask = smoothstep(_GrassMask_Edge1, _GrassMask_Edge2, mask) * _GrassMask_Int;
    float up = smoothstep(_GrassAngle - _GrassGradient, _GrassAngle + _GrassGradient, saturate(n.y));
    float blend = mask * up;

    float3 groundN = TxNormalStrength(TxWorldToTangent(TxTriplanarNormalWS(TEXTURE2D_ARGS(_GroundNormal, sampler_GroundNormal), pGround, n, w), i), _GroundNormalIntensity);
    float3 grassN = TxNormalStrength(TxWorldToTangent(TxTriplanarNormalWS(TEXTURE2D_ARGS(_GrassNormal, sampler_GrassNormal), pGrass, n, w), i), _GrassNormalIntensity);

    float4 groundM = TxTriplanar(TEXTURE2D_ARGS(_GroundGlayScale, sampler_GroundGlayScale), pGround, w);
    float4 grassM = TxTriplanar(TEXTURE2D_ARGS(_GrassGlayScale, sampler_GrassGlayScale), pGrass, w);
    float4 m = lerp(groundM, grassM, blend);

    s.albedo = lerp(ground, grass, blend);
    s.normalWS = TxTangentToWorld(lerp(groundN, grassN, blend), i);
    s.metallic = saturate(m.r);
    s.smoothness = saturate(m.a);
    s.occlusion = m.g;
}
