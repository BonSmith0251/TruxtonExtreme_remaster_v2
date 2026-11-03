namespace System.Data.SqlTypes;

[Token(Token = "0x20000AA")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlByte : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x4000356")]
	private static readonly int s_iBitNotByteMax; //Field offset: 0x0
	[Token(Token = "0x4000357")]
	public static readonly SqlByte Null; //Field offset: 0x4
	[Token(Token = "0x4000358")]
	public static readonly SqlByte Zero; //Field offset: 0x6
	[Token(Token = "0x4000359")]
	public static readonly SqlByte MinValue; //Field offset: 0x8
	[Token(Token = "0x400035A")]
	public static readonly SqlByte MaxValue; //Field offset: 0xA
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000354")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000355")]
	private byte m_value; //Field offset: 0x1

	[Token(Token = "0x17000158")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60008CE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000159")]
	public byte Value
	{
		[Address(RVA = "0x2375DC0", Offset = "0x23751C0", Length = "0x54")]
		[Token(Token = "0x60008CF")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x2375CF0", Offset = "0x23750F0", Length = "0xB1")]
	[Token(Token = "0x60008E6")]
	private static SqlByte() { }

	[Address(RVA = "0x2375DB0", Offset = "0x23751B0", Length = "0x6")]
	[Token(Token = "0x60008CC")]
	private SqlByte(bool fNull) { }

	[Address(RVA = "0xDA8970", Offset = "0xDA7D70", Length = "0x7")]
	[Token(Token = "0x60008CD")]
	public SqlByte(byte value) { }

	[Address(RVA = "0x2375270", Offset = "0x2374670", Length = "0x1BE")]
	[Token(Token = "0x60008DF")]
	public int CompareTo(SqlByte value) { }

	[Address(RVA = "0x2375430", Offset = "0x2374830", Length = "0x10E")]
	[Token(Token = "0x60008DE")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2375540", Offset = "0x2374940", Length = "0x216")]
	[Token(Token = "0x60008E0")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x60008CE")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2375DC0", Offset = "0x23751C0", Length = "0x54")]
	[Token(Token = "0x60008CF")]
	public byte get_Value() { }

	[Address(RVA = "0x2375760", Offset = "0x2374B60", Length = "0xB8")]
	[Token(Token = "0x60008E1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2375820", Offset = "0x2374C20", Length = "0x6B")]
	[Token(Token = "0x60008E5")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2375890", Offset = "0x2374C90", Length = "0x59")]
	[Token(Token = "0x60008DB")]
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x23758F0", Offset = "0x2374CF0", Length = "0x59")]
	[Token(Token = "0x60008DA")]
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x2375E20", Offset = "0x2375220", Length = "0x126")]
	[Token(Token = "0x60008D2")]
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x2375F50", Offset = "0x2375350", Length = "0x115")]
	[Token(Token = "0x60008D5")]
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x2376070", Offset = "0x2375470", Length = "0xC3")]
	[Token(Token = "0x60008D7")]
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x2376140", Offset = "0x2375540", Length = "0x181")]
	[Token(Token = "0x60008D6")]
	public static SqlByte op_Explicit(SqlInt64 x) { }

	[Address(RVA = "0x23762D0", Offset = "0x23756D0", Length = "0xC3")]
	[Token(Token = "0x60008D9")]
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x23763A0", Offset = "0x23757A0", Length = "0xF")]
	[Token(Token = "0x60008D0")]
	public static SqlByte op_Implicit(byte x) { }

	[Address(RVA = "0x23763B0", Offset = "0x23757B0", Length = "0xC3")]
	[Token(Token = "0x60008D8")]
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x2376480", Offset = "0x2375880", Length = "0x127")]
	[Token(Token = "0x60008D4")]
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x23765B0", Offset = "0x23759B0", Length = "0x126")]
	[Token(Token = "0x60008D3")]
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008E2")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x2375950", Offset = "0x2374D50", Length = "0x11D")]
	[Token(Token = "0x60008E3")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2375A70", Offset = "0x2374E70", Length = "0x116")]
	[Token(Token = "0x60008E4")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x2375B90", Offset = "0x2374F90", Length = "0x68")]
	[Token(Token = "0x60008DC")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x2375C00", Offset = "0x2375000", Length = "0x68")]
	[Token(Token = "0x60008DD")]
	public SqlInt64 ToSqlInt64() { }

	[Address(RVA = "0x2375C70", Offset = "0x2375070", Length = "0x7B")]
	[Token(Token = "0x60008D1")]
	public virtual string ToString() { }

}

