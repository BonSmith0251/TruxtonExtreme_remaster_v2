namespace TXEKernel;

[Token(Token = "0x20000F6")]
public static class TXESpriteAtlasUtil
{

	[Address(RVA = "0x2718370", Offset = "0x2717770", Length = "0x177")]
	[Token(Token = "0x6000727")]
	public static Sprite GetSprite(SpriteAtlas atlas, string name) { }

	[Address(RVA = "0x27184F0", Offset = "0x27178F0", Length = "0x4B")]
	[Token(Token = "0x6000729")]
	public static bool NameEquals(string a, string b, bool ignoreCase = true) { }

	[Address(RVA = "0x2718540", Offset = "0x2717940", Length = "0x132")]
	[Token(Token = "0x6000728")]
	public static string NormalizeName(string input) { }

}

