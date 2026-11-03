namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021E")]
internal abstract class SubInstruction : Instruction
{
	[Token(Token = "0x2000226")]
	private sealed class SubDouble : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AAF")]
		public SubDouble() { }

		[Address(RVA = "0x22A93C0", Offset = "0x22A87C0", Length = "0x162")]
		[Token(Token = "0x6000AAE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200021F")]
	private sealed class SubInt16 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AA1")]
		public SubInt16() { }

		[Address(RVA = "0x22A99E0", Offset = "0x22A8DE0", Length = "0x156")]
		[Token(Token = "0x6000AA0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000220")]
	private sealed class SubInt32 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AA3")]
		public SubInt32() { }

		[Address(RVA = "0x22A9B40", Offset = "0x22A8F40", Length = "0x14F")]
		[Token(Token = "0x6000AA2")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000221")]
	private sealed class SubInt64 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AA5")]
		public SubInt64() { }

		[Address(RVA = "0x22A9C90", Offset = "0x22A9090", Length = "0x154")]
		[Token(Token = "0x6000AA4")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000225")]
	private sealed class SubSingle : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AAD")]
		public SubSingle() { }

		[Address(RVA = "0x22AB090", Offset = "0x22AA490", Length = "0x162")]
		[Token(Token = "0x6000AAC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000222")]
	private sealed class SubUInt16 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AA7")]
		public SubUInt16() { }

		[Address(RVA = "0x22AB200", Offset = "0x22AA600", Length = "0x156")]
		[Token(Token = "0x6000AA6")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000223")]
	private sealed class SubUInt32 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AA9")]
		public SubUInt32() { }

		[Address(RVA = "0x22AB360", Offset = "0x22AA760", Length = "0x152")]
		[Token(Token = "0x6000AA8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000224")]
	private sealed class SubUInt64 : SubInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AAB")]
		public SubUInt64() { }

		[Address(RVA = "0x22AB4C0", Offset = "0x22AA8C0", Length = "0x154")]
		[Token(Token = "0x6000AAA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003E0")]
	private static Instruction s_Int16; //Field offset: 0x0
	[Token(Token = "0x40003E1")]
	private static Instruction s_Int32; //Field offset: 0x8
	[Token(Token = "0x40003E2")]
	private static Instruction s_Int64; //Field offset: 0x10
	[Token(Token = "0x40003E3")]
	private static Instruction s_UInt16; //Field offset: 0x18
	[Token(Token = "0x40003E4")]
	private static Instruction s_UInt32; //Field offset: 0x20
	[Token(Token = "0x40003E5")]
	private static Instruction s_UInt64; //Field offset: 0x28
	[Token(Token = "0x40003E6")]
	private static Instruction s_Single; //Field offset: 0x30
	[Token(Token = "0x40003E7")]
	private static Instruction s_Double; //Field offset: 0x38

	[Token(Token = "0x1700022A")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000A9B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700022C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A99B0", Offset = "0x22A8DB0", Length = "0x2C")]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700022B")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A9C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A9E")]
	private SubInstruction() { }

	[Address(RVA = "0x22A9530", Offset = "0x22A8930", Length = "0x460")]
	[Token(Token = "0x6000A9F")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000A9B")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A99B0", Offset = "0x22A8DB0", Length = "0x2C")]
	[Token(Token = "0x6000A9D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A9C")]
	public virtual int get_ProducedStack() { }

}

