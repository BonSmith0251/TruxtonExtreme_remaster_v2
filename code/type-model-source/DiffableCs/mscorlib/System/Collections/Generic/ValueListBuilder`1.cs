namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000601")]
internal struct ValueListBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001880")]
	private Span<T> _span; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001881")]
	private T[] _arrayFromPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001882")]
	private int _pos; //Field offset: 0x0

	[Token(Token = "0x17000726")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002CF1")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x120D460", Offset = "0x120C860", Length = "0x10")]
	[Token(Token = "0x6002CF0")]
	public ValueListBuilder`1(Span<T> initialSpan) { }

	[Address(RVA = "0x120C4B0", Offset = "0x120B8B0", Length = "0x8A")]
	[Token(Token = "0x6002CF2")]
	public void Append(T item) { }

	[Address(RVA = "0x120C860", Offset = "0x120BC60", Length = "0xD9")]
	[Token(Token = "0x6002CF3")]
	public ReadOnlySpan<T> AsSpan() { }

	[Address(RVA = "0x120CA30", Offset = "0x120BE30", Length = "0xBD")]
	[Token(Token = "0x6002CF4")]
	public void Dispose() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002CF1")]
	public int get_Length() { }

	[Address(RVA = "0x120CE00", Offset = "0x120C200", Length = "0x214")]
	[Token(Token = "0x6002CF5")]
	private void Grow() { }

}

