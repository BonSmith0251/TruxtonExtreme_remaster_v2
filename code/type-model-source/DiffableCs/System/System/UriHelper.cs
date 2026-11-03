namespace System;

[Token(Token = "0x20000C6")]
internal static class UriHelper
{
	[Token(Token = "0x40002E8")]
	private static readonly Char[] HexUpperChars; //Field offset: 0x0

	[Address(RVA = "0x26102B0", Offset = "0x260F6B0", Length = "0x8C")]
	[Token(Token = "0x6000409")]
	private static UriHelper() { }

	[Address(RVA = "0x260E470", Offset = "0x260D870", Length = "0xFF")]
	[Token(Token = "0x60003FF")]
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	[Address(RVA = "0x260E570", Offset = "0x260D970", Length = "0x103")]
	[Token(Token = "0x6000403")]
	internal static void EscapeAsciiChar(char ch, Char[] to, ref int pos) { }

	[Address(RVA = "0x260ECF0", Offset = "0x260E0F0", Length = "0x92")]
	[Token(Token = "0x6000404")]
	internal static char EscapedAscii(char digit, char next) { }

	[Address(RVA = "0x260E680", Offset = "0x260DA80", Length = "0x66A")]
	[Token(Token = "0x60003FE")]
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	[Address(RVA = "0x260ED90", Offset = "0x260E190", Length = "0x83")]
	[Token(Token = "0x6000408")]
	internal static bool Is3986Unreserved(char c) { }

	[Address(RVA = "0x260EE20", Offset = "0x260E220", Length = "0x49")]
	[Token(Token = "0x6000405")]
	internal static bool IsNotSafeForUnescape(char ch) { }

	[Address(RVA = "0x260EE70", Offset = "0x260E270", Length = "0x124")]
	[Token(Token = "0x6000406")]
	private static bool IsReservedUnreservedOrHash(char c) { }

	[Address(RVA = "0x260EFA0", Offset = "0x260E3A0", Length = "0x11E")]
	[Token(Token = "0x6000407")]
	internal static bool IsUnreserved(char c) { }

	[Address(RVA = "0x260F0C0", Offset = "0x260E4C0", Length = "0x49F")]
	[Token(Token = "0x6000402")]
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, ref int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	[Address(RVA = "0x260F560", Offset = "0x260E960", Length = "0x189")]
	[Token(Token = "0x60003FD")]
	internal static bool TestForSubPath(Char* pMe, ushort meLength, Char* pShe, ushort sheLength, bool ignoreCase) { }

	[Address(RVA = "0x260F6F0", Offset = "0x260EAF0", Length = "0xD4")]
	[Token(Token = "0x6000400")]
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	[Address(RVA = "0x260F7D0", Offset = "0x260EBD0", Length = "0xAD8")]
	[Token(Token = "0x6000401")]
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

}

