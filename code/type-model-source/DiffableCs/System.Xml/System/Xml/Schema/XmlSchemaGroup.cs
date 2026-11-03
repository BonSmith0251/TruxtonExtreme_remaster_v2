namespace System.Xml.Schema;

[Token(Token = "0x2000224")]
public class XmlSchemaGroup : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B80")]
	private string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B81")]
	private XmlSchemaGroupBase particle; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B82")]
	private XmlSchemaParticle canonicalParticle; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B83")]
	private XmlQualifiedName qname; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B84")]
	private XmlSchemaGroup redefined; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B85")]
	private int selfReferenceCount; //Field offset: 0x78

	[Token(Token = "0x170005F4")]
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60015A1")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60015A2")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x170005F1")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600159C")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x600159D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005F7")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015A7")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015A8")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005F2")]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600159E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x600159F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005F3")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60015A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F5")]
	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60015A3")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60015A4")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170005F6")]
	[XmlIgnore]
	internal int SelfReferenceCount
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x60015A5")]
		internal get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x60015A6")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x248EE90", Offset = "0x248E290", Length = "0x6B")]
	[Token(Token = "0x60015AC")]
	public XmlSchemaGroup() { }

	[Address(RVA = "0x248EE80", Offset = "0x248E280", Length = "0xA")]
	[Token(Token = "0x60015AA")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x248EC80", Offset = "0x248E080", Length = "0x1FE")]
	[Token(Token = "0x60015AB")]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60015A1")]
	internal XmlSchemaParticle get_CanonicalParticle() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600159C")]
	public string get_Name() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015A7")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600159E")]
	public XmlSchemaGroupBase get_Particle() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60015A0")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60015A3")]
	internal XmlSchemaGroup get_Redefined() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x60015A5")]
	internal int get_SelfReferenceCount() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60015A2")]
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x600159D")]
	public void set_Name(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015A8")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x600159F")]
	public void set_Particle(XmlSchemaGroupBase value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60015A4")]
	internal void set_Redefined(XmlSchemaGroup value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x60015A6")]
	internal void set_SelfReferenceCount(int value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60015A9")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

