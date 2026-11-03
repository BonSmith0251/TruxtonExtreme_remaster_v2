namespace Mono.Http;

[Token(Token = "0x2000068")]
internal class NtlmSession
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012F")]
	private MessageBase message; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000178")]
	public NtlmSession() { }

	[Address(RVA = "0x22CA1D0", Offset = "0x22C95D0", Length = "0x4A7")]
	[Token(Token = "0x6000179")]
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

}

