namespace System.Xml.Schema;

[Token(Token = "0x2000227")]
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B89")]
	private string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B8A")]
	private XmlSchemaXPath selector; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B8B")]
	private XmlSchemaObjectCollection fields; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B8C")]
	private XmlQualifiedName qualifiedName; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B8D")]
	private CompiledIdentityConstraint compiledConstraint; //Field offset: 0x70

	[Token(Token = "0x17000600")]
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60015BE")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60015BF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005FE")]
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60015BB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005FC")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015B7")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015B8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000601")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015C0")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015C1")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005FF")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60015BC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005FD")]
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60015B9")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60015BA")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x248EF00", Offset = "0x248E300", Length = "0xA9")]
	[Token(Token = "0x60015C2")]
	public XmlSchemaIdentityConstraint() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60015BE")]
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60015BB")]
	public XmlSchemaObjectCollection get_Fields() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015B7")]
	public string get_Name() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015C0")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60015BC")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60015B9")]
	public XmlSchemaXPath get_Selector() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60015BF")]
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015B8")]
	public void set_Name(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015C1")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60015BA")]
	public void set_Selector(XmlSchemaXPath value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60015BD")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

