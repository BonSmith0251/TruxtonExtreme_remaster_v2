namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x2000099")]
internal sealed class ArraySliceDebugView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CE")]
	private ArraySlice<T> m_Slice; //Field offset: 0x0

	[Token(Token = "0x17000098")]
	public T[] Items
	{
		[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
		[Token(Token = "0x600038A")]
		 get { } //Length: 28
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000389")]
	public ArraySliceDebugView`1(ArraySlice<T> slice) { }

	[Address(RVA = "0xB49C50", Offset = "0xB49050", Length = "0x1C")]
	[Token(Token = "0x600038A")]
	public T[] get_Items() { }

}

