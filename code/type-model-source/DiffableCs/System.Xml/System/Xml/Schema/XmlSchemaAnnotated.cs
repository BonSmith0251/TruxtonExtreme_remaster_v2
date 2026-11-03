namespace System.Xml.Schema;

[Token(Token = "0x20001F9")]
public class XmlSchemaAnnotated : XmlSchemaObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AE9")]
	private string id; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AEA")]
	private XmlSchemaAnnotation annotation; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AEB")]
	private XmlAttribute[] moreAttributes; //Field offset: 0x48

	[Token(Token = "0x17000563")]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600144A")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x600144B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000562")]
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001448")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6001449")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000565")]
	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600144E")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600144F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000564")]
	[XmlAnyAttribute]
	public XmlAttribute[] UnhandledAttributes
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600144C")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600144D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001452")]
	public XmlSchemaAnnotated() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6001451")]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600144A")]
	public XmlSchemaAnnotation get_Annotation() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001448")]
	public string get_Id() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600144E")]
	internal virtual string get_IdAttribute() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600144C")]
	public XmlAttribute[] get_UnhandledAttributes() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600144B")]
	public void set_Annotation(XmlSchemaAnnotation value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6001449")]
	public void set_Id(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600144F")]
	internal virtual void set_IdAttribute(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x600144D")]
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6001450")]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

