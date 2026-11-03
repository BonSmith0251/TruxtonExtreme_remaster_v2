namespace System.Net;

[Token(Token = "0x2000262")]
internal class HeaderInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009B1")]
	internal readonly bool IsRequestRestricted; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40009B2")]
	internal readonly bool IsResponseRestricted; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009B3")]
	internal readonly HeaderParser Parser; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B4")]
	internal readonly string HeaderName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009B5")]
	internal readonly bool AllowMultiValues; //Field offset: 0x28

	[Address(RVA = "0x26C7420", Offset = "0x26C6820", Length = "0x70")]
	[Token(Token = "0x6001013")]
	internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

