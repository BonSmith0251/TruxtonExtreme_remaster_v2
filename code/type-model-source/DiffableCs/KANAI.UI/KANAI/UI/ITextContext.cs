namespace KANAI.UI;

[Token(Token = "0x2000043")]
internal interface ITextContext
{

	[Token(Token = "0x17000036")]
	public string localizeKey
	{
		[Token(Token = "0x60001C9")]
		 get { } //Length: 0
		[Token(Token = "0x60001CA")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000035")]
	public string text
	{
		[Token(Token = "0x60001C7")]
		 get { } //Length: 0
		[Token(Token = "0x60001C8")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60001C9")]
	public string get_localizeKey() { }

	[Token(Token = "0x60001C7")]
	public string get_text() { }

	[Token(Token = "0x60001CA")]
	public void set_localizeKey(string value) { }

	[Token(Token = "0x60001C8")]
	public void set_text(string value) { }

}

