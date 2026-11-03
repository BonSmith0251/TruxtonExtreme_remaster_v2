namespace Unity.Collections;

[Token(Token = "0x200004A")]
internal struct ListPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	public Key key; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BA")]
	public Value value; //Field offset: 0x0

	[Address(RVA = "0xAEEBC0", Offset = "0xAEDFC0", Length = "0x1B4")]
	[Token(Token = "0x60001EA")]
	public ListPair`2(Key k, Value v) { }

	[Address(RVA = "0xB0C3C0", Offset = "0xB0B7C0", Length = "0x4C5")]
	[Token(Token = "0x60001EB")]
	public virtual string ToString() { }

}

