namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FB")]
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x4000233")]
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000234")]
	private readonly bool _hasValue; //Field offset: 0x18

	[Token(Token = "0x17000183")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
		[Token(Token = "0x6000640")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000182")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22662C0", Offset = "0x22656C0", Length = "0x2C")]
		[Token(Token = "0x600063F")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000184")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
		[Token(Token = "0x6000641")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2266250", Offset = "0x2265650", Length = "0x68")]
	[Token(Token = "0x6000644")]
	private static LeaveExceptionHandlerInstruction() { }

	[Address(RVA = "0x2258470", Offset = "0x2257870", Length = "0x36")]
	[Token(Token = "0x600063E")]
	private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue) { }

	[Address(RVA = "0x22660B0", Offset = "0x22654B0", Length = "0x141")]
	[Token(Token = "0x6000642")]
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
	[Token(Token = "0x6000640")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22662C0", Offset = "0x22656C0", Length = "0x2C")]
	[Token(Token = "0x600063F")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
	[Token(Token = "0x6000641")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2266200", Offset = "0x2265600", Length = "0x4D")]
	[Token(Token = "0x6000643")]
	public virtual int Run(InterpretedFrame frame) { }

}

