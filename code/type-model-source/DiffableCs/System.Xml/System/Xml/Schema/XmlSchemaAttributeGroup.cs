namespace System.Xml.Schema;

[Token(Token = "0x20001FF")]
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B02")]
	private string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B03")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B04")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B05")]
	private XmlQualifiedName qname; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B06")]
	private XmlSchemaAttributeGroup redefined; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B07")]
	private XmlSchemaObjectTable attributeUses; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B08")]
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B09")]
	private int selfReferenceCount; //Field offset: 0x88

	[Token(Token = "0x17000584")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001493")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6001494")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000583")]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001492")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000586")]
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses
	{
		[Address(RVA = "0x2488980", Offset = "0x2487D80", Length = "0x69")]
		[Token(Token = "0x6001496")]
		internal get { } //Length: 105
	}

	[Token(Token = "0x17000587")]
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001497")]
		internal get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x6001498")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x17000582")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001490")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001491")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700058B")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600149E")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x600149F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000585")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001495")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000589")]
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x600149A")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x600149B")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000588")]
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6001499")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700058A")]
	[XmlIgnore]
	internal int SelfReferenceCount
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x600149C")]
		internal get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[Token(Token = "0x600149D")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x24888D0", Offset = "0x2487CD0", Length = "0xA9")]
	[Token(Token = "0x60014A2")]
	public XmlSchemaAttributeGroup() { }

	[Address(RVA = "0x24887B0", Offset = "0x2487BB0", Length = "0x112")]
	[Token(Token = "0x60014A1")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001493")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001492")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x2488980", Offset = "0x2487D80", Length = "0x69")]
	[Token(Token = "0x6001496")]
	internal XmlSchemaObjectTable get_AttributeUses() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001497")]
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001490")]
	public string get_Name() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600149E")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001495")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x600149A")]
	internal XmlSchemaAttributeGroup get_Redefined() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001499")]
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x600149C")]
	internal int get_SelfReferenceCount() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6001494")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x6001498")]
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001491")]
	public void set_Name(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x600149F")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x600149B")]
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[Token(Token = "0x600149D")]
	internal void set_SelfReferenceCount(int value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60014A0")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

