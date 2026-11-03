namespace System.Net;

[Token(Token = "0x2000257")]
internal static class WebExceptionMapping
{
	[Token(Token = "0x4000969")]
	private static readonly String[] s_Mapping; //Field offset: 0x0

	[Address(RVA = "0x26ADE20", Offset = "0x26AD220", Length = "0x68")]
	[Token(Token = "0x6000FB2")]
	private static WebExceptionMapping() { }

	[Address(RVA = "0x26ADC70", Offset = "0x26AD070", Length = "0x1A7")]
	[Token(Token = "0x6000FB1")]
	internal static string GetWebStatusString(WebExceptionStatus status) { }

}

