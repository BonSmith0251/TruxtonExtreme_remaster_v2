namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000210")]
internal abstract class RightShiftInstruction : Instruction
{
	[Token(Token = "0x2000215")]
	private sealed class RightShiftByte : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A7D")]
		public RightShiftByte() { }

		[Address(RVA = "0x22A7D30", Offset = "0x22A7130", Length = "0xC3")]
		[Token(Token = "0x6000A7C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000212")]
	private sealed class RightShiftInt16 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A77")]
		public RightShiftInt16() { }

		[Address(RVA = "0x22A82B0", Offset = "0x22A76B0", Length = "0xC2")]
		[Token(Token = "0x6000A76")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000213")]
	private sealed class RightShiftInt32 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A79")]
		public RightShiftInt32() { }

		[Address(RVA = "0x22A8380", Offset = "0x22A7780", Length = "0xC0")]
		[Token(Token = "0x6000A78")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000214")]
	private sealed class RightShiftInt64 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A7B")]
		public RightShiftInt64() { }

		[Address(RVA = "0x22A8450", Offset = "0x22A7850", Length = "0xCE")]
		[Token(Token = "0x6000A7A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000211")]
	private sealed class RightShiftSByte : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A75")]
		public RightShiftSByte() { }

		[Address(RVA = "0x22A8520", Offset = "0x22A7920", Length = "0xC3")]
		[Token(Token = "0x6000A74")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000216")]
	private sealed class RightShiftUInt16 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A7F")]
		public RightShiftUInt16() { }

		[Address(RVA = "0x22A85F0", Offset = "0x22A79F0", Length = "0xC2")]
		[Token(Token = "0x6000A7E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000217")]
	private sealed class RightShiftUInt32 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A81")]
		public RightShiftUInt32() { }

		[Address(RVA = "0x22A86C0", Offset = "0x22A7AC0", Length = "0xCB")]
		[Token(Token = "0x6000A80")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000218")]
	private sealed class RightShiftUInt64 : RightShiftInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A83")]
		public RightShiftUInt64() { }

		[Address(RVA = "0x22A8790", Offset = "0x22A7B90", Length = "0xCE")]
		[Token(Token = "0x6000A82")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003D3")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x40003D4")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x40003D5")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x40003D6")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x40003D7")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x40003D8")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x40003D9")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x40003DA")]
	private static Instruction s_UInt64; //Field offset: 0x38

	[Token(Token = "0x1700021F")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000A6F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000221")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A8280", Offset = "0x22A7680", Length = "0x2C")]
		[Token(Token = "0x6000A71")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000220")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A70")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A72")]
	private RightShiftInstruction() { }

	[Address(RVA = "0x22A7E00", Offset = "0x22A7200", Length = "0x460")]
	[Token(Token = "0x6000A73")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000A6F")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A8280", Offset = "0x22A7680", Length = "0x2C")]
	[Token(Token = "0x6000A71")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A70")]
	public virtual int get_ProducedStack() { }

}

