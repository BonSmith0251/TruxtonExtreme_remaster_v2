namespace System.Xml.Schema;

[Token(Token = "0x20001FB")]
public class XmlSchemaAny : XmlSchemaParticle
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AEF")]
	private string ns; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AF0")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AF1")]
	private NamespaceList namespaceList; //Field offset: 0x88

	[Token(Token = "0x17000569")]
	[XmlAttribute("namespace")]
	public string Namespace
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600145A")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x600145B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700056B")]
	[XmlIgnore]
	internal NamespaceList NamespaceList
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x600145D")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700056E")]
	internal virtual string NameString
	{
		[Address(RVA = "0x2488210", Offset = "0x2487610", Length = "0x404")]
		[Token(Token = "0x6001460")]
		internal get { } //Length: 1028
	}

	[DefaultValue(XmlSchemaContentProcessing::None (0))]
	[Token(Token = "0x1700056A")]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[Token(Token = "0x600145C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700056D")]
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect
	{
		[Address(RVA = "0x2488620", Offset = "0x2487A20", Length = "0x15")]
		[Token(Token = "0x600145F")]
		internal get { } //Length: 21
	}

	[Token(Token = "0x1700056C")]
	[XmlIgnore]
	internal string ResolvedNamespace
	{
		[Address(RVA = "0x2488640", Offset = "0x2487A40", Length = "0x43")]
		[Token(Token = "0x600145E")]
		internal get { } //Length: 67
	}

	[Address(RVA = "0x24881C0", Offset = "0x24875C0", Length = "0x49")]
	[Token(Token = "0x6001464")]
	public XmlSchemaAny() { }

	[Address(RVA = "0x2488010", Offset = "0x2487410", Length = "0x36")]
	[Token(Token = "0x6001463")]
	internal bool Allows(XmlQualifiedName qname) { }

	[Address(RVA = "0x2488110", Offset = "0x2487510", Length = "0xA2")]
	[Token(Token = "0x6001461")]
	internal void BuildNamespaceList(string targetNamespace) { }

	[Address(RVA = "0x2488050", Offset = "0x2487450", Length = "0xB5")]
	[Token(Token = "0x6001462")]
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x600145A")]
	public string get_Namespace() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x600145D")]
	internal NamespaceList get_NamespaceList() { }

	[Address(RVA = "0x2488210", Offset = "0x2487610", Length = "0x404")]
	[Token(Token = "0x6001460")]
	internal virtual string get_NameString() { }

	[Address(RVA = "0x2488620", Offset = "0x2487A20", Length = "0x15")]
	[Token(Token = "0x600145F")]
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	[Address(RVA = "0x2488640", Offset = "0x2487A40", Length = "0x43")]
	[Token(Token = "0x600145E")]
	internal string get_ResolvedNamespace() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x600145B")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[Token(Token = "0x600145C")]
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

}

