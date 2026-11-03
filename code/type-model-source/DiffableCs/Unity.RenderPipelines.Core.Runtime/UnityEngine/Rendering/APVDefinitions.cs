namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\Lighting\\ProbeVolume\\ShaderVariablesProbeVolumes.cs")]
[Token(Token = "0x2000145")]
internal class APVDefinitions
{
	[Token(Token = "0x400061C")]
	public static int probeIndexChunkSize; //Field offset: 0x0
	[Token(Token = "0x400061D")]
	public const float probeValidityThreshold = 0.05; //Field offset: 0x0
	[Token(Token = "0x400061E")]
	public static int probeMaxRegionCount; //Field offset: 0x4
	[Token(Token = "0x400061F")]
	public static Color32[] layerMaskColors; //Field offset: 0x8
	[Token(Token = "0x4000620")]
	public static Color debugEmptyColor; //Field offset: 0x10

	[Address(RVA = "0x2C23380", Offset = "0x2C22780", Length = "0x11D")]
	[Token(Token = "0x6000ADD")]
	private static APVDefinitions() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000ADC")]
	public APVDefinitions() { }

}

