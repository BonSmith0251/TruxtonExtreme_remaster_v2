namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005DA")]
internal static class Shaders
{
	[Token(Token = "0x400153D")]
	public static readonly string k_AtlasBlit; //Field offset: 0x0
	[Token(Token = "0x400153E")]
	public static readonly string k_Default; //Field offset: 0x8
	[Token(Token = "0x400153F")]
	public static readonly string k_RuntimeGaussianBlur; //Field offset: 0x10
	[Token(Token = "0x4001540")]
	public static readonly string k_RuntimeColorEffect; //Field offset: 0x18
	[Token(Token = "0x4001541")]
	public static readonly string k_ColorConversionBlit; //Field offset: 0x20
	[Token(Token = "0x4001542")]
	public static readonly string k_ForceGammaKeyword; //Field offset: 0x28
	[Token(Token = "0x4001543")]
	public static readonly string k_TextureSlotCount1; //Field offset: 0x30
	[Token(Token = "0x4001544")]
	public static readonly string k_TextureSlotCount2; //Field offset: 0x38
	[Token(Token = "0x4001545")]
	public static readonly string k_TextureSlotCount4; //Field offset: 0x40
	[Token(Token = "0x4001546")]
	public static readonly string k_ForceRenderTypeSolid; //Field offset: 0x48
	[Token(Token = "0x4001547")]
	public static readonly string k_ForceRenderTypeTextured; //Field offset: 0x50
	[Token(Token = "0x4001548")]
	public static readonly string k_ForceRenderTypeText; //Field offset: 0x58
	[Token(Token = "0x4001549")]
	public static readonly string k_ForceRenderTypeSvgGradient; //Field offset: 0x60
	[Token(Token = "0x400154A")]
	private static Material s_DefaultMaterial; //Field offset: 0x68
	[Token(Token = "0x400154B")]
	private static int s_RefCount; //Field offset: 0x70

	[Token(Token = "0x17000A8A")]
	public static Material defaultMaterial
	{
		[Address(RVA = "0x3324910", Offset = "0x3323D10", Length = "0x1A7")]
		[Token(Token = "0x6002A21")]
		 get { } //Length: 423
	}

	[Address(RVA = "0x3324580", Offset = "0x3323980", Length = "0x38A")]
	[Token(Token = "0x6002A25")]
	private static Shaders() { }

	[Address(RVA = "0x3324250", Offset = "0x3323650", Length = "0x53")]
	[Token(Token = "0x6002A23")]
	public static void Acquire() { }

	[Address(RVA = "0x3324910", Offset = "0x3323D10", Length = "0x1A7")]
	[Token(Token = "0x6002A21")]
	public static Material get_defaultMaterial() { }

	[Address(RVA = "0x33242B0", Offset = "0x33236B0", Length = "0x162")]
	[Token(Token = "0x6002A22")]
	private static Material GetOrCreateMaterial(ref Material material, string shaderName) { }

	[Address(RVA = "0x3324420", Offset = "0x3323820", Length = "0x158")]
	[Token(Token = "0x6002A24")]
	public static void Release() { }

}

