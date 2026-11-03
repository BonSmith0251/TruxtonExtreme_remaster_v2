namespace System;

[Token(Token = "0x200017C")]
internal sealed class LocalDataStore
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000579")]
	private LocalDataStoreElement[] m_DataTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057A")]
	private LocalDataStoreMgr m_Manager; //Field offset: 0x18

	[Address(RVA = "0x206B720", Offset = "0x206AB20", Length = "0x7B")]
	[Token(Token = "0x6000D79")]
	public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) { }

	[Address(RVA = "0x206B180", Offset = "0x206A580", Length = "0x24")]
	[Token(Token = "0x6000D7A")]
	internal void Dispose() { }

	[Address(RVA = "0x206B1B0", Offset = "0x206A5B0", Length = "0x5C")]
	[Token(Token = "0x6000D7D")]
	internal void FreeData(int slot, long cookie) { }

	[Address(RVA = "0x206B210", Offset = "0x206A610", Length = "0x126")]
	[Token(Token = "0x6000D7B")]
	public object GetData(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x206B340", Offset = "0x206A740", Length = "0x291")]
	[Token(Token = "0x6000D7E")]
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x206B5E0", Offset = "0x206A9E0", Length = "0x139")]
	[Token(Token = "0x6000D7C")]
	public void SetData(LocalDataStoreSlot slot, object data) { }

}

