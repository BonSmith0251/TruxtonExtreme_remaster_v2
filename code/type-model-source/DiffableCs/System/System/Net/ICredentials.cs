namespace System.Net;

[Token(Token = "0x2000246")]
public interface ICredentials
{

	[Token(Token = "0x6000F67")]
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

