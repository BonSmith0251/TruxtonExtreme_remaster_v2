namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000109")]
internal abstract class DivInstruction : Instruction
{
	[Token(Token = "0x2000111")]
	private sealed class DivDouble : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000682")]
		public DivDouble() { }

		[Address(RVA = "0x2256860", Offset = "0x2255C60", Length = "0x158")]
		[Token(Token = "0x6000681")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010A")]
	private sealed class DivInt16 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000674")]
		public DivInt16() { }

		[Address(RVA = "0x2256E70", Offset = "0x2256270", Length = "0x158")]
		[Token(Token = "0x6000673")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010B")]
	private sealed class DivInt32 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000676")]
		public DivInt32() { }

		[Address(RVA = "0x2256FD0", Offset = "0x22563D0", Length = "0x159")]
		[Token(Token = "0x6000675")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010C")]
	private sealed class DivInt64 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000678")]
		public DivInt64() { }

		[Address(RVA = "0x2257130", Offset = "0x2256530", Length = "0x159")]
		[Token(Token = "0x6000677")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000110")]
	private sealed class DivSingle : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000680")]
		public DivSingle() { }

		[Address(RVA = "0x2257290", Offset = "0x2256690", Length = "0x158")]
		[Token(Token = "0x600067F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010D")]
	private sealed class DivUInt16 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600067A")]
		public DivUInt16() { }

		[Address(RVA = "0x22573F0", Offset = "0x22567F0", Length = "0x159")]
		[Token(Token = "0x6000679")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010E")]
	private sealed class DivUInt32 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600067C")]
		public DivUInt32() { }

		[Address(RVA = "0x2257550", Offset = "0x2256950", Length = "0x157")]
		[Token(Token = "0x600067B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200010F")]
	private sealed class DivUInt64 : DivInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600067E")]
		public DivUInt64() { }

		[Address(RVA = "0x22576B0", Offset = "0x2256AB0", Length = "0x159")]
		[Token(Token = "0x600067D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000247")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x4000248")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x4000249")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x400024A")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x400024B")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x400024C")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x400024D")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x400024E")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x17000191")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600066E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000193")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2256E40", Offset = "0x2256240", Length = "0x2C")]
		[Token(Token = "0x6000670")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000192")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600066F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000671")]
	private DivInstruction() { }

	[Address(RVA = "0x22569C0", Offset = "0x2255DC0", Length = "0x460")]
	[Token(Token = "0x6000672")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600066E")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2256E40", Offset = "0x2256240", Length = "0x2C")]
	[Token(Token = "0x6000670")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600066F")]
	public virtual int get_ProducedStack() { }

}

