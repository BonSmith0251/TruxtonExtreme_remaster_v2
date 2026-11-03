namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A9")]
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction
{

	[Token(Token = "0x170001E3")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000950")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001E5")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2291180", Offset = "0x2290580", Length = "0x2C")]
		[Token(Token = "0x6000952")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001E4")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000951")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600094F")]
	internal AssignLocalToClosureInstruction(int index) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000950")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2291180", Offset = "0x2290580", Length = "0x2C")]
	[Token(Token = "0x6000952")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000951")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22910F0", Offset = "0x22904F0", Length = "0x89")]
	[Token(Token = "0x6000953")]
	public virtual int Run(InterpretedFrame frame) { }

}

