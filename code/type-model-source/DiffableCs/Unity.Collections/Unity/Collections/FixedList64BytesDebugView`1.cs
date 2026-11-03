namespace Unity.Collections;

[Token(Token = "0x2000055")]
internal sealed class FixedList64BytesDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C6")]
	private FixedList64Bytes<T> m_List; //Field offset: 0x0

	[Token(Token = "0x1700005A")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x60002B2")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x11A5B80", Offset = "0x11A4F80", Length = "0x41")]
	[Token(Token = "0x60002B1")]
	public FixedList64BytesDebugView`1(FixedList64Bytes<T> list) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x60002B2")]
	public T[] get_Items() { }

}

