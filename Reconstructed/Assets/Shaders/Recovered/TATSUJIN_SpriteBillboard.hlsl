// Recovered from TATSUJIN/SpriteBillboard (evidence/shader-recovery/TATSUJIN_SpriteBillboard, pass 0).
// vs (camera-facing billboard, exactly as the original):
//     centre = unity_MatrixV * (ObjectToWorld column 3, i.e. the object's world translation, w = 1)
//     scale  = (|ObjectToWorld col0.xyz|, |col1.xyz|, |col2.xyz|)
//     clip   = glstate_matrix_projection * (centre + float4(vertex.xyz * scale, 0))
//     The object's rotation is ignored; the mesh's object x/y/z become view x/y/z. NORMAL is unused.
//     uv = TRANSFORM_TEX(uv, _MainTex).
// ps: rgb = _MainTex.rgb, a = _MainTex.a * _TexAlpha (no vertex colour). Instancing as the INSTANCING_ON variant.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _MainTex_ST;
    float _TexAlpha;
CBUFFER_END
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);

struct Attributes
{
    float4 positionOS : POSITION;
    float3 normalOS : NORMAL;
    float4 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
    float2 uv : TEXCOORD0;
};

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    float4x4 m = GetObjectToWorldMatrix();
    float4 centreVS = mul(GetWorldToViewMatrix(), float4(m._m03, m._m13, m._m23, m._m33));
    float3 scale = float3(length(float3(m._m00, m._m10, m._m20)),
                          length(float3(m._m01, m._m11, m._m21)),
                          length(float3(m._m02, m._m12, m._m22)));
    float4 positionVS = centreVS + float4(v.positionOS.xyz * scale, 0.0);
    o.positionCS = mul(GetViewToHClipMatrix(), positionVS);
    o.uv = v.uv.xy * _MainTex_ST.xy + _MainTex_ST.zw;
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv);
    return float4(tex.rgb, tex.a * _TexAlpha);
}
