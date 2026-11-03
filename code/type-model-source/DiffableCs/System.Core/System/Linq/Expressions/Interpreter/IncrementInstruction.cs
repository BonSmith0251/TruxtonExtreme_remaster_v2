namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000153")]
internal abstract class IncrementInstruction : Instruction
{
	[Token(Token = "0x200015B")]
	private sealed class IncrementDouble : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600072E")]
		public IncrementDouble() { }

		[Address(RVA = "0x2273470", Offset = "0x2272870", Length = "0x157")]
		[Token(Token = "0x600072D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000154")]
	private sealed class IncrementInt16 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000720")]
		public IncrementInt16() { }

		[Address(RVA = "0x2273A80", Offset = "0x2272E80", Length = "0x146")]
		[Token(Token = "0x600071F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000155")]
	private sealed class IncrementInt32 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000722")]
		public IncrementInt32() { }

		[Address(RVA = "0x2273BD0", Offset = "0x2272FD0", Length = "0x11D")]
		[Token(Token = "0x6000721")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000156")]
	private sealed class IncrementInt64 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000724")]
		public IncrementInt64() { }

		[Address(RVA = "0x2273CF0", Offset = "0x22730F0", Length = "0x150")]
		[Token(Token = "0x6000723")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200015A")]
	private sealed class IncrementSingle : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600072C")]
		public IncrementSingle() { }

		[Address(RVA = "0x2273E50", Offset = "0x2273250", Length = "0x157")]
		[Token(Token = "0x600072B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000157")]
	private sealed class IncrementUInt16 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000726")]
		public IncrementUInt16() { }

		[Address(RVA = "0x2273FB0", Offset = "0x22733B0", Length = "0x146")]
		[Token(Token = "0x6000725")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000158")]
	private sealed class IncrementUInt32 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000728")]
		public IncrementUInt32() { }

		[Address(RVA = "0x2274100", Offset = "0x2273500", Length = "0x14D")]
		[Token(Token = "0x6000727")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000159")]
	private sealed class IncrementUInt64 : IncrementInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600072A")]
		public IncrementUInt64() { }

		[Address(RVA = "0x2274250", Offset = "0x2273650", Length = "0x150")]
		[Token(Token = "0x6000729")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40002A0")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40002A1")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40002A2")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x40002A3")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x40002A4")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x40002A5")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x40002A6")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x40002A7")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x170001A9")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600071A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AB")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2273A50", Offset = "0x2272E50", Length = "0x2C")]
		[Token(Token = "0x600071C")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001AA")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600071B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600071D")]
	private IncrementInstruction() { }

	[Address(RVA = "0x22735D0", Offset = "0x22729D0", Length = "0x460")]
	[Token(Token = "0x600071E")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600071A")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2273A50", Offset = "0x2272E50", Length = "0x2C")]
	[Token(Token = "0x600071C")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600071B")]
	public virtual int get_ProducedStack() { }

}

