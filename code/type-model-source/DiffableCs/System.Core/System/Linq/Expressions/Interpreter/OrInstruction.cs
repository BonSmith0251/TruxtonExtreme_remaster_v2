namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000206")]
internal abstract class OrInstruction : Instruction
{
	[Token(Token = "0x200020F")]
	private sealed class OrBoolean : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A6E")]
		public OrBoolean() { }

		[Address(RVA = "0x22A5F60", Offset = "0x22A5360", Length = "0x175")]
		[Token(Token = "0x6000A6D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200020B")]
	private sealed class OrByte : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A66")]
		public OrByte() { }

		[Address(RVA = "0x22A60E0", Offset = "0x22A54E0", Length = "0xC5")]
		[Token(Token = "0x6000A65")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000208")]
	private sealed class OrInt16 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A60")]
		public OrInt16() { }

		[Address(RVA = "0x22A66E0", Offset = "0x22A5AE0", Length = "0xC4")]
		[Token(Token = "0x6000A5F")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000209")]
	private sealed class OrInt32 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A62")]
		public OrInt32() { }

		[Address(RVA = "0x22A67B0", Offset = "0x22A5BB0", Length = "0xC1")]
		[Token(Token = "0x6000A61")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200020A")]
	private sealed class OrInt64 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A64")]
		public OrInt64() { }

		[Address(RVA = "0x22A6880", Offset = "0x22A5C80", Length = "0xD2")]
		[Token(Token = "0x6000A63")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000207")]
	private sealed class OrSByte : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A5E")]
		public OrSByte() { }

		[Address(RVA = "0x22A6960", Offset = "0x22A5D60", Length = "0xC5")]
		[Token(Token = "0x6000A5D")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200020C")]
	private sealed class OrUInt16 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A68")]
		public OrUInt16() { }

		[Address(RVA = "0x22A6A30", Offset = "0x22A5E30", Length = "0xC4")]
		[Token(Token = "0x6000A67")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200020D")]
	private sealed class OrUInt32 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A6A")]
		public OrUInt32() { }

		[Address(RVA = "0x22A6B00", Offset = "0x22A5F00", Length = "0xCF")]
		[Token(Token = "0x6000A69")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x200020E")]
	private sealed class OrUInt64 : OrInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000A6C")]
		public OrUInt64() { }

		[Address(RVA = "0x22A6BD0", Offset = "0x22A5FD0", Length = "0xD2")]
		[Token(Token = "0x6000A6B")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003CA")]
	private static Instruction s_SByte; //Field offset: 0x0
	[Token(Token = "0x40003CB")]
	private static Instruction s_Int16; //Field offset: 0x8
	[Token(Token = "0x40003CC")]
	private static Instruction s_Int32; //Field offset: 0x10
	[Token(Token = "0x40003CD")]
	private static Instruction s_Int64; //Field offset: 0x18
	[Token(Token = "0x40003CE")]
	private static Instruction s_Byte; //Field offset: 0x20
	[Token(Token = "0x40003CF")]
	private static Instruction s_UInt16; //Field offset: 0x28
	[Token(Token = "0x40003D0")]
	private static Instruction s_UInt32; //Field offset: 0x30
	[Token(Token = "0x40003D1")]
	private static Instruction s_UInt64; //Field offset: 0x38
	[Token(Token = "0x40003D2")]
	private static Instruction s_Boolean; //Field offset: 0x40

	[Token(Token = "0x1700021C")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000A58")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700021E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A66B0", Offset = "0x22A5AB0", Length = "0x2C")]
		[Token(Token = "0x6000A5A")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700021D")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A59")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A5B")]
	private OrInstruction() { }

	[Address(RVA = "0x22A61B0", Offset = "0x22A55B0", Length = "0x4D0")]
	[Token(Token = "0x6000A5C")]
	public static Instruction Create(Type type) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000A58")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A66B0", Offset = "0x22A5AB0", Length = "0x2C")]
	[Token(Token = "0x6000A5A")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A59")]
	public virtual int get_ProducedStack() { }

}

