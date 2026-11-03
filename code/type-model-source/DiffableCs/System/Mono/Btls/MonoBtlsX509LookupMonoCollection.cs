namespace Mono.Btls;

[Token(Token = "0x2000099")]
internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BF")]
	private Int64[] hashes; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C0")]
	private MonoBtlsX509[] certificates; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001C1")]
	private X509CertificateCollection collection; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001C2")]
	private MonoBtlsX509TrustKind trust; //Field offset: 0x60

	[Address(RVA = "0x2603BB0", Offset = "0x2602FB0", Length = "0x42")]
	[Token(Token = "0x60002B5")]
	internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	[Address(RVA = "0x2603670", Offset = "0x2602A70", Length = "0x151")]
	[Token(Token = "0x60002B8")]
	protected virtual void Close() { }

	[Address(RVA = "0x26037D0", Offset = "0x2602BD0", Length = "0x303")]
	[Token(Token = "0x60002B6")]
	private void Initialize() { }

	[Address(RVA = "0x2603AE0", Offset = "0x2602EE0", Length = "0xC6")]
	[Token(Token = "0x60002B7")]
	protected virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

}

