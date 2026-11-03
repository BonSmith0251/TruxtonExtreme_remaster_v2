// Recovered from Shader Graphs/sg_emission_FlickerDepth, SubShader 0 Universal Forward / DepthOnly (evidence/shader-recovery).
// Lit PBR from plain UV0 maps: albedo RGB, normal map, metallic R / smoothness A * _Smoothness, occlusion R.
// Emission = HDR(_EmissionColir) * emissionMap.rgb * 4, Overlay-blended with black (Shader Graph Blend Overlay,
// Blend = 0) at opacity (sin(2pi * t * _FlickerSpeed) + 1) * 0.5 * _MaskPower * emissionMap.a, so bright texels
// pulse brighter and dark ones toward black. t = _TimeParameters.x * _Tx_SpeedRate (game-set global time scale).
// "Depth": the Forward and DepthOnly vertex programs add _Shifter to clip-space z (positionCS.z += _Shifter).
// FOG_LINEAR/FOG_EXP/FOG_EXP2 Toggle properties only switch URP's standard fog keywords (standard MixFog).
CBUFFER_START(UnityPerMaterial)
    float _FlickerSpeed;
    float4 _Tx_Emission_TexelSize;
    float4 _EmissionColir;
    float _MaskPower;
    float4 _Tx_Albedo_TexelSize;
    float4 _Tx_Metsllic_TexelSize;
    float _Smoothness;
    float4 _Tx_Normal_TexelSize;
    float4 _Tx_Occlusion_TexelSize;
    float _Shifter;
CBUFFER_END
float _Tx_SpeedRate; // global set by the game (0 if never set: the flicker then holds still)
TEXTURE2D(_Tx_Emission); SAMPLER(sampler_Tx_Emission);
TEXTURE2D(_Tx_Albedo); SAMPLER(sampler_Tx_Albedo);
TEXTURE2D(_Tx_Metsllic); SAMPLER(sampler_Tx_Metsllic);
TEXTURE2D(_Tx_Normal); SAMPLER(sampler_Tx_Normal);
TEXTURE2D(_Tx_Occlusion); SAMPLER(sampler_Tx_Occlusion);

// Shader Graph HDR colour property: converted to sRGB in a Gamma-space project (the original build is Gamma).
float3 RecHdrColor(float3 c)
{
#ifdef UNITY_COLORSPACE_GAMMA
    return LinearToSRGB(c);
#else
    return c;
#endif
}

// Shader Graph Blend node, Overlay mode.
float3 RecBlendOverlay(float3 base, float3 blend, float opacity)
{
    float3 r1 = 1.0 - 2.0 * (1.0 - base) * (1.0 - blend);
    float3 r2 = 2.0 * base * blend;
    float3 zeroOrOne = step(base, 0.5);
    return lerp(base, r2 * zeroOrOne + (1.0 - zeroOrOne) * r1, opacity);
}

// The original adds _Shifter to clip z after the usual transform; the shared passes only expose object space, so the
// vertex is moved to the point that projects to the same screen position with that depth. Perspective: scaling about
// the eye by m = z0 / (z0 + _Shifter) (z0 = clip z of the eye) gives clip' = m * (x, y, z + _Shifter, w) exactly.
// Orthographic: a move along the view axis by _Shifter / (dz_clip per unit). Only applied while rendering from the
// camera (the original shadow caster has no shift). Shading/fog then see the moved position (small difference).
void TxVertexFunction(inout TxVertexInput v)
{
    float3 posWS = TransformObjectToWorld(v.positionOS);
    float4x4 vp = UNITY_MATRIX_VP;
    float3 cam = _WorldSpaceCameraPos;
    if (unity_OrthoParams.w < 0.5)
    {
        float4 camCS = mul(vp, float4(cam, 1.0));
        float d = camCS.z + _Shifter;
        if (abs(camCS.w) < 1e-2 && abs(d) > 1e-6) // eye on w = 0: this is the camera's own view
            posWS = cam + (posWS - cam) * (camCS.z / d);
    }
    else
    {
        float3 f = cross(vp[0].xyz, vp[1].xyz); // keeps clip x, y
        float k = dot(vp[2].xyz, f);
        float3 camFwd = unity_CameraToWorld._m02_m12_m22;
        if (dot(f, f) > 1e-20 && abs(dot(normalize(f), camFwd)) > 0.999 && abs(k) > 1e-20)
            posWS += f * (_Shifter / k);
    }
    v.positionOS = TransformWorldToObject(posWS);
}

void TxSurfaceFunction(TxSurfaceInput i, inout TxSurface s)
{
    float2 uv = i.uv0.xy;
    float3 albedo = SAMPLE_TEXTURE2D(_Tx_Albedo, sampler_Tx_Albedo, uv).rgb;
    float3 normalTS = TxUnpackNormal(SAMPLE_TEXTURE2D(_Tx_Normal, sampler_Tx_Normal, uv));
    float4 metal = SAMPLE_TEXTURE2D(_Tx_Metsllic, sampler_Tx_Metsllic, uv);
    float occlusion = SAMPLE_TEXTURE2D(_Tx_Occlusion, sampler_Tx_Occlusion, uv).r;
    float4 em = SAMPLE_TEXTURE2D(_Tx_Emission, sampler_Tx_Emission, uv);

    float3 emission = RecHdrColor(_EmissionColir.rgb) * em.rgb * 4.0;
    float t = _TimeParameters.x * _Tx_SpeedRate;
    float flicker = (sin(t * _FlickerSpeed * 6.283185) + 1.0) * _MaskPower * em.a * 0.5;

    s.albedo = albedo;
    s.normalWS = TxTangentToWorld(normalTS, i);
    s.metallic = saturate(metal.r);
    s.smoothness = saturate(metal.a * _Smoothness);
    s.occlusion = occlusion;
    s.emission = RecBlendOverlay(emission, 0.0, flicker);
}
