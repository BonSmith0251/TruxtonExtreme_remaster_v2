namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E3")]
internal sealed class SetArrayItemInstruction : Instruction
{
	[Token(Token = "0x400020E")]
	internal static readonly SetArrayItemInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700014B")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60005B5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2269670", Offset = "0x2268A70", Length = "0x2C")]
		[Token(Token = "0x60005B6")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2269600", Offset = "0x2268A00", Length = "0x67")]
	[Token(Token = "0x60005B8")]
	private static SetArrayItemInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005B4")]
	private SetArrayItemInstruction() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60005B5")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2269670", Offset = "0x2268A70", Length = "0x2C")]
	[Token(Token = "0x60005B6")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2269550", Offset = "0x2268950", Length = "0xAC")]
	[Token(Token = "0x60005B7")]
	public virtual int Run(InterpretedFrame frame) { }

}

