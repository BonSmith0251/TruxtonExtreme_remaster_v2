namespace Mono.Security.X509;

[DefaultMember("Item")]
[Token(Token = "0x200000F")]
public class X509Crl
{
	[Token(Token = "0x2000010")]
	internal class X509CrlEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000047")]
		private Byte[] sn; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000048")]
		private DateTime revocationDate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000049")]
		private X509ExtensionCollection extensions; //Field offset: 0x20

		[Token(Token = "0x17000028")]
		public X509ExtensionCollection Extensions
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x600008C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000027")]
		public DateTime RevocationDate
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600008B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000026")]
		public Byte[] SerialNumber
		{
			[Address(RVA = "0x1E42430", Offset = "0x1E41830", Length = "0x77")]
			[Token(Token = "0x600008A")]
			 get { } //Length: 119
		}

		[Address(RVA = "0x1E42320", Offset = "0x1E41720", Length = "0x102")]
		[Token(Token = "0x6000089")]
		internal X509CrlEntry(ASN1 entry) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600008C")]
		public X509ExtensionCollection get_Extensions() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600008B")]
		public DateTime get_RevocationDate() { }

		[Address(RVA = "0x1E42430", Offset = "0x1E41830", Length = "0x77")]
		[Token(Token = "0x600008A")]
		public Byte[] get_SerialNumber() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003D")]
	private string issuer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400003E")]
	private byte version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003F")]
	private DateTime thisUpdate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000040")]
	private DateTime nextUpdate; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000041")]
	private ArrayList entries; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000042")]
	private string signatureOID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000043")]
	private Byte[] signature; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000044")]
	private X509ExtensionCollection extensions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000045")]
	private Byte[] encoded; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000046")]
	private Byte[] hash_value; //Field offset: 0x58

	[Token(Token = "0x17000022")]
	public X509ExtensionCollection Extensions
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000023")]
	public Byte[] Hash
	{
		[Address(RVA = "0x1E43670", Offset = "0x1E42A70", Length = "0x180")]
		[Token(Token = "0x6000080")]
		 get { } //Length: 384
	}

	[Token(Token = "0x17000024")]
	public string IssuerName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000081")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000025")]
	public DateTime NextUpdate
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000082")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E43550", Offset = "0x1E42950", Length = "0x115")]
	[Token(Token = "0x600007D")]
	public X509Crl(Byte[] crl) { }

	[Address(RVA = "0x1E3EC60", Offset = "0x1E3E060", Length = "0x6B")]
	[Token(Token = "0x6000083")]
	private bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600007F")]
	public X509ExtensionCollection get_Extensions() { }

	[Address(RVA = "0x1E43670", Offset = "0x1E42A70", Length = "0x180")]
	[Token(Token = "0x6000080")]
	public Byte[] get_Hash() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000081")]
	public string get_IssuerName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000082")]
	public DateTime get_NextUpdate() { }

	[Address(RVA = "0x1E424B0", Offset = "0x1E418B0", Length = "0x82")]
	[Token(Token = "0x6000084")]
	public X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	[Address(RVA = "0x1E42540", Offset = "0x1E41940", Length = "0x212")]
	[Token(Token = "0x6000085")]
	public X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	[Address(RVA = "0x1E42760", Offset = "0x1E41B60", Length = "0x759")]
	[Token(Token = "0x600007E")]
	private void Parse(Byte[] crl) { }

	[Address(RVA = "0x1E43250", Offset = "0x1E42650", Length = "0x2F7")]
	[Token(Token = "0x6000086")]
	internal bool VerifySignature(DSA dsa) { }

	[Address(RVA = "0x1E43170", Offset = "0x1E42570", Length = "0xDB")]
	[Token(Token = "0x6000087")]
	internal bool VerifySignature(RSA rsa) { }

	[Address(RVA = "0x1E42EC0", Offset = "0x1E422C0", Length = "0x2AB")]
	[Token(Token = "0x6000088")]
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

}

