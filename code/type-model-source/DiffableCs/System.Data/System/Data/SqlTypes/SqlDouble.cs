namespace System.Data.SqlTypes;

[Token(Token = "0x20000B0")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDouble : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003C4")]
	public static readonly SqlDouble Null; //Field offset: 0x0
	[Token(Token = "0x40003C5")]
	public static readonly SqlDouble Zero; //Field offset: 0x10
	[Token(Token = "0x40003C6")]
	public static readonly SqlDouble MinValue; //Field offset: 0x20
	[Token(Token = "0x40003C7")]
	public static readonly SqlDouble MaxValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003C2")]
	private bool m_fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003C3")]
	private double m_value; //Field offset: 0x8

	[Token(Token = "0x1700016D")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x600096E")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700016E")]
	public double Value
	{
		[Address(RVA = "0x2397860", Offset = "0x2396C60", Length = "0x55")]
		[Token(Token = "0x600096F")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x23975B0", Offset = "0x23969B0", Length = "0x202")]
	[Token(Token = "0x600098C")]
	private static SqlDouble() { }

	[Address(RVA = "0x2397850", Offset = "0x2396C50", Length = "0xC")]
	[Token(Token = "0x600096C")]
	private SqlDouble(bool fNull) { }

	[Address(RVA = "0x23977C0", Offset = "0x2396BC0", Length = "0x8C")]
	[Token(Token = "0x600096D")]
	public SqlDouble(double value) { }

	[Address(RVA = "0x2396990", Offset = "0x2395D90", Length = "0x228")]
	[Token(Token = "0x6000985")]
	public int CompareTo(SqlDouble value) { }

	[Address(RVA = "0x2396860", Offset = "0x2395C60", Length = "0x121")]
	[Token(Token = "0x6000984")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2396BC0", Offset = "0x2395FC0", Length = "0x22E")]
	[Token(Token = "0x6000986")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x600096E")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2397860", Offset = "0x2396C60", Length = "0x55")]
	[Token(Token = "0x600096F")]
	public double get_Value() { }

	[Address(RVA = "0x2396DF0", Offset = "0x23961F0", Length = "0xCF")]
	[Token(Token = "0x6000987")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2396EC0", Offset = "0x23962C0", Length = "0x6B")]
	[Token(Token = "0x600098B")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2396F30", Offset = "0x2396330", Length = "0x118")]
	[Token(Token = "0x6000982")]
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2397050", Offset = "0x2396450", Length = "0x118")]
	[Token(Token = "0x6000981")]
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x23978C0", Offset = "0x2396CC0", Length = "0x142")]
	[Token(Token = "0x6000973")]
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2397A10", Offset = "0x2396E10", Length = "0x1A2")]
	[Token(Token = "0x6000976")]
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2397BC0", Offset = "0x2396FC0", Length = "0xF2")]
	[Token(Token = "0x600097E")]
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2397CC0", Offset = "0x23970C0", Length = "0xD0")]
	[Token(Token = "0x6000980")]
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2397EA0", Offset = "0x23972A0", Length = "0x11E")]
	[Token(Token = "0x600097D")]
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	[Address(RVA = "0x2397D90", Offset = "0x2397190", Length = "0x106")]
	[Token(Token = "0x600097A")]
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	[Address(RVA = "0x23980B0", Offset = "0x23974B0", Length = "0xFF")]
	[Token(Token = "0x6000979")]
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	[Address(RVA = "0x2398280", Offset = "0x2397680", Length = "0xCF")]
	[Token(Token = "0x6000978")]
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x2398350", Offset = "0x2397750", Length = "0xD5")]
	[Token(Token = "0x6000977")]
	public static SqlDouble op_Implicit(SqlByte x) { }

	[Address(RVA = "0x2398090", Offset = "0x2397490", Length = "0x20")]
	[Token(Token = "0x6000970")]
	public static SqlDouble op_Implicit(double x) { }

	[Address(RVA = "0x23981B0", Offset = "0x23975B0", Length = "0xCD")]
	[Token(Token = "0x600097B")]
	public static SqlDouble op_Implicit(SqlSingle x) { }

	[Address(RVA = "0x2397FC0", Offset = "0x23973C0", Length = "0xCD")]
	[Token(Token = "0x600097C")]
	public static SqlDouble op_Implicit(SqlMoney x) { }

	[Address(RVA = "0x2398430", Offset = "0x2397830", Length = "0xD0")]
	[Token(Token = "0x600097F")]
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2398500", Offset = "0x2397900", Length = "0x142")]
	[Token(Token = "0x6000975")]
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x2398650", Offset = "0x2397A50", Length = "0x142")]
	[Token(Token = "0x6000974")]
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	[Address(RVA = "0x23987A0", Offset = "0x2397BA0", Length = "0xAE")]
	[Token(Token = "0x6000972")]
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000988")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x2397170", Offset = "0x2396570", Length = "0x11F")]
	[Token(Token = "0x6000989")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2397290", Offset = "0x2396690", Length = "0x120")]
	[Token(Token = "0x600098A")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x23973C0", Offset = "0x23967C0", Length = "0x18C")]
	[Token(Token = "0x6000983")]
	public SqlSingle ToSqlSingle() { }

	[Address(RVA = "0x2397550", Offset = "0x2396950", Length = "0x5E")]
	[Token(Token = "0x6000971")]
	public virtual string ToString() { }

}

