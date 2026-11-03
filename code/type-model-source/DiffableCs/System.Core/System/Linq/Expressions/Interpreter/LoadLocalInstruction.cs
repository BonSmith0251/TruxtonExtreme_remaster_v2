namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A1")]
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

	[Token(Token = "0x170001D2")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229D910", Offset = "0x229CD10", Length = "0x2C")]
		[Token(Token = "0x600092C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001D1")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600092B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600092A")]
	internal LoadLocalInstruction(int index) { }

	[Address(RVA = "0x229D7F0", Offset = "0x229CBF0", Length = "0x65")]
	[Token(Token = "0x600092E")]
	public override Instruction BoxIfIndexMatches(int index) { }

	[Address(RVA = "0x229D910", Offset = "0x229CD10", Length = "0x2C")]
	[Token(Token = "0x600092C")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600092B")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D860", Offset = "0x229CC60", Length = "0xA1")]
	[Token(Token = "0x600092D")]
	public virtual int Run(InterpretedFrame frame) { }

}

