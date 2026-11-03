namespace System.Data.SqlTypes;

[Token(Token = "0x20000B2")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003CE")]
	private static readonly int s_MASKI2; //Field offset: 0x0
	[Token(Token = "0x40003CF")]
	public static readonly SqlInt16 Null; //Field offset: 0x4
	[Token(Token = "0x40003D0")]
	public static readonly SqlInt16 Zero; //Field offset: 0x8
	[Token(Token = "0x40003D1")]
	public static readonly SqlInt16 MinValue; //Field offset: 0xC
	[Token(Token = "0x40003D2")]
	public static readonly SqlInt16 MaxValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CC")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40003CD")]
	private short m_value; //Field offset: 0x2

	[Token(Token = "0x17000171")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60009A2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000172")]
	public short Value
	{
		[Address(RVA = "0x239A500", Offset = "0x2399900", Length = "0x54")]
		[Token(Token = "0x60009A3")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x239A430", Offset = "0x2399830", Length = "0xB9")]
	[Token(Token = "0x60009BC")]
	private static SqlInt16() { }

	[Address(RVA = "0x239A4F0", Offset = "0x23998F0", Length = "0xA")]
	[Token(Token = "0x60009A0")]
	private SqlInt16(bool fNull) { }

	[Address(RVA = "0xDA8730", Offset = "0xDA7B30", Length = "0x8")]
	[Token(Token = "0x60009A1")]
	public SqlInt16(short value) { }

	[Address(RVA = "0x23999B0", Offset = "0x2398DB0", Length = "0x163")]
	[Token(Token = "0x60009B5")]
	public int CompareTo(SqlInt16 value) { }

	[Address(RVA = "0x23998A0", Offset = "0x2398CA0", Length = "0x10C")]
	[Token(Token = "0x60009B4")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2399B20", Offset = "0x2398F20", Length = "0x1F8")]
	[Token(Token = "0x60009B6")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x60009A2")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x239A500", Offset = "0x2399900", Length = "0x54")]
	[Token(Token = "0x60009A3")]
	public short get_Value() { }

	[Address(RVA = "0x2399D20", Offset = "0x2399120", Length = "0xBA")]
	[Token(Token = "0x60009B7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2399DE0", Offset = "0x23991E0", Length = "0x6B")]
	[Token(Token = "0x60009BB")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2399E50", Offset = "0x2399250", Length = "0x55")]
	[Token(Token = "0x60009B1")]
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x2399EB0", Offset = "0x23992B0", Length = "0x55")]
	[Token(Token = "0x60009B0")]
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239A560", Offset = "0x2399960", Length = "0x11E")]
	[Token(Token = "0x60009A7")]
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239A680", Offset = "0x2399A80", Length = "0x17D")]
	[Token(Token = "0x60009AA")]
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239A800", Offset = "0x2399C00", Length = "0xD5")]
	[Token(Token = "0x60009AD")]
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239A8E0", Offset = "0x2399CE0", Length = "0x150")]
	[Token(Token = "0x60009AC")]
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	[Address(RVA = "0x239AA30", Offset = "0x2399E30", Length = "0xD5")]
	[Token(Token = "0x60009AF")]
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239ABE0", Offset = "0x2399FE0", Length = "0x17")]
	[Token(Token = "0x60009A4")]
	public static SqlInt16 op_Implicit(short x) { }

	[Address(RVA = "0x239AB10", Offset = "0x2399F10", Length = "0xC3")]
	[Token(Token = "0x60009AB")]
	public static SqlInt16 op_Implicit(SqlByte x) { }

	[Address(RVA = "0x239AC00", Offset = "0x239A000", Length = "0xD5")]
	[Token(Token = "0x60009AE")]
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239ACE0", Offset = "0x239A0E0", Length = "0x150")]
	[Token(Token = "0x60009A9")]
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239AE40", Offset = "0x239A240", Length = "0x11E")]
	[Token(Token = "0x60009A8")]
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	[Address(RVA = "0x239AF60", Offset = "0x239A360", Length = "0x96")]
	[Token(Token = "0x60009A6")]
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009B8")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x2399F10", Offset = "0x2399310", Length = "0x11E")]
	[Token(Token = "0x60009B9")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x239A030", Offset = "0x2399430", Length = "0x115")]
	[Token(Token = "0x60009BA")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x239A150", Offset = "0x2399550", Length = "0x16F")]
	[Token(Token = "0x60009B2")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x239A2C0", Offset = "0x23996C0", Length = "0x103")]
	[Token(Token = "0x60009B3")]
	public SqlInt64 ToSqlInt64() { }

	[Address(RVA = "0x239A3D0", Offset = "0x23997D0", Length = "0x5E")]
	[Token(Token = "0x60009A5")]
	public virtual string ToString() { }

}

