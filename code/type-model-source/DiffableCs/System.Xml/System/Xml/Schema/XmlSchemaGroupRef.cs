namespace System.Xml.Schema;

[Token(Token = "0x2000226")]
public class XmlSchemaGroupRef : XmlSchemaParticle
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B86")]
	private XmlQualifiedName refName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B87")]
	private XmlSchemaGroupBase particle; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B88")]
	private XmlSchemaGroup refined; //Field offset: 0x88

	[Token(Token = "0x170005FA")]
	[XmlIgnore]
	public XmlSchemaGroupBase Particle
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60015B2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005FB")]
	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60015B4")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60015B5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170005F9")]
	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60015B0")]
		 get { } //Length: 5
		[Address(RVA = "0x248EBD0", Offset = "0x248DFD0", Length = "0xA0")]
		[Token(Token = "0x60015B1")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x248EB40", Offset = "0x248DF40", Length = "0x8C")]
	[Token(Token = "0x60015B6")]
	public XmlSchemaGroupRef() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60015B2")]
	public XmlSchemaGroupBase get_Particle() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60015B4")]
	internal XmlSchemaGroup get_Redefined() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60015B0")]
	public XmlQualifiedName get_RefName() { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60015B5")]
	internal void set_Redefined(XmlSchemaGroup value) { }

	[Address(RVA = "0x248EBD0", Offset = "0x248DFD0", Length = "0xA0")]
	[Token(Token = "0x60015B1")]
	public void set_RefName(XmlQualifiedName value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60015B3")]
	internal void SetParticle(XmlSchemaGroupBase value) { }

}

