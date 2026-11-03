namespace System.Data;

[Token(Token = "0x20000A4")]
internal sealed class DataTextWriter : XmlWriter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034A")]
	private XmlWriter _xmltextWriter; //Field offset: 0x18

	[Token(Token = "0x1700012E")]
	internal Stream BaseStream
	{
		[Address(RVA = "0x2370650", Offset = "0x236FA50", Length = "0x6E")]
		[Token(Token = "0x600084E")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x1700012F")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x1F6EAC0", Offset = "0x1F6DEC0", Length = "0x2A")]
		[Token(Token = "0x6000865")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2370610", Offset = "0x236FA10", Length = "0x31")]
	[Token(Token = "0x600084D")]
	private DataTextWriter(XmlWriter w) { }

	[Address(RVA = "0x1F6EC50", Offset = "0x1F6E050", Length = "0x2A")]
	[Token(Token = "0x6000866")]
	public virtual void Close() { }

	[Address(RVA = "0x23701F0", Offset = "0x236F5F0", Length = "0x60")]
	[Token(Token = "0x600084C")]
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	[Address(RVA = "0x2370250", Offset = "0x236F650", Length = "0x2A")]
	[Token(Token = "0x6000867")]
	public virtual void Flush() { }

	[Address(RVA = "0x2370650", Offset = "0x236FA50", Length = "0x6E")]
	[Token(Token = "0x600084E")]
	internal Stream get_BaseStream() { }

	[Address(RVA = "0x1F6EAC0", Offset = "0x1F6DEC0", Length = "0x2A")]
	[Token(Token = "0x6000865")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x2370280", Offset = "0x236F680", Length = "0x2A")]
	[Token(Token = "0x6000868")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x23702B0", Offset = "0x236F6B0", Length = "0x2F")]
	[Token(Token = "0x6000863")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x23702E0", Offset = "0x236F6E0", Length = "0x2F")]
	[Token(Token = "0x6000864")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2370310", Offset = "0x236F710", Length = "0x2A")]
	[Token(Token = "0x6000858")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x2370340", Offset = "0x236F740", Length = "0x2A")]
	[Token(Token = "0x600085C")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x2370370", Offset = "0x236F770", Length = "0x2F")]
	[Token(Token = "0x6000860")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x23703A0", Offset = "0x236F7A0", Length = "0x2A")]
	[Token(Token = "0x6000859")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x23703D0", Offset = "0x236F7D0", Length = "0x2F")]
	[Token(Token = "0x6000852")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x1FE3CD0", Offset = "0x1FE30D0", Length = "0x2A")]
	[Token(Token = "0x6000857")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x1FE3A40", Offset = "0x1FE2E40", Length = "0x2A")]
	[Token(Token = "0x6000851")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x1FE3D30", Offset = "0x1FE3130", Length = "0x2A")]
	[Token(Token = "0x6000854")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x2370400", Offset = "0x236F800", Length = "0x2A")]
	[Token(Token = "0x600085B")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x2370430", Offset = "0x236F830", Length = "0x2A")]
	[Token(Token = "0x6000855")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x2370460", Offset = "0x236F860", Length = "0x2A")]
	[Token(Token = "0x600085A")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x2370490", Offset = "0x236F890", Length = "0x2F")]
	[Token(Token = "0x6000861")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x23704C0", Offset = "0x236F8C0", Length = "0x2A")]
	[Token(Token = "0x6000862")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x23704F0", Offset = "0x236F8F0", Length = "0x2F")]
	[Token(Token = "0x6000856")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2230430", Offset = "0x222F830", Length = "0x2A")]
	[Token(Token = "0x600084F")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x2370520", Offset = "0x236F920", Length = "0x2A")]
	[Token(Token = "0x6000850")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x2370550", Offset = "0x236F950", Length = "0x2F")]
	[Token(Token = "0x6000853")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2370580", Offset = "0x236F980", Length = "0x2A")]
	[Token(Token = "0x600085E")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x23705B0", Offset = "0x236F9B0", Length = "0x2A")]
	[Token(Token = "0x600085F")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x23705E0", Offset = "0x236F9E0", Length = "0x2A")]
	[Token(Token = "0x600085D")]
	public virtual void WriteWhitespace(string ws) { }

}

