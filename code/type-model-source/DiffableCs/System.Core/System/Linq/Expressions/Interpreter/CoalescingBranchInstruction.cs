namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EE")]
internal sealed class CoalescingBranchInstruction : OffsetInstruction
{
	[Token(Token = "0x400021E")]
	private static Instruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000160")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x2255490", Offset = "0x2254890", Length = "0x8E")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000162")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005F1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000161")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2255520", Offset = "0x2254920", Length = "0x2C")]
		[Token(Token = "0x60005F0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000163")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005F2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22539E0", Offset = "0x2252DE0", Length = "0xE")]
	[Token(Token = "0x60005F4")]
	public CoalescingBranchInstruction() { }

	[Address(RVA = "0x2255490", Offset = "0x2254890", Length = "0x8E")]
	[Token(Token = "0x60005EF")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005F1")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2255520", Offset = "0x2254920", Length = "0x2C")]
	[Token(Token = "0x60005F0")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005F2")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2255450", Offset = "0x2254850", Length = "0x39")]
	[Token(Token = "0x60005F3")]
	public virtual int Run(InterpretedFrame frame) { }

}

