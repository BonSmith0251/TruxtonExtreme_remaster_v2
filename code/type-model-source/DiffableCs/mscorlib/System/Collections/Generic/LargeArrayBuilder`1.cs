namespace System.Collections.Generic;

[Token(Token = "0x2000604")]
internal struct LargeArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001885")]
	private readonly int _maxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001886")]
	private T[] _first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001887")]
	private ArrayBuilder<T[]> _buffers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001888")]
	private T[] _current; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001889")]
	private int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400188A")]
	private int _count; //Field offset: 0x0

	[Address(RVA = "0xAF8310", Offset = "0xAF7710", Length = "0x3A")]
	[Token(Token = "0x6002CFD")]
	public LargeArrayBuilder`1(bool initialize) { }

	[Address(RVA = "0xAF8480", Offset = "0xAF7880", Length = "0xD0")]
	[Token(Token = "0x6002CFE")]
	public LargeArrayBuilder`1(int maxCapacity) { }

	[Address(RVA = "0xAF6E40", Offset = "0xAF6240", Length = "0x2BC")]
	[Token(Token = "0x6002CFF")]
	public void AddRange(IEnumerable<T> items) { }

	[Address(RVA = "0xAF7770", Offset = "0xAF6B70", Length = "0xB8")]
	[Token(Token = "0x6002D00")]
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }

	[Address(RVA = "0xAF7A50", Offset = "0xAF6E50", Length = "0x1D6")]
	[Token(Token = "0x6002D05")]
	private void AllocateBuffer() { }

	[Address(RVA = "0xAF7D60", Offset = "0xAF7160", Length = "0x152")]
	[Token(Token = "0x6002D01")]
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	[Address(RVA = "0xAF7FD0", Offset = "0xAF73D0", Length = "0x98")]
	[Token(Token = "0x6002D02")]
	public T[] GetBuffer(int index) { }

	[Address(RVA = "0xAF81B0", Offset = "0xAF75B0", Length = "0x115")]
	[Token(Token = "0x6002D03")]
	public T[] ToArray() { }

	[Address(RVA = "0xAF82D0", Offset = "0xAF76D0", Length = "0x38")]
	[Token(Token = "0x6002D04")]
	public bool TryMove(out T[] array) { }

}

