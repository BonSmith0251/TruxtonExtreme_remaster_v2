namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000231")]
internal sealed class TypeEqualsInstruction : Instruction
{
	[Token(Token = "0x40003F1")]
	public static readonly TypeEqualsInstruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000239")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000AD2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700023B")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22AC170", Offset = "0x22AB570", Length = "0x2C")]
		[Token(Token = "0x6000AD4")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700023A")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AD3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22AC100", Offset = "0x22AB500", Length = "0x67")]
	[Token(Token = "0x6000AD7")]
	private static TypeEqualsInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000AD5")]
	private TypeEqualsInstruction() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000AD2")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22AC170", Offset = "0x22AB570", Length = "0x2C")]
	[Token(Token = "0x6000AD4")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AD3")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22AC0A0", Offset = "0x22AB4A0", Length = "0x5F")]
	[Token(Token = "0x6000AD6")]
	public virtual int Run(InterpretedFrame frame) { }

}

