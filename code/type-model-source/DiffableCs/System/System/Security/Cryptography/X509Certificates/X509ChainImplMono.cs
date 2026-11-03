namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013A")]
internal class X509ChainImplMono : X509ChainImpl
{
	[Token(Token = "0x40005A4")]
	private static X509ChainStatus[] Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A0")]
	private StoreLocation location; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A1")]
	private X509ChainElementCollection elements; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A2")]
	private X509ChainPolicy policy; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A3")]
	private X509ChainStatus[] status; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005A5")]
	private int max_path_length; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005A6")]
	private X500DistinguishedName working_issuer_name; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005A7")]
	private AsymmetricAlgorithm working_public_key; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005A8")]
	private X509ChainElement bce_restriction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005A9")]
	private X509Certificate2Collection roots; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005AA")]
	private X509Certificate2Collection cas; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005AB")]
	private X509Store root_store; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005AC")]
	private X509Store ca_store; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005AD")]
	private X509Store user_root_store; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005AE")]
	private X509Store user_ca_store; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005AF")]
	private X509Certificate2Collection collection; //Field offset: 0x80

	[Token(Token = "0x17000164")]
	private X509Certificate2Collection CertificateAuthorities
	{
		[Address(RVA = "0x26562D0", Offset = "0x26556D0", Length = "0x1AB")]
		[Token(Token = "0x60007A8")]
		private get { } //Length: 427
	}

	[Token(Token = "0x17000169")]
	private X509Certificate2Collection CertificateCollection
	{
		[Address(RVA = "0x2656480", Offset = "0x2655880", Length = "0x233")]
		[Token(Token = "0x60007AD")]
		private get { } //Length: 563
	}

	[Token(Token = "0x17000161")]
	public virtual X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60007A2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000162")]
	public virtual X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60007A3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000160")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60007A1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000167")]
	private X509Store LMCAStore
	{
		[Address(RVA = "0x26566C0", Offset = "0x2655AC0", Length = "0x9E")]
		[Token(Token = "0x60007AB")]
		private get { } //Length: 158
	}

	[Token(Token = "0x17000165")]
	private X509Store LMRootStore
	{
		[Address(RVA = "0x2656760", Offset = "0x2655B60", Length = "0x9E")]
		[Token(Token = "0x60007A9")]
		private get { } //Length: 158
	}

	[Token(Token = "0x17000163")]
	private X509Certificate2Collection Roots
	{
		[Address(RVA = "0x2656800", Offset = "0x2655C00", Length = "0x1AB")]
		[Token(Token = "0x60007A7")]
		private get { } //Length: 427
	}

	[Token(Token = "0x17000168")]
	private X509Store UserCAStore
	{
		[Address(RVA = "0x26569B0", Offset = "0x2655DB0", Length = "0x9E")]
		[Token(Token = "0x60007AC")]
		private get { } //Length: 158
	}

	[Token(Token = "0x17000166")]
	private X509Store UserRootStore
	{
		[Address(RVA = "0x2656A50", Offset = "0x2655E50", Length = "0x9E")]
		[Token(Token = "0x60007AA")]
		private get { } //Length: 158
	}

	[Address(RVA = "0x2656060", Offset = "0x2655460", Length = "0x65")]
	[Token(Token = "0x60007C4")]
	private static X509ChainImplMono() { }

	[Address(RVA = "0x26560D0", Offset = "0x26554D0", Length = "0x1F3")]
	[Token(Token = "0x60007A0")]
	public X509ChainImplMono(bool useMachineContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007A4")]
	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[Address(RVA = "0x2653210", Offset = "0x2652610", Length = "0x759")]
	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	[Token(Token = "0x60007A5")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x2652E80", Offset = "0x2652280", Length = "0x38B")]
	[Token(Token = "0x60007AE")]
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	[Address(RVA = "0x2653970", Offset = "0x2652D70", Length = "0x232")]
	[Token(Token = "0x60007C0")]
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	[Address(RVA = "0x2654020", Offset = "0x2653420", Length = "0x13B")]
	[Token(Token = "0x60007BE")]
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	[Address(RVA = "0x2653E10", Offset = "0x2653210", Length = "0x205")]
	[Token(Token = "0x60007BF")]
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	[Address(RVA = "0x2653BB0", Offset = "0x2652FB0", Length = "0x25C")]
	[Token(Token = "0x60007BD")]
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	[Address(RVA = "0x2654160", Offset = "0x2653560", Length = "0x2E8")]
	[Token(Token = "0x60007C1")]
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	[Address(RVA = "0x2654450", Offset = "0x2653850", Length = "0x1A2")]
	[Token(Token = "0x60007B0")]
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	[Address(RVA = "0x26562D0", Offset = "0x26556D0", Length = "0x1AB")]
	[Token(Token = "0x60007A8")]
	private X509Certificate2Collection get_CertificateAuthorities() { }

	[Address(RVA = "0x2656480", Offset = "0x2655880", Length = "0x233")]
	[Token(Token = "0x60007AD")]
	private X509Certificate2Collection get_CertificateCollection() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60007A2")]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60007A3")]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60007A1")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x26566C0", Offset = "0x2655AC0", Length = "0x9E")]
	[Token(Token = "0x60007AB")]
	private X509Store get_LMCAStore() { }

	[Address(RVA = "0x2656760", Offset = "0x2655B60", Length = "0x9E")]
	[Token(Token = "0x60007A9")]
	private X509Store get_LMRootStore() { }

	[Address(RVA = "0x2656800", Offset = "0x2655C00", Length = "0x1AB")]
	[Token(Token = "0x60007A7")]
	private X509Certificate2Collection get_Roots() { }

	[Address(RVA = "0x26569B0", Offset = "0x2655DB0", Length = "0x9E")]
	[Token(Token = "0x60007AC")]
	private X509Store get_UserCAStore() { }

	[Address(RVA = "0x2656A50", Offset = "0x2655E50", Length = "0x9E")]
	[Token(Token = "0x60007AA")]
	private X509Store get_UserRootStore() { }

	[Address(RVA = "0x2654710", Offset = "0x2653B10", Length = "0x160")]
	[Token(Token = "0x60007BC")]
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	[Address(RVA = "0x2654690", Offset = "0x2653A90", Length = "0x7A")]
	[Token(Token = "0x60007BB")]
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	[Address(RVA = "0x2654600", Offset = "0x2653A00", Length = "0x87")]
	[Token(Token = "0x60007BA")]
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	[Address(RVA = "0x2654880", Offset = "0x2653C80", Length = "0x99")]
	[Token(Token = "0x60007B9")]
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	[Address(RVA = "0x2654920", Offset = "0x2653D20", Length = "0x14B")]
	[Token(Token = "0x60007B1")]
	private bool IsChainComplete(X509Certificate2 certificate) { }

	[Address(RVA = "0x2654A70", Offset = "0x2653E70", Length = "0x47")]
	[Token(Token = "0x60007B2")]
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	[Address(RVA = "0x2654AC0", Offset = "0x2653EC0", Length = "0x40")]
	[Token(Token = "0x60007B8")]
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	[Address(RVA = "0x2654B10", Offset = "0x2653F10", Length = "0x324")]
	[Token(Token = "0x60007B5")]
	private void PrepareForNextCertificate(int n) { }

	[Address(RVA = "0x26553D0", Offset = "0x26547D0", Length = "0x368")]
	[Token(Token = "0x60007B4")]
	private void Process(int n) { }

	[Address(RVA = "0x2654E40", Offset = "0x2654240", Length = "0x1A9")]
	[Token(Token = "0x60007B7")]
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	[Address(RVA = "0x2654FF0", Offset = "0x26543F0", Length = "0x1CE")]
	[Token(Token = "0x60007C3")]
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	[Address(RVA = "0x26551C0", Offset = "0x26545C0", Length = "0x205")]
	[Token(Token = "0x60007C2")]
	private bool ProcessCrlExtensions(X509Crl crl) { }

	[Address(RVA = "0x2655740", Offset = "0x2654B40", Length = "0x1DA")]
	[Token(Token = "0x60007A6")]
	public virtual void Reset() { }

	[Address(RVA = "0x2655920", Offset = "0x2654D20", Length = "0x32A")]
	[Token(Token = "0x60007AF")]
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	[Address(RVA = "0x2655C50", Offset = "0x2655050", Length = "0x296")]
	[Token(Token = "0x60007B3")]
	private void ValidateChain(X509ChainStatusFlags flag) { }

	[Address(RVA = "0x2655EF0", Offset = "0x26552F0", Length = "0x160")]
	[Token(Token = "0x60007B6")]
	private void WrapUp() { }

}

