namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E9")]
internal class MethodInfoCallInstruction : CallInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000218")]
	protected readonly MethodInfo _target; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000219")]
	protected readonly int _argumentCount; //Field offset: 0x18

	[Token(Token = "0x17000156")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60005D7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000157")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2254810", Offset = "0x2253C10", Length = "0x7F")]
		[Token(Token = "0x60005D9")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x60005D8")]
	internal MethodInfoCallInstruction(MethodInfo target, int argumentCount) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60005D7")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2254810", Offset = "0x2253C10", Length = "0x7F")]
	[Token(Token = "0x60005D9")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22678B0", Offset = "0x2266CB0", Length = "0x195")]
	[Token(Token = "0x60005DB")]
	protected Object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	[Address(RVA = "0x2267A50", Offset = "0x2266E50", Length = "0x2A0")]
	[Token(Token = "0x60005DA")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x2267D00", Offset = "0x2267100", Length = "0x72")]
	[Token(Token = "0x60005DC")]
	public virtual string ToString() { }

}

