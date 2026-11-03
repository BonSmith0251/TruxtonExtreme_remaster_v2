namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E2")]
internal sealed class GetArrayItemInstruction : Instruction
{
	[Token(Token = "0x400020D")]
	internal static readonly GetArrayItemInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000148")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60005AF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2263CF0", Offset = "0x22630F0", Length = "0x2C")]
		[Token(Token = "0x60005B1")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000149")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005B0")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2263C80", Offset = "0x2263080", Length = "0x67")]
	[Token(Token = "0x60005B3")]
	private static GetArrayItemInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005AE")]
	private GetArrayItemInstruction() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60005AF")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2263CF0", Offset = "0x22630F0", Length = "0x2C")]
	[Token(Token = "0x60005B1")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005B0")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2263BE0", Offset = "0x2262FE0", Length = "0x9B")]
	[Token(Token = "0x60005B2")]
	public virtual int Run(InterpretedFrame frame) { }

}

