namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001B4")]
internal sealed class RuntimeVariablesInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000376")]
	private readonly int _count; //Field offset: 0x10

	[Token(Token = "0x170001F2")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000979")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170001F3")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A8BA0", Offset = "0x22A7FA0", Length = "0x2C")]
		[Token(Token = "0x600097A")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001F1")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000978")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000977")]
	public RuntimeVariablesInstruction(int count) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000979")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A8BA0", Offset = "0x22A7FA0", Length = "0x2C")]
	[Token(Token = "0x600097A")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000978")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22A89E0", Offset = "0x22A7DE0", Length = "0x1B9")]
	[Token(Token = "0x600097B")]
	public virtual int Run(InterpretedFrame frame) { }

}

