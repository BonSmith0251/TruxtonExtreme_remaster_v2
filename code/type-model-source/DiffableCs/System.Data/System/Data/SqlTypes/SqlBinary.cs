namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[Token(Token = "0x20000A8")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBinary : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x400034D")]
	public static readonly SqlBinary Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034C")]
	private Byte[] _value; //Field offset: 0x0

	[Token(Token = "0x17000151")]
	public override bool IsNull
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x60008A1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000152")]
	public Byte[] Value
	{
		[Address(RVA = "0x2373E10", Offset = "0x2373210", Length = "0xC8")]
		[Token(Token = "0x60008A2")]
		 get { } //Length: 200
	}

	[Address(RVA = "0x2373D00", Offset = "0x2373100", Length = "0x65")]
	[Token(Token = "0x60008B2")]
	private static SqlBinary() { }

	[Address(RVA = "0x2373D70", Offset = "0x2373170", Length = "0xE")]
	[Token(Token = "0x600089F")]
	private SqlBinary(bool fNull) { }

	[Address(RVA = "0x2373D80", Offset = "0x2373180", Length = "0x84")]
	[Token(Token = "0x60008A0")]
	public SqlBinary(Byte[] value) { }

	[Address(RVA = "0x2373350", Offset = "0x2372750", Length = "0x10E")]
	[Token(Token = "0x60008A9")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2373010", Offset = "0x2372410", Length = "0x340")]
	[Token(Token = "0x60008AA")]
	public int CompareTo(SqlBinary value) { }

	[Address(RVA = "0x2373460", Offset = "0x2372860", Length = "0x224")]
	[Token(Token = "0x60008AB")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x60008A1")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2373E10", Offset = "0x2373210", Length = "0xC8")]
	[Token(Token = "0x60008A2")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x2373690", Offset = "0x2372A90", Length = "0xE0")]
	[Token(Token = "0x60008AD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2373780", Offset = "0x2372B80", Length = "0x6B")]
	[Token(Token = "0x60008B1")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x23737F0", Offset = "0x2372BF0", Length = "0x58")]
	[Token(Token = "0x60008AC")]
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	[Address(RVA = "0x2373EE0", Offset = "0x23732E0", Length = "0xFC")]
	[Token(Token = "0x60008A6")]
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	[Address(RVA = "0x2373FE0", Offset = "0x23733E0", Length = "0xFC")]
	[Token(Token = "0x60008A8")]
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	[Address(RVA = "0x23740E0", Offset = "0x23734E0", Length = "0x92")]
	[Token(Token = "0x60008A3")]
	public static SqlBinary op_Implicit(Byte[] x) { }

	[Address(RVA = "0x2374180", Offset = "0x2373580", Length = "0xFB")]
	[Token(Token = "0x60008A7")]
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	[Address(RVA = "0x2373850", Offset = "0x2372C50", Length = "0x122")]
	[Token(Token = "0x60008A5")]
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008AE")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x2373980", Offset = "0x2372D80", Length = "0x15C")]
	[Token(Token = "0x60008AF")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2373AE0", Offset = "0x2372EE0", Length = "0x115")]
	[Token(Token = "0x60008B0")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x2373C00", Offset = "0x2373000", Length = "0xF4")]
	[Token(Token = "0x60008A4")]
	public virtual string ToString() { }

}

