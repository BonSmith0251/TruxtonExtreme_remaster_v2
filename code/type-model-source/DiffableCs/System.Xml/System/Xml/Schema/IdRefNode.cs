namespace System.Xml.Schema;

[Token(Token = "0x200024F")]
internal class IdRefNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C11")]
	internal string Id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C12")]
	internal int LineNo; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C13")]
	internal int LinePos; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C14")]
	internal IdRefNode Next; //Field offset: 0x20

	[Address(RVA = "0x2491160", Offset = "0x2490560", Length = "0x65")]
	[Token(Token = "0x60016DF")]
	internal IdRefNode(IdRefNode next, string id, int lineNo, int linePos) { }

}

