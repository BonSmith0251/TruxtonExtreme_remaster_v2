namespace System.Collections.Generic;

[IsReadOnly]
[Token(Token = "0x20005FE")]
public struct KeyValuePair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001875")]
	private readonly TKey key; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001876")]
	private readonly TValue value; //Field offset: 0x0

	[Token(Token = "0x17000719")]
	public TKey Key
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6002CA5")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700071A")]
	public TValue Value
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6002CA6")]
		 get { } //Length: 11
	}

	[Address(RVA = "0xAEE620", Offset = "0xAEDA20", Length = "0x3D")]
	[Token(Token = "0x6002CA4")]
	public KeyValuePair`2(TKey key, TValue value) { }

	[Address(RVA = "0xAEBE30", Offset = "0xAEB230", Length = "0x7B")]
	[Token(Token = "0x6002CA8")]
	public void Deconstruct(out TKey key, out TValue value) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6002CA5")]
	public TKey get_Key() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x6002CA6")]
	public TValue get_Value() { }

	[Address(RVA = "0xAEC900", Offset = "0xAEBD00", Length = "0xBE")]
	[Token(Token = "0x6002CA7")]
	public virtual string ToString() { }

}

