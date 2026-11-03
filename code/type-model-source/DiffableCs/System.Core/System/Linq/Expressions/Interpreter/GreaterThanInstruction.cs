namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200013B")]
internal abstract class GreaterThanInstruction : Instruction
{
	[Token(Token = "0x2000141")]
	private sealed class GreaterThanByte : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006F3")]
		public GreaterThanByte(object nullValue) { }

		[Address(RVA = "0x226F770", Offset = "0x226EB70", Length = "0x165")]
		[Token(Token = "0x60006F4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200013E")]
	private sealed class GreaterThanChar : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006ED")]
		public GreaterThanChar(object nullValue) { }

		[Address(RVA = "0x226F8E0", Offset = "0x226ECE0", Length = "0x165")]
		[Token(Token = "0x60006EE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000146")]
	private sealed class GreaterThanDouble : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006FD")]
		public GreaterThanDouble(object nullValue) { }

		[Address(RVA = "0x226FA50", Offset = "0x226EE50", Length = "0x171")]
		[Token(Token = "0x60006FE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200013D")]
	private sealed class GreaterThanInt16 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006EB")]
		public GreaterThanInt16(object nullValue) { }

		[Address(RVA = "0x2270A60", Offset = "0x226FE60", Length = "0x165")]
		[Token(Token = "0x60006EC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200013F")]
	private sealed class GreaterThanInt32 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006EF")]
		public GreaterThanInt32(object nullValue) { }

		[Address(RVA = "0x2270BD0", Offset = "0x226FFD0", Length = "0x163")]
		[Token(Token = "0x60006F0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000140")]
	private sealed class GreaterThanInt64 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006F1")]
		public GreaterThanInt64(object nullValue) { }

		[Address(RVA = "0x2270D40", Offset = "0x2270140", Length = "0x165")]
		[Token(Token = "0x60006F2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200013C")]
	private sealed class GreaterThanSByte : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006E9")]
		public GreaterThanSByte(object nullValue) { }

		[Address(RVA = "0x2272D30", Offset = "0x2272130", Length = "0x165")]
		[Token(Token = "0x60006EA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000145")]
	private sealed class GreaterThanSingle : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006FB")]
		public GreaterThanSingle(object nullValue) { }

		[Address(RVA = "0x2272EA0", Offset = "0x22722A0", Length = "0x170")]
		[Token(Token = "0x60006FC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000142")]
	private sealed class GreaterThanUInt16 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006F5")]
		public GreaterThanUInt16(object nullValue) { }

		[Address(RVA = "0x2273020", Offset = "0x2272420", Length = "0x165")]
		[Token(Token = "0x60006F6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000143")]
	private sealed class GreaterThanUInt32 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006F7")]
		public GreaterThanUInt32(object nullValue) { }

		[Address(RVA = "0x2273190", Offset = "0x2272590", Length = "0x163")]
		[Token(Token = "0x60006F8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000144")]
	private sealed class GreaterThanUInt64 : GreaterThanInstruction
	{

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x60006F9")]
		public GreaterThanUInt64(object nullValue) { }

		[Address(RVA = "0x2273300", Offset = "0x2272700", Length = "0x165")]
		[Token(Token = "0x60006FA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x4000273")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x4000274")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x4000275")]
	private static Instruction s_Char; //Field offset: 0x10
	[Token(Token = "0x4000276")]
	private static Instruction s_Int32; //Field offset: 0x18
	[Token(Token = "0x4000277")]
	private static Instruction s_Int64; //Field offset: 0x20
	[Token(Token = "0x4000278")]
	private static Instruction s_Byte; //Field offset: 0x28
	[Token(Token = "0x4000279")]
	private static Instruction s_UInt16; //Field offset: 0x30
	[Token(Token = "0x400027A")]
	private static Instruction s_UInt32; //Field offset: 0x38
	[Token(Token = "0x400027B")]
	private static Instruction s_UInt64; //Field offset: 0x40
	[Token(Token = "0x400027C")]
	private static Instruction s_Single; //Field offset: 0x48
	[Token(Token = "0x400027D")]
	private static Instruction s_Double; //Field offset: 0x50
	[Token(Token = "0x400027E")]
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	[Token(Token = "0x400027F")]
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	[Token(Token = "0x4000280")]
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	[Token(Token = "0x4000281")]
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	[Token(Token = "0x4000282")]
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	[Token(Token = "0x4000283")]
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	[Token(Token = "0x4000284")]
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	[Token(Token = "0x4000285")]
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	[Token(Token = "0x4000286")]
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	[Token(Token = "0x4000287")]
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	[Token(Token = "0x4000288")]
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000272")]
	private readonly object _nullValue; //Field offset: 0x10

	[Token(Token = "0x170001A3")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A5")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2270A30", Offset = "0x226FE30", Length = "0x2C")]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001A4")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006E7")]
	private GreaterThanInstruction(object nullValue) { }

	[Address(RVA = "0x226FBD0", Offset = "0x226EFD0", Length = "0xE00")]
	[Token(Token = "0x60006E8")]
	public static Instruction Create(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60006E4")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2270A30", Offset = "0x226FE30", Length = "0x2C")]
	[Token(Token = "0x60006E6")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006E5")]
	public virtual int get_ProducedStack() { }

}

