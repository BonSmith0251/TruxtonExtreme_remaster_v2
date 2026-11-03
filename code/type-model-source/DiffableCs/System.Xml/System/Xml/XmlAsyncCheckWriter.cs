namespace System.Xml;

[Token(Token = "0x2000048")]
internal class XmlAsyncCheckWriter : XmlWriter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000153")]
	private readonly XmlWriter coreWriter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000154")]
	private Task lastTask; //Field offset: 0x20

	[Token(Token = "0x17000076")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x24EFD80", Offset = "0x24EF180", Length = "0x37")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x24EFCF0", Offset = "0x24EF0F0", Length = "0x86")]
	[Token(Token = "0x600023A")]
	public XmlAsyncCheckWriter(XmlWriter writer) { }

	[Address(RVA = "0x24EF2C0", Offset = "0x24EE6C0", Length = "0x8B")]
	[Token(Token = "0x600023B")]
	private void CheckAsync() { }

	[Address(RVA = "0x24EF350", Offset = "0x24EE750", Length = "0x37")]
	[Token(Token = "0x6000253")]
	public virtual void Close() { }

	[Address(RVA = "0x24EF390", Offset = "0x24EE790", Length = "0x2A")]
	[Token(Token = "0x6000259")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x24EF3C0", Offset = "0x24EE7C0", Length = "0x37")]
	[Token(Token = "0x6000254")]
	public virtual void Flush() { }

	[Address(RVA = "0x24EFD80", Offset = "0x24EF180", Length = "0x37")]
	[Token(Token = "0x6000252")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x24EF400", Offset = "0x24EE800", Length = "0x46")]
	[Token(Token = "0x6000255")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x24EF450", Offset = "0x24EE850", Length = "0x58")]
	[Token(Token = "0x6000257")]
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	[Address(RVA = "0x24EF4B0", Offset = "0x24EE8B0", Length = "0x6B")]
	[Token(Token = "0x6000250")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24EF520", Offset = "0x24EE920", Length = "0x6B")]
	[Token(Token = "0x6000251")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24EF590", Offset = "0x24EE990", Length = "0x46")]
	[Token(Token = "0x6000245")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24EF5E0", Offset = "0x24EE9E0", Length = "0x46")]
	[Token(Token = "0x6000249")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24EF630", Offset = "0x24EEA30", Length = "0x6B")]
	[Token(Token = "0x600024D")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24EF6A0", Offset = "0x24EEAA0", Length = "0x46")]
	[Token(Token = "0x6000246")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24EF6F0", Offset = "0x24EEAF0", Length = "0x6B")]
	[Token(Token = "0x600023F")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24EF760", Offset = "0x24EEB60", Length = "0x37")]
	[Token(Token = "0x6000244")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x24EF7A0", Offset = "0x24EEBA0", Length = "0x37")]
	[Token(Token = "0x600023E")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x24EF7E0", Offset = "0x24EEBE0", Length = "0x37")]
	[Token(Token = "0x6000241")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x24EF820", Offset = "0x24EEC20", Length = "0x46")]
	[Token(Token = "0x6000248")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24EF870", Offset = "0x24EEC70", Length = "0x37")]
	[Token(Token = "0x6000242")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x24EF8B0", Offset = "0x24EECB0", Length = "0x58")]
	[Token(Token = "0x6000258")]
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	[Address(RVA = "0x24EF910", Offset = "0x24EED10", Length = "0x56")]
	[Token(Token = "0x6000247")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24EF970", Offset = "0x24EED70", Length = "0x6B")]
	[Token(Token = "0x600024E")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24EF9E0", Offset = "0x24EEDE0", Length = "0x46")]
	[Token(Token = "0x600024F")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24EFA30", Offset = "0x24EEE30", Length = "0x6B")]
	[Token(Token = "0x6000243")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EFAA0", Offset = "0x24EEEA0", Length = "0x47")]
	[Token(Token = "0x600023D")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x24EFAF0", Offset = "0x24EEEF0", Length = "0x37")]
	[Token(Token = "0x600023C")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x24EFB30", Offset = "0x24EEF30", Length = "0x6B")]
	[Token(Token = "0x6000240")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EFBA0", Offset = "0x24EEFA0", Length = "0x46")]
	[Token(Token = "0x600024B")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24EFBF0", Offset = "0x24EEFF0", Length = "0x58")]
	[Token(Token = "0x600024C")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24EFC50", Offset = "0x24EF050", Length = "0x46")]
	[Token(Token = "0x6000256")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x24EFCA0", Offset = "0x24EF0A0", Length = "0x46")]
	[Token(Token = "0x600024A")]
	public virtual void WriteWhitespace(string ws) { }

}

