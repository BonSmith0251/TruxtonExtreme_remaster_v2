namespace UnityEngine.Rendering;

[Extension]
[MovedFrom("Utilities")]
[Token(Token = "0x20001E3")]
public static class MaterialQualityUtilities
{
	[Token(Token = "0x4000945")]
	public static String[] KeywordNames; //Field offset: 0x0
	[Token(Token = "0x4000946")]
	public static String[] EnumNames; //Field offset: 0x8
	[Token(Token = "0x4000947")]
	public static ShaderKeyword[] Keywords; //Field offset: 0x10

	[Address(RVA = "0x2C61990", Offset = "0x2C60D90", Length = "0x2DB")]
	[Token(Token = "0x6000E83")]
	private static MaterialQualityUtilities() { }

	[Address(RVA = "0x2C61410", Offset = "0x2C60810", Length = "0x8")]
	[Token(Token = "0x6000E82")]
	public static MaterialQuality FromIndex(int index) { }

	[Address(RVA = "0x2C61420", Offset = "0x2C60820", Length = "0x1C0")]
	[Extension]
	[Token(Token = "0x6000E7E")]
	public static MaterialQuality GetClosestQuality(MaterialQuality availableLevels, MaterialQuality requestedLevel) { }

	[Address(RVA = "0x2C615F0", Offset = "0x2C609F0", Length = "0x87")]
	[Extension]
	[Token(Token = "0x6000E7D")]
	public static MaterialQuality GetHighestQuality(MaterialQuality levels) { }

	[Address(RVA = "0x2C61680", Offset = "0x2C60A80", Length = "0x124")]
	[Extension]
	[Token(Token = "0x6000E7F")]
	public static void SetGlobalShaderKeywords(MaterialQuality level) { }

	[Address(RVA = "0x2C617B0", Offset = "0x2C60BB0", Length = "0x147")]
	[Extension]
	[Token(Token = "0x6000E80")]
	public static void SetGlobalShaderKeywords(MaterialQuality level, CommandBuffer cmd) { }

	[Address(RVA = "0x2C61900", Offset = "0x2C60D00", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000E81")]
	public static int ToFirstIndex(MaterialQuality level) { }

}

