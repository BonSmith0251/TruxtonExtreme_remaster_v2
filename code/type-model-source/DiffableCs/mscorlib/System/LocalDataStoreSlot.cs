namespace System;

[ComVisible(True)]
[Token(Token = "0x200017D")]
public sealed class LocalDataStoreSlot
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057B")]
	private LocalDataStoreMgr m_mgr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057C")]
	private int m_slot; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057D")]
	private long m_cookie; //Field offset: 0x20

	[Token(Token = "0x1700011E")]
	internal long Cookie
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D82")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011C")]
	internal LocalDataStoreMgr Manager
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D80")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011D")]
	internal int Slot
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000D81")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x206B120", Offset = "0x206A520", Length = "0x53")]
	[Token(Token = "0x6000D7F")]
	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) { }

	[Address(RVA = "0x206B090", Offset = "0x206A490", Length = "0x80")]
	[Token(Token = "0x6000D83")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D82")]
	internal long get_Cookie() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D80")]
	internal LocalDataStoreMgr get_Manager() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000D81")]
	internal int get_Slot() { }

}

