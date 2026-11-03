namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x2000057")]
public class DataViewSettingCollection
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001AB")]
	private readonly DataViewManager _dataViewManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AC")]
	private readonly Hashtable _list; //Field offset: 0x18

	[Token(Token = "0x170000EC")]
	public override DataViewSetting Item
	{
		[Address(RVA = "0x2334E20", Offset = "0x2334220", Length = "0x161")]
		[Token(Token = "0x6000544")]
		 get { } //Length: 353
		[Address(RVA = "0x2334F90", Offset = "0x2334390", Length = "0xBB")]
		[Token(Token = "0x6000545")]
		 set { } //Length: 187
	}

	[Address(RVA = "0x2334E20", Offset = "0x2334220", Length = "0x161")]
	[Token(Token = "0x6000544")]
	public override DataViewSetting get_Item(DataTable table) { }

	[Address(RVA = "0x2334DF0", Offset = "0x23341F0", Length = "0x2A")]
	[Token(Token = "0x6000546")]
	internal void Remove(DataTable table) { }

	[Address(RVA = "0x2334F90", Offset = "0x2334390", Length = "0xBB")]
	[Token(Token = "0x6000545")]
	public override void set_Item(DataTable table, DataViewSetting value) { }

}

