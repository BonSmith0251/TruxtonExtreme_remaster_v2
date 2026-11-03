namespace System.Xml;

[Token(Token = "0x200009E")]
internal class XmlLoader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000474")]
	private XmlDocument doc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000475")]
	private XmlReader reader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000476")]
	private bool preserveWhitespace; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000896")]
	public XmlLoader() { }

	[Address(RVA = "0x251CC20", Offset = "0x251C020", Length = "0x267")]
	[Token(Token = "0x60008AE")]
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	[Address(RVA = "0x251CE90", Offset = "0x251C290", Length = "0x4F")]
	[Token(Token = "0x60008AB")]
	private string EntitizeName(string name) { }

	[Address(RVA = "0x251D480", Offset = "0x251C880", Length = "0xAA")]
	[Token(Token = "0x60008AC")]
	internal void ExpandEntity(XmlEntity ent) { }

	[Address(RVA = "0x251CEE0", Offset = "0x251C2E0", Length = "0x59E")]
	[Token(Token = "0x60008AD")]
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	[Address(RVA = "0x251D530", Offset = "0x251C930", Length = "0x896")]
	[Token(Token = "0x60008A6")]
	private XmlParserContext GetContext(XmlNode node) { }

	[Address(RVA = "0x2520B40", Offset = "0x251FF40", Length = "0x2C6")]
	[Token(Token = "0x6000897")]
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	[Address(RVA = "0x251DFA0", Offset = "0x251D3A0", Length = "0x38C")]
	[Token(Token = "0x600089B")]
	private XmlAttribute LoadAttributeNode() { }

	[Address(RVA = "0x251DDD0", Offset = "0x251D1D0", Length = "0x1CA")]
	[Token(Token = "0x60008A2")]
	private XmlAttribute LoadAttributeNodeDirect() { }

	[Address(RVA = "0x251E330", Offset = "0x251D730", Length = "0x325")]
	[Token(Token = "0x600089D")]
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	[Address(RVA = "0x251E660", Offset = "0x251DA60", Length = "0x1EA")]
	[Token(Token = "0x600089F")]
	private XmlDeclaration LoadDeclarationNode() { }

	[Address(RVA = "0x251E850", Offset = "0x251DC50", Length = "0x1EC")]
	[Token(Token = "0x600089C")]
	private XmlAttribute LoadDefaultAttribute() { }

	[Address(RVA = "0x251EA40", Offset = "0x251DE40", Length = "0x74")]
	[Token(Token = "0x6000898")]
	private void LoadDocSequence(XmlDocument parentDoc) { }

	[Address(RVA = "0x251ED10", Offset = "0x251E110", Length = "0xCC0")]
	[Token(Token = "0x60008A5")]
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	[Address(RVA = "0x251EAC0", Offset = "0x251DEC0", Length = "0x247")]
	[Token(Token = "0x60008A0")]
	private XmlDocumentType LoadDocumentTypeNode() { }

	[Address(RVA = "0x251F9E0", Offset = "0x251EDE0", Length = "0x24C")]
	[Token(Token = "0x600089E")]
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	[Address(RVA = "0x251FC30", Offset = "0x251F030", Length = "0x1D")]
	[Token(Token = "0x60008A9")]
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	[Address(RVA = "0x251FC50", Offset = "0x251F050", Length = "0x192")]
	[Token(Token = "0x60008A8")]
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	[Address(RVA = "0x25203F0", Offset = "0x251F7F0", Length = "0x704")]
	[Token(Token = "0x600089A")]
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	[Address(RVA = "0x251FDF0", Offset = "0x251F1F0", Length = "0xCC")]
	[Token(Token = "0x60008A1")]
	private XmlNode LoadNodeDirect() { }

	[Address(RVA = "0x25210C0", Offset = "0x25204C0", Length = "0x7D")]
	[Token(Token = "0x60008A3")]
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	[Address(RVA = "0x2520E10", Offset = "0x2520210", Length = "0x2AD")]
	[Token(Token = "0x60008A4")]
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	[Address(RVA = "0x2521140", Offset = "0x2520540", Length = "0x272")]
	[Token(Token = "0x60008A7")]
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	[Address(RVA = "0x25213C0", Offset = "0x25207C0", Length = "0x291")]
	[Token(Token = "0x60008AF")]
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	[Address(RVA = "0x2521660", Offset = "0x2520A60", Length = "0x1B7")]
	[Token(Token = "0x6000899")]
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	[Address(RVA = "0x2521820", Offset = "0x2520C20", Length = "0x337")]
	[Token(Token = "0x60008AA")]
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	[Address(RVA = "0x2521B60", Offset = "0x2520F60", Length = "0xEA")]
	[Token(Token = "0x60008B0")]
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

