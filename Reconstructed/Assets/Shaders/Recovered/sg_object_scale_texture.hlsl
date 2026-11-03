// Recovered from Shader Graphs/sg_object_scale_texture, Universal Forward ps (evidence/shader-recovery).
// UV0 scaled by the object's scale so the texture density stays constant on stretched objects:
// uv = uv0 * (objectScale.x * _TexScale.x, objectScale.z * _TexScale.y) (object scale = length of the
// object-to-world matrix columns, Shader Graph Object node). Albedo = TexAlbed * _ColorAlbed; normal map in tangent
// space; GlayScale packs metallic (R), occlusion (G), cut-out mask (B), smoothness (A * _Smooth).
// Alpha = vertex colour alpha, alpha clip threshold = (1 - GlayScale.b) * _CutOut (queue AlphaTest, cull off).
CBUFFER_START(UnityPerMaterial)
    float4 _ColorAlbed;
    float _Smooth;
    float4 _TexScale;
    float _CutOut;
CBUFFER_END
TEXTURE2D(_TexAlbed); SAMPLER(sampler_TexAlbed);
TEXTURE2D(_TexNormal); SAMPLER(sampler_TexNormal);
TEXTURE2D(_TexGlayScale); SAMPLER(sampler_TexGlayScale);

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float4x4 m = GetObjectToWorldMatrix();
    float2 objScale = float2(length(float3(m._m00, m._m10, m._m20)), length(float3(m._m02, m._m12, m._m22)));
    float2 uv = objScale * _TexScale.xy * i.uv0.xy;

    float3 albedo = SAMPLE_TEXTURE2D(_TexAlbed, sampler_TexAlbed, uv).rgb * _ColorAlbed.rgb;
    float3 tn = UnpackNormal(SAMPLE_TEXTURE2D(_TexNormal, sampler_TexNormal, uv));
    float4 g = SAMPLE_TEXTURE2D(_TexGlayScale, sampler_TexGlayScale, uv);

    s.albedo = albedo;
    s.normalWS = TxTangentToWorld(tn, i);
    s.metallic = saturate(g.r);
    s.smoothness = saturate(g.a * _Smooth);
    s.occlusion = min(g.g, 1);
    s.alpha = i.color.a;
    s.alphaClip = (1 - g.b) * _CutOut;
}
