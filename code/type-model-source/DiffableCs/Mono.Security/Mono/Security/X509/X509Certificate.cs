namespace Mono.Security.X509;

[Token(Token = "0x2000011")]
public class X509Certificate : ISerializable
{
	[Token(Token = "0x4000060")]
	private static string encoding_error; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	private ASN1 decoder; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004B")]
	private Byte[] m_encodedcert; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004C")]
	private DateTime m_from; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004D")]
	private DateTime m_until; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400004E")]
	private ASN1 issuer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004F")]
	private string m_issuername; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000050")]
	private string m_keyalgo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000051")]
	private Byte[] m_keyalgoparams; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000052")]
	private ASN1 subject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000053")]
	private string m_subject; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000054")]
	private Byte[] m_publickey; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000055")]
	private Byte[] signature; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000056")]
	private string m_signaturealgo; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000057")]
	private Byte[] m_signaturealgoparams; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000058")]
	private Byte[] certhash; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000059")]
	private RSA _rsa; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400005A")]
	private DSA _dsa; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400005B")]
	private int version; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400005C")]
	private Byte[] serialnumber; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400005D")]
	private Byte[] issuerUniqueID; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400005E")]
	private Byte[] subjectUniqueID; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400005F")]
	private X509ExtensionCollection extensions; //Field offset: 0xB8

	[Token(Token = "0x17000029")]
	public DSA DSA
	{
		[Address(RVA = "0x1E40600", Offset = "0x1E3FA00", Length = "0x398")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 920
		[Address(RVA = "0x1E41600", Offset = "0x1E40A00", Length = "0x4C")]
		[Token(Token = "0x6000091")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700002A")]
	public X509ExtensionCollection Extensions
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002B")]
	public Byte[] Hash
	{
		[Address(RVA = "0x1E409A0", Offset = "0x1E3FDA0", Length = "0x242")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 578
	}

	[Token(Token = "0x17000038")]
	public bool IsCurrent
	{
		[Address(RVA = "0x1E40BF0", Offset = "0x1E3FFF0", Length = "0x104")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 260
	}

	[Token(Token = "0x17000039")]
	public bool IsSelfSigned
	{
		[Address(RVA = "0x1E40D00", Offset = "0x1E40100", Length = "0x90")]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700002C")]
	public override string IssuerName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002D")]
	public override string KeyAlgorithm
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002E")]
	public override Byte[] KeyAlgorithmParameters
	{
		[Address(RVA = "0x1E40D90", Offset = "0x1E40190", Length = "0x7B")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 123
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000097")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002F")]
	public override Byte[] PublicKey
	{
		[Address(RVA = "0x1E40E10", Offset = "0x1E40210", Length = "0x7B")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000031")]
	public override Byte[] RawData
	{
		[Address(RVA = "0x1E410C0", Offset = "0x1E404C0", Length = "0x7B")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000030")]
	public override RSA RSA
	{
		[Address(RVA = "0x1E40E90", Offset = "0x1E40290", Length = "0x225")]
		[Token(Token = "0x6000099")]
		 get { } //Length: 549
		[Address(RVA = "0x1E41650", Offset = "0x1E40A50", Length = "0x4E")]
		[Token(Token = "0x600009A")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000032")]
	public override Byte[] SerialNumber
	{
		[Address(RVA = "0x1E41140", Offset = "0x1E40540", Length = "0x81")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000033")]
	public override Byte[] Signature
	{
		[Address(RVA = "0x1E411D0", Offset = "0x1E405D0", Length = "0x422")]
		[Token(Token = "0x600009D")]
		 get { } //Length: 1058
	}

	[Token(Token = "0x17000034")]
	public override string SubjectName
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000035")]
	public override DateTime ValidFrom
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000036")]
	public override DateTime ValidUntil
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000037")]
	public int Version
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1E40360", Offset = "0x1E3F760", Length = "0x5B")]
	[Token(Token = "0x60000AA")]
	private static X509Certificate() { }

	[Address(RVA = "0x1E403C0", Offset = "0x1E3F7C0", Length = "0x23F")]
	[Token(Token = "0x600008E")]
	public X509Certificate(Byte[] data) { }

	[Address(RVA = "0x1E40600", Offset = "0x1E3FA00", Length = "0x398")]
	[Token(Token = "0x6000090")]
	public DSA get_DSA() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000092")]
	public X509ExtensionCollection get_Extensions() { }

	[Address(RVA = "0x1E409A0", Offset = "0x1E3FDA0", Length = "0x242")]
	[Token(Token = "0x6000093")]
	public Byte[] get_Hash() { }

	[Address(RVA = "0x1E40BF0", Offset = "0x1E3FFF0", Length = "0x104")]
	[Token(Token = "0x60000A2")]
	public bool get_IsCurrent() { }

	[Address(RVA = "0x1E40D00", Offset = "0x1E40100", Length = "0x90")]
	[Token(Token = "0x60000A7")]
	public bool get_IsSelfSigned() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000094")]
	public override string get_IssuerName() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000095")]
	public override string get_KeyAlgorithm() { }

	[Address(RVA = "0x1E40D90", Offset = "0x1E40190", Length = "0x7B")]
	[Token(Token = "0x6000096")]
	public override Byte[] get_KeyAlgorithmParameters() { }

	[Address(RVA = "0x1E40E10", Offset = "0x1E40210", Length = "0x7B")]
	[Token(Token = "0x6000098")]
	public override Byte[] get_PublicKey() { }

	[Address(RVA = "0x1E410C0", Offset = "0x1E404C0", Length = "0x7B")]
	[Token(Token = "0x600009B")]
	public override Byte[] get_RawData() { }

	[Address(RVA = "0x1E40E90", Offset = "0x1E40290", Length = "0x225")]
	[Token(Token = "0x6000099")]
	public override RSA get_RSA() { }

	[Address(RVA = "0x1E41140", Offset = "0x1E40540", Length = "0x81")]
	[Token(Token = "0x600009C")]
	public override Byte[] get_SerialNumber() { }

	[Address(RVA = "0x1E411D0", Offset = "0x1E405D0", Length = "0x422")]
	[Token(Token = "0x600009D")]
	public override Byte[] get_Signature() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600009E")]
	public override string get_SubjectName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600009F")]
	public override DateTime get_ValidFrom() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000A0")]
	public override DateTime get_ValidUntil() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x60000A1")]
	public int get_Version() { }

	[Address(RVA = "0x1E3F2C0", Offset = "0x1E3E6C0", Length = "0x56")]
	[Token(Token = "0x60000A8")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1E3F320", Offset = "0x1E3E720", Length = "0x9D")]
	[Token(Token = "0x600008F")]
	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	[Address(RVA = "0x1E3F4E0", Offset = "0x1E3E8E0", Length = "0x9A5")]
	[Token(Token = "0x600008D")]
	private void Parse(Byte[] data) { }

	[Address(RVA = "0x1E3F3C0", Offset = "0x1E3E7C0", Length = "0x116")]
	[Token(Token = "0x60000A9")]
	private static Byte[] PEM(string type, Byte[] data) { }

	[Address(RVA = "0x1E41600", Offset = "0x1E40A00", Length = "0x4C")]
	[Token(Token = "0x6000091")]
	public void set_DSA(DSA value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000097")]
	public override void set_KeyAlgorithmParameters(Byte[] value) { }

	[Address(RVA = "0x1E41650", Offset = "0x1E40A50", Length = "0x4E")]
	[Token(Token = "0x600009A")]
	public override void set_RSA(RSA value) { }

	[Address(RVA = "0x1E401B0", Offset = "0x1E3F5B0", Length = "0xD2")]
	[Token(Token = "0x60000A4")]
	internal bool VerifySignature(DSA dsa) { }

	[Address(RVA = "0x1E40080", Offset = "0x1E3F480", Length = "0x128")]
	[Token(Token = "0x60000A5")]
	internal bool VerifySignature(RSA rsa) { }

	[Address(RVA = "0x1E3FE90", Offset = "0x1E3F290", Length = "0x1E8")]
	[Token(Token = "0x60000A6")]
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	[Address(RVA = "0x1E40290", Offset = "0x1E3F690", Length = "0xCC")]
	[Token(Token = "0x60000A3")]
	public bool WasCurrent(DateTime instant) { }

}

