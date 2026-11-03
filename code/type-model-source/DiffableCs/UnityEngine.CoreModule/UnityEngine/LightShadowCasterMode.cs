namespace UnityEngine;

[NativeHeader("Runtime/Camera/SharedLightData.h")]
[Token(Token = "0x20000F8")]
public enum LightShadowCasterMode : int
{
	Default = 0,
	NonLightmappedOnly = 1,
	Everything = 2,
}

