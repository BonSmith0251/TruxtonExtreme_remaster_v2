namespace System.Xml.Serialization;

[AttributeUsage(10624)]
[Token(Token = "0x200010A")]
public class XmlAttributeAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000617")]
	private string attributeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000618")]
	private string dataType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000619")]
	private Type type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400061A")]
	private XmlSchemaForm form; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400061B")]
	private string ns; //Field offset: 0x30

	[Token(Token = "0x17000323")]
	public string AttributeName
	{
		[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
		[Token(Token = "0x6000C52")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000324")]
	public string DataType
	{
		[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
		[Token(Token = "0x6000C53")]
		 get { } //Length: 30
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000C54")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000325")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000C55")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000326")]
	public string Namespace
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C56")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000C50")]
	public XmlAttributeAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000C51")]
	public XmlAttributeAttribute(string attributeName) { }

	[Address(RVA = "0x255EE90", Offset = "0x255E290", Length = "0x13D")]
	[Token(Token = "0x6000C57")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254F980", Offset = "0x254ED80", Length = "0x1E")]
	[Token(Token = "0x6000C52")]
	public string get_AttributeName() { }

	[Address(RVA = "0x255EA90", Offset = "0x255DE90", Length = "0x1E")]
	[Token(Token = "0x6000C53")]
	public string get_DataType() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000C55")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C56")]
	public string get_Namespace() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000C54")]
	public void set_DataType(string value) { }

}

