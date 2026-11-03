namespace UnityEngine.Rendering.Universal;

[Flags]
[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@a6e30d1f59f5\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
[Token(Token = "0x2000012")]
public enum DebugLightingFeatureFlags : int
{
	None = 0,
	GlobalIllumination = 1,
	MainLight = 2,
	AdditionalLights = 4,
	VertexLighting = 8,
	Emission = 16,
	AmbientOcclusion = 32,
}

