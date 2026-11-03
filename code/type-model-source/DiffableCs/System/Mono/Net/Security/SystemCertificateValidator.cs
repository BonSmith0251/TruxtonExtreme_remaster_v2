namespace Mono.Net.Security;

[Token(Token = "0x2000064")]
internal static class SystemCertificateValidator
{
	[Token(Token = "0x400012B")]
	private static bool is_macosx; //Field offset: 0x0
	[Token(Token = "0x400012C")]
	private static X509KeyUsageFlags s_flags; //Field offset: 0x4

	[Address(RVA = "0x22CB040", Offset = "0x22CA440", Length = "0x4B")]
	[Token(Token = "0x6000170")]
	private static SystemCertificateValidator() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000171")]
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

