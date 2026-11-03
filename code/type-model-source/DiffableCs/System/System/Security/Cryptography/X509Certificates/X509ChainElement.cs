namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000136")]
public class X509ChainElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400059A")]
	private X509Certificate2 certificate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400059B")]
	private X509ChainStatus[] status; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400059C")]
	private string info; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400059D")]
	private X509ChainStatusFlags compressed_status_flags; //Field offset: 0x28

	[Token(Token = "0x17000154")]
	public X509Certificate2 Certificate
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600077E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000155")]
	public X509ChainStatus[] ChainElementStatus
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600077F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000156")]
	internal X509ChainStatusFlags StatusFlags
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000780")]
		internal get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000781")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2652E30", Offset = "0x2652230", Length = "0x4F")]
	[Token(Token = "0x600077D")]
	internal X509ChainElement(X509Certificate2 certificate) { }

	[Address(RVA = "0x2651EE0", Offset = "0x26512E0", Length = "0x2F")]
	[Token(Token = "0x6000782")]
	private int Count(X509ChainStatusFlags flags) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600077E")]
	public X509Certificate2 get_Certificate() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600077F")]
	public X509ChainStatus[] get_ChainElementStatus() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000780")]
	internal X509ChainStatusFlags get_StatusFlags() { }

	[Address(RVA = "0x2651F10", Offset = "0x2651310", Length = "0x7D")]
	[Token(Token = "0x6000783")]
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000781")]
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	[Address(RVA = "0x2651F90", Offset = "0x2651390", Length = "0xE96")]
	[Token(Token = "0x6000784")]
	internal void UncompressFlags() { }

}

