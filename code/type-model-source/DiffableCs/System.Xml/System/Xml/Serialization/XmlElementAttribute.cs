namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
[Token(Token = "0x200010F")]
public class XmlElementAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062D")]
	private string dataType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062E")]
	private string elementName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400062F")]
	private XmlSchemaForm form; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000630")]
	private string ns; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000631")]
	private bool isNullable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000632")]
	private Type type; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000633")]
	private int order; //Field offset: 0x40

	[Token(Token = "0x17000339")]
	public string DataType
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C7A")]
		 get { } //Length: 30
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000C7B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700033A")]
	public string ElementName
	{
		[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
		[Token(Token = "0x6000C7C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700033B")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C7D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700033D")]
	public bool IsNullable
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000C7F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700033C")]
	public string Namespace
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C7E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700033E")]
	public int Order
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000C80")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700033F")]
	public Type Type
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C81")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2562AB0", Offset = "0x2561EB0", Length = "0xE")]
	[Token(Token = "0x6000C77")]
	public XmlElementAttribute() { }

	[Address(RVA = "0x2562B20", Offset = "0x2561F20", Length = "0x38")]
	[Token(Token = "0x6000C78")]
	public XmlElementAttribute(string elementName) { }

	[Address(RVA = "0x2562AC0", Offset = "0x2561EC0", Length = "0x55")]
	[Token(Token = "0x6000C79")]
	public XmlElementAttribute(string elementName, Type type) { }

	[Address(RVA = "0x2562950", Offset = "0x2561D50", Length = "0x152")]
	[Token(Token = "0x6000C82")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C7A")]
	public string get_DataType() { }

	[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
	[Token(Token = "0x6000C7C")]
	public string get_ElementName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C7D")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000C7F")]
	public bool get_IsNullable() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C7E")]
	public string get_Namespace() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6000C80")]
	public int get_Order() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C81")]
	public Type get_Type() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000C7B")]
	public void set_DataType(string value) { }

}

