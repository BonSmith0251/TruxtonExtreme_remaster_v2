namespace Mono.Xml;

[Token(Token = "0x2000046")]
internal class SecurityParser : SmallXmlParser, IContentHandler
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000139")]
	private SecurityElement root; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400013A")]
	private SecurityElement current; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400013B")]
	private Stack stack; //Field offset: 0x78

	[Address(RVA = "0x1E651B0", Offset = "0x1E645B0", Length = "0x206")]
	[Token(Token = "0x6000074")]
	public SecurityParser() { }

	[Address(RVA = "0x1E64C90", Offset = "0x1E64090", Length = "0xA2")]
	[Token(Token = "0x6000075")]
	public void LoadXml(string xml) { }

	[Address(RVA = "0x1E64D40", Offset = "0x1E64140", Length = "0x71")]
	[Token(Token = "0x600007C")]
	public override void OnChars(string ch) { }

	[Address(RVA = "0x1E64DC0", Offset = "0x1E641C0", Length = "0xB2")]
	[Token(Token = "0x600007B")]
	public override void OnEndElement(string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600007D")]
	public override void OnEndParsing(SmallXmlParser parser) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000079")]
	public override void OnIgnorableWhitespace(string s) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000078")]
	public override void OnProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1E64E80", Offset = "0x1E64280", Length = "0x325")]
	[Token(Token = "0x600007A")]
	public override void OnStartElement(string name, IAttrList attrs) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000077")]
	public override void OnStartParsing(SmallXmlParser parser) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000076")]
	public SecurityElement ToXml() { }

}

