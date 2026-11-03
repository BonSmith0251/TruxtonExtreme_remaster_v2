namespace TMPro;

[Token(Token = "0x20000B1")]
internal struct MarkupElement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000666")]
	private MarkupAttribute[] m_Attributes; //Field offset: 0x0

	[Token(Token = "0x1700019D")]
	public MarkupAttribute[] Attributes
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60006BD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000199")]
	public int NameHashCode
	{
		[Address(RVA = "0x2F193E0", Offset = "0x2F187E0", Length = "0x27")]
		[Token(Token = "0x60006B4")]
		 get { } //Length: 39
		[Address(RVA = "0x2F194A0", Offset = "0x2F188A0", Length = "0x77")]
		[Token(Token = "0x60006B5")]
		 set { } //Length: 119
	}

	[Token(Token = "0x1700019A")]
	public int ValueHashCode
	{
		[Address(RVA = "0x2F19410", Offset = "0x2F18810", Length = "0x27")]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 39
		[Address(RVA = "0x2F19520", Offset = "0x2F18920", Length = "0x25")]
		[Token(Token = "0x60006B7")]
		 set { } //Length: 37
	}

	[Token(Token = "0x1700019C")]
	public int ValueLength
	{
		[Address(RVA = "0x2F19440", Offset = "0x2F18840", Length = "0x27")]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 39
		[Address(RVA = "0x2F19550", Offset = "0x2F18950", Length = "0x25")]
		[Token(Token = "0x60006BB")]
		 set { } //Length: 37
	}

	[Token(Token = "0x1700019B")]
	public int ValueStartIndex
	{
		[Address(RVA = "0x2F19470", Offset = "0x2F18870", Length = "0x27")]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 39
		[Address(RVA = "0x2F19580", Offset = "0x2F18980", Length = "0x25")]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x2F19330", Offset = "0x2F18730", Length = "0xAD")]
	[Token(Token = "0x60006BE")]
	public MarkupElement(int nameHashCode, int startIndex, int length) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60006BC")]
	public MarkupAttribute[] get_Attributes() { }

	[Address(RVA = "0x2F193E0", Offset = "0x2F187E0", Length = "0x27")]
	[Token(Token = "0x60006B4")]
	public int get_NameHashCode() { }

	[Address(RVA = "0x2F19410", Offset = "0x2F18810", Length = "0x27")]
	[Token(Token = "0x60006B6")]
	public int get_ValueHashCode() { }

	[Address(RVA = "0x2F19440", Offset = "0x2F18840", Length = "0x27")]
	[Token(Token = "0x60006BA")]
	public int get_ValueLength() { }

	[Address(RVA = "0x2F19470", Offset = "0x2F18870", Length = "0x27")]
	[Token(Token = "0x60006B8")]
	public int get_ValueStartIndex() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60006BD")]
	public void set_Attributes(MarkupAttribute[] value) { }

	[Address(RVA = "0x2F194A0", Offset = "0x2F188A0", Length = "0x77")]
	[Token(Token = "0x60006B5")]
	public void set_NameHashCode(int value) { }

	[Address(RVA = "0x2F19520", Offset = "0x2F18920", Length = "0x25")]
	[Token(Token = "0x60006B7")]
	public void set_ValueHashCode(int value) { }

	[Address(RVA = "0x2F19550", Offset = "0x2F18950", Length = "0x25")]
	[Token(Token = "0x60006BB")]
	public void set_ValueLength(int value) { }

	[Address(RVA = "0x2F19580", Offset = "0x2F18980", Length = "0x25")]
	[Token(Token = "0x60006B9")]
	public void set_ValueStartIndex(int value) { }

}

