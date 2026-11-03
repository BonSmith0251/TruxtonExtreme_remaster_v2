namespace System;

[IsReadOnly]
[Token(Token = "0x2000163")]
public struct ConsoleKeyInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000549")]
	private readonly char _keyChar; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400054A")]
	private readonly ConsoleKey _key; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400054B")]
	private readonly ConsoleModifiers _mods; //Field offset: 0x8

	[Token(Token = "0x17000104")]
	public ConsoleKey Key
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6000C5B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000103")]
	public char KeyChar
	{
		[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
		[Token(Token = "0x6000C5A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2042550", Offset = "0x2041950", Length = "0xB0")]
	[Token(Token = "0x6000C59")]
	public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	[Address(RVA = "0x2042480", Offset = "0x2041880", Length = "0xA9")]
	[Token(Token = "0x6000C5C")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2042460", Offset = "0x2041860", Length = "0x1D")]
	[Token(Token = "0x6000C5D")]
	public bool Equals(ConsoleKeyInfo obj) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6000C5B")]
	public ConsoleKey get_Key() { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x6000C5A")]
	public char get_KeyChar() { }

	[Address(RVA = "0x2042530", Offset = "0x2041930", Length = "0x12")]
	[Token(Token = "0x6000C5E")]
	public virtual int GetHashCode() { }

}

