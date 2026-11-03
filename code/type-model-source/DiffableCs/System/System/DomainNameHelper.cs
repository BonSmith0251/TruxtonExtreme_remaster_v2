namespace System;

[Token(Token = "0x20000CB")]
internal class DomainNameHelper
{

	[Address(RVA = "0x26152C0", Offset = "0x26146C0", Length = "0x254")]
	[Token(Token = "0x6000428")]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	[Address(RVA = "0x2615520", Offset = "0x2614920", Length = "0x17D")]
	[Token(Token = "0x6000429")]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	[Address(RVA = "0x26156A0", Offset = "0x2614AA0", Length = "0x25")]
	[Token(Token = "0x600042E")]
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	[Address(RVA = "0x26156D0", Offset = "0x2614AD0", Length = "0x7C")]
	[Token(Token = "0x600042A")]
	private static bool IsIdnAce(string input, int index) { }

	[Address(RVA = "0x2615750", Offset = "0x2614B50", Length = "0x30")]
	[Token(Token = "0x600042B")]
	private static bool IsIdnAce(Char* input, int index) { }

	[Address(RVA = "0x2615990", Offset = "0x2614D90", Length = "0x161")]
	[Token(Token = "0x6000426")]
	internal static bool IsValid(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[Address(RVA = "0x2615780", Offset = "0x2614B80", Length = "0x1CF")]
	[Token(Token = "0x6000427")]
	internal static bool IsValidByIri(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[Address(RVA = "0x2615950", Offset = "0x2614D50", Length = "0x35")]
	[Token(Token = "0x600042F")]
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

	[Address(RVA = "0x2615B00", Offset = "0x2614F00", Length = "0x17D")]
	[Token(Token = "0x6000425")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	[Address(RVA = "0x2615C80", Offset = "0x2615080", Length = "0xA6")]
	[Token(Token = "0x600042C")]
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	[Address(RVA = "0x2615D30", Offset = "0x2615130", Length = "0x462")]
	[Token(Token = "0x600042D")]
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

}

