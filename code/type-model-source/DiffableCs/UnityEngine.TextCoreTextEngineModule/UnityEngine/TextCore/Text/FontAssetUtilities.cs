namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000035")]
internal static class FontAssetUtilities
{
	[Token(Token = "0x4000179")]
	private static HashSet<Int32> k_SearchedAssets; //Field offset: 0x0

	[Address(RVA = "0x31AF0A0", Offset = "0x31AE4A0", Length = "0x11D")]
	[Token(Token = "0x6000148")]
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	[Address(RVA = "0x31AEA60", Offset = "0x31ADE60", Length = "0x634")]
	[Token(Token = "0x6000149")]
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	[Address(RVA = "0x31AF3B0", Offset = "0x31AE7B0", Length = "0x16F")]
	[Token(Token = "0x600014A")]
	internal static Character GetCharacterFromFontAssetsInternal(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true) { }

	[Address(RVA = "0x31AF1C0", Offset = "0x31AE5C0", Length = "0x1EB")]
	[Token(Token = "0x600014B")]
	private static Character GetCharacterFromFontAssetsInternal(uint unicode, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = true) { }

	[Address(RVA = "0x31AF630", Offset = "0x31AEA30", Length = "0xFC")]
	[Token(Token = "0x600014F")]
	public static uint GetCodePoint(string text, ref int index) { }

	[Address(RVA = "0x31AF520", Offset = "0x31AE920", Length = "0x104")]
	[Token(Token = "0x6000150")]
	public static uint GetCodePoint(UInt32[] codesPoints, ref int index) { }

	[Address(RVA = "0x31AF8F0", Offset = "0x31AECF0", Length = "0x2C6")]
	[Token(Token = "0x600014D")]
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	[Address(RVA = "0x31AF730", Offset = "0x31AEB30", Length = "0x1B3")]
	[Token(Token = "0x600014E")]
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	[Address(RVA = "0x31AFBC0", Offset = "0x31AEFC0", Length = "0x2F0")]
	[Token(Token = "0x600014C")]
	internal static TextElement GetTextElementFromTextAssets(uint unicode, FontAsset sourceFontAsset, List<TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

}

