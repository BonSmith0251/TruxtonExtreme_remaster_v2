namespace System.Xml;

[Token(Token = "0x20000B3")]
public interface IXmlLineInfo
{

	[Token(Token = "0x170002B7")]
	public int LineNumber
	{
		[Token(Token = "0x60009E3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002B8")]
	public int LinePosition
	{
		[Token(Token = "0x60009E4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60009E3")]
	public int get_LineNumber() { }

	[Token(Token = "0x60009E4")]
	public int get_LinePosition() { }

	[Token(Token = "0x60009E2")]
	public bool HasLineInfo() { }

}

