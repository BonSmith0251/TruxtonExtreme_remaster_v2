// Recovered from Shader Graphs/sg_explosion_sphere, Universal Forward ps (evidence/shader-recovery). URP Unlit, additive
// (SrcAlpha One). A world-space three-plane projection of _Texture2D.r (planes yz/xz/xy at posWS*_Tiling*0.005, scrolled
// by t*_TexScrollSpeed, weights n*n of the normalized world normal) times _TexIntensity, times _MaskNoizeTex.rgb
// (uv0*_NoizeScal + t*_NoizeScroolSpeed.xy) * _NoizeIntensity gives c. m = smoothstep(_AlphaEdge1, _AlphaEdge2, c*_Intensity).
// rgb = c*_Intensity*sRGB(_ColorOut) * m*sRGB(_ColorIn) * vertexColor.rgb;
// alpha = m.r * vertexColor.a * (1 - smoothstep(0, 0.75, 1 - saturate(N.V))) (fades towards the silhouette).
// The graph converts both colour properties linear->sRGB (Colorspace Conversion). t = _TimeParameters.x * _Tx_SpeedRate.
// No fog in the original graph.
CBUFFER_START(UnityPerMaterial)
    float4 _Texture2D_TexelSize;
    float _Tiling;
    float _TexScrollSpeed;
    float4 _ColorOut;
    float4 _ColorIn;
    float _NoizeScal;
    float _NoizeIntensity;
    float _Intensity;
    float _TexIntensity;
    float _AlphaEdge2;
    float _AlphaEdge1;
    float4 _MaskNoizeTex_TexelSize;
    float4 _NoizeScroolSpeed;
CBUFFER_END
TEXTURE2D(_Texture2D); SAMPLER(sampler_Texture2D);
TEXTURE2D(_MaskNoizeTex); SAMPLER(sampler_MaskNoizeTex);

// Game-wide time scale (a global set by the game's code; 0 when never set, which freezes the animation).
float _Tx_SpeedRate;

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
    float3 n = i.normalWS; // already normalized
    float3 w = n * n;

    float fresnel = 1 - saturate(dot(n, i.viewDirWS));
    float fade = 1 - TxSmoothstep(0, 0.75, fresnel);

    float3 p = i.positionWS * (_Tiling * 0.01) * 0.5;
    float scroll = t * _TexScrollSpeed;
    float tx = SAMPLE_TEXTURE2D(_Texture2D, sampler_Texture2D, p.yz + scroll).r * w.x
             + SAMPLE_TEXTURE2D(_Texture2D, sampler_Texture2D, p.xz + scroll).r * w.y
             + SAMPLE_TEXTURE2D(_Texture2D, sampler_Texture2D, p.xy + scroll).r * w.z;
    tx *= _TexIntensity;

    float3 mask = SAMPLE_TEXTURE2D(_MaskNoizeTex, sampler_MaskNoizeTex, i.uv0.xy * _NoizeScal + t * _NoizeScroolSpeed.xy).rgb * _NoizeIntensity;
    float3 c = mask * tx * _Intensity;
    float3 m = TxBSmoothstep3(_AlphaEdge1, _AlphaEdge2, c);

    s.albedo = c * TxBLinearToSRGB(_ColorOut.rgb) * (m * TxBLinearToSRGB(_ColorIn.rgb)) * i.color.rgb;
    s.alpha = m.r * i.color.a * fade;
}
