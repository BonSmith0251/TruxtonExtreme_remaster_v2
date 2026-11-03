namespace System.Net;

[Token(Token = "0x200021B")]
internal static class HttpStatusDescription
{

	[Address(RVA = "0x2682C10", Offset = "0x2682010", Length = "0x7")]
	[Token(Token = "0x6000E2E")]
	internal static string Get(HttpStatusCode code) { }

	[Address(RVA = "0x2682C20", Offset = "0x2682020", Length = "0x6DC")]
	[Token(Token = "0x6000E2F")]
	internal static string Get(int code) { }

}

