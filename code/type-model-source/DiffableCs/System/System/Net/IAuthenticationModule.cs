namespace System.Net;

[Token(Token = "0x2000244")]
public interface IAuthenticationModule
{

	[Token(Token = "0x17000327")]
	public string AuthenticationType
	{
		[Token(Token = "0x6000F65")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F63")]
	public Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	[Token(Token = "0x6000F65")]
	public string get_AuthenticationType() { }

	[Token(Token = "0x6000F64")]
	public Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

}

