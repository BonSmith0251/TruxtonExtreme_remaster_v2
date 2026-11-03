namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001AA")]
internal sealed class ValueTypeCopyInstruction : Instruction
{
	[Token(Token = "0x4000371")]
	public static readonly ValueTypeCopyInstruction Instruction; //Field offset: 0x0

	[Token(Token = "0x170001E6")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000954")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001E8")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22AD680", Offset = "0x22ACA80", Length = "0x2C")]
		[Token(Token = "0x6000956")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001E7")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000955")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22AD610", Offset = "0x22ACA10", Length = "0x67")]
	[Token(Token = "0x6000959")]
	private static ValueTypeCopyInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000958")]
	public ValueTypeCopyInstruction() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000954")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22AD680", Offset = "0x22ACA80", Length = "0x2C")]
	[Token(Token = "0x6000956")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000955")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22AD5C0", Offset = "0x22AC9C0", Length = "0x47")]
	[Token(Token = "0x6000957")]
	public virtual int Run(InterpretedFrame frame) { }

}

