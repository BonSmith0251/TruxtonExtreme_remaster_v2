#ifndef TRUXTON_RECOVERED_SG_INCLUDED
#define TRUXTON_RECOVERED_SG_INCLUDED

// Shared URP 16 passes for the recovered TATSUJIN EXTREME Shader Graph shaders. The original graphs were compiled
// URP Lit/Unlit sub-targets; only their graph math was game-specific. Each recovered shader declares its
// UnityPerMaterial buffer and textures, defines TxSurfaceFunction (and optionally TxVertexFunction with
// TX_HAS_VERTEX_FUNCTION), then uses the vertex/fragment entry points below. The graph math in each body is read from
// the original D3D11 bytecode (evidence/shader-recovery); these passes stand in for Shader Graph's generated ones.
//   TX_UNLIT        Unlit sub-target: albedo is the output colour (no lighting)
//   TX_TRANSPARENT  output surface alpha (otherwise 1)
//   TX_ALPHATEST    clip(alpha - alphaClip)
//   TX_NOFOG        skip MixFog (graphs built with fog off)

#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

struct TxAttributes
{
    float4 positionOS : POSITION;
    float3 normalOS : NORMAL;
    float4 tangentOS : TANGENT;
    float4 uv0 : TEXCOORD0;
    float4 uv1 : TEXCOORD1;
    float4 color : COLOR;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct TxVaryings
{
    float4 positionCS : SV_POSITION;
    float3 positionWS : TEXCOORD0;
    float3 normalWS : TEXCOORD1;
    float4 tangentWS : TEXCOORD2;
    float4 uv0 : TEXCOORD3;
    float4 uv1 : TEXCOORD4;
    float4 color : TEXCOORD5;
    float3 positionOS : TEXCOORD6;
    float fogFactor : TEXCOORD7;
    UNITY_VERTEX_INPUT_INSTANCE_ID
    UNITY_VERTEX_OUTPUT_STEREO
};

struct TxVertexInput
{
    float3 positionOS;
    float3 normalOS;
    float4 tangentOS;
    float4 uv0;
    float4 uv1;
    float4 color;
};

struct TxSurfaceInput
{
    float3 positionWS;
    float3 positionOS;
    float3 normalWS;
    float3 tangentWS;
    float3 bitangentWS;
    float3 viewDirWS;
    float4 uv0;
    float4 uv1;
    float4 color;
    float4 screenPosition; // Shader Graph "Screen Position (Default)": normalized xy, z = 0, w = 1 for opaque use
    float4 screenRaw;      // Shader Graph "Screen Position (Raw)"
    float sceneEyeDepth;   // eye depth of this fragment
};

struct TxSurface
{
    half3 albedo;
    float3 normalWS;
    half metallic;
    half smoothness;
    half occlusion;
    half3 emission;
    half alpha;
    half alphaClip;
};

#ifdef TX_HAS_VERTEX_FUNCTION
void TxVertexFunction(inout TxVertexInput v);
#endif
void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s);
// Optional hooks for shaders that modify colour outside the surface (TATSUJIN/TXE_Lit: fade colour and rim after fog
// in Forward, folded into albedo before GBuffer packing). They receive TxVaryings for the raw interpolated normal.
#ifdef TX_HAS_POST_FOG
half3 TxPostFog(TxVaryings v, TxSurfaceInput i, half3 color);
#endif
#ifdef TX_HAS_GBUFFER_ALBEDO
half3 TxGBufferAlbedo(TxVaryings v, TxSurfaceInput i, half3 albedo);
#endif

float3 _LightDirection;
float3 _LightPosition;

TxVaryings TxVertCommon(TxAttributes a, bool shadow)
{
    TxVaryings o = (TxVaryings)0;
    UNITY_SETUP_INSTANCE_ID(a);
    UNITY_TRANSFER_INSTANCE_ID(a, o);
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
    TxVertexInput v;
    v.positionOS = a.positionOS.xyz; v.normalOS = a.normalOS; v.tangentOS = a.tangentOS;
    v.uv0 = a.uv0; v.uv1 = a.uv1; v.color = a.color;
#ifdef TX_HAS_VERTEX_FUNCTION
    TxVertexFunction(v);
#endif
    VertexPositionInputs p = GetVertexPositionInputs(v.positionOS);
    VertexNormalInputs n = GetVertexNormalInputs(v.normalOS, v.tangentOS);
    o.positionWS = p.positionWS;
    o.positionCS = p.positionCS;
    o.normalWS = n.normalWS;
    o.tangentWS = float4(n.tangentWS, v.tangentOS.w * GetOddNegativeScale());
    o.uv0 = v.uv0; o.uv1 = v.uv1; o.color = v.color; o.positionOS = v.positionOS;
    o.fogFactor = ComputeFogFactor(p.positionCS.z);
    if (shadow)
    {
#if _CASTING_PUNCTUAL_LIGHT_SHADOW
        float3 lightDir = normalize(_LightPosition - p.positionWS);
#else
        float3 lightDir = _LightDirection;
#endif
        float4 cs = TransformWorldToHClip(ApplyShadowBias(p.positionWS, n.normalWS, lightDir));
#if UNITY_REVERSED_Z
        cs.z = min(cs.z, UNITY_NEAR_CLIP_VALUE);
#else
        cs.z = max(cs.z, UNITY_NEAR_CLIP_VALUE);
#endif
        o.positionCS = cs;
    }
    return o;
}

TxVaryings TxVert(TxAttributes a) { return TxVertCommon(a, false); }
TxVaryings TxVertShadow(TxAttributes a) { return TxVertCommon(a, true); }

TxSurfaceInput TxBuildInput(TxVaryings v)
{
    TxSurfaceInput i;
    i.positionWS = v.positionWS;
    i.positionOS = v.positionOS;
    i.normalWS = normalize(v.normalWS);
    i.tangentWS = normalize(v.tangentWS.xyz);
    i.bitangentWS = cross(i.normalWS, i.tangentWS) * (v.tangentWS.w > 0 ? 1 : -1) * GetOddNegativeScale();
    i.viewDirWS = GetWorldSpaceNormalizeViewDir(v.positionWS);
    i.uv0 = v.uv0; i.uv1 = v.uv1; i.color = v.color;
    float4 clip = TransformWorldToHClip(v.positionWS);
    i.screenRaw = ComputeScreenPos(clip);
    i.screenPosition = float4(i.screenRaw.xy / i.screenRaw.w, 0, 0);
    i.sceneEyeDepth = LinearEyeDepth(v.positionWS, GetWorldToViewMatrix());
    return i;
}

TxSurface TxEvaluate(TxVaryings v, out TxSurfaceInput i)
{
    i = TxBuildInput(v);
    TxSurface s;
    s.albedo = 0.5; s.normalWS = i.normalWS; s.metallic = 0; s.smoothness = 0.5; s.occlusion = 1;
    s.emission = 0; s.alpha = 1; s.alphaClip = 0.5;
    TxSurfaceFunction(i, s);
#ifdef TX_ALPHATEST
    clip(s.alpha - s.alphaClip);
#endif
#ifndef TX_TRANSPARENT
    s.alpha = 1;
#endif
    s.normalWS = NormalizeNormalPerPixel(s.normalWS);
    return s;
}

void TxInputData(TxVaryings v, TxSurfaceInput i, TxSurface s, out InputData d, out SurfaceData sd)
{
    d = (InputData)0;
    d.positionWS = i.positionWS;
    d.positionCS = v.positionCS;
    d.normalWS = s.normalWS;
    d.viewDirectionWS = i.viewDirWS;
#if defined(MAIN_LIGHT_CALCULATE_SHADOWS)
    d.shadowCoord = TransformWorldToShadowCoord(i.positionWS);
#else
    d.shadowCoord = float4(0, 0, 0, 0);
#endif
    d.fogCoord = v.fogFactor;
    d.bakedGI = SampleSH(s.normalWS);
    d.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(v.positionCS);
    d.shadowMask = half4(1, 1, 1, 1);
    sd = (SurfaceData)0;
    sd.albedo = s.albedo; sd.metallic = s.metallic; sd.specular = 0; sd.smoothness = s.smoothness;
    sd.occlusion = s.occlusion; sd.emission = s.emission; sd.alpha = s.alpha; sd.normalTS = float3(0, 0, 1);
}

half4 TxFragForward(TxVaryings v) : SV_Target
{
    UNITY_SETUP_INSTANCE_ID(v);
    UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(v);
    TxSurfaceInput i;
    TxSurface s = TxEvaluate(v, i);
#ifdef TX_UNLIT
    half4 c = half4(s.albedo, s.alpha);
#else
    InputData d; SurfaceData sd;
    TxInputData(v, i, s, d, sd);
    half4 c = UniversalFragmentPBR(d, sd);
    c.a = s.alpha;
#endif
#ifndef TX_NOFOG
    c.rgb = MixFog(c.rgb, v.fogFactor);
#endif
#ifdef TX_HAS_POST_FOG
    c.rgb = TxPostFog(v, i, c.rgb);
#endif
    return c;
}

#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/UnityGBuffer.hlsl"
FragmentOutput TxFragGBuffer(TxVaryings v)
{
    UNITY_SETUP_INSTANCE_ID(v);
    UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(v);
    TxSurfaceInput i;
    TxSurface s = TxEvaluate(v, i);
#ifdef TX_HAS_GBUFFER_ALBEDO
    s.albedo = TxGBufferAlbedo(v, i, s.albedo);
#endif
    InputData d; SurfaceData sd;
    TxInputData(v, i, s, d, sd);
#ifdef TX_UNLIT
    return SurfaceDataToGbuffer(sd, d, s.albedo, kLightingInvalid);
#else
    BRDFData brdf;
    half alpha = sd.alpha;
    InitializeBRDFData(sd.albedo, sd.metallic, sd.specular, sd.smoothness, alpha, brdf);
    Light mainLight = GetMainLight(d.shadowCoord, d.positionWS, d.shadowMask);
    MixRealtimeAndBakedGI(mainLight, d.normalWS, d.bakedGI, d.shadowMask);
    half3 gi = GlobalIllumination(brdf, d.bakedGI, sd.occlusion, d.positionWS, d.normalWS, d.viewDirectionWS);
    return BRDFDataToGbuffer(brdf, d, sd.smoothness, sd.emission + gi, sd.occlusion);
#endif
}

half4 TxFragDepth(TxVaryings v) : SV_Target
{
    UNITY_SETUP_INSTANCE_ID(v);
#ifdef TX_ALPHATEST
    TxSurfaceInput i;
    TxEvaluate(v, i);
#endif
    return 0;
}

half4 TxFragDepthNormals(TxVaryings v) : SV_Target
{
    UNITY_SETUP_INSTANCE_ID(v);
    TxSurfaceInput i;
    TxSurface s = TxEvaluate(v, i);
    return half4(s.normalWS, 0);
}

// Shader Graph node helpers used by the recovered bodies.
// pow() for fresnel/rim terms: 1 - N.V is exactly 0 where a surface faces the camera, and pow(0, 0) is NaN on D3D
// (exp2(0 * log2(0))). The stage cameras run HDR post-processing without Stop NaN, so one NaN pixel blacks the frame.
// Clamping the base keeps every finite result and gives x^0 = 1 there.
float TxPow(float x, float e) { return pow(max(x, 1e-6), e); }
float TxSmoothstep(float edge0, float edge1, float x)
{
    float t = saturate((x - edge0) / (edge1 - edge0));
    return t * t * (3 - 2 * t);
}
// Shader Graph Normal Unpack of a texture sample (DXT5nm/BC5 aware, like UnpackNormal).
float3 TxUnpackNormal(float4 packed) { return UnpackNormal(packed); }
// Triplanar blend weights as in Shader Graph's Triplanar node: |n|^blend normalized.
float3 TxTriplanarWeights(float3 normalWS, float blend)
{
    float3 w = pow(abs(normalWS), blend);
    return w / dot(w, 1);
}
// Shader Graph Triplanar (Default): planes sampled at p.zy, p.xz, p.xy.
float4 TxTriplanar(TEXTURE2D_PARAM(tex, smp), float3 p, float3 w)
{
    return SAMPLE_TEXTURE2D(tex, smp, p.zy) * w.x + SAMPLE_TEXTURE2D(tex, smp, p.xz) * w.y + SAMPLE_TEXTURE2D(tex, smp, p.xy) * w.z;
}
// Shader Graph Triplanar (Normal): whiteout-style blend into world space, as compiled in the original graphs.
float3 TxTriplanarNormalWS(TEXTURE2D_PARAM(tex, smp), float3 p, float3 n, float3 w)
{
    float3 x = UnpackNormal(SAMPLE_TEXTURE2D(tex, smp, p.zy));
    float3 y = UnpackNormal(SAMPLE_TEXTURE2D(tex, smp, p.xz));
    float3 z = UnpackNormal(SAMPLE_TEXTURE2D(tex, smp, p.xy));
    x = float3(n.x * x.z, n.y + x.y, n.z + x.x); // the X plane adds the swizzled .yx (grassrock1 ps lines 114-138)
    y = float3(n.x + y.x, n.y * y.z, n.z + y.y);
    z = float3(n.x + z.x, n.y + z.y, n.z * z.z);
    return normalize(x * w.x + y * w.y + z * w.z);
}
float3 TxWorldToTangent(float3 v, TxSurfaceInput i) { return normalize(float3(dot(v, i.tangentWS), dot(v, i.bitangentWS), dot(v, i.normalWS))); }
float3 TxTangentToWorld(float3 v, TxSurfaceInput i) { return normalize(i.tangentWS * v.x + i.bitangentWS * v.y + i.normalWS * v.z); }
// Shader Graph Normal Strength node.
float3 TxNormalStrength(float3 n, float strength) { return float3(n.xy * strength, lerp(1, n.z, saturate(strength))); }

#endif
