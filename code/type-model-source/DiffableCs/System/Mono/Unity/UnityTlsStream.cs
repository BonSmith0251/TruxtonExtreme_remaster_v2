namespace Mono.Unity;

[Token(Token = "0x2000044")]
internal class UnityTlsStream : MobileAuthenticatedStream
{

	[Address(RVA = "0x22D22A0", Offset = "0x22D16A0", Length = "0x1C4")]
	[Token(Token = "0x600009F")]
	public UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[Address(RVA = "0x22D2230", Offset = "0x22D1630", Length = "0x64")]
	[Token(Token = "0x60000A0")]
	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

