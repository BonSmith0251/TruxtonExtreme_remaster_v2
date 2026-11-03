namespace System.Net;

[Token(Token = "0x200029A")]
internal class DigestClient : IAuthenticationModule
{
	[Token(Token = "0x4000A8D")]
	private static readonly Hashtable cache; //Field offset: 0x0

	[Token(Token = "0x170003AC")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x26BE390", Offset = "0x26BD790", Length = "0x2C")]
		[Token(Token = "0x6001160")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170003AB")]
	private static Hashtable Cache
	{
		[Address(RVA = "0x26BE3C0", Offset = "0x26BD7C0", Length = "0x16C")]
		[Token(Token = "0x600115C")]
		private get { } //Length: 364
	}

	[Address(RVA = "0x26BE310", Offset = "0x26BD710", Length = "0x7D")]
	[Token(Token = "0x6001162")]
	private static DigestClient() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001161")]
	public DigestClient() { }

	[Address(RVA = "0x26BD720", Offset = "0x26BCB20", Length = "0x348")]
	[Token(Token = "0x600115E")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x26BDA70", Offset = "0x26BCE70", Length = "0x6FC")]
	[Token(Token = "0x600115D")]
	private static void CheckExpired(int count) { }

	[Address(RVA = "0x26BE390", Offset = "0x26BD790", Length = "0x2C")]
	[Token(Token = "0x6001160")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x26BE3C0", Offset = "0x26BD7C0", Length = "0x16C")]
	[Token(Token = "0x600115C")]
	private static Hashtable get_Cache() { }

	[Address(RVA = "0x26BE170", Offset = "0x26BD570", Length = "0x19E")]
	[Token(Token = "0x600115F")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

