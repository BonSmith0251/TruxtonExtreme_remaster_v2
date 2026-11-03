namespace Mono.Security.X509;

[Token(Token = "0x200000B")]
internal class SafeBag
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000019")]
	private string _bagOID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001A")]
	private ASN1 _asn1; //Field offset: 0x18

	[Token(Token = "0x17000017")]
	public ASN1 ASN1
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public string BagOID
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000041")]
	public SafeBag(string bagOID, ASN1 asn1) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000043")]
	public ASN1 get_ASN1() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000042")]
	public string get_BagOID() { }

}

