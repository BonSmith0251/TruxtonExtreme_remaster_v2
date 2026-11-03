namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000137")]
internal sealed class LoadStaticFieldInstruction : FieldInstruction
{

	[Token(Token = "0x1700019A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x228FFB0", Offset = "0x228F3B0", Length = "0x2C")]
		[Token(Token = "0x60006D4")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700019B")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006D3")]
	public LoadStaticFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x228FFB0", Offset = "0x228F3B0", Length = "0x2C")]
	[Token(Token = "0x60006D4")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006D5")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x228FEF0", Offset = "0x228F2F0", Length = "0xB8")]
	[Token(Token = "0x60006D6")]
	public virtual int Run(InterpretedFrame frame) { }

}

