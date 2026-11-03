namespace System.Data;

[DefaultProperty("RelationName")]
[Token(Token = "0x2000036")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation
{
	[Token(Token = "0x4000123")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000113")]
	private DataSet _dataSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000114")]
	internal PropertyCollection _extendedProperties; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000115")]
	internal string _relationName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000116")]
	private DataKey _childKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000117")]
	private DataKey _parentKey; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000118")]
	private UniqueConstraint _parentKeyConstraint; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000119")]
	private ForeignKeyConstraint _childKeyConstraint; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400011A")]
	internal String[] _parentColumnNames; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400011B")]
	internal String[] _childColumnNames; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400011C")]
	internal string _parentTableName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400011D")]
	internal string _childTableName; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400011E")]
	internal string _parentTableNamespace; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400011F")]
	internal string _childTableNamespace; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000120")]
	internal bool _nested; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000121")]
	internal bool _createConstraints; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x4000122")]
	private bool _checkMultipleNested; //Field offset: 0x7A
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000124")]
	private readonly int _objectID; //Field offset: 0x7C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000125")]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x80

	[Token(Token = "0x170000A2")]
	internal bool CheckMultipleNested
	{
		[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
		[Token(Token = "0x60003EC")]
		internal get { } //Length: 5
		[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
		[Token(Token = "0x60003ED")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000098")]
	internal String[] ChildColumnNames
	{
		[Address(RVA = "0x231DDE0", Offset = "0x231D1E0", Length = "0xB")]
		[Token(Token = "0x60003D9")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000092")]
	public override DataColumn[] ChildColumns
	{
		[Address(RVA = "0x231DE10", Offset = "0x231D210", Length = "0x20")]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000093")]
	internal DataColumn[] ChildColumnsReference
	{
		[Address(RVA = "0x231DDF0", Offset = "0x231D1F0", Length = "0x1A")]
		[Token(Token = "0x60003D4")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000094")]
	internal DataKey ChildKey
	{
		[Address(RVA = "0x231DDF0", Offset = "0x231D1F0", Length = "0x1A")]
		[Token(Token = "0x60003D5")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170000A0")]
	public override ForeignKeyConstraint ChildKeyConstraint
	{
		[Address(RVA = "0x231DE30", Offset = "0x231D230", Length = "0x1A")]
		[Token(Token = "0x60003EA")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000095")]
	public override DataTable ChildTable
	{
		[Address(RVA = "0x231DE50", Offset = "0x231D250", Length = "0x3D")]
		[Token(Token = "0x60003D6")]
		 get { } //Length: 61
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[Token(Token = "0x17000096")]
	public override DataSet DataSet
	{
		[Address(RVA = "0x231DE90", Offset = "0x231D290", Length = "0x1A")]
		[Token(Token = "0x60003D7")]
		 get { } //Length: 26
	}

	[Browsable(False)]
	[Token(Token = "0x170000A1")]
	public PropertyCollection ExtendedProperties
	{
		[Address(RVA = "0x231DEB0", Offset = "0x231D2B0", Length = "0x6A")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 106
	}

	[DefaultValue(False)]
	[Token(Token = "0x1700009E")]
	public override bool Nested
	{
		[Address(RVA = "0x231DF20", Offset = "0x231D320", Length = "0x1A")]
		[Token(Token = "0x60003E6")]
		 get { } //Length: 26
		[Address(RVA = "0x231E020", Offset = "0x231D420", Length = "0xF26")]
		[Token(Token = "0x60003E7")]
		 set { } //Length: 3878
	}

	[Token(Token = "0x170000A3")]
	internal int ObjectID
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x60003F8")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000097")]
	internal String[] ParentColumnNames
	{
		[Address(RVA = "0x231DF40", Offset = "0x231D340", Length = "0xB")]
		[Token(Token = "0x60003D8")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000099")]
	public override DataColumn[] ParentColumns
	{
		[Address(RVA = "0x231DF50", Offset = "0x231D350", Length = "0x20")]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700009A")]
	internal DataColumn[] ParentColumnsReference
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60003E0")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700009B")]
	internal DataKey ParentKey
	{
		[Address(RVA = "0x231DF90", Offset = "0x231D390", Length = "0x1A")]
		[Token(Token = "0x60003E1")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x1700009F")]
	public override UniqueConstraint ParentKeyConstraint
	{
		[Address(RVA = "0x231DF70", Offset = "0x231D370", Length = "0x1A")]
		[Token(Token = "0x60003E8")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700009C")]
	public override DataTable ParentTable
	{
		[Address(RVA = "0x231DFB0", Offset = "0x231D3B0", Length = "0x3D")]
		[Token(Token = "0x60003E2")]
		 get { } //Length: 61
	}

	[DefaultValue(null)]
	[Token(Token = "0x1700009D")]
	public override string RelationName
	{
		[Address(RVA = "0x231DFF0", Offset = "0x231D3F0", Length = "0x1A")]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x231D880", Offset = "0x231CC80", Length = "0x241")]
	[Token(Token = "0x60003CE")]
	public DataRelation(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	[Address(RVA = "0x231DB90", Offset = "0x231CF90", Length = "0x1C")]
	[Token(Token = "0x60003CF")]
	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Address(RVA = "0x231DAD0", Offset = "0x231CED0", Length = "0xB7")]
	[Token(Token = "0x60003D0")]
	public DataRelation(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Address(RVA = "0x231DCD0", Offset = "0x231D0D0", Length = "0xF1")]
	[Browsable(False)]
	[Token(Token = "0x60003D1")]
	public DataRelation(string relationName, string parentTableName, string childTableName, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	[Address(RVA = "0x231DBB0", Offset = "0x231CFB0", Length = "0x115")]
	[Browsable(False)]
	[Token(Token = "0x60003D2")]
	public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, String[] parentColumnNames, String[] childColumnNames, bool nested) { }

	[Address(RVA = "0x231B640", Offset = "0x231AA40", Length = "0x28C")]
	[Token(Token = "0x60003E4")]
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	[Address(RVA = "0x231B8D0", Offset = "0x231ACD0", Length = "0x437")]
	[Token(Token = "0x60003E5")]
	internal void CheckNestedRelations() { }

	[Address(RVA = "0x231BD70", Offset = "0x231B170", Length = "0x2DF")]
	[Token(Token = "0x60003EF")]
	internal void CheckState() { }

	[Address(RVA = "0x231BD10", Offset = "0x231B110", Length = "0x5C")]
	[Token(Token = "0x60003F0")]
	protected void CheckStateForProperty() { }

	[Address(RVA = "0x231C050", Offset = "0x231B450", Length = "0x71B")]
	[Token(Token = "0x60003F2")]
	internal DataRelation Clone(DataSet destination) { }

	[Address(RVA = "0x231C770", Offset = "0x231BB70", Length = "0x2FB")]
	[Token(Token = "0x60003F1")]
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
	[Token(Token = "0x60003EC")]
	internal bool get_CheckMultipleNested() { }

	[Address(RVA = "0x231DDE0", Offset = "0x231D1E0", Length = "0xB")]
	[Token(Token = "0x60003D9")]
	internal String[] get_ChildColumnNames() { }

	[Address(RVA = "0x231DE10", Offset = "0x231D210", Length = "0x20")]
	[Token(Token = "0x60003D3")]
	public override DataColumn[] get_ChildColumns() { }

	[Address(RVA = "0x231DDF0", Offset = "0x231D1F0", Length = "0x1A")]
	[Token(Token = "0x60003D4")]
	internal DataColumn[] get_ChildColumnsReference() { }

	[Address(RVA = "0x231DDF0", Offset = "0x231D1F0", Length = "0x1A")]
	[Token(Token = "0x60003D5")]
	internal DataKey get_ChildKey() { }

	[Address(RVA = "0x231DE30", Offset = "0x231D230", Length = "0x1A")]
	[Token(Token = "0x60003EA")]
	public override ForeignKeyConstraint get_ChildKeyConstraint() { }

	[Address(RVA = "0x231DE50", Offset = "0x231D250", Length = "0x3D")]
	[Token(Token = "0x60003D6")]
	public override DataTable get_ChildTable() { }

	[Address(RVA = "0x231DE90", Offset = "0x231D290", Length = "0x1A")]
	[Token(Token = "0x60003D7")]
	public override DataSet get_DataSet() { }

	[Address(RVA = "0x231DEB0", Offset = "0x231D2B0", Length = "0x6A")]
	[Token(Token = "0x60003EB")]
	public PropertyCollection get_ExtendedProperties() { }

	[Address(RVA = "0x231DF20", Offset = "0x231D320", Length = "0x1A")]
	[Token(Token = "0x60003E6")]
	public override bool get_Nested() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x60003F8")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x231DF40", Offset = "0x231D340", Length = "0xB")]
	[Token(Token = "0x60003D8")]
	internal String[] get_ParentColumnNames() { }

	[Address(RVA = "0x231DF50", Offset = "0x231D350", Length = "0x20")]
	[Token(Token = "0x60003DF")]
	public override DataColumn[] get_ParentColumns() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60003E0")]
	internal DataColumn[] get_ParentColumnsReference() { }

	[Address(RVA = "0x231DF90", Offset = "0x231D390", Length = "0x1A")]
	[Token(Token = "0x60003E1")]
	internal DataKey get_ParentKey() { }

	[Address(RVA = "0x231DF70", Offset = "0x231D370", Length = "0x1A")]
	[Token(Token = "0x60003E8")]
	public override UniqueConstraint get_ParentKeyConstraint() { }

	[Address(RVA = "0x231DFB0", Offset = "0x231D3B0", Length = "0x3D")]
	[Token(Token = "0x60003E2")]
	public override DataTable get_ParentTable() { }

	[Address(RVA = "0x231DFF0", Offset = "0x231D3F0", Length = "0x1A")]
	[Token(Token = "0x60003E3")]
	public override string get_RelationName() { }

	[Address(RVA = "0x231CA70", Offset = "0x231BE70", Length = "0x183")]
	[Token(Token = "0x60003DB")]
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	[Address(RVA = "0x231CC00", Offset = "0x231C000", Length = "0x20B")]
	[Token(Token = "0x60003DD")]
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	[Address(RVA = "0x231CE10", Offset = "0x231C210", Length = "0x183")]
	[Token(Token = "0x60003DC")]
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	[Address(RVA = "0x231CFA0", Offset = "0x231C3A0", Length = "0x1B3")]
	[Token(Token = "0x60003F7")]
	private bool IsAutoGenerated(DataColumn col) { }

	[Address(RVA = "0x231D160", Offset = "0x231C560", Length = "0xA0")]
	[Token(Token = "0x60003DA")]
	private static bool IsKeyNull(Object[] values) { }

	[Address(RVA = "0x231D210", Offset = "0x231C610", Length = "0xC3")]
	[Token(Token = "0x60003F3")]
	protected private void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	[Address(RVA = "0x231D2E0", Offset = "0x231C6E0", Length = "0x106")]
	[Token(Token = "0x60003F4")]
	protected private void RaisePropertyChanging(string name) { }

	[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
	[Token(Token = "0x60003ED")]
	internal void set_CheckMultipleNested(bool value) { }

	[Address(RVA = "0x231E020", Offset = "0x231D420", Length = "0xF26")]
	[Token(Token = "0x60003E7")]
	public override void set_Nested(bool value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60003EE")]
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	[Address(RVA = "0x231D3F0", Offset = "0x231C7F0", Length = "0x14")]
	[Token(Token = "0x60003DE")]
	internal void SetDataSet(DataSet dataSet) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60003E9")]
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
	[Token(Token = "0x60003F5")]
	public virtual string ToString() { }

	[Address(RVA = "0x231D410", Offset = "0x231C810", Length = "0x462")]
	[Token(Token = "0x60003F6")]
	internal void ValidateMultipleNestedRelations() { }

}

