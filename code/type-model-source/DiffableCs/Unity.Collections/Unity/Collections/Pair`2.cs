namespace Unity.Collections;

[Token(Token = "0x2000049")]
internal struct Pair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B7")]
	public Key key; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B8")]
	public Value value; //Field offset: 0x0

	[Address(RVA = "0xAEEBC0", Offset = "0xAEDFC0", Length = "0x1B4")]
	[Token(Token = "0x60001E8")]
	public Pair`2(Key k, Value v) { }

	[Address(RVA = "0xE12CA0", Offset = "0xE120A0", Length = "0x1D1")]
	[Token(Token = "0x60001E9")]
	public virtual string ToString() { }

}

