namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F4")]
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x400022A")]
	private static readonly EnterFinallyInstruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000173")]
	public virtual int ConsumedContinuations
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000619")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000171")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2257EB0", Offset = "0x22572B0", Length = "0x2C")]
		[Token(Token = "0x6000617")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000172")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000618")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2257E40", Offset = "0x2257240", Length = "0x68")]
	[Token(Token = "0x600061C")]
	private static EnterFinallyInstruction() { }

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000616")]
	private EnterFinallyInstruction(int labelIndex) { }

	[Address(RVA = "0x2257C90", Offset = "0x2257090", Length = "0x101")]
	[Token(Token = "0x600061A")]
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000619")]
	public virtual int get_ConsumedContinuations() { }

	[Address(RVA = "0x2257EB0", Offset = "0x22572B0", Length = "0x2C")]
	[Token(Token = "0x6000617")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000618")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2257DA0", Offset = "0x22571A0", Length = "0x91")]
	[Token(Token = "0x600061B")]
	public virtual int Run(InterpretedFrame frame) { }

}

