namespace Mono.Btls;

[Token(Token = "0x20000A7")]
internal class X509CertificateImplBtls : X509Certificate2ImplUnix
{
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001F5")]
	private MonoBtlsX509 x509; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001F6")]
	private MonoBtlsKey nativePrivateKey; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001F7")]
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xC0

	[Token(Token = "0x1700007B")]
	public virtual bool HasPrivateKey
	{
		[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
		[Token(Token = "0x6000315")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700007A")]
	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6000313")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000077")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2612BF0", Offset = "0x2611FF0", Length = "0x1B")]
		[Token(Token = "0x600030E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000079")]
	internal MonoBtlsKey NativePrivateKey
	{
		[Address(RVA = "0x2612C10", Offset = "0x2612010", Length = "0x1D")]
		[Token(Token = "0x6000310")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x1700007C")]
	public virtual AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x2611EC0", Offset = "0x26112C0", Length = "0x34")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 52
		[Address(RVA = "0x2612C50", Offset = "0x2612050", Length = "0xCE")]
		[Token(Token = "0x6000317")]
		 set { } //Length: 206
	}

	[Token(Token = "0x17000078")]
	internal MonoBtlsX509 X509
	{
		[Address(RVA = "0x2612C30", Offset = "0x2612030", Length = "0x1D")]
		[Token(Token = "0x600030F")]
		internal get { } //Length: 29
	}

	[Address(RVA = "0x26127D0", Offset = "0x2611BD0", Length = "0x4B")]
	[Token(Token = "0x600030A")]
	internal X509CertificateImplBtls(MonoBtlsX509 x509) { }

	[Address(RVA = "0x2612820", Offset = "0x2611C20", Length = "0xD5")]
	[Token(Token = "0x600030B")]
	private X509CertificateImplBtls(X509CertificateImplBtls other) { }

	[Address(RVA = "0x2612900", Offset = "0x2611D00", Length = "0x51")]
	[Token(Token = "0x600030C")]
	internal X509CertificateImplBtls(Byte[] data, MonoBtlsX509Format format) { }

	[Address(RVA = "0x2612960", Offset = "0x2611D60", Length = "0x280")]
	[Token(Token = "0x600030D")]
	internal X509CertificateImplBtls(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x2611D20", Offset = "0x2611120", Length = "0x10D")]
	[Token(Token = "0x6000311")]
	public virtual X509CertificateImpl Clone() { }

	[Address(RVA = "0x2611E30", Offset = "0x2611230", Length = "0x45")]
	[Token(Token = "0x6000314")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
	[Token(Token = "0x6000315")]
	public virtual bool get_HasPrivateKey() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6000313")]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[Address(RVA = "0x2612BF0", Offset = "0x2611FF0", Length = "0x1B")]
	[Token(Token = "0x600030E")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x2612C10", Offset = "0x2612010", Length = "0x1D")]
	[Token(Token = "0x6000310")]
	internal MonoBtlsKey get_NativePrivateKey() { }

	[Address(RVA = "0x2611EC0", Offset = "0x26112C0", Length = "0x34")]
	[Token(Token = "0x6000316")]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x2612C30", Offset = "0x2612030", Length = "0x1D")]
	[Token(Token = "0x600030F")]
	internal MonoBtlsX509 get_X509() { }

	[Address(RVA = "0x2611E80", Offset = "0x2611280", Length = "0x3E")]
	[Token(Token = "0x6000319")]
	public virtual DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x2611F00", Offset = "0x2611300", Length = "0x3D")]
	[Token(Token = "0x6000312")]
	protected virtual Byte[] GetRawCertData() { }

	[Address(RVA = "0x2611EC0", Offset = "0x26112C0", Length = "0x34")]
	[Token(Token = "0x6000318")]
	public virtual RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x2612480", Offset = "0x2611880", Length = "0x59")]
	[Token(Token = "0x600031A")]
	private void Import(Byte[] data) { }

	[Address(RVA = "0x2611F40", Offset = "0x2611340", Length = "0xD6")]
	[Token(Token = "0x600031C")]
	private void ImportAuthenticode(Byte[] data) { }

	[Address(RVA = "0x2612020", Offset = "0x2611420", Length = "0x452")]
	[Token(Token = "0x600031B")]
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	[Address(RVA = "0x2612C50", Offset = "0x2612050", Length = "0xCE")]
	[Token(Token = "0x6000317")]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Address(RVA = "0x26124E0", Offset = "0x26118E0", Length = "0x2E4")]
	[Token(Token = "0x600031D")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

