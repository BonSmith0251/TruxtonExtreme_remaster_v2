namespace System.Data.SqlTypes;

[Token(Token = "0x20000B5")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlMoney : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003E5")]
	internal static readonly int s_iMoneyScale; //Field offset: 0x0
	[Token(Token = "0x40003E6")]
	private static readonly long s_lTickBase; //Field offset: 0x8
	[Token(Token = "0x40003E7")]
	private static readonly double s_dTickBase; //Field offset: 0x10
	[Token(Token = "0x40003E8")]
	private static readonly long s_minLong; //Field offset: 0x18
	[Token(Token = "0x40003E9")]
	private static readonly long s_maxLong; //Field offset: 0x20
	[Token(Token = "0x40003EA")]
	public static readonly SqlMoney Null; //Field offset: 0x28
	[Token(Token = "0x40003EB")]
	public static readonly SqlMoney Zero; //Field offset: 0x38
	[Token(Token = "0x40003EC")]
	public static readonly SqlMoney MinValue; //Field offset: 0x48
	[Token(Token = "0x40003ED")]
	public static readonly SqlMoney MaxValue; //Field offset: 0x58
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E3")]
	private bool _fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003E4")]
	private long _value; //Field offset: 0x8

	[Token(Token = "0x17000177")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x6000A05")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000178")]
	public decimal Value
	{
		[Address(RVA = "0x23A0350", Offset = "0x239F750", Length = "0xA2")]
		[Token(Token = "0x6000A06")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x239FE70", Offset = "0x239F270", Length = "0x178")]
	[Token(Token = "0x6000A25")]
	private static SqlMoney() { }

	[Address(RVA = "0x23A0160", Offset = "0x239F560", Length = "0x1E1")]
	[Token(Token = "0x6000A04")]
	public SqlMoney(decimal value) { }

	[Address(RVA = "0x239FFF0", Offset = "0x239F3F0", Length = "0xF0")]
	[Token(Token = "0x6000A03")]
	public SqlMoney(long value) { }

	[Address(RVA = "0x2397850", Offset = "0x2396C50", Length = "0xC")]
	[Token(Token = "0x6000A00")]
	private SqlMoney(bool fNull) { }

	[Address(RVA = "0xDA86E0", Offset = "0xDA7AE0", Length = "0x8")]
	[Token(Token = "0x6000A01")]
	internal SqlMoney(long value, int ignored) { }

	[Address(RVA = "0x23A00F0", Offset = "0x239F4F0", Length = "0x69")]
	[Token(Token = "0x6000A02")]
	public SqlMoney(int value) { }

	[Address(RVA = "0x239EDA0", Offset = "0x239E1A0", Length = "0x229")]
	[Token(Token = "0x6000A1E")]
	public int CompareTo(SqlMoney value) { }

	[Address(RVA = "0x239EFD0", Offset = "0x239E3D0", Length = "0x121")]
	[Token(Token = "0x6000A1D")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x239F100", Offset = "0x239E500", Length = "0x225")]
	[Token(Token = "0x6000A1F")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x6000A05")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x23A0350", Offset = "0x239F750", Length = "0xA2")]
	[Token(Token = "0x6000A06")]
	public decimal get_Value() { }

	[Address(RVA = "0x239F330", Offset = "0x239E730", Length = "0x57")]
	[Token(Token = "0x6000A20")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x239F390", Offset = "0x239E790", Length = "0x6B")]
	[Token(Token = "0x6000A24")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x239F400", Offset = "0x239E800", Length = "0xFF")]
	[Token(Token = "0x6000A1A")]
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x239F500", Offset = "0x239E900", Length = "0xFF")]
	[Token(Token = "0x6000A19")]
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A0400", Offset = "0x239F800", Length = "0x18B")]
	[Token(Token = "0x6000A0D")]
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A0590", Offset = "0x239F990", Length = "0x168")]
	[Token(Token = "0x6000A10")]
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A0700", Offset = "0x239FB00", Length = "0xCE")]
	[Token(Token = "0x6000A16")]
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A07D0", Offset = "0x239FBD0", Length = "0x16C")]
	[Token(Token = "0x6000A15")]
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	[Address(RVA = "0x23A0940", Offset = "0x239FD40", Length = "0xCE")]
	[Token(Token = "0x6000A18")]
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A0D30", Offset = "0x23A0130", Length = "0x102")]
	[Token(Token = "0x6000A14")]
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	[Address(RVA = "0x23A0C10", Offset = "0x23A0010", Length = "0xCE")]
	[Token(Token = "0x6000A11")]
	public static SqlMoney op_Implicit(SqlByte x) { }

	[Address(RVA = "0x23A0AE0", Offset = "0x239FEE0", Length = "0x2D")]
	[Token(Token = "0x6000A09")]
	public static SqlMoney op_Implicit(decimal x) { }

	[Address(RVA = "0x23A0B10", Offset = "0x239FF10", Length = "0xFA")]
	[Token(Token = "0x6000A13")]
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	[Address(RVA = "0x23A0CE0", Offset = "0x23A00E0", Length = "0x48")]
	[Token(Token = "0x6000A0A")]
	public static SqlMoney op_Implicit(long x) { }

	[Address(RVA = "0x23A0A10", Offset = "0x239FE10", Length = "0xC8")]
	[Token(Token = "0x6000A12")]
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x23A0E40", Offset = "0x23A0240", Length = "0xCE")]
	[Token(Token = "0x6000A17")]
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A0F10", Offset = "0x23A0310", Length = "0x168")]
	[Token(Token = "0x6000A0F")]
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A1080", Offset = "0x23A0480", Length = "0x187")]
	[Token(Token = "0x6000A0E")]
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	[Address(RVA = "0x23A1210", Offset = "0x23A0610", Length = "0x11F")]
	[Token(Token = "0x6000A0C")]
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A21")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x239F600", Offset = "0x239EA00", Length = "0x17B")]
	[Token(Token = "0x6000A22")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x239F780", Offset = "0x239EB80", Length = "0x14B")]
	[Token(Token = "0x6000A23")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x239F8D0", Offset = "0x239ECD0", Length = "0x10F")]
	[Token(Token = "0x6000A07")]
	public decimal ToDecimal() { }

	[Address(RVA = "0x239F9E0", Offset = "0x239EDE0", Length = "0x90")]
	[Token(Token = "0x6000A08")]
	public double ToDouble() { }

	[Address(RVA = "0x239FA70", Offset = "0x239EE70", Length = "0x13A")]
	[Token(Token = "0x6000A1C")]
	public SqlDecimal ToSqlDecimal() { }

	[Address(RVA = "0x239FBB0", Offset = "0x239EFB0", Length = "0x1E3")]
	[Token(Token = "0x6000A1B")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x239FDA0", Offset = "0x239F1A0", Length = "0xCB")]
	[Token(Token = "0x6000A0B")]
	public virtual string ToString() { }

}

