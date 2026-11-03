namespace Mono.Security.X509;

[Token(Token = "0x200000E")]
public sealed class X501
{
	[Token(Token = "0x400002D")]
	private static Byte[] countryName; //Field offset: 0x0
	[Token(Token = "0x400002E")]
	private static Byte[] organizationName; //Field offset: 0x8
	[Token(Token = "0x400002F")]
	private static Byte[] organizationalUnitName; //Field offset: 0x10
	[Token(Token = "0x4000030")]
	private static Byte[] commonName; //Field offset: 0x18
	[Token(Token = "0x4000031")]
	private static Byte[] localityName; //Field offset: 0x20
	[Token(Token = "0x4000032")]
	private static Byte[] stateOrProvinceName; //Field offset: 0x28
	[Token(Token = "0x4000033")]
	private static Byte[] streetAddress; //Field offset: 0x30
	[Token(Token = "0x4000034")]
	private static Byte[] serialNumber; //Field offset: 0x38
	[Token(Token = "0x4000035")]
	private static Byte[] domainComponent; //Field offset: 0x40
	[Token(Token = "0x4000036")]
	private static Byte[] userid; //Field offset: 0x48
	[Token(Token = "0x4000037")]
	private static Byte[] email; //Field offset: 0x50
	[Token(Token = "0x4000038")]
	private static Byte[] dnQualifier; //Field offset: 0x58
	[Token(Token = "0x4000039")]
	private static Byte[] title; //Field offset: 0x60
	[Token(Token = "0x400003A")]
	private static Byte[] surname; //Field offset: 0x68
	[Token(Token = "0x400003B")]
	private static Byte[] givenName; //Field offset: 0x70
	[Token(Token = "0x400003C")]
	private static Byte[] initial; //Field offset: 0x78

	[Address(RVA = "0x1E3E450", Offset = "0x1E3D850", Length = "0x612")]
	[Token(Token = "0x600007C")]
	private static X501() { }

	[Address(RVA = "0x1E3BDA0", Offset = "0x1E3B1A0", Length = "0x957")]
	[Token(Token = "0x6000072")]
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	[Address(RVA = "0x1E3C700", Offset = "0x1E3BB00", Length = "0x460")]
	[Token(Token = "0x600007B")]
	public static ASN1 FromString(string rdn) { }

	[Address(RVA = "0x1E3CB70", Offset = "0x1E3BF70", Length = "0xA86")]
	[Token(Token = "0x6000073")]
	private static AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	[Address(RVA = "0x1E3D600", Offset = "0x1E3CA00", Length = "0xB7")]
	[Token(Token = "0x6000076")]
	private static bool IsHex(char c) { }

	[Address(RVA = "0x1E3D6C0", Offset = "0x1E3CAC0", Length = "0xE2")]
	[Token(Token = "0x6000074")]
	private static bool IsOid(string oid) { }

	[Address(RVA = "0x1E3D7B0", Offset = "0x1E3CBB0", Length = "0x18A")]
	[Token(Token = "0x6000075")]
	private static AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	[Address(RVA = "0x1E3D940", Offset = "0x1E3CD40", Length = "0x1A9")]
	[Token(Token = "0x6000078")]
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	[Address(RVA = "0x1E3DAF0", Offset = "0x1E3CEF0", Length = "0x22E")]
	[Token(Token = "0x6000077")]
	private static string ReadHex(string value, ref int pos) { }

	[Address(RVA = "0x1E3DD20", Offset = "0x1E3D120", Length = "0x14A")]
	[Token(Token = "0x6000079")]
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	[Address(RVA = "0x1E3DE70", Offset = "0x1E3D270", Length = "0x297")]
	[Token(Token = "0x600007A")]
	private static string ReadValue(string value, ref int pos) { }

	[Address(RVA = "0x1E3E300", Offset = "0x1E3D700", Length = "0x14A")]
	[Token(Token = "0x6000070")]
	public static string ToString(ASN1 seq) { }

	[Address(RVA = "0x1E3E110", Offset = "0x1E3D510", Length = "0x1EC")]
	[Token(Token = "0x6000071")]
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

}

