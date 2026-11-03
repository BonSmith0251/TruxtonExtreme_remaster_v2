namespace System.Data;

[DefaultMember("Item")]
[DefaultProperty("ColumnName")]
[DesignTimeVisible(False)]
[Token(Token = "0x2000009")]
[ToolboxItem(False)]
public class DataColumn : MarshalByValueComponent
{
	[Token(Token = "0x4000028")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000009")]
	private bool _allowNull; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	private string _caption; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000B")]
	private string _columnName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000C")]
	private Type _dataType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000D")]
	private StorageType _storageType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000E")]
	internal object _defaultValue; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400000F")]
	private DataSetDateTime _dateTimeMode; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000010")]
	private DataExpression _expression; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000011")]
	private int _maxLength; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000012")]
	private int _ordinal; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000013")]
	private bool _readOnly; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000014")]
	internal Index _sortIndex; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000015")]
	internal DataTable _table; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000016")]
	private bool _unique; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000017")]
	internal MappingType _columnMapping; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000018")]
	internal int _hashCode; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000019")]
	internal int _errors; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400001A")]
	private bool _isSqlType; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x400001B")]
	private bool _implementsINullable; //Field offset: 0x91
	[FieldOffset(Offset = "0x92")]
	[Token(Token = "0x400001C")]
	private bool _implementsIChangeTracking; //Field offset: 0x92
	[FieldOffset(Offset = "0x93")]
	[Token(Token = "0x400001D")]
	private bool _implementsIRevertibleChangeTracking; //Field offset: 0x93
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400001E")]
	private bool _implementsIXMLSerializable; //Field offset: 0x94
	[FieldOffset(Offset = "0x95")]
	[Token(Token = "0x400001F")]
	private bool _defaultValueIsNull; //Field offset: 0x95
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000020")]
	internal List<DataColumn> _dependentColumns; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000021")]
	internal PropertyCollection _extendedProperties; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000022")]
	private DataStorage _storage; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000023")]
	private AutoIncrementValue _autoInc; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000024")]
	internal string _columnUri; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000025")]
	private string _columnPrefix; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000026")]
	internal string _encodedColumnName; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000027")]
	internal SimpleType _simpleType; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000029")]
	private readonly int _objectID; //Field offset: 0xD8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400002A")]
	private string <XmlDataType>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400002B")]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0xE8

	[DefaultValue(True)]
	[Token(Token = "0x17000003")]
	public bool AllowDBNull
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 5
		[Address(RVA = "0x22F11E0", Offset = "0x22F05E0", Length = "0x155")]
		[Token(Token = "0x6000014")]
		 set { } //Length: 341
	}

	[Token(Token = "0x17000006")]
	internal AutoIncrementValue AutoInc
	{
		[Address(RVA = "0x22F0A40", Offset = "0x22EFE40", Length = "0xF7")]
		[Token(Token = "0x6000019")]
		internal get { } //Length: 247
	}

	[DefaultValue(False)]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x17000004")]
	public bool AutoIncrement
	{
		[Address(RVA = "0x22F0BF0", Offset = "0x22EFFF0", Length = "0x19")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 25
		[Address(RVA = "0x22F1700", Offset = "0x22F0B00", Length = "0x1DA")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 474
	}

	[Token(Token = "0x17000005")]
	internal object AutoIncrementCurrent
	{
		[Address(RVA = "0x22F0B40", Offset = "0x22EFF40", Length = "0x4B")]
		[Token(Token = "0x6000017")]
		internal get { } //Length: 75
		[Address(RVA = "0x22F1340", Offset = "0x22F0740", Length = "0x1A0")]
		[Token(Token = "0x6000018")]
		internal set { } //Length: 416
	}

	[DefaultValue(0)]
	[Token(Token = "0x17000007")]
	public long AutoIncrementSeed
	{
		[Address(RVA = "0x22F0B90", Offset = "0x22EFF90", Length = "0x28")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 40
		[Address(RVA = "0x22F14F0", Offset = "0x22F08F0", Length = "0xFE")]
		[Token(Token = "0x600001B")]
		 set { } //Length: 254
	}

	[DefaultValue(1)]
	[Token(Token = "0x17000008")]
	public long AutoIncrementStep
	{
		[Address(RVA = "0x22F0BC0", Offset = "0x22EFFC0", Length = "0x2B")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 43
		[Address(RVA = "0x22F15F0", Offset = "0x22F09F0", Length = "0x101")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 257
	}

	[Token(Token = "0x17000009")]
	public string Caption
	{
		[Address(RVA = "0x22F0C10", Offset = "0x22F0010", Length = "0x11")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 17
		[Address(RVA = "0x22F18E0", Offset = "0x22F0CE0", Length = "0xC0")]
		[Token(Token = "0x600001F")]
		 set { } //Length: 192
	}

	[DefaultValue(MappingType::Element (1))]
	[Token(Token = "0x17000028")]
	public override MappingType ColumnMapping
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x6000054")]
		 get { } //Length: 7
		[Address(RVA = "0x22F19A0", Offset = "0x22F0DA0", Length = "0x2CD")]
		[Token(Token = "0x6000055")]
		 set { } //Length: 717
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x1700000A")]
	public string ColumnName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 5
		[Address(RVA = "0x22F1C70", Offset = "0x22F1070", Length = "0x407")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 1031
	}

	[Token(Token = "0x17000010")]
	internal bool Computed
	{
		[Address(RVA = "0x22F0C30", Offset = "0x22F0030", Length = "0x9")]
		[Token(Token = "0x6000029")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000011")]
	internal DataExpression DataExpression
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600002A")]
		internal get { } //Length: 5
	}

	[DefaultValue(typeof(string))]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x17000012")]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 5
		[Address(RVA = "0x22F2080", Offset = "0x22F1480", Length = "0xB4A")]
		[Token(Token = "0x600002C")]
		 set { } //Length: 2890
	}

	[DefaultValue(DataSetDateTime::UnspecifiedLocal (3))]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x17000013")]
	public DataSetDateTime DateTimeMode
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 4
		[Address(RVA = "0x22F2BD0", Offset = "0x22F1FD0", Length = "0x16E")]
		[Token(Token = "0x600002E")]
		 set { } //Length: 366
	}

	[Token(Token = "0x17000014")]
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue
	{
		[Address(RVA = "0x22F0C50", Offset = "0x22F0050", Length = "0x14B")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 331
		[Address(RVA = "0x22F2D40", Offset = "0x22F2140", Length = "0x2ED")]
		[Token(Token = "0x6000030")]
		 set { } //Length: 749
	}

	[Token(Token = "0x17000015")]
	internal bool DefaultValueIsNull
	{
		[Address(RVA = "0x22F0C40", Offset = "0x22F0040", Length = "0x8")]
		[Token(Token = "0x6000031")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	internal string EncodedColumnName
	{
		[Address(RVA = "0x22F0DA0", Offset = "0x22F01A0", Length = "0x7F")]
		[Token(Token = "0x6000022")]
		internal get { } //Length: 127
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x17000016")]
	public string Expression
	{
		[Address(RVA = "0x22F0E20", Offset = "0x22F0220", Length = "0x49")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 73
		[Address(RVA = "0x22F3030", Offset = "0x22F2430", Length = "0x64A")]
		[Token(Token = "0x6000033")]
		 set { } //Length: 1610
	}

	[Browsable(False)]
	[Token(Token = "0x17000017")]
	public PropertyCollection ExtendedProperties
	{
		[Address(RVA = "0x22F0E70", Offset = "0x22F0270", Length = "0x73")]
		[Token(Token = "0x6000034")]
		 get { } //Length: 115
	}

	[Token(Token = "0x1700000C")]
	internal IFormatProvider FormatProvider
	{
		[Address(RVA = "0x22F0EF0", Offset = "0x22F02F0", Length = "0x5D")]
		[Token(Token = "0x6000023")]
		internal get { } //Length: 93
	}

	[Token(Token = "0x17000018")]
	internal bool HasData
	{
		[Address(RVA = "0x22F0F50", Offset = "0x22F0350", Length = "0xC")]
		[Token(Token = "0x6000035")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x1700001A")]
	internal bool ImplementsIChangeTracking
	{
		[Address(RVA = "0x22F0F60", Offset = "0x22F0360", Length = "0x8")]
		[Token(Token = "0x6000037")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000019")]
	internal bool ImplementsINullable
	{
		[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
		[Token(Token = "0x6000036")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700001B")]
	internal bool ImplementsIRevertibleChangeTracking
	{
		[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
		[Token(Token = "0x6000038")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700002A")]
	internal bool ImplementsIXMLSerializable
	{
		[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
		[Token(Token = "0x6000068")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000029")]
	internal bool IsCustomType
	{
		[Address(RVA = "0x22F0F90", Offset = "0x22F0390", Length = "0x68")]
		[Token(Token = "0x6000066")]
		internal get { } //Length: 104
	}

	[Token(Token = "0x1700001D")]
	internal bool IsSqlType
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x600003A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700001C")]
	internal bool IsValueType
	{
		[Address(RVA = "0x22F1000", Offset = "0x22F0400", Length = "0x1E")]
		[Token(Token = "0x6000039")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x17000024")]
	internal object Item
	{
		[Address(RVA = "0x22F1020", Offset = "0x22F0420", Length = "0x2D")]
		[Token(Token = "0x6000048")]
		internal get { } //Length: 45
		[Address(RVA = "0x22F3680", Offset = "0x22F2A80", Length = "0x19A")]
		[Token(Token = "0x6000049")]
		internal set { } //Length: 410
	}

	[Token(Token = "0x1700000D")]
	internal CultureInfo Locale
	{
		[Address(RVA = "0x22F1050", Offset = "0x22F0450", Length = "0x5E")]
		[Token(Token = "0x6000024")]
		internal get { } //Length: 94
	}

	[DefaultValue(-1)]
	[Token(Token = "0x1700001E")]
	public int MaxLength
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x600003C")]
		 get { } //Length: 4
		[Address(RVA = "0x22F3820", Offset = "0x22F2C20", Length = "0x3D5")]
		[Token(Token = "0x600003D")]
		 set { } //Length: 981
	}

	[Token(Token = "0x1700001F")]
	public string Namespace
	{
		[Address(RVA = "0x22F10B0", Offset = "0x22F04B0", Length = "0x3F")]
		[Token(Token = "0x600003E")]
		 get { } //Length: 63
		[Address(RVA = "0x22F3C00", Offset = "0x22F3000", Length = "0x176")]
		[Token(Token = "0x600003F")]
		 set { } //Length: 374
	}

	[Token(Token = "0x1700000E")]
	internal int ObjectID
	{
		[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
		[Token(Token = "0x6000025")]
		internal get { } //Length: 7
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000020")]
	public int Ordinal
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	[Token(Token = "0x1700000F")]
	public string Prefix
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 8
		[Address(RVA = "0x22F3D80", Offset = "0x22F3180", Length = "0x166")]
		[Token(Token = "0x6000027")]
		 set { } //Length: 358
	}

	[DefaultValue(False)]
	[Token(Token = "0x17000021")]
	public bool ReadOnly
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 5
		[Address(RVA = "0x22F3EF0", Offset = "0x22F32F0", Length = "0xDA")]
		[Token(Token = "0x6000043")]
		 set { } //Length: 218
	}

	[Token(Token = "0x17000027")]
	internal SimpleType SimpleType
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x6000052")]
		internal get { } //Length: 8
		[Address(RVA = "0x22F3FD0", Offset = "0x22F33D0", Length = "0x58")]
		[Token(Token = "0x6000053")]
		internal set { } //Length: 88
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x17000022")]
	private Index SortIndex
	{
		[Address(RVA = "0x22F10F0", Offset = "0x22F04F0", Length = "0xE0")]
		[Token(Token = "0x6000044")]
		private get { } //Length: 224
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000023")]
	public DataTable Table
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000025")]
	public bool Unique
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 8
		[Address(RVA = "0x22F4030", Offset = "0x22F3430", Length = "0x40C")]
		[Token(Token = "0x600004E")]
		 set { } //Length: 1036
	}

	[Token(Token = "0x17000026")]
	internal string XmlDataType
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000050")]
		internal get { } //Length: 8
		[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000051")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x22F0670", Offset = "0x22EFA70", Length = "0x60")]
	[Token(Token = "0x600000F")]
	public DataColumn() { }

	[Address(RVA = "0x22F0640", Offset = "0x22EFA40", Length = "0x22")]
	[Token(Token = "0x6000010")]
	public DataColumn(string columnName, Type dataType) { }

	[Address(RVA = "0x22F06D0", Offset = "0x22EFAD0", Length = "0x369")]
	[Token(Token = "0x6000011")]
	public DataColumn(string columnName, Type dataType, string expr, MappingType type) { }

	[Address(RVA = "0x22ED950", Offset = "0x22ECD50", Length = "0x118")]
	[Token(Token = "0x6000079")]
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	[Address(RVA = "0x22EDA70", Offset = "0x22ECE70", Length = "0x123")]
	[Token(Token = "0x6000056")]
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	[Address(RVA = "0x22EDC30", Offset = "0x22ED030", Length = "0x240")]
	[Token(Token = "0x6000057")]
	internal bool CheckMaxLength() { }

	[Address(RVA = "0x22EDBA0", Offset = "0x22ECFA0", Length = "0x84")]
	[Token(Token = "0x6000058")]
	internal void CheckMaxLength(DataRow dr) { }

	[Address(RVA = "0x22EDE80", Offset = "0x22ED280", Length = "0x319")]
	[Token(Token = "0x6000059")]
	protected private void CheckNotAllowNull() { }

	[Address(RVA = "0x22EE1A0", Offset = "0x22ED5A0", Length = "0x8E")]
	[Token(Token = "0x600005A")]
	internal void CheckNullable(DataRow row) { }

	[Address(RVA = "0x22EE230", Offset = "0x22ED630", Length = "0x5D")]
	[Token(Token = "0x600005B")]
	protected void CheckUnique() { }

	[Address(RVA = "0x22EE290", Offset = "0x22ED690", Length = "0x5E2")]
	[Token(Token = "0x6000061")]
	internal DataColumn Clone() { }

	[Address(RVA = "0x22EEA90", Offset = "0x22EDE90", Length = "0x2D")]
	[Token(Token = "0x600005C")]
	internal int Compare(int record1, int record2) { }

	[Address(RVA = "0x22EE880", Offset = "0x22EDC80", Length = "0x1D2")]
	[Token(Token = "0x600005D")]
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	[Address(RVA = "0x22EEA60", Offset = "0x22EDE60", Length = "0x2D")]
	[Token(Token = "0x600005E")]
	internal int CompareValueTo(int record1, object value) { }

	[Address(RVA = "0x22EEB10", Offset = "0x22EDF10", Length = "0x6E")]
	[Token(Token = "0x6000075")]
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x22EEAC0", Offset = "0x22EDEC0", Length = "0x49")]
	[Token(Token = "0x6000074")]
	internal string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x22EEB80", Offset = "0x22EDF80", Length = "0x2D")]
	[Token(Token = "0x600005F")]
	internal object ConvertValue(object value) { }

	[Address(RVA = "0x22EEC00", Offset = "0x22EE000", Length = "0x59")]
	[Token(Token = "0x6000073")]
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x22EEBB0", Offset = "0x22EDFB0", Length = "0x49")]
	[Token(Token = "0x6000072")]
	internal object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x22EEC90", Offset = "0x22EE090", Length = "0x2D")]
	[Token(Token = "0x6000060")]
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	[Address(RVA = "0x22EEC60", Offset = "0x22EE060", Length = "0x27")]
	[Token(Token = "0x6000077")]
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x22EECC0", Offset = "0x22EE0C0", Length = "0x34")]
	[Token(Token = "0x600004C")]
	internal void FreeRecord(int record) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000013")]
	public bool get_AllowDBNull() { }

	[Address(RVA = "0x22F0A40", Offset = "0x22EFE40", Length = "0xF7")]
	[Token(Token = "0x6000019")]
	internal AutoIncrementValue get_AutoInc() { }

	[Address(RVA = "0x22F0BF0", Offset = "0x22EFFF0", Length = "0x19")]
	[Token(Token = "0x6000015")]
	public bool get_AutoIncrement() { }

	[Address(RVA = "0x22F0B40", Offset = "0x22EFF40", Length = "0x4B")]
	[Token(Token = "0x6000017")]
	internal object get_AutoIncrementCurrent() { }

	[Address(RVA = "0x22F0B90", Offset = "0x22EFF90", Length = "0x28")]
	[Token(Token = "0x600001A")]
	public long get_AutoIncrementSeed() { }

	[Address(RVA = "0x22F0BC0", Offset = "0x22EFFC0", Length = "0x2B")]
	[Token(Token = "0x600001C")]
	public long get_AutoIncrementStep() { }

	[Address(RVA = "0x22F0C10", Offset = "0x22F0010", Length = "0x11")]
	[Token(Token = "0x600001E")]
	public string get_Caption() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[Token(Token = "0x6000054")]
	public override MappingType get_ColumnMapping() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000020")]
	public string get_ColumnName() { }

	[Address(RVA = "0x22F0C30", Offset = "0x22F0030", Length = "0x9")]
	[Token(Token = "0x6000029")]
	internal bool get_Computed() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600002A")]
	internal DataExpression get_DataExpression() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600002B")]
	public Type get_DataType() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x600002D")]
	public DataSetDateTime get_DateTimeMode() { }

	[Address(RVA = "0x22F0C50", Offset = "0x22F0050", Length = "0x14B")]
	[Token(Token = "0x600002F")]
	public object get_DefaultValue() { }

	[Address(RVA = "0x22F0C40", Offset = "0x22F0040", Length = "0x8")]
	[Token(Token = "0x6000031")]
	internal bool get_DefaultValueIsNull() { }

	[Address(RVA = "0x22F0DA0", Offset = "0x22F01A0", Length = "0x7F")]
	[Token(Token = "0x6000022")]
	internal string get_EncodedColumnName() { }

	[Address(RVA = "0x22F0E20", Offset = "0x22F0220", Length = "0x49")]
	[Token(Token = "0x6000032")]
	public string get_Expression() { }

	[Address(RVA = "0x22F0E70", Offset = "0x22F0270", Length = "0x73")]
	[Token(Token = "0x6000034")]
	public PropertyCollection get_ExtendedProperties() { }

	[Address(RVA = "0x22F0EF0", Offset = "0x22F02F0", Length = "0x5D")]
	[Token(Token = "0x6000023")]
	internal IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x22F0F50", Offset = "0x22F0350", Length = "0xC")]
	[Token(Token = "0x6000035")]
	internal bool get_HasData() { }

	[Address(RVA = "0x22F0F60", Offset = "0x22F0360", Length = "0x8")]
	[Token(Token = "0x6000037")]
	internal bool get_ImplementsIChangeTracking() { }

	[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
	[Token(Token = "0x6000036")]
	internal bool get_ImplementsINullable() { }

	[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
	[Token(Token = "0x6000038")]
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
	[Token(Token = "0x6000068")]
	internal bool get_ImplementsIXMLSerializable() { }

	[Address(RVA = "0x22F0F90", Offset = "0x22F0390", Length = "0x68")]
	[Token(Token = "0x6000066")]
	internal bool get_IsCustomType() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x600003A")]
	internal bool get_IsSqlType() { }

	[Address(RVA = "0x22F1000", Offset = "0x22F0400", Length = "0x1E")]
	[Token(Token = "0x6000039")]
	internal bool get_IsValueType() { }

	[Address(RVA = "0x22F1020", Offset = "0x22F0420", Length = "0x2D")]
	[Token(Token = "0x6000048")]
	internal object get_Item(int record) { }

	[Address(RVA = "0x22F1050", Offset = "0x22F0450", Length = "0x5E")]
	[Token(Token = "0x6000024")]
	internal CultureInfo get_Locale() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x600003C")]
	public int get_MaxLength() { }

	[Address(RVA = "0x22F10B0", Offset = "0x22F04B0", Length = "0x3F")]
	[Token(Token = "0x600003E")]
	public string get_Namespace() { }

	[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
	[Token(Token = "0x6000025")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x6000040")]
	public int get_Ordinal() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6000026")]
	public string get_Prefix() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6000042")]
	public bool get_ReadOnly() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x6000052")]
	internal SimpleType get_SimpleType() { }

	[Address(RVA = "0x22F10F0", Offset = "0x22F04F0", Length = "0xE0")]
	[Token(Token = "0x6000044")]
	private Index get_SortIndex() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000045")]
	public DataTable get_Table() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[Token(Token = "0x600004D")]
	public bool get_Unique() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000050")]
	internal string get_XmlDataType() { }

	[Address(RVA = "0x22EED00", Offset = "0x22EE100", Length = "0xD5")]
	[Token(Token = "0x6000062")]
	internal object GetAggregateValue(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x22EEDE0", Offset = "0x22EE1E0", Length = "0xE9")]
	[Token(Token = "0x6000028")]
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x22EEED0", Offset = "0x22EE2D0", Length = "0x27")]
	[Token(Token = "0x6000047")]
	private DataRow GetDataRow(int index) { }

	[Address(RVA = "0x22EEF00", Offset = "0x22EE300", Length = "0x3B")]
	[Token(Token = "0x6000076")]
	internal object GetEmptyColumnStore(int recordCount) { }

	[Address(RVA = "0x22EEF40", Offset = "0x22EE340", Length = "0x2D")]
	[Token(Token = "0x6000063")]
	private int GetStringLength(int record) { }

	[Address(RVA = "0x22EEF70", Offset = "0x22EE370", Length = "0x2CE")]
	[Token(Token = "0x600007B")]
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

	[Address(RVA = "0x22EF240", Offset = "0x22EE640", Length = "0xC0")]
	[Token(Token = "0x6000064")]
	internal void Init(int record) { }

	[Address(RVA = "0x22EF310", Offset = "0x22EE710", Length = "0x4A")]
	[Token(Token = "0x600004A")]
	internal void InitializeRecord(int record) { }

	[Address(RVA = "0x22EF360", Offset = "0x22EE760", Length = "0x8C")]
	[Token(Token = "0x600006E")]
	private void InsureStorage() { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[Token(Token = "0x600004F")]
	internal void InternalUnique(bool value) { }

	[Address(RVA = "0x22EF3F0", Offset = "0x22EE7F0", Length = "0x28B")]
	[Token(Token = "0x6000065")]
	internal static bool IsAutoIncrementType(Type dataType) { }

	[Address(RVA = "0x22EF680", Offset = "0x22EEA80", Length = "0x14F")]
	[Token(Token = "0x6000069")]
	internal bool IsInRelation() { }

	[Address(RVA = "0x22EF7D0", Offset = "0x22EEBD0", Length = "0x418")]
	[Token(Token = "0x600006A")]
	internal bool IsMaxLengthViolated() { }

	[Address(RVA = "0x22EFBF0", Offset = "0x22EEFF0", Length = "0x1AA")]
	[Token(Token = "0x600006B")]
	internal bool IsNotAllowDBNullViolated() { }

	[Address(RVA = "0x22EFDA0", Offset = "0x22EF1A0", Length = "0xBA")]
	[Token(Token = "0x6000067")]
	internal bool IsValueCustomTypeInstance(object value) { }

	[Address(RVA = "0x22EFE60", Offset = "0x22EF260", Length = "0x22")]
	[Token(Token = "0x600006C")]
	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000070")]
	internal void OnSetDataSet() { }

	[Address(RVA = "0x22EFE90", Offset = "0x22EF290", Length = "0x77")]
	[Token(Token = "0x600006D")]
	protected private void RaisePropertyChanging(string name) { }

	[Address(RVA = "0x22EFF10", Offset = "0x22EF310", Length = "0x9A")]
	[Token(Token = "0x600007A")]
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	[Address(RVA = "0x22F11E0", Offset = "0x22F05E0", Length = "0x155")]
	[Token(Token = "0x6000014")]
	public void set_AllowDBNull(bool value) { }

	[Address(RVA = "0x22F1700", Offset = "0x22F0B00", Length = "0x1DA")]
	[Token(Token = "0x6000016")]
	public void set_AutoIncrement(bool value) { }

	[Address(RVA = "0x22F1340", Offset = "0x22F0740", Length = "0x1A0")]
	[Token(Token = "0x6000018")]
	internal void set_AutoIncrementCurrent(object value) { }

	[Address(RVA = "0x22F14F0", Offset = "0x22F08F0", Length = "0xFE")]
	[Token(Token = "0x600001B")]
	public void set_AutoIncrementSeed(long value) { }

	[Address(RVA = "0x22F15F0", Offset = "0x22F09F0", Length = "0x101")]
	[Token(Token = "0x600001D")]
	public void set_AutoIncrementStep(long value) { }

	[Address(RVA = "0x22F18E0", Offset = "0x22F0CE0", Length = "0xC0")]
	[Token(Token = "0x600001F")]
	public void set_Caption(string value) { }

	[Address(RVA = "0x22F19A0", Offset = "0x22F0DA0", Length = "0x2CD")]
	[Token(Token = "0x6000055")]
	public override void set_ColumnMapping(MappingType value) { }

	[Address(RVA = "0x22F1C70", Offset = "0x22F1070", Length = "0x407")]
	[Token(Token = "0x6000021")]
	public void set_ColumnName(string value) { }

	[Address(RVA = "0x22F2080", Offset = "0x22F1480", Length = "0xB4A")]
	[Token(Token = "0x600002C")]
	public void set_DataType(Type value) { }

	[Address(RVA = "0x22F2BD0", Offset = "0x22F1FD0", Length = "0x16E")]
	[Token(Token = "0x600002E")]
	public void set_DateTimeMode(DataSetDateTime value) { }

	[Address(RVA = "0x22F2D40", Offset = "0x22F2140", Length = "0x2ED")]
	[Token(Token = "0x6000030")]
	public void set_DefaultValue(object value) { }

	[Address(RVA = "0x22F3030", Offset = "0x22F2430", Length = "0x64A")]
	[Token(Token = "0x6000033")]
	public void set_Expression(string value) { }

	[Address(RVA = "0x22F3680", Offset = "0x22F2A80", Length = "0x19A")]
	[Token(Token = "0x6000049")]
	internal void set_Item(int record, object value) { }

	[Address(RVA = "0x22F3820", Offset = "0x22F2C20", Length = "0x3D5")]
	[Token(Token = "0x600003D")]
	public void set_MaxLength(int value) { }

	[Address(RVA = "0x22F3C00", Offset = "0x22F3000", Length = "0x176")]
	[Token(Token = "0x600003F")]
	public void set_Namespace(string value) { }

	[Address(RVA = "0x22F3D80", Offset = "0x22F3180", Length = "0x166")]
	[Token(Token = "0x6000027")]
	public void set_Prefix(string value) { }

	[Address(RVA = "0x22F3EF0", Offset = "0x22F32F0", Length = "0xDA")]
	[Token(Token = "0x6000043")]
	public void set_ReadOnly(bool value) { }

	[Address(RVA = "0x22F3FD0", Offset = "0x22F33D0", Length = "0x58")]
	[Token(Token = "0x6000053")]
	internal void set_SimpleType(SimpleType value) { }

	[Address(RVA = "0x22F4030", Offset = "0x22F3430", Length = "0x40C")]
	[Token(Token = "0x600004E")]
	public void set_Unique(bool value) { }

	[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000051")]
	internal void set_XmlDataType(string value) { }

	[Address(RVA = "0x22EFFB0", Offset = "0x22EF3B0", Length = "0x47")]
	[Token(Token = "0x600006F")]
	internal void SetCapacity(int capacity) { }

	[Address(RVA = "0x22F0000", Offset = "0x22EF400", Length = "0x120")]
	[Token(Token = "0x600003B")]
	private void SetMaxLengthSimpleType() { }

	[Address(RVA = "0x22F0130", Offset = "0x22EF530", Length = "0x134")]
	[Token(Token = "0x6000041")]
	internal void SetOrdinalInternal(int ordinal) { }

	[Address(RVA = "0x22F0270", Offset = "0x22EF670", Length = "0x4D")]
	[Token(Token = "0x6000078")]
	internal void SetStorage(object store, BitArray nullbits) { }

	[Address(RVA = "0x22F02C0", Offset = "0x22EF6C0", Length = "0xD0")]
	[Token(Token = "0x6000046")]
	internal void SetTable(DataTable table) { }

	[Address(RVA = "0x22F03A0", Offset = "0x22EF7A0", Length = "0xEF")]
	[Token(Token = "0x600004B")]
	internal void SetValue(int record, object value) { }

	[Address(RVA = "0x22F0490", Offset = "0x22EF890", Length = "0x98")]
	[Token(Token = "0x6000071")]
	public virtual string ToString() { }

	[Address(RVA = "0x22F0530", Offset = "0x22EF930", Length = "0x107")]
	[Token(Token = "0x6000012")]
	private void UpdateColumnType(Type type, StorageType typeCode) { }

}

