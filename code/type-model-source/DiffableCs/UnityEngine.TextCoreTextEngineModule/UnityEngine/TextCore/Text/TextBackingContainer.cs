namespace UnityEngine.TextCore.Text;

[DefaultMember("Item")]
[Token(Token = "0x2000054")]
internal struct TextBackingContainer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400032E")]
	private UInt32[] m_Array; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400032F")]
	private int m_Count; //Field offset: 0x8

	[Token(Token = "0x1700006D")]
	public int Capacity
	{
		[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
		[Token(Token = "0x6000236")]
		 get { } //Length: 25
	}

	[Token(Token = "0x1700006E")]
	public int Count
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000237")]
		 get { } //Length: 6
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6000238")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700006F")]
	public uint Item
	{
		[Address(RVA = "0x2F17CF0", Offset = "0x2F170F0", Length = "0x2A")]
		[Token(Token = "0x6000239")]
		 get { } //Length: 42
		[Address(RVA = "0x31B2CB0", Offset = "0x31B20B0", Length = "0x5B")]
		[Token(Token = "0x600023A")]
		 set { } //Length: 91
	}

	[Address(RVA = "0x31B2C50", Offset = "0x31B2050", Length = "0x59")]
	[Token(Token = "0x600023B")]
	public TextBackingContainer(int size) { }

	[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
	[Token(Token = "0x6000236")]
	public int get_Capacity() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6000237")]
	public int get_Count() { }

	[Address(RVA = "0x2F17CF0", Offset = "0x2F170F0", Length = "0x2A")]
	[Token(Token = "0x6000239")]
	public uint get_Item(int index) { }

	[Address(RVA = "0x31B2BE0", Offset = "0x31B1FE0", Length = "0x68")]
	[Token(Token = "0x600023C")]
	public void Resize(int size) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6000238")]
	public void set_Count(int value) { }

	[Address(RVA = "0x31B2CB0", Offset = "0x31B20B0", Length = "0x5B")]
	[Token(Token = "0x600023A")]
	public void set_Item(int index, uint value) { }

}

