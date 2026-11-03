namespace System;

[Token(Token = "0x200017B")]
internal sealed class LocalDataStoreElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000577")]
	private object m_value; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000578")]
	private long m_cookie; //Field offset: 0x18

	[Token(Token = "0x1700011B")]
	public long Cookie
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D78")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011A")]
	public object Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D76")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000D77")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x206A4B0", Offset = "0x20698B0", Length = "0x26")]
	[Token(Token = "0x6000D75")]
	public LocalDataStoreElement(long cookie) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D78")]
	public long get_Cookie() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D76")]
	public object get_Value() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000D77")]
	public void set_Value(object value) { }

}

