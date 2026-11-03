namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001C2")]
internal abstract class MulInstruction : Instruction
{
	[Token(Token = "0x20001CA")]
	private sealed class MulDouble : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009B8")]
		public MulDouble() { }

		[Address(RVA = "0x229F910", Offset = "0x229ED10", Length = "0x15E")]
		[Token(Token = "0x60009B7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C3")]
	private sealed class MulInt16 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009AA")]
		public MulInt16() { }

		[Address(RVA = "0x229FF20", Offset = "0x229F320", Length = "0x156")]
		[Token(Token = "0x60009A9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C4")]
	private sealed class MulInt32 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009AC")]
		public MulInt32() { }

		[Address(RVA = "0x22A0080", Offset = "0x229F480", Length = "0x14E")]
		[Token(Token = "0x60009AB")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C5")]
	private sealed class MulInt64 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009AE")]
		public MulInt64() { }

		[Address(RVA = "0x22A01D0", Offset = "0x229F5D0", Length = "0x152")]
		[Token(Token = "0x60009AD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C9")]
	private sealed class MulSingle : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009B6")]
		public MulSingle() { }

		[Address(RVA = "0x22A15E0", Offset = "0x22A09E0", Length = "0x15E")]
		[Token(Token = "0x60009B5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C6")]
	private sealed class MulUInt16 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009B0")]
		public MulUInt16() { }

		[Address(RVA = "0x22A1740", Offset = "0x22A0B40", Length = "0x156")]
		[Token(Token = "0x60009AF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C7")]
	private sealed class MulUInt32 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009B2")]
		public MulUInt32() { }

		[Address(RVA = "0x22A18A0", Offset = "0x22A0CA0", Length = "0x152")]
		[Token(Token = "0x60009B1")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C8")]
	private sealed class MulUInt64 : MulInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009B4")]
		public MulUInt64() { }

		[Address(RVA = "0x22A1A00", Offset = "0x22A0E00", Length = "0x152")]
		[Token(Token = "0x60009B3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400038C")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x400038D")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x400038E")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x400038F")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x4000390")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x4000391")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x4000392")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x4000393")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x170001FD")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60009A4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001FF")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229FEF0", Offset = "0x229F2F0", Length = "0x2C")]
		[Token(Token = "0x60009A6")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001FE")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60009A5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009A7")]
	private MulInstruction() { }

	[Address(RVA = "0x229FA70", Offset = "0x229EE70", Length = "0x460")]
	[Token(Token = "0x60009A8")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60009A4")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x229FEF0", Offset = "0x229F2F0", Length = "0x2C")]
	[Token(Token = "0x60009A6")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60009A5")]
	public virtual int get_ProducedStack() { }

}

