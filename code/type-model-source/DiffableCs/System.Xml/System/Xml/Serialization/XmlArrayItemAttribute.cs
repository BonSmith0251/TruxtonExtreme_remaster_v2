namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
[Token(Token = "0x2000108")]
public class XmlArrayItemAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060F")]
	private string dataType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000610")]
	private string elementName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000611")]
	private XmlSchemaForm form; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000612")]
	private string ns; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000613")]
	private bool isNullable; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000614")]
	private bool isNullableSpecified; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000615")]
	private int nestingLevel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000616")]
	private Type type; //Field offset: 0x38

	[Token(Token = "0x1700031A")]
	public string DataType
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C42")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700031B")]
	public string ElementName
	{
		[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
		[Token(Token = "0x6000C43")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700031C")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C44")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700031E")]
	public bool IsNullable
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000C46")]
		 get { } //Length: 5
		[Address(RVA = "0x255EAB0", Offset = "0x255DEB0", Length = "0x8")]
		[Token(Token = "0x6000C47")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700031F")]
	internal bool IsNullableSpecified
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x6000C48")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700031D")]
	public string Namespace
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C45")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000321")]
	public int NestingLevel
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000C4A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000320")]
	public Type Type
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C49")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2370610", Offset = "0x236FA10", Length = "0x31")]
	[Token(Token = "0x6000C41")]
	public XmlArrayItemAttribute(string elementName) { }

	[Address(RVA = "0x255E910", Offset = "0x255DD10", Length = "0x177")]
	[Token(Token = "0x6000C4B")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C42")]
	public string get_DataType() { }

	[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
	[Token(Token = "0x6000C43")]
	public string get_ElementName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C44")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000C46")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x6000C48")]
	internal bool get_IsNullableSpecified() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C45")]
	public string get_Namespace() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000C4A")]
	public int get_NestingLevel() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C49")]
	public Type get_Type() { }

	[Address(RVA = "0x255EAB0", Offset = "0x255DEB0", Length = "0x8")]
	[Token(Token = "0x6000C47")]
	public void set_IsNullable(bool value) { }

}

