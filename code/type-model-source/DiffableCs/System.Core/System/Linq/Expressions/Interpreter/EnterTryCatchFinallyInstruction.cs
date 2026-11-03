namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F2")]
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000227")]
	private readonly bool _hasFinally; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000228")]
	private TryCatchFinallyHandler _tryHandler; //Field offset: 0x20

	[Token(Token = "0x1700016B")]
	internal TryCatchFinallyHandler Handler
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000608")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700016D")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22584B0", Offset = "0x22578B0", Length = "0x4A")]
		[Token(Token = "0x600060E")]
		 get { } //Length: 74
	}

	[Token(Token = "0x1700016C")]
	public virtual int ProducedContinuations
	{
		[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
		[Token(Token = "0x6000609")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2258470", Offset = "0x2257870", Length = "0x36")]
	[Token(Token = "0x600060A")]
	private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally) { }

	[Address(RVA = "0x2257EE0", Offset = "0x22572E0", Length = "0x4F")]
	[Token(Token = "0x600060C")]
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	[Address(RVA = "0x2257F30", Offset = "0x2257330", Length = "0x56")]
	[Token(Token = "0x600060B")]
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000608")]
	internal TryCatchFinallyHandler get_Handler() { }

	[Address(RVA = "0x22584B0", Offset = "0x22578B0", Length = "0x4A")]
	[Token(Token = "0x600060E")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2253E20", Offset = "0x2253220", Length = "0x9")]
	[Token(Token = "0x6000609")]
	public virtual int get_ProducedContinuations() { }

	[Address(RVA = "0x2257F90", Offset = "0x2257390", Length = "0x459")]
	[Token(Token = "0x600060D")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000607")]
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	[Address(RVA = "0x22583F0", Offset = "0x22577F0", Length = "0x79")]
	[Token(Token = "0x600060F")]
	public virtual string ToString() { }

}

