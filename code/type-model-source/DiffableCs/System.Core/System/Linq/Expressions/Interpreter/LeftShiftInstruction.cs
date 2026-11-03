namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000169")]
internal abstract class LeftShiftInstruction : Instruction
{
	[Token(Token = "0x200016E")]
	private sealed class LeftShiftByte : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000802")]
		public LeftShiftByte() { }

		[Address(RVA = "0x227B780", Offset = "0x227AB80", Length = "0x131")]
		[Token(Token = "0x6000801")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200016B")]
	private sealed class LeftShiftInt16 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007FC")]
		public LeftShiftInt16() { }

		[Address(RVA = "0x227BD70", Offset = "0x227B170", Length = "0x130")]
		[Token(Token = "0x60007FB")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200016C")]
	private sealed class LeftShiftInt32 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007FE")]
		public LeftShiftInt32() { }

		[Address(RVA = "0x227BEB0", Offset = "0x227B2B0", Length = "0x12A")]
		[Token(Token = "0x60007FD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200016D")]
	private sealed class LeftShiftInt64 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000800")]
		public LeftShiftInt64() { }

		[Address(RVA = "0x227BFE0", Offset = "0x227B3E0", Length = "0x1B5")]
		[Token(Token = "0x60007FF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200016A")]
	private sealed class LeftShiftSByte : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007FA")]
		public LeftShiftSByte() { }

		[Address(RVA = "0x227C1A0", Offset = "0x227B5A0", Length = "0x1B8")]
		[Token(Token = "0x60007F9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200016F")]
	private sealed class LeftShiftUInt16 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000804")]
		public LeftShiftUInt16() { }

		[Address(RVA = "0x227C360", Offset = "0x227B760", Length = "0x130")]
		[Token(Token = "0x6000803")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000170")]
	private sealed class LeftShiftUInt32 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000806")]
		public LeftShiftUInt32() { }

		[Address(RVA = "0x227C4A0", Offset = "0x227B8A0", Length = "0x1B2")]
		[Token(Token = "0x6000805")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000171")]
	private sealed class LeftShiftUInt64 : LeftShiftInstruction
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000808")]
		public LeftShiftUInt64() { }

		[Address(RVA = "0x227C660", Offset = "0x227BA60", Length = "0x1B5")]
		[Token(Token = "0x6000807")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40002F9")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x40002FA")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x40002FB")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x40002FC")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x40002FD")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x40002FE")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x40002FF")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x4000300")]
	private static Instruction s_UInt64; //Field offset: 0x38

	[Token(Token = "0x170001C2")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60007F4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001C4")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x227BD40", Offset = "0x227B140", Length = "0x2C")]
		[Token(Token = "0x60007F6")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001C3")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60007F5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60007F7")]
	private LeftShiftInstruction() { }

	[Address(RVA = "0x227B8C0", Offset = "0x227ACC0", Length = "0x460")]
	[Token(Token = "0x60007F8")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60007F4")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x227BD40", Offset = "0x227B140", Length = "0x2C")]
	[Token(Token = "0x60007F6")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60007F5")]
	public virtual int get_ProducedStack() { }

}

