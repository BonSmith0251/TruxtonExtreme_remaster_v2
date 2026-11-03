namespace System.Xml.Schema;

[Token(Token = "0x20001FC")]
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AF2")]
	private string ns; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AF3")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AF4")]
	private NamespaceList namespaceList; //Field offset: 0x60

	[Token(Token = "0x1700056F")]
	[XmlAttribute("namespace")]
	public string Namespace
	{
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001465")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000571")]
	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001468")]
		internal get { } //Length: 5
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[Token(Token = "0x17000570")]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x6001466")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6001467")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000572")]
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		[Address(RVA = "0x2488000", Offset = "0x2487400", Length = "0xF")]
		[Token(Token = "0x6001469")]
		internal get { } //Length: 15
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001470")]
	public XmlSchemaAnyAttribute() { }

	[Address(RVA = "0x2487C80", Offset = "0x2487080", Length = "0x33")]
	[Token(Token = "0x600146C")]
	internal bool Allows(XmlQualifiedName qname) { }

	[Address(RVA = "0x2487D70", Offset = "0x2487170", Length = "0x9C")]
	[Token(Token = "0x600146A")]
	internal void BuildNamespaceList(string targetNamespace) { }

	[Address(RVA = "0x2487CC0", Offset = "0x24870C0", Length = "0xAF")]
	[Token(Token = "0x600146B")]
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001468")]
	internal NamespaceList get_NamespaceList() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x6001466")]
	public XmlSchemaContentProcessing get_ProcessContents() { }

	[Address(RVA = "0x2488000", Offset = "0x2487400", Length = "0xF")]
	[Token(Token = "0x6001469")]
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	[Address(RVA = "0x2487E10", Offset = "0x2487210", Length = "0xD0")]
	[Token(Token = "0x600146E")]
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	[Address(RVA = "0x2487EF0", Offset = "0x24872F0", Length = "0x27")]
	[Token(Token = "0x600146D")]
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001465")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6001467")]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	[Address(RVA = "0x2487F20", Offset = "0x2487320", Length = "0xD0")]
	[Token(Token = "0x600146F")]
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

}

