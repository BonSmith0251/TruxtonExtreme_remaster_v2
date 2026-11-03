namespace UnityEngine.UIElements;

[Token(Token = "0x2000541")]
internal class PathRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400116F")]
	private PropertyPath m_Path; //Field offset: 0x10

	[Token(Token = "0x17000A11")]
	public bool IsEmpty
	{
		[Address(RVA = "0x32B9E50", Offset = "0x32B9250", Length = "0xB")]
		[Token(Token = "0x60026AE")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000A10")]
	public PropertyPath path
	{
		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60026AD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60026AF")]
	public PathRef() { }

	[Address(RVA = "0x32B9E50", Offset = "0x32B9250", Length = "0xB")]
	[Token(Token = "0x60026AE")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
	[Token(Token = "0x60026AD")]
	public PropertyPath get_path() { }

}

