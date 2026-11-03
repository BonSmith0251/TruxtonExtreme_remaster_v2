namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200017E")]
internal abstract class LessThanOrEqualInstruction : Instruction
{
	[Token(Token = "0x2000184")]
	private sealed class LessThanOrEqualByte : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000833")]
		public LessThanOrEqualByte(object nullValue) { }

		[Address(RVA = "0x227DF60", Offset = "0x227D360", Length = "0x165")]
		[Token(Token = "0x6000834")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000181")]
	private sealed class LessThanOrEqualChar : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600082D")]
		public LessThanOrEqualChar(object nullValue) { }

		[Address(RVA = "0x227E0D0", Offset = "0x227D4D0", Length = "0x165")]
		[Token(Token = "0x600082E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000189")]
	private sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600083D")]
		public LessThanOrEqualDouble(object nullValue) { }

		[Address(RVA = "0x227E240", Offset = "0x227D640", Length = "0x175")]
		[Token(Token = "0x600083E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000180")]
	private sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600082B")]
		public LessThanOrEqualInt16(object nullValue) { }

		[Address(RVA = "0x227F250", Offset = "0x227E650", Length = "0x165")]
		[Token(Token = "0x600082C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000182")]
	private sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600082F")]
		public LessThanOrEqualInt32(object nullValue) { }

		[Address(RVA = "0x227F3C0", Offset = "0x227E7C0", Length = "0x163")]
		[Token(Token = "0x6000830")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000183")]
	private sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000831")]
		public LessThanOrEqualInt64(object nullValue) { }

		[Address(RVA = "0x227F530", Offset = "0x227E930", Length = "0x165")]
		[Token(Token = "0x6000832")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200017F")]
	private sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000829")]
		public LessThanOrEqualSByte(object nullValue) { }

		[Address(RVA = "0x227F6A0", Offset = "0x227EAA0", Length = "0x165")]
		[Token(Token = "0x600082A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000188")]
	private sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600083B")]
		public LessThanOrEqualSingle(object nullValue) { }

		[Address(RVA = "0x227F810", Offset = "0x227EC10", Length = "0x174")]
		[Token(Token = "0x600083C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000185")]
	private sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000835")]
		public LessThanOrEqualUInt16(object nullValue) { }

		[Address(RVA = "0x227F990", Offset = "0x227ED90", Length = "0x165")]
		[Token(Token = "0x6000836")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000186")]
	private sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000837")]
		public LessThanOrEqualUInt32(object nullValue) { }

		[Address(RVA = "0x227FB00", Offset = "0x227EF00", Length = "0x163")]
		[Token(Token = "0x6000838")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000187")]
	private sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000839")]
		public LessThanOrEqualUInt64(object nullValue) { }

		[Address(RVA = "0x227FC70", Offset = "0x227F070", Length = "0x165")]
		[Token(Token = "0x600083A")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000319")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x400031A")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x400031B")]
	private static Instruction s_Char; //Field offset: 0x10
	[Token(Token = "0x400031C")]
	private static Instruction s_Int32; //Field offset: 0x18
	[Token(Token = "0x400031D")]
	private static Instruction s_Int64; //Field offset: 0x20
	[Token(Token = "0x400031E")]
	private static Instruction s_Byte; //Field offset: 0x28
	[Token(Token = "0x400031F")]
	private static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x4000320")]
	private static Instruction s_UInt32; //Field offset: 0x38
	[Token(Token = "0x4000321")]
	private static Instruction s_UInt64; //Field offset: 0x40
	[Token(Token = "0x4000322")]
	private static Instruction s_Single; //Field offset: 0x48
	[Token(Token = "0x4000323")]
	private static Instruction s_Double; //Field offset: 0x50
	[Token(Token = "0x4000324")]
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	[Token(Token = "0x4000325")]
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	[Token(Token = "0x4000326")]
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	[Token(Token = "0x4000327")]
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	[Token(Token = "0x4000328")]
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	[Token(Token = "0x4000329")]
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	[Token(Token = "0x400032A")]
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	[Token(Token = "0x400032B")]
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	[Token(Token = "0x400032C")]
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	[Token(Token = "0x400032D")]
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	[Token(Token = "0x400032E")]
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000318")]
	private readonly object _nullValue; //Field offset: 0x10

	[Token(Token = "0x170001C8")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000824")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001CA")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x227F220", Offset = "0x227E620", Length = "0x2C")]
		[Token(Token = "0x6000826")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001C9")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000825")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000827")]
	private LessThanOrEqualInstruction(object nullValue) { }

	[Address(RVA = "0x227E3C0", Offset = "0x227D7C0", Length = "0xE00")]
	[Token(Token = "0x6000828")]
	public static Instruction Create(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000824")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x227F220", Offset = "0x227E620", Length = "0x2C")]
	[Token(Token = "0x6000826")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000825")]
	public virtual int get_ProducedStack() { }

}

