namespace System.Data.SqlTypes;

[Token(Token = "0x20000B6")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlSingle : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003F0")]
	public static readonly SqlSingle Null; //Field offset: 0x0
	[Token(Token = "0x40003F1")]
	public static readonly SqlSingle Zero; //Field offset: 0x8
	[Token(Token = "0x40003F2")]
	public static readonly SqlSingle MinValue; //Field offset: 0x10
	[Token(Token = "0x40003F3")]
	public static readonly SqlSingle MaxValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EE")]
	private bool _fNotNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003EF")]
	private float _value; //Field offset: 0x4

	[Token(Token = "0x17000179")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x6000A29")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700017A")]
	public float Value
	{
		[Address(RVA = "0x23A2300", Offset = "0x23A1700", Length = "0x55")]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x23A2030", Offset = "0x23A1430", Length = "0x1E1")]
	[Token(Token = "0x6000A47")]
	private static SqlSingle() { }

	[Address(RVA = "0x23A2220", Offset = "0x23A1620", Length = "0x5E")]
	[Token(Token = "0x6000A28")]
	public SqlSingle(double value) { }

	[Address(RVA = "0x239BCB0", Offset = "0x239B0B0", Length = "0xB")]
	[Token(Token = "0x6000A26")]
	private SqlSingle(bool fNull) { }

	[Address(RVA = "0x23A2280", Offset = "0x23A1680", Length = "0x7A")]
	[Token(Token = "0x6000A27")]
	public SqlSingle(float value) { }

	[Address(RVA = "0x23A1590", Offset = "0x23A0990", Length = "0x16A")]
	[Token(Token = "0x6000A40")]
	public int CompareTo(SqlSingle value) { }

	[Address(RVA = "0x23A1700", Offset = "0x23A0B00", Length = "0x10E")]
	[Token(Token = "0x6000A3F")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x23A1810", Offset = "0x23A0C10", Length = "0x205")]
	[Token(Token = "0x6000A41")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x6000A29")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x23A2300", Offset = "0x23A1700", Length = "0x55")]
	[Token(Token = "0x6000A2A")]
	public float get_Value() { }

	[Address(RVA = "0x23A1A20", Offset = "0x23A0E20", Length = "0xBE")]
	[Token(Token = "0x6000A42")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23A1AE0", Offset = "0x23A0EE0", Length = "0x6B")]
	[Token(Token = "0x6000A46")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x23A1B50", Offset = "0x23A0F50", Length = "0x59")]
	[Token(Token = "0x6000A3D")]
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A1BB0", Offset = "0x23A0FB0", Length = "0x59")]
	[Token(Token = "0x6000A3C")]
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A2360", Offset = "0x23A1760", Length = "0x182")]
	[Token(Token = "0x6000A2E")]
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A24F0", Offset = "0x23A18F0", Length = "0x183")]
	[Token(Token = "0x6000A31")]
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A2680", Offset = "0x23A1A80", Length = "0xFC")]
	[Token(Token = "0x6000A39")]
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A2780", Offset = "0x23A1B80", Length = "0x188")]
	[Token(Token = "0x6000A38")]
	public static SqlSingle op_Explicit(SqlDouble x) { }

	[Address(RVA = "0x23A2910", Offset = "0x23A1D10", Length = "0xDA")]
	[Token(Token = "0x6000A3B")]
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A2B50", Offset = "0x23A1F50", Length = "0x1AA")]
	[Token(Token = "0x6000A37")]
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	[Address(RVA = "0x23A30C0", Offset = "0x23A24C0", Length = "0x8B")]
	[Token(Token = "0x6000A2B")]
	public static SqlSingle op_Implicit(float x) { }

	[Address(RVA = "0x23A2D00", Offset = "0x23A2100", Length = "0x157")]
	[Token(Token = "0x6000A35")]
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	[Address(RVA = "0x23A2F80", Offset = "0x23A2380", Length = "0x136")]
	[Token(Token = "0x6000A32")]
	public static SqlSingle op_Implicit(SqlByte x) { }

	[Address(RVA = "0x23A29F0", Offset = "0x23A1DF0", Length = "0x15C")]
	[Token(Token = "0x6000A36")]
	public static SqlSingle op_Implicit(SqlMoney x) { }

	[Address(RVA = "0x23A2E60", Offset = "0x23A2260", Length = "0x11A")]
	[Token(Token = "0x6000A33")]
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x23A3150", Offset = "0x23A2550", Length = "0x14A")]
	[Token(Token = "0x6000A34")]
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	[Address(RVA = "0x23A32A0", Offset = "0x23A26A0", Length = "0xDA")]
	[Token(Token = "0x6000A3A")]
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A3380", Offset = "0x23A2780", Length = "0x182")]
	[Token(Token = "0x6000A30")]
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A3510", Offset = "0x23A2910", Length = "0x182")]
	[Token(Token = "0x6000A2F")]
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	[Address(RVA = "0x23A36A0", Offset = "0x23A2AA0", Length = "0xFF")]
	[Token(Token = "0x6000A2D")]
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A43")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x23A1C10", Offset = "0x23A1010", Length = "0x11F")]
	[Token(Token = "0x6000A44")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x23A1D30", Offset = "0x23A1130", Length = "0x120")]
	[Token(Token = "0x6000A45")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x23A1E60", Offset = "0x23A1260", Length = "0x16D")]
	[Token(Token = "0x6000A3E")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x23A1FD0", Offset = "0x23A13D0", Length = "0x5E")]
	[Token(Token = "0x6000A2C")]
	public virtual string ToString() { }

}

