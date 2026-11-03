namespace System.Threading;

[Token(Token = "0x2000215")]
public class Lock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CC")]
	private object _lock; //Field offset: 0x10

	[Address(RVA = "0x209FE10", Offset = "0x209F210", Length = "0x66")]
	[Token(Token = "0x600120F")]
	public Lock() { }

	[Address(RVA = "0x209FDF0", Offset = "0x209F1F0", Length = "0x9")]
	[Token(Token = "0x600120D")]
	public void Acquire() { }

	[Address(RVA = "0x209FE00", Offset = "0x209F200", Length = "0x9")]
	[Token(Token = "0x600120E")]
	public void Release() { }

}

