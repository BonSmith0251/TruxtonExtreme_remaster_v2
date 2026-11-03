namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x2000082")]
internal sealed class RecordManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000292")]
	private readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000293")]
	private int _lastFreeRecord; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000294")]
	private int _minimumCapacity; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000295")]
	private int _recordCapacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000296")]
	private readonly List<Int32> _freeRecordList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000297")]
	private DataRow[] _rows; //Field offset: 0x30

	[Token(Token = "0x1700010D")]
	internal DataRow Item
	{
		[Address(RVA = "0x1D57810", Offset = "0x1D56C10", Length = "0x2B")]
		[Token(Token = "0x60006D3")]
		internal get { } //Length: 43
		[Address(RVA = "0x234BC10", Offset = "0x234B010", Length = "0x7B")]
		[Token(Token = "0x60006D4")]
		internal set { } //Length: 123
	}

	[Token(Token = "0x1700010A")]
	internal int LastFreeRecord
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60006C9")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700010B")]
	internal int MinimumCapacity
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60006CA")]
		internal get { } //Length: 4
		[Address(RVA = "0x234BC90", Offset = "0x234B090", Length = "0x40")]
		[Token(Token = "0x60006CB")]
		internal set { } //Length: 64
	}

	[Token(Token = "0x1700010C")]
	internal int RecordCapacity
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60006CC")]
		internal get { } //Length: 4
		[Address(RVA = "0x234BCD0", Offset = "0x234B0D0", Length = "0xAA")]
		[Token(Token = "0x60006CD")]
		internal set { } //Length: 170
	}

	[Address(RVA = "0x234BB30", Offset = "0x234AF30", Length = "0xD0")]
	[Token(Token = "0x60006C7")]
	internal RecordManager(DataTable table) { }

	[Address(RVA = "0x234B1F0", Offset = "0x234A5F0", Length = "0x20A")]
	[Token(Token = "0x60006D2")]
	internal void Clear(bool clearAll) { }

	[Address(RVA = "0x234B400", Offset = "0x234A800", Length = "0x233")]
	[Token(Token = "0x60006D6")]
	internal int CopyRecord(DataTable src, int record, int copy) { }

	[Address(RVA = "0x234B640", Offset = "0x234AA40", Length = "0x16C")]
	[Token(Token = "0x60006D1")]
	internal void FreeRecord(ref int record) { }

	[Address(RVA = "0x1D57810", Offset = "0x1D56C10", Length = "0x2B")]
	[Token(Token = "0x60006D3")]
	internal DataRow get_Item(int record) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60006C9")]
	internal int get_LastFreeRecord() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60006CA")]
	internal int get_MinimumCapacity() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60006CC")]
	internal int get_RecordCapacity() { }

	[Address(RVA = "0x234B7B0", Offset = "0x234ABB0", Length = "0x1FF")]
	[Token(Token = "0x60006C8")]
	private void GrowRecordCapacity() { }

	[Address(RVA = "0x234B9B0", Offset = "0x234ADB0", Length = "0x1D")]
	[Token(Token = "0x60006D5")]
	internal int ImportRecord(DataTable src, int record) { }

	[Address(RVA = "0x234B9D0", Offset = "0x234ADD0", Length = "0xE")]
	[Token(Token = "0x60006CE")]
	internal static int NewCapacity(int capacity) { }

	[Address(RVA = "0x234B9E0", Offset = "0x234ADE0", Length = "0xC1")]
	[Token(Token = "0x60006D0")]
	internal int NewRecordBase() { }

	[Address(RVA = "0x234BAB0", Offset = "0x234AEB0", Length = "0x35")]
	[Token(Token = "0x60006CF")]
	private int NormalizedMinimumCapacity(int capacity) { }

	[Address(RVA = "0x234BC10", Offset = "0x234B010", Length = "0x7B")]
	[Token(Token = "0x60006D4")]
	internal void set_Item(int record, DataRow value) { }

	[Address(RVA = "0x234BC90", Offset = "0x234B090", Length = "0x40")]
	[Token(Token = "0x60006CB")]
	internal void set_MinimumCapacity(int value) { }

	[Address(RVA = "0x234BCD0", Offset = "0x234B0D0", Length = "0xAA")]
	[Token(Token = "0x60006CD")]
	internal void set_RecordCapacity(int value) { }

	[Address(RVA = "0x234BAF0", Offset = "0x234AEF0", Length = "0x33")]
	[Token(Token = "0x60006D7")]
	internal void SetRowCache(DataRow[] newRows) { }

}

