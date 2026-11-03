namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x20001CB")]
public static class LightExtensions
{

	[Address(RVA = "0x2E074F0", Offset = "0x2E068F0", Length = "0x8E")]
	[Extension]
	[Token(Token = "0x60009EB")]
	public static UniversalAdditionalLightData GetUniversalAdditionalLightData(Light light) { }

}

