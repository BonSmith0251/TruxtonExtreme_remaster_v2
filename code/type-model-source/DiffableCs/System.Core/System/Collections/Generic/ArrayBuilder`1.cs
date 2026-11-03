namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x2000285")]
internal struct ArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000488")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000489")]
	private int _count; //Field offset: 0x0

	[Address(RVA = "0xB45040", Offset = "0xB44440", Length = "0x6D")]
	[Token(Token = "0x6000CB7")]
	public ArrayBuilder`1(int capacity) { }

	[Address(RVA = "0xB44AF0", Offset = "0xB43EF0", Length = "0x122")]
	[Token(Token = "0x6000CB8")]
	public T[] ToArray() { }

	[Address(RVA = "0xB44D20", Offset = "0xB44120", Length = "0x3E")]
	[Token(Token = "0x6000CB9")]
	public void UncheckedAdd(T item) { }

}

