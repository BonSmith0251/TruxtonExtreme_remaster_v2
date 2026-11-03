namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A3")]
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001D6")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229D7C0", Offset = "0x229CBC0", Length = "0x2C")]
		[Token(Token = "0x6000935")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001D5")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000934")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000933")]
	internal LoadLocalFromClosureInstruction(int index) { }

	[Address(RVA = "0x229D7C0", Offset = "0x229CBC0", Length = "0x2C")]
	[Token(Token = "0x6000935")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000934")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D6D0", Offset = "0x229CAD0", Length = "0xE5")]
	[Token(Token = "0x6000936")]
	public virtual int Run(InterpretedFrame frame) { }

}

