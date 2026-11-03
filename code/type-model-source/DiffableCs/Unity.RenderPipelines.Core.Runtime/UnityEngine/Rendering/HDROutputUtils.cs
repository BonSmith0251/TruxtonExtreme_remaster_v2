namespace UnityEngine.Rendering;

[Token(Token = "0x20001DC")]
public static class HDROutputUtils
{
	[Token(Token = "0x20001DE")]
	internal struct HDRDisplayInformation
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000932")]
		public int maxFullFrameToneMapLuminance; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000933")]
		public int maxToneMapLuminance; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000934")]
		public int minToneMapLuminance; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000935")]
		public float paperWhiteNits; //Field offset: 0xC

		[Address(RVA = "0x2C5D5B0", Offset = "0x2C5C9B0", Length = "0x16")]
		[Token(Token = "0x6000E62")]
		public HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits) { }

	}

	[Flags]
	[Token(Token = "0x20001DD")]
	internal enum Operation : int
	{
		None = 0,
		ColorConversion = 1,
		ColorEncoding = 2,
	}

	[Token(Token = "0x20001DF")]
	internal static class ShaderKeywords
	{
		[Token(Token = "0x4000936")]
		public const string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION"; //Field offset: 0x0
		[Token(Token = "0x4000937")]
		public const string HDR_ENCODING = "HDR_ENCODING"; //Field offset: 0x0
		[Token(Token = "0x4000938")]
		public const string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING"; //Field offset: 0x0
		[Token(Token = "0x4000939")]
		public const string HDR_INPUT = "HDR_INPUT"; //Field offset: 0x0
		[Token(Token = "0x400093A")]
		internal static readonly ShaderKeyword HDRColorSpaceConversion; //Field offset: 0x0
		[Token(Token = "0x400093B")]
		internal static readonly ShaderKeyword HDREncoding; //Field offset: 0x10
		[Token(Token = "0x400093C")]
		internal static readonly ShaderKeyword HDRColorSpaceConversionAndEncoding; //Field offset: 0x20
		[Token(Token = "0x400093D")]
		internal static readonly ShaderKeyword HDRInput; //Field offset: 0x30

		[Address(RVA = "0x2C64BF0", Offset = "0x2C63FF0", Length = "0x180")]
		[Token(Token = "0x6000E63")]
		private static ShaderKeywords() { }

	}

	[Token(Token = "0x20001E0")]
	private static class ShaderPropertyId
	{
		[Token(Token = "0x400093E")]
		public static readonly int hdrColorSpace; //Field offset: 0x0
		[Token(Token = "0x400093F")]
		public static readonly int hdrEncoding; //Field offset: 0x4

		[Address(RVA = "0x2C64D70", Offset = "0x2C64170", Length = "0x7A")]
		[Token(Token = "0x6000E64")]
		private static ShaderPropertyId() { }

	}


	[Address(RVA = "0x2C5DBC0", Offset = "0x2C5CFC0", Length = "0x2D3")]
	[Token(Token = "0x6000E5D")]
	public static void ConfigureHDROutput(Material material, ColorGamut gamut, Operation operations) { }

	[Address(RVA = "0x2C5D810", Offset = "0x2C5CC10", Length = "0xC9")]
	[Token(Token = "0x6000E5E")]
	public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut) { }

	[Address(RVA = "0x2C5D5D0", Offset = "0x2C5C9D0", Length = "0x23E")]
	[Token(Token = "0x6000E5F")]
	public static void ConfigureHDROutput(Material material, Operation operations) { }

	[Address(RVA = "0x2C5D8E0", Offset = "0x2C5CCE0", Length = "0x2D3")]
	[Token(Token = "0x6000E60")]
	public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, Operation operations) { }

	[Address(RVA = "0x2C5DEA0", Offset = "0x2C5D2A0", Length = "0x191")]
	[Token(Token = "0x6000E5C")]
	public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding) { }

	[Address(RVA = "0x2C5E040", Offset = "0x2C5D440", Length = "0x265")]
	[Token(Token = "0x6000E5B")]
	public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace) { }

	[Address(RVA = "0x2C5E2B0", Offset = "0x2C5D6B0", Length = "0x168")]
	[Token(Token = "0x6000E61")]
	public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled) { }

}

