namespace Unity.Collections;

[Token(Token = "0x2000051")]
internal sealed class FixedList32BytesDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C2")]
	private FixedList32Bytes<T> m_List; //Field offset: 0x0

	[Token(Token = "0x1700004E")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x6000264")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000263")]
	public FixedList32BytesDebugView`1(FixedList32Bytes<T> list) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x6000264")]
	public T[] get_Items() { }

}

