namespace Mono.Security.X509;

[Token(Token = "0x2000016")]
public class X509Extension
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006F")]
	protected string extnOid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000070")]
	protected bool extnCritical; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000071")]
	protected ASN1 extnValue; //Field offset: 0x20

	[Token(Token = "0x1700003F")]
	public bool Critical
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003E")]
	public string Oid
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public ASN1 Value
	{
		[Address(RVA = "0x1E44640", Offset = "0x1E43A40", Length = "0x37")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x1E44180", Offset = "0x1E43580", Length = "0x322")]
	[Token(Token = "0x60000C5")]
	public X509Extension(ASN1 asn1) { }

	[Address(RVA = "0x1E444B0", Offset = "0x1E438B0", Length = "0x181")]
	[Token(Token = "0x60000C6")]
	public X509Extension(X509Extension extension) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C7")]
	protected override void Decode() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C8")]
	protected override void Encode() { }

	[Address(RVA = "0x1E43CC0", Offset = "0x1E430C0", Length = "0x154")]
	[Token(Token = "0x60000CC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60000CA")]
	public bool get_Critical() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000C9")]
	public string get_Oid() { }

	[Address(RVA = "0x1E44640", Offset = "0x1E43A40", Length = "0x37")]
	[Token(Token = "0x60000CB")]
	public ASN1 get_Value() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x60000CD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E43E20", Offset = "0x1E43220", Length = "0x114")]
	[Token(Token = "0x60000CF")]
	public virtual string ToString() { }

	[Address(RVA = "0x1E43F40", Offset = "0x1E43340", Length = "0x231")]
	[Token(Token = "0x60000CE")]
	private void WriteLine(StringBuilder sb, int n, int pos) { }

}

