namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000CE")]
internal abstract class AddOvfInstruction : Instruction
{
	[Token(Token = "0x20000CF")]
	private sealed class AddOvfInt16 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600057D")]
		public AddOvfInt16() { }

		[Address(RVA = "0x22501C0", Offset = "0x224F5C0", Length = "0x2F4")]
		[Token(Token = "0x600057C")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D0")]
	private sealed class AddOvfInt32 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600057F")]
		public AddOvfInt32() { }

		[Address(RVA = "0x22504C0", Offset = "0x224F8C0", Length = "0x263")]
		[Token(Token = "0x600057E")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D1")]
	private sealed class AddOvfInt64 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000581")]
		public AddOvfInt64() { }

		[Address(RVA = "0x2250730", Offset = "0x224FB30", Length = "0x238")]
		[Token(Token = "0x6000580")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D2")]
	private sealed class AddOvfUInt16 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000583")]
		public AddOvfUInt16() { }

		[Address(RVA = "0x2250970", Offset = "0x224FD70", Length = "0x2A0")]
		[Token(Token = "0x6000582")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D3")]
	private sealed class AddOvfUInt32 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000585")]
		public AddOvfUInt32() { }

		[Address(RVA = "0x2250C20", Offset = "0x2250020", Length = "0x20D")]
		[Token(Token = "0x6000584")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x20000D4")]
	private sealed class AddOvfUInt64 : AddOvfInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000587")]
		public AddOvfUInt64() { }

		[Address(RVA = "0x2250E30", Offset = "0x2250230", Length = "0x20A")]
		[Token(Token = "0x6000586")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40001F9")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40001FA")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40001FB")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x40001FC")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x40001FD")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x40001FE")]
	private static Instruction s_UInt64; //Field offset: 0x28

	[Token(Token = "0x17000139")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000577")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700013B")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2250190", Offset = "0x224F590", Length = "0x2C")]
		[Token(Token = "0x6000579")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700013A")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000578")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600057A")]
	private AddOvfInstruction() { }

	[Address(RVA = "0x224FDF0", Offset = "0x224F1F0", Length = "0x388")]
	[Token(Token = "0x600057B")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000577")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2250190", Offset = "0x224F590", Length = "0x2C")]
	[Token(Token = "0x6000579")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000578")]
	public virtual int get_ProducedStack() { }

}

