namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200023A")]
internal abstract class CastInstruction : Instruction
{
	[Token(Token = "0x200023C")]
	private abstract class CastInstructionNoT : CastInstruction
	{
		[Token(Token = "0x200023D")]
		private sealed class Ref : CastInstructionNoT
		{

			[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
			[Token(Token = "0x6000AF9")]
			public Ref(Type t) { }

			[Address(RVA = "0x22A7C10", Offset = "0x22A7010", Length = "0x22")]
			[Token(Token = "0x6000AFA")]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		[Token(Token = "0x200023E")]
		private sealed class Value : CastInstructionNoT
		{

			[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
			[Token(Token = "0x6000AFB")]
			public Value(Type t) { }

			[Address(RVA = "0x22AD6B0", Offset = "0x22ACAB0", Length = "0x3E")]
			[Token(Token = "0x6000AFC")]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000408")]
		private readonly Type _t; //Field offset: 0x10

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x6000AF5")]
		protected CastInstructionNoT(Type t) { }

		[Token(Token = "0x6000AF8")]
		protected abstract void ConvertNull(InterpretedFrame frame) { }

		[Address(RVA = "0x2291D50", Offset = "0x2291150", Length = "0xBB")]
		[Token(Token = "0x6000AF6")]
		public static CastInstruction Create(Type t) { }

		[Address(RVA = "0x2291E10", Offset = "0x2291210", Length = "0x19E")]
		[Token(Token = "0x6000AF7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200023B")]
	private sealed class CastInstructionT : CastInstruction
	{

		[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
		[Token(Token = "0x6000AF4")]
		public CastInstructionT`1() { }

		[Address(RVA = "0x16C7750", Offset = "0x16C6B50", Length = "0xB4")]
		[Token(Token = "0x6000AF3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003F9")]
	private static CastInstruction s_Boolean; //Field offset: 0x0
	[Token(Token = "0x40003FA")]
	private static CastInstruction s_Byte; //Field offset: 0x8
	[Token(Token = "0x40003FB")]
	private static CastInstruction s_Char; //Field offset: 0x10
	[Token(Token = "0x40003FC")]
	private static CastInstruction s_DateTime; //Field offset: 0x18
	[Token(Token = "0x40003FD")]
	private static CastInstruction s_Decimal; //Field offset: 0x20
	[Token(Token = "0x40003FE")]
	private static CastInstruction s_Double; //Field offset: 0x28
	[Token(Token = "0x40003FF")]
	private static CastInstruction s_Int16; //Field offset: 0x30
	[Token(Token = "0x4000400")]
	private static CastInstruction s_Int32; //Field offset: 0x38
	[Token(Token = "0x4000401")]
	private static CastInstruction s_Int64; //Field offset: 0x40
	[Token(Token = "0x4000402")]
	private static CastInstruction s_SByte; //Field offset: 0x48
	[Token(Token = "0x4000403")]
	private static CastInstruction s_Single; //Field offset: 0x50
	[Token(Token = "0x4000404")]
	private static CastInstruction s_String; //Field offset: 0x58
	[Token(Token = "0x4000405")]
	private static CastInstruction s_UInt16; //Field offset: 0x60
	[Token(Token = "0x4000406")]
	private static CastInstruction s_UInt32; //Field offset: 0x68
	[Token(Token = "0x4000407")]
	private static CastInstruction s_UInt64; //Field offset: 0x70

	[Token(Token = "0x17000241")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AEE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000243")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2292840", Offset = "0x2291C40", Length = "0x2C")]
		[Token(Token = "0x6000AF0")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000242")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AEF")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000AF2")]
	protected CastInstruction() { }

	[Address(RVA = "0x2291FB0", Offset = "0x22913B0", Length = "0x850")]
	[Token(Token = "0x6000AF1")]
	public static Instruction Create(Type t) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AEE")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2292840", Offset = "0x2291C40", Length = "0x2C")]
	[Token(Token = "0x6000AF0")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AEF")]
	public virtual int get_ProducedStack() { }

}

