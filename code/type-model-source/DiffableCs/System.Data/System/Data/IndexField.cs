namespace System.Data;

[IsReadOnly]
[Token(Token = "0x2000087")]
internal struct IndexField
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A4")]
	public readonly DataColumn Column; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002A5")]
	public readonly bool IsDescending; //Field offset: 0x8

	[Address(RVA = "0xAEE570", Offset = "0xAED970", Length = "0x28")]
	[Token(Token = "0x60006E2")]
	internal IndexField(DataColumn column, bool isDescending) { }

	[Address(RVA = "0x23435A0", Offset = "0x23429A0", Length = "0xA0")]
	[Token(Token = "0x60006E4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2343650", Offset = "0x2342A50", Length = "0x5D")]
	[Token(Token = "0x60006E5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23436B0", Offset = "0x2342AB0", Length = "0x16")]
	[Token(Token = "0x60006E3")]
	public static bool op_Equality(IndexField if1, IndexField if2) { }

}

