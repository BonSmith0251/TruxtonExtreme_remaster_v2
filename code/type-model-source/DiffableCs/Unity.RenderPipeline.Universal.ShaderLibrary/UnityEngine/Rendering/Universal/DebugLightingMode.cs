namespace UnityEngine.Rendering.Universal;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@a6e30d1f59f5\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
[Token(Token = "0x2000010")]
public enum DebugLightingMode : int
{
	None = 0,
	ShadowCascades = 1,
	LightingWithoutNormalMaps = 2,
	LightingWithNormalMaps = 3,
	Reflections = 4,
	ReflectionsWithSmoothness = 5,
	GlobalIllumination = 6,
}

