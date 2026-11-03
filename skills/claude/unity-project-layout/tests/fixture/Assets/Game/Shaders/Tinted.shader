Shader "Custom/Tinted"
{
    Properties { _Color ("Color", Color) = (1,1,1,1) }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "Assets/Game/Shaders/common.hlsl"
            float4 _Color;
            float4 vert(float4 v:POSITION):SV_POSITION{return UnityObjectToClipPos(v);}
            float4 frag():SV_Target{return Tint(_Color);}
            ENDCG
        }
    }
}
