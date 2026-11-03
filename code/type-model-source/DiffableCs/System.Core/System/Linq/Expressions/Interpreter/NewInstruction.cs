namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001DC")]
internal class NewInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A2")]
	protected readonly ConstructorInfo _constructor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A3")]
	protected readonly int _argumentCount; //Field offset: 0x18

	[Token(Token = "0x17000209")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60009E5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700020B")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A2E60", Offset = "0x22A2260", Length = "0x2C")]
		[Token(Token = "0x60009E7")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700020A")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009E6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x60009E4")]
	public NewInstruction(ConstructorInfo constructor, int argumentCount) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60009E5")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A2E60", Offset = "0x22A2260", Length = "0x2C")]
	[Token(Token = "0x60009E7")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009E6")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22A2A90", Offset = "0x22A1E90", Length = "0x133")]
	[Token(Token = "0x60009E9")]
	protected Object[] GetArgs(InterpretedFrame frame, int first) { }

	[Address(RVA = "0x22A2BD0", Offset = "0x22A1FD0", Length = "0x113")]
	[Token(Token = "0x60009E8")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x22A2CF0", Offset = "0x22A20F0", Length = "0x16B")]
	[Token(Token = "0x60009EA")]
	public virtual string ToString() { }

}

