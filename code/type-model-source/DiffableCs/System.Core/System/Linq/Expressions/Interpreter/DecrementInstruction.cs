namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000FF")]
internal abstract class DecrementInstruction : Instruction
{
	[Token(Token = "0x2000107")]
	private sealed class DecrementDouble : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000668")]
		public DecrementDouble() { }

		[Address(RVA = "0x2255DF0", Offset = "0x22551F0", Length = "0x87")]
		[Token(Token = "0x6000667")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000100")]
	private sealed class DecrementInt16 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600065A")]
		public DecrementInt16() { }

		[Address(RVA = "0x2256330", Offset = "0x2255730", Length = "0x7B")]
		[Token(Token = "0x6000659")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000101")]
	private sealed class DecrementInt32 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600065C")]
		public DecrementInt32() { }

		[Address(RVA = "0x22563B0", Offset = "0x22557B0", Length = "0x79")]
		[Token(Token = "0x600065B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000102")]
	private sealed class DecrementInt64 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600065E")]
		public DecrementInt64() { }

		[Address(RVA = "0x2256430", Offset = "0x2255830", Length = "0x80")]
		[Token(Token = "0x600065D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000106")]
	private sealed class DecrementSingle : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000666")]
		public DecrementSingle() { }

		[Address(RVA = "0x22564C0", Offset = "0x22558C0", Length = "0x87")]
		[Token(Token = "0x6000665")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000103")]
	private sealed class DecrementUInt16 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000660")]
		public DecrementUInt16() { }

		[Address(RVA = "0x2256550", Offset = "0x2255950", Length = "0x7B")]
		[Token(Token = "0x600065F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000104")]
	private sealed class DecrementUInt32 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000662")]
		public DecrementUInt32() { }

		[Address(RVA = "0x22565D0", Offset = "0x22559D0", Length = "0x7D")]
		[Token(Token = "0x6000661")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000105")]
	private sealed class DecrementUInt64 : DecrementInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000664")]
		public DecrementUInt64() { }

		[Address(RVA = "0x2256650", Offset = "0x2255A50", Length = "0x80")]
		[Token(Token = "0x6000663")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400023E")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x400023F")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x4000240")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x4000241")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x4000242")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x4000243")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x4000244")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x4000245")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x1700018C")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000654")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700018E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2256300", Offset = "0x2255700", Length = "0x2C")]
		[Token(Token = "0x6000656")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700018D")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000655")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000657")]
	private DecrementInstruction() { }

	[Address(RVA = "0x2255E80", Offset = "0x2255280", Length = "0x460")]
	[Token(Token = "0x6000658")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000654")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2256300", Offset = "0x2255700", Length = "0x2C")]
	[Token(Token = "0x6000656")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000655")]
	public virtual int get_ProducedStack() { }

}

