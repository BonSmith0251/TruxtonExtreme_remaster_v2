namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001B5")]
internal sealed class LocalVariable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000377")]
	public readonly int Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000378")]
	private int _flags; //Field offset: 0x14

	[Token(Token = "0x170001F5")]
	public bool InClosure
	{
		[Address(RVA = "0x229DE80", Offset = "0x229D280", Length = "0x8")]
		[Token(Token = "0x600097E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F4")]
	public bool IsBoxed
	{
		[Address(RVA = "0x229DE90", Offset = "0x229D290", Length = "0x7")]
		[Token(Token = "0x600097C")]
		 get { } //Length: 7
		[Address(RVA = "0x229DEA0", Offset = "0x229D2A0", Length = "0x19")]
		[Token(Token = "0x600097D")]
		 set { } //Length: 25
	}

	[Address(RVA = "0x229DE40", Offset = "0x229D240", Length = "0x39")]
	[Token(Token = "0x600097F")]
	internal LocalVariable(int index, bool closure) { }

	[Address(RVA = "0x229DE80", Offset = "0x229D280", Length = "0x8")]
	[Token(Token = "0x600097E")]
	public bool get_InClosure() { }

	[Address(RVA = "0x229DE90", Offset = "0x229D290", Length = "0x7")]
	[Token(Token = "0x600097C")]
	public bool get_IsBoxed() { }

	[Address(RVA = "0x229DEA0", Offset = "0x229D2A0", Length = "0x19")]
	[Token(Token = "0x600097D")]
	public void set_IsBoxed(bool value) { }

	[Address(RVA = "0x229DD60", Offset = "0x229D160", Length = "0xD2")]
	[Token(Token = "0x6000980")]
	public virtual string ToString() { }

}

