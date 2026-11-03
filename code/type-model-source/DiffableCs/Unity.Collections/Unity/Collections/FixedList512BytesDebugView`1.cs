namespace Unity.Collections;

[Token(Token = "0x200005D")]
internal sealed class FixedList512BytesDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CE")]
	private FixedList512Bytes<T> m_List; //Field offset: 0x0

	[Token(Token = "0x17000072")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x600034E")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x1BF0DF0", Offset = "0x1BF01F0", Length = "0x7E")]
	[Token(Token = "0x600034D")]
	public FixedList512BytesDebugView`1(FixedList512Bytes<T> list) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x600034E")]
	public T[] get_Items() { }

}

