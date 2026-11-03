namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200011B")]
internal sealed class UnsafeListTDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D4")]
	private UnsafeList<T> Data; //Field offset: 0x0

	[Token(Token = "0x17000165")]
	public T[] Items
	{
		[Address(RVA = "0x11A7D50", Offset = "0x11A7150", Length = "0x18A")]
		[Token(Token = "0x6000BF3")]
		 get { } //Length: 394
	}

	[Address(RVA = "0x11A7D10", Offset = "0x11A7110", Length = "0x33")]
	[Token(Token = "0x6000BF2")]
	public UnsafeListTDebugView`1(UnsafeList<T> data) { }

	[Address(RVA = "0x11A7D50", Offset = "0x11A7150", Length = "0x18A")]
	[Token(Token = "0x6000BF3")]
	public T[] get_Items() { }

}

