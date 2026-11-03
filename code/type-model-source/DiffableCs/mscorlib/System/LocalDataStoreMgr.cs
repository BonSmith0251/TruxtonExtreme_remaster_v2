namespace System;

[Token(Token = "0x200017E")]
internal sealed class LocalDataStoreMgr
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057E")]
	private Boolean[] m_SlotInfoTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057F")]
	private int m_FirstAvailableSlot; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000580")]
	private List<LocalDataStore> m_ManagedLocalDataStores; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000581")]
	private Dictionary<String, LocalDataStoreSlot> m_KeyToSlotMap; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000582")]
	private long m_CookieGenerator; //Field offset: 0x30

	[Address(RVA = "0x206AFA0", Offset = "0x206A3A0", Length = "0xEA")]
	[Token(Token = "0x6000D8D")]
	public LocalDataStoreMgr() { }

	[Address(RVA = "0x206A560", Offset = "0x2069960", Length = "0x25F")]
	[Token(Token = "0x6000D86")]
	public LocalDataStoreSlot AllocateDataSlot() { }

	[Address(RVA = "0x206A7C0", Offset = "0x2069BC0", Length = "0xEF")]
	[Token(Token = "0x6000D87")]
	public LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	[Address(RVA = "0x206A8B0", Offset = "0x2069CB0", Length = "0x1F7")]
	[Token(Token = "0x6000D84")]
	public LocalDataStoreHolder CreateLocalDataStore() { }

	[Address(RVA = "0x206AAB0", Offset = "0x2069EB0", Length = "0xC5")]
	[Token(Token = "0x6000D85")]
	public void DeleteLocalDataStore(LocalDataStore store) { }

	[Address(RVA = "0x206AB80", Offset = "0x2069F80", Length = "0x1BA")]
	[Token(Token = "0x6000D8A")]
	internal void FreeDataSlot(int slot, long cookie) { }

	[Address(RVA = "0x206AD40", Offset = "0x206A140", Length = "0xC5")]
	[Token(Token = "0x6000D89")]
	public void FreeNamedDataSlot(string name) { }

	[Address(RVA = "0x206AE10", Offset = "0x206A210", Length = "0x107")]
	[Token(Token = "0x6000D88")]
	public LocalDataStoreSlot GetNamedDataSlot(string name) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000D8C")]
	internal int GetSlotTableLength() { }

	[Address(RVA = "0x206AF20", Offset = "0x206A320", Length = "0x7D")]
	[Token(Token = "0x6000D8B")]
	public void ValidateSlot(LocalDataStoreSlot slot) { }

}

