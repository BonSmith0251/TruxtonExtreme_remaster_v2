namespace Mono.Security;

[DefaultMember("Item")]
[Token(Token = "0x200005D")]
internal class ASN1
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B7")]
	private byte m_nTag; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B8")]
	private Byte[] m_aValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B9")]
	private ArrayList elist; //Field offset: 0x20

	[Token(Token = "0x17000017")]
	public int Count
	{
		[Address(RVA = "0x1E2D070", Offset = "0x1E2C470", Length = "0x22")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000018")]
	public Byte[] Value
	{
		[Address(RVA = "0x1E5A8E0", Offset = "0x1E59CE0", Length = "0x94")]
		[Token(Token = "0x6000113")]
		 get { } //Length: 148
	}

	[Address(RVA = "0x1E2CFE0", Offset = "0x1E2C3E0", Length = "0x37")]
	[Token(Token = "0x600010F")]
	public ASN1(byte tag) { }

	[Address(RVA = "0x1E2D020", Offset = "0x1E2C420", Length = "0x41")]
	[Token(Token = "0x6000110")]
	public ASN1(byte tag, Byte[] data) { }

	[Address(RVA = "0x1E5A750", Offset = "0x1E59B50", Length = "0x18B")]
	[Token(Token = "0x6000111")]
	public ASN1(Byte[] data) { }

	[Address(RVA = "0x1E599F0", Offset = "0x1E58DF0", Length = "0x9D")]
	[Token(Token = "0x6000114")]
	public ASN1 Add(ASN1 asn1) { }

	[Address(RVA = "0x1E59BB0", Offset = "0x1E58FB0", Length = "0x1DD")]
	[Token(Token = "0x6000116")]
	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	[Address(RVA = "0x1E59A90", Offset = "0x1E58E90", Length = "0x117")]
	[Token(Token = "0x6000117")]
	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	[Address(RVA = "0x1E2D070", Offset = "0x1E2C470", Length = "0x22")]
	[Token(Token = "0x6000112")]
	public int get_Count() { }

	[Address(RVA = "0x1E5A8E0", Offset = "0x1E59CE0", Length = "0x94")]
	[Token(Token = "0x6000113")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x1E59D90", Offset = "0x1E59190", Length = "0x6A1")]
	[Token(Token = "0x6000115")]
	public override Byte[] GetBytes() { }

	[Address(RVA = "0x1E5A440", Offset = "0x1E59840", Length = "0x30D")]
	[Token(Token = "0x6000118")]
	public virtual string ToString() { }

}

