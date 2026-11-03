namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E0")]
internal sealed class NewArrayInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020A")]
	private readonly Type _elementType; //Field offset: 0x10

	[Token(Token = "0x17000142")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005A5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000144")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2268310", Offset = "0x2267710", Length = "0x2C")]
		[Token(Token = "0x60005A7")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000143")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005A6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60005A4")]
	internal NewArrayInstruction(Type elementType) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005A5")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2268310", Offset = "0x2267710", Length = "0x2C")]
	[Token(Token = "0x60005A7")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005A6")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2268280", Offset = "0x2267680", Length = "0x88")]
	[Token(Token = "0x60005A8")]
	public virtual int Run(InterpretedFrame frame) { }

}

