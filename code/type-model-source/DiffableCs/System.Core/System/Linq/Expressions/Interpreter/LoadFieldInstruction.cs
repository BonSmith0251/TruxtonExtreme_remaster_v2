namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000138")]
internal sealed class LoadFieldInstruction : FieldInstruction
{

	[Token(Token = "0x1700019D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006D9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700019C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x228FEC0", Offset = "0x228F2C0", Length = "0x2C")]
		[Token(Token = "0x60006D8")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700019E")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006DA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006D7")]
	public LoadFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006D9")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x228FEC0", Offset = "0x228F2C0", Length = "0x2C")]
	[Token(Token = "0x60006D8")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006DA")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x228FDD0", Offset = "0x228F1D0", Length = "0xE9")]
	[Token(Token = "0x60006DB")]
	public virtual int Run(InterpretedFrame frame) { }

}

