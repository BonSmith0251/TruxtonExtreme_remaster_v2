namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[Token(Token = "0x2000031")]
public sealed class DataColumnCollection : InternalDataCollectionBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000100")]
	private readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000101")]
	private readonly ArrayList _list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000102")]
	private int _defaultNameIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000103")]
	private DataColumn[] _delayedAddRangeColumns; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000104")]
	private readonly Dictionary<String, DataColumn> _columnFromName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000105")]
	private bool _fInClear; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000106")]
	private DataColumn[] _columnsImplementingIChangeTracking; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000107")]
	private int _nColumnsImplementingIChangeTracking; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000108")]
	private int _nColumnsImplementingIRevertibleChangeTracking; //Field offset: 0x4C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000109")]
	private CollectionChangeEventHandler CollectionChanged; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400010A")]
	private CollectionChangeEventHandler CollectionChanging; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400010B")]
	private CollectionChangeEventHandler ColumnPropertyChanged; //Field offset: 0x60

	[Token(Token = "0x14000001")]
	public event CollectionChangeEventHandler CollectionChanged
	{
		[Address(RVA = "0x2317AD0", Offset = "0x2316ED0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000387")]
		 add { } //Length: 158
		[Address(RVA = "0x2317F10", Offset = "0x2317310", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000388")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	internal event CollectionChangeEventHandler ColumnPropertyChanged
	{
		[Address(RVA = "0x2317B70", Offset = "0x2316F70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000389")]
		internal add { } //Length: 158
		[Address(RVA = "0x2317FB0", Offset = "0x23173B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600038A")]
		internal remove { } //Length: 158
	}

	[Token(Token = "0x17000082")]
	internal DataColumn[] ColumnsImplementingIChangeTracking
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600037F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000083")]
	internal int ColumnsImplementingIChangeTrackingCount
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x6000380")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000084")]
	internal int ColumnsImplementingIRevertibleChangeTrackingCount
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x6000381")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000085")]
	public DataColumn Item
	{
		[Address(RVA = "0x2317CC0", Offset = "0x23170C0", Length = "0xD8")]
		[Token(Token = "0x6000382")]
		 get { } //Length: 216
	}

	[Token(Token = "0x17000086")]
	public DataColumn Item
	{
		[Address(RVA = "0x2317DA0", Offset = "0x23171A0", Length = "0x16B")]
		[Token(Token = "0x6000383")]
		 get { } //Length: 363
	}

	[Token(Token = "0x17000087")]
	internal DataColumn Item
	{
		[Address(RVA = "0x2317C10", Offset = "0x2317010", Length = "0xAD")]
		[Token(Token = "0x6000384")]
		internal get { } //Length: 173
	}

	[Token(Token = "0x17000081")]
	protected virtual ArrayList List
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600037E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x23179B0", Offset = "0x2316DB0", Length = "0x119")]
	[Token(Token = "0x600037D")]
	internal DataColumnCollection(DataTable table) { }

	[Address(RVA = "0x23154F0", Offset = "0x23148F0", Length = "0x10")]
	[Token(Token = "0x6000385")]
	public void Add(DataColumn column) { }

	[Address(RVA = "0x2317AD0", Offset = "0x2316ED0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000387")]
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x2317B70", Offset = "0x2316F70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000389")]
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x23150C0", Offset = "0x23144C0", Length = "0x330")]
	[Token(Token = "0x6000386")]
	internal void AddAt(int index, DataColumn column) { }

	[Address(RVA = "0x2315400", Offset = "0x2314800", Length = "0xE3")]
	[Token(Token = "0x60003A1")]
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	[Address(RVA = "0x2315500", Offset = "0x2314900", Length = "0x69")]
	[Token(Token = "0x600038C")]
	private void ArrayAdd(int index, DataColumn column) { }

	[Address(RVA = "0x2315570", Offset = "0x2314970", Length = "0x93")]
	[Token(Token = "0x600038B")]
	private void ArrayAdd(DataColumn column) { }

	[Address(RVA = "0x2315610", Offset = "0x2314A10", Length = "0x269")]
	[Token(Token = "0x600038D")]
	private void ArrayRemove(DataColumn column) { }

	[Address(RVA = "0x2315880", Offset = "0x2314C80", Length = "0x11C")]
	[Token(Token = "0x600038E")]
	internal string AssignName() { }

	[Address(RVA = "0x23159A0", Offset = "0x2314DA0", Length = "0x37B")]
	[Token(Token = "0x600038F")]
	private void BaseAdd(DataColumn column) { }

	[Address(RVA = "0x2315D20", Offset = "0x2315120", Length = "0x227")]
	[Token(Token = "0x6000390")]
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	[Address(RVA = "0x2315F50", Offset = "0x2315350", Length = "0x20C")]
	[Token(Token = "0x6000391")]
	private void BaseRemove(DataColumn column) { }

	[Address(RVA = "0x2316160", Offset = "0x2315560", Length = "0x56")]
	[Token(Token = "0x600039E")]
	internal bool CanRegisterName(string name) { }

	[Address(RVA = "0x23161C0", Offset = "0x23155C0", Length = "0x941")]
	[Token(Token = "0x6000392")]
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	[Address(RVA = "0x2316B10", Offset = "0x2315F10", Length = "0x46")]
	[Token(Token = "0x6000393")]
	private void CheckIChangeTracking(DataColumn column) { }

	[Address(RVA = "0x2316B60", Offset = "0x2315F60", Length = "0x35B")]
	[Token(Token = "0x6000394")]
	public void Clear() { }

	[Address(RVA = "0x2316F80", Offset = "0x2316380", Length = "0x8E")]
	[Token(Token = "0x6000395")]
	public bool Contains(string name) { }

	[Address(RVA = "0x2316EC0", Offset = "0x23162C0", Length = "0xB8")]
	[Token(Token = "0x6000396")]
	internal bool Contains(string name, bool caseSensitive) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600037F")]
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x6000380")]
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x6000381")]
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	[Address(RVA = "0x2317DA0", Offset = "0x23171A0", Length = "0x16B")]
	[Token(Token = "0x6000383")]
	public DataColumn get_Item(string name) { }

	[Address(RVA = "0x2317CC0", Offset = "0x23170C0", Length = "0xD8")]
	[Token(Token = "0x6000382")]
	public DataColumn get_Item(int index) { }

	[Address(RVA = "0x2317C10", Offset = "0x2317010", Length = "0xAD")]
	[Token(Token = "0x6000384")]
	internal DataColumn get_Item(string name, string ns) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600037E")]
	protected virtual ArrayList get_List() { }

	[Address(RVA = "0x23171B0", Offset = "0x23165B0", Length = "0x10B")]
	[Token(Token = "0x6000397")]
	public int IndexOf(string columnName) { }

	[Address(RVA = "0x2317010", Offset = "0x2316410", Length = "0x192")]
	[Token(Token = "0x6000398")]
	internal int IndexOfCaseInsensitive(string name) { }

	[Address(RVA = "0x23172C0", Offset = "0x23166C0", Length = "0x94")]
	[Token(Token = "0x6000399")]
	private string MakeName(int index) { }

	[Address(RVA = "0x2317360", Offset = "0x2316760", Length = "0x9F")]
	[Token(Token = "0x600039A")]
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x2317400", Offset = "0x2316800", Length = "0x1F")]
	[Token(Token = "0x600039B")]
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x2317420", Offset = "0x2316820", Length = "0x4D")]
	[Token(Token = "0x600039C")]
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x2317470", Offset = "0x2316870", Length = "0x19D")]
	[Token(Token = "0x600039D")]
	internal void RegisterColumnName(string name, DataColumn column) { }

	[Address(RVA = "0x2317770", Offset = "0x2316B70", Length = "0x108")]
	[Token(Token = "0x600039F")]
	public void Remove(DataColumn column) { }

	[Address(RVA = "0x2317F10", Offset = "0x2317310", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000388")]
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x2317FB0", Offset = "0x23173B0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600038A")]
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[Address(RVA = "0x2317610", Offset = "0x2316A10", Length = "0x15C")]
	[Token(Token = "0x60003A2")]
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	[Address(RVA = "0x2317880", Offset = "0x2316C80", Length = "0x124")]
	[Token(Token = "0x60003A0")]
	internal void UnregisterName(string name) { }

}

