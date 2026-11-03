namespace System;

[Token(Token = "0x200017A")]
internal sealed class LocalDataStoreHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000576")]
	private LocalDataStore m_Store; //Field offset: 0x10

	[Token(Token = "0x17000119")]
	public LocalDataStore Store
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D74")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000D72")]
	public LocalDataStoreHolder(LocalDataStore store) { }

	[Address(RVA = "0x206A4E0", Offset = "0x20698E0", Length = "0x79")]
	[Token(Token = "0x6000D73")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D74")]
	public LocalDataStore get_Store() { }

}

