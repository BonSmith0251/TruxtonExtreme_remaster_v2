namespace System.Data;

[Token(Token = "0x2000088")]
internal sealed class Index
{
	[CompilerGenerated]
	[Token(Token = "0x200008A")]
	private sealed class <>c
	{
		[Token(Token = "0x40002B5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002B6")]
		public static Func<DataViewListener, DataViewListener, Boolean> <>9__22_0; //Field offset: 0x8
		[Token(Token = "0x40002B7")]
		public static Action<DataViewListener, DataViewListener, ListChangedEventArgs, Boolean, Boolean> <>9__85_0; //Field offset: 0x10

		[Address(RVA = "0x234EA00", Offset = "0x234DE00", Length = "0x67")]
		[Token(Token = "0x6000728")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000729")]
		public <>c() { }

		[Address(RVA = "0x234E9B0", Offset = "0x234DDB0", Length = "0x7")]
		[Token(Token = "0x600072A")]
		internal bool <.ctor>b__22_0(DataViewListener listener) { }

		[Address(RVA = "0x234E980", Offset = "0x234DD80", Length = "0x26")]
		[Token(Token = "0x600072B")]
		internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <>c__DisplayClass86_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002B8")]
		public ListChangedType changedType; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600072C")]
		public <>c__DisplayClass86_0() { }

		[Address(RVA = "0x234E9C0", Offset = "0x234DDC0", Length = "0x35")]
		[Token(Token = "0x600072D")]
		internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

	}

	[Token(Token = "0x2000089")]
	private sealed class IndexTree : RBTree<Int32>
	{
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002B4")]
		private readonly Index _index; //Field offset: 0x40

		[Address(RVA = "0x2343710", Offset = "0x2342B10", Length = "0x5A")]
		[Token(Token = "0x6000725")]
		internal IndexTree(Index index) { }

		[Address(RVA = "0x23436D0", Offset = "0x2342AD0", Length = "0x1E")]
		[Token(Token = "0x6000726")]
		protected virtual int CompareNode(int record1, int record2) { }

		[Address(RVA = "0x23436F0", Offset = "0x2342AF0", Length = "0x1E")]
		[Token(Token = "0x6000727")]
		protected virtual int CompareSateliteTreeNode(int record1, int record2) { }

	}

	[Token(Token = "0x40002B2")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A6")]
	private readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A7")]
	internal readonly IndexField[] _indexFields; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A8")]
	private readonly Comparison<DataRow> _comparison; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A9")]
	private readonly DataViewRowState _recordStates; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AA")]
	private WeakReference _rowFilter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002AB")]
	private IndexTree _records; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002AC")]
	private int _recordCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002AD")]
	private int _refCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002AE")]
	private Listeners<DataViewListener> _listeners; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002AF")]
	private bool _suspendEvents; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40002B0")]
	private readonly bool _isSharable; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x40002B1")]
	private readonly bool _hasRemoteAggregate; //Field offset: 0x52
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40002B3")]
	private readonly int _objectID; //Field offset: 0x54

	[Token(Token = "0x17000115")]
	private bool DoListChanged
	{
		[Address(RVA = "0x23472E0", Offset = "0x23466E0", Length = "0x69")]
		[Token(Token = "0x6000718")]
		private get { } //Length: 105
	}

	[Token(Token = "0x17000112")]
	public bool HasDuplicates
	{
		[Address(RVA = "0x2347350", Offset = "0x2346750", Length = "0x44")]
		[Token(Token = "0x60006F0")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700010E")]
	internal bool HasRemoteAggregate
	{
		[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
		[Token(Token = "0x60006EB")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700010F")]
	internal int ObjectID
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60006EC")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000113")]
	public int RecordCount
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000110")]
	public DataViewRowState RecordStates
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000114")]
	public int RefCount
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x60006F6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000111")]
	public IFilter RowFilter
	{
		[Address(RVA = "0x23473A0", Offset = "0x23467A0", Length = "0x81")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000116")]
	internal DataTable Table
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000722")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x23472B0", Offset = "0x23466B0", Length = "0x29")]
	[Token(Token = "0x60006E6")]
	public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x2346E20", Offset = "0x2346220", Length = "0x150")]
	[Token(Token = "0x60006E7")]
	public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x2346F80", Offset = "0x2346380", Length = "0x32E")]
	[Token(Token = "0x60006E9")]
	private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x2343770", Offset = "0x2342B70", Length = "0x149")]
	[Token(Token = "0x60006F3")]
	private bool AcceptRecord(int record, IFilter filter) { }

	[Address(RVA = "0x23438C0", Offset = "0x2342CC0", Length = "0x30")]
	[Token(Token = "0x60006F2")]
	private bool AcceptRecord(int record) { }

	[Address(RVA = "0x23438F0", Offset = "0x2342CF0", Length = "0x1F7")]
	[Token(Token = "0x60006F7")]
	public void AddRef() { }

	[Address(RVA = "0x2343AF0", Offset = "0x2342EF0", Length = "0xC1")]
	[Token(Token = "0x60006F9")]
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	[Address(RVA = "0x2343BC0", Offset = "0x2342FC0", Length = "0x47")]
	[Token(Token = "0x60006FA")]
	public bool CheckUnique() { }

	[Address(RVA = "0x2343C10", Offset = "0x2343010", Length = "0x71")]
	[Token(Token = "0x60006FC")]
	private int CompareDataRows(int record1, int record2) { }

	[Address(RVA = "0x2343C90", Offset = "0x2343090", Length = "0x1F0")]
	[Token(Token = "0x60006FD")]
	private int CompareDuplicateRecords(int record1, int record2) { }

	[Address(RVA = "0x2343F80", Offset = "0x2343380", Length = "0x1F8")]
	[Token(Token = "0x60006FB")]
	private int CompareRecords(int record1, int record2) { }

	[Address(RVA = "0x2343E90", Offset = "0x2343290", Length = "0xE7")]
	[Token(Token = "0x60006FE")]
	private int CompareRecordToKey(int record1, Object[] vals) { }

	[Address(RVA = "0x23442B0", Offset = "0x23436B0", Length = "0xB")]
	[Token(Token = "0x6000700")]
	private void DeleteRecord(int recordIndex) { }

	[Address(RVA = "0x2344190", Offset = "0x2343590", Length = "0x11A")]
	[Token(Token = "0x6000701")]
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	[Address(RVA = "0x2344180", Offset = "0x2343580", Length = "0xB")]
	[Token(Token = "0x60006FF")]
	public void DeleteRecordFromIndex(int recordIndex) { }

	[Address(RVA = "0x23442C0", Offset = "0x23436C0", Length = "0xCA")]
	[Token(Token = "0x60006EA")]
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	[Address(RVA = "0x2344470", Offset = "0x2343870", Length = "0x1FD")]
	[Token(Token = "0x6000706")]
	private int FindNodeByKey(object originalKey) { }

	[Address(RVA = "0x2344390", Offset = "0x2343790", Length = "0xD1")]
	[Token(Token = "0x6000708")]
	private int FindNodeByKeyRecord(int record) { }

	[Address(RVA = "0x2344670", Offset = "0x2343A70", Length = "0x307")]
	[Token(Token = "0x6000707")]
	private int FindNodeByKeys(Object[] originalKey) { }

	[Address(RVA = "0x2344980", Offset = "0x2343D80", Length = "0x50")]
	[Token(Token = "0x600070B")]
	public Range FindRecords(Object[] key) { }

	[Address(RVA = "0x23449D0", Offset = "0x2343DD0", Length = "0x50")]
	[Token(Token = "0x600070A")]
	public Range FindRecords(object key) { }

	[Address(RVA = "0x2344A20", Offset = "0x2343E20", Length = "0x125")]
	[Token(Token = "0x600070C")]
	internal void FireResetEvent() { }

	[Address(RVA = "0x23472E0", Offset = "0x23466E0", Length = "0x69")]
	[Token(Token = "0x6000718")]
	private bool get_DoListChanged() { }

	[Address(RVA = "0x2347350", Offset = "0x2346750", Length = "0x44")]
	[Token(Token = "0x60006F0")]
	public bool get_HasDuplicates() { }

	[Address(RVA = "0x1CF2E10", Offset = "0x1CF2210", Length = "0x5")]
	[Token(Token = "0x60006EB")]
	internal bool get_HasRemoteAggregate() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60006EC")]
	internal int get_ObjectID() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60006F1")]
	public int get_RecordCount() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60006ED")]
	public DataViewRowState get_RecordStates() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x60006F6")]
	public int get_RefCount() { }

	[Address(RVA = "0x23473A0", Offset = "0x23467A0", Length = "0x81")]
	[Token(Token = "0x60006EE")]
	public IFilter get_RowFilter() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000722")]
	internal DataTable get_Table() { }

	[Address(RVA = "0x2344B50", Offset = "0x2343F50", Length = "0x103")]
	[Token(Token = "0x60006E8")]
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	[Address(RVA = "0x2344C60", Offset = "0x2344060", Length = "0x19")]
	[Token(Token = "0x600070D")]
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	[Address(RVA = "0x2344C80", Offset = "0x2344080", Length = "0x69")]
	[Token(Token = "0x6000702")]
	public RBTreeEnumerator<Int32> GetEnumerator(int startIndex) { }

	[Address(RVA = "0x2344D50", Offset = "0x2344150", Length = "0x1A3")]
	[Token(Token = "0x6000704")]
	private int GetIndex(int record, int changeRecord) { }

	[Address(RVA = "0x2344CF0", Offset = "0x23440F0", Length = "0x51")]
	[Token(Token = "0x6000703")]
	public int GetIndex(int record) { }

	[Address(RVA = "0x2344F00", Offset = "0x2344300", Length = "0x17A")]
	[Token(Token = "0x6000709")]
	private Range GetRangeFromNode(int nodeId) { }

	[Address(RVA = "0x2345080", Offset = "0x2344480", Length = "0x51")]
	[Token(Token = "0x60006EF")]
	public int GetRecord(int recordIndex) { }

	[Address(RVA = "0x23450E0", Offset = "0x23444E0", Length = "0x16")]
	[Token(Token = "0x600070E")]
	private static int GetReplaceAction(DataViewRowState oldState) { }

	[Address(RVA = "0x2345100", Offset = "0x2344500", Length = "0x89")]
	[Token(Token = "0x600070F")]
	public DataRow GetRow(int i) { }

	[Address(RVA = "0x2345370", Offset = "0x2344770", Length = "0x4B")]
	[Token(Token = "0x6000710")]
	public DataRow[] GetRows(Object[] values) { }

	[Address(RVA = "0x2345190", Offset = "0x2344590", Length = "0x1DD")]
	[Token(Token = "0x6000711")]
	public DataRow[] GetRows(Range range) { }

	[Address(RVA = "0x23453C0", Offset = "0x23447C0", Length = "0xCD")]
	[Token(Token = "0x6000705")]
	public Object[] GetUniqueKeyValues() { }

	[Address(RVA = "0x2345490", Offset = "0x2344890", Length = "0x244")]
	[Token(Token = "0x6000723")]
	private void GetUniqueKeyValues(List<Object[]> list, int curNodeId) { }

	[Address(RVA = "0x82FB70", Offset = "0x82EF70", Length = "0x73")]
	[Token(Token = "0x6000724")]
	internal static int IndexOfReference(List<T> list, T item) { }

	[Address(RVA = "0x23456E0", Offset = "0x2344AE0", Length = "0x37E")]
	[Token(Token = "0x6000712")]
	private void InitRecords(IFilter filter) { }

	[Address(RVA = "0x2345AC0", Offset = "0x2344EC0", Length = "0x231")]
	[Token(Token = "0x6000714")]
	private int InsertRecord(int record, bool fireEvent) { }

	[Address(RVA = "0x2345A60", Offset = "0x2344E60", Length = "0x54")]
	[Token(Token = "0x6000713")]
	public int InsertRecordToIndex(int record) { }

	[Address(RVA = "0x2345D00", Offset = "0x2345100", Length = "0x16")]
	[Token(Token = "0x6000715")]
	public bool IsKeyInIndex(object key) { }

	[Address(RVA = "0x2345D20", Offset = "0x2345120", Length = "0x16")]
	[Token(Token = "0x6000716")]
	public bool IsKeyInIndex(Object[] key) { }

	[Address(RVA = "0x2345D40", Offset = "0x2345140", Length = "0xD4")]
	[Token(Token = "0x6000717")]
	public bool IsKeyRecordInIndex(int record) { }

	[Address(RVA = "0x2345E20", Offset = "0x2345220", Length = "0x53")]
	[Token(Token = "0x60006F4")]
	internal void ListChangedAdd(DataViewListener listener) { }

	[Address(RVA = "0x2345E80", Offset = "0x2345280", Length = "0x53")]
	[Token(Token = "0x60006F5")]
	internal void ListChangedRemove(DataViewListener listener) { }

	[Address(RVA = "0x2345EE0", Offset = "0x23452E0", Length = "0x12B")]
	[Token(Token = "0x600071C")]
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	[Address(RVA = "0x2346010", Offset = "0x2345410", Length = "0xCE")]
	[Token(Token = "0x600071A")]
	private void OnListChanged(ListChangedType changedType, int index) { }

	[Address(RVA = "0x23460E0", Offset = "0x23454E0", Length = "0xE8")]
	[Token(Token = "0x6000719")]
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	[Address(RVA = "0x23461D0", Offset = "0x23455D0", Length = "0x1A6")]
	[Token(Token = "0x600071B")]
	private void OnListChanged(ListChangedEventArgs e) { }

	[Address(RVA = "0x23464C0", Offset = "0x23458C0", Length = "0x13C")]
	[Token(Token = "0x600071E")]
	public void RecordChanged(int record) { }

	[Address(RVA = "0x2346380", Offset = "0x2345780", Length = "0x137")]
	[Token(Token = "0x600071F")]
	public void RecordChanged(int oldIndex, int newIndex) { }

	[Address(RVA = "0x2346980", Offset = "0x2345D80", Length = "0x10C")]
	[Token(Token = "0x6000720")]
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	[Address(RVA = "0x2346600", Offset = "0x2345A00", Length = "0x376")]
	[Token(Token = "0x6000721")]
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	[Address(RVA = "0x2346A90", Offset = "0x2345E90", Length = "0x1AB")]
	[Token(Token = "0x60006F8")]
	public int RemoveRef() { }

	[Address(RVA = "0x2346C40", Offset = "0x2346040", Length = "0x1D6")]
	[Token(Token = "0x600071D")]
	public void Reset() { }

}

