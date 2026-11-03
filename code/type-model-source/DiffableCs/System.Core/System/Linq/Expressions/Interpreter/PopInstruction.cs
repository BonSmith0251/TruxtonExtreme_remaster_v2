namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021C")]
internal sealed class PopInstruction : Instruction
{
	[Token(Token = "0x40003DE")]
	internal static readonly PopInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000226")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A92")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000227")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A7120", Offset = "0x22A6520", Length = "0x2C")]
		[Token(Token = "0x6000A93")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x22A70B0", Offset = "0x22A64B0", Length = "0x67")]
	[Token(Token = "0x6000A95")]
	private static PopInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A91")]
	private PopInstruction() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A92")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A7120", Offset = "0x22A6520", Length = "0x2C")]
	[Token(Token = "0x6000A93")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22A7080", Offset = "0x22A6480", Length = "0x25")]
	[Token(Token = "0x6000A94")]
	public virtual int Run(InterpretedFrame frame) { }

}

