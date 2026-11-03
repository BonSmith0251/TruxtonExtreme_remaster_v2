namespace Unity.Collections;

[Token(Token = "0x2000043")]
internal struct Long1024 : IIndexable<Int64>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A1")]
	internal Long512 f0; //Field offset: 0x0
	[FieldOffset(Offset = "0x1000")]
	[Token(Token = "0x40000A2")]
	internal Long512 f1; //Field offset: 0x1000

	[Token(Token = "0x1700002C")]
	public override int Length
	{
		[Address(RVA = "0x9E1950", Offset = "0x9E0D50", Length = "0x6")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 6
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600015C")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x28C46C0", Offset = "0x28C3AC0", Length = "0x3B")]
	[Token(Token = "0x600015D")]
	public override long ElementAt(int index) { }

	[Address(RVA = "0x9E1950", Offset = "0x9E0D50", Length = "0x6")]
	[Token(Token = "0x600015B")]
	public override int get_Length() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015C")]
	public override void set_Length(int value) { }

}

