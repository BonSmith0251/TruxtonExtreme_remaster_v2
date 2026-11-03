namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F9")]
internal sealed class LeaveExceptionFilterInstruction : Instruction
{
	[Token(Token = "0x400022F")]
	internal static readonly LeaveExceptionFilterInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700017E")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000635")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700017D")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2266080", Offset = "0x2265480", Length = "0x2C")]
		[Token(Token = "0x6000634")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2266010", Offset = "0x2265410", Length = "0x67")]
	[Token(Token = "0x6000637")]
	private static LeaveExceptionFilterInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000633")]
	private LeaveExceptionFilterInstruction() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000635")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2266080", Offset = "0x2265480", Length = "0x2C")]
	[Token(Token = "0x6000634")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000636")]
	public virtual int Run(InterpretedFrame frame) { }

}

