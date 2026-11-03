namespace System.Net;

[Token(Token = "0x2000268")]
internal class NetRes
{

	[Address(RVA = "0x26CC840", Offset = "0x26CBC40", Length = "0x143")]
	[Token(Token = "0x6001031")]
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

	[Address(RVA = "0x26CC990", Offset = "0x26CBD90", Length = "0x51")]
	[Token(Token = "0x6001030")]
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	[Address(RVA = "0x26CC9F0", Offset = "0x26CBDF0", Length = "0xA6")]
	[Token(Token = "0x600102F")]
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

}

