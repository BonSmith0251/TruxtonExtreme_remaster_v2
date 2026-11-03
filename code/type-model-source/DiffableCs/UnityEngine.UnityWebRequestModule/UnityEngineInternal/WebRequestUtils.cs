namespace UnityEngineInternal;

[Token(Token = "0x2000002")]
internal static class WebRequestUtils
{
	[Token(Token = "0x4000001")]
	private static Regex domainRegex; //Field offset: 0x0

	[Address(RVA = "0x347FDA0", Offset = "0x347F1A0", Length = "0x87")]
	[Token(Token = "0x6000005")]
	private static WebRequestUtils() { }

	[Address(RVA = "0x347F490", Offset = "0x347E890", Length = "0x2E4")]
	[Token(Token = "0x6000002")]
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	[Address(RVA = "0x347F780", Offset = "0x347EB80", Length = "0x41B")]
	[Token(Token = "0x6000003")]
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	[Address(RVA = "0x347FBA0", Offset = "0x347EFA0", Length = "0xF8")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	[Address(RVA = "0x347FCA0", Offset = "0x347F0A0", Length = "0xFA")]
	[Token(Token = "0x6000004")]
	private static string URLDecode(string encoded) { }

}

