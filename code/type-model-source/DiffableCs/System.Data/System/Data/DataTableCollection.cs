namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[ListBindable(False)]
[Token(Token = "0x200004B")]
public sealed class DataTableCollection : InternalDataCollectionBase
{
	[Token(Token = "0x4000173")]
	private static int s_objectTypeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016D")]
	private readonly DataSet _dataSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016E")]
	private readonly ArrayList _list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016F")]
	private int _defaultNameIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000170")]
	private DataTable[] _delayedAddRangeTables; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000171")]
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000172")]
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000174")]
	private readonly int _objectID; //Field offset: 0x40

	[Token(Token = "0x170000C5")]
	public DataTable Item
	{
		[Address(RVA = "0x2327A10", Offset = "0x2326E10", Length = "0xD8")]
		[Token(Token = "0x60004AB")]
		 get { } //Length: 216
	}

	[Token(Token = "0x170000C6")]
	public DataTable Item
	{
		[Address(RVA = "0x2327900", Offset = "0x2326D00", Length = "0x105")]
		[Token(Token = "0x60004AC")]
		 get { } //Length: 261
	}

	[Token(Token = "0x170000C7")]
	public DataTable Item
	{
		[Address(RVA = "0x2327AF0", Offset = "0x2326EF0", Length = "0x129")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 297
	}

	[Token(Token = "0x170000C3")]
	protected virtual ArrayList List
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60004A9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C4")]
	internal int ObjectID
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60004AA")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x23277A0", Offset = "0x2326BA0", Length = "0x153")]
	[Token(Token = "0x60004A8")]
	internal DataTableCollection(DataSet dataSet) { }

	[Address(RVA = "0x2325090", Offset = "0x2324490", Length = "0x25E")]
	[Token(Token = "0x60004B0")]
	public void Add(DataTable table) { }

	[Address(RVA = "0x23252F0", Offset = "0x23246F0", Length = "0x2A")]
	[Token(Token = "0x60004B1")]
	private void ArrayAdd(DataTable table) { }

	[Address(RVA = "0x2325320", Offset = "0x2324720", Length = "0xC6")]
	[Token(Token = "0x60004B2")]
	internal string AssignName() { }

	[Address(RVA = "0x23253F0", Offset = "0x23247F0", Length = "0x249")]
	[Token(Token = "0x60004B3")]
	private void BaseAdd(DataTable table) { }

	[Address(RVA = "0x2325640", Offset = "0x2324A40", Length = "0x1BF")]
	[Token(Token = "0x60004B4")]
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	[Address(RVA = "0x2325800", Offset = "0x2324C00", Length = "0x17E")]
	[Token(Token = "0x60004B5")]
	private void BaseRemove(DataTable table) { }

	[Address(RVA = "0x2325980", Offset = "0x2324D80", Length = "0x71D")]
	[Token(Token = "0x60004B6")]
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	[Address(RVA = "0x23260A0", Offset = "0x23254A0", Length = "0x2F0")]
	[Token(Token = "0x60004B7")]
	public void Clear() { }

	[Address(RVA = "0x2326510", Offset = "0x2325910", Length = "0x16")]
	[Token(Token = "0x60004B8")]
	public bool Contains(string name) { }

	[Address(RVA = "0x2326530", Offset = "0x2325930", Length = "0x1AF")]
	[Token(Token = "0x60004B9")]
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	[Address(RVA = "0x23263A0", Offset = "0x23257A0", Length = "0x161")]
	[Token(Token = "0x60004BA")]
	internal bool Contains(string name, bool caseSensitive) { }

	[Address(RVA = "0x2327AF0", Offset = "0x2326EF0", Length = "0x129")]
	[Token(Token = "0x60004AD")]
	public DataTable get_Item(string name, string tableNamespace) { }

	[Address(RVA = "0x2327900", Offset = "0x2326D00", Length = "0x105")]
	[Token(Token = "0x60004AC")]
	public DataTable get_Item(string name) { }

	[Address(RVA = "0x2327A10", Offset = "0x2326E10", Length = "0xD8")]
	[Token(Token = "0x60004AB")]
	public DataTable get_Item(int index) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60004A9")]
	protected virtual ArrayList get_List() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60004AA")]
	internal int get_ObjectID() { }

	[Address(RVA = "0x2326840", Offset = "0x2325C40", Length = "0x138")]
	[Token(Token = "0x60004AE")]
	internal DataTable GetTable(string name, string ns) { }

	[Address(RVA = "0x23266E0", Offset = "0x2325AE0", Length = "0x15B")]
	[Token(Token = "0x60004AF")]
	internal DataTable GetTableSmart(string name, string ns) { }

	[Address(RVA = "0x23269A0", Offset = "0x2325DA0", Length = "0x8E")]
	[Token(Token = "0x60004BD")]
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	[Address(RVA = "0x2326A30", Offset = "0x2325E30", Length = "0xE8")]
	[Token(Token = "0x60004BB")]
	public int IndexOf(DataTable table) { }

	[Address(RVA = "0x2326980", Offset = "0x2325D80", Length = "0x1B")]
	[Token(Token = "0x60004BC")]
	public int IndexOf(string tableName) { }

	[Address(RVA = "0x2326B20", Offset = "0x2325F20", Length = "0x289")]
	[Token(Token = "0x60004BF")]
	internal int InternalIndexOf(string tableName) { }

	[Address(RVA = "0x2326DB0", Offset = "0x23261B0", Length = "0x207")]
	[Token(Token = "0x60004C0")]
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	[Address(RVA = "0x2326FC0", Offset = "0x23263C0", Length = "0x94")]
	[Token(Token = "0x60004C1")]
	private string MakeName(int index) { }

	[Address(RVA = "0x2327060", Offset = "0x2326460", Length = "0xBD")]
	[Token(Token = "0x60004C2")]
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x2327120", Offset = "0x2326520", Length = "0xBD")]
	[Token(Token = "0x60004C3")]
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	[Address(RVA = "0x23271E0", Offset = "0x23265E0", Length = "0x288")]
	[Token(Token = "0x60004C4")]
	internal void RegisterName(string name, string tbNamespace) { }

	[Address(RVA = "0x2327470", Offset = "0x2326870", Length = "0x1B3")]
	[Token(Token = "0x60004C5")]
	public void Remove(DataTable table) { }

	[Address(RVA = "0x2327630", Offset = "0x2326A30", Length = "0x5B")]
	[Token(Token = "0x60004BE")]
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	[Address(RVA = "0x2327690", Offset = "0x2326A90", Length = "0x10A")]
	[Token(Token = "0x60004C6")]
	internal void UnregisterName(string name) { }

}

