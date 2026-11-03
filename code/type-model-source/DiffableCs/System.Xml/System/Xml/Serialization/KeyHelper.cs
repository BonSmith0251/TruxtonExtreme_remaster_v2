namespace System.Xml.Serialization;

[Token(Token = "0x20000FB")]
internal class KeyHelper
{

	[Address(RVA = "0x2542870", Offset = "0x2541C70", Length = "0xCC")]
	[Token(Token = "0x6000BF8")]
	public static void AddField(StringBuilder sb, int n, string val) { }

	[Address(RVA = "0x2542A30", Offset = "0x2541E30", Length = "0xDA")]
	[Token(Token = "0x6000BF9")]
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	[Address(RVA = "0x2542B10", Offset = "0x2541F10", Length = "0x3B")]
	[Token(Token = "0x6000BFA")]
	public static void AddField(StringBuilder sb, int n, bool val) { }

	[Address(RVA = "0x2542940", Offset = "0x2541D40", Length = "0x3B")]
	[Token(Token = "0x6000BFB")]
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	[Address(RVA = "0x2542980", Offset = "0x2541D80", Length = "0xA8")]
	[Token(Token = "0x6000BFC")]
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	[Address(RVA = "0x25427A0", Offset = "0x2541BA0", Length = "0xCE")]
	[Token(Token = "0x6000BFD")]
	public static void AddField(StringBuilder sb, int n, Type val) { }

}

