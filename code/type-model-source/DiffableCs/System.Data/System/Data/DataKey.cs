namespace System.Data;

[IsReadOnly]
[Token(Token = "0x2000035")]
internal struct DataKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000112")]
	private readonly DataColumn[] _columns; //Field offset: 0x0

	[Token(Token = "0x1700008F")]
	internal DataColumn[] ColumnsReference
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60003BD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000090")]
	internal bool HasValue
	{
		[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
		[Token(Token = "0x60003BE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000091")]
	internal DataTable Table
	{
		[Address(RVA = "0x2319D40", Offset = "0x2319140", Length = "0x2F")]
		[Token(Token = "0x60003BF")]
		internal get { } //Length: 47
	}

	[Address(RVA = "0x2319A70", Offset = "0x2318E70", Length = "0x2C6")]
	[Token(Token = "0x60003BC")]
	internal DataKey(DataColumn[] columns, bool copyColumns) { }

	[Address(RVA = "0x2319040", Offset = "0x2318440", Length = "0xFC")]
	[Token(Token = "0x60003C0")]
	internal void CheckState() { }

	[Address(RVA = "0x2319200", Offset = "0x2318600", Length = "0xBE")]
	[Token(Token = "0x60003C1")]
	internal bool ColumnsEqual(DataKey key) { }

	[Address(RVA = "0x2319140", Offset = "0x2318540", Length = "0xBE")]
	[Token(Token = "0x60003C2")]
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	[Address(RVA = "0x23192C0", Offset = "0x23186C0", Length = "0x55")]
	[Token(Token = "0x60003C3")]
	internal bool ContainsColumn(DataColumn column) { }

	[Address(RVA = "0x23193E0", Offset = "0x23187E0", Length = "0x73")]
	[Token(Token = "0x60003C5")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2319320", Offset = "0x2318720", Length = "0xB4")]
	[Token(Token = "0x60003C6")]
	internal bool Equals(DataKey value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60003BD")]
	internal DataColumn[] get_ColumnsReference() { }

	[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
	[Token(Token = "0x60003BE")]
	internal bool get_HasValue() { }

	[Address(RVA = "0x2319D40", Offset = "0x2319140", Length = "0x2F")]
	[Token(Token = "0x60003BF")]
	internal DataTable get_Table() { }

	[Address(RVA = "0x2319460", Offset = "0x2318860", Length = "0xD9")]
	[Token(Token = "0x60003C7")]
	internal String[] GetColumnNames() { }

	[Address(RVA = "0x2319540", Offset = "0x2318940", Length = "0x4E")]
	[Token(Token = "0x60003C4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2319590", Offset = "0x2318990", Length = "0x113")]
	[Token(Token = "0x60003C8")]
	internal IndexField[] GetIndexDesc() { }

	[Address(RVA = "0x23196B0", Offset = "0x2318AB0", Length = "0x127")]
	[Token(Token = "0x60003C9")]
	internal Object[] GetKeyValues(int record) { }

	[Address(RVA = "0x2319850", Offset = "0x2318C50", Length = "0x5B")]
	[Token(Token = "0x60003CA")]
	internal Index GetSortIndex() { }

	[Address(RVA = "0x23197E0", Offset = "0x2318BE0", Length = "0x63")]
	[Token(Token = "0x60003CB")]
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	[Address(RVA = "0x23198B0", Offset = "0x2318CB0", Length = "0xA2")]
	[Token(Token = "0x60003CC")]
	internal bool RecordsEqual(int record1, int record2) { }

	[Address(RVA = "0x2319960", Offset = "0x2318D60", Length = "0x10F")]
	[Token(Token = "0x60003CD")]
	internal DataColumn[] ToArray() { }

}

