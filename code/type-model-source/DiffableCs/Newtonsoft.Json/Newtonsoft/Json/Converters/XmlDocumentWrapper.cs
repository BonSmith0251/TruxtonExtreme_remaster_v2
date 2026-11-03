namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BF")]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000812")]
	private readonly XmlDocument _document; //Field offset: 0x28

	[Nullable(2)]
	[Token(Token = "0x17000255")]
	public override IXmlElement DocumentElement
	{
		[Address(RVA = "0x21B4210", Offset = "0x21B3610", Length = "0xA4")]
		[NullableContext(2)]
		[Token(Token = "0x6000F10")]
		 get { } //Length: 164
	}

	[Address(RVA = "0x21B38F0", Offset = "0x21B2CF0", Length = "0x41")]
	[Token(Token = "0x6000F03")]
	public XmlDocumentWrapper(XmlDocument document) { }

	[Address(RVA = "0x21B3A60", Offset = "0x21B2E60", Length = "0xAB")]
	[Token(Token = "0x6000F0E")]
	public override IXmlNode CreateAttribute(string name, string value) { }

	[Address(RVA = "0x21B3B10", Offset = "0x21B2F10", Length = "0xBB")]
	[Token(Token = "0x6000F0F")]
	public override IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[Address(RVA = "0x21B3BD0", Offset = "0x21B2FD0", Length = "0x8A")]
	[Token(Token = "0x6000F06")]
	public override IXmlNode CreateCDataSection(string data) { }

	[Address(RVA = "0x21B3C60", Offset = "0x21B3060", Length = "0x8A")]
	[Token(Token = "0x6000F04")]
	public override IXmlNode CreateComment(string data) { }

	[Address(RVA = "0x21B3CF0", Offset = "0x21B30F0", Length = "0x8F")]
	[Token(Token = "0x6000F0C")]
	public override IXmlElement CreateElement(string elementName) { }

	[Address(RVA = "0x21B3D80", Offset = "0x21B3180", Length = "0x9F")]
	[Token(Token = "0x6000F0D")]
	public override IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	[Address(RVA = "0x21B3E20", Offset = "0x21B3220", Length = "0x9A")]
	[Token(Token = "0x6000F0B")]
	public override IXmlNode CreateProcessingInstruction(string target, string data) { }

	[Address(RVA = "0x21B3EC0", Offset = "0x21B32C0", Length = "0x8A")]
	[Token(Token = "0x6000F08")]
	public override IXmlNode CreateSignificantWhitespace(string text) { }

	[Address(RVA = "0x21B3F50", Offset = "0x21B3350", Length = "0x8A")]
	[Token(Token = "0x6000F05")]
	public override IXmlNode CreateTextNode(string text) { }

	[Address(RVA = "0x21B3FE0", Offset = "0x21B33E0", Length = "0x8A")]
	[Token(Token = "0x6000F07")]
	public override IXmlNode CreateWhitespace(string text) { }

	[Address(RVA = "0x21B4070", Offset = "0x21B3470", Length = "0xC0")]
	[Token(Token = "0x6000F09")]
	public override IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[Address(RVA = "0x21B4140", Offset = "0x21B3540", Length = "0xC9")]
	[NullableContext(2)]
	[Token(Token = "0x6000F0A")]
	public override IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[Address(RVA = "0x21B4210", Offset = "0x21B3610", Length = "0xA4")]
	[NullableContext(2)]
	[Token(Token = "0x6000F10")]
	public override IXmlElement get_DocumentElement() { }

}

