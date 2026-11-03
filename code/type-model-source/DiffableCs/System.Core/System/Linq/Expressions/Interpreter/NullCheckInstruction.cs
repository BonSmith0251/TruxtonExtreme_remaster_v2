namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000201")]
internal sealed class NullCheckInstruction : Instruction
{
	[Token(Token = "0x40003C6")]
	public static readonly Instruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000213")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A3B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000215")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A5780", Offset = "0x22A4B80", Length = "0x2C")]
		[Token(Token = "0x6000A3D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000214")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A3C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22A5710", Offset = "0x22A4B10", Length = "0x67")]
	[Token(Token = "0x6000A3F")]
	private static NullCheckInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A3A")]
	private NullCheckInstruction() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A3B")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A5780", Offset = "0x22A4B80", Length = "0x2C")]
	[Token(Token = "0x6000A3D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A3C")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22A56A0", Offset = "0x22A4AA0", Length = "0x6D")]
	[Token(Token = "0x6000A3E")]
	public virtual int Run(InterpretedFrame frame) { }

}

