namespace System.Data.SqlTypes;

[Token(Token = "0x20000B3")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003D5")]
	private static readonly long s_iIntMin; //Field offset: 0x0
	[Token(Token = "0x40003D6")]
	private static readonly long s_lBitNotIntMax; //Field offset: 0x8
	[Token(Token = "0x40003D7")]
	public static readonly SqlInt32 Null; //Field offset: 0x10
	[Token(Token = "0x40003D8")]
	public static readonly SqlInt32 Zero; //Field offset: 0x18
	[Token(Token = "0x40003D9")]
	public static readonly SqlInt32 MinValue; //Field offset: 0x20
	[Token(Token = "0x40003DA")]
	public static readonly SqlInt32 MaxValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003D3")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003D4")]
	private int m_value; //Field offset: 0x4

	[Token(Token = "0x17000173")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60009BF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000174")]
	public int Value
	{
		[Address(RVA = "0x239BCC0", Offset = "0x239B0C0", Length = "0x80")]
		[Token(Token = "0x60009C0")]
		 get { } //Length: 128
	}

	[Address(RVA = "0x239BBD0", Offset = "0x239AFD0", Length = "0xD7")]
	[Token(Token = "0x60009DB")]
	private static SqlInt32() { }

	[Address(RVA = "0x239BCB0", Offset = "0x239B0B0", Length = "0xB")]
	[Token(Token = "0x60009BD")]
	private SqlInt32(bool fNull) { }

	[Address(RVA = "0xDA8670", Offset = "0xDA7A70", Length = "0x7")]
	[Token(Token = "0x60009BE")]
	public SqlInt32(int value) { }

	[Address(RVA = "0x239B000", Offset = "0x239A400", Length = "0x16A")]
	[Token(Token = "0x60009D4")]
	public int CompareTo(SqlInt32 value) { }

	[Address(RVA = "0x239B170", Offset = "0x239A570", Length = "0x10E")]
	[Token(Token = "0x60009D3")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x239B280", Offset = "0x239A680", Length = "0x1FA")]
	[Token(Token = "0x60009D5")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x60009BF")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x239BCC0", Offset = "0x239B0C0", Length = "0x80")]
	[Token(Token = "0x60009C0")]
	public int get_Value() { }

	[Address(RVA = "0x239B480", Offset = "0x239A880", Length = "0x84")]
	[Token(Token = "0x60009D6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x239B510", Offset = "0x239A910", Length = "0x6B")]
	[Token(Token = "0x60009DA")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x239B580", Offset = "0x239A980", Length = "0x59")]
	[Token(Token = "0x60009D0")]
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239B5E0", Offset = "0x239A9E0", Length = "0x59")]
	[Token(Token = "0x60009CF")]
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239BD50", Offset = "0x239B150", Length = "0x156")]
	[Token(Token = "0x60009C4")]
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239BEB0", Offset = "0x239B2B0", Length = "0x19A")]
	[Token(Token = "0x60009C7")]
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C050", Offset = "0x239B450", Length = "0xD7")]
	[Token(Token = "0x60009CC")]
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C130", Offset = "0x239B530", Length = "0x155")]
	[Token(Token = "0x60009CA")]
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	[Address(RVA = "0x239C290", Offset = "0x239B690", Length = "0xD7")]
	[Token(Token = "0x60009CE")]
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C460", Offset = "0x239B860", Length = "0xB3")]
	[Token(Token = "0x60009C9")]
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x239C370", Offset = "0x239B770", Length = "0xC5")]
	[Token(Token = "0x60009C8")]
	public static SqlInt32 op_Implicit(SqlByte x) { }

	[Address(RVA = "0x239C440", Offset = "0x239B840", Length = "0x18")]
	[Token(Token = "0x60009C1")]
	public static SqlInt32 op_Implicit(int x) { }

	[Address(RVA = "0x239C520", Offset = "0x239B920", Length = "0xD7")]
	[Token(Token = "0x60009CD")]
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C600", Offset = "0x239BA00", Length = "0x15C")]
	[Token(Token = "0x60009C6")]
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C760", Offset = "0x239BB60", Length = "0x13C")]
	[Token(Token = "0x60009C5")]
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	[Address(RVA = "0x239C8A0", Offset = "0x239BCA0", Length = "0x98")]
	[Token(Token = "0x60009C3")]
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	[Address(RVA = "0x239B640", Offset = "0x239AA40", Length = "0xE")]
	[Token(Token = "0x60009CB")]
	private static bool SameSignInt(int x, int y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009D7")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x239B650", Offset = "0x239AA50", Length = "0x11D")]
	[Token(Token = "0x60009D8")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x239B770", Offset = "0x239AB70", Length = "0x113")]
	[Token(Token = "0x60009D9")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x239B890", Offset = "0x239AC90", Length = "0x19F")]
	[Token(Token = "0x60009D1")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x239BA30", Offset = "0x239AE30", Length = "0x135")]
	[Token(Token = "0x60009D2")]
	public SqlInt64 ToSqlInt64() { }

	[Address(RVA = "0x239BB70", Offset = "0x239AF70", Length = "0x5E")]
	[Token(Token = "0x60009C2")]
	public virtual string ToString() { }

}

