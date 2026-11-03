namespace System.Xml;

[Token(Token = "0x20000C2")]
internal static class ValidateNames
{
	[Token(Token = "0x400054C")]
	private static XmlCharType xmlCharType; //Field offset: 0x0

	[Address(RVA = "0x254D1F0", Offset = "0x254C5F0", Length = "0x51")]
	[Token(Token = "0x6000A71")]
	private static ValidateNames() { }

	[Address(RVA = "0x254C500", Offset = "0x254B900", Length = "0x267")]
	[Token(Token = "0x6000A6F")]
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	[Address(RVA = "0x254C770", Offset = "0x254BB70", Length = "0x69")]
	[Token(Token = "0x6000A69")]
	internal static bool IsNameNoNamespaces(string s) { }

	[Address(RVA = "0x254C950", Offset = "0x254BD50", Length = "0x142")]
	[Token(Token = "0x6000A68")]
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	[Address(RVA = "0x254C830", Offset = "0x254BC30", Length = "0x119")]
	[Token(Token = "0x6000A6A")]
	internal static int ParseNCName(string s, int offset) { }

	[Address(RVA = "0x254C7E0", Offset = "0x254BBE0", Length = "0x4C")]
	[Token(Token = "0x6000A6B")]
	internal static int ParseNCName(string s) { }

	[Address(RVA = "0x254CB70", Offset = "0x254BF70", Length = "0xB9")]
	[Token(Token = "0x6000A66")]
	internal static int ParseNmtoken(string s, int offset) { }

	[Address(RVA = "0x254CAA0", Offset = "0x254BEA0", Length = "0xCE")]
	[Token(Token = "0x6000A67")]
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	[Address(RVA = "0x254CDE0", Offset = "0x254C1E0", Length = "0xD2")]
	[Token(Token = "0x6000A6C")]
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	[Address(RVA = "0x254CC30", Offset = "0x254C030", Length = "0x1A3")]
	[Token(Token = "0x6000A6D")]
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	[Address(RVA = "0x254CEC0", Offset = "0x254C2C0", Length = "0x14A")]
	[Token(Token = "0x6000A70")]
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	[Address(RVA = "0x254D010", Offset = "0x254C410", Length = "0x1DB")]
	[Token(Token = "0x6000A6E")]
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

}

