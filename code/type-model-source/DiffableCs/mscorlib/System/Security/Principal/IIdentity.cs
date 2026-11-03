namespace System.Security.Principal;

[Token(Token = "0x2000339")]
public interface IIdentity
{

	[Token(Token = "0x170002AB")]
	public string AuthenticationType
	{
		[Token(Token = "0x6001A25")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AA")]
	public string Name
	{
		[Token(Token = "0x6001A24")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001A25")]
	public string get_AuthenticationType() { }

	[Token(Token = "0x6001A24")]
	public string get_Name() { }

}

