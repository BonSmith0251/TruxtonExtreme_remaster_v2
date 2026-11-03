namespace System.Threading;

[Token(Token = "0x2000211")]
internal class SparselyPopulatedArray
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C3")]
	private readonly SparselyPopulatedArrayFragment<T> _head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C4")]
	private SparselyPopulatedArrayFragment<T> _tail; //Field offset: 0x0

	[Token(Token = "0x1700019C")]
	internal SparselyPopulatedArrayFragment<T> Tail
	{
		[Address(RVA = "0xFABBF0", Offset = "0xFAAFF0", Length = "0x18")]
		[Token(Token = "0x6001200")]
		internal get { } //Length: 24
	}

	[Address(RVA = "0xFABB40", Offset = "0xFAAF40", Length = "0xB0")]
	[Token(Token = "0x60011FF")]
	internal SparselyPopulatedArray`1(int initialSize) { }

	[Address(RVA = "0xFAB890", Offset = "0xFAAC90", Length = "0x2A1")]
	[Token(Token = "0x6001201")]
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }

	[Address(RVA = "0xFABBF0", Offset = "0xFAAFF0", Length = "0x18")]
	[Token(Token = "0x6001200")]
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }

}

