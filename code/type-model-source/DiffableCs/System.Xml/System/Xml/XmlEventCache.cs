namespace System.Xml;

[Token(Token = "0x200004C")]
internal sealed class XmlEventCache : XmlRawWriter
{
	[Token(Token = "0x200004E")]
	private struct XmlEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A2")]
		private XmlEventType eventType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A3")]
		private string s1; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A4")]
		private string s2; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A5")]
		private string s3; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A6")]
		private object o; //Field offset: 0x20

		[Token(Token = "0x1700007A")]
		public XmlEventType EventType
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x60002FB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007E")]
		public object Object
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60002FF")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700007B")]
		public string String1
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x60002FC")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700007C")]
		public string String2
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60002FD")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700007D")]
		public string String3
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60002FE")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60002FB")]
		public XmlEventType get_EventType() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60002FF")]
		public object get_Object() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x60002FC")]
		public string get_String1() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002FD")]
		public string get_String2() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002FE")]
		public string get_String3() { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60002F5")]
		public void InitEvent(XmlEventType eventType) { }

		[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
		[Token(Token = "0x60002F6")]
		public void InitEvent(XmlEventType eventType, string s1) { }

		[Address(RVA = "0x24F76C0", Offset = "0x24F6AC0", Length = "0x3C")]
		[Token(Token = "0x60002F7")]
		public void InitEvent(XmlEventType eventType, string s1, string s2) { }

		[Address(RVA = "0x24F7780", Offset = "0x24F6B80", Length = "0x4E")]
		[Token(Token = "0x60002F8")]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

		[Address(RVA = "0x24F7720", Offset = "0x24F6B20", Length = "0x60")]
		[Token(Token = "0x60002F9")]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

		[Address(RVA = "0x24F7700", Offset = "0x24F6B00", Length = "0x12")]
		[Token(Token = "0x60002FA")]
		public void InitEvent(XmlEventType eventType, object o) { }

	}

	[Token(Token = "0x200004D")]
	private enum XmlEventType : int
	{
		Unknown = 0,
		DocType = 1,
		StartElem = 2,
		StartAttr = 3,
		EndAttr = 4,
		CData = 5,
		Comment = 6,
		PI = 7,
		Whitespace = 8,
		String = 9,
		Raw = 10,
		EntRef = 11,
		CharEnt = 12,
		SurrCharEnt = 13,
		Base64 = 14,
		BinHex = 15,
		XmlDecl1 = 16,
		XmlDecl2 = 17,
		StartContent = 18,
		EndElem = 19,
		FullEndElem = 20,
		Nmsp = 21,
		EndBase64 = 22,
		Close = 23,
		Flush = 24,
		Dispose = 25,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000181")]
	private List<XmlEvent[]> pages; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000182")]
	private XmlEvent[] pageCurr; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000183")]
	private int pageSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000184")]
	private bool hasRootNode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000185")]
	private StringConcat singleText; //Field offset: 0x40
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000186")]
	private string baseUri; //Field offset: 0x78

	[Address(RVA = "0x24F7670", Offset = "0x24F6A70", Length = "0x44")]
	[Token(Token = "0x60002CE")]
	public XmlEventCache(string baseUri, bool hasRootNode) { }

	[Address(RVA = "0x24F5E40", Offset = "0x24F5240", Length = "0x67")]
	[Token(Token = "0x60002F2")]
	private void AddEvent(XmlEventType eventType, object o) { }

	[Address(RVA = "0x24F5EB0", Offset = "0x24F52B0", Length = "0xA5")]
	[Token(Token = "0x60002F1")]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	[Address(RVA = "0x24F5D50", Offset = "0x24F5150", Length = "0x93")]
	[Token(Token = "0x60002F0")]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	[Address(RVA = "0x24F5FD0", Offset = "0x24F53D0", Length = "0x81")]
	[Token(Token = "0x60002EF")]
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	[Address(RVA = "0x24F5F60", Offset = "0x24F5360", Length = "0x67")]
	[Token(Token = "0x60002EE")]
	private void AddEvent(XmlEventType eventType, string s1) { }

	[Address(RVA = "0x24F5DF0", Offset = "0x24F51F0", Length = "0x46")]
	[Token(Token = "0x60002ED")]
	private void AddEvent(XmlEventType eventType) { }

	[Address(RVA = "0x24F6060", Offset = "0x24F5460", Length = "0x3D")]
	[Token(Token = "0x60002E2")]
	public virtual void Close() { }

	[Address(RVA = "0x24F60A0", Offset = "0x24F54A0", Length = "0xA2")]
	[Token(Token = "0x60002E5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x24F6150", Offset = "0x24F5550", Length = "0x43")]
	[Token(Token = "0x60002CF")]
	public void EndEvents() { }

	[Address(RVA = "0x24F61A0", Offset = "0x24F55A0", Length = "0x17C")]
	[Token(Token = "0x60002D0")]
	public void EventsToWriter(XmlWriter writer) { }

	[Address(RVA = "0x24F6BA0", Offset = "0x24F5FA0", Length = "0x3D")]
	[Token(Token = "0x60002E3")]
	public virtual void Flush() { }

	[Address(RVA = "0x24F6BE0", Offset = "0x24F5FE0", Length = "0x184")]
	[Token(Token = "0x60002F3")]
	private int NewEvent() { }

	[Address(RVA = "0x24F6D70", Offset = "0x24F6170", Length = "0x3D")]
	[Token(Token = "0x60002E8")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24F6DB0", Offset = "0x24F61B0", Length = "0xB2")]
	[Token(Token = "0x60002F4")]
	private static Byte[] ToBytes(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F6E70", Offset = "0x24F6270", Length = "0x7A")]
	[Token(Token = "0x60002E0")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F6EF0", Offset = "0x24F62F0", Length = "0x7A")]
	[Token(Token = "0x60002E1")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F6F70", Offset = "0x24F6370", Length = "0x5F")]
	[Token(Token = "0x60002D5")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24F6FD0", Offset = "0x24F63D0", Length = "0x77")]
	[Token(Token = "0x60002DE")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24F0380", Offset = "0x24EF780", Length = "0x38")]
	[Token(Token = "0x60002DA")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F7050", Offset = "0x24F6450", Length = "0x5F")]
	[Token(Token = "0x60002D6")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24F70B0", Offset = "0x24F64B0", Length = "0xA8")]
	[Token(Token = "0x60002D1")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24F7160", Offset = "0x24F6560", Length = "0x3D")]
	[Token(Token = "0x60002D4")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x24F71A0", Offset = "0x24F65A0", Length = "0x3D")]
	[Token(Token = "0x60002EC")]
	internal virtual void WriteEndBase64() { }

	[Address(RVA = "0x24F71E0", Offset = "0x24F65E0", Length = "0x27")]
	[Token(Token = "0x60002E9")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F7210", Offset = "0x24F6610", Length = "0x5F")]
	[Token(Token = "0x60002DD")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24F7270", Offset = "0x24F6670", Length = "0x27")]
	[Token(Token = "0x60002EA")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F72A0", Offset = "0x24F66A0", Length = "0x22")]
	[Token(Token = "0x60002EB")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x24F72D0", Offset = "0x24F66D0", Length = "0x22")]
	[Token(Token = "0x60002D7")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24F7300", Offset = "0x24F6700", Length = "0x5F")]
	[Token(Token = "0x60002DC")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24F0620", Offset = "0x24EFA20", Length = "0x38")]
	[Token(Token = "0x60002DB")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F7360", Offset = "0x24F6760", Length = "0x27")]
	[Token(Token = "0x60002D3")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F7390", Offset = "0x24F6790", Length = "0x27")]
	[Token(Token = "0x60002D2")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F73C0", Offset = "0x24F67C0", Length = "0x7C")]
	[Token(Token = "0x60002D9")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24F7440", Offset = "0x24F6840", Length = "0xC1")]
	[Token(Token = "0x60002DF")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x60002E4")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x24F7510", Offset = "0x24F6910", Length = "0x5F")]
	[Token(Token = "0x60002D8")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x24F7570", Offset = "0x24F6970", Length = "0x94")]
	[Token(Token = "0x60002E6")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x24F7610", Offset = "0x24F6A10", Length = "0x5F")]
	[Token(Token = "0x60002E7")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

