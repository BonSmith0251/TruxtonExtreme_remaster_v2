namespace System.Xml.Schema;

[Token(Token = "0x2000242")]
public class XmlSchemaSimpleType : XmlSchemaType
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000BE1")]
	private XmlSchemaSimpleTypeContent content; //Field offset: 0x98

	[Token(Token = "0x1700064E")]
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	public XmlSchemaSimpleTypeContent Content
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6001697")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x6001698")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x24A21C0", Offset = "0x24A15C0", Length = "0x89")]
	[Token(Token = "0x6001696")]
	public XmlSchemaSimpleType() { }

	[Address(RVA = "0x24A2090", Offset = "0x24A1490", Length = "0x123")]
	[Token(Token = "0x6001699")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6001697")]
	public XmlSchemaSimpleTypeContent get_Content() { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6001698")]
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

}

