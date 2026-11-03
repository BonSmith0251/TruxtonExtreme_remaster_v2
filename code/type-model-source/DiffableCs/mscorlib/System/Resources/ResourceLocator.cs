namespace System.Resources;

[Token(Token = "0x20004C4")]
internal struct ResourceLocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012D2")]
	internal object _value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40012D3")]
	internal int _dataPos; //Field offset: 0x8

	[Token(Token = "0x17000418")]
	internal int DataPosition
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60021CB")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000419")]
	internal object Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60021CC")]
		internal get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60021CD")]
		internal set { } //Length: 8
	}

	[Address(RVA = "0x1F2C5D0", Offset = "0x1F2B9D0", Length = "0xE")]
	[Token(Token = "0x60021CA")]
	internal ResourceLocator(int dataPos, object value) { }

	[Address(RVA = "0x1F3AB40", Offset = "0x1F39F40", Length = "0x7")]
	[Token(Token = "0x60021CE")]
	internal static bool CanCache(ResourceTypeCode value) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60021CB")]
	internal int get_DataPosition() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60021CC")]
	internal object get_Value() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60021CD")]
	internal void set_Value(object value) { }

}

