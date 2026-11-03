namespace System.Data;

[Token(Token = "0x200009B")]
internal sealed class XmlToDatasetMap
{
	[Token(Token = "0x200009E")]
	private sealed class TableSchemaInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400031B")]
		public DataTable TableSchema; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400031C")]
		public XmlNodeIdHashtable ColumnsSchemaMap; //Field offset: 0x18

		[Address(RVA = "0x23766E0", Offset = "0x2375AE0", Length = "0x12C")]
		[Token(Token = "0x6000804")]
		public TableSchemaInfo(DataTable tableSchema) { }

	}

	[Token(Token = "0x200009C")]
	private sealed class XmlNodeIdentety
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000318")]
		public string LocalName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000319")]
		public string NamespaceURI; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60007FC")]
		public XmlNodeIdentety(string localName, string namespaceURI) { }

		[Address(RVA = "0x236D670", Offset = "0x236CA70", Length = "0xA8")]
		[Token(Token = "0x60007FE")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
		[Token(Token = "0x60007FD")]
		public virtual int GetHashCode() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x200009D")]
	public sealed class XmlNodeIdHashtable : Hashtable
	{
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400031A")]
		private XmlNodeIdentety _id; //Field offset: 0x50

		[Token(Token = "0x1700012A")]
		public object Item
		{
			[Address(RVA = "0x2379B60", Offset = "0x2378F60", Length = "0xAB")]
			[Token(Token = "0x6000800")]
			 get { } //Length: 171
		}

		[Token(Token = "0x1700012B")]
		public object Item
		{
			[Address(RVA = "0x2379C10", Offset = "0x2379010", Length = "0xAB")]
			[Token(Token = "0x6000801")]
			 get { } //Length: 171
		}

		[Token(Token = "0x1700012C")]
		public object Item
		{
			[Address(RVA = "0x2379AD0", Offset = "0x2378ED0", Length = "0x8F")]
			[Token(Token = "0x6000802")]
			 get { } //Length: 143
		}

		[Token(Token = "0x1700012D")]
		public object Item
		{
			[Address(RVA = "0x2379A60", Offset = "0x2378E60", Length = "0x6B")]
			[Token(Token = "0x6000803")]
			 get { } //Length: 107
		}

		[Address(RVA = "0x23799B0", Offset = "0x2378DB0", Length = "0xA5")]
		[Token(Token = "0x60007FF")]
		public XmlNodeIdHashtable(int capacity) { }

		[Address(RVA = "0x2379B60", Offset = "0x2378F60", Length = "0xAB")]
		[Token(Token = "0x6000800")]
		public object get_Item(XmlNode node) { }

		[Address(RVA = "0x2379C10", Offset = "0x2379010", Length = "0xAB")]
		[Token(Token = "0x6000801")]
		public object get_Item(XmlReader dataReader) { }

		[Address(RVA = "0x2379AD0", Offset = "0x2378ED0", Length = "0x8F")]
		[Token(Token = "0x6000802")]
		public object get_Item(DataTable table) { }

		[Address(RVA = "0x2379A60", Offset = "0x2378E60", Length = "0x6B")]
		[Token(Token = "0x6000803")]
		public object get_Item(string name) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000316")]
	private XmlNodeIdHashtable _tableSchemaMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000317")]
	private TableSchemaInfo _lastTableSchemaInfo; //Field offset: 0x18

	[Address(RVA = "0x236FD50", Offset = "0x236F150", Length = "0x3F")]
	[Token(Token = "0x60007E9")]
	public XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable) { }

	[Address(RVA = "0x236FCD0", Offset = "0x236F0D0", Length = "0x3F")]
	[Token(Token = "0x60007EA")]
	public XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet) { }

	[Address(RVA = "0x236FD90", Offset = "0x236F190", Length = "0x7A")]
	[Token(Token = "0x60007EB")]
	public XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable) { }

	[Address(RVA = "0x236FD10", Offset = "0x236F110", Length = "0x3F")]
	[Token(Token = "0x60007EC")]
	public XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable) { }

	[Address(RVA = "0x236D720", Offset = "0x236CB20", Length = "0x179")]
	[Token(Token = "0x60007F0")]
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	[Address(RVA = "0x236D8A0", Offset = "0x236CCA0", Length = "0x219")]
	[Token(Token = "0x60007F1")]
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	[Address(RVA = "0x236DAC0", Offset = "0x236CEC0", Length = "0x154")]
	[Token(Token = "0x60007EE")]
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	[Address(RVA = "0x236DC20", Offset = "0x236D020", Length = "0x1D1")]
	[Token(Token = "0x60007EF")]
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	[Address(RVA = "0x236EBA0", Offset = "0x236DFA0", Length = "0x6EC")]
	[Token(Token = "0x60007F5")]
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	[Address(RVA = "0x236E1B0", Offset = "0x236D5B0", Length = "0x2BA")]
	[Token(Token = "0x60007F4")]
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	[Address(RVA = "0x236DE00", Offset = "0x236D200", Length = "0x3AE")]
	[Token(Token = "0x60007F2")]
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	[Address(RVA = "0x236E470", Offset = "0x236D870", Length = "0x72E")]
	[Token(Token = "0x60007F3")]
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	[Address(RVA = "0x236F290", Offset = "0x236E690", Length = "0x204")]
	[Token(Token = "0x60007F7")]
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	[Address(RVA = "0x236F4A0", Offset = "0x236E8A0", Length = "0x17D")]
	[Token(Token = "0x60007F8")]
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	[Address(RVA = "0x236F620", Offset = "0x236EA20", Length = "0xFA")]
	[Token(Token = "0x60007F9")]
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	[Address(RVA = "0x236F720", Offset = "0x236EB20", Length = "0x2E3")]
	[Token(Token = "0x60007F6")]
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	[Address(RVA = "0x236FA10", Offset = "0x236EE10", Length = "0xE8")]
	[Token(Token = "0x60007FA")]
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	[Address(RVA = "0x236FB00", Offset = "0x236EF00", Length = "0x19B")]
	[Token(Token = "0x60007FB")]
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	[Address(RVA = "0x236FCA0", Offset = "0x236F0A0", Length = "0x2C")]
	[Token(Token = "0x60007ED")]
	internal static bool IsMappedColumn(DataColumn c) { }

}

