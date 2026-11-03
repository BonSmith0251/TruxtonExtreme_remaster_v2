namespace System.Threading;

[Token(Token = "0x2000212")]
internal struct SparselyPopulatedArrayAddInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C5")]
	private SparselyPopulatedArrayFragment<T> _source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C6")]
	private int _index; //Field offset: 0x0

	[Token(Token = "0x1700019E")]
	internal int Index
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001204")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700019D")]
	internal SparselyPopulatedArrayFragment<T> Source
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6001203")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
	[Token(Token = "0x6001202")]
	internal SparselyPopulatedArrayAddInfo`1(SparselyPopulatedArrayFragment<T> source, int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6001204")]
	internal int get_Index() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6001203")]
	internal SparselyPopulatedArrayFragment<T> get_Source() { }

}

