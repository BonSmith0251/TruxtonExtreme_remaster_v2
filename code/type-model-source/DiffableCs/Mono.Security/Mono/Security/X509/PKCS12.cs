namespace Mono.Security.X509;

[Token(Token = "0x200000C")]
public class PKCS12 : ICloneable
{
	[Token(Token = "0x200000D")]
	internal class DeriveBytes
	{
		[Token(Token = "0x4000026")]
		private static Byte[] keyDiversifier; //Field offset: 0x0
		[Token(Token = "0x4000027")]
		private static Byte[] ivDiversifier; //Field offset: 0x8
		[Token(Token = "0x4000028")]
		private static Byte[] macDiversifier; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000029")]
		private string _hashName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002A")]
		private int _iterations; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400002B")]
		private Byte[] _password; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002C")]
		private Byte[] _salt; //Field offset: 0x28

		[Token(Token = "0x1700001E")]
		public string HashName
		{
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[Token(Token = "0x6000066")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700001F")]
		public int IterationCount
		{
			[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
			[Token(Token = "0x6000067")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000020")]
		public Byte[] Password
		{
			[Address(RVA = "0x1E31960", Offset = "0x1E30D60", Length = "0xD7")]
			[Token(Token = "0x6000068")]
			 set { } //Length: 215
		}

		[Token(Token = "0x17000021")]
		public Byte[] Salt
		{
			[Address(RVA = "0x1E31A40", Offset = "0x1E30E40", Length = "0xC8")]
			[Token(Token = "0x6000069")]
			 set { } //Length: 200
		}

		[Address(RVA = "0x1E31810", Offset = "0x1E30C10", Length = "0x148")]
		[Token(Token = "0x600006F")]
		private static DeriveBytes() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000065")]
		public DeriveBytes() { }

		[Address(RVA = "0x1E31150", Offset = "0x1E30550", Length = "0xF2")]
		[Token(Token = "0x600006A")]
		private void Adjust(Byte[] a, int aOff, Byte[] b) { }

		[Address(RVA = "0x1E313A0", Offset = "0x1E307A0", Length = "0x464")]
		[Token(Token = "0x600006B")]
		private Byte[] Derive(Byte[] diversifier, int n) { }

		[Address(RVA = "0x1E31250", Offset = "0x1E30650", Length = "0x6D")]
		[Token(Token = "0x600006D")]
		public Byte[] DeriveIV(int size) { }

		[Address(RVA = "0x1E312C0", Offset = "0x1E306C0", Length = "0x6C")]
		[Token(Token = "0x600006C")]
		public Byte[] DeriveKey(int size) { }

		[Address(RVA = "0x1E31330", Offset = "0x1E30730", Length = "0x6D")]
		[Token(Token = "0x600006E")]
		public Byte[] DeriveMAC(int size) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000066")]
		public void set_HashName(string value) { }

		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000067")]
		public void set_IterationCount(int value) { }

		[Address(RVA = "0x1E31960", Offset = "0x1E30D60", Length = "0xD7")]
		[Token(Token = "0x6000068")]
		public void set_Password(Byte[] value) { }

		[Address(RVA = "0x1E31A40", Offset = "0x1E30E40", Length = "0xC8")]
		[Token(Token = "0x6000069")]
		public void set_Salt(Byte[] value) { }

	}

	[Token(Token = "0x4000025")]
	private static int password_max_length; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private Byte[] _password; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001C")]
	private ArrayList _keyBags; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001D")]
	private ArrayList _secretBags; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001E")]
	private X509CertificateCollection _certs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001F")]
	private bool _keyBagsChanged; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000020")]
	private bool _secretBagsChanged; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000021")]
	private bool _certsChanged; //Field offset: 0x32
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000022")]
	private int _iterations; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000023")]
	private ArrayList _safeBags; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000024")]
	private RandomNumberGenerator _rng; //Field offset: 0x40

	[Token(Token = "0x1700001B")]
	public X509CertificateCollection Certificates
	{
		[Address(RVA = "0x1E39EC0", Offset = "0x1E392C0", Length = "0x3E0")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 992
	}

	[Token(Token = "0x17000019")]
	public int IterationCount
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x600004B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public ArrayList Keys
	{
		[Address(RVA = "0x1E3A2B0", Offset = "0x1E396B0", Length = "0x5F2")]
		[Token(Token = "0x600004C")]
		 get { } //Length: 1522
	}

	[Token(Token = "0x1700001D")]
	public static int MaximumPasswordLength
	{
		[Address(RVA = "0x1E3A8B0", Offset = "0x1E39CB0", Length = "0x4D")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000018")]
	public string Password
	{
		[Address(RVA = "0x1E3A940", Offset = "0x1E39D40", Length = "0x1BD")]
		[Token(Token = "0x6000049")]
		 set { } //Length: 445
	}

	[Token(Token = "0x1700001C")]
	internal RandomNumberGenerator RNG
	{
		[Address(RVA = "0x1E3A900", Offset = "0x1E39D00", Length = "0x3B")]
		[Token(Token = "0x600004E")]
		internal get { } //Length: 59
	}

	[Address(RVA = "0x1E39CA0", Offset = "0x1E390A0", Length = "0x39")]
	[Token(Token = "0x6000064")]
	private static PKCS12() { }

	[Address(RVA = "0x1E39CE0", Offset = "0x1E390E0", Length = "0x4A")]
	[Token(Token = "0x6000046")]
	public PKCS12(Byte[] data, string password) { }

	[Address(RVA = "0x1E39DC0", Offset = "0x1E391C0", Length = "0xFE")]
	[Token(Token = "0x6000044")]
	public PKCS12() { }

	[Address(RVA = "0x1E39D30", Offset = "0x1E39130", Length = "0x87")]
	[Token(Token = "0x6000045")]
	public PKCS12(Byte[] data) { }

	[Address(RVA = "0x1E32330", Offset = "0x1E31730", Length = "0x2F6")]
	[Token(Token = "0x600005D")]
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	[Address(RVA = "0x1E32320", Offset = "0x1E31720", Length = "0xB")]
	[Token(Token = "0x600005C")]
	public void AddCertificate(X509Certificate cert) { }

	[Address(RVA = "0x1E32630", Offset = "0x1E31A30", Length = "0x3E4")]
	[Token(Token = "0x6000061")]
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	[Address(RVA = "0x1E32A20", Offset = "0x1E31E20", Length = "0x29D")]
	[Token(Token = "0x6000055")]
	private void AddPrivateKey(PrivateKeyInfo pki) { }

	[Address(RVA = "0x1E32CC0", Offset = "0x1E320C0", Length = "0xAAF")]
	[Token(Token = "0x6000058")]
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	[Address(RVA = "0x1E33770", Offset = "0x1E32B70", Length = "0x148")]
	[Token(Token = "0x6000062")]
	public override object Clone() { }

	[Address(RVA = "0x1E33980", Offset = "0x1E32D80", Length = "0x7B")]
	[Token(Token = "0x600004F")]
	private bool Compare(Byte[] expected, Byte[] actual) { }

	[Address(RVA = "0x1E338C0", Offset = "0x1E32CC0", Length = "0xBE")]
	[Token(Token = "0x6000060")]
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	[Address(RVA = "0x1E33A00", Offset = "0x1E32E00", Length = "0x9BA")]
	[Token(Token = "0x6000047")]
	private void Decode(Byte[] data) { }

	[Address(RVA = "0x1E34500", Offset = "0x1E33900", Length = "0x13C")]
	[Token(Token = "0x6000051")]
	public Byte[] Decrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] encryptedData) { }

	[Address(RVA = "0x1E343C0", Offset = "0x1E337C0", Length = "0x131")]
	[Token(Token = "0x6000052")]
	public Byte[] Decrypt(EncryptedData ed) { }

	[Address(RVA = "0x1E34640", Offset = "0x1E33A40", Length = "0x15C")]
	[Token(Token = "0x6000053")]
	public Byte[] Encrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] data) { }

	[Address(RVA = "0x1E347A0", Offset = "0x1E33BA0", Length = "0x8DA")]
	[Token(Token = "0x600005B")]
	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	[Address(RVA = "0x1E35080", Offset = "0x1E34480", Length = "0x8A")]
	[Token(Token = "0x6000048")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E39EC0", Offset = "0x1E392C0", Length = "0x3E0")]
	[Token(Token = "0x600004D")]
	public X509CertificateCollection get_Certificates() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600004A")]
	public int get_IterationCount() { }

	[Address(RVA = "0x1E3A2B0", Offset = "0x1E396B0", Length = "0x5F2")]
	[Token(Token = "0x600004C")]
	public ArrayList get_Keys() { }

	[Address(RVA = "0x1E3A8B0", Offset = "0x1E39CB0", Length = "0x4D")]
	[Token(Token = "0x6000063")]
	public static int get_MaximumPasswordLength() { }

	[Address(RVA = "0x1E3A900", Offset = "0x1E39D00", Length = "0x3B")]
	[Token(Token = "0x600004E")]
	internal RandomNumberGenerator get_RNG() { }

	[Address(RVA = "0x1E35110", Offset = "0x1E34510", Length = "0x264E")]
	[Token(Token = "0x600005A")]
	public Byte[] GetBytes() { }

	[Address(RVA = "0x1E37760", Offset = "0x1E36B60", Length = "0x2C3")]
	[Token(Token = "0x6000054")]
	private DSAParameters GetExistingParameters(out bool found) { }

	[Address(RVA = "0x1E37A30", Offset = "0x1E36E30", Length = "0x636")]
	[Token(Token = "0x6000050")]
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Byte[] salt, int iterationCount) { }

	[Address(RVA = "0x1E38070", Offset = "0x1E37470", Length = "0x1A5")]
	[Token(Token = "0x6000059")]
	private Byte[] MAC(Byte[] password, Byte[] salt, int iterations, Byte[] data) { }

	[Address(RVA = "0x1E38220", Offset = "0x1E37620", Length = "0xB1D")]
	[Token(Token = "0x6000057")]
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	[Address(RVA = "0x1E38D40", Offset = "0x1E38140", Length = "0x901")]
	[Token(Token = "0x6000056")]
	private void ReadSafeBag(ASN1 safeBag) { }

	[Address(RVA = "0x1E39C90", Offset = "0x1E39090", Length = "0xB")]
	[Token(Token = "0x600005E")]
	public void RemoveCertificate(X509Certificate cert) { }

	[Address(RVA = "0x1E39650", Offset = "0x1E38A50", Length = "0x638")]
	[Token(Token = "0x600005F")]
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x600004B")]
	public void set_IterationCount(int value) { }

	[Address(RVA = "0x1E3A940", Offset = "0x1E39D40", Length = "0x1BD")]
	[Token(Token = "0x6000049")]
	public void set_Password(string value) { }

}

