namespace System;

[Token(Token = "0x20000B8")]
internal static class IriHelper
{

	[Address(RVA = "0x25FD110", Offset = "0x25FC510", Length = "0x5F")]
	[Token(Token = "0x6000373")]
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	[Address(RVA = "0x25FCBA0", Offset = "0x25FBFA0", Length = "0x567")]
	[Token(Token = "0x6000374")]
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	[Address(RVA = "0x25FD170", Offset = "0x25FC570", Length = "0x101")]
	[Token(Token = "0x6000375")]
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	[Address(RVA = "0x25FD280", Offset = "0x25FC680", Length = "0x820")]
	[Token(Token = "0x6000376")]
	internal static string EscapeUnescapeIri(Char* pInput, int start, int end, UriComponents component) { }

}

