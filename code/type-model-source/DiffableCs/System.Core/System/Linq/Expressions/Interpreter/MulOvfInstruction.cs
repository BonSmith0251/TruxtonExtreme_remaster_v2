namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001CB")]
internal abstract class MulOvfInstruction : Instruction
{
	[Token(Token = "0x20001CC")]
	private sealed class MulOvfInt16 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009BF")]
		public MulOvfInt16() { }

		[Address(RVA = "0x22A0700", Offset = "0x229FB00", Length = "0x2FA")]
		[Token(Token = "0x60009BE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CD")]
	private sealed class MulOvfInt32 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009C1")]
		public MulOvfInt32() { }

		[Address(RVA = "0x22A0A00", Offset = "0x229FE00", Length = "0x263")]
		[Token(Token = "0x60009C0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CE")]
	private sealed class MulOvfInt64 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009C3")]
		public MulOvfInt64() { }

		[Address(RVA = "0x22A0C70", Offset = "0x22A0070", Length = "0x257")]
		[Token(Token = "0x60009C2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001CF")]
	private sealed class MulOvfUInt16 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009C5")]
		public MulOvfUInt16() { }

		[Address(RVA = "0x22A0ED0", Offset = "0x22A02D0", Length = "0x2DA")]
		[Token(Token = "0x60009C4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D0")]
	private sealed class MulOvfUInt32 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009C7")]
		public MulOvfUInt32() { }

		[Address(RVA = "0x22A11B0", Offset = "0x22A05B0", Length = "0x20D")]
		[Token(Token = "0x60009C6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D1")]
	private sealed class MulOvfUInt64 : MulOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009C9")]
		public MulOvfUInt64() { }

		[Address(RVA = "0x22A13C0", Offset = "0x22A07C0", Length = "0x219")]
		[Token(Token = "0x60009C8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000394")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x4000395")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x4000396")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x4000397")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x4000398")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x4000399")]
	private static Instruction s_UInt64; //Field offset: 0x28

	[Token(Token = "0x17000200")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60009B9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000202")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A06D0", Offset = "0x229FAD0", Length = "0x2C")]
		[Token(Token = "0x60009BB")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000201")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009BA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009BC")]
	private MulOvfInstruction() { }

	[Address(RVA = "0x22A0330", Offset = "0x229F730", Length = "0x388")]
	[Token(Token = "0x60009BD")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60009B9")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A06D0", Offset = "0x229FAD0", Length = "0x2C")]
	[Token(Token = "0x60009BB")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009BA")]
	public virtual int get_ProducedStack() { }

}

