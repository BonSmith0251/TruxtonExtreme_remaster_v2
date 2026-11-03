namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E1")]
internal sealed class NewArrayBoundsInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020B")]
	private readonly Type _elementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020C")]
	private readonly int _rank; //Field offset: 0x18

	[Token(Token = "0x17000145")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60005AA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000147")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2267EE0", Offset = "0x22672E0", Length = "0x2C")]
		[Token(Token = "0x60005AC")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000146")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005AB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x60005A9")]
	internal NewArrayBoundsInstruction(Type elementType, int rank) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60005AA")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2267EE0", Offset = "0x22672E0", Length = "0x2C")]
	[Token(Token = "0x60005AC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005AB")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2267DA0", Offset = "0x22671A0", Length = "0x139")]
	[Token(Token = "0x60005AD")]
	public virtual int Run(InterpretedFrame frame) { }

}

