namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A8")]
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001E1")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600094C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001E2")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A9250", Offset = "0x22A8650", Length = "0x2C")]
		[Token(Token = "0x600094D")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600094B")]
	internal StoreLocalBoxedInstruction(int index) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600094C")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A9250", Offset = "0x22A8650", Length = "0x2C")]
	[Token(Token = "0x600094D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22A9150", Offset = "0x22A8550", Length = "0xF4")]
	[Token(Token = "0x600094E")]
	public virtual int Run(InterpretedFrame frame) { }

}

