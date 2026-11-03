namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EF")]
internal class BranchInstruction : OffsetInstruction
{
	[Token(Token = "0x400021F")]
	private static Instruction[][][] s_caches; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000220")]
	internal readonly bool _hasResult; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000221")]
	internal readonly bool _hasValue; //Field offset: 0x19

	[Token(Token = "0x17000164")]
	public virtual Instruction[] Cache
	{
		[Address(RVA = "0x2253B20", Offset = "0x2252F20", Length = "0x2B0")]
		[Token(Token = "0x60005F5")]
		 get { } //Length: 688
	}

	[Token(Token = "0x17000166")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2253DE0", Offset = "0x22531E0", Length = "0x9")]
		[Token(Token = "0x60005F9")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000165")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2253DF0", Offset = "0x22531F0", Length = "0x2C")]
		[Token(Token = "0x60005F8")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000167")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
		[Token(Token = "0x60005FA")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2253AB0", Offset = "0x2252EB0", Length = "0x23")]
	[Token(Token = "0x60005F6")]
	internal BranchInstruction() { }

	[Address(RVA = "0x2253AE0", Offset = "0x2252EE0", Length = "0x3E")]
	[Token(Token = "0x60005F7")]
	public BranchInstruction(bool hasResult, bool hasValue) { }

	[Address(RVA = "0x2253B20", Offset = "0x2252F20", Length = "0x2B0")]
	[Token(Token = "0x60005F5")]
	public virtual Instruction[] get_Cache() { }

	[Address(RVA = "0x2253DE0", Offset = "0x22531E0", Length = "0x9")]
	[Token(Token = "0x60005F9")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2253DF0", Offset = "0x22531F0", Length = "0x2C")]
	[Token(Token = "0x60005F8")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
	[Token(Token = "0x60005FA")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60005FB")]
	public virtual int Run(InterpretedFrame frame) { }

}

