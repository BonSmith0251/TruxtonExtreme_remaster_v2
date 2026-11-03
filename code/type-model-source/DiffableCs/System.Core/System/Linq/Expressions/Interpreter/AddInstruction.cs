namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000C5")]
internal abstract class AddInstruction : Instruction
{
	[Token(Token = "0x20000CD")]
	private sealed class AddDouble : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000576")]
		public AddDouble() { }

		[Address(RVA = "0x224F3D0", Offset = "0x224E7D0", Length = "0x15E")]
		[Token(Token = "0x6000575")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000C6")]
	private sealed class AddInt16 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000568")]
		public AddInt16() { }

		[Address(RVA = "0x224F9E0", Offset = "0x224EDE0", Length = "0x154")]
		[Token(Token = "0x6000567")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000C7")]
	private sealed class AddInt32 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600056A")]
		public AddInt32() { }

		[Address(RVA = "0x224FB40", Offset = "0x224EF40", Length = "0x14F")]
		[Token(Token = "0x6000569")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000C8")]
	private sealed class AddInt64 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600056C")]
		public AddInt64() { }

		[Address(RVA = "0x224FC90", Offset = "0x224F090", Length = "0x154")]
		[Token(Token = "0x600056B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000CC")]
	private sealed class AddSingle : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000574")]
		public AddSingle() { }

		[Address(RVA = "0x2251040", Offset = "0x2250440", Length = "0x15E")]
		[Token(Token = "0x6000573")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000C9")]
	private sealed class AddUInt16 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600056E")]
		public AddUInt16() { }

		[Address(RVA = "0x22511A0", Offset = "0x22505A0", Length = "0x154")]
		[Token(Token = "0x600056D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000CA")]
	private sealed class AddUInt32 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000570")]
		public AddUInt32() { }

		[Address(RVA = "0x2251300", Offset = "0x2250700", Length = "0x152")]
		[Token(Token = "0x600056F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000CB")]
	private sealed class AddUInt64 : AddInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000572")]
		public AddUInt64() { }

		[Address(RVA = "0x2251460", Offset = "0x2250860", Length = "0x154")]
		[Token(Token = "0x6000571")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40001F1")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40001F2")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40001F3")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x40001F4")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x40001F5")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x40001F6")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x40001F7")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x40001F8")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x17000136")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000562")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000138")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x224F9B0", Offset = "0x224EDB0", Length = "0x2C")]
		[Token(Token = "0x6000564")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000137")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000563")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000565")]
	private AddInstruction() { }

	[Address(RVA = "0x224F530", Offset = "0x224E930", Length = "0x460")]
	[Token(Token = "0x6000566")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000562")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x224F9B0", Offset = "0x224EDB0", Length = "0x2C")]
	[Token(Token = "0x6000564")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000563")]
	public virtual int get_ProducedStack() { }

}

