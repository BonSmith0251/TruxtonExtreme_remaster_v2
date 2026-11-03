namespace System;

[Token(Token = "0x20001A5")]
public struct ArgIterator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D5")]
	private IntPtr sig; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006D6")]
	private IntPtr args; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D7")]
	private int next_arg; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006D8")]
	private int num_args; //Field offset: 0x14

	[Address(RVA = "0x207AC60", Offset = "0x207A060", Length = "0x4E")]
	[Token(Token = "0x6000F62")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000F63")]
	public virtual int GetHashCode() { }

}

