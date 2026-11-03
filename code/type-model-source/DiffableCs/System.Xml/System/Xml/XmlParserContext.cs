namespace System.Xml;

[Token(Token = "0x200004F")]
public class XmlParserContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A7")]
	private XmlNameTable _nt; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A8")]
	private XmlNamespaceManager _nsMgr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A9")]
	private string _docTypeName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AA")]
	private string _pubId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AB")]
	private string _sysId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001AC")]
	private string _internalSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001AD")]
	private string _xmlLang; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001AE")]
	private XmlSpace _xmlSpace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001AF")]
	private string _baseURI; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001B0")]
	private Encoding _encoding; //Field offset: 0x58

	[Token(Token = "0x17000084")]
	public string BaseURI
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000308")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000081")]
	public string DocTypeName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000305")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000088")]
	public Encoding Encoding
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600030C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000089")]
	internal bool HasDtdInfo
	{
		[Address(RVA = "0x24F7B50", Offset = "0x24F6F50", Length = "0x75")]
		[Token(Token = "0x600030D")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000085")]
	public string InternalSubset
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000309")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000080")]
	public XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007F")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000303")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000082")]
	public string PublicId
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000306")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000083")]
	public string SystemId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000307")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000086")]
	public string XmlLang
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600030A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000087")]
	public XmlSpace XmlSpace
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x600030B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x24F77D0", Offset = "0x24F6BD0", Length = "0x53")]
	[Token(Token = "0x6000300")]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	[Address(RVA = "0x24F7830", Offset = "0x24F6C30", Length = "0x62")]
	[Token(Token = "0x6000301")]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	[Address(RVA = "0x24F78A0", Offset = "0x24F6CA0", Length = "0x2AC")]
	[Token(Token = "0x6000302")]
	public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000308")]
	public string get_BaseURI() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000305")]
	public string get_DocTypeName() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600030C")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x24F7B50", Offset = "0x24F6F50", Length = "0x75")]
	[Token(Token = "0x600030D")]
	internal bool get_HasDtdInfo() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000309")]
	public string get_InternalSubset() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000304")]
	public XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000303")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000306")]
	public string get_PublicId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000307")]
	public string get_SystemId() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600030A")]
	public string get_XmlLang() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x600030B")]
	public XmlSpace get_XmlSpace() { }

}

