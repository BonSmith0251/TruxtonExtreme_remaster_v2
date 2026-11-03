namespace Unity.Collections;

[Token(Token = "0x20000C0")]
internal sealed class NativeRingQueueDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EB")]
	private UnsafeRingQueue<T>* Data; //Field offset: 0x0

	[Token(Token = "0x1700010B")]
	public T[] Items
	{
		[Address(RVA = "0xD92790", Offset = "0xD91B90", Length = "0x1AE")]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 430
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x60008FE")]
	public NativeRingQueueDebugView`1(NativeRingQueue<T> data) { }

	[Address(RVA = "0xD92790", Offset = "0xD91B90", Length = "0x1AE")]
	[Token(Token = "0x60008FF")]
	public T[] get_Items() { }

}

