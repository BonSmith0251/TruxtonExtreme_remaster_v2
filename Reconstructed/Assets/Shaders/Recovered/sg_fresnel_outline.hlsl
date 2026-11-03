// Recovered from Shader Graphs/sg_fresnel_outline, Universal Forward ps (evidence/shader-recovery). URP Unlit, alpha blend.
// f = pow(1 - saturate(N.V), _FrsnelEdgeIntencity) (Fresnel Effect). rgb = lerp(_FresnelBaceColor, sRGB(_FresnelEdgeColor), f)
// + sRGB(_Emissioncolor) * _EmissionImage(uv0).rgb * _Emissionintencity; alpha = f. Only the edge and emission colours go
// through the graph's linear->sRGB Colorspace Conversion; the base colour is used as is. No fog in the original graph.
CBUFFER_START(UnityPerMaterial)
    float4 _EmissionImage_TexelSize;
    float4 _Emissioncolor;
    float _FrsnelEdgeIntencity;
    float4 _FresnelBaceColor;
    float4 _FresnelEdgeColor;
    float _Emissionintencity;
CBUFFER_END
TEXTURE2D(_EmissionImage); SAMPLER(sampler_EmissionImage);

// Shader Graph Colorspace Conversion Linear -> RGB, constants as in the original bytecode.
float3 TxBLinearToSRGB(float3 c)
{
    float3 lo = c * 12.92321;
    float3 hi = pow(abs(c), float3(1.0 / 2.4, 1.0 / 2.4, 1.0 / 2.4)) * 1.055 - 0.055;
    return float3(c.x <= 0.0031308 ? lo.x : hi.x, c.y <= 0.0031308 ? lo.y : hi.y, c.z <= 0.0031308 ? lo.z : hi.z);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float f = TxPow(1 - saturate(dot(i.normalWS, i.viewDirWS)), _FrsnelEdgeIntencity);
    float3 rim = lerp(_FresnelBaceColor.rgb, TxBLinearToSRGB(_FresnelEdgeColor.rgb), f);
    float3 emission = TxBLinearToSRGB(_Emissioncolor.rgb) * SAMPLE_TEXTURE2D(_EmissionImage, sampler_EmissionImage, i.uv0.xy).rgb;
    s.albedo = emission * _Emissionintencity + rim;
    s.alpha = f;
}
