namespace Mono.Btls;

[Token(Token = "0x200008B")]
internal class MonoBtlsStream : MobileAuthenticatedStream
{

	[Address(RVA = "0x2602490", Offset = "0x2601890", Length = "0x84")]
	[Token(Token = "0x6000270")]
	public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[Address(RVA = "0x2602420", Offset = "0x2601820", Length = "0x64")]
	[Token(Token = "0x6000271")]
	protected virtual MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

