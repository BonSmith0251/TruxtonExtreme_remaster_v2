namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001D2")]
internal abstract class NegateInstruction : Instruction
{
	[Token(Token = "0x20001D7")]
	private sealed class NegateDouble : NegateInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009D8")]
		public NegateDouble() { }

		[Address(RVA = "0x22A2490", Offset = "0x22A1890", Length = "0x86")]
		[Token(Token = "0x60009D7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D3")]
	private sealed class NegateInt16 : NegateInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009D0")]
		public NegateInt16() { }

		[Address(RVA = "0x22A2870", Offset = "0x22A1C70", Length = "0x7B")]
		[Token(Token = "0x60009CF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D4")]
	private sealed class NegateInt32 : NegateInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009D2")]
		public NegateInt32() { }

		[Address(RVA = "0x22A28F0", Offset = "0x22A1CF0", Length = "0x79")]
		[Token(Token = "0x60009D1")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D5")]
	private sealed class NegateInt64 : NegateInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009D4")]
		public NegateInt64() { }

		[Address(RVA = "0x22A2970", Offset = "0x22A1D70", Length = "0x80")]
		[Token(Token = "0x60009D3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001D6")]
	private sealed class NegateSingle : NegateInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009D6")]
		public NegateSingle() { }

		[Address(RVA = "0x22A2A00", Offset = "0x22A1E00", Length = "0x86")]
		[Token(Token = "0x60009D5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400039A")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x400039B")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x400039C")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x400039D")]
	private static Instruction s_Single; //Field offset: 0x18
	[Token(Token = "0x400039E")]
	private static Instruction s_Double; //Field offset: 0x20

	[Token(Token = "0x17000203")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000205")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A2840", Offset = "0x22A1C40", Length = "0x2C")]
		[Token(Token = "0x60009CC")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000204")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009CB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009CD")]
	private NegateInstruction() { }

	[Address(RVA = "0x22A2520", Offset = "0x22A1920", Length = "0x2FC")]
	[Token(Token = "0x60009CE")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009CA")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A2840", Offset = "0x22A1C40", Length = "0x2C")]
	[Token(Token = "0x60009CC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009CB")]
	public virtual int get_ProducedStack() { }

}

