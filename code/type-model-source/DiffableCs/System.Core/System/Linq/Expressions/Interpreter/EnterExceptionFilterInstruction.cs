namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F8")]
internal sealed class EnterExceptionFilterInstruction : Instruction
{
	[Token(Token = "0x400022E")]
	internal static readonly EnterExceptionFilterInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700017B")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2257930", Offset = "0x2256D30", Length = "0x2C")]
		[Token(Token = "0x600062F")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700017C")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000630")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22578C0", Offset = "0x2256CC0", Length = "0x67")]
	[Token(Token = "0x6000632")]
	private static EnterExceptionFilterInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600062E")]
	private EnterExceptionFilterInstruction() { }

	[Address(RVA = "0x2257930", Offset = "0x2256D30", Length = "0x2C")]
	[Token(Token = "0x600062F")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000630")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000631")]
	public virtual int Run(InterpretedFrame frame) { }

}

