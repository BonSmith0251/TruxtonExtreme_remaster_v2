namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200012C")]
internal abstract class ExclusiveOrInstruction : Instruction
{
	[Token(Token = "0x2000135")]
	private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60006D0")]
		public ExclusiveOrBoolean() { }

		[Address(RVA = "0x226EF70", Offset = "0x226E370", Length = "0x13B")]
		[Token(Token = "0x60006CF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000131")]
	private sealed class ExclusiveOrByte : ExclusiveOrInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60006C8")]
		public ExclusiveOrByte() { }

		[Address(RVA = "0x226F0B0", Offset = "0x226E4B0", Length = "0x136")]
		[Token(Token = "0x60006C7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012E")]
	private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006C2")]
		public ExclusiveOrInt16() { }

		[Address(RVA = "0x225F930", Offset = "0x225ED30", Length = "0xC4")]
		[Token(Token = "0x60006C1")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012F")]
	private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006C4")]
		public ExclusiveOrInt32() { }

		[Address(RVA = "0x225FA00", Offset = "0x225EE00", Length = "0xC1")]
		[Token(Token = "0x60006C3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000130")]
	private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006C6")]
		public ExclusiveOrInt64() { }

		[Address(RVA = "0x225FAD0", Offset = "0x225EED0", Length = "0xD2")]
		[Token(Token = "0x60006C5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012D")]
	private sealed class ExclusiveOrSByte : ExclusiveOrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006C0")]
		public ExclusiveOrSByte() { }

		[Address(RVA = "0x225FBB0", Offset = "0x225EFB0", Length = "0xC5")]
		[Token(Token = "0x60006BF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000132")]
	private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60006CA")]
		public ExclusiveOrUInt16() { }

		[Address(RVA = "0x226F1F0", Offset = "0x226E5F0", Length = "0x135")]
		[Token(Token = "0x60006C9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000133")]
	private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60006CC")]
		public ExclusiveOrUInt32() { }

		[Address(RVA = "0x226F330", Offset = "0x226E730", Length = "0x1C7")]
		[Token(Token = "0x60006CB")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000134")]
	private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x60006CE")]
		public ExclusiveOrUInt64() { }

		[Address(RVA = "0x226F500", Offset = "0x226E900", Length = "0x1CA")]
		[Token(Token = "0x60006CD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000268")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x4000269")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x400026A")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x400026B")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x400026C")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x400026D")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x400026E")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x400026F")]
	private static Instruction s_UInt64; //Field offset: 0x38
	[Token(Token = "0x4000270")]
	private static Instruction s_Boolean; //Field offset: 0x40

	[Token(Token = "0x17000197")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000199")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x225F900", Offset = "0x225ED00", Length = "0x2C")]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000198")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006BB")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60006BD")]
	private ExclusiveOrInstruction() { }

	[Address(RVA = "0x225F400", Offset = "0x225E800", Length = "0x4D0")]
	[Token(Token = "0x60006BE")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60006BA")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x225F900", Offset = "0x225ED00", Length = "0x2C")]
	[Token(Token = "0x60006BC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006BB")]
	public virtual int get_ProducedStack() { }

}

