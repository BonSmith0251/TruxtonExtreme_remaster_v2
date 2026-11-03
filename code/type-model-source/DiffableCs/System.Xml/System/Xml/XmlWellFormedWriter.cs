namespace System.Xml;

[Token(Token = "0x2000073")]
internal class XmlWellFormedWriter : XmlWriter
{
	[Token(Token = "0x200007C")]
	private class AttributeValueCache
	{
		[Token(Token = "0x200007F")]
		private class BufferChunk
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400039E")]
			internal Char[] buffer; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400039F")]
			internal int index; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x40003A0")]
			internal int count; //Field offset: 0x1C

			[Address(RVA = "0x16B7820", Offset = "0x16B6C20", Length = "0x52")]
			[Token(Token = "0x600067A")]
			internal BufferChunk(Char[] buffer, int index, int count) { }

		}

		[Token(Token = "0x200007E")]
		private class Item
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400039C")]
			internal ItemType type; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400039D")]
			internal object data; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000678")]
			internal Item() { }

			[Address(RVA = "0x1F16800", Offset = "0x1F15C00", Length = "0x13")]
			[Token(Token = "0x6000679")]
			internal void Set(ItemType type, object data) { }

		}

		[Token(Token = "0x200007D")]
		private enum ItemType : int
		{
			EntityRef = 0,
			CharEntity = 1,
			SurrogateCharEntity = 2,
			Whitespace = 3,
			String = 4,
			StringChars = 5,
			Raw = 6,
			RawChars = 7,
			ValueString = 8,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400038D")]
		private StringBuilder stringValue; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400038E")]
		private string singleStringValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400038F")]
		private Item[] items; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000390")]
		private int firstItem; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000391")]
		private int lastItem; //Field offset: 0x2C

		[Token(Token = "0x17000168")]
		internal string StringValue
		{
			[Address(RVA = "0x2510860", Offset = "0x250FC60", Length = "0x3A")]
			[Token(Token = "0x6000668")]
			internal get { } //Length: 58
		}

		[Address(RVA = "0x25107F0", Offset = "0x250FBF0", Length = "0x6D")]
		[Token(Token = "0x6000677")]
		public AttributeValueCache() { }

		[Address(RVA = "0x250F4B0", Offset = "0x250E8B0", Length = "0x187")]
		[Token(Token = "0x6000676")]
		private void AddItem(ItemType type, object data) { }

		[Address(RVA = "0x250F640", Offset = "0x250EA40", Length = "0x47")]
		[Token(Token = "0x6000674")]
		internal void Clear() { }

		[Address(RVA = "0x2510860", Offset = "0x250FC60", Length = "0x3A")]
		[Token(Token = "0x6000668")]
		internal string get_StringValue() { }

		[Address(RVA = "0x250F690", Offset = "0x250EA90", Length = "0xB4")]
		[Token(Token = "0x6000672")]
		internal void Replay(XmlWriter writer) { }

		[Address(RVA = "0x250FAD0", Offset = "0x250EED0", Length = "0x4F")]
		[Token(Token = "0x6000675")]
		private void StartComplexValue() { }

		[Address(RVA = "0x250FB20", Offset = "0x250EF20", Length = "0x4A0")]
		[Token(Token = "0x6000673")]
		internal void Trim() { }

		[Address(RVA = "0x250FFF0", Offset = "0x250F3F0", Length = "0xAA")]
		[Token(Token = "0x600066A")]
		internal void WriteCharEntity(char ch) { }

		[Address(RVA = "0x25100A0", Offset = "0x250F4A0", Length = "0x104")]
		[Token(Token = "0x600066E")]
		internal void WriteChars(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x25101B0", Offset = "0x250F5B0", Length = "0x1C2")]
		[Token(Token = "0x6000669")]
		internal void WriteEntityRef(string name) { }

		[Address(RVA = "0x2510410", Offset = "0x250F810", Length = "0x104")]
		[Token(Token = "0x600066F")]
		internal void WriteRaw(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x2510380", Offset = "0x250F780", Length = "0x89")]
		[Token(Token = "0x6000670")]
		internal void WriteRaw(string data) { }

		[Address(RVA = "0x2510520", Offset = "0x250F920", Length = "0xA6")]
		[Token(Token = "0x600066D")]
		internal void WriteString(string text) { }

		[Address(RVA = "0x25105D0", Offset = "0x250F9D0", Length = "0xFB")]
		[Token(Token = "0x600066B")]
		internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

		[Address(RVA = "0x25106D0", Offset = "0x250FAD0", Length = "0x89")]
		[Token(Token = "0x6000671")]
		internal void WriteValue(string value) { }

		[Address(RVA = "0x2510760", Offset = "0x250FB60", Length = "0x89")]
		[Token(Token = "0x600066C")]
		internal void WriteWhitespace(string ws) { }

	}

	[Token(Token = "0x200007A")]
	private struct AttrName
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000383")]
		internal string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000384")]
		internal string namespaceUri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000385")]
		internal string localName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000386")]
		internal int prev; //Field offset: 0x18

		[Address(RVA = "0x250F2E0", Offset = "0x250E6E0", Length = "0x80")]
		[Token(Token = "0x6000667")]
		internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

		[Address(RVA = "0x250F360", Offset = "0x250E760", Length = "0x57")]
		[Token(Token = "0x6000666")]
		internal void Set(string prefix, string localName, string namespaceUri) { }

	}

	[Token(Token = "0x2000077")]
	private struct ElementScope
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000374")]
		internal int prevNSTop; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000375")]
		internal string prefix; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000376")]
		internal string localName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000377")]
		internal string namespaceUri; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000378")]
		internal XmlSpace xmlSpace; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000379")]
		internal string xmlLang; //Field offset: 0x28

		[Address(RVA = "0x24FDB30", Offset = "0x24FCF30", Length = "0x74")]
		[Token(Token = "0x6000661")]
		internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

		[Address(RVA = "0x24FDBB0", Offset = "0x24FCFB0", Length = "0x3E")]
		[Token(Token = "0x6000662")]
		internal void WriteEndElement(XmlRawWriter rawWriter) { }

		[Address(RVA = "0x24FDBF0", Offset = "0x24FCFF0", Length = "0x3E")]
		[Token(Token = "0x6000663")]
		internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

	}

	[Token(Token = "0x2000079")]
	private struct Namespace
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037F")]
		internal string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000380")]
		internal string namespaceUri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000381")]
		internal NamespaceKind kind; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000382")]
		internal int prevNsIndex; //Field offset: 0x14

		[Address(RVA = "0x24FDCC0", Offset = "0x24FD0C0", Length = "0x4A")]
		[Token(Token = "0x6000664")]
		internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

		[Address(RVA = "0x24FDD60", Offset = "0x24FD160", Length = "0x12D")]
		[Token(Token = "0x6000665")]
		internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

	}

	[Token(Token = "0x2000078")]
	private enum NamespaceKind : int
	{
		Written = 0,
		NeedToWrite = 1,
		Implied = 2,
		Special = 3,
	}

	[Token(Token = "0x2000076")]
	private class NamespaceResolverProxy : IXmlNamespaceResolver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000373")]
		private XmlWellFormedWriter wfWriter; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600065D")]
		internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter) { }

		[Address(RVA = "0x24FDC30", Offset = "0x24FD030", Length = "0x3E")]
		[Token(Token = "0x600065E")]
		private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

		[Address(RVA = "0x24FDC70", Offset = "0x24FD070", Length = "0x1E")]
		[Token(Token = "0x600065F")]
		private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

		[Address(RVA = "0x24FDC90", Offset = "0x24FD090", Length = "0x2A")]
		[Token(Token = "0x6000660")]
		private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	}

	[Token(Token = "0x200007B")]
	private enum SpecialAttribute : int
	{
		No = 0,
		DefaultXmlns = 1,
		PrefixedXmlns = 2,
		XmlSpace = 3,
		XmlLang = 4,
	}

	[Token(Token = "0x2000074")]
	private enum State : int
	{
		Start = 0,
		TopLevel = 1,
		Document = 2,
		Element = 3,
		Content = 4,
		B64Content = 5,
		B64Attribute = 6,
		AfterRootEle = 7,
		Attribute = 8,
		SpecialAttr = 9,
		EndDocument = 10,
		RootLevelAttr = 11,
		RootLevelSpecAttr = 12,
		RootLevelB64Attr = 13,
		AfterRootLevelAttr = 14,
		Closed = 15,
		Error = 16,
		StartContent = 101,
		StartContentEle = 102,
		StartContentB64 = 103,
		StartDoc = 104,
		StartDocEle = 106,
		EndAttrSEle = 107,
		EndAttrEEle = 108,
		EndAttrSCont = 109,
		EndAttrSAttr = 111,
		PostB64Cont = 112,
		PostB64Attr = 113,
		PostB64RootAttr = 114,
		StartFragEle = 115,
		StartFragCont = 116,
		StartFragB64 = 117,
		StartRootLevelAttr = 118,
	}

	[Token(Token = "0x2000075")]
	private enum Token : int
	{
		StartDocument = 0,
		EndDocument = 1,
		PI = 2,
		Comment = 3,
		Dtd = 4,
		StartElement = 5,
		EndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Text = 9,
		CData = 10,
		AtomicValue = 11,
		Base64 = 12,
		RawData = 13,
		Whitespace = 14,
	}

	[Token(Token = "0x400033C")]
	internal static readonly String[] stateName; //Field offset: 0x0
	[Token(Token = "0x400033D")]
	internal static readonly String[] tokenName; //Field offset: 0x8
	[Token(Token = "0x400033E")]
	private static WriteState[] state2WriteState; //Field offset: 0x10
	[Token(Token = "0x400033F")]
	private static readonly State[] StateTableDocument; //Field offset: 0x18
	[Token(Token = "0x4000340")]
	private static readonly State[] StateTableAuto; //Field offset: 0x20
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000323")]
	private XmlWriter writer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000324")]
	private XmlRawWriter rawWriter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000325")]
	private IXmlNamespaceResolver predefinedNamespaces; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000326")]
	private Namespace[] nsStack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000327")]
	private int nsTop; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000328")]
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000329")]
	private bool useNsHashtable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400032A")]
	private ElementScope[] elemScopeStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400032B")]
	private int elemTop; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400032C")]
	private AttrName[] attrStack; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400032D")]
	private int attrCount; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400032E")]
	private Dictionary<String, Int32> attrHashTable; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400032F")]
	private SpecialAttribute specAttr; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000330")]
	private AttributeValueCache attrValueCache; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000331")]
	private string curDeclPrefix; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000332")]
	private State[] stateTable; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000333")]
	private State currentState; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000334")]
	private bool checkCharacters; //Field offset: 0x9C
	[FieldOffset(Offset = "0x9D")]
	[Token(Token = "0x4000335")]
	private bool omitDuplNamespaces; //Field offset: 0x9D
	[FieldOffset(Offset = "0x9E")]
	[Token(Token = "0x4000336")]
	private bool writeEndDocumentOnClose; //Field offset: 0x9E
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000337")]
	private ConformanceLevel conformanceLevel; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000338")]
	private bool dtdWritten; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA5")]
	[Token(Token = "0x4000339")]
	private bool xmlDeclFollows; //Field offset: 0xA5
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400033A")]
	private XmlCharType xmlCharType; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400033B")]
	private SecureStringHasher hasher; //Field offset: 0xB0

	[Token(Token = "0x17000166")]
	private bool InBase64
	{
		[Address(RVA = "0x250F210", Offset = "0x250E610", Length = "0x20")]
		[Token(Token = "0x6000645")]
		private get { } //Length: 32
	}

	[Token(Token = "0x17000167")]
	private bool IsClosedOrErrorState
	{
		[Address(RVA = "0x250F230", Offset = "0x250E630", Length = "0xB")]
		[Token(Token = "0x6000659")]
		private get { } //Length: 11
	}

	[Token(Token = "0x17000164")]
	internal XmlRawWriter RawWriter
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000643")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000165")]
	private bool SaveAttrValue
	{
		[Address(RVA = "0x243ED30", Offset = "0x243E130", Length = "0x8")]
		[Token(Token = "0x6000644")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000163")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x250F240", Offset = "0x250E640", Length = "0x89")]
		[Token(Token = "0x6000628")]
		 get { } //Length: 137
	}

	[Address(RVA = "0x250E530", Offset = "0x250D930", Length = "0x759")]
	[Token(Token = "0x600065C")]
	private static XmlWellFormedWriter() { }

	[Address(RVA = "0x250EC90", Offset = "0x250E090", Length = "0x57C")]
	[Token(Token = "0x6000627")]
	internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x25090E0", Offset = "0x25084E0", Length = "0x2D4")]
	[Token(Token = "0x600065A")]
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	[Address(RVA = "0x25093C0", Offset = "0x25087C0", Length = "0x189")]
	[Token(Token = "0x600064B")]
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	[Address(RVA = "0x2509550", Offset = "0x2508950", Length = "0x148")]
	[Token(Token = "0x600065B")]
	private void AddToAttrHashTable(int attributeIndex) { }

	[Address(RVA = "0x25096A0", Offset = "0x2508AA0", Length = "0xD2")]
	[Token(Token = "0x600064C")]
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	[Address(RVA = "0x2509780", Offset = "0x2508B80", Length = "0x8C")]
	[Token(Token = "0x6000650")]
	private void AdvanceState(Token token) { }

	[Address(RVA = "0x2509BB0", Offset = "0x2508FB0", Length = "0x143")]
	[Token(Token = "0x6000656")]
	private void CheckNCName(string ncname) { }

	[Address(RVA = "0x2509D00", Offset = "0x2509100", Length = "0x13F")]
	[Token(Token = "0x600063E")]
	public virtual void Close() { }

	[Address(RVA = "0x2509E40", Offset = "0x2509240", Length = "0xFB")]
	[Token(Token = "0x600064F")]
	private static XmlException DupAttrException(string prefix, string localName) { }

	[Address(RVA = "0x2509F40", Offset = "0x2509340", Length = "0x5A")]
	[Token(Token = "0x600063F")]
	public virtual void Flush() { }

	[Address(RVA = "0x2509FA0", Offset = "0x25093A0", Length = "0x13A")]
	[Token(Token = "0x6000655")]
	private string GeneratePrefix() { }

	[Address(RVA = "0x250F210", Offset = "0x250E610", Length = "0x20")]
	[Token(Token = "0x6000645")]
	private bool get_InBase64() { }

	[Address(RVA = "0x250F230", Offset = "0x250E630", Length = "0xB")]
	[Token(Token = "0x6000659")]
	private bool get_IsClosedOrErrorState() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000643")]
	internal XmlRawWriter get_RawWriter() { }

	[Address(RVA = "0x243ED30", Offset = "0x243E130", Length = "0x8")]
	[Token(Token = "0x6000644")]
	private bool get_SaveAttrValue() { }

	[Address(RVA = "0x250F240", Offset = "0x250E640", Length = "0x89")]
	[Token(Token = "0x6000628")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x250A0E0", Offset = "0x25094E0", Length = "0x8C")]
	[Token(Token = "0x6000652")]
	private static string GetStateName(State state) { }

	[Address(RVA = "0x250A170", Offset = "0x2509570", Length = "0x11E")]
	[Token(Token = "0x6000657")]
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	[Address(RVA = "0x250A290", Offset = "0x2509690", Length = "0xBC")]
	[Token(Token = "0x6000654")]
	private string LookupLocalNamespace(string prefix) { }

	[Address(RVA = "0x250A440", Offset = "0x2509840", Length = "0xE7")]
	[Token(Token = "0x6000653")]
	internal string LookupNamespace(string prefix) { }

	[Address(RVA = "0x250A350", Offset = "0x2509750", Length = "0xE7")]
	[Token(Token = "0x600064D")]
	private int LookupNamespaceIndex(string prefix) { }

	[Address(RVA = "0x250A530", Offset = "0x2509930", Length = "0x1B4")]
	[Token(Token = "0x6000640")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x250A6F0", Offset = "0x2509AF0", Length = "0xE8")]
	[Token(Token = "0x600064E")]
	private void PopNamespaces(int indexFrom, int indexTo) { }

	[Address(RVA = "0x250A7E0", Offset = "0x2509BE0", Length = "0x562")]
	[Token(Token = "0x600064A")]
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	[Address(RVA = "0x250AD50", Offset = "0x250A150", Length = "0x45B")]
	[Token(Token = "0x6000649")]
	private void PushNamespaceImplicit(string prefix, string ns) { }

	[Address(RVA = "0x250B1B0", Offset = "0x250A5B0", Length = "0x9A")]
	[Token(Token = "0x6000646")]
	private void SetSpecialAttribute(SpecialAttribute special) { }

	[Address(RVA = "0x250B250", Offset = "0x250A650", Length = "0x1CF")]
	[Token(Token = "0x6000651")]
	private void StartElementContent() { }

	[Address(RVA = "0x250B420", Offset = "0x250A820", Length = "0xB")]
	[Token(Token = "0x6000648")]
	private void StartFragment() { }

	[Address(RVA = "0x250B430", Offset = "0x250A830", Length = "0x213")]
	[Token(Token = "0x6000658")]
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	[Address(RVA = "0x250B650", Offset = "0x250AA50", Length = "0x1DB")]
	[Token(Token = "0x600063D")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x250B830", Offset = "0x250AC30", Length = "0xEC")]
	[Token(Token = "0x6000642")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x250B920", Offset = "0x250AD20", Length = "0x92")]
	[Token(Token = "0x6000632")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x250B9C0", Offset = "0x250ADC0", Length = "0x11C")]
	[Token(Token = "0x6000636")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x250BAE0", Offset = "0x250AEE0", Length = "0x20D")]
	[Token(Token = "0x600063A")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x250BCF0", Offset = "0x250B0F0", Length = "0x92")]
	[Token(Token = "0x6000633")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x250BD90", Offset = "0x250B190", Length = "0x468")]
	[Token(Token = "0x600062C")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x250C200", Offset = "0x250B600", Length = "0x8AB")]
	[Token(Token = "0x6000631")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x250CAB0", Offset = "0x250BEB0", Length = "0x101")]
	[Token(Token = "0x600062B")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x250CBC0", Offset = "0x250BFC0", Length = "0x1BE")]
	[Token(Token = "0x600062E")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x250CD80", Offset = "0x250C180", Length = "0x10C")]
	[Token(Token = "0x6000635")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x250CE90", Offset = "0x250C290", Length = "0x1BE")]
	[Token(Token = "0x600062F")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x250D050", Offset = "0x250C450", Length = "0x24B")]
	[Token(Token = "0x6000634")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x250D2A0", Offset = "0x250C6A0", Length = "0xA8")]
	[Token(Token = "0x600063C")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x250D350", Offset = "0x250C750", Length = "0x20D")]
	[Token(Token = "0x600063B")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x250D560", Offset = "0x250C960", Length = "0x6B7")]
	[Token(Token = "0x6000630")]
	public virtual void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	[Address(RVA = "0x250DDE0", Offset = "0x250D1E0", Length = "0xA")]
	[Token(Token = "0x6000629")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x250DDB0", Offset = "0x250D1B0", Length = "0x22")]
	[Token(Token = "0x600062A")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x250DC20", Offset = "0x250D020", Length = "0x188")]
	[Token(Token = "0x6000647")]
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	[Address(RVA = "0x250DDF0", Offset = "0x250D1F0", Length = "0x363")]
	[Token(Token = "0x600062D")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x250E160", Offset = "0x250D560", Length = "0xA8")]
	[Token(Token = "0x6000639")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x250E210", Offset = "0x250D610", Length = "0x11D")]
	[Token(Token = "0x6000637")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x250E330", Offset = "0x250D730", Length = "0xB2")]
	[Token(Token = "0x6000641")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x250E3F0", Offset = "0x250D7F0", Length = "0x132")]
	[Token(Token = "0x6000638")]
	public virtual void WriteWhitespace(string ws) { }

}

