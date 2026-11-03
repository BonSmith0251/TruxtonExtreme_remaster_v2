namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F7")]
internal sealed class LeaveFaultInstruction : Instruction
{
	[Token(Token = "0x400022D")]
	internal static readonly Instruction Instance; //Field offset: 0x0

	[Token(Token = "0x17000179")]
	public virtual int ConsumedContinuations
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600062A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000178")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000629")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700017A")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2266390", Offset = "0x2265790", Length = "0x2C")]
		[Token(Token = "0x600062B")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2266320", Offset = "0x2265720", Length = "0x67")]
	[Token(Token = "0x600062D")]
	private static LeaveFaultInstruction() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000628")]
	private LeaveFaultInstruction() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600062A")]
	public virtual int get_ConsumedContinuations() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000629")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2266390", Offset = "0x2265790", Length = "0x2C")]
	[Token(Token = "0x600062B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22662F0", Offset = "0x22656F0", Length = "0x25")]
	[Token(Token = "0x600062C")]
	public virtual int Run(InterpretedFrame frame) { }

}

