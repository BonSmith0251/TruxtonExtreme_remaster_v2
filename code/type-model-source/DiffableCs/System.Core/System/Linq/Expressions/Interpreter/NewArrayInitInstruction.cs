namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000DF")]
internal sealed class NewArrayInitInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000208")]
	private readonly Type _elementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000209")]
	private readonly int _elementCount; //Field offset: 0x18

	[Token(Token = "0x1700013F")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60005A0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000141")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2268250", Offset = "0x2267650", Length = "0x2C")]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000140")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005A1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x600059F")]
	internal NewArrayInitInstruction(Type elementType, int elementCount) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60005A0")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2268250", Offset = "0x2267650", Length = "0x2C")]
	[Token(Token = "0x60005A2")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005A1")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22681C0", Offset = "0x22675C0", Length = "0x89")]
	[Token(Token = "0x60005A3")]
	public virtual int Run(InterpretedFrame frame) { }

}

