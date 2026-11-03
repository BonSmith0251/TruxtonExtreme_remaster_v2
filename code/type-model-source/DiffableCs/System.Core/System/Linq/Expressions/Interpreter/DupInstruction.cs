namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021D")]
internal sealed class DupInstruction : Instruction
{
	[Token(Token = "0x40003DF")]
	internal static readonly DupInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000229")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2295870", Offset = "0x2294C70", Length = "0x2C")]
		[Token(Token = "0x6000A98")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000228")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A97")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2295800", Offset = "0x2294C00", Length = "0x67")]
	[Token(Token = "0x6000A9A")]
	private static DupInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A96")]
	private DupInstruction() { }

	[Address(RVA = "0x2295870", Offset = "0x2294C70", Length = "0x2C")]
	[Token(Token = "0x6000A98")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A97")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22957D0", Offset = "0x2294BD0", Length = "0x25")]
	[Token(Token = "0x6000A99")]
	public virtual int Run(InterpretedFrame frame) { }

}

