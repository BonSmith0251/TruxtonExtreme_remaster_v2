namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200022E")]
internal sealed class CreateDelegateInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003EE")]
	private readonly LightDelegateCreator _creator; //Field offset: 0x10

	[Token(Token = "0x17000230")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2294090", Offset = "0x2293490", Length = "0x26")]
		[Token(Token = "0x6000AC2")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000232")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22940C0", Offset = "0x22934C0", Length = "0x2C")]
		[Token(Token = "0x6000AC4")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000231")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AC3")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000AC1")]
	internal CreateDelegateInstruction(LightDelegateCreator delegateCreator) { }

	[Address(RVA = "0x2294090", Offset = "0x2293490", Length = "0x26")]
	[Token(Token = "0x6000AC2")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22940C0", Offset = "0x22934C0", Length = "0x2C")]
	[Token(Token = "0x6000AC4")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AC3")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2293EC0", Offset = "0x22932C0", Length = "0x1C8")]
	[Token(Token = "0x6000AC5")]
	public virtual int Run(InterpretedFrame frame) { }

}

