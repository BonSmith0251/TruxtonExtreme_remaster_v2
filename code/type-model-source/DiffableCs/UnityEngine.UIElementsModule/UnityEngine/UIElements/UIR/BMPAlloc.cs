namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005EB")]
internal struct BMPAlloc
{
	[Token(Token = "0x4001596")]
	public static readonly BMPAlloc Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001597")]
	public int page; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001598")]
	public ushort pageLine; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4001599")]
	public byte bitIndex; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400159A")]
	public OwnedState ownedState; //Field offset: 0x7

	[Address(RVA = "0x3317120", Offset = "0x3316520", Length = "0x4C")]
	[Token(Token = "0x6002A71")]
	private static BMPAlloc() { }

	[Address(RVA = "0x3317010", Offset = "0x3316410", Length = "0x1F")]
	[Token(Token = "0x6002A6E")]
	public bool Equals(BMPAlloc other) { }

	[Address(RVA = "0x3317030", Offset = "0x3316430", Length = "0xA")]
	[Token(Token = "0x6002A6F")]
	public bool IsValid() { }

	[Address(RVA = "0x3317040", Offset = "0x3316440", Length = "0xDB")]
	[Token(Token = "0x6002A70")]
	public virtual string ToString() { }

}

