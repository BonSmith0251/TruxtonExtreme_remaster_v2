namespace System.Data;

[Token(Token = "0x2000083")]
internal sealed class RelatedView : DataView, IFilter
{
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000298")]
	private readonly Nullable<DataKey> _parentKey; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000299")]
	private readonly DataKey _childKey; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400029A")]
	private readonly DataRowView _parentRowView; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400029B")]
	private readonly Object[] _filterValues; //Field offset: 0xD8

	[Address(RVA = "0x234C040", Offset = "0x234B440", Length = "0x164")]
	[Token(Token = "0x60006D8")]
	public RelatedView(DataColumn[] columns, Object[] values) { }

	[Address(RVA = "0x234C1B0", Offset = "0x234B5B0", Length = "0x14D")]
	[Token(Token = "0x60006D9")]
	public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	[Address(RVA = "0x234BD80", Offset = "0x234B180", Length = "0x6E")]
	[Token(Token = "0x60006DD")]
	public virtual DataRowView AddNew() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60006DC")]
	internal virtual IFilter GetFilter() { }

	[Address(RVA = "0x234BDF0", Offset = "0x234B1F0", Length = "0xA9")]
	[Token(Token = "0x60006DA")]
	private Object[] GetParentValues() { }

	[Address(RVA = "0x234BEA0", Offset = "0x234B2A0", Length = "0x163")]
	[Token(Token = "0x60006DB")]
	public override bool Invoke(DataRow row, DataRowVersion version) { }

	[Address(RVA = "0x234C010", Offset = "0x234B410", Length = "0x2B")]
	[Token(Token = "0x60006DE")]
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

