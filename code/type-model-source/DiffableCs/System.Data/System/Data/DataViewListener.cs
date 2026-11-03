namespace System.Data;

[Token(Token = "0x2000052")]
internal sealed class DataViewListener
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000194")]
	private readonly WeakReference _dvWeak; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000195")]
	private DataTable _table; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000196")]
	private Index _index; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000197")]
	internal readonly int _objectID; //Field offset: 0x28

	[Address(RVA = "0x2334C20", Offset = "0x2334020", Length = "0x8A")]
	[Token(Token = "0x600052D")]
	internal DataViewListener(DataView dv) { }

	[Address(RVA = "0x2333E40", Offset = "0x2333240", Length = "0xD9")]
	[Token(Token = "0x600052E")]
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2333F20", Offset = "0x2333320", Length = "0x20")]
	[Token(Token = "0x6000538")]
	private void CleanUp(bool updateListeners) { }

	[Address(RVA = "0x2333F40", Offset = "0x2333340", Length = "0xE2")]
	[Token(Token = "0x6000530")]
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2334030", Offset = "0x2333430", Length = "0x17C")]
	[Token(Token = "0x6000532")]
	internal void IndexListChanged(ListChangedEventArgs e) { }

	[Address(RVA = "0x23341B0", Offset = "0x23335B0", Length = "0xE3")]
	[Token(Token = "0x6000531")]
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	[Address(RVA = "0x23342A0", Offset = "0x23336A0", Length = "0xD9")]
	[Token(Token = "0x600052F")]
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	[Address(RVA = "0x2334380", Offset = "0x2333780", Length = "0xC8")]
	[Token(Token = "0x6000536")]
	internal void RegisterListChangedEvent(Index index) { }

	[Address(RVA = "0x2334450", Offset = "0x2333850", Length = "0x1F2")]
	[Token(Token = "0x6000539")]
	private void RegisterListener(DataTable table) { }

	[Address(RVA = "0x2334650", Offset = "0x2333A50", Length = "0x211")]
	[Token(Token = "0x6000533")]
	internal void RegisterMetaDataEvents(DataTable table) { }

	[Address(RVA = "0x2334870", Offset = "0x2333C70", Length = "0xDE")]
	[Token(Token = "0x6000537")]
	internal void UnregisterListChangedEvent() { }

	[Address(RVA = "0x2334C10", Offset = "0x2334010", Length = "0xA")]
	[Token(Token = "0x6000534")]
	internal void UnregisterMetaDataEvents() { }

	[Address(RVA = "0x2334950", Offset = "0x2333D50", Length = "0x2BC")]
	[Token(Token = "0x6000535")]
	private void UnregisterMetaDataEvents(bool updateListeners) { }

}

