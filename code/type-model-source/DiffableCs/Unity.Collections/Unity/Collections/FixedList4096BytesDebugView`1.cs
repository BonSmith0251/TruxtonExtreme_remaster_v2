namespace Unity.Collections;

[Token(Token = "0x2000061")]
internal sealed class FixedList4096BytesDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D2")]
	private FixedList4096Bytes<T> m_List; //Field offset: 0x0

	[Token(Token = "0x1700007E")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x600039C")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x1BE3960", Offset = "0x1BE2D60", Length = "0x58")]
	[Token(Token = "0x600039B")]
	public FixedList4096BytesDebugView`1(FixedList4096Bytes<T> list) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x600039C")]
	public T[] get_Items() { }

}

