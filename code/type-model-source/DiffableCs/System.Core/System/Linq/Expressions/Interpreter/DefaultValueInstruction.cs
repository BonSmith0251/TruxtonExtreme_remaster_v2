namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000108")]
internal sealed class DefaultValueInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000246")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x17000190")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2256830", Offset = "0x2255C30", Length = "0x2C")]
		[Token(Token = "0x600066B")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700018F")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600066A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000669")]
	internal DefaultValueInstruction(Type type) { }

	[Address(RVA = "0x2256830", Offset = "0x2255C30", Length = "0x2C")]
	[Token(Token = "0x600066B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600066A")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2256790", Offset = "0x2255B90", Length = "0x37")]
	[Token(Token = "0x600066C")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x22567D0", Offset = "0x2255BD0", Length = "0x5F")]
	[Token(Token = "0x600066D")]
	public virtual string ToString() { }

}

