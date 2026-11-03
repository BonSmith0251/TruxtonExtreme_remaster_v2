namespace System.Data;

[Token(Token = "0x2000056")]
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A5")]
	private DataViewManager _dataViewManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A6")]
	private DataTable _table; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A7")]
	private string _sort; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A8")]
	private string _rowFilter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001A9")]
	private DataViewRowState _rowStateFilter; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001AA")]
	private bool _applyDefaultSort; //Field offset: 0x34

	[Token(Token = "0x170000E8")]
	public bool ApplyDefaultSort
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x600053E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E9")]
	public string RowFilter
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000541")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000EA")]
	public DataViewRowState RowStateFilter
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000542")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000EB")]
	public string Sort
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000543")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2335070", Offset = "0x2334470", Length = "0x5B")]
	[Token(Token = "0x600053D")]
	internal DataViewSetting() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x600053E")]
	public bool get_ApplyDefaultSort() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000541")]
	public string get_RowFilter() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000542")]
	public DataViewRowState get_RowStateFilter() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000543")]
	public string get_Sort() { }

	[Address(RVA = "0x2335050", Offset = "0x2334450", Length = "0x14")]
	[Token(Token = "0x6000540")]
	internal void SetDataTable(DataTable table) { }

	[Address(RVA = "0x231D3F0", Offset = "0x231C7F0", Length = "0x14")]
	[Token(Token = "0x600053F")]
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

}

