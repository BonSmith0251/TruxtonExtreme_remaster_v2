namespace Unity.Collections;

[Token(Token = "0x200009E")]
internal sealed class NativeListDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C4")]
	private UnsafeList<T>* Data; //Field offset: 0x0

	[Token(Token = "0x170000D6")]
	public T[] Items
	{
		[Address(RVA = "0xD6DF50", Offset = "0xD6D350", Length = "0xE4")]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 228
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x60007C5")]
	public NativeListDebugView`1(NativeList<T> array) { }

	[Address(RVA = "0xD6DF50", Offset = "0xD6D350", Length = "0xE4")]
	[Token(Token = "0x60007C6")]
	public T[] get_Items() { }

}

