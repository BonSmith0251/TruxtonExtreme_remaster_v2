namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001F7")]
internal abstract class NotInstruction : Instruction
{
	[Token(Token = "0x20001F8")]
	private sealed class NotBoolean : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A29")]
		public NotBoolean() { }

		[Address(RVA = "0x22A2E90", Offset = "0x22A2290", Length = "0x7B")]
		[Token(Token = "0x6000A28")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FF")]
	private sealed class NotByte : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A37")]
		public NotByte() { }

		[Address(RVA = "0x22A2F10", Offset = "0x22A2310", Length = "0x7A")]
		[Token(Token = "0x6000A36")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FB")]
	private sealed class NotInt16 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A2F")]
		public NotInt16() { }

		[Address(RVA = "0x22A5300", Offset = "0x22A4700", Length = "0x7B")]
		[Token(Token = "0x6000A2E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FA")]
	private sealed class NotInt32 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A2D")]
		public NotInt32() { }

		[Address(RVA = "0x22A5380", Offset = "0x22A4780", Length = "0x79")]
		[Token(Token = "0x6000A2C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001F9")]
	private sealed class NotInt64 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A2B")]
		public NotInt64() { }

		[Address(RVA = "0x22A5400", Offset = "0x22A4800", Length = "0x80")]
		[Token(Token = "0x6000A2A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000200")]
	private sealed class NotSByte : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A39")]
		public NotSByte() { }

		[Address(RVA = "0x22A5490", Offset = "0x22A4890", Length = "0x7A")]
		[Token(Token = "0x6000A38")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FE")]
	private sealed class NotUInt16 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A35")]
		public NotUInt16() { }

		[Address(RVA = "0x22A5510", Offset = "0x22A4910", Length = "0x7B")]
		[Token(Token = "0x6000A34")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FD")]
	private sealed class NotUInt32 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A33")]
		public NotUInt32() { }

		[Address(RVA = "0x22A5590", Offset = "0x22A4990", Length = "0x7D")]
		[Token(Token = "0x6000A32")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001FC")]
	private sealed class NotUInt64 : NotInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A31")]
		public NotUInt64() { }

		[Address(RVA = "0x22A5610", Offset = "0x22A4A10", Length = "0x80")]
		[Token(Token = "0x6000A30")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003BD")]
	public static Instruction s_Boolean; //Field offset: 0x0
	[Token(Token = "0x40003BE")]
	public static Instruction s_Int64; //Field offset: 0x8
	[Token(Token = "0x40003BF")]
	public static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x40003C0")]
	public static Instruction s_Int16; //Field offset: 0x18
	[Token(Token = "0x40003C1")]
	public static Instruction s_UInt64; //Field offset: 0x20
	[Token(Token = "0x40003C2")]
	public static Instruction s_UInt32; //Field offset: 0x28
	[Token(Token = "0x40003C3")]
	public static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x40003C4")]
	public static Instruction s_Byte; //Field offset: 0x38
	[Token(Token = "0x40003C5")]
	public static Instruction s_SByte; //Field offset: 0x40

	[Token(Token = "0x17000210")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A24")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000212")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A52D0", Offset = "0x22A46D0", Length = "0x2C")]
		[Token(Token = "0x6000A26")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000211")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A25")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A23")]
	private NotInstruction() { }

	[Address(RVA = "0x22A4DD0", Offset = "0x22A41D0", Length = "0x4D4")]
	[Token(Token = "0x6000A27")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A24")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A52D0", Offset = "0x22A46D0", Length = "0x2C")]
	[Token(Token = "0x6000A26")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A25")]
	public virtual int get_ProducedStack() { }

}

