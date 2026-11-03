namespace System.Xml.Schema;

[Token(Token = "0x20001CE")]
internal sealed class Parser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000890")]
	private SchemaType schemaType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000891")]
	private XmlNameTable nameTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000892")]
	private SchemaNames schemaNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000893")]
	private ValidationEventHandler eventHandler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000894")]
	private XmlNamespaceManager namespaceManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000895")]
	private XmlReader reader; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000896")]
	private PositionInfo positionInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000897")]
	private bool isProcessNamespaces; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000898")]
	private int schemaXmlDepth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000899")]
	private int markupDepth; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400089A")]
	private SchemaBuilder builder; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400089B")]
	private XmlSchema schema; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400089C")]
	private SchemaInfo xdrSchema; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400089D")]
	private XmlResolver xmlResolver; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400089E")]
	private XmlDocument dummyDocument; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400089F")]
	private bool processMarkup; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008A0")]
	private XmlNode parentNode; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008A1")]
	private XmlNamespaceManager annotationNSManager; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008A2")]
	private string xmlns; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008A3")]
	private XmlCharType xmlCharType; //Field offset: 0xA0

	[Token(Token = "0x170004D4")]
	public SchemaInfo XdrSchema
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60011C8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D3")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x60011C7")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004D2")]
	public XmlSchema XmlSchema
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60011C6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2429780", Offset = "0x2428B80", Length = "0xF1")]
	[Token(Token = "0x60011C1")]
	public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	[Address(RVA = "0x2427A00", Offset = "0x2426E00", Length = "0x118")]
	[Token(Token = "0x60011C4")]
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	[Address(RVA = "0x2427B20", Offset = "0x2426F20", Length = "0x125")]
	[Token(Token = "0x60011CC")]
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60011C5")]
	public SchemaType FinishParsing() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60011C8")]
	public SchemaInfo get_XdrSchema() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60011C6")]
	public XmlSchema get_XmlSchema() { }

	[Address(RVA = "0x2427C50", Offset = "0x2427050", Length = "0x1B4")]
	[Token(Token = "0x60011CD")]
	private XmlAttribute LoadAttributeNode() { }

	[Address(RVA = "0x2427E10", Offset = "0x2427210", Length = "0x4C6")]
	[Token(Token = "0x60011CB")]
	private XmlElement LoadElementNode(bool root) { }

	[Address(RVA = "0x24282E0", Offset = "0x24276E0", Length = "0x26A")]
	[Token(Token = "0x60011CE")]
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

	[Address(RVA = "0x2428E60", Offset = "0x2428260", Length = "0x60")]
	[Token(Token = "0x60011C2")]
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	[Address(RVA = "0x2428550", Offset = "0x2427950", Length = "0x90C")]
	[Token(Token = "0x60011C9")]
	public bool ParseReaderNode() { }

	[Address(RVA = "0x2428ED0", Offset = "0x24282D0", Length = "0x300")]
	[Token(Token = "0x60011CA")]
	private void ProcessAppInfoDocMarkup(bool root) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60011C7")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x2429210", Offset = "0x2428610", Length = "0x56C")]
	[Token(Token = "0x60011C3")]
	public void StartParsing(XmlReader reader, string targetNamespace) { }

}

