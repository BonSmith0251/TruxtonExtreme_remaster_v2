namespace System.Collections;

[Token(Token = "0x20005A0")]
public struct DictionaryEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017A3")]
	private object _key; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40017A4")]
	private object _value; //Field offset: 0x8

	[Token(Token = "0x1700060E")]
	public object Key
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6002938")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700060F")]
	public object Value
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6002939")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x6002937")]
	public DictionaryEntry(object key, object value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002938")]
	public object get_Key() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6002939")]
	public object get_Value() { }

}

