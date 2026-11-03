namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000ED")]
internal sealed class BranchTrueInstruction : OffsetInstruction
{
	[Token(Token = "0x400021D")]
	private static Instruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x1700015D")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x22541D0", Offset = "0x22535D0", Length = "0x8E")]
		[Token(Token = "0x60005EA")]
		 get { } //Length: 142
	}

	[Token(Token = "0x1700015F")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005EC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2254260", Offset = "0x2253660", Length = "0x2C")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x22539E0", Offset = "0x2252DE0", Length = "0xE")]
	[Token(Token = "0x60005EE")]
	public BranchTrueInstruction() { }

	[Address(RVA = "0x22541D0", Offset = "0x22535D0", Length = "0x8E")]
	[Token(Token = "0x60005EA")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005EC")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2254260", Offset = "0x2253660", Length = "0x2C")]
	[Token(Token = "0x60005EB")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2254160", Offset = "0x2253560", Length = "0x63")]
	[Token(Token = "0x60005ED")]
	public virtual int Run(InterpretedFrame frame) { }

}

