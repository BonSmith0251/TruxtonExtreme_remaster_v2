namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000142")]
public sealed class X509KeyUsageExtension : X509Extension
{
	[Token(Token = "0x40005C1")]
	internal const string oid = "2.5.29.15"; //Field offset: 0x0
	[Token(Token = "0x40005C2")]
	internal const string friendlyName = "Key Usage"; //Field offset: 0x0
	[Token(Token = "0x40005C3")]
	internal const X509KeyUsageFlags all = 33023; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C4")]
	private X509KeyUsageFlags _keyUsages; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005C5")]
	private AsnDecodeStatus _status; //Field offset: 0x2C

	[Token(Token = "0x17000178")]
	public X509KeyUsageFlags KeyUsages
	{
		[Address(RVA = "0x2659E10", Offset = "0x2659210", Length = "0x6A")]
		[Token(Token = "0x60007F8")]
		 get { } //Length: 106
	}

	[Address(RVA = "0x2659D80", Offset = "0x2659180", Length = "0x8D")]
	[Token(Token = "0x60007F5")]
	public X509KeyUsageExtension() { }

	[Address(RVA = "0x2659BC0", Offset = "0x2658FC0", Length = "0xDA")]
	[Token(Token = "0x60007F6")]
	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical) { }

	[Address(RVA = "0x2659CA0", Offset = "0x26590A0", Length = "0xD4")]
	[Token(Token = "0x60007F7")]
	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical) { }

	[Address(RVA = "0x26591F0", Offset = "0x26585F0", Length = "0x1DE")]
	[Token(Token = "0x60007F9")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x26593D0", Offset = "0x26587D0", Length = "0x15C")]
	[Token(Token = "0x60007FB")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x2659530", Offset = "0x2658930", Length = "0x16C")]
	[Token(Token = "0x60007FC")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x2659E10", Offset = "0x2659210", Length = "0x6A")]
	[Token(Token = "0x60007F8")]
	public X509KeyUsageFlags get_KeyUsages() { }

	[Address(RVA = "0x26596A0", Offset = "0x2658AA0", Length = "0x10")]
	[Token(Token = "0x60007FA")]
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	[Address(RVA = "0x26596B0", Offset = "0x2658AB0", Length = "0x502")]
	[Token(Token = "0x60007FD")]
	internal virtual string ToString(bool multiLine) { }

}

