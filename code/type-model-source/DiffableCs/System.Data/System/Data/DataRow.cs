namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x200003B")]
public class DataRow
{
	[Token(Token = "0x4000142")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000134")]
	private readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000135")]
	private readonly DataColumnCollection _columns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000136")]
	internal int _oldRecord; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000137")]
	internal int _newRecord; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000138")]
	internal int _tempRecord; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000139")]
	internal long _rowID; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400013A")]
	internal DataRowAction _action; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400013B")]
	internal bool _inChangingEvent; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x400013C")]
	internal bool _inDeletingEvent; //Field offset: 0x3D
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x400013D")]
	internal bool _inCascade; //Field offset: 0x3E
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400013E")]
	private DataColumn _lastChangedColumn; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400013F")]
	private int _countColumnChange; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000140")]
	private DataError _error; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000141")]
	private int _rbTreeNodeId; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000143")]
	internal readonly int _objectID; //Field offset: 0x5C

	[Token(Token = "0x170000BC")]
	public bool HasErrors
	{
		[Address(RVA = "0x2323360", Offset = "0x2322760", Length = "0x3D")]
		[Token(Token = "0x600044F")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170000B2")]
	internal bool HasPropertyChanged
	{
		[Address(RVA = "0x23233A0", Offset = "0x23227A0", Length = "0x8")]
		[Token(Token = "0x6000431")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000B8")]
	public string Item
	{
		[Address(RVA = "0x2323BC0", Offset = "0x2322FC0", Length = "0x92")]
		[Token(Token = "0x600043D")]
		 set { } //Length: 146
	}

	[Token(Token = "0x170000B9")]
	public object Item
	{
		[Address(RVA = "0x2323490", Offset = "0x2322890", Length = "0x101")]
		[Token(Token = "0x600043E")]
		 get { } //Length: 257
		[Address(RVA = "0x2323C60", Offset = "0x2323060", Length = "0x408")]
		[Token(Token = "0x600043F")]
		 set { } //Length: 1032
	}

	[Token(Token = "0x170000BA")]
	public object Item
	{
		[Address(RVA = "0x23233B0", Offset = "0x23227B0", Length = "0xD2")]
		[Token(Token = "0x6000440")]
		 get { } //Length: 210
	}

	[Token(Token = "0x170000BB")]
	public Object[] ItemArray
	{
		[Address(RVA = "0x2323790", Offset = "0x2322B90", Length = "0x42F")]
		[Token(Token = "0x6000441")]
		 set { } //Length: 1071
	}

	[Token(Token = "0x170000B1")]
	internal DataColumn LastChangedColumn
	{
		[Address(RVA = "0x23235A0", Offset = "0x23229A0", Length = "0xE")]
		[Token(Token = "0x600042F")]
		internal get { } //Length: 14
		[Address(RVA = "0x2324070", Offset = "0x2323470", Length = "0x10")]
		[Token(Token = "0x6000430")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x170000B3")]
	internal int RBTreeNodeId
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x6000432")]
		internal get { } //Length: 4
		[Address(RVA = "0x2324080", Offset = "0x2323480", Length = "0xA3")]
		[Token(Token = "0x6000433")]
		internal set { } //Length: 163
	}

	[Token(Token = "0x170000B4")]
	public string RowError
	{
		[Address(RVA = "0x23235B0", Offset = "0x23229B0", Length = "0x22")]
		[Token(Token = "0x6000434")]
		 get { } //Length: 34
		[Address(RVA = "0x2324130", Offset = "0x2323530", Length = "0x1CC")]
		[Token(Token = "0x6000435")]
		 set { } //Length: 460
	}

	[Token(Token = "0x170000B5")]
	internal long rowID
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000437")]
		internal get { } //Length: 5
		[Address(RVA = "0x2324300", Offset = "0x2323700", Length = "0x39")]
		[Token(Token = "0x6000438")]
		internal set { } //Length: 57
	}

	[Token(Token = "0x170000B6")]
	public DataRowState RowState
	{
		[Address(RVA = "0x23235E0", Offset = "0x23229E0", Length = "0x1AF")]
		[Token(Token = "0x6000439")]
		 get { } //Length: 431
	}

	[Token(Token = "0x170000B7")]
	public DataTable Table
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600043A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x23232B0", Offset = "0x23226B0", Length = "0xA3")]
	[Token(Token = "0x600042E")]
	protected private DataRow(DataRowBuilder builder) { }

	[Address(RVA = "0x2320200", Offset = "0x231F600", Length = "0x286")]
	[Token(Token = "0x6000442")]
	public void AcceptChanges() { }

	[Address(RVA = "0x2320570", Offset = "0x231F970", Length = "0x7")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000443")]
	public void BeginEdit() { }

	[Address(RVA = "0x2320490", Offset = "0x231F890", Length = "0xD6")]
	[Token(Token = "0x6000444")]
	private bool BeginEditInternal() { }

	[Address(RVA = "0x2320580", Offset = "0x231F980", Length = "0x6B")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000445")]
	public void CancelEdit() { }

	[Address(RVA = "0x23205F0", Offset = "0x231F9F0", Length = "0xB7")]
	[Token(Token = "0x6000446")]
	private void CheckColumn(DataColumn column) { }

	[Address(RVA = "0x23206B0", Offset = "0x231FAB0", Length = "0xFE")]
	[Token(Token = "0x600043B")]
	internal void CheckForLoops(DataRelation rel) { }

	[Address(RVA = "0x23207B0", Offset = "0x231FBB0", Length = "0x3B")]
	[Token(Token = "0x6000447")]
	internal void CheckInTable() { }

	[Address(RVA = "0x23207F0", Offset = "0x231FBF0", Length = "0x105")]
	[Token(Token = "0x600044E")]
	internal void ClearError(DataColumn column) { }

	[Address(RVA = "0x2320900", Offset = "0x231FD00", Length = "0xD1")]
	[Token(Token = "0x600044D")]
	public void ClearErrors() { }

	[Address(RVA = "0x23209E0", Offset = "0x231FDE0", Length = "0x397")]
	[Token(Token = "0x600046F")]
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

	[Address(RVA = "0x2320D80", Offset = "0x2320180", Length = "0x60")]
	[Token(Token = "0x6000448")]
	public void Delete() { }

	[Address(RVA = "0x2320DF0", Offset = "0x23201F0", Length = "0xDC")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000449")]
	public void EndEdit() { }

	[Address(RVA = "0x2323360", Offset = "0x2322760", Length = "0x3D")]
	[Token(Token = "0x600044F")]
	public bool get_HasErrors() { }

	[Address(RVA = "0x23233A0", Offset = "0x23227A0", Length = "0x8")]
	[Token(Token = "0x6000431")]
	internal bool get_HasPropertyChanged() { }

	[Address(RVA = "0x2323490", Offset = "0x2322890", Length = "0x101")]
	[Token(Token = "0x600043E")]
	public object get_Item(DataColumn column) { }

	[Address(RVA = "0x23233B0", Offset = "0x23227B0", Length = "0xD2")]
	[Token(Token = "0x6000440")]
	public object get_Item(DataColumn column, DataRowVersion version) { }

	[Address(RVA = "0x23235A0", Offset = "0x23229A0", Length = "0xE")]
	[Token(Token = "0x600042F")]
	internal DataColumn get_LastChangedColumn() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x6000432")]
	internal int get_RBTreeNodeId() { }

	[Address(RVA = "0x23235B0", Offset = "0x23229B0", Length = "0x22")]
	[Token(Token = "0x6000434")]
	public string get_RowError() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000437")]
	internal long get_rowID() { }

	[Address(RVA = "0x23235E0", Offset = "0x23229E0", Length = "0x1AF")]
	[Token(Token = "0x6000439")]
	public DataRowState get_RowState() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600043A")]
	public DataTable get_Table() { }

	[Address(RVA = "0x2320EE0", Offset = "0x23202E0", Length = "0x299")]
	[Token(Token = "0x6000452")]
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	[Address(RVA = "0x2320ED0", Offset = "0x23202D0", Length = "0xE")]
	[Token(Token = "0x6000451")]
	public DataRow[] GetChildRows(DataRelation relation) { }

	[Address(RVA = "0x2321180", Offset = "0x2320580", Length = "0x1B0")]
	[Token(Token = "0x600044C")]
	public string GetColumnError(DataColumn column) { }

	[Address(RVA = "0x23213F0", Offset = "0x23207F0", Length = "0x13D")]
	[Token(Token = "0x6000450")]
	public DataColumn[] GetColumnsInError() { }

	[Address(RVA = "0x23213A0", Offset = "0x23207A0", Length = "0x4B")]
	[Token(Token = "0x6000459")]
	internal Object[] GetColumnValues(DataColumn[] columns) { }

	[Address(RVA = "0x2321340", Offset = "0x2320740", Length = "0x5A")]
	[Token(Token = "0x600045A")]
	internal Object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	[Address(RVA = "0x2321530", Offset = "0x2320930", Length = "0x3D")]
	[Token(Token = "0x600045D")]
	internal int GetCurrentRecordNo() { }

	[Address(RVA = "0x2321570", Offset = "0x2320970", Length = "0x75")]
	[Token(Token = "0x6000453")]
	internal DataColumn GetDataColumn(string columnName) { }

	[Address(RVA = "0x23215F0", Offset = "0x23209F0", Length = "0x5A")]
	[Token(Token = "0x600045E")]
	internal int GetDefaultRecord() { }

	[Address(RVA = "0x2321650", Offset = "0x2320A50", Length = "0x24")]
	[Token(Token = "0x6000462")]
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	[Address(RVA = "0x2321680", Offset = "0x2320A80", Length = "0x79")]
	[Token(Token = "0x600045B")]
	internal Object[] GetKeyValues(DataKey key) { }

	[Address(RVA = "0x2321700", Offset = "0x2320B00", Length = "0x28")]
	[Token(Token = "0x600045C")]
	internal Object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	[Address(RVA = "0x2321730", Offset = "0x2320B30", Length = "0xC7")]
	[Token(Token = "0x600043C")]
	internal int GetNestedParentCount() { }

	[Address(RVA = "0x2321800", Offset = "0x2320C00", Length = "0xC5")]
	[Token(Token = "0x6000456")]
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	[Address(RVA = "0x23218D0", Offset = "0x2320CD0", Length = "0x3D")]
	[Token(Token = "0x600045F")]
	internal int GetOriginalRecordNo() { }

	[Address(RVA = "0x2321A90", Offset = "0x2320E90", Length = "0xE")]
	[Token(Token = "0x6000454")]
	public DataRow GetParentRow(DataRelation relation) { }

	[Address(RVA = "0x2321910", Offset = "0x2320D10", Length = "0x177")]
	[Token(Token = "0x6000455")]
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	[Address(RVA = "0x2321D40", Offset = "0x2321140", Length = "0xE")]
	[Token(Token = "0x6000457")]
	public DataRow[] GetParentRows(DataRelation relation) { }

	[Address(RVA = "0x2321AA0", Offset = "0x2320EA0", Length = "0x299")]
	[Token(Token = "0x6000458")]
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	[Address(RVA = "0x2321D50", Offset = "0x2321150", Length = "0x3D")]
	[Token(Token = "0x6000460")]
	private int GetProposedRecordNo() { }

	[Address(RVA = "0x2321D90", Offset = "0x2321190", Length = "0xEE")]
	[Token(Token = "0x6000461")]
	internal int GetRecordFromVersion(DataRowVersion version) { }

	[Address(RVA = "0x2321E80", Offset = "0x2321280", Length = "0x4A")]
	[Token(Token = "0x6000463")]
	internal DataViewRowState GetRecordState(int record) { }

	[Address(RVA = "0x2321ED0", Offset = "0x23212D0", Length = "0x23")]
	[Token(Token = "0x6000464")]
	internal bool HasKeyChanged(DataKey key) { }

	[Address(RVA = "0x2321F00", Offset = "0x2321300", Length = "0x8E")]
	[Token(Token = "0x6000465")]
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	[Address(RVA = "0x2321F90", Offset = "0x2321390", Length = "0x88")]
	[Token(Token = "0x6000466")]
	public bool HasVersion(DataRowVersion version) { }

	[Address(RVA = "0x2322020", Offset = "0x2321420", Length = "0x23")]
	[Token(Token = "0x6000467")]
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	[Address(RVA = "0x2322050", Offset = "0x2321450", Length = "0x180")]
	[Token(Token = "0x6000468")]
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	[Address(RVA = "0x23221E0", Offset = "0x23215E0", Length = "0x4A4")]
	[Token(Token = "0x6000469")]
	public void RejectChanges() { }

	[Address(RVA = "0x2322690", Offset = "0x2321A90", Length = "0x29")]
	[Token(Token = "0x600046A")]
	internal void ResetLastChangedColumn() { }

	[Address(RVA = "0x23226C0", Offset = "0x2321AC0", Length = "0x4D")]
	[Token(Token = "0x6000436")]
	private void RowErrorChanged() { }

	[Address(RVA = "0x2323BC0", Offset = "0x2322FC0", Length = "0x92")]
	[Token(Token = "0x600043D")]
	public void set_Item(string columnName, object value) { }

	[Address(RVA = "0x2323C60", Offset = "0x2323060", Length = "0x408")]
	[Token(Token = "0x600043F")]
	public void set_Item(DataColumn column, object value) { }

	[Address(RVA = "0x2323790", Offset = "0x2322B90", Length = "0x42F")]
	[Token(Token = "0x6000441")]
	public void set_ItemArray(Object[] value) { }

	[Address(RVA = "0x2324070", Offset = "0x2323470", Length = "0x10")]
	[Token(Token = "0x6000430")]
	internal void set_LastChangedColumn(DataColumn value) { }

	[Address(RVA = "0x2324080", Offset = "0x2323480", Length = "0xA3")]
	[Token(Token = "0x6000433")]
	internal void set_RBTreeNodeId(int value) { }

	[Address(RVA = "0x2324130", Offset = "0x2323530", Length = "0x1CC")]
	[Token(Token = "0x6000435")]
	public void set_RowError(string value) { }

	[Address(RVA = "0x2324300", Offset = "0x2323700", Length = "0x39")]
	[Token(Token = "0x6000438")]
	internal void set_rowID(long value) { }

	[Address(RVA = "0x2322710", Offset = "0x2321B10", Length = "0x2C2")]
	[Token(Token = "0x600044B")]
	public void SetColumnError(DataColumn column, string error) { }

	[Address(RVA = "0x23229E0", Offset = "0x2321DE0", Length = "0x76")]
	[Token(Token = "0x600044A")]
	public void SetColumnError(int columnIndex, string error) { }

	[Address(RVA = "0x2322A60", Offset = "0x2321E60", Length = "0x11C")]
	[Token(Token = "0x600046B")]
	internal void SetKeyValues(DataKey key, Object[] keyValues) { }

	[Address(RVA = "0x2322B80", Offset = "0x2321F80", Length = "0x343")]
	[Token(Token = "0x600046C")]
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	[Address(RVA = "0x23230F0", Offset = "0x23224F0", Length = "0x1BE")]
	[Token(Token = "0x600046E")]
	internal void SetParentRowToDBNull(DataRelation relation) { }

	[Address(RVA = "0x2322ED0", Offset = "0x23222D0", Length = "0x212")]
	[Token(Token = "0x600046D")]
	internal void SetParentRowToDBNull() { }

}

