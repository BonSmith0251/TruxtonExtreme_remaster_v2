namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000227")]
internal abstract class SubOvfInstruction : Instruction
{
	[Token(Token = "0x2000228")]
	private sealed class SubOvfInt16 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AB6")]
		public SubOvfInt16() { }

		[Address(RVA = "0x22AA1C0", Offset = "0x22A95C0", Length = "0x2F6")]
		[Token(Token = "0x6000AB5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000229")]
	private sealed class SubOvfInt32 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AB8")]
		public SubOvfInt32() { }

		[Address(RVA = "0x22AA4C0", Offset = "0x22A98C0", Length = "0x262")]
		[Token(Token = "0x6000AB7")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200022A")]
	private sealed class SubOvfInt64 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000ABA")]
		public SubOvfInt64() { }

		[Address(RVA = "0x22AA730", Offset = "0x22A9B30", Length = "0x23B")]
		[Token(Token = "0x6000AB9")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200022B")]
	private sealed class SubOvfUInt16 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000ABC")]
		public SubOvfUInt16() { }

		[Address(RVA = "0x22AA970", Offset = "0x22A9D70", Length = "0x2F4")]
		[Token(Token = "0x6000ABB")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200022C")]
	private sealed class SubOvfUInt32 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000ABE")]
		public SubOvfUInt32() { }

		[Address(RVA = "0x22AAC70", Offset = "0x22AA070", Length = "0x20D")]
		[Token(Token = "0x6000ABD")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200022D")]
	private sealed class SubOvfUInt64 : SubOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AC0")]
		public SubOvfUInt64() { }

		[Address(RVA = "0x22AAE80", Offset = "0x22AA280", Length = "0x207")]
		[Token(Token = "0x6000ABF")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003E8")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40003E9")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40003EA")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x40003EB")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x40003EC")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x40003ED")]
	private static Instruction s_UInt64; //Field offset: 0x28

	[Token(Token = "0x1700022D")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000AB0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700022F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22AA190", Offset = "0x22A9590", Length = "0x2C")]
		[Token(Token = "0x6000AB2")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700022E")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AB1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000AB3")]
	private SubOvfInstruction() { }

	[Address(RVA = "0x22A9DF0", Offset = "0x22A91F0", Length = "0x388")]
	[Token(Token = "0x6000AB4")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000AB0")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22AA190", Offset = "0x22A9590", Length = "0x2C")]
	[Token(Token = "0x6000AB2")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AB1")]
	public virtual int get_ProducedStack() { }

}

