namespace Mono.Http;

[Token(Token = "0x2000069")]
internal class NtlmClient : IAuthenticationModule
{
	[CompilerGenerated]
	[Token(Token = "0x200006A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000131")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000132")]
		public static CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x22CE6E0", Offset = "0x22CDAE0", Length = "0x67")]
		[Token(Token = "0x600017F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000180")]
		public <>c() { }

		[Address(RVA = "0x22CE4B0", Offset = "0x22CD8B0", Length = "0x44")]
		[Token(Token = "0x6000181")]
		internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

	}

	[Token(Token = "0x4000130")]
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; //Field offset: 0x0

	[Token(Token = "0x17000056")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x22CA1A0", Offset = "0x22C95A0", Length = "0x2C")]
		[Token(Token = "0x600017C")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x22CA110", Offset = "0x22C9510", Length = "0x84")]
	[Token(Token = "0x600017E")]
	private static NtlmClient() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600017D")]
	public NtlmClient() { }

	[Address(RVA = "0x22C9D70", Offset = "0x22C9170", Length = "0x393")]
	[Token(Token = "0x600017A")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x22CA1A0", Offset = "0x22C95A0", Length = "0x2C")]
	[Token(Token = "0x600017C")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600017B")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

