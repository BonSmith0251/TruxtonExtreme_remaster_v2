namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A5")]
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

	[Token(Token = "0x170001D9")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600093C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001DB")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22910C0", Offset = "0x22904C0", Length = "0x2C")]
		[Token(Token = "0x600093E")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001DA")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600093D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x600093B")]
	internal AssignLocalInstruction(int index) { }

	[Address(RVA = "0x2290FB0", Offset = "0x22903B0", Length = "0x65")]
	[Token(Token = "0x6000940")]
	public override Instruction BoxIfIndexMatches(int index) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600093C")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22910C0", Offset = "0x22904C0", Length = "0x2C")]
	[Token(Token = "0x600093E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600093D")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2291020", Offset = "0x2290420", Length = "0x94")]
	[Token(Token = "0x600093F")]
	public virtual int Run(InterpretedFrame frame) { }

}

