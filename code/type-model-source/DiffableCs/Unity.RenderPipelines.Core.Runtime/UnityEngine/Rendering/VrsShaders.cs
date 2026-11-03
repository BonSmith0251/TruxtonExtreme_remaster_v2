namespace UnityEngine.Rendering;

[Token(Token = "0x2000232")]
internal static class VrsShaders
{
	[Token(Token = "0x40009D7")]
	internal const string k_TileSizePrefix = "VRS_TILE_SIZE_"; //Field offset: 0x0
	[Token(Token = "0x40009D8")]
	internal const string k_DisableTexture2dXArray = "DISABLE_TEXTURE2D_X_ARRAY"; //Field offset: 0x0
	[Token(Token = "0x40009D9")]
	internal const string k_YFlip = "APPLY_Y_FLIP"; //Field offset: 0x0
	[Token(Token = "0x40009DA")]
	internal static readonly int s_ScaleBias; //Field offset: 0x0
	[Token(Token = "0x40009DF")]
	internal const string k_KernelTextureCopy = "TextureCopy"; //Field offset: 0x0
	[Token(Token = "0x40009E0")]
	internal const string k_KernelTextureReduce = "TextureReduce"; //Field offset: 0x0
	[Token(Token = "0x40009DB")]
	internal static readonly int s_MainTex; //Field offset: 0x4
	[Token(Token = "0x40009DC")]
	internal static readonly int s_MainTexLut; //Field offset: 0x8
	[Token(Token = "0x40009DD")]
	internal static readonly int s_ShadingRateNativeValues; //Field offset: 0xC
	[Token(Token = "0x40009DE")]
	internal static readonly int s_ShadingRateImage; //Field offset: 0x10
	[Token(Token = "0x40009E1")]
	internal static readonly int s_VisualizationLut; //Field offset: 0x14
	[Token(Token = "0x40009E2")]
	internal static readonly int s_VisualizationParams; //Field offset: 0x18

	[Address(RVA = "0x2C89EE0", Offset = "0x2C892E0", Length = "0x151")]
	[Token(Token = "0x6000FC1")]
	private static VrsShaders() { }

}

