namespace System.Data.SqlTypes;

[Token(Token = "0x20000B1")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlGuid : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x40003C8")]
	private static readonly int s_sizeOfGuid; //Field offset: 0x0
	[Token(Token = "0x40003C9")]
	private static readonly Int32[] s_rgiGuidOrder; //Field offset: 0x8
	[Token(Token = "0x40003CB")]
	public static readonly SqlGuid Null; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CA")]
	private Byte[] m_value; //Field offset: 0x0

	[Token(Token = "0x1700016F")]
	public override bool IsNull
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x600098F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000170")]
	public Guid Value
	{
		[Address(RVA = "0x23994E0", Offset = "0x23988E0", Length = "0xA1")]
		[Token(Token = "0x6000990")]
		 get { } //Length: 161
	}

	[Address(RVA = "0x23993C0", Offset = "0x23987C0", Length = "0xEB")]
	[Token(Token = "0x600099F")]
	private static SqlGuid() { }

	[Address(RVA = "0x2373D70", Offset = "0x2373170", Length = "0xE")]
	[Token(Token = "0x600098D")]
	private SqlGuid(bool fNull) { }

	[Address(RVA = "0x23994B0", Offset = "0x23988B0", Length = "0x2A")]
	[Token(Token = "0x600098E")]
	public SqlGuid(Guid g) { }

	[Address(RVA = "0x2398C40", Offset = "0x2398040", Length = "0x104")]
	[Token(Token = "0x6000993")]
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	[Address(RVA = "0x2398850", Offset = "0x2397C50", Length = "0x10E")]
	[Token(Token = "0x6000997")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2398960", Offset = "0x2397D60", Length = "0x2D5")]
	[Token(Token = "0x6000998")]
	public int CompareTo(SqlGuid value) { }

	[Address(RVA = "0x2398D50", Offset = "0x2398150", Length = "0x1E4")]
	[Token(Token = "0x6000999")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x600098F")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x23994E0", Offset = "0x23988E0", Length = "0xA1")]
	[Token(Token = "0x6000990")]
	public Guid get_Value() { }

	[Address(RVA = "0x2398F40", Offset = "0x2398340", Length = "0x109")]
	[Token(Token = "0x600099A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2399050", Offset = "0x2398450", Length = "0x6B")]
	[Token(Token = "0x600099E")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2399590", Offset = "0x2398990", Length = "0xEC")]
	[Token(Token = "0x6000994")]
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	[Address(RVA = "0x2399680", Offset = "0x2398A80", Length = "0xEC")]
	[Token(Token = "0x6000996")]
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	[Address(RVA = "0x2399770", Offset = "0x2398B70", Length = "0x3D")]
	[Token(Token = "0x6000991")]
	public static SqlGuid op_Implicit(Guid x) { }

	[Address(RVA = "0x23997B0", Offset = "0x2398BB0", Length = "0xEB")]
	[Token(Token = "0x6000995")]
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600099B")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x23990C0", Offset = "0x23984C0", Length = "0x132")]
	[Token(Token = "0x600099C")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2399200", Offset = "0x2398600", Length = "0x13E")]
	[Token(Token = "0x600099D")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x2399340", Offset = "0x2398740", Length = "0x77")]
	[Token(Token = "0x6000992")]
	public virtual string ToString() { }

}

