namespace Mono.Btls;

[Token(Token = "0x20000A9")]
internal class X509PalImplBtls : X509PalImpl
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000200")]
	private readonly MonoBtlsProvider <Provider>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000081")]
	private MonoBtlsProvider Provider
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000329")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x2613B30", Offset = "0x2612F30", Length = "0x340")]
	[Token(Token = "0x6000328")]
	public X509PalImplBtls(MonoTlsProvider provider) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000329")]
	private MonoBtlsProvider get_Provider() { }

	[Address(RVA = "0x2613B00", Offset = "0x2612F00", Length = "0x2B")]
	[Token(Token = "0x600032A")]
	public virtual X509CertificateImpl Import(Byte[] data) { }

	[Address(RVA = "0x2613AB0", Offset = "0x2612EB0", Length = "0x24")]
	[Token(Token = "0x600032B")]
	public virtual X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x2613AE0", Offset = "0x2612EE0", Length = "0x1E")]
	[Token(Token = "0x600032C")]
	public virtual X509Certificate2Impl Import(X509Certificate cert) { }

}

