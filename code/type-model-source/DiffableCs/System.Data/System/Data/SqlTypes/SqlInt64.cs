namespace System.Data.SqlTypes;

[Token(Token = "0x20000B4")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003DD")]
	private static readonly long s_lLowIntMask; //Field offset: 0x0
	[Token(Token = "0x40003DE")]
	private static readonly long s_lHighIntMask; //Field offset: 0x8
	[Token(Token = "0x40003DF")]
	public static readonly SqlInt64 Null; //Field offset: 0x10
	[Token(Token = "0x40003E0")]
	public static readonly SqlInt64 Zero; //Field offset: 0x20
	[Token(Token = "0x40003E1")]
	public static readonly SqlInt64 MinValue; //Field offset: 0x30
	[Token(Token = "0x40003E2")]
	public static readonly SqlInt64 MaxValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003DB")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003DC")]
	private long m_value; //Field offset: 0x8

	[Token(Token = "0x17000175")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60009DE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000176")]
	public long Value
	{
		[Address(RVA = "0x239DB70", Offset = "0x239CF70", Length = "0x54")]
		[Token(Token = "0x60009DF")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x239DA80", Offset = "0x239CE80", Length = "0xF0")]
	[Token(Token = "0x60009FF")]
	private static SqlInt64() { }

	[Address(RVA = "0x2397850", Offset = "0x2396C50", Length = "0xC")]
	[Token(Token = "0x60009DC")]
	private SqlInt64(bool fNull) { }

	[Address(RVA = "0xDA86E0", Offset = "0xDA7AE0", Length = "0x8")]
	[Token(Token = "0x60009DD")]
	public SqlInt64(long value) { }

	[Address(RVA = "0x239C940", Offset = "0x239BD40", Length = "0x229")]
	[Token(Token = "0x60009F8")]
	public int CompareTo(SqlInt64 value) { }

	[Address(RVA = "0x239CB70", Offset = "0x239BF70", Length = "0x121")]
	[Token(Token = "0x60009F7")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x239CCA0", Offset = "0x239C0A0", Length = "0x225")]
	[Token(Token = "0x60009F9")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x60009DE")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x239DB70", Offset = "0x239CF70", Length = "0x54")]
	[Token(Token = "0x60009DF")]
	public long get_Value() { }

	[Address(RVA = "0x239CED0", Offset = "0x239C2D0", Length = "0xBD")]
	[Token(Token = "0x60009FA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x239CF90", Offset = "0x239C390", Length = "0x6B")]
	[Token(Token = "0x60009FE")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x239D000", Offset = "0x239C400", Length = "0xFF")]
	[Token(Token = "0x60009F1")]
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239D100", Offset = "0x239C500", Length = "0xFF")]
	[Token(Token = "0x60009F0")]
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239DBD0", Offset = "0x239CFD0", Length = "0x167")]
	[Token(Token = "0x60009E3")]
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239DD40", Offset = "0x239D140", Length = "0x187")]
	[Token(Token = "0x60009E6")]
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239DED0", Offset = "0x239D2D0", Length = "0xCE")]
	[Token(Token = "0x60009ED")]
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239DFA0", Offset = "0x239D3A0", Length = "0x2A3")]
	[Token(Token = "0x60009EB")]
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	[Address(RVA = "0x239E250", Offset = "0x239D650", Length = "0xCE")]
	[Token(Token = "0x60009EF")]
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239E5C0", Offset = "0x239D9C0", Length = "0x11")]
	[Token(Token = "0x60009E0")]
	public static SqlInt64 op_Implicit(long x) { }

	[Address(RVA = "0x239E420", Offset = "0x239D820", Length = "0xC5")]
	[Token(Token = "0x60009E9")]
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x239E4F0", Offset = "0x239D8F0", Length = "0xCA")]
	[Token(Token = "0x60009E8")]
	public static SqlInt64 op_Implicit(SqlByte x) { }

	[Address(RVA = "0x239E320", Offset = "0x239D720", Length = "0xF7")]
	[Token(Token = "0x60009EA")]
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	[Address(RVA = "0x239E5E0", Offset = "0x239D9E0", Length = "0xCE")]
	[Token(Token = "0x60009EE")]
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239E6B0", Offset = "0x239DAB0", Length = "0x187")]
	[Token(Token = "0x60009E7")]
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239E840", Offset = "0x239DC40", Length = "0x32B")]
	[Token(Token = "0x60009E5")]
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239EB70", Offset = "0x239DF70", Length = "0x174")]
	[Token(Token = "0x60009E4")]
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	[Address(RVA = "0x239ECF0", Offset = "0x239E0F0", Length = "0xA6")]
	[Token(Token = "0x60009E2")]
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	[Address(RVA = "0x239D200", Offset = "0x239C600", Length = "0x11")]
	[Token(Token = "0x60009EC")]
	private static bool SameSignLong(long x, long y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009FB")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x239D220", Offset = "0x239C620", Length = "0x11E")]
	[Token(Token = "0x60009FC")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x239D340", Offset = "0x239C740", Length = "0x115")]
	[Token(Token = "0x60009FD")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x239D460", Offset = "0x239C860", Length = "0x5F")]
	[Token(Token = "0x60009F2")]
	public SqlByte ToSqlByte() { }

	[Address(RVA = "0x239D4C0", Offset = "0x239C8C0", Length = "0x11B")]
	[Token(Token = "0x60009F6")]
	public SqlDecimal ToSqlDecimal() { }

	[Address(RVA = "0x239D5E0", Offset = "0x239C9E0", Length = "0x170")]
	[Token(Token = "0x60009F3")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x239D760", Offset = "0x239CB60", Length = "0x157")]
	[Token(Token = "0x60009F4")]
	public SqlInt16 ToSqlInt16() { }

	[Address(RVA = "0x239D8C0", Offset = "0x239CCC0", Length = "0x15C")]
	[Token(Token = "0x60009F5")]
	public SqlInt32 ToSqlInt32() { }

	[Address(RVA = "0x239DA20", Offset = "0x239CE20", Length = "0x5E")]
	[Token(Token = "0x60009E1")]
	public virtual string ToString() { }

}

