namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001D8")]
internal abstract class NegateCheckedInstruction : Instruction
{
	[Token(Token = "0x20001DA")]
	private sealed class NegateCheckedInt16 : NegateCheckedInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009E1")]
		public NegateCheckedInt16() { }

		[Address(RVA = "0x22A20A0", Offset = "0x22A14A0", Length = "0x188")]
		[Token(Token = "0x60009E0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D9")]
	private sealed class NegateCheckedInt32 : NegateCheckedInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009DF")]
		public NegateCheckedInt32() { }

		[Address(RVA = "0x22A2230", Offset = "0x22A1630", Length = "0x131")]
		[Token(Token = "0x60009DE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001DB")]
	private sealed class NegateCheckedInt64 : NegateCheckedInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009E3")]
		public NegateCheckedInt64() { }

		[Address(RVA = "0x22A2370", Offset = "0x22A1770", Length = "0x11A")]
		[Token(Token = "0x60009E2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400039F")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40003A0")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40003A1")]
	private static Instruction s_Int64; //Field offset: 0x10

	[Token(Token = "0x17000206")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009D9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000208")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A2070", Offset = "0x22A1470", Length = "0x2C")]
		[Token(Token = "0x60009DB")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000207")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009DC")]
	private NegateCheckedInstruction() { }

	[Address(RVA = "0x22A1E70", Offset = "0x22A1270", Length = "0x1FE")]
	[Token(Token = "0x60009DD")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009D9")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A2070", Offset = "0x22A1470", Length = "0x2C")]
	[Token(Token = "0x60009DB")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009DA")]
	public virtual int get_ProducedStack() { }

}

