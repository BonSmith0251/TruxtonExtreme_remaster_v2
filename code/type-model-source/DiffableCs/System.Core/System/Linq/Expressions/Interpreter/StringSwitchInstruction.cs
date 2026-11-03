namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FE")]
internal sealed class StringSwitchInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023C")]
	private readonly Dictionary<String, Int32> _cases; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023D")]
	private readonly StrongBox<Int32> _nullCase; //Field offset: 0x18

	[Token(Token = "0x1700018B")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000652")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700018A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22697E0", Offset = "0x2268BE0", Length = "0x2C")]
		[Token(Token = "0x6000651")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x6000650")]
	internal StringSwitchInstruction(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000652")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22697E0", Offset = "0x2268BE0", Length = "0x2C")]
	[Token(Token = "0x6000651")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2269710", Offset = "0x2268B10", Length = "0xC3")]
	[Token(Token = "0x6000653")]
	public virtual int Run(InterpretedFrame frame) { }

}

