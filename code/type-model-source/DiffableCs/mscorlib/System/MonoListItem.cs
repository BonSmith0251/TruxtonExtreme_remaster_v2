namespace System;

[Token(Token = "0x20001BE")]
internal sealed class MonoListItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000714")]
	private MonoListItem next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000715")]
	private object data; //Field offset: 0x18

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FED")]
	public MonoListItem() { }

}

