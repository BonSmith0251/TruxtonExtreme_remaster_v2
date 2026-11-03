namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000147")]
internal abstract class GreaterThanOrEqualInstruction : Instruction
{
	[Token(Token = "0x200014D")]
	private sealed class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600070E")]
		public GreaterThanOrEqualByte(object nullValue) { }

		[Address(RVA = "0x2270EB0", Offset = "0x22702B0", Length = "0x165")]
		[Token(Token = "0x600070F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200014A")]
	private sealed class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000708")]
		public GreaterThanOrEqualChar(object nullValue) { }

		[Address(RVA = "0x2271020", Offset = "0x2270420", Length = "0x165")]
		[Token(Token = "0x6000709")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000152")]
	private sealed class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000718")]
		public GreaterThanOrEqualDouble(object nullValue) { }

		[Address(RVA = "0x2271190", Offset = "0x2270590", Length = "0x171")]
		[Token(Token = "0x6000719")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000149")]
	private sealed class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000706")]
		public GreaterThanOrEqualInt16(object nullValue) { }

		[Address(RVA = "0x22721A0", Offset = "0x22715A0", Length = "0x165")]
		[Token(Token = "0x6000707")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200014B")]
	private sealed class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600070A")]
		public GreaterThanOrEqualInt32(object nullValue) { }

		[Address(RVA = "0x2272310", Offset = "0x2271710", Length = "0x163")]
		[Token(Token = "0x600070B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200014C")]
	private sealed class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600070C")]
		public GreaterThanOrEqualInt64(object nullValue) { }

		[Address(RVA = "0x2272480", Offset = "0x2271880", Length = "0x165")]
		[Token(Token = "0x600070D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000148")]
	private sealed class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000704")]
		public GreaterThanOrEqualSByte(object nullValue) { }

		[Address(RVA = "0x22725F0", Offset = "0x22719F0", Length = "0x165")]
		[Token(Token = "0x6000705")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000151")]
	private sealed class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000716")]
		public GreaterThanOrEqualSingle(object nullValue) { }

		[Address(RVA = "0x2272760", Offset = "0x2271B60", Length = "0x170")]
		[Token(Token = "0x6000717")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200014E")]
	private sealed class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000710")]
		public GreaterThanOrEqualUInt16(object nullValue) { }

		[Address(RVA = "0x22728E0", Offset = "0x2271CE0", Length = "0x165")]
		[Token(Token = "0x6000711")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200014F")]
	private sealed class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000712")]
		public GreaterThanOrEqualUInt32(object nullValue) { }

		[Address(RVA = "0x2272A50", Offset = "0x2271E50", Length = "0x163")]
		[Token(Token = "0x6000713")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000150")]
	private sealed class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000714")]
		public GreaterThanOrEqualUInt64(object nullValue) { }

		[Address(RVA = "0x2272BC0", Offset = "0x2271FC0", Length = "0x165")]
		[Token(Token = "0x6000715")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x400028A")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x400028B")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x400028C")]
	private static Instruction s_Char; //Field offset: 0x10
	[Token(Token = "0x400028D")]
	private static Instruction s_Int32; //Field offset: 0x18
	[Token(Token = "0x400028E")]
	private static Instruction s_Int64; //Field offset: 0x20
	[Token(Token = "0x400028F")]
	private static Instruction s_Byte; //Field offset: 0x28
	[Token(Token = "0x4000290")]
	private static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x4000291")]
	private static Instruction s_UInt32; //Field offset: 0x38
	[Token(Token = "0x4000292")]
	private static Instruction s_UInt64; //Field offset: 0x40
	[Token(Token = "0x4000293")]
	private static Instruction s_Single; //Field offset: 0x48
	[Token(Token = "0x4000294")]
	private static Instruction s_Double; //Field offset: 0x50
	[Token(Token = "0x4000295")]
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	[Token(Token = "0x4000296")]
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	[Token(Token = "0x4000297")]
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	[Token(Token = "0x4000298")]
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	[Token(Token = "0x4000299")]
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	[Token(Token = "0x400029A")]
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	[Token(Token = "0x400029B")]
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	[Token(Token = "0x400029C")]
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	[Token(Token = "0x400029D")]
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	[Token(Token = "0x400029E")]
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	[Token(Token = "0x400029F")]
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000289")]
	private readonly object _nullValue; //Field offset: 0x10

	[Token(Token = "0x170001A6")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60006FF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A8")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2272170", Offset = "0x2271570", Length = "0x2C")]
		[Token(Token = "0x6000701")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001A7")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000700")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000702")]
	private GreaterThanOrEqualInstruction(object nullValue) { }

	[Address(RVA = "0x2271310", Offset = "0x2270710", Length = "0xE00")]
	[Token(Token = "0x6000703")]
	public static Instruction Create(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60006FF")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2272170", Offset = "0x2271570", Length = "0x2C")]
	[Token(Token = "0x6000701")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000700")]
	public virtual int get_ProducedStack() { }

}

