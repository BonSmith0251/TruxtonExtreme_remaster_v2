namespace System.Xml.Schema;

[Token(Token = "0x20001FA")]
public class XmlSchemaAnnotation : XmlSchemaObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AEC")]
	private string id; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AED")]
	private XmlSchemaObjectCollection items; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AEE")]
	private XmlAttribute[] moreAttributes; //Field offset: 0x48

	[Token(Token = "0x17000566")]
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001453")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6001454")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000568")]
	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001456")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6001457")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000567")]
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	public XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001455")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2487C10", Offset = "0x2487010", Length = "0x66")]
	[Token(Token = "0x6001459")]
	public XmlSchemaAnnotation() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001453")]
	public string get_Id() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001456")]
	internal virtual string get_IdAttribute() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001455")]
	public XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6001454")]
	public void set_Id(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6001457")]
	internal virtual void set_IdAttribute(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6001458")]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

