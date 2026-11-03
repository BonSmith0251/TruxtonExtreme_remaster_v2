namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E4")]
internal sealed class ArrayLengthInstruction : Instruction
{
	[Token(Token = "0x400020F")]
	public static readonly ArrayLengthInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x1700014D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700014F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2252410", Offset = "0x2251810", Length = "0x2C")]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700014E")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005BA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22523A0", Offset = "0x22517A0", Length = "0x67")]
	[Token(Token = "0x60005BE")]
	private static ArrayLengthInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005BC")]
	private ArrayLengthInstruction() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005B9")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2252410", Offset = "0x2251810", Length = "0x2C")]
	[Token(Token = "0x60005BB")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005BA")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2252320", Offset = "0x2251720", Length = "0x79")]
	[Token(Token = "0x60005BD")]
	public virtual int Run(InterpretedFrame frame) { }

}

