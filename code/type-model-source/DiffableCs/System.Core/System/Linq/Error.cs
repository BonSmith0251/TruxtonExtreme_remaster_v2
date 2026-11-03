namespace System.Linq;

[Token(Token = "0x2000017")]
internal static class Error
{

	[Address(RVA = "0x2234170", Offset = "0x2233570", Length = "0x54")]
	[Token(Token = "0x6000053")]
	internal static Exception ArgumentNull(string s) { }

	[Address(RVA = "0x22341D0", Offset = "0x22335D0", Length = "0x54")]
	[Token(Token = "0x6000054")]
	internal static Exception ArgumentOutOfRange(string s) { }

	[Address(RVA = "0x2234230", Offset = "0x2233630", Length = "0x58")]
	[Token(Token = "0x6000055")]
	internal static Exception MoreThanOneElement() { }

	[Address(RVA = "0x2234290", Offset = "0x2233690", Length = "0x58")]
	[Token(Token = "0x6000056")]
	internal static Exception MoreThanOneMatch() { }

	[Address(RVA = "0x22342F0", Offset = "0x22336F0", Length = "0x58")]
	[Token(Token = "0x6000057")]
	internal static Exception NoElements() { }

	[Address(RVA = "0x2234350", Offset = "0x2233750", Length = "0x58")]
	[Token(Token = "0x6000058")]
	internal static Exception NoMatch() { }

	[Address(RVA = "0x22343B0", Offset = "0x22337B0", Length = "0x44")]
	[Token(Token = "0x6000059")]
	internal static Exception NotSupported() { }

}

