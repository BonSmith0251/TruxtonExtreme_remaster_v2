namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000121")]
internal sealed class UnsafePtrListDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004E0")]
	private UnsafePtrList<T> Data; //Field offset: 0x0

	[Token(Token = "0x1700016D")]
	public T*[] Items
	{
		[Address(RVA = "0x11DB640", Offset = "0x11DAA40", Length = "0xB1")]
		[Token(Token = "0x6000C2A")]
		 get { } //Length: 177
	}

	[Address(RVA = "0x11A7D10", Offset = "0x11A7110", Length = "0x33")]
	[Token(Token = "0x6000C29")]
	public UnsafePtrListDebugView`1(UnsafePtrList<T> data) { }

	[Address(RVA = "0x11DB640", Offset = "0x11DAA40", Length = "0xB1")]
	[Token(Token = "0x6000C2A")]
	public T*[] get_Items() { }

}

