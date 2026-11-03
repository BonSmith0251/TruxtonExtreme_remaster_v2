namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000230")]
internal sealed class TypeAsInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003F0")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x17000236")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000ACD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000238")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22AC070", Offset = "0x22AB470", Length = "0x2C")]
		[Token(Token = "0x6000ACF")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000237")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000ACE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000ACC")]
	internal TypeAsInstruction(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000ACD")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22AC070", Offset = "0x22AB470", Length = "0x2C")]
	[Token(Token = "0x6000ACF")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000ACE")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22ABF90", Offset = "0x22AB390", Length = "0x74")]
	[Token(Token = "0x6000AD0")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x22AC010", Offset = "0x22AB410", Length = "0x5D")]
	[Token(Token = "0x6000AD1")]
	public virtual string ToString() { }

}

