namespace System.Threading;

[DefaultMember("Item")]
[Token(Token = "0x2000213")]
internal class SparselyPopulatedArrayFragment
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C7")]
	internal readonly T[] _elements; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C8")]
	internal int _freeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009C9")]
	internal SparselyPopulatedArrayFragment<T> _next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009CA")]
	internal SparselyPopulatedArrayFragment<T> _prev; //Field offset: 0x0

	[Token(Token = "0x1700019F")]
	internal T Item
	{
		[Address(RVA = "0xFAB830", Offset = "0xFAAC30", Length = "0x35")]
		[Token(Token = "0x6001207")]
		internal get { } //Length: 53
	}

	[Token(Token = "0x170001A0")]
	internal int Length
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6001208")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170001A1")]
	internal SparselyPopulatedArrayFragment<T> Prev
	{
		[Address(RVA = "0xFAB870", Offset = "0xFAAC70", Length = "0x18")]
		[Token(Token = "0x6001209")]
		internal get { } //Length: 24
	}

	[Address(RVA = "0xFAB770", Offset = "0xFAAB70", Length = "0x16")]
	[Token(Token = "0x6001205")]
	internal SparselyPopulatedArrayFragment`1(int size) { }

	[Address(RVA = "0xFAB790", Offset = "0xFAAB90", Length = "0x91")]
	[Token(Token = "0x6001206")]
	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment<T> prev) { }

	[Address(RVA = "0xFAB830", Offset = "0xFAAC30", Length = "0x35")]
	[Token(Token = "0x6001207")]
	internal T get_Item(int index) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6001208")]
	internal int get_Length() { }

	[Address(RVA = "0xFAB870", Offset = "0xFAAC70", Length = "0x18")]
	[Token(Token = "0x6001209")]
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }

	[Address(RVA = "0xFAB6F0", Offset = "0xFAAAF0", Length = "0x77")]
	[Token(Token = "0x600120A")]
	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

