namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FC")]
internal sealed class ThrowInstruction : Instruction
{
	[Token(Token = "0x4000235")]
	internal static readonly ThrowInstruction Throw; //Field offset: 0x0
	[Token(Token = "0x4000236")]
	internal static readonly ThrowInstruction VoidThrow; //Field offset: 0x8
	[Token(Token = "0x4000237")]
	internal static readonly ThrowInstruction Rethrow; //Field offset: 0x10
	[Token(Token = "0x4000238")]
	internal static readonly ThrowInstruction VoidRethrow; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000239")]
	private readonly bool _hasResult; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400023A")]
	private readonly bool _rethrow; //Field offset: 0x11

	[Token(Token = "0x17000187")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000185")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x226BB10", Offset = "0x226AF10", Length = "0x2C")]
		[Token(Token = "0x6000646")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000186")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2257A20", Offset = "0x2256E20", Length = "0x9")]
		[Token(Token = "0x6000647")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x226B980", Offset = "0x226AD80", Length = "0x14E")]
	[Token(Token = "0x600064B")]
	private static ThrowInstruction() { }

	[Address(RVA = "0x226BAD0", Offset = "0x226AED0", Length = "0x37")]
	[Token(Token = "0x6000645")]
	private ThrowInstruction(bool hasResult, bool isRethrow) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000648")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x226BB10", Offset = "0x226AF10", Length = "0x2C")]
	[Token(Token = "0x6000646")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2257A20", Offset = "0x2256E20", Length = "0x9")]
	[Token(Token = "0x6000647")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x226B7B0", Offset = "0x226ABB0", Length = "0x11F")]
	[Token(Token = "0x6000649")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x226B8D0", Offset = "0x226ACD0", Length = "0xA3")]
	[Token(Token = "0x600064A")]
	private static Exception WrapThrownObject(object thrown) { }

}

