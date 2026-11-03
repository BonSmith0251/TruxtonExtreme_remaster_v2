namespace Mono.Net.Security;

[Token(Token = "0x2000052")]
internal class ChainValidationHelper : ICertificateValidator
{
	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CB")]
		public MonoTlsSettings settings; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000E0")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x22CE530", Offset = "0x22CD930", Length = "0x14D")]
		[Token(Token = "0x60000E1")]
		internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C4")]
	private readonly WeakReference<SslStream> owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C5")]
	private readonly MonoTlsSettings settings; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C6")]
	private readonly MobileTlsProvider provider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C7")]
	private readonly ServerCertValidationCallback certValidationCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C8")]
	private readonly LocalCertSelectionCallback certSelectionCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C9")]
	private readonly MonoTlsStream tlsStream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000CA")]
	private readonly HttpWebRequest request; //Field offset: 0x40

	[Token(Token = "0x17000022")]
	public override MonoTlsSettings Settings
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22BC4F0", Offset = "0x22BB8F0", Length = "0x412")]
	[Token(Token = "0x60000D7")]
	private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	[Address(RVA = "0x22BBAF0", Offset = "0x22BAEF0", Length = "0xAB")]
	[Token(Token = "0x60000D6")]
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	[Address(RVA = "0x22BBBA0", Offset = "0x22BAFA0", Length = "0x36")]
	[Token(Token = "0x60000D9")]
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000DA")]
	public override MonoTlsSettings get_Settings() { }

	[Address(RVA = "0x22BBBE0", Offset = "0x22BAFE0", Length = "0xE0")]
	[Token(Token = "0x60000D5")]
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	[Address(RVA = "0x22BBCD0", Offset = "0x22BB0D0", Length = "0xEC")]
	[Token(Token = "0x60000D8")]
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	[Address(RVA = "0x22BBDC0", Offset = "0x22BB1C0", Length = "0xB1")]
	[Token(Token = "0x60000DF")]
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }

	[Address(RVA = "0x22BBE80", Offset = "0x22BB280", Length = "0x5E")]
	[Token(Token = "0x60000DB")]
	public override bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, out X509Certificate clientCertificate) { }

	[Address(RVA = "0x22BBEE0", Offset = "0x22BB2E0", Length = "0x99")]
	[Token(Token = "0x60000DC")]
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	[Address(RVA = "0x22BBF80", Offset = "0x22BB380", Length = "0xD6")]
	[Token(Token = "0x60000DD")]
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	[Address(RVA = "0x22BC060", Offset = "0x22BB460", Length = "0x48A")]
	[Token(Token = "0x60000DE")]
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

