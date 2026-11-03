namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012C")]
public class X509Certificate2 : X509Certificate
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000587")]
	private Byte[] lazyRawData; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000588")]
	private Oid lazySignatureAlgorithm; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000589")]
	private int lazyVersion; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400058A")]
	private X500DistinguishedName lazySubjectName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400058B")]
	private X500DistinguishedName lazyIssuerName; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400058C")]
	private PublicKey lazyPublicKey; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400058D")]
	private AsymmetricAlgorithm lazyPrivateKey; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400058E")]
	private X509ExtensionCollection lazyExtensions; //Field offset: 0x98

	[Token(Token = "0x1700011F")]
	public X509ExtensionCollection Extensions
	{
		[Address(RVA = "0x264FF70", Offset = "0x264F370", Length = "0x349")]
		[Token(Token = "0x6000701")]
		 get { } //Length: 841
	}

	[Token(Token = "0x17000120")]
	public bool HasPrivateKey
	{
		[Address(RVA = "0x26502C0", Offset = "0x264F6C0", Length = "0x40")]
		[Token(Token = "0x6000702")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700012C")]
	internal X509Certificate2Impl Impl
	{
		[Address(RVA = "0x2650310", Offset = "0x264F710", Length = "0x7C")]
		[Token(Token = "0x6000714")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x17000122")]
	public X500DistinguishedName IssuerName
	{
		[Address(RVA = "0x2650390", Offset = "0x264F790", Length = "0x7B")]
		[Token(Token = "0x6000704")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000123")]
	public DateTime NotAfter
	{
		[Address(RVA = "0x2650410", Offset = "0x264F810", Length = "0x7")]
		[Token(Token = "0x6000705")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000124")]
	public DateTime NotBefore
	{
		[Address(RVA = "0x2650420", Offset = "0x264F820", Length = "0x7")]
		[Token(Token = "0x6000706")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000121")]
	public AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x2650430", Offset = "0x264F830", Length = "0x1B1")]
		[Token(Token = "0x6000703")]
		 get { } //Length: 433
	}

	[Token(Token = "0x17000125")]
	public PublicKey PublicKey
	{
		[Address(RVA = "0x26505F0", Offset = "0x264F9F0", Length = "0x31B")]
		[Token(Token = "0x6000707")]
		 get { } //Length: 795
	}

	[Token(Token = "0x17000126")]
	public Byte[] RawData
	{
		[Address(RVA = "0x2650910", Offset = "0x264FD10", Length = "0x79")]
		[Token(Token = "0x6000708")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000127")]
	public string SerialNumber
	{
		[Address(RVA = "0x2650990", Offset = "0x264FD90", Length = "0x14")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000128")]
	public Oid SignatureAlgorithm
	{
		[Address(RVA = "0x26509B0", Offset = "0x264FDB0", Length = "0x82")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 130
	}

	[Token(Token = "0x17000129")]
	public X500DistinguishedName SubjectName
	{
		[Address(RVA = "0x2650A40", Offset = "0x264FE40", Length = "0x72")]
		[Token(Token = "0x600070B")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700012A")]
	public string Thumbprint
	{
		[Address(RVA = "0x2650AC0", Offset = "0x264FEC0", Length = "0x25")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 37
	}

	[Token(Token = "0x1700012B")]
	public int Version
	{
		[Address(RVA = "0x2650AF0", Offset = "0x264FEF0", Length = "0x61")]
		[Token(Token = "0x600070D")]
		 get { } //Length: 97
	}

	[Address(RVA = "0x264FF00", Offset = "0x264F300", Length = "0x7")]
	[Token(Token = "0x60006FB")]
	public X509Certificate2() { }

	[Address(RVA = "0x264FDE0", Offset = "0x264F1E0", Length = "0x10F")]
	[Token(Token = "0x60006FC")]
	public X509Certificate2(Byte[] rawData) { }

	[Address(RVA = "0x264FDC0", Offset = "0x264F1C0", Length = "0x8")]
	[Token(Token = "0x60006FD")]
	public X509Certificate2(Byte[] rawData, string password) { }

	[Address(RVA = "0x264FEF0", Offset = "0x264F2F0", Length = "0x8")]
	[Token(Token = "0x60006FE")]
	internal X509Certificate2(X509Certificate2Impl impl) { }

	[Address(RVA = "0x264FDD0", Offset = "0x264F1D0", Length = "0x8")]
	[Token(Token = "0x60006FF")]
	public X509Certificate2(X509Certificate certificate) { }

	[Address(RVA = "0x264FF10", Offset = "0x264F310", Length = "0x54")]
	[Token(Token = "0x6000700")]
	protected X509Certificate2(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x264EBC0", Offset = "0x264DFC0", Length = "0x2CE")]
	[Token(Token = "0x6000713")]
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	[Address(RVA = "0x264FF70", Offset = "0x264F370", Length = "0x349")]
	[Token(Token = "0x6000701")]
	public X509ExtensionCollection get_Extensions() { }

	[Address(RVA = "0x26502C0", Offset = "0x264F6C0", Length = "0x40")]
	[Token(Token = "0x6000702")]
	public bool get_HasPrivateKey() { }

	[Address(RVA = "0x2650310", Offset = "0x264F710", Length = "0x7C")]
	[Token(Token = "0x6000714")]
	internal X509Certificate2Impl get_Impl() { }

	[Address(RVA = "0x2650390", Offset = "0x264F790", Length = "0x7B")]
	[Token(Token = "0x6000704")]
	public X500DistinguishedName get_IssuerName() { }

	[Address(RVA = "0x2650410", Offset = "0x264F810", Length = "0x7")]
	[Token(Token = "0x6000705")]
	public DateTime get_NotAfter() { }

	[Address(RVA = "0x2650420", Offset = "0x264F820", Length = "0x7")]
	[Token(Token = "0x6000706")]
	public DateTime get_NotBefore() { }

	[Address(RVA = "0x2650430", Offset = "0x264F830", Length = "0x1B1")]
	[Token(Token = "0x6000703")]
	public AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x26505F0", Offset = "0x264F9F0", Length = "0x31B")]
	[Token(Token = "0x6000707")]
	public PublicKey get_PublicKey() { }

	[Address(RVA = "0x2650910", Offset = "0x264FD10", Length = "0x79")]
	[Token(Token = "0x6000708")]
	public Byte[] get_RawData() { }

	[Address(RVA = "0x2650990", Offset = "0x264FD90", Length = "0x14")]
	[Token(Token = "0x6000709")]
	public string get_SerialNumber() { }

	[Address(RVA = "0x26509B0", Offset = "0x264FDB0", Length = "0x82")]
	[Token(Token = "0x600070A")]
	public Oid get_SignatureAlgorithm() { }

	[Address(RVA = "0x2650A40", Offset = "0x264FE40", Length = "0x72")]
	[Token(Token = "0x600070B")]
	public X500DistinguishedName get_SubjectName() { }

	[Address(RVA = "0x2650AC0", Offset = "0x264FEC0", Length = "0x25")]
	[Token(Token = "0x600070C")]
	public string get_Thumbprint() { }

	[Address(RVA = "0x2650AF0", Offset = "0x264FEF0", Length = "0x61")]
	[Token(Token = "0x600070D")]
	public int get_Version() { }

	[Address(RVA = "0x264EE90", Offset = "0x264E290", Length = "0x9D")]
	[Token(Token = "0x600070E")]
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	[Address(RVA = "0x264EF30", Offset = "0x264E330", Length = "0x48")]
	[Token(Token = "0x600070F")]
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Address(RVA = "0x264EF80", Offset = "0x264E380", Length = "0xCF")]
	[Token(Token = "0x60006FA")]
	public virtual void Reset() { }

	[Address(RVA = "0x264FD70", Offset = "0x264F170", Length = "0xA")]
	[Token(Token = "0x6000710")]
	public virtual string ToString() { }

	[Address(RVA = "0x264F050", Offset = "0x264E450", Length = "0xD13")]
	[Token(Token = "0x6000711")]
	public virtual string ToString(bool verbose) { }

	[Address(RVA = "0x264FD80", Offset = "0x264F180", Length = "0x39")]
	[Token(Token = "0x6000712")]
	public bool Verify() { }

}

