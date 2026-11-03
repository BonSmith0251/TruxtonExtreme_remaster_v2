// Recovered from TATSUJIN/SpriteBillbordAnime (evidence/shader-recovery/TATSUJIN_SpriteBillbordAnime, pass 0).
// vs (rotating camera-facing billboard, exactly as the original):
//     a      = _Time.y * _RotateSpeed * _Tx_SpeedRate          (_Tx_SpeedRate: game-wide global, not a property)
//     r      = (cos(a) * x - sin(a) * y,  sin(a) * x + cos(a) * y)   from vertex.xy (vertex.z unused)
//     centre = unity_MatrixV * (ObjectToWorld column 3, w = 1)
//     clip   = glstate_matrix_projection * (centre + float4(r * (|M col0.xyz|, |M col1.xyz|), 0, 0))
//     Sprite-sheet uv as TATSUJIN/SpriteAnime (A = int(_AIndex), col = fmod(A, floor(H)),
//     row = fmod((V - 1) - floor(A / H), floor(H)), uv = (TRANSFORM_TEX(uv) + (col,row)) / (H,V)).
// ps: col = 2 * vcolor * _TintColor * _MainTex, alpha saturated. Alpha blend, ZTest Always, RGB mask (state).
// SOFTPARTICLES_ON: the original vs writes projPos = 0, so its depth fade samples at 0/0 (undefined); not
//     implemented. _USEFOG_OFF (all compiled variants): no fog. _USEFOG_ON: no compiled variant exists; inferred
//     like EffectCommon/NormalShot (rgb towards black by the fog factor).
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _TintColor;
    float4 _MainTex_ST;
    float _DividedH;
    float _DividedV;
    float _AIndex;       // declared int in the original program (itof)
    float _RotateSpeed;
    float _InvFade;
CBUFFER_END
float _Tx_SpeedRate;     // global set by the game (same global the Shader Graph effects use)
TEXTURE2D(_MainTex); SAMPLER(sampler_MainTex);

struct Attributes
{
    float4 positionOS : POSITION;
    float4 color : COLOR;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
    float4 color : COLOR;
    float3 uvFog : TEXCOORD0;   // xy uv, z fog factor (_USEFOG_ON only)
};

float2 TxSpriteSheetUV(float2 uv0)
{
    float a = (float)(int)_AIndex;
    float cellsH = floor(_DividedH);
    float col = fmod(a, cellsH);
    float row = fmod((_DividedV - 1.0) - floor(a / _DividedH), cellsH);
    return (uv0 + float2(col, row)) * (1.0 / float2(_DividedH, _DividedV));
}

Varyings vert(Attributes v)
{
    Varyings o;
    UNITY_SETUP_INSTANCE_ID(v);
    float4x4 m = GetObjectToWorldMatrix();
    float4 centreVS = mul(GetWorldToViewMatrix(), float4(m._m03, m._m13, m._m23, m._m33));
    float2 scale = float2(length(float3(m._m00, m._m10, m._m20)), length(float3(m._m01, m._m11, m._m21)));
    float ang = _Time.y * _RotateSpeed * _Tx_SpeedRate;
    float s, c;
    sincos(ang, s, c);
    float2 r = float2(c * v.positionOS.x - s * v.positionOS.y, s * v.positionOS.x + c * v.positionOS.y);
    float4 positionVS = centreVS + float4(r * scale, 0.0, 0.0);
    o.positionCS = mul(GetViewToHClipMatrix(), positionVS);
    o.color = v.color;
    o.uvFog.xy = TxSpriteSheetUV(v.uv * _MainTex_ST.xy + _MainTex_ST.zw);
#if defined(_USEFOG_ON)
    o.uvFog.z = ComputeFogFactor(o.positionCS.z);
#else
    o.uvFog.z = 0.0;
#endif
    return o;
}

float4 frag(Varyings i) : SV_Target
{
    float4 col = (i.color + i.color) * _TintColor;
    col *= SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uvFog.xy);
#if defined(_USEFOG_ON)
    col.rgb = MixFogColor(col.rgb, float3(0.0, 0.0, 0.0), i.uvFog.z);
#endif
    col.a = saturate(col.a);
    return col;
}
