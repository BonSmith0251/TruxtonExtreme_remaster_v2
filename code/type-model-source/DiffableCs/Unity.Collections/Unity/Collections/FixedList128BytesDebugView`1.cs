namespace Unity.Collections;

[Token(Token = "0x2000059")]
internal sealed class FixedList128BytesDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CA")]
	private FixedList128Bytes<T> m_List; //Field offset: 0x0

	[Token(Token = "0x17000066")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x6000300")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x1BC6F90", Offset = "0x1BC6390", Length = "0x64")]
	[Token(Token = "0x60002FF")]
	public FixedList128BytesDebugView`1(FixedList128Bytes<T> list) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x6000300")]
	public T[] get_Items() { }

}

