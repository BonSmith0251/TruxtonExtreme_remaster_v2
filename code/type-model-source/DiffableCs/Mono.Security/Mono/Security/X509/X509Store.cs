namespace Mono.Security.X509;

[Token(Token = "0x2000018")]
public class X509Store
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000073")]
	private string _storePath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000074")]
	private X509CertificateCollection _certificates; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000075")]
	private ArrayList _crls; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000076")]
	private bool _crl; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000077")]
	private bool _newFormat; //Field offset: 0x29

	[Token(Token = "0x17000042")]
	public X509CertificateCollection Certificates
	{
		[Address(RVA = "0x1E45AA0", Offset = "0x1E44EA0", Length = "0x40")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000043")]
	public ArrayList Crls
	{
		[Address(RVA = "0x1E45AE0", Offset = "0x1E44EE0", Length = "0x8E")]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 142
	}

	[Address(RVA = "0x1E45A40", Offset = "0x1E44E40", Length = "0x56")]
	[Token(Token = "0x60000D5")]
	internal X509Store(string path, bool crl, bool newFormat) { }

	[Address(RVA = "0x1E45380", Offset = "0x1E44780", Length = "0x1C1")]
	[Token(Token = "0x60000DC")]
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	[Address(RVA = "0x1E45550", Offset = "0x1E44950", Length = "0x145")]
	[Token(Token = "0x60000DD")]
	private ArrayList BuildCrlsCollection(string storeName) { }

	[Address(RVA = "0x1E456A0", Offset = "0x1E44AA0", Length = "0x5F")]
	[Token(Token = "0x60000DB")]
	private bool CheckStore(string path, bool throwException) { }

	[Address(RVA = "0x1E45AA0", Offset = "0x1E44EA0", Length = "0x40")]
	[Token(Token = "0x60000D6")]
	public X509CertificateCollection get_Certificates() { }

	[Address(RVA = "0x1E45AE0", Offset = "0x1E44EE0", Length = "0x8E")]
	[Token(Token = "0x60000D7")]
	public ArrayList get_Crls() { }

	[Address(RVA = "0x1E458D0", Offset = "0x1E44CD0", Length = "0x165")]
	[Token(Token = "0x60000D8")]
	private Byte[] Load(string filename) { }

	[Address(RVA = "0x1E45700", Offset = "0x1E44B00", Length = "0x68")]
	[Token(Token = "0x60000D9")]
	private X509Certificate LoadCertificate(string filename) { }

	[Address(RVA = "0x1E45770", Offset = "0x1E44B70", Length = "0x159")]
	[Token(Token = "0x60000DA")]
	private X509Crl LoadCrl(string filename) { }

}

