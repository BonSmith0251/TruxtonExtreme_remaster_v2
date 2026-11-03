namespace System.Net;

[Token(Token = "0x200021C")]
internal static class HttpValidationHelpers
{
	[Token(Token = "0x40007C7")]
	private static readonly Char[] s_httpTrimCharacters; //Field offset: 0x0

	[Address(RVA = "0x2683570", Offset = "0x2682970", Length = "0x8C")]
	[Token(Token = "0x6000E31")]
	private static HttpValidationHelpers() { }

	[Address(RVA = "0x2683420", Offset = "0x2682820", Length = "0x108")]
	[Token(Token = "0x6000E30")]
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

}

