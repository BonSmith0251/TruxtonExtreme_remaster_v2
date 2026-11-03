namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F1")]
internal sealed class GotoInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x4000223")]
	private static readonly GotoInstruction[] s_cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000224")]
	private readonly bool _hasResult; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000225")]
	private readonly bool _hasValue; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000226")]
	private readonly bool _labelTargetGetsValue; //Field offset: 0x1A

	[Token(Token = "0x17000169")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2253DE0", Offset = "0x22531E0", Length = "0x9")]
		[Token(Token = "0x6000601")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000168")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22641E0", Offset = "0x22635E0", Length = "0x2C")]
		[Token(Token = "0x6000600")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700016A")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
		[Token(Token = "0x6000602")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2264120", Offset = "0x2263520", Length = "0x68")]
	[Token(Token = "0x6000606")]
	private static GotoInstruction() { }

	[Address(RVA = "0x2264190", Offset = "0x2263590", Length = "0x50")]
	[Token(Token = "0x6000603")]
	private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x2263ED0", Offset = "0x22632D0", Length = "0x16C")]
	[Token(Token = "0x6000604")]
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x2253DE0", Offset = "0x22531E0", Length = "0x9")]
	[Token(Token = "0x6000601")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22641E0", Offset = "0x22635E0", Length = "0x2C")]
	[Token(Token = "0x6000600")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
	[Token(Token = "0x6000602")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2264040", Offset = "0x2263440", Length = "0xD4")]
	[Token(Token = "0x6000605")]
	public virtual int Run(InterpretedFrame frame) { }

}

