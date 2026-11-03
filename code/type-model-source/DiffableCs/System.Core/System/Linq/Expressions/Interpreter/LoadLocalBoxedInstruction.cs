namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A2")]
internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001D4")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229D5C0", Offset = "0x229C9C0", Length = "0x2C")]
		[Token(Token = "0x6000931")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001D3")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000930")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600092F")]
	internal LoadLocalBoxedInstruction(int index) { }

	[Address(RVA = "0x229D5C0", Offset = "0x229C9C0", Length = "0x2C")]
	[Token(Token = "0x6000931")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000930")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D4A0", Offset = "0x229C8A0", Length = "0x116")]
	[Token(Token = "0x6000932")]
	public virtual int Run(InterpretedFrame frame) { }

}

