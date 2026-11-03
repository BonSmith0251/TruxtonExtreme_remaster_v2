namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200013D")]
internal sealed class UnsafeRingQueueDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400051D")]
	private UnsafeRingQueue<T> Data; //Field offset: 0x0

	[Token(Token = "0x17000199")]
	public T[] Items
	{
		[Address(RVA = "0x11DF7C0", Offset = "0x11DEBC0", Length = "0x1A1")]
		[Token(Token = "0x6000D7B")]
		 get { } //Length: 417
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000D7A")]
	public UnsafeRingQueueDebugView`1(UnsafeRingQueue<T> data) { }

	[Address(RVA = "0x11DF7C0", Offset = "0x11DEBC0", Length = "0x1A1")]
	[Token(Token = "0x6000D7B")]
	public T[] get_Items() { }

}

