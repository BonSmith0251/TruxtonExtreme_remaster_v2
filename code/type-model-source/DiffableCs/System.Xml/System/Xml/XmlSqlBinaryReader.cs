namespace System.Xml;

[Token(Token = "0x2000011")]
internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
{
	[Token(Token = "0x2000015")]
	private struct AttrInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B8")]
		public QName name; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B9")]
		public string val; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000BA")]
		public int contentPos; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000BB")]
		public int hashCode; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000BC")]
		public int prevHash; //Field offset: 0x28

		[Address(RVA = "0x23EDA60", Offset = "0x23ECE60", Length = "0xA")]
		[Token(Token = "0x60000D4")]
		public void AdjustPosition(int adj) { }

		[Address(RVA = "0x23EDAF0", Offset = "0x23ECEF0", Length = "0x3B")]
		[Token(Token = "0x60000D0")]
		public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

		[Address(RVA = "0x23EDA70", Offset = "0x23ECE70", Length = "0x75")]
		[Token(Token = "0x60000D1")]
		public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

		[Address(RVA = "0x23EDB30", Offset = "0x23ECF30", Length = "0x51")]
		[Token(Token = "0x60000D3")]
		public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

		[Address(RVA = "0x23EDB90", Offset = "0x23ECF90", Length = "0x4A")]
		[Token(Token = "0x60000D2")]
		public bool MatchNS(string localname, string namespaceUri) { }

		[Address(RVA = "0x23EDC30", Offset = "0x23ED030", Length = "0x4B")]
		[Token(Token = "0x60000CE")]
		public void Set(QName n, string v) { }

		[Address(RVA = "0x23EDBE0", Offset = "0x23ECFE0", Length = "0x50")]
		[Token(Token = "0x60000CF")]
		public void Set(QName n, int pos) { }

	}

	[Token(Token = "0x2000014")]
	private struct ElemInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B3")]
		public QName name; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B4")]
		public string xmlLang; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B5")]
		public XmlSpace xmlSpace; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000B6")]
		public bool xmlspacePreserve; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B7")]
		public NamespaceDecl nsdecls; //Field offset: 0x28

		[Address(RVA = "0x23F3A20", Offset = "0x23F2E20", Length = "0x26")]
		[Token(Token = "0x60000CD")]
		public NamespaceDecl Clear() { }

		[Address(RVA = "0x23F3A50", Offset = "0x23F2E50", Length = "0x51")]
		[Token(Token = "0x60000CC")]
		public void Set(QName name, bool xmlspacePreserve) { }

	}

	[Token(Token = "0x2000016")]
	private class NamespaceDecl
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BD")]
		public string prefix; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BE")]
		public string uri; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000BF")]
		public NamespaceDecl scopeLink; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000C0")]
		public NamespaceDecl prevLink; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000C1")]
		public int scope; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40000C2")]
		public bool implied; //Field offset: 0x34

		[Address(RVA = "0x23F7090", Offset = "0x23F6490", Length = "0x8D")]
		[Token(Token = "0x60000D5")]
		public NamespaceDecl(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied) { }

	}

	[Token(Token = "0x2000018")]
	private class NestedBinXml
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C7")]
		public SymbolTables symbolTables; //Field offset: 0x10
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000C8")]
		public int docState; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C9")]
		public NestedBinXml next; //Field offset: 0x38

		[Address(RVA = "0x23F7120", Offset = "0x23F6520", Length = "0x68")]
		[Token(Token = "0x60000D7")]
		public NestedBinXml(SymbolTables symbolTables, int docState, NestedBinXml next) { }

	}

	[Token(Token = "0x2000013")]
	public struct QName
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B0")]
		public string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B1")]
		public string localname; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B2")]
		public string namespaceUri; //Field offset: 0x10

		[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
		[Token(Token = "0x60000C1")]
		public QName(string prefix, string lname, string nsUri) { }

		[Address(RVA = "0x23F7190", Offset = "0x23F6590", Length = "0x104")]
		[Token(Token = "0x60000C6")]
		public void CheckPrefixNS(string prefix, string namespaceUri) { }

		[Address(RVA = "0x23F72A0", Offset = "0x23F66A0", Length = "0x56")]
		[Token(Token = "0x60000C3")]
		public void Clear() { }

		[Address(RVA = "0x23F7300", Offset = "0x23F6700", Length = "0x106")]
		[Token(Token = "0x60000C9")]
		public virtual bool Equals(object other) { }

		[Address(RVA = "0x23F7410", Offset = "0x23F6810", Length = "0x59")]
		[Token(Token = "0x60000C7")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x23F7470", Offset = "0x23F6870", Length = "0x51")]
		[Token(Token = "0x60000C8")]
		public int GetNSHashCode(SecureStringHasher hasher) { }

		[Address(RVA = "0x23EDB90", Offset = "0x23ECF90", Length = "0x4A")]
		[Token(Token = "0x60000C4")]
		public bool MatchNs(string lname, string nsUri) { }

		[Address(RVA = "0x23F74D0", Offset = "0x23F68D0", Length = "0x49")]
		[Token(Token = "0x60000C5")]
		public bool MatchPrefix(string prefix, string lname) { }

		[Address(RVA = "0x23F7580", Offset = "0x23F6980", Length = "0x8B")]
		[Token(Token = "0x60000CB")]
		public static bool op_Equality(QName a, QName b) { }

		[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
		[Token(Token = "0x60000C2")]
		public void Set(string prefix, string lname, string nsUri) { }

		[Address(RVA = "0x23F7520", Offset = "0x23F6920", Length = "0x5D")]
		[Token(Token = "0x60000CA")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000012")]
	private enum ScanState : int
	{
		Doc = 0,
		XmlText = 1,
		Attr = 2,
		AttrVal = 3,
		AttrValPseudoValue = 4,
		Init = 5,
		Error = 6,
		EOF = 7,
		Closed = 8,
	}

	[Token(Token = "0x2000017")]
	private struct SymbolTables
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C3")]
		public String[] symtable; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000C4")]
		public int symCount; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C5")]
		public QName[] qnametable; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000C6")]
		public int qnameCount; //Field offset: 0x18

		[Address(RVA = "0x23F7680", Offset = "0x23F6A80", Length = "0xBF")]
		[Token(Token = "0x60000D6")]
		public void Init() { }

	}

	[Token(Token = "0x4000070")]
	internal static readonly Type TypeOfObject; //Field offset: 0x0
	[Token(Token = "0x4000071")]
	internal static readonly Type TypeOfString; //Field offset: 0x8
	[Token(Token = "0x4000072")]
	private static Type[] TokenTypeMap; //Field offset: 0x10
	[Token(Token = "0x4000073")]
	private static Byte[] XsdKatmaiTimeScaleToValueLengthMap; //Field offset: 0x18
	[Token(Token = "0x4000074")]
	private static ReadState[] ScanState2ReadState; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000075")]
	private Stream inStrm; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000076")]
	private Byte[] data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000077")]
	private int pos; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000078")]
	private int mark; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000079")]
	private int end; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007A")]
	private long offset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007B")]
	private bool eof; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400007C")]
	private bool sniffed; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x400007D")]
	private bool isEmpty; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400007E")]
	private int docState; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007F")]
	private SymbolTables symbolTables; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000080")]
	private XmlNameTable xnt; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000081")]
	private bool xntFromSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000082")]
	private string xml; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000083")]
	private string xmlns; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000084")]
	private string nsxmlns; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000085")]
	private string baseUri; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000086")]
	private ScanState state; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000087")]
	private XmlNodeType nodetype; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000088")]
	private BinXmlToken token; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000089")]
	private int attrIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400008A")]
	private QName qnameOther; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400008B")]
	private QName qnameElement; //Field offset: 0xB8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400008C")]
	private XmlNodeType parentNodeType; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400008D")]
	private ElemInfo[] elementStack; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400008E")]
	private int elemDepth; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400008F")]
	private AttrInfo[] attributes; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000090")]
	private Int32[] attrHashTbl; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000091")]
	private int attrCount; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000092")]
	private int posAfterAttrs; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000093")]
	private bool xmlspacePreserve; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000094")]
	private int tokLen; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000095")]
	private int tokDataPos; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000096")]
	private bool hasTypedValue; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000097")]
	private Type valueType; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000098")]
	private string stringValue; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000099")]
	private Dictionary<String, NamespaceDecl> namespaces; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400009A")]
	private NestedBinXml prevNameInfo; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400009B")]
	private XmlReader textXmlReader; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400009C")]
	private bool closeInput; //Field offset: 0x138
	[FieldOffset(Offset = "0x139")]
	[Token(Token = "0x400009D")]
	private bool checkCharacters; //Field offset: 0x139
	[FieldOffset(Offset = "0x13A")]
	[Token(Token = "0x400009E")]
	private bool ignoreWhitespace; //Field offset: 0x13A
	[FieldOffset(Offset = "0x13B")]
	[Token(Token = "0x400009F")]
	private bool ignorePIs; //Field offset: 0x13B
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x40000A0")]
	private bool ignoreComments; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000A1")]
	private DtdProcessing dtdProcessing; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000A2")]
	private SecureStringHasher hasher; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40000A3")]
	private XmlCharType xmlCharType; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40000A4")]
	private Encoding unicode; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40000A5")]
	private byte version; //Field offset: 0x160

	[Token(Token = "0x1700000F")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x2403580", Offset = "0x2402980", Length = "0x5D")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700000A")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6000050")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000009")]
	public virtual int Depth
	{
		[Address(RVA = "0x24035E0", Offset = "0x24029E0", Length = "0xCE")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 206
	}

	[Token(Token = "0x17000010")]
	public virtual bool EOF
	{
		[Address(RVA = "0x24036B0", Offset = "0x2402AB0", Length = "0xB")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700000B")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x24036C0", Offset = "0x2402AC0", Length = "0x11")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000005")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000006")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x600004C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000012")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x24036E0", Offset = "0x2402AE0", Length = "0x75")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000003")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2403760", Offset = "0x2402B60", Length = "0x110")]
		[Token(Token = "0x6000049")]
		 get { } //Length: 272
	}

	[Token(Token = "0x17000008")]
	public virtual string Value
	{
		[Address(RVA = "0x2403880", Offset = "0x2402C80", Length = "0x390")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 912
	}

	[Token(Token = "0x1700000E")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x6000054")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x2403C50", Offset = "0x2403050", Length = "0x9F")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700000C")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x2403CF0", Offset = "0x24030F0", Length = "0x8F")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 143
	}

	[Address(RVA = "0x2402DB0", Offset = "0x24021B0", Length = "0x1BB")]
	[Token(Token = "0x60000C0")]
	private static XmlSqlBinaryReader() { }

	[Address(RVA = "0x2402F70", Offset = "0x2402370", Length = "0x609")]
	[Token(Token = "0x6000048")]
	public XmlSqlBinaryReader(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	[Address(RVA = "0x23F77F0", Offset = "0x23F6BF0", Length = "0x135")]
	[Token(Token = "0x6000069")]
	private void AddInitNamespace(string prefix, string uri) { }

	[Address(RVA = "0x23F7930", Offset = "0x23F6D30", Length = "0x14F")]
	[Token(Token = "0x600006A")]
	private void AddName() { }

	[Address(RVA = "0x23F7A80", Offset = "0x23F6E80", Length = "0x2DF")]
	[Token(Token = "0x600006B")]
	private void AddQName() { }

	[Address(RVA = "0x23F7D60", Offset = "0x23F7160", Length = "0x13B")]
	[Token(Token = "0x6000093")]
	private string CDATAValue() { }

	[Address(RVA = "0x23F7EA0", Offset = "0x23F72A0", Length = "0x5B")]
	[Token(Token = "0x60000A3")]
	private void CheckAllowContent() { }

	[Address(RVA = "0x23F7FA0", Offset = "0x23F73A0", Length = "0x246")]
	[Token(Token = "0x60000A9")]
	private XmlNodeType CheckText(bool attr) { }

	[Address(RVA = "0x23F7F00", Offset = "0x23F7300", Length = "0x90")]
	[Token(Token = "0x60000AA")]
	private XmlNodeType CheckTextIsWS() { }

	[Address(RVA = "0x23F81F0", Offset = "0x23F75F0", Length = "0x54")]
	[Token(Token = "0x60000AB")]
	private void CheckValueTokenBounds() { }

	[Address(RVA = "0x23F8250", Offset = "0x23F7650", Length = "0x14")]
	[Token(Token = "0x600008A")]
	private void ClearAttributes() { }

	[Address(RVA = "0x23F8270", Offset = "0x23F7670", Length = "0xB3")]
	[Token(Token = "0x6000060")]
	public virtual void Close() { }

	[Address(RVA = "0x23F8600", Offset = "0x23F7A00", Length = "0x81")]
	[Token(Token = "0x6000072")]
	private void Fill(int require) { }

	[Address(RVA = "0x23F8580", Offset = "0x23F7980", Length = "0x71")]
	[Token(Token = "0x6000071")]
	private void Fill_(int require) { }

	[Address(RVA = "0x23F8330", Offset = "0x23F7730", Length = "0x241")]
	[Token(Token = "0x6000070")]
	private bool FillAllowEOF() { }

	[Address(RVA = "0x23F8690", Offset = "0x23F7A90", Length = "0x9C")]
	[Token(Token = "0x6000094")]
	private void FinishCDATA() { }

	[Address(RVA = "0x23F8730", Offset = "0x23F7B30", Length = "0x11D")]
	[Token(Token = "0x6000095")]
	private void FinishEndElement() { }

	[Address(RVA = "0x23F8850", Offset = "0x23F7C50", Length = "0x243")]
	[Token(Token = "0x600008D")]
	private void GenerateImpliedXmlnsAttrs() { }

	[Address(RVA = "0x23F8AA0", Offset = "0x23F7EA0", Length = "0xF6D")]
	[Token(Token = "0x60000A4")]
	private void GenerateTokenTypeMap() { }

	[Address(RVA = "0x2403580", Offset = "0x2402980", Length = "0x5D")]
	[Token(Token = "0x6000055")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000050")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x24035E0", Offset = "0x24029E0", Length = "0xCE")]
	[Token(Token = "0x600004F")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x24036B0", Offset = "0x2402AB0", Length = "0xB")]
	[Token(Token = "0x600005E")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x24036C0", Offset = "0x2402AC0", Length = "0x11")]
	[Token(Token = "0x6000051")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x600004B")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x600004C")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000061")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x600004A")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x600004D")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x24036E0", Offset = "0x2402AE0", Length = "0x75")]
	[Token(Token = "0x6000064")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x2403760", Offset = "0x2402B60", Length = "0x110")]
	[Token(Token = "0x6000049")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x2403880", Offset = "0x2402C80", Length = "0x390")]
	[Token(Token = "0x600004E")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x6000054")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x2403C50", Offset = "0x2403050", Length = "0x9F")]
	[Token(Token = "0x6000053")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x2403CF0", Offset = "0x24030F0", Length = "0x8F")]
	[Token(Token = "0x6000052")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x23F9B90", Offset = "0x23F8F90", Length = "0xA1")]
	[Token(Token = "0x6000058")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x23F9C40", Offset = "0x23F9040", Length = "0x161")]
	[Token(Token = "0x6000056")]
	public virtual string GetAttribute(string name, string ns) { }

	[Address(RVA = "0x23F9DB0", Offset = "0x23F91B0", Length = "0x6F")]
	[Token(Token = "0x6000057")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x23F9A10", Offset = "0x23F8E10", Length = "0x17F")]
	[Token(Token = "0x6000084")]
	private string GetAttributeText(int i) { }

	[Address(RVA = "0x23F9E20", Offset = "0x23F9220", Length = "0x152")]
	[Token(Token = "0x60000BB")]
	private double GetDouble(int offset) { }

	[Address(RVA = "0x23F9F80", Offset = "0x23F9380", Length = "0x45")]
	[Token(Token = "0x60000B4")]
	private short GetInt16(int pos) { }

	[Address(RVA = "0x23F9FD0", Offset = "0x23F93D0", Length = "0x75")]
	[Token(Token = "0x60000B6")]
	private int GetInt32(int pos) { }

	[Address(RVA = "0x23FA050", Offset = "0x23F9450", Length = "0x119")]
	[Token(Token = "0x60000B8")]
	private long GetInt64(int pos) { }

	[Address(RVA = "0x23FA170", Offset = "0x23F9570", Length = "0x7A")]
	[Token(Token = "0x60000BA")]
	private float GetSingle(int offset) { }

	[Address(RVA = "0x23FA230", Offset = "0x23F9630", Length = "0x1C1")]
	[Token(Token = "0x6000082")]
	private string GetString(int pos, int cch) { }

	[Address(RVA = "0x23FA1F0", Offset = "0x23F95F0", Length = "0x3B")]
	[Token(Token = "0x6000083")]
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	[Address(RVA = "0x23F9F80", Offset = "0x23F9380", Length = "0x45")]
	[Token(Token = "0x60000B5")]
	private ushort GetUInt16(int pos) { }

	[Address(RVA = "0x23F9FD0", Offset = "0x23F93D0", Length = "0x75")]
	[Token(Token = "0x60000B7")]
	private uint GetUInt32(int pos) { }

	[Address(RVA = "0x23FA050", Offset = "0x23F9450", Length = "0x119")]
	[Token(Token = "0x60000B9")]
	private ulong GetUInt64(int pos) { }

	[Address(RVA = "0x23FA400", Offset = "0x23F9800", Length = "0xDB")]
	[Token(Token = "0x60000A5")]
	private Type GetValueType(BinXmlToken token) { }

	[Address(RVA = "0x23FA4E0", Offset = "0x23F98E0", Length = "0x144")]
	[Token(Token = "0x60000AC")]
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	[Address(RVA = "0x23FA640", Offset = "0x23F9A40", Length = "0x96")]
	[Token(Token = "0x6000089")]
	private void GrowAttributes() { }

	[Address(RVA = "0x23FA6E0", Offset = "0x23F9AE0", Length = "0x9F")]
	[Token(Token = "0x6000088")]
	private void GrowElements() { }

	[Address(RVA = "0x23FA780", Offset = "0x23F9B80", Length = "0x32B")]
	[Token(Token = "0x6000091")]
	private void HashCheckForDuplicateAttributes() { }

	[Address(RVA = "0x23FAAB0", Offset = "0x23F9EB0", Length = "0x80")]
	[Token(Token = "0x600009D")]
	private void ImplReadCDATA() { }

	[Address(RVA = "0x23FAB40", Offset = "0x23F9F40", Length = "0x34")]
	[Token(Token = "0x600009C")]
	private void ImplReadComment() { }

	[Address(RVA = "0x23FAB80", Offset = "0x23F9F80", Length = "0x180")]
	[Token(Token = "0x6000097")]
	private void ImplReadData(BinXmlToken tokenType) { }

	[Address(RVA = "0x23FAD30", Offset = "0x23FA130", Length = "0x3FF")]
	[Token(Token = "0x600009A")]
	private void ImplReadDoctype() { }

	[Address(RVA = "0x23FB130", Offset = "0x23FA530", Length = "0x3CB")]
	[Token(Token = "0x6000098")]
	private void ImplReadElement() { }

	[Address(RVA = "0x23FB500", Offset = "0x23FA900", Length = "0xF4")]
	[Token(Token = "0x6000099")]
	private void ImplReadEndElement() { }

	[Address(RVA = "0x23FB600", Offset = "0x23FAA00", Length = "0x60")]
	[Token(Token = "0x600009F")]
	private void ImplReadEndNest() { }

	[Address(RVA = "0x23FB670", Offset = "0x23FAA70", Length = "0x12E")]
	[Token(Token = "0x600009E")]
	private void ImplReadNest() { }

	[Address(RVA = "0x23FB7A0", Offset = "0x23FABA0", Length = "0x7A")]
	[Token(Token = "0x600009B")]
	private void ImplReadPI() { }

	[Address(RVA = "0x23FB820", Offset = "0x23FAC20", Length = "0x409")]
	[Token(Token = "0x60000A0")]
	private void ImplReadXmlText() { }

	[Address(RVA = "0x23FBC30", Offset = "0x23FB030", Length = "0xA7")]
	[Token(Token = "0x6000085")]
	private int LocateAttribute(string name, string ns) { }

	[Address(RVA = "0x23FBCE0", Offset = "0x23FB0E0", Length = "0xEB")]
	[Token(Token = "0x6000086")]
	private int LocateAttribute(string name) { }

	[Address(RVA = "0x23FBDD0", Offset = "0x23FB1D0", Length = "0xBF")]
	[Token(Token = "0x6000062")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x23FBF40", Offset = "0x23FB340", Length = "0x8F")]
	[Token(Token = "0x6000059")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x23FBE90", Offset = "0x23FB290", Length = "0xAA")]
	[Token(Token = "0x600005A")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x23FBFD0", Offset = "0x23FB3D0", Length = "0x123")]
	[Token(Token = "0x600005D")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x23FC100", Offset = "0x23FB500", Length = "0x81")]
	[Token(Token = "0x600005B")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x23FC190", Offset = "0x23FB590", Length = "0xA4")]
	[Token(Token = "0x600005C")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x23FC240", Offset = "0x23FB640", Length = "0x5D")]
	[Token(Token = "0x600006C")]
	private void NameFlush() { }

	[Address(RVA = "0x23FC660", Offset = "0x23FBA60", Length = "0x99")]
	[Token(Token = "0x600007D")]
	private BinXmlToken NextToken() { }

	[Address(RVA = "0x23FC2A0", Offset = "0x23FB6A0", Length = "0x67")]
	[Token(Token = "0x600007C")]
	private BinXmlToken NextToken1() { }

	[Address(RVA = "0x23FC310", Offset = "0x23FB710", Length = "0x341")]
	[Token(Token = "0x600007B")]
	private BinXmlToken NextToken2(BinXmlToken token) { }

	[Address(RVA = "0x23FC8C0", Offset = "0x23FBCC0", Length = "0x111")]
	[Token(Token = "0x6000077")]
	private int ParseMB32(int pos) { }

	[Address(RVA = "0x23FC860", Offset = "0x23FBC60", Length = "0x5B")]
	[Token(Token = "0x6000075")]
	private int ParseMB32() { }

	[Address(RVA = "0x23FC700", Offset = "0x23FBB00", Length = "0x157")]
	[Token(Token = "0x6000076")]
	private int ParseMB32_(byte b) { }

	[Address(RVA = "0x23FC860", Offset = "0x23FBC60", Length = "0x5B")]
	[Token(Token = "0x6000078")]
	private int ParseMB64() { }

	[Address(RVA = "0x23FC9E0", Offset = "0x23FBDE0", Length = "0xB7")]
	[Token(Token = "0x6000080")]
	private string ParseText() { }

	[Address(RVA = "0x23FCAA0", Offset = "0x23FBEA0", Length = "0x1E")]
	[Token(Token = "0x600007E")]
	private BinXmlToken PeekNextToken() { }

	[Address(RVA = "0x23FCAC0", Offset = "0x23FBEC0", Length = "0x276")]
	[Token(Token = "0x6000079")]
	private BinXmlToken PeekToken() { }

	[Address(RVA = "0x23FCD40", Offset = "0x23FC140", Length = "0xD1")]
	[Token(Token = "0x600008C")]
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	[Address(RVA = "0x23FCE20", Offset = "0x23FC220", Length = "0x11B")]
	[Token(Token = "0x6000087")]
	private void PositionOnAttribute(int i) { }

	[Address(RVA = "0x23FCF40", Offset = "0x23FC340", Length = "0x2A4")]
	[Token(Token = "0x600008B")]
	private void PushNamespace(string prefix, string ns, bool implied) { }

	[Address(RVA = "0x23FE910", Offset = "0x23FDD10", Length = "0x164")]
	[Token(Token = "0x6000065")]
	public virtual bool Read() { }

	[Address(RVA = "0x23FD210", Offset = "0x23FC610", Length = "0x1DC")]
	[Token(Token = "0x600005F")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x23FD3F0", Offset = "0x23FC7F0", Length = "0x41")]
	[Token(Token = "0x6000073")]
	private byte ReadByte() { }

	[Address(RVA = "0x23FD440", Offset = "0x23FC840", Length = "0x8E4")]
	[Token(Token = "0x6000096")]
	private bool ReadDoc() { }

	[Address(RVA = "0x23FDDB0", Offset = "0x23FD1B0", Length = "0x6D5")]
	[Token(Token = "0x600008E")]
	private bool ReadInit(bool skipXmlDecl) { }

	[Address(RVA = "0x23FE490", Offset = "0x23FD890", Length = "0xC6")]
	[Token(Token = "0x600006F")]
	private int ReadNameRef() { }

	[Address(RVA = "0x23FE560", Offset = "0x23FD960", Length = "0xC6")]
	[Token(Token = "0x600006E")]
	private int ReadQNameRef() { }

	[Address(RVA = "0x23FE630", Offset = "0x23FDA30", Length = "0x27C")]
	[Token(Token = "0x600007A")]
	private BinXmlToken ReadToken() { }

	[Address(RVA = "0x23FE8B0", Offset = "0x23FDCB0", Length = "0x5D")]
	[Token(Token = "0x6000074")]
	private ushort ReadUShort() { }

	[Address(RVA = "0x23FEA90", Offset = "0x23FDE90", Length = "0x2A3")]
	[Token(Token = "0x600007F")]
	private BinXmlToken RescanNextToken() { }

	[Address(RVA = "0x23FD1F0", Offset = "0x23FC5F0", Length = "0x1D")]
	[Token(Token = "0x60000A6")]
	private void ReScanOverValue(BinXmlToken token) { }

	[Address(RVA = "0x23FED40", Offset = "0x23FE140", Length = "0x3E")]
	[Token(Token = "0x6000063")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x23FED80", Offset = "0x23FE180", Length = "0x76B")]
	[Token(Token = "0x600008F")]
	private void ScanAttributes() { }

	[Address(RVA = "0x23FF4F0", Offset = "0x23FE8F0", Length = "0x1AC")]
	[Token(Token = "0x60000A8")]
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	[Address(RVA = "0x23FFB70", Offset = "0x23FEF70", Length = "0x21C")]
	[Token(Token = "0x60000A7")]
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	[Address(RVA = "0x23FFD90", Offset = "0x23FF190", Length = "0x157")]
	[Token(Token = "0x6000081")]
	private int ScanText(out int start) { }

	[Address(RVA = "0x23FFEF0", Offset = "0x23FF2F0", Length = "0x168")]
	[Token(Token = "0x6000090")]
	private void SimpleCheckForDuplicateAttributes() { }

	[Address(RVA = "0x2400060", Offset = "0x23FF460", Length = "0x124")]
	[Token(Token = "0x600006D")]
	private void SkipExtn() { }

	[Address(RVA = "0x2400190", Offset = "0x23FF590", Length = "0x38D")]
	[Token(Token = "0x6000066")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2400520", Offset = "0x23FF920", Length = "0x1F9")]
	[Token(Token = "0x6000067")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x2400720", Offset = "0x23FFB20", Length = "0x6E")]
	[Token(Token = "0x60000BF")]
	private Exception ThrowNotSupported(string res) { }

	[Address(RVA = "0x2400790", Offset = "0x23FFB90", Length = "0x84")]
	[Token(Token = "0x60000BC")]
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	[Address(RVA = "0x2400900", Offset = "0x23FFD00", Length = "0x64")]
	[Token(Token = "0x60000BD")]
	private Exception ThrowXmlException(string res) { }

	[Address(RVA = "0x2400820", Offset = "0x23FFC20", Length = "0xDA")]
	[Token(Token = "0x60000BE")]
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	[Address(RVA = "0x2400A90", Offset = "0x23FFE90", Length = "0x1D")]
	[Token(Token = "0x60000A2")]
	private bool UpdateFromTextReader(bool needUpdate) { }

	[Address(RVA = "0x2400970", Offset = "0x23FFD70", Length = "0x11C")]
	[Token(Token = "0x60000A1")]
	private void UpdateFromTextReader() { }

	[Address(RVA = "0x2400AB0", Offset = "0x23FFEB0", Length = "0xC2C")]
	[Token(Token = "0x60000B2")]
	private string ValueAsDateTimeString() { }

	[Address(RVA = "0x2401710", Offset = "0x2400B10", Length = "0x2CC")]
	[Token(Token = "0x60000B0")]
	private decimal ValueAsDecimal() { }

	[Address(RVA = "0x2401A30", Offset = "0x2400E30", Length = "0x1AC")]
	[Token(Token = "0x60000B1")]
	private double ValueAsDouble() { }

	[Address(RVA = "0x2401C30", Offset = "0x2401030", Length = "0x4A0")]
	[Token(Token = "0x60000AE")]
	private long ValueAsLong() { }

	[Address(RVA = "0x2402170", Offset = "0x2401570", Length = "0xF4")]
	[Token(Token = "0x60000B3")]
	private string ValueAsString(BinXmlToken token) { }

	[Address(RVA = "0x2402A90", Offset = "0x2401E90", Length = "0x96")]
	[Token(Token = "0x60000AF")]
	private ulong ValueAsULong() { }

	[Address(RVA = "0x2402B30", Offset = "0x2401F30", Length = "0x46")]
	[Token(Token = "0x6000068")]
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	[Address(RVA = "0x2402B80", Offset = "0x2401F80", Length = "0x15A")]
	[Token(Token = "0x6000092")]
	private string XmlDeclValue() { }

	[Address(RVA = "0x2402CE0", Offset = "0x24020E0", Length = "0xC0")]
	[Token(Token = "0x60000AD")]
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

}

