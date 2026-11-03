namespace System.Data.SqlTypes;

[Token(Token = "0x20000B8")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlString : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x4000401")]
	public static readonly SqlString Null; //Field offset: 0x0
	[Token(Token = "0x4000402")]
	internal static readonly UnicodeEncoding s_unicodeEncoding; //Field offset: 0x20
	[Token(Token = "0x4000403")]
	public static readonly int IgnoreCase; //Field offset: 0x28
	[Token(Token = "0x4000404")]
	public static readonly int IgnoreWidth; //Field offset: 0x2C
	[Token(Token = "0x4000405")]
	public static readonly int IgnoreNonSpace; //Field offset: 0x30
	[Token(Token = "0x4000406")]
	public static readonly int IgnoreKanaType; //Field offset: 0x34
	[Token(Token = "0x4000407")]
	public static readonly int BinarySort; //Field offset: 0x38
	[Token(Token = "0x4000408")]
	public static readonly int BinarySort2; //Field offset: 0x3C
	[Token(Token = "0x4000409")]
	private static readonly SqlCompareOptions s_iDefaultFlag; //Field offset: 0x40
	[Token(Token = "0x400040A")]
	private static readonly CompareOptions s_iValidCompareOptionMask; //Field offset: 0x44
	[Token(Token = "0x400040B")]
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; //Field offset: 0x48
	[Token(Token = "0x400040C")]
	internal static readonly int s_lcidUSEnglish; //Field offset: 0x4C
	[Token(Token = "0x400040D")]
	private static readonly int s_lcidBinary; //Field offset: 0x50
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003FC")]
	private string m_value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003FD")]
	private CompareInfo m_cmpInfo; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003FE")]
	private int m_lcid; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003FF")]
	private SqlCompareOptions m_flag; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000400")]
	private bool m_fNotNull; //Field offset: 0x18

	[Token(Token = "0x1700017B")]
	public override bool IsNull
	{
		[Address(RVA = "0x23A52E0", Offset = "0x23A46E0", Length = "0x8")]
		[Token(Token = "0x6000A4C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700017C")]
	public string Value
	{
		[Address(RVA = "0x23A52F0", Offset = "0x23A46F0", Length = "0x81")]
		[Token(Token = "0x6000A4D")]
		 get { } //Length: 129
	}

	[Address(RVA = "0x23A4E20", Offset = "0x23A4220", Length = "0x1CF")]
	[Token(Token = "0x6000A62")]
	private static SqlString() { }

	[Address(RVA = "0x23A51E0", Offset = "0x23A45E0", Length = "0xBE")]
	[Token(Token = "0x6000A4B")]
	private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	[Address(RVA = "0x23A52A0", Offset = "0x23A46A0", Length = "0x3B")]
	[Token(Token = "0x6000A48")]
	private SqlString(bool fNull) { }

	[Address(RVA = "0x23A4FF0", Offset = "0x23A43F0", Length = "0xA7")]
	[Token(Token = "0x6000A49")]
	public SqlString(string data, int lcid, SqlCompareOptions compareOptions) { }

	[Address(RVA = "0x23A50A0", Offset = "0x23A44A0", Length = "0x135")]
	[Token(Token = "0x6000A4A")]
	public SqlString(string data) { }

	[Address(RVA = "0x23A3E70", Offset = "0x23A3270", Length = "0x168")]
	[Token(Token = "0x6000A53")]
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	[Address(RVA = "0x23A3900", Offset = "0x23A2D00", Length = "0x22D")]
	[Token(Token = "0x6000A58")]
	private static int CompareBinary(SqlString x, SqlString y) { }

	[Address(RVA = "0x23A37A0", Offset = "0x23A2BA0", Length = "0x15C")]
	[Token(Token = "0x6000A59")]
	private static int CompareBinary2(SqlString x, SqlString y) { }

	[Address(RVA = "0x23A3B30", Offset = "0x23A2F30", Length = "0xBA")]
	[Token(Token = "0x6000A56")]
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	[Address(RVA = "0x23A3D30", Offset = "0x23A3130", Length = "0x136")]
	[Token(Token = "0x6000A5B")]
	public int CompareTo(SqlString value) { }

	[Address(RVA = "0x23A3BF0", Offset = "0x23A2FF0", Length = "0x137")]
	[Token(Token = "0x6000A5A")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x23A3FE0", Offset = "0x23A33E0", Length = "0x311")]
	[Token(Token = "0x6000A5C")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x23A4300", Offset = "0x23A3700", Length = "0x58")]
	[Token(Token = "0x6000A57")]
	private bool FBinarySort() { }

	[Address(RVA = "0x23A52E0", Offset = "0x23A46E0", Length = "0x8")]
	[Token(Token = "0x6000A4C")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x23A52F0", Offset = "0x23A46F0", Length = "0x81")]
	[Token(Token = "0x6000A4D")]
	public string get_Value() { }

	[Address(RVA = "0x23A4360", Offset = "0x23A3760", Length = "0x23A")]
	[Token(Token = "0x6000A5D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23A45A0", Offset = "0x23A39A0", Length = "0x6B")]
	[Token(Token = "0x6000A61")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x23A5380", Offset = "0x23A4780", Length = "0x19D")]
	[Token(Token = "0x6000A51")]
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	[Address(RVA = "0x23A5520", Offset = "0x23A4920", Length = "0x158")]
	[Token(Token = "0x6000A54")]
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	[Address(RVA = "0x23A5680", Offset = "0x23A4A80", Length = "0x24")]
	[Token(Token = "0x6000A4F")]
	public static SqlString op_Implicit(string x) { }

	[Address(RVA = "0x23A4610", Offset = "0x23A3A10", Length = "0x93")]
	[Token(Token = "0x6000A4E")]
	private void SetCompareInfo() { }

	[Address(RVA = "0x23A46B0", Offset = "0x23A3AB0", Length = "0x46A")]
	[Token(Token = "0x6000A52")]
	private static int StringCompare(SqlString x, SqlString y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A5E")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x23A4B20", Offset = "0x23A3F20", Length = "0x108")]
	[Token(Token = "0x6000A5F")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x23A4C30", Offset = "0x23A4030", Length = "0xDF")]
	[Token(Token = "0x6000A60")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x23A4D10", Offset = "0x23A4110", Length = "0x55")]
	[Token(Token = "0x6000A50")]
	public virtual string ToString() { }

	[Address(RVA = "0x23A4D70", Offset = "0x23A4170", Length = "0xA1")]
	[Token(Token = "0x6000A55")]
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

}

