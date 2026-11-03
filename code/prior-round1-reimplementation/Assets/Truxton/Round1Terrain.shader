Shader "Truxton/Round1 Triplanar"
{
    Properties
    {
        _BaseMap("Albedo",2D)="white"{}
        _BaseColor("Tint",Color)=(1,1,1,1)
        _EmissionMap("Emission",2D)="black"{}
        [HDR]_EmissionColor("Emission tint",Color)=(0,0,0,1)
        _Tiling("World texture scale",Float)=0.01
        _Scroll("Lava flow",Float)=0
        _Smoothness("Smoothness",Range(0,1))=0.35
        _Cutoff("Cutoff",Float)=0.5
        _Cull("Cull",Float)=2
    }
    SubShader
    {
        Tags{"RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" "Queue"="Geometry"}
        Pass
        {
            Tags{"LightMode"="UniversalForward"}
            Cull [_Cull]
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fog
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            TEXTURE2D(_BaseMap);SAMPLER(sampler_BaseMap);
            TEXTURE2D(_EmissionMap);SAMPLER(sampler_EmissionMap);
            CBUFFER_START(UnityPerMaterial)
            float4 _BaseColor,_EmissionColor;float _Tiling,_Scroll,_Smoothness,_Cutoff,_Cull;
            CBUFFER_END
            float _TruxtonTime;
            struct Attributes{float4 positionOS:POSITION;float3 normalOS:NORMAL;};
            struct Varyings{float4 positionCS:SV_POSITION;float3 positionWS:TEXCOORD0;half3 normalWS:TEXCOORD1;half fog:TEXCOORD2;};
            Varyings vert(Attributes v)
            {
                Varyings o;VertexPositionInputs p=GetVertexPositionInputs(v.positionOS.xyz);
                o.positionCS=p.positionCS;o.positionWS=p.positionWS;o.normalWS=TransformObjectToWorldNormal(v.normalOS);
                o.fog=ComputeFogFactor(p.positionCS.z);return o;
            }
            half4 frag(Varyings i):SV_Target
            {
                half3 n=normalize(i.normalWS);half3 w=pow(abs(n),4);w/=max(w.x+w.y+w.z,0.0001);
                float3 p=i.positionWS*_Tiling;float shift=_TruxtonTime*_Scroll;
                half3 albedo=(SAMPLE_TEXTURE2D(_BaseMap,sampler_BaseMap,p.zy+shift).rgb*w.x+
                    SAMPLE_TEXTURE2D(_BaseMap,sampler_BaseMap,p.xz+shift).rgb*w.y+
                    SAMPLE_TEXTURE2D(_BaseMap,sampler_BaseMap,p.xy+shift).rgb*w.z)*_BaseColor.rgb;
                half3 emission=(SAMPLE_TEXTURE2D(_EmissionMap,sampler_EmissionMap,p.zy+shift).rgb*w.x+
                    SAMPLE_TEXTURE2D(_EmissionMap,sampler_EmissionMap,p.xz+shift).rgb*w.y+
                    SAMPLE_TEXTURE2D(_EmissionMap,sampler_EmissionMap,p.xy+shift).rgb*w.z)*_EmissionColor.rgb;
                InputData input=(InputData)0;input.positionWS=i.positionWS;input.normalWS=n;
                input.viewDirectionWS=GetWorldSpaceNormalizeViewDir(i.positionWS);
                input.shadowCoord=TransformWorldToShadowCoord(i.positionWS);input.bakedGI=SampleSH(n);
                input.normalizedScreenSpaceUV=GetNormalizedScreenSpaceUV(i.positionCS);
                SurfaceData surface=(SurfaceData)0;surface.albedo=albedo;surface.alpha=1;
                surface.smoothness=_Smoothness;surface.occlusion=1;surface.emission=emission;
                half4 color=UniversalFragmentPBR(input,surface);color.rgb=MixFog(color.rgb,i.fog);return color;
            }
            ENDHLSL
        }
        UsePass "Universal Render Pipeline/Lit/ShadowCaster"
        UsePass "Universal Render Pipeline/Lit/DepthOnly"
    }
}
