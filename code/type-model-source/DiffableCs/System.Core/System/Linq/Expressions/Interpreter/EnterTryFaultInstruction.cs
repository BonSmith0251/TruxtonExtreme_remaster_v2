namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F3")]
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000229")]
	private TryFaultHandler _tryHandler; //Field offset: 0x18

	[Token(Token = "0x17000170")]
	internal TryFaultHandler Handler
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000613")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700016E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22587B0", Offset = "0x2257BB0", Length = "0x2C")]
		[Token(Token = "0x6000611")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700016F")]
	public virtual int ProducedContinuations
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000612")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000610")]
	internal EnterTryFaultInstruction(int targetIndex) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000613")]
	internal TryFaultHandler get_Handler() { }

	[Address(RVA = "0x22587B0", Offset = "0x2257BB0", Length = "0x2C")]
	[Token(Token = "0x6000611")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000612")]
	public virtual int get_ProducedContinuations() { }

	[Address(RVA = "0x2258500", Offset = "0x2257900", Length = "0x2AF")]
	[Token(Token = "0x6000615")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000614")]
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

}

