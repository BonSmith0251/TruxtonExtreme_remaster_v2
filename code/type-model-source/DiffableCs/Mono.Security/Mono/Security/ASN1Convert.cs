namespace Mono.Security;

[Token(Token = "0x2000004")]
public static class ASN1Convert
{

	[Address(RVA = "0x1E2AFA0", Offset = "0x1E2A3A0", Length = "0x350")]
	[Token(Token = "0x6000014")]
	public static ASN1 FromInt32(int value) { }

	[Address(RVA = "0x1E2B300", Offset = "0x1E2A700", Length = "0xD0")]
	[Token(Token = "0x6000015")]
	public static ASN1 FromOid(string oid) { }

	[Address(RVA = "0x1E2B3E0", Offset = "0x1E2A7E0", Length = "0x11A")]
	[Token(Token = "0x6000016")]
	public static ASN1 FromUnsignedBigInteger(Byte[] big) { }

	[Address(RVA = "0x1E2B500", Offset = "0x1E2A900", Length = "0x5EC")]
	[Token(Token = "0x6000019")]
	public static DateTime ToDateTime(ASN1 time) { }

	[Address(RVA = "0x1E2BB10", Offset = "0x1E2AF10", Length = "0x1BA")]
	[Token(Token = "0x6000017")]
	public static int ToInt32(ASN1 asn1) { }

	[Address(RVA = "0x1E2BCD0", Offset = "0x1E2B0D0", Length = "0x29A")]
	[Token(Token = "0x6000018")]
	public static string ToOid(ASN1 asn1) { }

}

