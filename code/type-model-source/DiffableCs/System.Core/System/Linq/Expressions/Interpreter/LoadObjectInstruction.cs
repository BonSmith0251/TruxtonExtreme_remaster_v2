namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021A")]
internal sealed class LoadObjectInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003DC")]
	private readonly object _value; //Field offset: 0x10

	[Token(Token = "0x17000223")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229DA60", Offset = "0x229CE60", Length = "0x2C")]
		[Token(Token = "0x6000A88")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000222")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A87")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000A86")]
	internal LoadObjectInstruction(object value) { }

	[Address(RVA = "0x229DA60", Offset = "0x229CE60", Length = "0x2C")]
	[Token(Token = "0x6000A88")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A87")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D940", Offset = "0x229CD40", Length = "0x8E")]
	[Token(Token = "0x6000A89")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x229D9D0", Offset = "0x229CDD0", Length = "0x8A")]
	[Token(Token = "0x6000A8A")]
	public virtual string ToString() { }

}

