namespace System.Net;

[Token(Token = "0x20002B0")]
internal class NtlmClient : IAuthenticationModule
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B38")]
	private IAuthenticationModule authObject; //Field offset: 0x10

	[Token(Token = "0x170003E0")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x25C93E0", Offset = "0x25C87E0", Length = "0x2C")]
		[Token(Token = "0x6001211")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25C9370", Offset = "0x25C8770", Length = "0x66")]
	[Token(Token = "0x600120E")]
	public NtlmClient() { }

	[Address(RVA = "0x25C9290", Offset = "0x25C8690", Length = "0xE0")]
	[Token(Token = "0x600120F")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x25C93E0", Offset = "0x25C87E0", Length = "0x2C")]
	[Token(Token = "0x6001211")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001210")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

