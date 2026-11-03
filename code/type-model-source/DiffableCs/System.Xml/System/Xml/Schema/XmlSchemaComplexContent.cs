namespace System.Xml.Schema;

[Token(Token = "0x2000206")]
public class XmlSchemaComplexContent : XmlSchemaContentModel
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B19")]
	private XmlSchemaContent content; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B1A")]
	private bool isMixed; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000B1B")]
	private bool hasMixedAttribute; //Field offset: 0x59

	[Token(Token = "0x1700059F")]
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	public virtual XmlSchemaContent Content
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60014CD")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60014CE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A0")]
	[XmlIgnore]
	internal bool HasMixedAttribute
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x60014CF")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700059E")]
	[XmlAttribute("mixed")]
	public bool IsMixed
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60014CB")]
		 get { } //Length: 5
		[Address(RVA = "0x2489E10", Offset = "0x2489210", Length = "0x8")]
		[Token(Token = "0x60014CC")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014D0")]
	public XmlSchemaComplexContent() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60014CD")]
	public virtual XmlSchemaContent get_Content() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x60014CF")]
	internal bool get_HasMixedAttribute() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x60014CB")]
	public bool get_IsMixed() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60014CE")]
	public virtual void set_Content(XmlSchemaContent value) { }

	[Address(RVA = "0x2489E10", Offset = "0x2489210", Length = "0x8")]
	[Token(Token = "0x60014CC")]
	public void set_IsMixed(bool value) { }

}

