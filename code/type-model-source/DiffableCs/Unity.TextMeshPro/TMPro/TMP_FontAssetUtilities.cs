namespace TMPro;

[Token(Token = "0x2000059")]
public class TMP_FontAssetUtilities
{
	[Token(Token = "0x4000264")]
	private static readonly TMP_FontAssetUtilities s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000265")]
	private static HashSet<Int32> k_SearchedAssets; //Field offset: 0x8

	[Token(Token = "0x17000082")]
	public static TMP_FontAssetUtilities instance
	{
		[Address(RVA = "0x2EC76C0", Offset = "0x2EC6AC0", Length = "0x4E")]
		[Token(Token = "0x60002C1")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2EC7650", Offset = "0x2EC6A50", Length = "0x67")]
	[Token(Token = "0x60002C0")]
	private static TMP_FontAssetUtilities() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002CB")]
	public TMP_FontAssetUtilities() { }

	[Address(RVA = "0x2EC76C0", Offset = "0x2EC6AC0", Length = "0x4E")]
	[Token(Token = "0x60002C1")]
	public static TMP_FontAssetUtilities get_instance() { }

	[Address(RVA = "0x2EC65E0", Offset = "0x2EC59E0", Length = "0x182")]
	[Token(Token = "0x60002C2")]
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	[Address(RVA = "0x2EC6130", Offset = "0x2EC5530", Length = "0x4A6")]
	[Token(Token = "0x60002C3")]
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	[Address(RVA = "0x2EC6770", Offset = "0x2EC5B70", Length = "0x250")]
	[Token(Token = "0x60002C5")]
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	[Address(RVA = "0x2EC69D0", Offset = "0x2EC5DD0", Length = "0xFC")]
	[Token(Token = "0x60002C9")]
	internal static uint GetCodePoint(string text, ref int index) { }

	[Address(RVA = "0x2EC6AD0", Offset = "0x2EC5ED0", Length = "0x104")]
	[Token(Token = "0x60002CA")]
	internal static uint GetCodePoint(UInt32[] codesPoints, ref int index) { }

	[Address(RVA = "0x2EC6DC0", Offset = "0x2EC61C0", Length = "0x332")]
	[Token(Token = "0x60002C7")]
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	[Address(RVA = "0x2EC6BE0", Offset = "0x2EC5FE0", Length = "0x1D3")]
	[Token(Token = "0x60002C8")]
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	[Address(RVA = "0x2EC7100", Offset = "0x2EC6500", Length = "0x375")]
	[Token(Token = "0x60002C6")]
	internal static TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_Asset> textAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	[Address(RVA = "0x2EC7480", Offset = "0x2EC6880", Length = "0x1CB")]
	[Token(Token = "0x60002C4")]
	private static TMP_Character SearchFallbacksForCharacter(uint unicode, TMP_FontAsset sourceFontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

}

