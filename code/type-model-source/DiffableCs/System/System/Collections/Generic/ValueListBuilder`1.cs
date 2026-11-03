namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001EB")]
internal struct ValueListBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073E")]
	private Span<T> _span; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073F")]
	private T[] _arrayFromPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000740")]
	private int _pos; //Field offset: 0x0

	[Token(Token = "0x1700026D")]
	public T Item
	{
		[Address(RVA = "0x120D470", Offset = "0x120C870", Length = "0x1D")]
		[Token(Token = "0x6000C72")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700026C")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C71")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x120D460", Offset = "0x120C860", Length = "0x10")]
	[Token(Token = "0x6000C70")]
	public ValueListBuilder`1(Span<T> initialSpan) { }

	[Address(RVA = "0x120C420", Offset = "0x120B820", Length = "0x8A")]
	[Token(Token = "0x6000C73")]
	public void Append(T item) { }

	[Address(RVA = "0x120C860", Offset = "0x120BC60", Length = "0xD9")]
	[Token(Token = "0x6000C74")]
	public ReadOnlySpan<T> AsSpan() { }

	[Address(RVA = "0x120CA30", Offset = "0x120BE30", Length = "0xBD")]
	[Token(Token = "0x6000C75")]
	public void Dispose() { }

	[Address(RVA = "0x120D470", Offset = "0x120C870", Length = "0x1D")]
	[Token(Token = "0x6000C72")]
	public T get_Item(int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C71")]
	public int get_Length() { }

	[Address(RVA = "0x120CE00", Offset = "0x120C200", Length = "0x214")]
	[Token(Token = "0x6000C76")]
	private void Grow() { }

	[Address(RVA = "0x120D330", Offset = "0x120C730", Length = "0x25")]
	[Token(Token = "0x6000C77")]
	public T Pop() { }

}

