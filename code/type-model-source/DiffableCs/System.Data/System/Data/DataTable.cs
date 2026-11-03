namespace System.Data;

[DefaultEvent("RowChanging")]
[DefaultProperty("TableName")]
[DesignTimeVisible(False)]
[Token(Token = "0x2000019")]
[ToolboxItem(False)]
[XmlSchemaProvider("GetDataTableSchema")]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable
{
	[Token(Token = "0x200001B")]
	public struct DSRowDiffIdUsageSection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009A")]
		private DataSet _targetDS; //Field offset: 0x0

		[Address(RVA = "0x22ED8B0", Offset = "0x22ECCB0", Length = "0x9D")]
		[Token(Token = "0x60002E7")]
		internal void Prepare(DataSet ds) { }

	}

	[Token(Token = "0x200001A")]
	public struct RowDiffIdUsageSection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000099")]
		private DataTable _targetTable; //Field offset: 0x0

		[Address(RVA = "0x230F690", Offset = "0x230EA90", Length = "0x39")]
		[Token(Token = "0x60002E6")]
		internal void Prepare(DataTable table) { }

	}

	[Token(Token = "0x4000097")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000050")]
	private DataSet _dataSet; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000051")]
	private DataView _defaultView; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000052")]
	internal long _nextRowID; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000053")]
	internal readonly DataRowCollection _rowCollection; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000054")]
	internal readonly DataColumnCollection _columnCollection; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000055")]
	private readonly ConstraintCollection _constraintCollection; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000056")]
	private int _elementColumnCount; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000057")]
	internal DataRelationCollection _parentRelationsCollection; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000058")]
	internal DataRelationCollection _childRelationsCollection; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000059")]
	internal readonly RecordManager _recordManager; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400005A")]
	internal readonly List<Index> _indexes; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400005B")]
	private List<Index> _shadowIndexes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400005C")]
	private int _shadowCount; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400005D")]
	internal PropertyCollection _extendedProperties; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400005E")]
	private string _tableName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400005F")]
	internal string _tableNamespace; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000060")]
	private string _tablePrefix; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000061")]
	internal DataExpression _displayExpression; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000062")]
	internal bool _fNestedInDataset; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000063")]
	private CultureInfo _culture; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000064")]
	private bool _cultureUserSet; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000065")]
	private CompareInfo _compareInfo; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000066")]
	private CompareOptions _compareFlags; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000067")]
	private IFormatProvider _formatProvider; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000068")]
	private StringComparer _hashCodeProvider; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000069")]
	private bool _caseSensitive; //Field offset: 0xE8
	[FieldOffset(Offset = "0xE9")]
	[Token(Token = "0x400006A")]
	private bool _caseSensitiveUserSet; //Field offset: 0xE9
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400006B")]
	internal string _encodedTableName; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400006C")]
	internal DataColumn _xmlText; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400006D")]
	internal DataColumn _colUnique; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400006E")]
	internal decimal _minOccurs; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400006F")]
	internal decimal _maxOccurs; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000070")]
	internal bool _repeatableElement; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000071")]
	private object _typeName; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000072")]
	internal UniqueConstraint _primaryKey; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000073")]
	internal IndexField[] _primaryIndex; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000074")]
	private DataColumn[] _delayedSetPrimaryKey; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000075")]
	private Index _loadIndex; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000076")]
	private Index _loadIndexwithOriginalAdded; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000077")]
	private Index _loadIndexwithCurrentDeleted; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000078")]
	private int _suspendIndexEvents; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x4000079")]
	private bool _inDataLoad; //Field offset: 0x16C
	[FieldOffset(Offset = "0x16D")]
	[Token(Token = "0x400007A")]
	private bool _schemaLoading; //Field offset: 0x16D
	[FieldOffset(Offset = "0x16E")]
	[Token(Token = "0x400007B")]
	private bool _enforceConstraints; //Field offset: 0x16E
	[FieldOffset(Offset = "0x16F")]
	[Token(Token = "0x400007C")]
	internal bool _suspendEnforceConstraints; //Field offset: 0x16F
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400007D")]
	protected private bool fInitInProgress; //Field offset: 0x170
	[FieldOffset(Offset = "0x171")]
	[Token(Token = "0x400007E")]
	private bool _inLoad; //Field offset: 0x171
	[FieldOffset(Offset = "0x172")]
	[Token(Token = "0x400007F")]
	internal bool _fInLoadDiffgram; //Field offset: 0x172
	[FieldOffset(Offset = "0x173")]
	[Token(Token = "0x4000080")]
	private byte _isTypedDataTable; //Field offset: 0x173
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000081")]
	private DataRow[] _emptyDataRowArray; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000082")]
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000083")]
	private DataRelation[] _nestedParentRelations; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000084")]
	internal List<DataColumn> _dependentColumns; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000085")]
	private bool _mergingData; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000086")]
	private DataRowChangeEventHandler _onRowChangedDelegate; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000087")]
	private DataRowChangeEventHandler _onRowChangingDelegate; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000088")]
	private DataRowChangeEventHandler _onRowDeletingDelegate; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000089")]
	private DataRowChangeEventHandler _onRowDeletedDelegate; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400008A")]
	private DataColumnChangeEventHandler _onColumnChangedDelegate; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400008B")]
	private DataColumnChangeEventHandler _onColumnChangingDelegate; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400008C")]
	private DataTableClearEventHandler _onTableClearingDelegate; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400008D")]
	private DataTableClearEventHandler _onTableClearedDelegate; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400008E")]
	private DataTableNewRowEventHandler _onTableNewRowDelegate; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400008F")]
	private PropertyChangedEventHandler _onPropertyChangingDelegate; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000090")]
	private readonly DataRowBuilder _rowBuilder; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000091")]
	internal readonly List<DataView> _delayedViews; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000092")]
	private readonly List<DataViewListener> _dataViewListeners; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000093")]
	internal Hashtable _rowDiffId; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000094")]
	internal readonly ReaderWriterLockSlim _indexesLock; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000095")]
	internal int _ukColumnPositionForInference; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000096")]
	private SerializationFormat _remotingFormat; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000098")]
	private readonly int _objectID; //Field offset: 0x220

	[Token(Token = "0x17000047")]
	internal bool AreIndexEventsSuspended
	{
		[Address(RVA = "0x22EA510", Offset = "0x22E9910", Length = "0xB")]
		[Token(Token = "0x6000229")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000046")]
	public bool CaseSensitive
	{
		[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
		[Token(Token = "0x6000227")]
		 get { } //Length: 8
		[Address(RVA = "0x22EB160", Offset = "0x22EA560", Length = "0xBA")]
		[Token(Token = "0x6000228")]
		 set { } //Length: 186
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x1700004D")]
	public DataRelationCollection ChildRelations
	{
		[Address(RVA = "0x22EA520", Offset = "0x22E9920", Length = "0x71")]
		[Token(Token = "0x6000235")]
		 get { } //Length: 113
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Token(Token = "0x1700004E")]
	public DataColumnCollection Columns
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000236")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004F")]
	private CompareInfo CompareInfo
	{
		[Address(RVA = "0x22EA5A0", Offset = "0x22E99A0", Length = "0x64")]
		[Token(Token = "0x6000237")]
		private get { } //Length: 100
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[Token(Token = "0x17000050")]
	public ConstraintCollection Constraints
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000238")]
		 get { } //Length: 5
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000051")]
	public DataSet DataSet
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600023A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000052")]
	internal string DisplayExpressionInternal
	{
		[Address(RVA = "0x22EA610", Offset = "0x22E9A10", Length = "0x2A")]
		[Token(Token = "0x600023C")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700005A")]
	internal int ElementColumnCount
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600024B")]
		internal get { } //Length: 4
		[Address(RVA = "0x22EB220", Offset = "0x22EA620", Length = "0x45")]
		[Token(Token = "0x600024C")]
		internal set { } //Length: 69
	}

	[Token(Token = "0x17000063")]
	internal string EncodedTableName
	{
		[Address(RVA = "0x22EA640", Offset = "0x22E9A40", Length = "0x82")]
		[Token(Token = "0x600025A")]
		internal get { } //Length: 130
	}

	[Token(Token = "0x17000053")]
	internal bool EnforceConstraints
	{
		[Address(RVA = "0x22EA6D0", Offset = "0x22E9AD0", Length = "0x24")]
		[Token(Token = "0x600023D")]
		internal get { } //Length: 36
		[Address(RVA = "0x22EB270", Offset = "0x22EA670", Length = "0x3C")]
		[Token(Token = "0x600023E")]
		internal set { } //Length: 60
	}

	[Browsable(False)]
	[Token(Token = "0x17000055")]
	public PropertyCollection ExtendedProperties
	{
		[Address(RVA = "0x22EA700", Offset = "0x22E9B00", Length = "0x73")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000056")]
	internal IFormatProvider FormatProvider
	{
		[Address(RVA = "0x22EA780", Offset = "0x22E9B80", Length = "0xA6")]
		[Token(Token = "0x6000243")]
		internal get { } //Length: 166
	}

	[Token(Token = "0x17000048")]
	private bool IsTypedDataTable
	{
		[Address(RVA = "0x22EA830", Offset = "0x22E9C30", Length = "0x9A")]
		[Token(Token = "0x600022C")]
		private get { } //Length: 154
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x1700004A")]
	internal List<Index> LiveIndexes
	{
		[Address(RVA = "0x22EA8D0", Offset = "0x22E9CD0", Length = "0x95")]
		[Token(Token = "0x6000230")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x17000057")]
	public CultureInfo Locale
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000244")]
		 get { } //Length: 8
		[Address(RVA = "0x22EB2B0", Offset = "0x22EA6B0", Length = "0x3D4")]
		[Token(Token = "0x6000245")]
		 set { } //Length: 980
	}

	[Token(Token = "0x17000067")]
	internal decimal MaxOccurs
	{
		[Address(RVA = "0x22EA970", Offset = "0x22E9D70", Length = "0xE")]
		[Token(Token = "0x6000267")]
		internal get { } //Length: 14
		[Address(RVA = "0x22EB690", Offset = "0x22EAA90", Length = "0xB")]
		[Token(Token = "0x6000268")]
		internal set { } //Length: 11
	}

	[Token(Token = "0x1700005C")]
	internal bool MergingData
	{
		[Address(RVA = "0x22EA980", Offset = "0x22E9D80", Length = "0x8")]
		[Token(Token = "0x600024E")]
		internal get { } //Length: 8
		[Address(RVA = "0x22EB6A0", Offset = "0x22EAAA0", Length = "0x7")]
		[Token(Token = "0x600024F")]
		internal set { } //Length: 7
	}

	[DefaultValue(50)]
	[Token(Token = "0x17000058")]
	public int MinimumCapacity
	{
		[Address(RVA = "0x22EA9A0", Offset = "0x22E9DA0", Length = "0x1A")]
		[Token(Token = "0x6000248")]
		 get { } //Length: 26
		[Address(RVA = "0x22EB6C0", Offset = "0x22EAAC0", Length = "0x2B")]
		[Token(Token = "0x6000249")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000068")]
	internal decimal MinOccurs
	{
		[Address(RVA = "0x22EA990", Offset = "0x22E9D90", Length = "0xE")]
		[Token(Token = "0x6000269")]
		internal get { } //Length: 14
		[Address(RVA = "0x22EB6B0", Offset = "0x22EAAB0", Length = "0xB")]
		[Token(Token = "0x600026A")]
		internal set { } //Length: 11
	}

	[Token(Token = "0x17000064")]
	public string Namespace
	{
		[Address(RVA = "0x22EA9C0", Offset = "0x22E9DC0", Length = "0x79")]
		[Token(Token = "0x600025C")]
		 get { } //Length: 121
		[Address(RVA = "0x22EB6F0", Offset = "0x22EAAF0", Length = "0x27B")]
		[Token(Token = "0x600025D")]
		 set { } //Length: 635
	}

	[Token(Token = "0x1700006A")]
	internal bool NeedColumnChangeEvents
	{
		[Address(RVA = "0x22EAA40", Offset = "0x22E9E40", Length = "0x37")]
		[Token(Token = "0x6000297")]
		internal get { } //Length: 55
	}

	[Token(Token = "0x1700005D")]
	internal DataRelation[] NestedParentRelations
	{
		[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
		[Token(Token = "0x6000250")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700005F")]
	internal int NestedParentsCount
	{
		[Address(RVA = "0x22EAA90", Offset = "0x22E9E90", Length = "0x250")]
		[Token(Token = "0x6000254")]
		internal get { } //Length: 592
	}

	[Token(Token = "0x1700006D")]
	internal int ObjectID
	{
		[Address(RVA = "0x22EACF0", Offset = "0x22EA0F0", Length = "0x7")]
		[Token(Token = "0x60002DE")]
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x1700005B")]
	public DataRelationCollection ParentRelations
	{
		[Address(RVA = "0x22EAD00", Offset = "0x22EA100", Length = "0x71")]
		[Token(Token = "0x600024D")]
		 get { } //Length: 113
	}

	[DefaultValue(null)]
	[Token(Token = "0x17000065")]
	public string Prefix
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000263")]
		 get { } //Length: 8
		[Address(RVA = "0x22EB970", Offset = "0x22EAD70", Length = "0x166")]
		[Token(Token = "0x6000264")]
		 set { } //Length: 358
	}

	[Token(Token = "0x17000060")]
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey
	{
		[Address(RVA = "0x22EAD80", Offset = "0x22EA180", Length = "0x67")]
		[Token(Token = "0x6000255")]
		 get { } //Length: 103
		[Address(RVA = "0x22EBAE0", Offset = "0x22EAEE0", Length = "0x4C3")]
		[Token(Token = "0x6000256")]
		 set { } //Length: 1219
	}

	[Token(Token = "0x17000059")]
	internal int RecordCapacity
	{
		[Address(RVA = "0x22EADF0", Offset = "0x22EA1F0", Length = "0x1A")]
		[Token(Token = "0x600024A")]
		internal get { } //Length: 26
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	[Token(Token = "0x1700004B")]
	public SerializationFormat RemotingFormat
	{
		[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
		[Token(Token = "0x6000231")]
		 get { } //Length: 7
		[Address(RVA = "0x22EBFB0", Offset = "0x22EB3B0", Length = "0x71")]
		[Token(Token = "0x6000232")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700006C")]
	internal Hashtable RowDiffId
	{
		[Address(RVA = "0x22EAE10", Offset = "0x22EA210", Length = "0x75")]
		[Token(Token = "0x60002DD")]
		internal get { } //Length: 117
	}

	[Browsable(False)]
	[Token(Token = "0x17000061")]
	public DataRowCollection Rows
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	internal bool SchemaLoading
	{
		[Address(RVA = "0x22EAE90", Offset = "0x22EA290", Length = "0x8")]
		[Token(Token = "0x6000251")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000049")]
	internal bool SelfNested
	{
		[Address(RVA = "0x22EAEA0", Offset = "0x22EA2A0", Length = "0x1E8")]
		[Token(Token = "0x600022F")]
		internal get { } //Length: 488
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000069")]
	public virtual ISite Site
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000276")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000054")]
	internal bool SuspendEnforceConstraints
	{
		[Address(RVA = "0x22EB090", Offset = "0x22EA490", Length = "0x8")]
		[Token(Token = "0x600023F")]
		internal get { } //Length: 8
		[Address(RVA = "0x22EC030", Offset = "0x22EB430", Length = "0x7")]
		[Token(Token = "0x6000240")]
		internal set { } //Length: 7
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x17000062")]
	public string TableName
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000258")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC040", Offset = "0x22EB440", Length = "0x57B")]
		[Token(Token = "0x6000259")]
		 set { } //Length: 1403
	}

	[Token(Token = "0x1700006B")]
	internal XmlQualifiedName TypeName
	{
		[Address(RVA = "0x22EB0A0", Offset = "0x22EA4A0", Length = "0xA8")]
		[Token(Token = "0x60002C4")]
		internal get { } //Length: 168
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[Token(Token = "0x60002C5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700004C")]
	internal int UKColumnPositionForInference
	{
		[Address(RVA = "0x22EB150", Offset = "0x22EA550", Length = "0x7")]
		[Token(Token = "0x6000233")]
		internal get { } //Length: 7
		[Address(RVA = "0x22EC5E0", Offset = "0x22EB9E0", Length = "0x7")]
		[Token(Token = "0x6000234")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000066")]
	internal DataColumn XmlText
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x6000265")]
		internal get { } //Length: 8
		[Address(RVA = "0x22EC5F0", Offset = "0x22EB9F0", Length = "0x4D5")]
		[Token(Token = "0x6000266")]
		internal set { } //Length: 1237
	}

	[Address(RVA = "0x22E9E40", Offset = "0x22E9240", Length = "0x4C1")]
	[Token(Token = "0x6000216")]
	public DataTable() { }

	[Address(RVA = "0x22EA310", Offset = "0x22E9710", Length = "0x6B")]
	[Token(Token = "0x6000217")]
	public DataTable(string tableName) { }

	[Address(RVA = "0x22EA380", Offset = "0x22E9780", Length = "0x18C")]
	[Token(Token = "0x6000218")]
	protected DataTable(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22D4360", Offset = "0x22D3760", Length = "0x13C")]
	[Token(Token = "0x60002DF")]
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	[Address(RVA = "0x22D44A0", Offset = "0x22D38A0", Length = "0xB3")]
	[Token(Token = "0x60002C1")]
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	[Address(RVA = "0x22D4560", Offset = "0x22D3960", Length = "0x25")]
	[Token(Token = "0x6000277")]
	internal void AddRow(DataRow row, int proposedID) { }

	[Address(RVA = "0x22D4590", Offset = "0x22D3990", Length = "0xD")]
	[Token(Token = "0x60002C0")]
	internal DataColumn AddUniqueKey() { }

	[Address(RVA = "0x22D45A0", Offset = "0x22D39A0", Length = "0x30A")]
	[Token(Token = "0x60002BF")]
	internal DataColumn AddUniqueKey(int position) { }

	[Address(RVA = "0x22D48B0", Offset = "0x22D3CB0", Length = "0x2B")]
	[Token(Token = "0x6000252")]
	internal void CacheNestedParent() { }

	[Address(RVA = "0x22D48E0", Offset = "0x22D3CE0", Length = "0xCB")]
	[Token(Token = "0x600027D")]
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x22D49B0", Offset = "0x22D3DB0", Length = "0x2D3")]
	[Token(Token = "0x600025F")]
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	[Address(RVA = "0x22D4FF0", Offset = "0x22D43F0", Length = "0x114")]
	[Token(Token = "0x60002C9")]
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	[Address(RVA = "0x22D4C90", Offset = "0x22D4090", Length = "0x357")]
	[Token(Token = "0x60002CA")]
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	[Address(RVA = "0x22D5110", Offset = "0x22D4510", Length = "0x25F")]
	[Token(Token = "0x6000261")]
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	[Address(RVA = "0x22D5370", Offset = "0x22D4770", Length = "0x33D")]
	[Token(Token = "0x6000260")]
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	[Address(RVA = "0x22D56B0", Offset = "0x22D4AB0", Length = "0x2A")]
	[Token(Token = "0x600027A")]
	internal void CheckNotModifying(DataRow row) { }

	[Address(RVA = "0x22D56E0", Offset = "0x22D4AE0", Length = "0xA")]
	[Token(Token = "0x600027B")]
	public void Clear() { }

	[Address(RVA = "0x22D56F0", Offset = "0x22D4AF0", Length = "0x798")]
	[Token(Token = "0x600027C")]
	internal void Clear(bool clearAll) { }

	[Address(RVA = "0x22D7010", Offset = "0x22D6410", Length = "0x1CC")]
	[Token(Token = "0x6000272")]
	internal DataTable Clone(DataSet cloneDS) { }

	[Address(RVA = "0x22D71E0", Offset = "0x22D65E0", Length = "0xA")]
	[Token(Token = "0x6000271")]
	public override DataTable Clone() { }

	[Address(RVA = "0x22D5E90", Offset = "0x22D5290", Length = "0x416")]
	[Token(Token = "0x6000274")]
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	[Address(RVA = "0x22D62B0", Offset = "0x22D56B0", Length = "0xD5B")]
	[Token(Token = "0x6000275")]
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	[Address(RVA = "0x22D71F0", Offset = "0x22D65F0", Length = "0x148")]
	[Token(Token = "0x600027E")]
	internal void CommitRow(DataRow row) { }

	[Address(RVA = "0x22D7340", Offset = "0x22D6740", Length = "0x191")]
	[Token(Token = "0x6000280")]
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	[Address(RVA = "0x22D74E0", Offset = "0x22D68E0", Length = "0x156")]
	[Token(Token = "0x600027F")]
	internal int Compare(string s1, string s2) { }

	[Address(RVA = "0x22D7640", Offset = "0x22D6A40", Length = "0x2EC")]
	[Token(Token = "0x6000226")]
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	[Address(RVA = "0x22D7930", Offset = "0x22D6D30", Length = "0xD7")]
	[Token(Token = "0x6000224")]
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	[Address(RVA = "0x22D7A10", Offset = "0x22D6E10", Length = "0x307")]
	[Token(Token = "0x6000291")]
	internal DataRow CreateEmptyRow() { }

	[Address(RVA = "0x22D7D20", Offset = "0x22D7120", Length = "0x7E")]
	[Token(Token = "0x6000270")]
	protected override DataTable CreateInstance() { }

	[Address(RVA = "0x22D7DA0", Offset = "0x22D71A0", Length = "0x325")]
	[Token(Token = "0x60002D6")]
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	[Address(RVA = "0x22D80D0", Offset = "0x22D74D0", Length = "0x2D2")]
	[Token(Token = "0x60002D5")]
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	[Address(RVA = "0x22D83B0", Offset = "0x22D77B0", Length = "0xA9")]
	[Token(Token = "0x6000283")]
	internal void DeleteRow(DataRow row) { }

	[Address(RVA = "0x22D8460", Offset = "0x22D7860", Length = "0xB11")]
	[Token(Token = "0x600021F")]
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	[Address(RVA = "0x22D8F80", Offset = "0x22D8380", Length = "0x324")]
	[Token(Token = "0x600021B")]
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	[Address(RVA = "0x22D92B0", Offset = "0x22D86B0", Length = "0x17D")]
	[Token(Token = "0x6000221")]
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	[Address(RVA = "0x22D9430", Offset = "0x22D8830", Length = "0xA25")]
	[Token(Token = "0x6000223")]
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	[Address(RVA = "0x22D9E60", Offset = "0x22D9260", Length = "0xECB")]
	[Token(Token = "0x600021D")]
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	[Address(RVA = "0x22DAD30", Offset = "0x22DA130", Length = "0x53E")]
	[Token(Token = "0x6000262")]
	internal void DoRaiseNamespaceChange() { }

	[Address(RVA = "0x22DB270", Offset = "0x22DA670", Length = "0x52E")]
	[Token(Token = "0x6000241")]
	internal void EnableConstraints() { }

	[Address(RVA = "0x22DB7A0", Offset = "0x22DABA0", Length = "0x873")]
	[Token(Token = "0x60002E5")]
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

	[Address(RVA = "0x22DC020", Offset = "0x22DB420", Length = "0x145")]
	[Token(Token = "0x60002E4")]
	internal void EvaluateDependentExpressions(DataColumn column) { }

	[Address(RVA = "0x22DC170", Offset = "0x22DB570", Length = "0x263")]
	[Token(Token = "0x60002E3")]
	internal void EvaluateExpressions(DataColumn column) { }

	[Address(RVA = "0x22DC6A0", Offset = "0x22DBAA0", Length = "0x5AA")]
	[Token(Token = "0x60002E2")]
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	[Address(RVA = "0x22DC3E0", Offset = "0x22DB7E0", Length = "0x2BA")]
	[Token(Token = "0x60002E1")]
	internal void EvaluateExpressions() { }

	[Address(RVA = "0x22DCC50", Offset = "0x22DC050", Length = "0x9A")]
	[Token(Token = "0x600026C")]
	internal DataRow FindByIndex(Index ndx, Object[] key) { }

	[Address(RVA = "0x22DCCF0", Offset = "0x22DC0F0", Length = "0xFF")]
	[Token(Token = "0x600026D")]
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	[Address(RVA = "0x22DCDF0", Offset = "0x22DC1F0", Length = "0x306")]
	[Token(Token = "0x6000253")]
	private DataRelation[] FindNestedParentRelations() { }

	[Address(RVA = "0x22DD100", Offset = "0x22DC500", Length = "0x13D")]
	[Token(Token = "0x6000284")]
	internal string FormatSortString(IndexField[] indexDesc) { }

	[Address(RVA = "0x22DD240", Offset = "0x22DC640", Length = "0x1E")]
	[Token(Token = "0x6000285")]
	internal void FreeRecord(ref int record) { }

	[Address(RVA = "0x22EA510", Offset = "0x22E9910", Length = "0xB")]
	[Token(Token = "0x6000229")]
	internal bool get_AreIndexEventsSuspended() { }

	[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
	[Token(Token = "0x6000227")]
	public bool get_CaseSensitive() { }

	[Address(RVA = "0x22EA520", Offset = "0x22E9920", Length = "0x71")]
	[Token(Token = "0x6000235")]
	public DataRelationCollection get_ChildRelations() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000236")]
	public DataColumnCollection get_Columns() { }

	[Address(RVA = "0x22EA5A0", Offset = "0x22E99A0", Length = "0x64")]
	[Token(Token = "0x6000237")]
	private CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000238")]
	public ConstraintCollection get_Constraints() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600023A")]
	public DataSet get_DataSet() { }

	[Address(RVA = "0x22EA610", Offset = "0x22E9A10", Length = "0x2A")]
	[Token(Token = "0x600023C")]
	internal string get_DisplayExpressionInternal() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x600024B")]
	internal int get_ElementColumnCount() { }

	[Address(RVA = "0x22EA640", Offset = "0x22E9A40", Length = "0x82")]
	[Token(Token = "0x600025A")]
	internal string get_EncodedTableName() { }

	[Address(RVA = "0x22EA6D0", Offset = "0x22E9AD0", Length = "0x24")]
	[Token(Token = "0x600023D")]
	internal bool get_EnforceConstraints() { }

	[Address(RVA = "0x22EA700", Offset = "0x22E9B00", Length = "0x73")]
	[Token(Token = "0x6000242")]
	public PropertyCollection get_ExtendedProperties() { }

	[Address(RVA = "0x22EA780", Offset = "0x22E9B80", Length = "0xA6")]
	[Token(Token = "0x6000243")]
	internal IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x22EA830", Offset = "0x22E9C30", Length = "0x9A")]
	[Token(Token = "0x600022C")]
	private bool get_IsTypedDataTable() { }

	[Address(RVA = "0x22EA8D0", Offset = "0x22E9CD0", Length = "0x95")]
	[Token(Token = "0x6000230")]
	internal List<Index> get_LiveIndexes() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000244")]
	public CultureInfo get_Locale() { }

	[Address(RVA = "0x22EA970", Offset = "0x22E9D70", Length = "0xE")]
	[Token(Token = "0x6000267")]
	internal decimal get_MaxOccurs() { }

	[Address(RVA = "0x22EA980", Offset = "0x22E9D80", Length = "0x8")]
	[Token(Token = "0x600024E")]
	internal bool get_MergingData() { }

	[Address(RVA = "0x22EA9A0", Offset = "0x22E9DA0", Length = "0x1A")]
	[Token(Token = "0x6000248")]
	public int get_MinimumCapacity() { }

	[Address(RVA = "0x22EA990", Offset = "0x22E9D90", Length = "0xE")]
	[Token(Token = "0x6000269")]
	internal decimal get_MinOccurs() { }

	[Address(RVA = "0x22EA9C0", Offset = "0x22E9DC0", Length = "0x79")]
	[Token(Token = "0x600025C")]
	public string get_Namespace() { }

	[Address(RVA = "0x22EAA40", Offset = "0x22E9E40", Length = "0x37")]
	[Token(Token = "0x6000297")]
	internal bool get_NeedColumnChangeEvents() { }

	[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
	[Token(Token = "0x6000250")]
	internal DataRelation[] get_NestedParentRelations() { }

	[Address(RVA = "0x22EAA90", Offset = "0x22E9E90", Length = "0x250")]
	[Token(Token = "0x6000254")]
	internal int get_NestedParentsCount() { }

	[Address(RVA = "0x22EACF0", Offset = "0x22EA0F0", Length = "0x7")]
	[Token(Token = "0x60002DE")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x22EAD00", Offset = "0x22EA100", Length = "0x71")]
	[Token(Token = "0x600024D")]
	public DataRelationCollection get_ParentRelations() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000263")]
	public string get_Prefix() { }

	[Address(RVA = "0x22EAD80", Offset = "0x22EA180", Length = "0x67")]
	[Token(Token = "0x6000255")]
	public DataColumn[] get_PrimaryKey() { }

	[Address(RVA = "0x22EADF0", Offset = "0x22EA1F0", Length = "0x1A")]
	[Token(Token = "0x600024A")]
	internal int get_RecordCapacity() { }

	[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
	[Token(Token = "0x6000231")]
	public SerializationFormat get_RemotingFormat() { }

	[Address(RVA = "0x22EAE10", Offset = "0x22EA210", Length = "0x75")]
	[Token(Token = "0x60002DD")]
	internal Hashtable get_RowDiffId() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000257")]
	public DataRowCollection get_Rows() { }

	[Address(RVA = "0x22EAE90", Offset = "0x22EA290", Length = "0x8")]
	[Token(Token = "0x6000251")]
	internal bool get_SchemaLoading() { }

	[Address(RVA = "0x22EAEA0", Offset = "0x22EA2A0", Length = "0x1E8")]
	[Token(Token = "0x600022F")]
	internal bool get_SelfNested() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000276")]
	public virtual ISite get_Site() { }

	[Address(RVA = "0x22EB090", Offset = "0x22EA490", Length = "0x8")]
	[Token(Token = "0x600023F")]
	internal bool get_SuspendEnforceConstraints() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000258")]
	public string get_TableName() { }

	[Address(RVA = "0x22EB0A0", Offset = "0x22EA4A0", Length = "0xA8")]
	[Token(Token = "0x60002C4")]
	internal XmlQualifiedName get_TypeName() { }

	[Address(RVA = "0x22EB150", Offset = "0x22EA550", Length = "0x7")]
	[Token(Token = "0x6000233")]
	internal int get_UKColumnPositionForInference() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x6000265")]
	internal DataColumn get_XmlText() { }

	[Address(RVA = "0x22DD260", Offset = "0x22DC660", Length = "0x25B")]
	[Token(Token = "0x60002D7")]
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x22DD4C0", Offset = "0x22DC8C0", Length = "0x1EF")]
	[Token(Token = "0x6000287")]
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x22DD6B0", Offset = "0x22DCAB0", Length = "0x49")]
	[Token(Token = "0x6000286")]
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x22DD700", Offset = "0x22DCB00", Length = "0x292")]
	[Token(Token = "0x600025B")]
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[Token(Token = "0x6000288")]
	internal List<DataViewListener> GetListeners() { }

	[Address(RVA = "0x22DD9B0", Offset = "0x22DCDB0", Length = "0xE1")]
	[Token(Token = "0x6000219")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x22DDAA0", Offset = "0x22DCEA0", Length = "0x337")]
	[Token(Token = "0x60002C3")]
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	[Address(RVA = "0x22DDDE0", Offset = "0x22DD1E0", Length = "0x293")]
	[Token(Token = "0x6000225")]
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	[Address(RVA = "0x22DE080", Offset = "0x22DD480", Length = "0x4D")]
	[Token(Token = "0x6000295")]
	protected override Type GetRowType() { }

	[Address(RVA = "0x22DE0D0", Offset = "0x22DD4D0", Length = "0x1B6")]
	[Token(Token = "0x60002D9")]
	protected override XmlSchema GetSchema() { }

	[Address(RVA = "0x22DE290", Offset = "0x22DD690", Length = "0x101")]
	[Token(Token = "0x6000289")]
	internal int GetSpecialHashCode(string name) { }

	[Address(RVA = "0x22DE3A0", Offset = "0x22DD7A0", Length = "0x290")]
	[Token(Token = "0x6000273")]
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	[Address(RVA = "0x22DE640", Offset = "0x22DDA40", Length = "0xB2")]
	[Token(Token = "0x6000281")]
	internal int IndexOf(string s1, string s2) { }

	[Address(RVA = "0x22DE700", Offset = "0x22DDB00", Length = "0x212")]
	[Token(Token = "0x60002AD")]
	internal Int32[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x22DF110", Offset = "0x22DE510", Length = "0x1F")]
	[Token(Token = "0x6000278")]
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	[Address(RVA = "0x22DE920", Offset = "0x22DDD20", Length = "0x40A")]
	[Token(Token = "0x600028A")]
	internal void InsertRow(DataRow row, long proposedID) { }

	[Address(RVA = "0x22DED30", Offset = "0x22DE130", Length = "0x3D7")]
	[Token(Token = "0x6000279")]
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	[Address(RVA = "0x22DF130", Offset = "0x22DE530", Length = "0x217")]
	[Token(Token = "0x60002CD")]
	private bool IsEmptyXml(XmlReader reader) { }

	[Address(RVA = "0x22DF350", Offset = "0x22DE750", Length = "0xC")]
	[Token(Token = "0x600025E")]
	internal bool IsNamespaceInherited() { }

	[Address(RVA = "0x22DF360", Offset = "0x22DE760", Length = "0xB2")]
	[Token(Token = "0x6000282")]
	internal bool IsSuffix(string s1, string s2) { }

	[Address(RVA = "0x22DFAD0", Offset = "0x22DEED0", Length = "0x20")]
	[Token(Token = "0x60002C6")]
	public void Merge(DataTable table) { }

	[Address(RVA = "0x22DFAF0", Offset = "0x22DEEF0", Length = "0x239")]
	[Token(Token = "0x60002C7")]
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[Address(RVA = "0x22DF420", Offset = "0x22DE820", Length = "0x6A4")]
	[Token(Token = "0x600026F")]
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	[Address(RVA = "0x22DFD30", Offset = "0x22DF130", Length = "0xD1")]
	[Token(Token = "0x60002D1")]
	internal bool MoveToElement(XmlReader reader, int depth) { }

	[Address(RVA = "0x22DFE10", Offset = "0x22DF210", Length = "0x67")]
	[Token(Token = "0x600028E")]
	internal DataRow NewEmptyRow() { }

	[Address(RVA = "0x22DFE90", Offset = "0x22DF290", Length = "0xED")]
	[Token(Token = "0x600028D")]
	internal int NewRecord(int sourceRecord) { }

	[Address(RVA = "0x22DFE80", Offset = "0x22DF280", Length = "0xD")]
	[Token(Token = "0x600028B")]
	internal int NewRecord() { }

	[Address(RVA = "0x22E0200", Offset = "0x22DF600", Length = "0x9B")]
	[Token(Token = "0x6000293")]
	internal DataRow NewRow(int record) { }

	[Address(RVA = "0x22E02A0", Offset = "0x22DF6A0", Length = "0xFA")]
	[Token(Token = "0x6000290")]
	public DataRow NewRow() { }

	[Address(RVA = "0x22DFF80", Offset = "0x22DF380", Length = "0x18F")]
	[Token(Token = "0x6000296")]
	protected private DataRow[] NewRowArray(int size) { }

	[Address(RVA = "0x22E0110", Offset = "0x22DF510", Length = "0x82")]
	[Token(Token = "0x6000292")]
	private void NewRowCreated(DataRow row) { }

	[Address(RVA = "0x22E01A0", Offset = "0x22DF5A0", Length = "0x54")]
	[Token(Token = "0x6000294")]
	protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	[Address(RVA = "0x22E03A0", Offset = "0x22DF7A0", Length = "0x1D")]
	[Token(Token = "0x600028C")]
	internal int NewUninitializedRecord() { }

	[Address(RVA = "0x22E03C0", Offset = "0x22DF7C0", Length = "0x30")]
	[Token(Token = "0x600028F")]
	private DataRow NewUninitializedRow() { }

	[Address(RVA = "0x22E0400", Offset = "0x22DF800", Length = "0xC6")]
	[Token(Token = "0x6000299")]
	protected private override void OnColumnChanged(DataColumnChangeEventArgs e) { }

	[Address(RVA = "0x22E04D0", Offset = "0x22DF8D0", Length = "0xC6")]
	[Token(Token = "0x6000298")]
	protected private override void OnColumnChanging(DataColumnChangeEventArgs e) { }

	[Address(RVA = "0x22E05A0", Offset = "0x22DF9A0", Length = "0xC6")]
	[Token(Token = "0x600029A")]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600029C")]
	protected override void OnRemoveColumn(DataColumn column) { }

	[Address(RVA = "0x22E0670", Offset = "0x22DFA70", Length = "0x14")]
	[Token(Token = "0x600029B")]
	internal void OnRemoveColumnInternal(DataColumn column) { }

	[Address(RVA = "0x22E0690", Offset = "0x22DFA90", Length = "0xAA")]
	[Token(Token = "0x600029D")]
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[Address(RVA = "0x22E0740", Offset = "0x22DFB40", Length = "0xC6")]
	[Token(Token = "0x600029F")]
	protected override void OnRowChanged(DataRowChangeEventArgs e) { }

	[Address(RVA = "0x22E0810", Offset = "0x22DFC10", Length = "0xAA")]
	[Token(Token = "0x600029E")]
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[Address(RVA = "0x22E08C0", Offset = "0x22DFCC0", Length = "0xC6")]
	[Token(Token = "0x60002A0")]
	protected override void OnRowChanging(DataRowChangeEventArgs e) { }

	[Address(RVA = "0x22E0990", Offset = "0x22DFD90", Length = "0xC6")]
	[Token(Token = "0x60002A2")]
	protected override void OnRowDeleted(DataRowChangeEventArgs e) { }

	[Address(RVA = "0x22E0A60", Offset = "0x22DFE60", Length = "0xC6")]
	[Token(Token = "0x60002A1")]
	protected override void OnRowDeleting(DataRowChangeEventArgs e) { }

	[Address(RVA = "0x22E0B30", Offset = "0x22DFF30", Length = "0xC6")]
	[Token(Token = "0x60002A3")]
	protected override void OnTableCleared(DataTableClearEventArgs e) { }

	[Address(RVA = "0x22E0C00", Offset = "0x22E0000", Length = "0xC6")]
	[Token(Token = "0x60002A4")]
	protected override void OnTableClearing(DataTableClearEventArgs e) { }

	[Address(RVA = "0x22E0CD0", Offset = "0x22E00D0", Length = "0xC6")]
	[Token(Token = "0x60002A5")]
	protected override void OnTableNewRow(DataTableNewRowEventArgs e) { }

	[Address(RVA = "0x22E0DA0", Offset = "0x22E01A0", Length = "0x384")]
	[Token(Token = "0x60002A6")]
	internal IndexField[] ParseSortString(string sortString) { }

	[Address(RVA = "0x22E1130", Offset = "0x22E0530", Length = "0x77")]
	[Token(Token = "0x60002A7")]
	internal void RaisePropertyChanging(string name) { }

	[Address(RVA = "0x22E11B0", Offset = "0x22E05B0", Length = "0x191")]
	[Token(Token = "0x60002B4")]
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[Address(RVA = "0x22E1350", Offset = "0x22E0750", Length = "0x1C9")]
	[Token(Token = "0x60002B6")]
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	[Address(RVA = "0x22E1520", Offset = "0x22E0920", Length = "0x289")]
	[Token(Token = "0x60002B5")]
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	[Address(RVA = "0x22E17B0", Offset = "0x22E0BB0", Length = "0xB1")]
	[Token(Token = "0x60002CF")]
	internal void ReadEndElement(XmlReader reader) { }

	[Address(RVA = "0x22E1870", Offset = "0x22E0C70", Length = "0x70")]
	[Token(Token = "0x60002D0")]
	internal void ReadXDRSchema(XmlReader reader) { }

	[Address(RVA = "0x22E3570", Offset = "0x22E2970", Length = "0xFDF")]
	[Token(Token = "0x60002CE")]
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	[Address(RVA = "0x22E1B00", Offset = "0x22E0F00", Length = "0xA09")]
	[Token(Token = "0x60002D2")]
	private void ReadXmlDiffgram(XmlReader reader) { }

	[Address(RVA = "0x22E2510", Offset = "0x22E1910", Length = "0x1034")]
	[Token(Token = "0x60002D4")]
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	[Address(RVA = "0x22E3550", Offset = "0x22E2950", Length = "0x20")]
	[Token(Token = "0x60002DC")]
	protected override void ReadXmlSerializable(XmlReader reader) { }

	[Address(RVA = "0x22E18F0", Offset = "0x22E0CF0", Length = "0x208")]
	[Token(Token = "0x60002D3")]
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	[Address(RVA = "0x22E4550", Offset = "0x22E3950", Length = "0x17E")]
	[Token(Token = "0x60002A8")]
	internal void RecordChanged(int record) { }

	[Address(RVA = "0x22E46D0", Offset = "0x22E3AD0", Length = "0x1C1")]
	[Token(Token = "0x60002A9")]
	internal void RecordChanged(Int32[] oldIndex, Int32[] newIndex) { }

	[Address(RVA = "0x22E4AC0", Offset = "0x22E3EC0", Length = "0x197")]
	[Token(Token = "0x60002AA")]
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	[Address(RVA = "0x22E48A0", Offset = "0x22E3CA0", Length = "0x21D")]
	[Token(Token = "0x60002AB")]
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	[Address(RVA = "0x22E4C60", Offset = "0x22E4060", Length = "0x87")]
	[Token(Token = "0x60002E0")]
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	[Address(RVA = "0x22E4CF0", Offset = "0x22E40F0", Length = "0x26E")]
	[Token(Token = "0x60002AC")]
	internal Int32[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x22E4F60", Offset = "0x22E4360", Length = "0x1B7")]
	[Token(Token = "0x60002AF")]
	internal void RemoveRow(DataRow row, bool check) { }

	[Address(RVA = "0x22E5330", Offset = "0x22E4730", Length = "0x291")]
	[Token(Token = "0x60002B0")]
	public override void Reset() { }

	[Address(RVA = "0x22E5120", Offset = "0x22E4520", Length = "0x1D")]
	[Token(Token = "0x6000239")]
	private void ResetConstraints() { }

	[Address(RVA = "0x22E5140", Offset = "0x22E4540", Length = "0xA")]
	[Token(Token = "0x60002B1")]
	internal void ResetIndexes() { }

	[Address(RVA = "0x22E5150", Offset = "0x22E4550", Length = "0x1D5")]
	[Token(Token = "0x60002B2")]
	internal void ResetInternalIndexes(DataColumn column) { }

	[Address(RVA = "0x22E55D0", Offset = "0x22E49D0", Length = "0x53")]
	[Token(Token = "0x60002CC")]
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	[Address(RVA = "0x22E5630", Offset = "0x22E4A30", Length = "0x2C1")]
	[Token(Token = "0x600022A")]
	internal void RestoreIndexEvents(bool forceReset) { }

	[Address(RVA = "0x22E5900", Offset = "0x22E4D00", Length = "0x1D")]
	[Token(Token = "0x60002BA")]
	private void RestoreShadowIndexes() { }

	[Address(RVA = "0x22E5920", Offset = "0x22E4D20", Length = "0x93")]
	[Token(Token = "0x60002B3")]
	internal void RollbackRow(DataRow row) { }

	[Address(RVA = "0x22E59C0", Offset = "0x22E4DC0", Length = "0x7D8")]
	[Token(Token = "0x600021E")]
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	[Address(RVA = "0x22E61A0", Offset = "0x22E55A0", Length = "0x2D1")]
	[Token(Token = "0x600021A")]
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	[Address(RVA = "0x22E6480", Offset = "0x22E5880", Length = "0x171")]
	[Token(Token = "0x6000220")]
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	[Address(RVA = "0x22E6600", Offset = "0x22E5A00", Length = "0x638")]
	[Token(Token = "0x6000222")]
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	[Address(RVA = "0x22E6C40", Offset = "0x22E6040", Length = "0xD38")]
	[Token(Token = "0x600021C")]
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	[Address(RVA = "0x22EB160", Offset = "0x22EA560", Length = "0xBA")]
	[Token(Token = "0x6000228")]
	public void set_CaseSensitive(bool value) { }

	[Address(RVA = "0x22EB220", Offset = "0x22EA620", Length = "0x45")]
	[Token(Token = "0x600024C")]
	internal void set_ElementColumnCount(int value) { }

	[Address(RVA = "0x22EB270", Offset = "0x22EA670", Length = "0x3C")]
	[Token(Token = "0x600023E")]
	internal void set_EnforceConstraints(bool value) { }

	[Address(RVA = "0x22EB2B0", Offset = "0x22EA6B0", Length = "0x3D4")]
	[Token(Token = "0x6000245")]
	public void set_Locale(CultureInfo value) { }

	[Address(RVA = "0x22EB690", Offset = "0x22EAA90", Length = "0xB")]
	[Token(Token = "0x6000268")]
	internal void set_MaxOccurs(decimal value) { }

	[Address(RVA = "0x22EB6A0", Offset = "0x22EAAA0", Length = "0x7")]
	[Token(Token = "0x600024F")]
	internal void set_MergingData(bool value) { }

	[Address(RVA = "0x22EB6C0", Offset = "0x22EAAC0", Length = "0x2B")]
	[Token(Token = "0x6000249")]
	public void set_MinimumCapacity(int value) { }

	[Address(RVA = "0x22EB6B0", Offset = "0x22EAAB0", Length = "0xB")]
	[Token(Token = "0x600026A")]
	internal void set_MinOccurs(decimal value) { }

	[Address(RVA = "0x22EB6F0", Offset = "0x22EAAF0", Length = "0x27B")]
	[Token(Token = "0x600025D")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x22EB970", Offset = "0x22EAD70", Length = "0x166")]
	[Token(Token = "0x6000264")]
	public void set_Prefix(string value) { }

	[Address(RVA = "0x22EBAE0", Offset = "0x22EAEE0", Length = "0x4C3")]
	[Token(Token = "0x6000256")]
	public void set_PrimaryKey(DataColumn[] value) { }

	[Address(RVA = "0x22EBFB0", Offset = "0x22EB3B0", Length = "0x71")]
	[Token(Token = "0x6000232")]
	public void set_RemotingFormat(SerializationFormat value) { }

	[Address(RVA = "0x22EC030", Offset = "0x22EB430", Length = "0x7")]
	[Token(Token = "0x6000240")]
	internal void set_SuspendEnforceConstraints(bool value) { }

	[Address(RVA = "0x22EC040", Offset = "0x22EB440", Length = "0x57B")]
	[Token(Token = "0x6000259")]
	public void set_TableName(string value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[Token(Token = "0x60002C5")]
	internal void set_TypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x22EC5E0", Offset = "0x22EB9E0", Length = "0x7")]
	[Token(Token = "0x6000234")]
	internal void set_UKColumnPositionForInference(int value) { }

	[Address(RVA = "0x22EC5F0", Offset = "0x22EB9F0", Length = "0x4D5")]
	[Token(Token = "0x6000266")]
	internal void set_XmlText(DataColumn value) { }

	[Address(RVA = "0x22E7980", Offset = "0x22E6D80", Length = "0x282")]
	[Token(Token = "0x600022D")]
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	[Address(RVA = "0x22E7C10", Offset = "0x22E7010", Length = "0xD5")]
	[Token(Token = "0x600023B")]
	internal void SetDataSet(DataSet dataSet) { }

	[Address(RVA = "0x22E7CF0", Offset = "0x22E70F0", Length = "0x8C")]
	[Token(Token = "0x600026B")]
	internal void SetKeyValues(DataKey key, Object[] keyValues, int record) { }

	[Address(RVA = "0x22E7D80", Offset = "0x22E7180", Length = "0x605")]
	[Token(Token = "0x6000246")]
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	[Address(RVA = "0x22E8390", Offset = "0x22E7790", Length = "0x139")]
	[Token(Token = "0x600026E")]
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	[Address(RVA = "0x22E8DB0", Offset = "0x22E81B0", Length = "0x74")]
	[Token(Token = "0x60002B7")]
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = false, bool fireEvent = true, bool suppressEnsurePropertyChanged = false) { }

	[Address(RVA = "0x22E84D0", Offset = "0x22E78D0", Length = "0x8D4")]
	[Token(Token = "0x60002B8")]
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	[Address(RVA = "0x22E8E30", Offset = "0x22E8230", Length = "0x2C9")]
	[Token(Token = "0x60002B9")]
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	[Address(RVA = "0x22E9100", Offset = "0x22E8500", Length = "0x43")]
	[Token(Token = "0x60002BB")]
	private void SetShadowIndexes() { }

	[Address(RVA = "0x22E9150", Offset = "0x22E8550", Length = "0x89")]
	[Token(Token = "0x60002BC")]
	internal void ShadowIndexCopy() { }

	[Address(RVA = "0x22E91E0", Offset = "0x22E85E0", Length = "0x8")]
	[Token(Token = "0x600022E")]
	internal bool ShouldSerializeCaseSensitive() { }

	[Address(RVA = "0x22E91F0", Offset = "0x22E85F0", Length = "0x8")]
	[Token(Token = "0x6000247")]
	internal bool ShouldSerializeLocale() { }

	[Address(RVA = "0x22E9200", Offset = "0x22E8600", Length = "0x194")]
	[Token(Token = "0x60002AE")]
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	[Address(RVA = "0x22E93A0", Offset = "0x22E87A0", Length = "0xA2")]
	[Token(Token = "0x600022B")]
	internal void SuspendIndexEvents() { }

	[Address(RVA = "0x115BCA0", Offset = "0x115B0A0", Length = "0x14")]
	[Token(Token = "0x60002D8")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x22E9450", Offset = "0x22E8850", Length = "0xC9")]
	[Token(Token = "0x60002DA")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x22E9520", Offset = "0x22E8920", Length = "0x43")]
	[Token(Token = "0x60002DB")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x22E9570", Offset = "0x22E8970", Length = "0x75")]
	[Token(Token = "0x60002BD")]
	public virtual string ToString() { }

	[Address(RVA = "0x22E95F0", Offset = "0x22E89F0", Length = "0x19")]
	[Token(Token = "0x60002C2")]
	internal void UpdatePropertyDescriptorCollectionCache() { }

	[Address(RVA = "0x22E9610", Offset = "0x22E8A10", Length = "0x21")]
	[Token(Token = "0x60002BE")]
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x22E9A30", Offset = "0x22E8E30", Length = "0x400")]
	[Token(Token = "0x60002C8")]
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	[Address(RVA = "0x22E9640", Offset = "0x22E8A40", Length = "0x3EB")]
	[Token(Token = "0x60002CB")]
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

}

