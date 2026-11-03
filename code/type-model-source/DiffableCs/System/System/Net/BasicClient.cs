namespace System.Net;

[Token(Token = "0x2000290")]
internal class BasicClient : IAuthenticationModule
{

	[Token(Token = "0x1700039D")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x26B3990", Offset = "0x26B2D90", Length = "0x2C")]
		[Token(Token = "0x6001134")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001135")]
	public BasicClient() { }

	[Address(RVA = "0x26B3510", Offset = "0x26B2910", Length = "0xAD")]
	[Token(Token = "0x6001130")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x26B3990", Offset = "0x26B2D90", Length = "0x2C")]
	[Token(Token = "0x6001134")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x26B35C0", Offset = "0x26B29C0", Length = "0xA4")]
	[Token(Token = "0x6001131")]
	private static Byte[] GetBytes(string str) { }

	[Address(RVA = "0x26B3670", Offset = "0x26B2A70", Length = "0x2FB")]
	[Token(Token = "0x6001132")]
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x26B3970", Offset = "0x26B2D70", Length = "0x11")]
	[Token(Token = "0x6001133")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

