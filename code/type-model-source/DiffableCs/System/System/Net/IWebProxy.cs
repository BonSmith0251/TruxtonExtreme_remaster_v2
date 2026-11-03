namespace System.Net;

[Token(Token = "0x2000285")]
public interface IWebProxy
{

	[Token(Token = "0x17000397")]
	public ICredentials Credentials
	{
		[Token(Token = "0x6001106")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001106")]
	public ICredentials get_Credentials() { }

	[Token(Token = "0x6001104")]
	public Uri GetProxy(Uri destination) { }

	[Token(Token = "0x6001105")]
	public bool IsBypassed(Uri host) { }

}

