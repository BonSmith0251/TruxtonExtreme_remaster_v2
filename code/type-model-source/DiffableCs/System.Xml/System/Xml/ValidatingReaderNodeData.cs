namespace System.Xml;

[Token(Token = "0x2000040")]
internal class ValidatingReaderNodeData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000138")]
	private string localName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000139")]
	private string namespaceUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400013A")]
	private string prefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400013B")]
	private string nameWPrefix; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400013C")]
	private string rawValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400013D")]
	private string originalStringValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400013E")]
	private int depth; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400013F")]
	private AttributePSVIInfo attributePSVIInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000140")]
	private XmlNodeType nodeType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000141")]
	private int lineNo; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000142")]
	private int linePos; //Field offset: 0x58

	[Token(Token = "0x17000050")]
	public AttributePSVIInfo AttInfo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60001E8")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60001E9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004C")]
	public int Depth
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60001E1")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[Token(Token = "0x60001E2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000051")]
	public int LineNumber
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60001EA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000052")]
	public int LinePosition
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60001EB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000049")]
	public string LocalName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001DA")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60001DB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004A")]
	public string Namespace
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60001DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004F")]
	public XmlNodeType NodeType
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x60001E7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004E")]
	public string OriginalStringValue
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60001E5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004B")]
	public string Prefix
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001DF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004D")]
	public string RawValue
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60001E3")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60001E4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x24ED740", Offset = "0x24ECB40", Length = "0x22")]
	[Token(Token = "0x60001D8")]
	public ValidatingReaderNodeData() { }

	[Address(RVA = "0x24ED710", Offset = "0x24ECB10", Length = "0x2D")]
	[Token(Token = "0x60001D9")]
	public ValidatingReaderNodeData(XmlNodeType nodeType) { }

	[Address(RVA = "0x24ED420", Offset = "0x24EC820", Length = "0xB7")]
	[Token(Token = "0x60001EC")]
	internal void Clear(XmlNodeType nodeType) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60001E8")]
	public AttributePSVIInfo get_AttInfo() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60001E1")]
	public int get_Depth() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60001EA")]
	public int get_LineNumber() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60001EB")]
	public int get_LinePosition() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60001DA")]
	public string get_LocalName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60001DC")]
	public string get_Namespace() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60001E6")]
	public XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60001E5")]
	public string get_OriginalStringValue() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001DE")]
	public string get_Prefix() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60001E3")]
	public string get_RawValue() { }

	[Address(RVA = "0x24ED4E0", Offset = "0x24EC8E0", Length = "0xA8")]
	[Token(Token = "0x60001E0")]
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60001E9")]
	public void set_AttInfo(AttributePSVIInfo value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x60001E2")]
	public void set_Depth(int value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60001DB")]
	public void set_LocalName(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60001DD")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x60001E7")]
	public void set_NodeType(XmlNodeType value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001DF")]
	public void set_Prefix(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60001E4")]
	public void set_RawValue(string value) { }

	[Address(RVA = "0x24ED590", Offset = "0x24EC990", Length = "0x79")]
	[Token(Token = "0x60001EF")]
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	[Address(RVA = "0x24ED650", Offset = "0x24ECA50", Length = "0x37")]
	[Token(Token = "0x60001F0")]
	internal void SetItemData(string value) { }

	[Address(RVA = "0x24ED610", Offset = "0x24ECA10", Length = "0x37")]
	[Token(Token = "0x60001F1")]
	internal void SetItemData(string value, string originalStringValue) { }

	[Address(RVA = "0x24ED700", Offset = "0x24ECB00", Length = "0x8")]
	[Token(Token = "0x60001ED")]
	internal void SetLineInfo(int lineNo, int linePos) { }

	[Address(RVA = "0x24ED690", Offset = "0x24ECA90", Length = "0x6A")]
	[Token(Token = "0x60001EE")]
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

}

