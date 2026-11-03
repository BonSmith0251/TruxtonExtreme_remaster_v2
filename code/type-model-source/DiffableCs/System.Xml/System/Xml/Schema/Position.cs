namespace System.Xml.Schema;

[Token(Token = "0x200015F")]
internal struct Position
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000759")]
	public int symbol; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400075A")]
	public object particle; //Field offset: 0x8

	[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
	[Token(Token = "0x6000F00")]
	public Position(int symbol, object particle) { }

}

