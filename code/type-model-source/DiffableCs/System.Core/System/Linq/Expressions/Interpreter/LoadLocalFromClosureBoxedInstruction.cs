namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A4")]
internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001D8")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229D6A0", Offset = "0x229CAA0", Length = "0x2C")]
		[Token(Token = "0x6000939")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001D7")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000938")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000937")]
	internal LoadLocalFromClosureBoxedInstruction(int index) { }

	[Address(RVA = "0x229D6A0", Offset = "0x229CAA0", Length = "0x2C")]
	[Token(Token = "0x6000939")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000938")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D5F0", Offset = "0x229C9F0", Length = "0xA1")]
	[Token(Token = "0x600093A")]
	public virtual int Run(InterpretedFrame frame) { }

}

