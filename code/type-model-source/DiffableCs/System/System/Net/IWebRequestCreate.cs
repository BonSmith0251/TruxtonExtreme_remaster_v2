namespace System.Net;

[Token(Token = "0x2000248")]
public interface IWebRequestCreate
{

	[Token(Token = "0x6000F6E")]
	public WebRequest Create(Uri uri) { }

}

