namespace System.Xml;

[Token(Token = "0x200000F")]
internal struct BinXmlSqlMoney
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000069")]
	private long data; //Field offset: 0x0

	[Address(RVA = "0x2081A60", Offset = "0x2080E60", Length = "0x7")]
	[Token(Token = "0x6000020")]
	public BinXmlSqlMoney(int v) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000021")]
	public BinXmlSqlMoney(long v) { }

	[Address(RVA = "0x23F2A90", Offset = "0x23F1E90", Length = "0x4B")]
	[Token(Token = "0x6000022")]
	public decimal ToDecimal() { }

	[Address(RVA = "0x23F2AE0", Offset = "0x23F1EE0", Length = "0xDE")]
	[Token(Token = "0x6000023")]
	public virtual string ToString() { }

}

