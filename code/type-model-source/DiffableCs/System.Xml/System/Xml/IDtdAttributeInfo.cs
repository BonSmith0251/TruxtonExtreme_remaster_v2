namespace System.Xml;

[Token(Token = "0x2000028")]
internal interface IDtdAttributeInfo
{

	[Token(Token = "0x17000020")]
	public bool IsDeclaredInExternal
	{
		[Token(Token = "0x6000143")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001F")]
	public bool IsNonCDataType
	{
		[Token(Token = "0x6000142")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000021")]
	public bool IsXmlAttribute
	{
		[Token(Token = "0x6000144")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001D")]
	public int LineNumber
	{
		[Token(Token = "0x6000140")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001E")]
	public int LinePosition
	{
		[Token(Token = "0x6000141")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001C")]
	public string LocalName
	{
		[Token(Token = "0x600013F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700001B")]
	public string Prefix
	{
		[Token(Token = "0x600013E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000143")]
	public bool get_IsDeclaredInExternal() { }

	[Token(Token = "0x6000142")]
	public bool get_IsNonCDataType() { }

	[Token(Token = "0x6000144")]
	public bool get_IsXmlAttribute() { }

	[Token(Token = "0x6000140")]
	public int get_LineNumber() { }

	[Token(Token = "0x6000141")]
	public int get_LinePosition() { }

	[Token(Token = "0x600013F")]
	public string get_LocalName() { }

	[Token(Token = "0x600013E")]
	public string get_Prefix() { }

}

