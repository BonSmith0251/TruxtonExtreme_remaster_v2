namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x2000040")]
public sealed class DataRowCollection : InternalDataCollectionBase
{
	[Token(Token = "0x2000041")]
	private sealed class DataRowTree : RBTree<DataRow>
	{

		[Address(RVA = "0x231F840", Offset = "0x231EC40", Length = "0x3E")]
		[Token(Token = "0x6000482")]
		internal DataRowTree() { }

		[Address(RVA = "0x231F7E0", Offset = "0x231EBE0", Length = "0x2C")]
		[Token(Token = "0x6000483")]
		protected virtual int CompareNode(DataRow record1, DataRow record2) { }

		[Address(RVA = "0x231F810", Offset = "0x231EC10", Length = "0x2C")]
		[Token(Token = "0x6000484")]
		protected virtual int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000151")]
	private readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000152")]
	private readonly DataRowTree _list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000153")]
	internal int _nullInList; //Field offset: 0x20

	[Token(Token = "0x170000BD")]
	public virtual int Count
	{
		[Address(RVA = "0x231F730", Offset = "0x231EB30", Length = "0x44")]
		[Token(Token = "0x6000475")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170000BE")]
	public DataRow Item
	{
		[Address(RVA = "0x231F780", Offset = "0x231EB80", Length = "0x51")]
		[Token(Token = "0x6000476")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x231F660", Offset = "0x231EA60", Length = "0xCA")]
	[Token(Token = "0x6000474")]
	internal DataRowCollection(DataTable table) { }

	[Address(RVA = "0x231F050", Offset = "0x231E450", Length = "0x24")]
	[Token(Token = "0x6000477")]
	public void Add(DataRow row) { }

	[Address(RVA = "0x231EFD0", Offset = "0x231E3D0", Length = "0x73")]
	[Token(Token = "0x600047A")]
	internal DataRow AddWithColumnEvents(Object[] values) { }

	[Address(RVA = "0x231F080", Offset = "0x231E480", Length = "0x65")]
	[Token(Token = "0x600047B")]
	internal void ArrayAdd(DataRow row) { }

	[Address(RVA = "0x231F0F0", Offset = "0x231E4F0", Length = "0x44")]
	[Token(Token = "0x600047D")]
	internal void ArrayClear() { }

	[Address(RVA = "0x231F140", Offset = "0x231E540", Length = "0x74")]
	[Token(Token = "0x600047C")]
	internal void ArrayInsert(DataRow row, int pos) { }

	[Address(RVA = "0x231F1C0", Offset = "0x231E5C0", Length = "0x92")]
	[Token(Token = "0x600047E")]
	internal void ArrayRemove(DataRow row) { }

	[Address(RVA = "0x231F2D0", Offset = "0x231E6D0", Length = "0x63")]
	[Token(Token = "0x600047F")]
	public virtual void CopyTo(Array ar, int index) { }

	[Address(RVA = "0x231F260", Offset = "0x231E660", Length = "0x63")]
	[Token(Token = "0x6000480")]
	public void CopyTo(DataRow[] array, int index) { }

	[Address(RVA = "0x231F340", Offset = "0x231E740", Length = "0x236")]
	[Token(Token = "0x6000478")]
	internal void DiffInsertAt(DataRow row, int pos) { }

	[Address(RVA = "0x231F730", Offset = "0x231EB30", Length = "0x44")]
	[Token(Token = "0x6000475")]
	public virtual int get_Count() { }

	[Address(RVA = "0x231F780", Offset = "0x231EB80", Length = "0x51")]
	[Token(Token = "0x6000476")]
	public DataRow get_Item(int index) { }

	[Address(RVA = "0x231F580", Offset = "0x231E980", Length = "0x44")]
	[Token(Token = "0x6000481")]
	public virtual IEnumerator GetEnumerator() { }

	[Address(RVA = "0x231F5D0", Offset = "0x231E9D0", Length = "0x8A")]
	[Token(Token = "0x6000479")]
	public int IndexOf(DataRow row) { }

}

