namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EC")]
internal sealed class BranchFalseInstruction : OffsetInstruction
{
	[Token(Token = "0x400021C")]
	private static Instruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x1700015A")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x22539F0", Offset = "0x2252DF0", Length = "0x8E")]
		[Token(Token = "0x60005E5")]
		 get { } //Length: 142
	}

	[Token(Token = "0x1700015C")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005E7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700015B")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2253A80", Offset = "0x2252E80", Length = "0x2C")]
		[Token(Token = "0x60005E6")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x22539E0", Offset = "0x2252DE0", Length = "0xE")]
	[Token(Token = "0x60005E9")]
	public BranchFalseInstruction() { }

	[Address(RVA = "0x22539F0", Offset = "0x2252DF0", Length = "0x8E")]
	[Token(Token = "0x60005E5")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005E7")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2253A80", Offset = "0x2252E80", Length = "0x2C")]
	[Token(Token = "0x60005E6")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2253970", Offset = "0x2252D70", Length = "0x63")]
	[Token(Token = "0x60005E8")]
	public virtual int Run(InterpretedFrame frame) { }

}

