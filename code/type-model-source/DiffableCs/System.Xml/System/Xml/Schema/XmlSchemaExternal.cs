namespace System.Xml.Schema;

[Token(Token = "0x2000213")]
public abstract class XmlSchemaExternal : XmlSchemaObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B65")]
	private string location; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B66")]
	private Uri baseUri; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B67")]
	private XmlSchema schema; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B68")]
	private string id; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B69")]
	private XmlAttribute[] moreAttributes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B6A")]
	private Compositor compositor; //Field offset: 0x60

	[Token(Token = "0x170005EB")]
	[XmlIgnore]
	internal Uri BaseUri
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001580")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6001581")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005ED")]
	internal Compositor Compositor
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x6001585")]
		internal get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[Token(Token = "0x6001586")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170005EA")]
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600157E")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x600157F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005EC")]
	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001582")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001583")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005E9")]
	[XmlIgnore]
	public XmlSchema Schema
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600157C")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600157D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005E8")]
	[XmlAttribute("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600157A")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600157B")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001587")]
	protected XmlSchemaExternal() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001580")]
	internal Uri get_BaseUri() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x6001585")]
	internal Compositor get_Compositor() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600157E")]
	public string get_Id() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001582")]
	internal virtual string get_IdAttribute() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600157C")]
	public XmlSchema get_Schema() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600157A")]
	public string get_SchemaLocation() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6001581")]
	internal void set_BaseUri(Uri value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[Token(Token = "0x6001586")]
	internal void set_Compositor(Compositor value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x600157F")]
	public void set_Id(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001583")]
	internal virtual void set_IdAttribute(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x600157D")]
	public void set_Schema(XmlSchema value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600157B")]
	public void set_SchemaLocation(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001584")]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

