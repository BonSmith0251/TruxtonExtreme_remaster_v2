namespace System.Xml;

[Token(Token = "0x200006D")]
internal class XmlUtf8RawTextWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002ED")]
	private readonly bool useAsync; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002EE")]
	protected Byte[] bufBytes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002EF")]
	protected Stream stream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F0")]
	protected Encoding encoding; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F1")]
	protected XmlCharType xmlCharType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F2")]
	protected int bufPos; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40002F3")]
	protected int textPos; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002F4")]
	protected int contentPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002F5")]
	protected int cdataPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002F6")]
	protected int attrEndPos; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002F7")]
	protected int bufLen; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002F8")]
	protected bool writeToNull; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40002F9")]
	protected bool hadDoubleBracket; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x40002FA")]
	protected bool inAttributeValue; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002FB")]
	protected NewLineHandling newLineHandling; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002FC")]
	protected bool closeOutput; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40002FD")]
	protected bool omitXmlDeclaration; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002FE")]
	protected string newLineChars; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002FF")]
	protected bool checkCharacters; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000300")]
	protected XmlStandalone standalone; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000301")]
	protected XmlOutputMethod outputMethod; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000302")]
	protected bool autoXmlDeclaration; //Field offset: 0x8C
	[FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x4000303")]
	protected bool mergeCDataSections; //Field offset: 0x8D

	[Token(Token = "0x17000136")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600058C")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x25077C0", Offset = "0x2506BC0", Length = "0xF8")]
	[Token(Token = "0x6000580")]
	protected XmlUtf8RawTextWriter(XmlWriterSettings settings) { }

	[Address(RVA = "0x2507570", Offset = "0x2506970", Length = "0x240")]
	[Token(Token = "0x6000581")]
	public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x25040E0", Offset = "0x25034E0", Length = "0xF")]
	[Token(Token = "0x60005AE")]
	protected static Byte* AmpEntity(Byte* pDst) { }

	[Address(RVA = "0x25040F0", Offset = "0x25034F0", Length = "0xF")]
	[Token(Token = "0x60005B2")]
	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	[Address(RVA = "0x2504100", Offset = "0x2503500", Length = "0x95")]
	[Token(Token = "0x60005B3")]
	private static Byte* CharEntity(Byte* pDst, char ch) { }

	[Address(RVA = "0x25041A0", Offset = "0x25035A0", Length = "0xAF")]
	[Token(Token = "0x60005AA")]
	internal static void CharToUTF8(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	[Address(RVA = "0x2504250", Offset = "0x2503650", Length = "0x5F")]
	[Token(Token = "0x600059A")]
	public virtual void Close() { }

	[Address(RVA = "0x25042B0", Offset = "0x25036B0", Length = "0xD4")]
	[Token(Token = "0x60005A8")]
	internal void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	[Address(RVA = "0x2504390", Offset = "0x2503790", Length = "0x49")]
	[Token(Token = "0x60005A9")]
	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	[Address(RVA = "0x25043E0", Offset = "0x25037E0", Length = "0x1A1")]
	[Token(Token = "0x60005A6")]
	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	[Address(RVA = "0x2504710", Offset = "0x2503B10", Length = "0x46")]
	[Token(Token = "0x600059B")]
	public virtual void Flush() { }

	[Address(RVA = "0x2504590", Offset = "0x2503990", Length = "0x173")]
	[Token(Token = "0x600059C")]
	protected override void FlushBuffer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600059D")]
	private void FlushEncoder() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600058C")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x2504760", Offset = "0x2503B60", Length = "0xB")]
	[Token(Token = "0x60005AD")]
	protected static Byte* GtEntity(Byte* pDst) { }

	[Address(RVA = "0x2504770", Offset = "0x2503B70", Length = "0x176")]
	[Token(Token = "0x60005A7")]
	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	[Address(RVA = "0x25048F0", Offset = "0x2503CF0", Length = "0xA")]
	[Token(Token = "0x60005A5")]
	private static bool IsSurrogateByte(byte b) { }

	[Address(RVA = "0x2504900", Offset = "0x2503D00", Length = "0xF")]
	[Token(Token = "0x60005B1")]
	protected static Byte* LineFeedEntity(Byte* pDst) { }

	[Address(RVA = "0x2504910", Offset = "0x2503D10", Length = "0xB")]
	[Token(Token = "0x60005AC")]
	protected static Byte* LtEntity(Byte* pDst) { }

	[Address(RVA = "0x2504920", Offset = "0x2503D20", Length = "0x11")]
	[Token(Token = "0x60005AF")]
	protected static Byte* QuoteEntity(Byte* pDst) { }

	[Address(RVA = "0x2504940", Offset = "0x2503D40", Length = "0xE")]
	[Token(Token = "0x60005B5")]
	protected static Byte* RawEndCData(Byte* pDst) { }

	[Address(RVA = "0x2504950", Offset = "0x2503D50", Length = "0x16")]
	[Token(Token = "0x60005B4")]
	protected static Byte* RawStartCData(Byte* pDst) { }

	[Address(RVA = "0x2504970", Offset = "0x2503D70", Length = "0x44")]
	[Token(Token = "0x60005A0")]
	protected void RawText(string s) { }

	[Address(RVA = "0x25049C0", Offset = "0x2503DC0", Length = "0x21D")]
	[Token(Token = "0x60005A1")]
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x2504BE0", Offset = "0x2503FE0", Length = "0x3A")]
	[Token(Token = "0x6000586")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x2504C20", Offset = "0x2504020", Length = "0xF")]
	[Token(Token = "0x60005B0")]
	protected static Byte* TabEntity(Byte* pDst) { }

	[Address(RVA = "0x2504C30", Offset = "0x2504030", Length = "0x38E")]
	[Token(Token = "0x60005B6")]
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	[Address(RVA = "0x2504FC0", Offset = "0x25043C0", Length = "0x2CB")]
	[Token(Token = "0x600059E")]
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x2505670", Offset = "0x2504A70", Length = "0x1EA")]
	[Token(Token = "0x600058F")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x2505290", Offset = "0x2504690", Length = "0x3D1")]
	[Token(Token = "0x60005A4")]
	protected void WriteCDataSection(string text) { }

	[Address(RVA = "0x2505860", Offset = "0x2504C60", Length = "0x1B2")]
	[Token(Token = "0x6000593")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x23F5EB0", Offset = "0x23F52B0", Length = "0x47")]
	[Token(Token = "0x6000597")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2505E20", Offset = "0x2505220", Length = "0x117")]
	[Token(Token = "0x6000590")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x2505A20", Offset = "0x2504E20", Length = "0x3F5")]
	[Token(Token = "0x60005A3")]
	protected void WriteCommentOrPi(string text, int stopChar) { }

	[Address(RVA = "0x2505F40", Offset = "0x2505340", Length = "0x2A1")]
	[Token(Token = "0x6000584")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x25061F0", Offset = "0x25055F0", Length = "0x2F5")]
	[Token(Token = "0x600059F")]
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x25064F0", Offset = "0x25058F0", Length = "0x3E")]
	[Token(Token = "0x600058A")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x2506530", Offset = "0x2505930", Length = "0x15B")]
	[Token(Token = "0x6000587")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2506690", Offset = "0x2505A90", Length = "0x3E")]
	[Token(Token = "0x600058E")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x25066D0", Offset = "0x2505AD0", Length = "0xAC")]
	[Token(Token = "0x6000592")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x2506780", Offset = "0x2505B80", Length = "0x107")]
	[Token(Token = "0x6000588")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F4960", Offset = "0x24F3D60", Length = "0x5D")]
	[Token(Token = "0x600058B")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	[Address(RVA = "0x2506890", Offset = "0x2505C90", Length = "0x7B")]
	[Token(Token = "0x60005AB")]
	protected Byte* WriteNewLine(Byte* pDst) { }

	[Address(RVA = "0x2506910", Offset = "0x2505D10", Length = "0x123")]
	[Token(Token = "0x6000591")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x2506D80", Offset = "0x2506180", Length = "0x45")]
	[Token(Token = "0x6000598")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2506DD0", Offset = "0x25061D0", Length = "0x4B")]
	[Token(Token = "0x6000599")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x2506A40", Offset = "0x2505E40", Length = "0x336")]
	[Token(Token = "0x60005A2")]
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x2506E20", Offset = "0x2506220", Length = "0x10E")]
	[Token(Token = "0x6000589")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2506F30", Offset = "0x2506330", Length = "0xCE")]
	[Token(Token = "0x6000585")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2507000", Offset = "0x2506400", Length = "0x127")]
	[Token(Token = "0x600058D")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x2507130", Offset = "0x2506530", Length = "0x59")]
	[Token(Token = "0x6000595")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x2507190", Offset = "0x2506590", Length = "0x140")]
	[Token(Token = "0x6000596")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x2507130", Offset = "0x2506530", Length = "0x59")]
	[Token(Token = "0x6000594")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x2507500", Offset = "0x2506900", Length = "0x66")]
	[Token(Token = "0x6000583")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x25072E0", Offset = "0x25066E0", Length = "0x21E")]
	[Token(Token = "0x6000582")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

