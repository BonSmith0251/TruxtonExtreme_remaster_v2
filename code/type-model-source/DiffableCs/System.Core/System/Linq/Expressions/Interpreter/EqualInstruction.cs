namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000112")]
internal abstract class EqualInstruction : Instruction
{
	[Token(Token = "0x2000113")]
	private sealed class EqualBoolean : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000689")]
		public EqualBoolean() { }

		[Address(RVA = "0x22588B0", Offset = "0x2257CB0", Length = "0xBB")]
		[Token(Token = "0x6000688")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000120")]
	private sealed class EqualBooleanLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006A3")]
		public EqualBooleanLiftedToNull() { }

		[Address(RVA = "0x22587E0", Offset = "0x2257BE0", Length = "0xC1")]
		[Token(Token = "0x60006A2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000119")]
	private sealed class EqualByte : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000695")]
		public EqualByte() { }

		[Address(RVA = "0x2258A40", Offset = "0x2257E40", Length = "0xBB")]
		[Token(Token = "0x6000694")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000126")]
	private sealed class EqualByteLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006AF")]
		public EqualByteLiftedToNull() { }

		[Address(RVA = "0x2258970", Offset = "0x2257D70", Length = "0xC1")]
		[Token(Token = "0x60006AE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000116")]
	private sealed class EqualChar : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600068F")]
		public EqualChar() { }

		[Address(RVA = "0x2258BD0", Offset = "0x2257FD0", Length = "0xBB")]
		[Token(Token = "0x600068E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000123")]
	private sealed class EqualCharLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006A9")]
		public EqualCharLiftedToNull() { }

		[Address(RVA = "0x2258B00", Offset = "0x2257F00", Length = "0xC1")]
		[Token(Token = "0x60006A8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011E")]
	private sealed class EqualDouble : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600069F")]
		public EqualDouble() { }

		[Address(RVA = "0x2258D70", Offset = "0x2258170", Length = "0xC9")]
		[Token(Token = "0x600069E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012B")]
	private sealed class EqualDoubleLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006B9")]
		public EqualDoubleLiftedToNull() { }

		[Address(RVA = "0x2258C90", Offset = "0x2258090", Length = "0xDB")]
		[Token(Token = "0x60006B8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000115")]
	private sealed class EqualInt16 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600068D")]
		public EqualInt16() { }

		[Address(RVA = "0x2259B40", Offset = "0x2258F40", Length = "0xBB")]
		[Token(Token = "0x600068C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000122")]
	private sealed class EqualInt16LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006A7")]
		public EqualInt16LiftedToNull() { }

		[Address(RVA = "0x2259A70", Offset = "0x2258E70", Length = "0xC1")]
		[Token(Token = "0x60006A6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000117")]
	private sealed class EqualInt32 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000691")]
		public EqualInt32() { }

		[Address(RVA = "0x2259CC0", Offset = "0x22590C0", Length = "0xB9")]
		[Token(Token = "0x6000690")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000124")]
	private sealed class EqualInt32LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006AB")]
		public EqualInt32LiftedToNull() { }

		[Address(RVA = "0x2259C00", Offset = "0x2259000", Length = "0xBF")]
		[Token(Token = "0x60006AA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000118")]
	private sealed class EqualInt64 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000693")]
		public EqualInt64() { }

		[Address(RVA = "0x2259E50", Offset = "0x2259250", Length = "0xBB")]
		[Token(Token = "0x6000692")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000125")]
	private sealed class EqualInt64LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006AD")]
		public EqualInt64LiftedToNull() { }

		[Address(RVA = "0x2259D80", Offset = "0x2259180", Length = "0xC1")]
		[Token(Token = "0x60006AC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011F")]
	private sealed class EqualReference : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006A1")]
		public EqualReference() { }

		[Address(RVA = "0x2259F10", Offset = "0x2259310", Length = "0x50")]
		[Token(Token = "0x60006A0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000114")]
	private sealed class EqualSByte : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600068B")]
		public EqualSByte() { }

		[Address(RVA = "0x225A040", Offset = "0x2259440", Length = "0xBB")]
		[Token(Token = "0x600068A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000121")]
	private sealed class EqualSByteLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006A5")]
		public EqualSByteLiftedToNull() { }

		[Address(RVA = "0x2259F70", Offset = "0x2259370", Length = "0xC1")]
		[Token(Token = "0x60006A4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011D")]
	private sealed class EqualSingle : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600069D")]
		public EqualSingle() { }

		[Address(RVA = "0x225A1E0", Offset = "0x22595E0", Length = "0xC8")]
		[Token(Token = "0x600069C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200012A")]
	private sealed class EqualSingleLiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006B7")]
		public EqualSingleLiftedToNull() { }

		[Address(RVA = "0x225A100", Offset = "0x2259500", Length = "0xDA")]
		[Token(Token = "0x60006B6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011A")]
	private sealed class EqualUInt16 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000697")]
		public EqualUInt16() { }

		[Address(RVA = "0x225A380", Offset = "0x2259780", Length = "0xBB")]
		[Token(Token = "0x6000696")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000127")]
	private sealed class EqualUInt16LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006B1")]
		public EqualUInt16LiftedToNull() { }

		[Address(RVA = "0x225A2B0", Offset = "0x22596B0", Length = "0xC1")]
		[Token(Token = "0x60006B0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011B")]
	private sealed class EqualUInt32 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000699")]
		public EqualUInt32() { }

		[Address(RVA = "0x225A500", Offset = "0x2259900", Length = "0xB9")]
		[Token(Token = "0x6000698")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000128")]
	private sealed class EqualUInt32LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006B3")]
		public EqualUInt32LiftedToNull() { }

		[Address(RVA = "0x225A440", Offset = "0x2259840", Length = "0xBF")]
		[Token(Token = "0x60006B2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200011C")]
	private sealed class EqualUInt64 : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600069B")]
		public EqualUInt64() { }

		[Address(RVA = "0x225A690", Offset = "0x2259A90", Length = "0xBB")]
		[Token(Token = "0x600069A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000129")]
	private sealed class EqualUInt64LiftedToNull : EqualInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006B5")]
		public EqualUInt64LiftedToNull() { }

		[Address(RVA = "0x225A5C0", Offset = "0x22599C0", Length = "0xC1")]
		[Token(Token = "0x60006B4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400024F")]
	private static Instruction s_reference; //Field offset: 0x0
	[Token(Token = "0x4000250")]
	private static Instruction s_Boolean; //Field offset: 0x8
	[Token(Token = "0x4000251")]
	private static Instruction s_SByte; //Field offset: 0x10
	[Token(Token = "0x4000252")]
	private static Instruction s_Int16; //Field offset: 0x18
	[Token(Token = "0x4000253")]
	private static Instruction s_Char; //Field offset: 0x20
	[Token(Token = "0x4000254")]
	private static Instruction s_Int32; //Field offset: 0x28
	[Token(Token = "0x4000255")]
	private static Instruction s_Int64; //Field offset: 0x30
	[Token(Token = "0x4000256")]
	private static Instruction s_Byte; //Field offset: 0x38
	[Token(Token = "0x4000257")]
	private static Instruction s_UInt16; //Field offset: 0x40
	[Token(Token = "0x4000258")]
	private static Instruction s_UInt32; //Field offset: 0x48
	[Token(Token = "0x4000259")]
	private static Instruction s_UInt64; //Field offset: 0x50
	[Token(Token = "0x400025A")]
	private static Instruction s_Single; //Field offset: 0x58
	[Token(Token = "0x400025B")]
	private static Instruction s_Double; //Field offset: 0x60
	[Token(Token = "0x400025C")]
	private static Instruction s_BooleanLiftedToNull; //Field offset: 0x68
	[Token(Token = "0x400025D")]
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x70
	[Token(Token = "0x400025E")]
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x78
	[Token(Token = "0x400025F")]
	private static Instruction s_CharLiftedToNull; //Field offset: 0x80
	[Token(Token = "0x4000260")]
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x88
	[Token(Token = "0x4000261")]
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x90
	[Token(Token = "0x4000262")]
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x98
	[Token(Token = "0x4000263")]
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0xA0
	[Token(Token = "0x4000264")]
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0xA8
	[Token(Token = "0x4000265")]
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0xB0
	[Token(Token = "0x4000266")]
	private static Instruction s_SingleLiftedToNull; //Field offset: 0xB8
	[Token(Token = "0x4000267")]
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0xC0

	[Token(Token = "0x17000194")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000683")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000196")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2259A40", Offset = "0x2258E40", Length = "0x2C")]
		[Token(Token = "0x6000685")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000195")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000684")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000686")]
	private EqualInstruction() { }

	[Address(RVA = "0x2258E40", Offset = "0x2258240", Length = "0x6E4")]
	[Token(Token = "0x6000687")]
	public static Instruction Create(Type type, bool liftedToNull) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000683")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2259A40", Offset = "0x2258E40", Length = "0x2C")]
	[Token(Token = "0x6000685")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000684")]
	public virtual int get_ProducedStack() { }

}

