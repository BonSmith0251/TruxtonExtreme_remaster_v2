namespace System.Data;

[DefaultEvent("PositionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
[Token(Token = "0x2000050")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
{
	[Token(Token = "0x2000051")]
	private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
	{
		[Token(Token = "0x4000193")]
		internal static readonly DataRowReferenceComparer s_default; //Field offset: 0x0

		[Address(RVA = "0x2333B10", Offset = "0x2332F10", Length = "0x67")]
		[Token(Token = "0x600052C")]
		private static DataRowReferenceComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000529")]
		private DataRowReferenceComparer() { }

		[Address(RVA = "0x2152360", Offset = "0x2151760", Length = "0x7")]
		[Token(Token = "0x600052A")]
		public override bool Equals(DataRow x, DataRow y) { }

		[Address(RVA = "0x2333AF0", Offset = "0x2332EF0", Length = "0x16")]
		[Token(Token = "0x600052B")]
		public override int GetHashCode(DataRow obj) { }

	}

	[Token(Token = "0x4000189")]
	internal static ListChangedEventArgs s_resetEventArgs; //Field offset: 0x0
	[Token(Token = "0x4000191")]
	private static int s_objectTypeCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000177")]
	private DataViewManager _dataViewManager; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000178")]
	private DataTable _table; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000179")]
	private bool _locked; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017A")]
	private Index _index; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017B")]
	private Dictionary<String, Index> _findIndexes; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400017C")]
	private string _sort; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400017D")]
	private Comparison<DataRow> _comparison; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400017E")]
	private IFilter _rowFilter; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400017F")]
	private DataViewRowState _recordStates; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000180")]
	private bool _shouldOpen; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x4000181")]
	private bool _open; //Field offset: 0x65
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x4000182")]
	private bool _allowNew; //Field offset: 0x66
	[FieldOffset(Offset = "0x67")]
	[Token(Token = "0x4000183")]
	private bool _allowEdit; //Field offset: 0x67
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000184")]
	private bool _allowDelete; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000185")]
	private bool _applyDefaultSort; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000186")]
	internal DataRow _addNewRow; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000187")]
	private ListChangedEventArgs _addNewMoved; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000188")]
	private ListChangedEventHandler _onListChanged; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400018A")]
	private string _delayedSort; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400018B")]
	private DataViewRowState _delayedRecordStates; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400018C")]
	private bool _fInitInProgress; //Field offset: 0x94
	[FieldOffset(Offset = "0x95")]
	[Token(Token = "0x400018D")]
	private bool _fEndInitInProgress; //Field offset: 0x95
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400018E")]
	private Dictionary<DataRow, DataRowView> _rowViewCache; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400018F")]
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000190")]
	private DataViewListener _dvListener; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000192")]
	private readonly int _objectID; //Field offset: 0xB0

	[DefaultValue(True)]
	[Token(Token = "0x170000CC")]
	public bool AllowDelete
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x60004D7")]
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	[Token(Token = "0x170000CD")]
	public bool AllowEdit
	{
		[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 5
	}

	[DefaultValue(True)]
	[Token(Token = "0x170000CE")]
	public bool AllowNew
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 5
	}

	[Browsable(False)]
	[Token(Token = "0x170000CF")]
	public override int Count
	{
		[Address(RVA = "0x2338D50", Offset = "0x2338150", Length = "0x47")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000D0")]
	private int CountFromIndex
	{
		[Address(RVA = "0x2338D20", Offset = "0x2338120", Length = "0x2B")]
		[Token(Token = "0x60004DB")]
		private get { } //Length: 43
	}

	[Browsable(False)]
	[Token(Token = "0x170000D1")]
	public DataViewManager DataViewManager
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 5
	}

	[Browsable(False)]
	[Token(Token = "0x170000D2")]
	protected bool IsOpen
	{
		[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
		[Token(Token = "0x60004DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DA")]
	public DataRowView Item
	{
		[Address(RVA = "0x2337D20", Offset = "0x2337120", Length = "0x5E")]
		[Token(Token = "0x60004E7")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170000E6")]
	internal int ObjectID
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[Token(Token = "0x6000527")]
		internal get { } //Length: 7
	}

	[DefaultValue(DataViewRowState::CurrentRows (22))]
	[Token(Token = "0x170000D4")]
	public DataViewRowState RowStateFilter
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x60004DF")]
		 get { } //Length: 4
	}

	[DefaultValue(null)]
	[Token(Token = "0x170000D5")]
	public string Sort
	{
		[Address(RVA = "0x2338DB0", Offset = "0x23381B0", Length = "0x54")]
		[Token(Token = "0x60004E0")]
		 get { } //Length: 84
		[Address(RVA = "0x2338E10", Offset = "0x2338210", Length = "0x1CE")]
		[Token(Token = "0x60004E1")]
		 set { } //Length: 462
	}

	[Token(Token = "0x170000D6")]
	internal Comparison<DataRow> SortComparison
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60004E2")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000D3")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004DE")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000D7")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60004E3")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170000DC")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004F4")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000DB")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60004F3")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000D9")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x2337D20", Offset = "0x2337120", Length = "0x5E")]
		[Token(Token = "0x60004E5")]
		private get { } //Length: 94
		[Address(RVA = "0x2337D80", Offset = "0x2337180", Length = "0x27")]
		[Token(Token = "0x60004E6")]
		private set { } //Length: 39
	}

	[Token(Token = "0x170000DE")]
	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
		[Token(Token = "0x6000501")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000DD")]
	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[Token(Token = "0x60004FF")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000DF")]
	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6000502")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000E3")]
	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		[Address(RVA = "0x23382D0", Offset = "0x23376D0", Length = "0x5E")]
		[Token(Token = "0x6000506")]
		private get { } //Length: 94
	}

	[Token(Token = "0x170000E5")]
	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		[Address(RVA = "0x2338330", Offset = "0x2337730", Length = "0x3D")]
		[Token(Token = "0x6000509")]
		private get { } //Length: 61
	}

	[Token(Token = "0x170000E4")]
	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		[Address(RVA = "0x2338370", Offset = "0x2337770", Length = "0x8E")]
		[Token(Token = "0x6000507")]
		private get { } //Length: 142
	}

	[Token(Token = "0x170000E0")]
	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000503")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000E1")]
	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000504")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000E2")]
	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000505")]
		private get { } //Length: 3
	}

	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties::All (1))]
	[Token(Token = "0x170000D8")]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60004E4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x23388F0", Offset = "0x2337CF0", Length = "0x7C")]
	[Token(Token = "0x6000528")]
	private static DataView() { }

	[Address(RVA = "0x2338970", Offset = "0x2337D70", Length = "0x336")]
	[Token(Token = "0x60004D5")]
	internal DataView(DataTable table, bool locked) { }

	[Address(RVA = "0x2338CB0", Offset = "0x23380B0", Length = "0x6E")]
	[Token(Token = "0x60004D6")]
	public DataView(DataTable table) { }

	[Address(RVA = "0x23350D0", Offset = "0x23344D0", Length = "0x2BA")]
	[Token(Token = "0x60004E8")]
	public override DataRowView AddNew() { }

	[Address(RVA = "0x2335390", Offset = "0x2334790", Length = "0x3A")]
	[Token(Token = "0x60004E9")]
	private void CheckOpen() { }

	[Address(RVA = "0x23353D0", Offset = "0x23347D0", Length = "0x5B")]
	[Token(Token = "0x60004EA")]
	private void CheckSort(string sort) { }

	[Address(RVA = "0x2335430", Offset = "0x2334830", Length = "0x236")]
	[Token(Token = "0x6000523")]
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2335670", Offset = "0x2334A70", Length = "0x42")]
	[Token(Token = "0x60004EB")]
	protected void Close() { }

	[Address(RVA = "0x23356E0", Offset = "0x2334AE0", Length = "0x236")]
	[Token(Token = "0x6000525")]
	protected override void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x23356C0", Offset = "0x2334AC0", Length = "0x14")]
	[Token(Token = "0x6000526")]
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2335A80", Offset = "0x2334E80", Length = "0x21E")]
	[Token(Token = "0x60004ED")]
	private void CopyTo(DataRowView[] array, int index) { }

	[Address(RVA = "0x2335920", Offset = "0x2334D20", Length = "0x15A")]
	[Token(Token = "0x60004EC")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x2335CA0", Offset = "0x23350A0", Length = "0xEA")]
	[Token(Token = "0x600050F")]
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	[Address(RVA = "0x2335F80", Offset = "0x2335380", Length = "0x24")]
	[Token(Token = "0x60004EE")]
	public void Delete(int index) { }

	[Address(RVA = "0x2335D90", Offset = "0x2335190", Length = "0x1EA")]
	[Token(Token = "0x60004EF")]
	internal void Delete(DataRow row) { }

	[Address(RVA = "0x2335FB0", Offset = "0x23353B0", Length = "0x61")]
	[Token(Token = "0x60004F0")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2336020", Offset = "0x2335420", Length = "0x1E4")]
	[Token(Token = "0x60004F1")]
	internal void FinishAddNew(bool success) { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x60004D7")]
	public bool get_AllowDelete() { }

	[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
	[Token(Token = "0x60004D8")]
	public bool get_AllowEdit() { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[Token(Token = "0x60004D9")]
	public bool get_AllowNew() { }

	[Address(RVA = "0x2338D50", Offset = "0x2338150", Length = "0x47")]
	[Token(Token = "0x60004DA")]
	public override int get_Count() { }

	[Address(RVA = "0x2338D20", Offset = "0x2338120", Length = "0x2B")]
	[Token(Token = "0x60004DB")]
	private int get_CountFromIndex() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60004DC")]
	public DataViewManager get_DataViewManager() { }

	[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
	[Token(Token = "0x60004DD")]
	protected bool get_IsOpen() { }

	[Address(RVA = "0x2337D20", Offset = "0x2337120", Length = "0x5E")]
	[Token(Token = "0x60004E7")]
	public DataRowView get_Item(int recordIndex) { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[Token(Token = "0x6000527")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x60004DF")]
	public DataViewRowState get_RowStateFilter() { }

	[Address(RVA = "0x2338DB0", Offset = "0x23381B0", Length = "0x54")]
	[Token(Token = "0x60004E0")]
	public string get_Sort() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60004E2")]
	internal Comparison<DataRow> get_SortComparison() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60004E4")]
	public DataTable get_Table() { }

	[Address(RVA = "0x2336210", Offset = "0x2335610", Length = "0x9E")]
	[Token(Token = "0x60004F2")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000512")]
	internal override IFilter GetFilter() { }

	[Address(RVA = "0x23362B0", Offset = "0x23356B0", Length = "0x1B8")]
	[Token(Token = "0x60004FE")]
	internal Index GetFindIndex(string column, bool keepIndex) { }

	[Address(RVA = "0x2336470", Offset = "0x2335870", Length = "0xB4")]
	[Token(Token = "0x6000513")]
	private int GetRecord(int recordIndex) { }

	[Address(RVA = "0x2336610", Offset = "0x2335A10", Length = "0x15E")]
	[Token(Token = "0x6000514")]
	internal DataRow GetRow(int index) { }

	[Address(RVA = "0x2336590", Offset = "0x2335990", Length = "0x70")]
	[Token(Token = "0x6000515")]
	private DataRowView GetRowView(int record) { }

	[Address(RVA = "0x2336530", Offset = "0x2335930", Length = "0x56")]
	[Token(Token = "0x6000516")]
	private DataRowView GetRowView(DataRow dr) { }

	[Address(RVA = "0x2336770", Offset = "0x2335B70", Length = "0x87")]
	[Token(Token = "0x6000508")]
	internal PropertyDescriptor GetSortProperty() { }

	[Address(RVA = "0x23368D0", Offset = "0x2335CD0", Length = "0x84")]
	[Token(Token = "0x6000517")]
	protected override void IndexListChanged(object sender, ListChangedEventArgs e) { }

	[Address(RVA = "0x2336800", Offset = "0x2335C00", Length = "0xCE")]
	[Token(Token = "0x6000518")]
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	[Address(RVA = "0x23369C0", Offset = "0x2335DC0", Length = "0x14C")]
	[Token(Token = "0x60004F9")]
	internal int IndexOf(DataRowView rowview) { }

	[Address(RVA = "0x2336960", Offset = "0x2335D60", Length = "0x5F")]
	[Token(Token = "0x60004FA")]
	private int IndexOfDataRowView(DataRowView rowview) { }

	[Address(RVA = "0x2336B10", Offset = "0x2335F10", Length = "0x2C4")]
	[Token(Token = "0x6000519")]
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	[Address(RVA = "0x2336E00", Offset = "0x2336200", Length = "0x298")]
	[Token(Token = "0x600051A")]
	protected override void OnListChanged(ListChangedEventArgs e) { }

	[Address(RVA = "0x23370C0", Offset = "0x23364C0", Length = "0x236")]
	[Token(Token = "0x6000524")]
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2337580", Offset = "0x2336980", Length = "0x28")]
	[Token(Token = "0x600051B")]
	protected void Reset() { }

	[Address(RVA = "0x2337300", Offset = "0x2336700", Length = "0x27A")]
	[Token(Token = "0x600051C")]
	internal void ResetRowViewCache() { }

	[Address(RVA = "0x2338E10", Offset = "0x2338210", Length = "0x1CE")]
	[Token(Token = "0x60004E1")]
	public void set_Sort(string value) { }

	[Address(RVA = "0x23375B0", Offset = "0x23369B0", Length = "0x1A2")]
	[Token(Token = "0x600051D")]
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	[Address(RVA = "0x23379B0", Offset = "0x2336DB0", Length = "0x1C")]
	[Token(Token = "0x600051E")]
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	[Address(RVA = "0x2337760", Offset = "0x2336B60", Length = "0x24F")]
	[Token(Token = "0x600051F")]
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004DE")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60004E3")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x23379D0", Offset = "0x2336DD0", Length = "0x84")]
	[Token(Token = "0x60004F5")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2337A60", Offset = "0x2336E60", Length = "0x27")]
	[Token(Token = "0x60004F6")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2337A90", Offset = "0x2336E90", Length = "0x87")]
	[Token(Token = "0x60004F7")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004F4")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004F3")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x2337D20", Offset = "0x2337120", Length = "0x5E")]
	[Token(Token = "0x60004E5")]
	private override object System.Collections.IList.get_Item(int recordIndex) { }

	[Address(RVA = "0x2337B20", Offset = "0x2336F20", Length = "0x81")]
	[Token(Token = "0x60004F8")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x2337BB0", Offset = "0x2336FB0", Length = "0x27")]
	[Token(Token = "0x60004FB")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2337BE0", Offset = "0x2336FE0", Length = "0x132")]
	[Token(Token = "0x60004FC")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2335F80", Offset = "0x2335380", Length = "0x24")]
	[Token(Token = "0x60004FD")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2337D80", Offset = "0x2337180", Length = "0x27")]
	[Token(Token = "0x60004E6")]
	private override void System.Collections.IList.set_Item(int recordIndex, object value) { }

	[Address(RVA = "0x2337DB0", Offset = "0x23371B0", Length = "0x42")]
	[Token(Token = "0x600050A")]
	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	[Address(RVA = "0x2337E00", Offset = "0x2337200", Length = "0x14")]
	[Token(Token = "0x6000500")]
	private override object System.ComponentModel.IBindingList.AddNew() { }

	[Address(RVA = "0x2337E20", Offset = "0x2337220", Length = "0x108")]
	[Token(Token = "0x600050B")]
	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	[Address(RVA = "0x2337F30", Offset = "0x2337330", Length = "0x27D")]
	[Token(Token = "0x600050C")]
	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	[Address(RVA = "0x23382B0", Offset = "0x23376B0", Length = "0x5")]
	[Token(Token = "0x6000501")]
	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[Token(Token = "0x60004FF")]
	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6000502")]
	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	[Address(RVA = "0x23382D0", Offset = "0x23376D0", Length = "0x5E")]
	[Token(Token = "0x6000506")]
	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	[Address(RVA = "0x2338330", Offset = "0x2337730", Length = "0x3D")]
	[Token(Token = "0x6000509")]
	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[Address(RVA = "0x2338370", Offset = "0x2337770", Length = "0x8E")]
	[Token(Token = "0x6000507")]
	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000503")]
	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000504")]
	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000505")]
	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	[Address(RVA = "0x23381B0", Offset = "0x23375B0", Length = "0x42")]
	[Token(Token = "0x600050D")]
	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	[Address(RVA = "0x2338200", Offset = "0x2337600", Length = "0xAB")]
	[Token(Token = "0x600050E")]
	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	[Address(RVA = "0x2338400", Offset = "0x2337800", Length = "0xCB")]
	[Token(Token = "0x6000511")]
	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	[Address(RVA = "0x23384D0", Offset = "0x23378D0", Length = "0x75")]
	[Token(Token = "0x6000510")]
	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	[Address(RVA = "0x2338550", Offset = "0x2337950", Length = "0x36C")]
	[Token(Token = "0x6000522")]
	internal void UpdateIndex(bool force, bool fireEvent) { }

	[Address(RVA = "0x23388C0", Offset = "0x2337CC0", Length = "0x16")]
	[Token(Token = "0x6000520")]
	protected void UpdateIndex() { }

	[Address(RVA = "0x23388E0", Offset = "0x2337CE0", Length = "0xB")]
	[Token(Token = "0x6000521")]
	protected override void UpdateIndex(bool force) { }

}

