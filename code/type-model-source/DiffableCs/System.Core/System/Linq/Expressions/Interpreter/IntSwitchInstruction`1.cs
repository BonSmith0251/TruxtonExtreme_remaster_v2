namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FD")]
internal sealed class IntSwitchInstruction : Instruction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023B")]
	private readonly Dictionary<T, Int32> _cases; //Field offset: 0x0

	[Token(Token = "0x17000189")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600064E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000188")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x1CBEF90", Offset = "0x1CBE390", Length = "0x2C")]
		[Token(Token = "0x600064D")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600064C")]
	internal IntSwitchInstruction`1(Dictionary<T, Int32> cases) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600064E")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x1CBEF90", Offset = "0x1CBE390", Length = "0x2C")]
	[Token(Token = "0x600064D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x1CBECD0", Offset = "0x1CBE0D0", Length = "0xC2")]
	[Token(Token = "0x600064F")]
	public virtual int Run(InterpretedFrame frame) { }

}

