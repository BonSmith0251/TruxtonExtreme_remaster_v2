namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FA")]
internal sealed class EnterExceptionHandlerInstruction : Instruction
{
	[Token(Token = "0x4000230")]
	internal static readonly EnterExceptionHandlerInstruction Void; //Field offset: 0x0
	[Token(Token = "0x4000231")]
	internal static readonly EnterExceptionHandlerInstruction NonVoid; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000232")]
	private readonly bool _hasValue; //Field offset: 0x10

	[Token(Token = "0x17000180")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2257A20", Offset = "0x2256E20", Length = "0x9")]
		[Token(Token = "0x600063A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2257A30", Offset = "0x2256E30", Length = "0x2C")]
		[Token(Token = "0x6000639")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000181")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600063B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2257960", Offset = "0x2256D60", Length = "0xB4")]
	[Token(Token = "0x600063D")]
	private static EnterExceptionHandlerInstruction() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x6000638")]
	private EnterExceptionHandlerInstruction(bool hasValue) { }

	[Address(RVA = "0x2257A20", Offset = "0x2256E20", Length = "0x9")]
	[Token(Token = "0x600063A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2257A30", Offset = "0x2256E30", Length = "0x2C")]
	[Token(Token = "0x6000639")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600063B")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x600063C")]
	public virtual int Run(InterpretedFrame frame) { }

}

