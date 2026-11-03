namespace TMPro;

[Token(Token = "0x2000058")]
public static class TMP_FontUtilities
{
	[Token(Token = "0x4000263")]
	private static List<Int32> k_searchedFontAssets; //Field offset: 0x0

	[Address(RVA = "0x2EC84E0", Offset = "0x2EC78E0", Length = "0xFE")]
	[Token(Token = "0x60002BC")]
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x2EC83F0", Offset = "0x2EC77F0", Length = "0xED")]
	[Token(Token = "0x60002BD")]
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x2EC8040", Offset = "0x2EC7440", Length = "0x2B1")]
	[Token(Token = "0x60002BE")]
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x2EC8300", Offset = "0x2EC7700", Length = "0xE6")]
	[Token(Token = "0x60002BF")]
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

