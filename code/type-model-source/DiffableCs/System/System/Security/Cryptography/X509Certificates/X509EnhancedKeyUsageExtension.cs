namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013D")]
public sealed class X509EnhancedKeyUsageExtension : X509Extension
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005BB")]
	private OidCollection _enhKeyUsage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005BC")]
	private AsnDecodeStatus _status; //Field offset: 0x30

	[Address(RVA = "0x2658160", Offset = "0x2657560", Length = "0x8D")]
	[Token(Token = "0x60007D4")]
	public X509EnhancedKeyUsageExtension() { }

	[Address(RVA = "0x26581F0", Offset = "0x26575F0", Length = "0xDA")]
	[Token(Token = "0x60007D5")]
	public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	[Address(RVA = "0x26582D0", Offset = "0x26576D0", Length = "0x254")]
	[Token(Token = "0x60007D6")]
	public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical) { }

	[Address(RVA = "0x2657A10", Offset = "0x2656E10", Length = "0x1DE")]
	[Token(Token = "0x60007D7")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x2657BF0", Offset = "0x2656FF0", Length = "0x1D0")]
	[Token(Token = "0x60007D8")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x2657DD0", Offset = "0x26571D0", Length = "0xC8")]
	[Token(Token = "0x60007D9")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x2657EA0", Offset = "0x26572A0", Length = "0x2B1")]
	[Token(Token = "0x60007DA")]
	internal virtual string ToString(bool multiLine) { }

}

