namespace System.Data;

[Token(Token = "0x2000099")]
internal sealed class XmlDataLoader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F5")]
	private DataSet _dataSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F6")]
	private XmlToDatasetMap _nodeToSchemaMap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F7")]
	private Hashtable _nodeToRowMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F8")]
	private Stack _childRowsStack; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F9")]
	private Hashtable _htableExcludedNS; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002FA")]
	private bool _fIsXdr; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40002FB")]
	internal bool _isDiffgram; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002FC")]
	private XmlElement _topMostNode; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002FD")]
	private bool _ignoreSchema; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002FE")]
	private DataTable _dataTable; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002FF")]
	private bool _isTableLevel; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000300")]
	private bool _fromInference; //Field offset: 0x59
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000301")]
	private XmlReader _dataReader; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000302")]
	private object _XSD_XMLNS_NS; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000303")]
	private object _XDR_SCHEMA; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000304")]
	private object _XDRNS; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000305")]
	private object _SQL_SYNC; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000306")]
	private object _UPDGNS; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000307")]
	private object _XSD_SCHEMA; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000308")]
	private object _XSDNS; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000309")]
	private object _DFFNS; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400030A")]
	private object _MSDNS; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400030B")]
	private object _DIFFID; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400030C")]
	private object _HASCHANGES; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400030D")]
	private object _ROWORDER; //Field offset: 0xC0

	[Token(Token = "0x17000129")]
	internal bool FromInference
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x60007D1")]
		internal get { } //Length: 5
		[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
		[Token(Token = "0x60007D2")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x236D040", Offset = "0x236C440", Length = "0x9E")]
	[Token(Token = "0x60007CD")]
	internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	[Address(RVA = "0x236D2B0", Offset = "0x236C6B0", Length = "0xEC")]
	[Token(Token = "0x60007CE")]
	internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	[Address(RVA = "0x236D0E0", Offset = "0x236C4E0", Length = "0xB5")]
	[Token(Token = "0x60007CF")]
	internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	[Address(RVA = "0x236D1A0", Offset = "0x236C5A0", Length = "0x103")]
	[Token(Token = "0x60007D0")]
	internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	[Address(RVA = "0x2368070", Offset = "0x2367470", Length = "0x18D")]
	[Token(Token = "0x60007D3")]
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	[Address(RVA = "0x2368200", Offset = "0x2367600", Length = "0x19F")]
	[Token(Token = "0x60007D4")]
	private int CountNonNSAttributes(XmlNode node) { }

	[Address(RVA = "0x23683A0", Offset = "0x23677A0", Length = "0x115")]
	[Token(Token = "0x60007D9")]
	internal bool FColumnElement(XmlElement e) { }

	[Address(RVA = "0x23684C0", Offset = "0x23678C0", Length = "0x92")]
	[Token(Token = "0x60007DA")]
	private bool FExcludedNamespace(string ns) { }

	[Address(RVA = "0x23685F0", Offset = "0x23679F0", Length = "0x110")]
	[Token(Token = "0x60007DB")]
	private bool FIgnoreNamespace(XmlNode node) { }

	[Address(RVA = "0x2368560", Offset = "0x2367960", Length = "0x8C")]
	[Token(Token = "0x60007DC")]
	private bool FIgnoreNamespace(XmlReader node) { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x60007D1")]
	internal bool get_FromInference() { }

	[Address(RVA = "0x2368710", Offset = "0x2367B10", Length = "0x2F1")]
	[Token(Token = "0x60007D6")]
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	[Address(RVA = "0x2368A10", Offset = "0x2367E10", Length = "0x9A")]
	[Token(Token = "0x60007D8")]
	internal DataRow GetRowFromElement(XmlElement e) { }

	[Address(RVA = "0x2368AB0", Offset = "0x2367EB0", Length = "0xA9")]
	[Token(Token = "0x60007D7")]
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	[Address(RVA = "0x2368B60", Offset = "0x2367F60", Length = "0x2C0")]
	[Token(Token = "0x60007D5")]
	private string GetValueForTextOnlyColums(XmlNode n) { }

	[Address(RVA = "0x2368E30", Offset = "0x2368230", Length = "0x340")]
	[Token(Token = "0x60007E3")]
	private void InitNameTable() { }

	[Address(RVA = "0x2369180", Offset = "0x2368580", Length = "0x51")]
	[Token(Token = "0x60007DD")]
	internal bool IsTextLikeNode(XmlNodeType n) { }

	[Address(RVA = "0x23691E0", Offset = "0x23685E0", Length = "0x32")]
	[Token(Token = "0x60007DE")]
	internal bool IsTextOnly(DataColumn c) { }

	[Address(RVA = "0x2369220", Offset = "0x2368620", Length = "0xA98")]
	[Token(Token = "0x60007E7")]
	private void LoadColumn(DataColumn column, Object[] foundColumns) { }

	[Address(RVA = "0x2369CC0", Offset = "0x23690C0", Length = "0x2EE")]
	[Token(Token = "0x60007DF")]
	internal void LoadData(XmlDocument xdoc) { }

	[Address(RVA = "0x2369FB0", Offset = "0x23693B0", Length = "0x3E0")]
	[Token(Token = "0x60007E4")]
	internal void LoadData(XmlReader reader) { }

	[Address(RVA = "0x236A3A0", Offset = "0x23697A0", Length = "0xD9D")]
	[Token(Token = "0x60007E0")]
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	[Address(RVA = "0x236B140", Offset = "0x236A540", Length = "0x3B9")]
	[Token(Token = "0x60007E1")]
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	[Address(RVA = "0x236B500", Offset = "0x236A900", Length = "0xF20")]
	[Token(Token = "0x60007E6")]
	private void LoadTable(DataTable table, bool isNested) { }

	[Address(RVA = "0x236C430", Offset = "0x236B830", Length = "0x96B")]
	[Token(Token = "0x60007E5")]
	private void LoadTopMostTable(DataTable table) { }

	[Address(RVA = "0x236CDA0", Offset = "0x236C1A0", Length = "0x24D")]
	[Token(Token = "0x60007E8")]
	private bool ProcessXsdSchema() { }

	[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
	[Token(Token = "0x60007D2")]
	internal void set_FromInference(bool value) { }

	[Address(RVA = "0x236CFF0", Offset = "0x236C3F0", Length = "0x48")]
	[Token(Token = "0x60007E2")]
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

}

