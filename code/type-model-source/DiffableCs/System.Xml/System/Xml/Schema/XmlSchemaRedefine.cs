namespace System.Xml.Schema;

[Token(Token = "0x200023C")]
public class XmlSchemaRedefine : XmlSchemaExternal
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BBF")]
	private XmlSchemaObjectCollection items; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BC0")]
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BC1")]
	private XmlSchemaObjectTable types; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BC2")]
	private XmlSchemaObjectTable groups; //Field offset: 0x80

	[Token(Token = "0x17000632")]
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6001647")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000634")]
	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001649")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000631")]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001646")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000633")]
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6001648")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2499820", Offset = "0x2498C20", Length = "0xFB")]
	[Token(Token = "0x6001645")]
	public XmlSchemaRedefine() { }

	[Address(RVA = "0x2499800", Offset = "0x2498C00", Length = "0x1E")]
	[Token(Token = "0x600164A")]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001647")]
	public XmlSchemaObjectTable get_AttributeGroups() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001649")]
	public XmlSchemaObjectTable get_Groups() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001646")]
	public XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6001648")]
	public XmlSchemaObjectTable get_SchemaTypes() { }

}

