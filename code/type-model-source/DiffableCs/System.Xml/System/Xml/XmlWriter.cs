namespace System.Xml;

[Token(Token = "0x2000081")]
public abstract class XmlWriter : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A9")]
	private Char[] writeNodeBuffer; //Field offset: 0x10

	[Token(Token = "0x17000169")]
	public abstract WriteState WriteState
	{
		[Token(Token = "0x6000695")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006A2")]
	protected XmlWriter() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000696")]
	public override void Close() { }

	[Address(RVA = "0x2522E90", Offset = "0x2522290", Length = "0x6C")]
	[Token(Token = "0x60006A0")]
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	[Address(RVA = "0x2522F70", Offset = "0x2522370", Length = "0x6C")]
	[Token(Token = "0x600069F")]
	public static XmlWriter Create(string outputFileName, XmlWriterSettings settings) { }

	[Address(RVA = "0x2522F00", Offset = "0x2522300", Length = "0x6C")]
	[Token(Token = "0x60006A1")]
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	[Address(RVA = "0x2522FE0", Offset = "0x25223E0", Length = "0x40")]
	[Token(Token = "0x600069E")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2523020", Offset = "0x2522420", Length = "0x16")]
	[Token(Token = "0x600069D")]
	public override void Dispose() { }

	[Token(Token = "0x6000697")]
	public abstract void Flush() { }

	[Token(Token = "0x6000695")]
	public abstract WriteState get_WriteState() { }

	[Token(Token = "0x6000698")]
	public abstract string LookupPrefix(string ns) { }

	[Address(RVA = "0x2523180", Offset = "0x2522580", Length = "0x306")]
	[Token(Token = "0x600069A")]
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	[Address(RVA = "0x2523040", Offset = "0x2522440", Length = "0x6B")]
	[Token(Token = "0x6000683")]
	public void WriteAttributeString(string localName, string ns, string value) { }

	[Address(RVA = "0x2523120", Offset = "0x2522520", Length = "0x59")]
	[Token(Token = "0x6000685")]
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	[Address(RVA = "0x25230B0", Offset = "0x25224B0", Length = "0x6B")]
	[Token(Token = "0x6000684")]
	public void WriteAttributeString(string localName, string value) { }

	[Token(Token = "0x6000693")]
	public abstract void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2523490", Offset = "0x2522890", Length = "0x23")]
	[Token(Token = "0x6000694")]
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Token(Token = "0x6000688")]
	public abstract void WriteCData(string text) { }

	[Token(Token = "0x600068C")]
	public abstract void WriteCharEntity(char ch) { }

	[Token(Token = "0x6000690")]
	public abstract void WriteChars(Char[] buffer, int index, int count) { }

	[Token(Token = "0x6000689")]
	public abstract void WriteComment(string text) { }

	[Token(Token = "0x600067E")]
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x25234C0", Offset = "0x25228C0", Length = "0x76")]
	[Token(Token = "0x600069C")]
	public void WriteElementString(string localName, string ns, string value) { }

	[Token(Token = "0x6000687")]
	public abstract void WriteEndAttribute() { }

	[Token(Token = "0x600067D")]
	public abstract void WriteEndDocument() { }

	[Token(Token = "0x6000681")]
	public abstract void WriteEndElement() { }

	[Token(Token = "0x600068B")]
	public abstract void WriteEntityRef(string name) { }

	[Token(Token = "0x6000682")]
	public abstract void WriteFullEndElement() { }

	[Address(RVA = "0x2523540", Offset = "0x2522940", Length = "0x548")]
	[Token(Token = "0x600069B")]
	public override void WriteNode(XmlReader reader, bool defattr) { }

	[Token(Token = "0x600068A")]
	public abstract void WriteProcessingInstruction(string name, string text) { }

	[Token(Token = "0x6000691")]
	public abstract void WriteRaw(Char[] buffer, int index, int count) { }

	[Token(Token = "0x6000692")]
	public abstract void WriteRaw(string data) { }

	[Token(Token = "0x6000686")]
	public abstract void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Token(Token = "0x600067B")]
	public abstract void WriteStartDocument() { }

	[Token(Token = "0x600067C")]
	public abstract void WriteStartDocument(bool standalone) { }

	[Token(Token = "0x6000680")]
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2523AD0", Offset = "0x2522ED0", Length = "0x2A")]
	[Token(Token = "0x600067F")]
	public void WriteStartElement(string localName, string ns) { }

	[Token(Token = "0x600068E")]
	public abstract void WriteString(string text) { }

	[Token(Token = "0x600068F")]
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x2523B00", Offset = "0x2522F00", Length = "0x1A")]
	[Token(Token = "0x6000699")]
	public override void WriteValue(string value) { }

	[Token(Token = "0x600068D")]
	public abstract void WriteWhitespace(string ws) { }

}

