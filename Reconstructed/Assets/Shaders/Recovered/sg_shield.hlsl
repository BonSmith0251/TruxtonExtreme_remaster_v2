// Recovered from Shader Graphs/sg_shield, Universal Forward ps (evidence/shader-recovery). URP Unlit, alpha blend.
// rgb = sRGB(_Color) (graph's linear->sRGB Colorspace Conversion). Alpha = (rim + edge) * hex where
//   rim  = pow(|1 - |N.V||, _FresnalPower)
//   edge = smoothstep(0, 1, saturate(_EdgeOffset - (sceneEyeDepth - fragmentEyeDepth)))  (soft intersection glow; scene
//          depth via Shader Graph Scene Depth (Eye), fragment depth = Screen Position (Raw).w)
//   hex  = 1.5 * saturate(Overlay(base = lerp(h, min(h, 0), _Tx_Hex.a*_AlphaIntensity) with h = _Tx_Hex.r*_TxIntencity,
//          blend = lerp(_FlickIntencity.x, _FlickIntencity.y, (sin(2*time) + 1)/2)))
//   with _Tx_Hex sampled at uv0 + time*_TxSpeed.xy. Time here is raw _TimeParameters.x (no _Tx_SpeedRate).
// Needs the camera depth texture (URP asset Depth Texture on). No fog in the original graph.
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

CBUFFER_START(UnityPerMaterial)
    float4 _Color;
    float _EdgeOffset;
    float _FresnalPower;
    float4 _TxSpeed;
    float4 _Tx_Hex_TexelSize;
    float _AlphaIntensity;
    float _TxIntencity;
    float2 _FlickIntencity;
CBUFFER_END
TEXTURE2D(_Tx_Hex); SAMPLER(sampler_Tx_Hex);

// Shader Graph Colorspace Conversion Linear -> RGB, constants as in the original bytecode.
float3 TxBLinearToSRGB(float3 c)
{
    float3 lo = c * 12.92321;
    float3 hi = pow(abs(c), float3(1.0 / 2.4, 1.0 / 2.4, 1.0 / 2.4)) * 1.055 - 0.055;
    return float3(c.x <= 0.0031308 ? lo.x : hi.x, c.y <= 0.0031308 ? lo.y : hi.y, c.z <= 0.0031308 ? lo.z : hi.z);
}

// Shader Graph Scene Depth node, Eye mode (URP 16).
float TxBSceneEyeDepth(float2 uv)
{
    float raw = SampleSceneDepth(uv);
    if (unity_OrthoParams.w == 1.0)
        return LinearEyeDepth(ComputeWorldSpacePosition(uv, raw, UNITY_MATRIX_I_VP), UNITY_MATRIX_V);
    return LinearEyeDepth(raw, _ZBufferParams);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float time = _TimeParameters.x;

    float4 hexTex = SAMPLE_TEXTURE2D(_Tx_Hex, sampler_Tx_Hex, i.uv0.xy + time * _TxSpeed.xy);
    float h = hexTex.r * _TxIntencity;
    float baseV = lerp(h, min(h, 0), hexTex.a * _AlphaIntensity);
    float flick = lerp(_FlickIntencity.x, _FlickIntencity.y, (sin(time * 2) + 1) * 0.5);
    float overlay = (baseV <= 0.5) ? 2 * baseV * flick : 1 - 2 * (1 - baseV) * (1 - flick);
    float hex = saturate(overlay) * 1.5;

    float rim = TxPow(abs(1 - abs(dot(i.normalWS, i.viewDirWS))), _FresnalPower);

    float sceneEye = TxBSceneEyeDepth(i.screenPosition.xy);
    float e = saturate(_EdgeOffset - (sceneEye - i.screenRaw.w));
    float edge = e * e * (3 - 2 * e);

    s.albedo = TxBLinearToSRGB(_Color.rgb);
    s.alpha = (rim + edge) * hex;
}
