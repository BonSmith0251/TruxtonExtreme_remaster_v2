namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001B9")]
internal abstract class ModuloInstruction : Instruction
{
	[Token(Token = "0x20001C1")]
	private sealed class ModuloDouble : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009A3")]
		public ModuloDouble() { }

		[Address(RVA = "0x229E960", Offset = "0x229DD60", Length = "0x15D")]
		[Token(Token = "0x60009A2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BA")]
	private sealed class ModuloInt16 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000995")]
		public ModuloInt16() { }

		[Address(RVA = "0x229EF70", Offset = "0x229E370", Length = "0x158")]
		[Token(Token = "0x6000994")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BB")]
	private sealed class ModuloInt32 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000997")]
		public ModuloInt32() { }

		[Address(RVA = "0x229F0D0", Offset = "0x229E4D0", Length = "0x159")]
		[Token(Token = "0x6000996")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BC")]
	private sealed class ModuloInt64 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000999")]
		public ModuloInt64() { }

		[Address(RVA = "0x229F230", Offset = "0x229E630", Length = "0x159")]
		[Token(Token = "0x6000998")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001C0")]
	private sealed class ModuloSingle : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60009A1")]
		public ModuloSingle() { }

		[Address(RVA = "0x229F390", Offset = "0x229E790", Length = "0x15D")]
		[Token(Token = "0x60009A0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BD")]
	private sealed class ModuloUInt16 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600099B")]
		public ModuloUInt16() { }

		[Address(RVA = "0x229F4F0", Offset = "0x229E8F0", Length = "0x159")]
		[Token(Token = "0x600099A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BE")]
	private sealed class ModuloUInt32 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600099D")]
		public ModuloUInt32() { }

		[Address(RVA = "0x229F650", Offset = "0x229EA50", Length = "0x157")]
		[Token(Token = "0x600099C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20001BF")]
	private sealed class ModuloUInt64 : ModuloInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600099F")]
		public ModuloUInt64() { }

		[Address(RVA = "0x229F7B0", Offset = "0x229EBB0", Length = "0x159")]
		[Token(Token = "0x600099E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000384")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x4000385")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x4000386")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x4000387")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x4000388")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x4000389")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x400038A")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x400038B")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x170001FA")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600098F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001FC")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229EF40", Offset = "0x229E340", Length = "0x2C")]
		[Token(Token = "0x6000991")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001FB")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000990")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000992")]
	private ModuloInstruction() { }

	[Address(RVA = "0x229EAC0", Offset = "0x229DEC0", Length = "0x460")]
	[Token(Token = "0x6000993")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600098F")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x229EF40", Offset = "0x229E340", Length = "0x2C")]
	[Token(Token = "0x6000991")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000990")]
	public virtual int get_ProducedStack() { }

}

