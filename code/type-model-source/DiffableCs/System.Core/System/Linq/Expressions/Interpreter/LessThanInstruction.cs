namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000172")]
internal abstract class LessThanInstruction : Instruction
{
	[Token(Token = "0x2000178")]
	private sealed class LessThanByte : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000818")]
		public LessThanByte(object nullValue) { }

		[Address(RVA = "0x227C820", Offset = "0x227BC20", Length = "0x165")]
		[Token(Token = "0x6000819")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000175")]
	private sealed class LessThanChar : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000812")]
		public LessThanChar(object nullValue) { }

		[Address(RVA = "0x227C990", Offset = "0x227BD90", Length = "0x165")]
		[Token(Token = "0x6000813")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200017D")]
	private sealed class LessThanDouble : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000822")]
		public LessThanDouble(object nullValue) { }

		[Address(RVA = "0x227CB00", Offset = "0x227BF00", Length = "0x175")]
		[Token(Token = "0x6000823")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000174")]
	private sealed class LessThanInt16 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000810")]
		public LessThanInt16(object nullValue) { }

		[Address(RVA = "0x227DB10", Offset = "0x227CF10", Length = "0x165")]
		[Token(Token = "0x6000811")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000176")]
	private sealed class LessThanInt32 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000814")]
		public LessThanInt32(object nullValue) { }

		[Address(RVA = "0x227DC80", Offset = "0x227D080", Length = "0x163")]
		[Token(Token = "0x6000815")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000177")]
	private sealed class LessThanInt64 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000816")]
		public LessThanInt64(object nullValue) { }

		[Address(RVA = "0x227DDF0", Offset = "0x227D1F0", Length = "0x165")]
		[Token(Token = "0x6000817")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000173")]
	private sealed class LessThanSByte : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600080E")]
		public LessThanSByte(object nullValue) { }

		[Address(RVA = "0x227FDE0", Offset = "0x227F1E0", Length = "0x165")]
		[Token(Token = "0x600080F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200017C")]
	private sealed class LessThanSingle : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000820")]
		public LessThanSingle(object nullValue) { }

		[Address(RVA = "0x227FF50", Offset = "0x227F350", Length = "0x174")]
		[Token(Token = "0x6000821")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000179")]
	private sealed class LessThanUInt16 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600081A")]
		public LessThanUInt16(object nullValue) { }

		[Address(RVA = "0x22800D0", Offset = "0x227F4D0", Length = "0x165")]
		[Token(Token = "0x600081B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200017A")]
	private sealed class LessThanUInt32 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600081C")]
		public LessThanUInt32(object nullValue) { }

		[Address(RVA = "0x2280240", Offset = "0x227F640", Length = "0x163")]
		[Token(Token = "0x600081D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200017B")]
	private sealed class LessThanUInt64 : LessThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600081E")]
		public LessThanUInt64(object nullValue) { }

		[Address(RVA = "0x22803B0", Offset = "0x227F7B0", Length = "0x165")]
		[Token(Token = "0x600081F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000302")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x4000303")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x4000304")]
	private static Instruction s_Char; //Field offset: 0x10
	[Token(Token = "0x4000305")]
	private static Instruction s_Int32; //Field offset: 0x18
	[Token(Token = "0x4000306")]
	private static Instruction s_Int64; //Field offset: 0x20
	[Token(Token = "0x4000307")]
	private static Instruction s_Byte; //Field offset: 0x28
	[Token(Token = "0x4000308")]
	private static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x4000309")]
	private static Instruction s_UInt32; //Field offset: 0x38
	[Token(Token = "0x400030A")]
	private static Instruction s_UInt64; //Field offset: 0x40
	[Token(Token = "0x400030B")]
	private static Instruction s_Single; //Field offset: 0x48
	[Token(Token = "0x400030C")]
	private static Instruction s_Double; //Field offset: 0x50
	[Token(Token = "0x400030D")]
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	[Token(Token = "0x400030E")]
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	[Token(Token = "0x400030F")]
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	[Token(Token = "0x4000310")]
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	[Token(Token = "0x4000311")]
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	[Token(Token = "0x4000312")]
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	[Token(Token = "0x4000313")]
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	[Token(Token = "0x4000314")]
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	[Token(Token = "0x4000315")]
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	[Token(Token = "0x4000316")]
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	[Token(Token = "0x4000317")]
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000301")]
	private readonly object _nullValue; //Field offset: 0x10

	[Token(Token = "0x170001C5")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000809")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001C7")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x227DAE0", Offset = "0x227CEE0", Length = "0x2C")]
		[Token(Token = "0x600080B")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001C6")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600080A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600080C")]
	private LessThanInstruction(object nullValue) { }

	[Address(RVA = "0x227CC80", Offset = "0x227C080", Length = "0xE00")]
	[Token(Token = "0x600080D")]
	public static Instruction Create(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000809")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x227DAE0", Offset = "0x227CEE0", Length = "0x2C")]
	[Token(Token = "0x600080B")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600080A")]
	public virtual int get_ProducedStack() { }

}

