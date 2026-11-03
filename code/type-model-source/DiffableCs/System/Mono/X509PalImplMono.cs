namespace Mono;

[Token(Token = "0x2000005")]
internal class X509PalImplMono : X509PalImpl
{

	[Address(RVA = "0x22D2CC0", Offset = "0x22D20C0", Length = "0x49")]
	[Token(Token = "0x6000016")]
	public X509PalImplMono() { }

	[Address(RVA = "0x22D2CB0", Offset = "0x22D20B0", Length = "0x8")]
	[Token(Token = "0x6000013")]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[Address(RVA = "0x22D2CA0", Offset = "0x22D20A0", Length = "0xE")]
	[Token(Token = "0x6000014")]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000015")]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

