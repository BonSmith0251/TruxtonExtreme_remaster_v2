namespace System.Net;

[Token(Token = "0x2000277")]
internal class CookieParser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A23")]
	private CookieTokenizer m_tokenizer; //Field offset: 0x10

	[Address(RVA = "0x26B9C40", Offset = "0x26B9040", Length = "0x93")]
	[Token(Token = "0x6001095")]
	internal CookieParser(string cookieString) { }

	[Address(RVA = "0x26B9150", Offset = "0x26B8550", Length = "0x82")]
	[Token(Token = "0x6001097")]
	internal static string CheckQuoted(string value) { }

	[Address(RVA = "0x26B91E0", Offset = "0x26B85E0", Length = "0xA24")]
	[Token(Token = "0x6001096")]
	internal Cookie Get() { }

}

