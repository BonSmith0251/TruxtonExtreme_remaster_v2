namespace System;

[NonVersionable]
[Token(Token = "0x200011A")]
public struct Nullable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000412")]
	private readonly bool hasValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000413")]
	internal T value; //Field offset: 0x0

	[Token(Token = "0x1700008E")]
	public bool HasValue
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[NonVersionable]
		[Token(Token = "0x60008D9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700008F")]
	public T Value
	{
		[Address(RVA = "0xDA8D60", Offset = "0xDA8160", Length = "0x31")]
		[Token(Token = "0x60008DA")]
		 get { } //Length: 49
	}

	[Address(RVA = "0xDA8A30", Offset = "0xDA7E30", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x60008D8")]
	public Nullable`1(T value) { }

	[Address(RVA = "0xD9C080", Offset = "0xD9B480", Length = "0x5E")]
	[Token(Token = "0x60008E0")]
	private static object Box(Nullable<T> o) { }

	[Address(RVA = "0xD9D590", Offset = "0xD9C990", Length = "0x6E")]
	[Token(Token = "0x60008DD")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[NonVersionable]
	[Token(Token = "0x60008D9")]
	public bool get_HasValue() { }

	[Address(RVA = "0xDA8D60", Offset = "0xDA8160", Length = "0x31")]
	[Token(Token = "0x60008DA")]
	public T get_Value() { }

	[Address(RVA = "0xD9FC00", Offset = "0xD9F000", Length = "0x44")]
	[Token(Token = "0x60008DE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x60008DB")]
	public T GetValueOrDefault() { }

	[Address(RVA = "0xDA0A30", Offset = "0xD9FE30", Length = "0x18")]
	[NonVersionable]
	[Token(Token = "0x60008DC")]
	public T GetValueOrDefault(T defaultValue) { }

	[Address(RVA = "0xDA2050", Offset = "0xDA1450", Length = "0xA1")]
	[Token(Token = "0x60008DF")]
	public virtual string ToString() { }

	[Address(RVA = "0xDA6C30", Offset = "0xDA6030", Length = "0xE1")]
	[Token(Token = "0x60008E1")]
	private static Nullable<T> Unbox(object o) { }

	[Address(RVA = "0xDA44B0", Offset = "0xDA38B0", Length = "0x187")]
	[Token(Token = "0x60008E2")]
	private static Nullable<T> UnboxExact(object o) { }

}

