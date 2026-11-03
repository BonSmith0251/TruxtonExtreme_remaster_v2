namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[Token(Token = "0x20005F0")]
internal struct LayoutHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015C2")]
	public readonly int Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40015C3")]
	public readonly int Version; //Field offset: 0x4

	[Token(Token = "0x17000A9B")]
	public static LayoutHandle Undefined
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002AA1")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6002AA2")]
	internal LayoutHandle(int index, int version) { }

	[Address(RVA = "0x2FEFAC0", Offset = "0x2FEEEC0", Length = "0x12")]
	[Token(Token = "0x6002AA3")]
	public bool Equals(LayoutHandle other) { }

	[Address(RVA = "0x331E540", Offset = "0x331D940", Length = "0x8B")]
	[Token(Token = "0x6002AA4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002AA1")]
	public static LayoutHandle get_Undefined() { }

	[Address(RVA = "0x30C55D0", Offset = "0x30C49D0", Length = "0xC")]
	[Token(Token = "0x6002AA5")]
	public virtual int GetHashCode() { }

}

