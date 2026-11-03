namespace System.Data;

[DefaultProperty("DataSetName")]
[Token(Token = "0x2000018")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlRoot("DataSet")]
[XmlSchemaProvider("GetDataSetSchema")]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable
{
	[Token(Token = "0x4000047")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[Token(Token = "0x4000049")]
	private static XmlSchemaComplexType s_schemaTypeForWSDL; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000033")]
	private DataViewManager _defaultViewManager; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000034")]
	private readonly DataTableCollection _tableCollection; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000035")]
	private readonly DataRelationCollection _relationCollection; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000036")]
	internal PropertyCollection _extendedProperties; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000037")]
	private string _dataSetName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000038")]
	private string _datasetPrefix; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000039")]
	internal string _namespaceURI; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400003A")]
	private bool _enforceConstraints; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x400003B")]
	private bool _caseSensitive; //Field offset: 0x59
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400003C")]
	private CultureInfo _culture; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400003D")]
	private bool _cultureUserSet; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400003E")]
	internal bool _fInReadXml; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x400003F")]
	internal bool _fInLoadDiffgram; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x4000040")]
	internal bool _fTopLevelTable; //Field offset: 0x6B
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000041")]
	internal bool _fInitInProgress; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x4000042")]
	internal bool _fEnableCascading; //Field offset: 0x6D
	[FieldOffset(Offset = "0x6E")]
	[Token(Token = "0x4000043")]
	internal bool _fIsSchemaLoading; //Field offset: 0x6E
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000044")]
	internal string _mainTableName; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000045")]
	private SerializationFormat _remotingFormat; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000046")]
	private object _defaultViewManagerLock; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000048")]
	private readonly int _objectID; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400004A")]
	internal bool _useDataSetSchemaOnly; //Field offset: 0x8C
	[FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x400004B")]
	internal bool _udtIsWrapped; //Field offset: 0x8D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400004C")]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400004D")]
	private MergeFailedEventHandler MergeFailed; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400004E")]
	private DataRowCreatedEventHandler DataRowCreated; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400004F")]
	private DataSetClearEventhandler ClearFunctionCalled; //Field offset: 0xA8

	[DefaultValue(False)]
	[Token(Token = "0x1700003A")]
	public bool CaseSensitive
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 5
		[Address(RVA = "0x22FF400", Offset = "0x22FE800", Length = "0x26F")]
		[Token(Token = "0x60001D4")]
		 set { } //Length: 623
	}

	[DefaultValue(null)]
	[Token(Token = "0x1700003C")]
	public string DataSetName
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60001D9")]
		 get { } //Length: 5
		[Address(RVA = "0x22FF670", Offset = "0x22FEA70", Length = "0x165")]
		[Token(Token = "0x60001DA")]
		 set { } //Length: 357
	}

	[DefaultValue(True)]
	[Token(Token = "0x1700003B")]
	public bool EnforceConstraints
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60001D5")]
		 get { } //Length: 5
		[Address(RVA = "0x22FF7E0", Offset = "0x22FEBE0", Length = "0x13F")]
		[Token(Token = "0x60001D6")]
		 set { } //Length: 319
	}

	[Browsable(False)]
	[Token(Token = "0x1700003F")]
	public PropertyCollection ExtendedProperties
	{
		[Address(RVA = "0x22FF390", Offset = "0x22FE790", Length = "0x6A")]
		[Token(Token = "0x60001DF")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000040")]
	public CultureInfo Locale
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60001E0")]
		 get { } //Length: 5
		[Address(RVA = "0x22FF920", Offset = "0x22FED20", Length = "0x165")]
		[Token(Token = "0x60001E1")]
		 set { } //Length: 357
	}

	[Token(Token = "0x17000044")]
	internal string MainTableName
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000213")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6000214")]
		internal set { } //Length: 13
	}

	[DefaultValue(null)]
	[Token(Token = "0x1700003D")]
	public string Namespace
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60001DB")]
		 get { } //Length: 5
		[Address(RVA = "0x22FFA90", Offset = "0x22FEE90", Length = "0x3B0")]
		[Token(Token = "0x60001DC")]
		 set { } //Length: 944
	}

	[Token(Token = "0x17000045")]
	internal int ObjectID
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x6000215")]
		internal get { } //Length: 7
	}

	[DefaultValue(null)]
	[Token(Token = "0x1700003E")]
	public string Prefix
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 5
		[Address(RVA = "0x22FFE50", Offset = "0x22FF250", Length = "0x114")]
		[Token(Token = "0x60001DE")]
		 set { } //Length: 276
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Token(Token = "0x17000042")]
	public DataRelationCollection Relations
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60001E5")]
		 get { } //Length: 5
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	[Token(Token = "0x17000038")]
	public SerializationFormat RemotingFormat
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x60001C3")]
		 get { } //Length: 4
		[Address(RVA = "0x22FFF70", Offset = "0x22FF370", Length = "0xBB")]
		[Token(Token = "0x60001C4")]
		 set { } //Length: 187
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000039")]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 6
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000041")]
	public virtual ISite Site
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001E4")]
		 get { } //Length: 5
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Token(Token = "0x17000043")]
	public DataTableCollection Tables
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22FEE90", Offset = "0x22FE290", Length = "0x28B")]
	[Token(Token = "0x60001C1")]
	public DataSet() { }

	[Address(RVA = "0x22FF360", Offset = "0x22FE760", Length = "0x2F")]
	[Token(Token = "0x60001C2")]
	public DataSet(string dataSetName) { }

	[Address(RVA = "0x22FF120", Offset = "0x22FE520", Length = "0x205")]
	[Token(Token = "0x60001C7")]
	protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	[Address(RVA = "0x22FF330", Offset = "0x22FE730", Length = "0x28")]
	[Token(Token = "0x60001C6")]
	protected DataSet(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22F44B0", Offset = "0x22F38B0", Length = "0x1DA")]
	[Token(Token = "0x60001E7")]
	public void Clear() { }

	[Address(RVA = "0x22F4690", Offset = "0x22F3A90", Length = "0xFBD")]
	[Token(Token = "0x60001E8")]
	public override DataSet Clone() { }

	[Address(RVA = "0x22F5F80", Offset = "0x22F5380", Length = "0x7D")]
	[Token(Token = "0x60001CB")]
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	[Address(RVA = "0x22F5650", Offset = "0x22F4A50", Length = "0x1AB")]
	[Token(Token = "0x60001CD")]
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	[Address(RVA = "0x22F5800", Offset = "0x22F4C00", Length = "0x29D")]
	[Token(Token = "0x60001CF")]
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22F5AA0", Offset = "0x22F4EA0", Length = "0x4D1")]
	[Token(Token = "0x60001CC")]
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	[Address(RVA = "0x22F6000", Offset = "0x22F5400", Length = "0x6DD")]
	[Token(Token = "0x60001D1")]
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22F66E0", Offset = "0x22F5AE0", Length = "0x5A2")]
	[Token(Token = "0x60001D8")]
	internal void EnableConstraints() { }

	[Address(RVA = "0x22F6C90", Offset = "0x22F6090", Length = "0x159")]
	[Token(Token = "0x60001E9")]
	internal int EstimatedXmlStringSize() { }

	[Address(RVA = "0x22F6DF0", Offset = "0x22F61F0", Length = "0x31")]
	[Token(Token = "0x60001D2")]
	internal void FailedEnableConstraints() { }

	[Address(RVA = "0x22F6E30", Offset = "0x22F6230", Length = "0x171")]
	[Token(Token = "0x600020D")]
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x60001D3")]
	public bool get_CaseSensitive() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60001D9")]
	public string get_DataSetName() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x60001D5")]
	public bool get_EnforceConstraints() { }

	[Address(RVA = "0x22FF390", Offset = "0x22FE790", Length = "0x6A")]
	[Token(Token = "0x60001DF")]
	public PropertyCollection get_ExtendedProperties() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60001E0")]
	public CultureInfo get_Locale() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000213")]
	internal string get_MainTableName() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60001DB")]
	public string get_Namespace() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x6000215")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60001DD")]
	public string get_Prefix() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60001E5")]
	public DataRelationCollection get_Relations() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x60001C3")]
	public SerializationFormat get_RemotingFormat() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60001C5")]
	public override SchemaSerializationMode get_SchemaSerializationMode() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60001E4")]
	public virtual ISite get_Site() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60001E6")]
	public DataTableCollection get_Tables() { }

	[Address(RVA = "0x22F6FB0", Offset = "0x22F63B0", Length = "0x2C6")]
	[Token(Token = "0x600020F")]
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x22F7280", Offset = "0x22F6680", Length = "0x29")]
	[Token(Token = "0x60001C8")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22F72B0", Offset = "0x22F66B0", Length = "0x130")]
	[Token(Token = "0x60001EA")]
	internal string GetRemotingDiffGram(DataTable table) { }

	[Address(RVA = "0x22F73F0", Offset = "0x22F67F0", Length = "0x1A3")]
	[Token(Token = "0x60001EB")]
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	[Address(RVA = "0x22F75A0", Offset = "0x22F69A0", Length = "0x30C")]
	[Token(Token = "0x60001F6")]
	internal void InferSchema(XmlDocument xdoc, String[] excludedNamespaces, XmlReadMode mode) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C9")]
	protected override void InitializeDerivedDataSet() { }

	[Address(RVA = "0x22F78B0", Offset = "0x22F6CB0", Length = "0x1C5")]
	[Token(Token = "0x60001F7")]
	private bool IsEmpty() { }

	[Address(RVA = "0x22F7A80", Offset = "0x22F6E80", Length = "0x151")]
	[Token(Token = "0x60001FC")]
	public void Merge(DataSet dataSet) { }

	[Address(RVA = "0x22F7BE0", Offset = "0x22F6FE0", Length = "0x239")]
	[Token(Token = "0x60001FD")]
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[Address(RVA = "0x22F7E20", Offset = "0x22F7220", Length = "0x83")]
	[Token(Token = "0x60001EF")]
	private static void MoveToElement(XmlReader reader) { }

	[Address(RVA = "0x22DFD30", Offset = "0x22DF130", Length = "0xD1")]
	[Token(Token = "0x60001EE")]
	internal bool MoveToElement(XmlReader reader, int depth) { }

	[Address(RVA = "0x22F7EB0", Offset = "0x22F72B0", Length = "0x22")]
	[Token(Token = "0x6000202")]
	internal void OnClearFunctionCalled(DataTable table) { }

	[Address(RVA = "0x22F7EE0", Offset = "0x22F72E0", Length = "0x22")]
	[Token(Token = "0x6000201")]
	internal void OnDataRowCreated(DataRow row) { }

	[Address(RVA = "0x22F7F10", Offset = "0x22F7310", Length = "0x75")]
	[Token(Token = "0x60001FF")]
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	[Address(RVA = "0x22F7F90", Offset = "0x22F7390", Length = "0x22")]
	[Token(Token = "0x60001FE")]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[Address(RVA = "0x22F7FE0", Offset = "0x22F73E0", Length = "0x2C")]
	[Token(Token = "0x6000204")]
	internal void OnRemovedTable(DataTable table) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000205")]
	protected override void OnRemoveRelation(DataRelation relation) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x6000206")]
	internal void OnRemoveRelationHack(DataRelation relation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000203")]
	protected private override void OnRemoveTable(DataTable table) { }

	[Address(RVA = "0x22F8010", Offset = "0x22F7410", Length = "0x105")]
	[Token(Token = "0x6000200")]
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	[Address(RVA = "0x22F8120", Offset = "0x22F7520", Length = "0x77")]
	[Token(Token = "0x6000207")]
	protected private void RaisePropertyChanging(string name) { }

	[Address(RVA = "0x22E17B0", Offset = "0x22E0BB0", Length = "0xB1")]
	[Token(Token = "0x60001F0")]
	internal void ReadEndElement(XmlReader reader) { }

	[Address(RVA = "0x22F81A0", Offset = "0x22F75A0", Length = "0x162")]
	[Token(Token = "0x60001F2")]
	internal void ReadXDRSchema(XmlReader reader) { }

	[Address(RVA = "0x22FA470", Offset = "0x22F9870", Length = "0xE45")]
	[Token(Token = "0x60001FA")]
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	[Address(RVA = "0x22FA450", Offset = "0x22F9850", Length = "0x1A")]
	[Token(Token = "0x60001F9")]
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	[Address(RVA = "0x22FB2C0", Offset = "0x22FA6C0", Length = "0x1276")]
	[Token(Token = "0x60001F5")]
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	[Address(RVA = "0x22FC540", Offset = "0x22FB940", Length = "0xB")]
	[Token(Token = "0x60001F4")]
	public XmlReadMode ReadXml(XmlReader reader) { }

	[Address(RVA = "0x22F85D0", Offset = "0x22F79D0", Length = "0x1157")]
	[Token(Token = "0x60001F8")]
	private void ReadXmlDiffgram(XmlReader reader) { }

	[Address(RVA = "0x22F9740", Offset = "0x22F8B40", Length = "0x9B5")]
	[Token(Token = "0x60001ED")]
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	[Address(RVA = "0x22F9730", Offset = "0x22F8B30", Length = "0xB")]
	[Token(Token = "0x60001EC")]
	public void ReadXmlSchema(XmlReader reader) { }

	[Address(RVA = "0x22FA100", Offset = "0x22F9500", Length = "0x342")]
	[Token(Token = "0x600020E")]
	protected override void ReadXmlSerializable(XmlReader reader) { }

	[Address(RVA = "0x22F8310", Offset = "0x22F7710", Length = "0x2BF")]
	[Token(Token = "0x60001F1")]
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	[Address(RVA = "0x22FC550", Offset = "0x22FB950", Length = "0x27F")]
	[Token(Token = "0x600020A")]
	public override void Reset() { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[Token(Token = "0x60001D7")]
	internal void RestoreEnforceConstraints(bool value) { }

	[Address(RVA = "0x22FC970", Offset = "0x22FBD70", Length = "0x670")]
	[Token(Token = "0x60001CA")]
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	[Address(RVA = "0x22FC7D0", Offset = "0x22FBBD0", Length = "0x19E")]
	[Token(Token = "0x60001CE")]
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22FCFF0", Offset = "0x22FC3F0", Length = "0x537")]
	[Token(Token = "0x60001D0")]
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22FF400", Offset = "0x22FE800", Length = "0x26F")]
	[Token(Token = "0x60001D4")]
	public void set_CaseSensitive(bool value) { }

	[Address(RVA = "0x22FF670", Offset = "0x22FEA70", Length = "0x165")]
	[Token(Token = "0x60001DA")]
	public void set_DataSetName(string value) { }

	[Address(RVA = "0x22FF7E0", Offset = "0x22FEBE0", Length = "0x13F")]
	[Token(Token = "0x60001D6")]
	public void set_EnforceConstraints(bool value) { }

	[Address(RVA = "0x22FF920", Offset = "0x22FED20", Length = "0x165")]
	[Token(Token = "0x60001E1")]
	public void set_Locale(CultureInfo value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6000214")]
	internal void set_MainTableName(string value) { }

	[Address(RVA = "0x22FFA90", Offset = "0x22FEE90", Length = "0x3B0")]
	[Token(Token = "0x60001DC")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x22FFE50", Offset = "0x22FF250", Length = "0x114")]
	[Token(Token = "0x60001DE")]
	public void set_Prefix(string value) { }

	[Address(RVA = "0x22FFF70", Offset = "0x22FF370", Length = "0xBB")]
	[Token(Token = "0x60001C4")]
	public void set_RemotingFormat(SerializationFormat value) { }

	[Address(RVA = "0x22FD530", Offset = "0x22FC930", Length = "0x6C3")]
	[Token(Token = "0x60001E2")]
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x60001E3")]
	internal bool ShouldSerializeLocale() { }

	[Address(RVA = "0x22FDC00", Offset = "0x22FD000", Length = "0x1B6")]
	[Token(Token = "0x6000210")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x22FDDC0", Offset = "0x22FD1C0", Length = "0x145")]
	[Token(Token = "0x6000211")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x22FDF10", Offset = "0x22FD310", Length = "0x45")]
	[Token(Token = "0x6000212")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x22FDF60", Offset = "0x22FD360", Length = "0xA")]
	[Token(Token = "0x6000208")]
	internal DataTable[] TopLevelTables() { }

	[Address(RVA = "0x22FDF70", Offset = "0x22FD370", Length = "0x22F")]
	[Token(Token = "0x6000209")]
	internal DataTable[] TopLevelTables(bool forSchema) { }

	[Address(RVA = "0x22FE1A0", Offset = "0x22FD5A0", Length = "0x405")]
	[Token(Token = "0x600020B")]
	internal bool ValidateCaseConstraint() { }

	[Address(RVA = "0x22FE5B0", Offset = "0x22FD9B0", Length = "0x49B")]
	[Token(Token = "0x600020C")]
	internal bool ValidateLocaleConstraint() { }

	[Address(RVA = "0x22FEC60", Offset = "0x22FE060", Length = "0x226")]
	[Token(Token = "0x60001FB")]
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	[Address(RVA = "0x22FEA50", Offset = "0x22FDE50", Length = "0x20F")]
	[Token(Token = "0x60001F3")]
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, String> multipleTargetConverter) { }

}

