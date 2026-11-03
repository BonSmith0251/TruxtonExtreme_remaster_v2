namespace System.Net;

[Token(Token = "0x200023F")]
public class CredentialCache
{

	[Token(Token = "0x17000324")]
	public static ICredentials DefaultCredentials
	{
		[Address(RVA = "0x269A700", Offset = "0x2699B00", Length = "0x4E")]
		[Token(Token = "0x6000F5B")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000325")]
	public static NetworkCredential DefaultNetworkCredentials
	{
		[Address(RVA = "0x269A750", Offset = "0x2699B50", Length = "0x4E")]
		[Token(Token = "0x6000F5C")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x269A700", Offset = "0x2699B00", Length = "0x4E")]
	[Token(Token = "0x6000F5B")]
	public static ICredentials get_DefaultCredentials() { }

	[Address(RVA = "0x269A750", Offset = "0x2699B50", Length = "0x4E")]
	[Token(Token = "0x6000F5C")]
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

