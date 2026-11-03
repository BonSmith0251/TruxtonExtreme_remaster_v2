namespace Mono.Security;

[DefaultMember("Item")]
[Token(Token = "0x2000003")]
public class ASN1
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private byte m_nTag; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private Byte[] m_aValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000003")]
	private ArrayList elist; //Field offset: 0x20

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Address(RVA = "0x1E2D070", Offset = "0x1E2C470", Length = "0x22")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000005")]
	public ASN1 Item
	{
		[Address(RVA = "0x1E2D0A0", Offset = "0x1E2C4A0", Length = "0xC3")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 195
	}

	[Token(Token = "0x17000003")]
	public int Length
	{
		[Address(RVA = "0xAFF420", Offset = "0xAFE820", Length = "0x12")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000002")]
	public byte Tag
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public Byte[] Value
	{
		[Address(RVA = "0x1E2D170", Offset = "0x1E2C570", Length = "0x94")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 148
		[Address(RVA = "0x1E2D210", Offset = "0x1E2C610", Length = "0xB0")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 176
	}

	[Address(RVA = "0x1E2CFE0", Offset = "0x1E2C3E0", Length = "0x37")]
	[Token(Token = "0x6000003")]
	public ASN1(byte tag) { }

	[Address(RVA = "0x1E2D020", Offset = "0x1E2C420", Length = "0x41")]
	[Token(Token = "0x6000004")]
	public ASN1(byte tag, Byte[] data) { }

	[Address(RVA = "0x1E2CE50", Offset = "0x1E2C250", Length = "0x18B")]
	[Token(Token = "0x6000005")]
	public ASN1(Byte[] data) { }

	[Address(RVA = "0x1E2BF70", Offset = "0x1E2B370", Length = "0x9D")]
	[Token(Token = "0x600000D")]
	public ASN1 Add(ASN1 asn1) { }

	[Address(RVA = "0x1E2C010", Offset = "0x1E2B410", Length = "0x8D")]
	[Token(Token = "0x600000B")]
	private bool CompareArray(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x1E2C0A0", Offset = "0x1E2B4A0", Length = "0x7C")]
	[Token(Token = "0x600000C")]
	public bool CompareValue(Byte[] value) { }

	[Address(RVA = "0x1E2C240", Offset = "0x1E2B640", Length = "0x1DD")]
	[Token(Token = "0x600000F")]
	protected void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	[Address(RVA = "0x1E2C120", Offset = "0x1E2B520", Length = "0x117")]
	[Token(Token = "0x6000010")]
	protected void DecodeTLV(Byte[] asn1, ref int pos, out byte tag, out int length, out Byte[] content) { }

	[Address(RVA = "0x1E2C420", Offset = "0x1E2B820", Length = "0xE1")]
	[Token(Token = "0x6000012")]
	public ASN1 Element(int index, byte anTag) { }

	[Address(RVA = "0x1E2D070", Offset = "0x1E2C470", Length = "0x22")]
	[Token(Token = "0x6000006")]
	public int get_Count() { }

	[Address(RVA = "0x1E2D0A0", Offset = "0x1E2C4A0", Length = "0xC3")]
	[Token(Token = "0x6000011")]
	public ASN1 get_Item(int index) { }

	[Address(RVA = "0xAFF420", Offset = "0xAFE820", Length = "0x12")]
	[Token(Token = "0x6000008")]
	public int get_Length() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000007")]
	public byte get_Tag() { }

	[Address(RVA = "0x1E2D170", Offset = "0x1E2C570", Length = "0x94")]
	[Token(Token = "0x6000009")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x1E2C510", Offset = "0x1E2B910", Length = "0x628")]
	[Token(Token = "0x600000E")]
	public override Byte[] GetBytes() { }

	[Address(RVA = "0x1E2D210", Offset = "0x1E2C610", Length = "0xB0")]
	[Token(Token = "0x600000A")]
	public void set_Value(Byte[] value) { }

	[Address(RVA = "0x1E2CB40", Offset = "0x1E2BF40", Length = "0x30D")]
	[Token(Token = "0x6000013")]
	public virtual string ToString() { }

}

