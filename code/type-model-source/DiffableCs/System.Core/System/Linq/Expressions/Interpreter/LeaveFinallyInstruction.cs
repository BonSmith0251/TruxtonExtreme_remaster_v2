namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F5")]
internal sealed class LeaveFinallyInstruction : Instruction
{
	[Token(Token = "0x400022B")]
	internal static readonly Instruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000174")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600061E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000175")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2266480", Offset = "0x2265880", Length = "0x2C")]
		[Token(Token = "0x600061F")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2266410", Offset = "0x2265810", Length = "0x67")]
	[Token(Token = "0x6000621")]
	private static LeaveFinallyInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600061D")]
	private LeaveFinallyInstruction() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600061E")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2266480", Offset = "0x2265880", Length = "0x2C")]
	[Token(Token = "0x600061F")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22663C0", Offset = "0x22657C0", Length = "0x45")]
	[Token(Token = "0x6000620")]
	public virtual int Run(InterpretedFrame frame) { }

}

