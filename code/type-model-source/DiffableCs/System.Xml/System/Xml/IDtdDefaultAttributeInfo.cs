namespace System.Xml;

[Token(Token = "0x2000029")]
internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
{

	[Token(Token = "0x17000022")]
	public string DefaultValueExpanded
	{
		[Token(Token = "0x6000145")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000023")]
	public object DefaultValueTyped
	{
		[Token(Token = "0x6000146")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000024")]
	public int ValueLineNumber
	{
		[Token(Token = "0x6000147")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000025")]
	public int ValueLinePosition
	{
		[Token(Token = "0x6000148")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000145")]
	public string get_DefaultValueExpanded() { }

	[Token(Token = "0x6000146")]
	public object get_DefaultValueTyped() { }

	[Token(Token = "0x6000147")]
	public int get_ValueLineNumber() { }

	[Token(Token = "0x6000148")]
	public int get_ValueLinePosition() { }

}

