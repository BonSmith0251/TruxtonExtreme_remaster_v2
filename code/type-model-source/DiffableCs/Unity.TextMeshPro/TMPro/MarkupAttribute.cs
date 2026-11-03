namespace TMPro;

[Token(Token = "0x20000B0")]
internal struct MarkupAttribute
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000662")]
	private int m_NameHashCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000663")]
	private int m_ValueHashCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000664")]
	private int m_ValueStartIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000665")]
	private int m_ValueLength; //Field offset: 0xC

	[Token(Token = "0x17000195")]
	public int NameHashCode
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60006AC")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60006AD")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000196")]
	public int ValueHashCode
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60006AE")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60006AF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000198")]
	public int ValueLength
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60006B2")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x60006B3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000197")]
	public int ValueStartIndex
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60006B0")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60006B1")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60006AC")]
	public int get_NameHashCode() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60006AE")]
	public int get_ValueHashCode() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x60006B2")]
	public int get_ValueLength() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60006B0")]
	public int get_ValueStartIndex() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60006AD")]
	public void set_NameHashCode(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60006AF")]
	public void set_ValueHashCode(int value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x60006B3")]
	public void set_ValueLength(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60006B1")]
	public void set_ValueStartIndex(int value) { }

}

