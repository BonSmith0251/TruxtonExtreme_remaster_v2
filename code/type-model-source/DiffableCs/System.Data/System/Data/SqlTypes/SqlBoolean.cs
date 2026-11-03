namespace System.Data.SqlTypes;

[Token(Token = "0x20000A9")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x400034F")]
	public static readonly SqlBoolean True; //Field offset: 0x0
	[Token(Token = "0x4000350")]
	public static readonly SqlBoolean False; //Field offset: 0x1
	[Token(Token = "0x4000351")]
	public static readonly SqlBoolean Null; //Field offset: 0x2
	[Token(Token = "0x4000352")]
	public static readonly SqlBoolean Zero; //Field offset: 0x3
	[Token(Token = "0x4000353")]
	public static readonly SqlBoolean One; //Field offset: 0x4
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034E")]
	private byte m_value; //Field offset: 0x0

	[Token(Token = "0x17000157")]
	public byte ByteValue
	{
		[Address(RVA = "0x2374E80", Offset = "0x2374280", Length = "0x83")]
		[Token(Token = "0x60008BE")]
		 get { } //Length: 131
	}

	[Token(Token = "0x17000156")]
	public bool IsFalse
	{
		[Address(RVA = "0x2374F10", Offset = "0x2374310", Length = "0x7")]
		[Token(Token = "0x60008B9")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000153")]
	public override bool IsNull
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000155")]
	public bool IsTrue
	{
		[Address(RVA = "0x2374F30", Offset = "0x2374330", Length = "0x7")]
		[Token(Token = "0x60008B8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000154")]
	public bool Value
	{
		[Address(RVA = "0x2374F40", Offset = "0x2374340", Length = "0x5F")]
		[Token(Token = "0x60008B7")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x2374D00", Offset = "0x2374100", Length = "0xEB")]
	[Token(Token = "0x60008CB")]
	private static SqlBoolean() { }

	[Address(RVA = "0x2374E50", Offset = "0x2374250", Length = "0x13")]
	[Token(Token = "0x60008B5")]
	private SqlBoolean(int value, bool fNull) { }

	[Address(RVA = "0x2374E70", Offset = "0x2374270", Length = "0x7")]
	[Token(Token = "0x60008B3")]
	public SqlBoolean(bool value) { }

	[Address(RVA = "0x2374DF0", Offset = "0x23741F0", Length = "0x54")]
	[Token(Token = "0x60008B4")]
	public SqlBoolean(int value) { }

	[Address(RVA = "0x2374280", Offset = "0x2373680", Length = "0x10D")]
	[Token(Token = "0x60008C1")]
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	[Address(RVA = "0x2374390", Offset = "0x2373790", Length = "0x115")]
	[Token(Token = "0x60008C4")]
	public int CompareTo(SqlBoolean value) { }

	[Address(RVA = "0x23744B0", Offset = "0x23738B0", Length = "0x10E")]
	[Token(Token = "0x60008C3")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x23745C0", Offset = "0x23739C0", Length = "0x1A6")]
	[Token(Token = "0x60008C5")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2374E80", Offset = "0x2374280", Length = "0x83")]
	[Token(Token = "0x60008BE")]
	public byte get_ByteValue() { }

	[Address(RVA = "0x2374F10", Offset = "0x2374310", Length = "0x7")]
	[Token(Token = "0x60008B9")]
	public bool get_IsFalse() { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x60008B6")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2374F30", Offset = "0x2374330", Length = "0x7")]
	[Token(Token = "0x60008B8")]
	public bool get_IsTrue() { }

	[Address(RVA = "0x2374F40", Offset = "0x2374340", Length = "0x5F")]
	[Token(Token = "0x60008B7")]
	public bool get_Value() { }

	[Address(RVA = "0x2374770", Offset = "0x2373B70", Length = "0xD5")]
	[Token(Token = "0x60008C6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2374850", Offset = "0x2373C50", Length = "0x6B")]
	[Token(Token = "0x60008CA")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2374FA0", Offset = "0x23743A0", Length = "0xE0")]
	[Token(Token = "0x60008BC")]
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	[Address(RVA = "0x2375080", Offset = "0x2374480", Length = "0xE0")]
	[Token(Token = "0x60008BD")]
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	[Address(RVA = "0x2375160", Offset = "0x2374560", Length = "0xAD")]
	[Token(Token = "0x60008C0")]
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	[Address(RVA = "0x2375210", Offset = "0x2374610", Length = "0x6")]
	[Token(Token = "0x60008BA")]
	public static SqlBoolean op_Implicit(bool x) { }

	[Address(RVA = "0x2375220", Offset = "0x2374620", Length = "0x46")]
	[Token(Token = "0x60008BB")]
	public static bool op_True(SqlBoolean x) { }

	[Address(RVA = "0x23748C0", Offset = "0x2373CC0", Length = "0x10D")]
	[Token(Token = "0x60008C2")]
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008C7")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x23749D0", Offset = "0x2373DD0", Length = "0x11B")]
	[Token(Token = "0x60008C8")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2374AF0", Offset = "0x2373EF0", Length = "0x101")]
	[Token(Token = "0x60008C9")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x2374C00", Offset = "0x2374000", Length = "0xF6")]
	[Token(Token = "0x60008BF")]
	public virtual string ToString() { }

}

