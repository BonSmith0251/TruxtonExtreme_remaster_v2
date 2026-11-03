namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000D5")]
internal abstract class AndInstruction : Instruction
{
	[Token(Token = "0x20000DE")]
	private sealed class AndBoolean : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600059E")]
		public AndBoolean() { }

		[Address(RVA = "0x22515C0", Offset = "0x22509C0", Length = "0x174")]
		[Token(Token = "0x600059D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000DA")]
	private sealed class AndByte : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000596")]
		public AndByte() { }

		[Address(RVA = "0x2251740", Offset = "0x2250B40", Length = "0xC4")]
		[Token(Token = "0x6000595")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D7")]
	private sealed class AndInt16 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000590")]
		public AndInt16() { }

		[Address(RVA = "0x2251D40", Offset = "0x2251140", Length = "0xC4")]
		[Token(Token = "0x600058F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D8")]
	private sealed class AndInt32 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000592")]
		public AndInt32() { }

		[Address(RVA = "0x2251E10", Offset = "0x2251210", Length = "0xC1")]
		[Token(Token = "0x6000591")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D9")]
	private sealed class AndInt64 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000594")]
		public AndInt64() { }

		[Address(RVA = "0x2251EE0", Offset = "0x22512E0", Length = "0xD5")]
		[Token(Token = "0x6000593")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D6")]
	private sealed class AndSByte : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600058E")]
		public AndSByte() { }

		[Address(RVA = "0x2251FC0", Offset = "0x22513C0", Length = "0xC4")]
		[Token(Token = "0x600058D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000DB")]
	private sealed class AndUInt16 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000598")]
		public AndUInt16() { }

		[Address(RVA = "0x2252090", Offset = "0x2251490", Length = "0xC4")]
		[Token(Token = "0x6000597")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000DC")]
	private sealed class AndUInt32 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600059A")]
		public AndUInt32() { }

		[Address(RVA = "0x2252160", Offset = "0x2251560", Length = "0xD1")]
		[Token(Token = "0x6000599")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000DD")]
	private sealed class AndUInt64 : AndInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600059C")]
		public AndUInt64() { }

		[Address(RVA = "0x2252240", Offset = "0x2251640", Length = "0xD5")]
		[Token(Token = "0x600059B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40001FF")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x4000200")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x4000201")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x4000202")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x4000203")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x4000204")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x4000205")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x4000206")]
	private static Instruction s_UInt64; //Field offset: 0x38
	[Token(Token = "0x4000207")]
	private static Instruction s_Boolean; //Field offset: 0x40

	[Token(Token = "0x1700013C")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000588")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700013E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2251D10", Offset = "0x2251110", Length = "0x2C")]
		[Token(Token = "0x600058A")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700013D")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000589")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600058B")]
	private AndInstruction() { }

	[Address(RVA = "0x2251810", Offset = "0x2250C10", Length = "0x4D0")]
	[Token(Token = "0x600058C")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000588")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2251D10", Offset = "0x2251110", Length = "0x2C")]
	[Token(Token = "0x600058A")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000589")]
	public virtual int get_ProducedStack() { }

}

