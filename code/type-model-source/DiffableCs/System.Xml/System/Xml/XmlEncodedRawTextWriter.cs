namespace System.Xml;

[Token(Token = "0x200004A")]
internal class XmlEncodedRawTextWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015B")]
	private readonly bool useAsync; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015C")]
	protected Byte[] bufBytes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400015D")]
	protected Stream stream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400015E")]
	protected Encoding encoding; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400015F")]
	protected XmlCharType xmlCharType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000160")]
	protected int bufPos; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000161")]
	protected int textPos; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000162")]
	protected int contentPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000163")]
	protected int cdataPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000164")]
	protected int attrEndPos; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000165")]
	protected int bufLen; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000166")]
	protected bool writeToNull; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000167")]
	protected bool hadDoubleBracket; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x4000168")]
	protected bool inAttributeValue; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000169")]
	protected int bufBytesUsed; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400016A")]
	protected Char[] bufChars; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400016B")]
	protected Encoder encoder; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400016C")]
	protected TextWriter writer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400016D")]
	protected bool trackTextContent; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x400016E")]
	protected bool inTextContent; //Field offset: 0x89
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400016F")]
	private int lastMarkPos; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000170")]
	private Int32[] textContentMarks; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000171")]
	private CharEntityEncoderFallback charEntityFallback; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000172")]
	protected NewLineHandling newLineHandling; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000173")]
	protected bool closeOutput; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA5")]
	[Token(Token = "0x4000174")]
	protected bool omitXmlDeclaration; //Field offset: 0xA5
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000175")]
	protected string newLineChars; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000176")]
	protected bool checkCharacters; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000177")]
	protected XmlStandalone standalone; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000178")]
	protected XmlOutputMethod outputMethod; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000179")]
	protected bool autoXmlDeclaration; //Field offset: 0xBC
	[FieldOffset(Offset = "0xBD")]
	[Token(Token = "0x400017A")]
	protected bool mergeCDataSections; //Field offset: 0xBD

	[Token(Token = "0x17000079")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600028C")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x24F57C0", Offset = "0x24F4BC0", Length = "0x10D")]
	[Token(Token = "0x600027F")]
	protected XmlEncodedRawTextWriter(XmlWriterSettings settings) { }

	[Address(RVA = "0x24F5C50", Offset = "0x24F5050", Length = "0xFC")]
	[Token(Token = "0x6000280")]
	public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x24F58D0", Offset = "0x24F4CD0", Length = "0x37B")]
	[Token(Token = "0x6000281")]
	public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x24F1AB0", Offset = "0x24F0EB0", Length = "0x18")]
	[Token(Token = "0x60002AE")]
	protected static Char* AmpEntity(Char* pDst) { }

	[Address(RVA = "0x24F1AD0", Offset = "0x24F0ED0", Length = "0x18")]
	[Token(Token = "0x60002B2")]
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	[Address(RVA = "0x24F1AF0", Offset = "0x24F0EF0", Length = "0xEC")]
	[Token(Token = "0x60002A9")]
	protected void ChangeTextContentMark(bool value) { }

	[Address(RVA = "0x24F1BE0", Offset = "0x24F0FE0", Length = "0xAA")]
	[Token(Token = "0x60002B3")]
	private static Char* CharEntity(Char* pDst, char ch) { }

	[Address(RVA = "0x24F1C90", Offset = "0x24F1090", Length = "0x6B")]
	[Token(Token = "0x600029A")]
	public virtual void Close() { }

	[Address(RVA = "0x24F1D00", Offset = "0x24F1100", Length = "0xDA")]
	[Token(Token = "0x60002A8")]
	internal void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Char* pDst) { }

	[Address(RVA = "0x24F1DE0", Offset = "0x24F11E0", Length = "0x17A")]
	[Token(Token = "0x600029D")]
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	[Address(RVA = "0x24F1F60", Offset = "0x24F1360", Length = "0x16E")]
	[Token(Token = "0x60002A6")]
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	[Address(RVA = "0x24F2590", Offset = "0x24F1990", Length = "0x84")]
	[Token(Token = "0x600029B")]
	public virtual void Flush() { }

	[Address(RVA = "0x24F20D0", Offset = "0x24F14D0", Length = "0x3D3")]
	[Token(Token = "0x600029C")]
	protected override void FlushBuffer() { }

	[Address(RVA = "0x24F24B0", Offset = "0x24F18B0", Length = "0xD0")]
	[Token(Token = "0x600029E")]
	private void FlushEncoder() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600028C")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x24F2620", Offset = "0x24F1A20", Length = "0x91")]
	[Token(Token = "0x60002AA")]
	private void GrowTextContentMarks() { }

	[Address(RVA = "0x24F26C0", Offset = "0x24F1AC0", Length = "0x12")]
	[Token(Token = "0x60002AD")]
	protected static Char* GtEntity(Char* pDst) { }

	[Address(RVA = "0x24F26E0", Offset = "0x24F1AE0", Length = "0x105")]
	[Token(Token = "0x60002A7")]
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	[Address(RVA = "0x24F27F0", Offset = "0x24F1BF0", Length = "0x18")]
	[Token(Token = "0x60002B1")]
	protected static Char* LineFeedEntity(Char* pDst) { }

	[Address(RVA = "0x24F2810", Offset = "0x24F1C10", Length = "0x12")]
	[Token(Token = "0x60002AC")]
	protected static Char* LtEntity(Char* pDst) { }

	[Address(RVA = "0x24F2830", Offset = "0x24F1C30", Length = "0x19")]
	[Token(Token = "0x60002AF")]
	protected static Char* QuoteEntity(Char* pDst) { }

	[Address(RVA = "0x24F2850", Offset = "0x24F1C50", Length = "0x11")]
	[Token(Token = "0x60002B5")]
	protected static Char* RawEndCData(Char* pDst) { }

	[Address(RVA = "0x24F2870", Offset = "0x24F1C70", Length = "0x2B")]
	[Token(Token = "0x60002B4")]
	protected static Char* RawStartCData(Char* pDst) { }

	[Address(RVA = "0x24F28A0", Offset = "0x24F1CA0", Length = "0x1A2")]
	[Token(Token = "0x60002A2")]
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x24F2A50", Offset = "0x24F1E50", Length = "0x44")]
	[Token(Token = "0x60002A1")]
	protected void RawText(string s) { }

	[Address(RVA = "0x24F2AA0", Offset = "0x24F1EA0", Length = "0x3C")]
	[Token(Token = "0x6000286")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24F2AE0", Offset = "0x24F1EE0", Length = "0x18")]
	[Token(Token = "0x60002B0")]
	protected static Char* TabEntity(Char* pDst) { }

	[Address(RVA = "0x24F2B00", Offset = "0x24F1F00", Length = "0x38E")]
	[Token(Token = "0x60002B6")]
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	[Address(RVA = "0x24F2E90", Offset = "0x24F2290", Length = "0x314")]
	[Token(Token = "0x600029F")]
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x24F3590", Offset = "0x24F2990", Length = "0x23B")]
	[Token(Token = "0x600028F")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24F31B0", Offset = "0x24F25B0", Length = "0x3D4")]
	[Token(Token = "0x60002A5")]
	protected void WriteCDataSection(string text) { }

	[Address(RVA = "0x24F37D0", Offset = "0x24F2BD0", Length = "0x1D9")]
	[Token(Token = "0x6000293")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x23F45A0", Offset = "0x23F39A0", Length = "0x8A")]
	[Token(Token = "0x6000297")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F3D90", Offset = "0x24F3190", Length = "0x153")]
	[Token(Token = "0x6000290")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24F39B0", Offset = "0x24F2DB0", Length = "0x3D3")]
	[Token(Token = "0x60002A4")]
	protected void WriteCommentOrPi(string text, int stopChar) { }

	[Address(RVA = "0x24F3EF0", Offset = "0x24F32F0", Length = "0x2CA")]
	[Token(Token = "0x6000284")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24F41C0", Offset = "0x24F35C0", Length = "0x34F")]
	[Token(Token = "0x60002A0")]
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x24F4510", Offset = "0x24F3910", Length = "0x5F")]
	[Token(Token = "0x600028A")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x24F4570", Offset = "0x24F3970", Length = "0x17F")]
	[Token(Token = "0x6000287")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F46F0", Offset = "0x24F3AF0", Length = "0x5F")]
	[Token(Token = "0x600028E")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x24F4750", Offset = "0x24F3B50", Length = "0xD1")]
	[Token(Token = "0x6000292")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24F4830", Offset = "0x24F3C30", Length = "0x12B")]
	[Token(Token = "0x6000288")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F4960", Offset = "0x24F3D60", Length = "0x5D")]
	[Token(Token = "0x600028B")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	[Address(RVA = "0x24F49C0", Offset = "0x24F3DC0", Length = "0x8B")]
	[Token(Token = "0x60002AB")]
	protected Char* WriteNewLine(Char* pDst) { }

	[Address(RVA = "0x24F4A50", Offset = "0x24F3E50", Length = "0x14E")]
	[Token(Token = "0x6000291")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24F4E50", Offset = "0x24F4250", Length = "0x83")]
	[Token(Token = "0x6000298")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24ED220", Offset = "0x24EC620", Length = "0x67")]
	[Token(Token = "0x6000299")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24F4BA0", Offset = "0x24F3FA0", Length = "0x2AB")]
	[Token(Token = "0x60002A3")]
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	[Address(RVA = "0x24F4EE0", Offset = "0x24F42E0", Length = "0x136")]
	[Token(Token = "0x6000289")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F5020", Offset = "0x24F4420", Length = "0xEB")]
	[Token(Token = "0x6000285")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F5110", Offset = "0x24F4510", Length = "0x171")]
	[Token(Token = "0x600028D")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x24F5290", Offset = "0x24F4690", Length = "0x75")]
	[Token(Token = "0x6000295")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24F5310", Offset = "0x24F4710", Length = "0x167")]
	[Token(Token = "0x6000296")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24F5480", Offset = "0x24F4880", Length = "0x75")]
	[Token(Token = "0x6000294")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x24F5750", Offset = "0x24F4B50", Length = "0x69")]
	[Token(Token = "0x6000283")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x24F5500", Offset = "0x24F4900", Length = "0x240")]
	[Token(Token = "0x6000282")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

