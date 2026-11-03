namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A7")]
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001DE")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000947")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001E0")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2290F80", Offset = "0x2290380", Length = "0x2C")]
		[Token(Token = "0x6000949")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001DF")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000948")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000946")]
	internal AssignLocalBoxedInstruction(int index) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000947")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2290F80", Offset = "0x2290380", Length = "0x2C")]
	[Token(Token = "0x6000949")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000948")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2290EA0", Offset = "0x22902A0", Length = "0xDD")]
	[Token(Token = "0x600094A")]
	public virtual int Run(InterpretedFrame frame) { }

}

