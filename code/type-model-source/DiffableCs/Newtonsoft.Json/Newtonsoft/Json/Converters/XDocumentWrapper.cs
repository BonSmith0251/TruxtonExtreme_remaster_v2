namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001CB")]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
{

	[Token(Token = "0x17000285")]
	public virtual List<IXmlNode> ChildNodes
	{
		[Address(RVA = "0x21B22E0", Offset = "0x21B16E0", Length = "0x195")]
		[Token(Token = "0x6000F62")]
		 get { } //Length: 405
	}

	[Token(Token = "0x17000284")]
	private XDocument Document
	{
		[Address(RVA = "0x21B2580", Offset = "0x21B1980", Length = "0x6B")]
		[Token(Token = "0x6000F60")]
		private get { } //Length: 107
	}

	[Nullable(2)]
	[Token(Token = "0x17000287")]
	public override IXmlElement DocumentElement
	{
		[Address(RVA = "0x21B2480", Offset = "0x21B1880", Length = "0xF8")]
		[NullableContext(2)]
		[Token(Token = "0x6000F70")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000286")]
	protected virtual bool HasChildNodes
	{
		[Address(RVA = "0x21B25F0", Offset = "0x21B19F0", Length = "0x9B")]
		[Token(Token = "0x6000F63")]
		 get { } //Length: 155
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000F61")]
	public XDocumentWrapper(XDocument document) { }

	[Address(RVA = "0x21B1A60", Offset = "0x21B0E60", Length = "0xA7")]
	[Token(Token = "0x6000F71")]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[Address(RVA = "0x21B1BC0", Offset = "0x21B0FC0", Length = "0xB7")]
	[Token(Token = "0x6000F6F")]
	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[Address(RVA = "0x21B1B10", Offset = "0x21B0F10", Length = "0xA6")]
	[Token(Token = "0x6000F6E")]
	public override IXmlNode CreateAttribute(string name, string value) { }

	[Address(RVA = "0x21B1C80", Offset = "0x21B1080", Length = "0x89")]
	[Token(Token = "0x6000F66")]
	public override IXmlNode CreateCDataSection(string data) { }

	[Address(RVA = "0x21B1D10", Offset = "0x21B1110", Length = "0x89")]
	[Token(Token = "0x6000F64")]
	public override IXmlNode CreateComment(string text) { }

	[Address(RVA = "0x21B1E40", Offset = "0x21B1240", Length = "0xA7")]
	[Token(Token = "0x6000F6D")]
	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	[Address(RVA = "0x21B1DA0", Offset = "0x21B11A0", Length = "0x96")]
	[Token(Token = "0x6000F6C")]
	public override IXmlElement CreateElement(string elementName) { }

	[Address(RVA = "0x21B1EF0", Offset = "0x21B12F0", Length = "0x99")]
	[Token(Token = "0x6000F6B")]
	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	[Address(RVA = "0x21B1F90", Offset = "0x21B1390", Length = "0x89")]
	[Token(Token = "0x6000F68")]
	public override IXmlNode CreateSignificantWhitespace(string text) { }

	[Address(RVA = "0x21B2020", Offset = "0x21B1420", Length = "0x89")]
	[Token(Token = "0x6000F65")]
	public override IXmlNode CreateTextNode(string text) { }

	[Address(RVA = "0x21B20B0", Offset = "0x21B14B0", Length = "0x89")]
	[Token(Token = "0x6000F67")]
	public override IXmlNode CreateWhitespace(string text) { }

	[Address(RVA = "0x21B2140", Offset = "0x21B1540", Length = "0xC2")]
	[Token(Token = "0x6000F69")]
	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[Address(RVA = "0x21B2210", Offset = "0x21B1610", Length = "0xC9")]
	[NullableContext(2)]
	[Token(Token = "0x6000F6A")]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[Address(RVA = "0x21B22E0", Offset = "0x21B16E0", Length = "0x195")]
	[Token(Token = "0x6000F62")]
	public virtual List<IXmlNode> get_ChildNodes() { }

	[Address(RVA = "0x21B2580", Offset = "0x21B1980", Length = "0x6B")]
	[Token(Token = "0x6000F60")]
	private XDocument get_Document() { }

	[Address(RVA = "0x21B2480", Offset = "0x21B1880", Length = "0xF8")]
	[NullableContext(2)]
	[Token(Token = "0x6000F70")]
	public override IXmlElement get_DocumentElement() { }

	[Address(RVA = "0x21B25F0", Offset = "0x21B19F0", Length = "0x9B")]
	[Token(Token = "0x6000F63")]
	protected virtual bool get_HasChildNodes() { }

}

