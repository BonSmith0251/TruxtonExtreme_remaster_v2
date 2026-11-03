namespace System.Xml.Schema;

[Token(Token = "0x2000244")]
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BE2")]
	private XmlQualifiedName itemTypeName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BE3")]
	private XmlSchemaSimpleType itemType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BE4")]
	private XmlSchemaSimpleType baseItemType; //Field offset: 0x60

	[Token(Token = "0x17000651")]
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600169F")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60016A0")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000650")]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600169D")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x600169E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700064F")]
	[XmlAttribute("itemType")]
	public XmlQualifiedName ItemTypeName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600169B")]
		 get { } //Length: 5
		[Address(RVA = "0x24A1B00", Offset = "0x24A0F00", Length = "0xA0")]
		[Token(Token = "0x600169C")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x24A1A90", Offset = "0x24A0E90", Length = "0x6B")]
	[Token(Token = "0x60016A2")]
	public XmlSchemaSimpleTypeList() { }

	[Address(RVA = "0x24A1960", Offset = "0x24A0D60", Length = "0x126")]
	[Token(Token = "0x60016A1")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600169F")]
	public XmlSchemaSimpleType get_BaseItemType() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600169D")]
	public XmlSchemaSimpleType get_ItemType() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600169B")]
	public XmlQualifiedName get_ItemTypeName() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60016A0")]
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x600169E")]
	public void set_ItemType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x24A1B00", Offset = "0x24A0F00", Length = "0xA0")]
	[Token(Token = "0x600169C")]
	public void set_ItemTypeName(XmlQualifiedName value) { }

}

