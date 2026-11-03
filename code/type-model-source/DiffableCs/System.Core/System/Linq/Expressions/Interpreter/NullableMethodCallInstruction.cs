namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000232")]
internal abstract class NullableMethodCallInstruction : Instruction
{
	[Token(Token = "0x2000237")]
	private sealed class EqualsClass : NullableMethodCallInstruction
	{

		[Token(Token = "0x17000240")]
		public virtual int ConsumedStack
		{
			[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
			[Token(Token = "0x6000AE7")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AE9")]
		public EqualsClass() { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000AE7")]
		public virtual int get_ConsumedStack() { }

		[Address(RVA = "0x2297190", Offset = "0x2296590", Length = "0xDD")]
		[Token(Token = "0x6000AE8")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000239")]
	private sealed class GetHashCodeClass : NullableMethodCallInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AED")]
		public GetHashCodeClass() { }

		[Address(RVA = "0x2299E80", Offset = "0x2299280", Length = "0x51")]
		[Token(Token = "0x6000AEC")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000234")]
	private sealed class GetValue : NullableMethodCallInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AE1")]
		public GetValue() { }

		[Address(RVA = "0x229A000", Offset = "0x2299400", Length = "0x6E")]
		[Token(Token = "0x6000AE0")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000235")]
	private sealed class GetValueOrDefault : NullableMethodCallInstruction
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003F8")]
		private readonly Type _defaultValueType; //Field offset: 0x10

		[Address(RVA = "0x2299FA0", Offset = "0x22993A0", Length = "0x51")]
		[Token(Token = "0x6000AE2")]
		public GetValueOrDefault(MethodInfo mi) { }

		[Address(RVA = "0x2299F40", Offset = "0x2299340", Length = "0x5C")]
		[Token(Token = "0x6000AE3")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000236")]
	private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
	{

		[Token(Token = "0x1700023F")]
		public virtual int ConsumedStack
		{
			[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
			[Token(Token = "0x6000AE4")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AE6")]
		public GetValueOrDefault1() { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000AE4")]
		public virtual int get_ConsumedStack() { }

		[Address(RVA = "0x2299EE0", Offset = "0x22992E0", Length = "0x54")]
		[Token(Token = "0x6000AE5")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000233")]
	private sealed class HasValue : NullableMethodCallInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000ADF")]
		public HasValue() { }

		[Address(RVA = "0x229A070", Offset = "0x2299470", Length = "0x39")]
		[Token(Token = "0x6000ADE")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x2000238")]
	private sealed class ToStringClass : NullableMethodCallInstruction
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000AEB")]
		public ToStringClass() { }

		[Address(RVA = "0x22ABAE0", Offset = "0x22AAEE0", Length = "0x76")]
		[Token(Token = "0x6000AEA")]
		public virtual int Run(InterpretedFrame frame) { }

	}

	[Token(Token = "0x40003F2")]
	private static NullableMethodCallInstruction s_hasValue; //Field offset: 0x0
	[Token(Token = "0x40003F3")]
	private static NullableMethodCallInstruction s_value; //Field offset: 0x8
	[Token(Token = "0x40003F4")]
	private static NullableMethodCallInstruction s_equals; //Field offset: 0x10
	[Token(Token = "0x40003F5")]
	private static NullableMethodCallInstruction s_getHashCode; //Field offset: 0x18
	[Token(Token = "0x40003F6")]
	private static NullableMethodCallInstruction s_getValueOrDefault1; //Field offset: 0x20
	[Token(Token = "0x40003F7")]
	private static NullableMethodCallInstruction s_toString; //Field offset: 0x28

	[Token(Token = "0x1700023C")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AD8")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700023E")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A5C60", Offset = "0x22A5060", Length = "0x2C")]
		[Token(Token = "0x6000ADA")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700023D")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AD9")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000ADB")]
	private NullableMethodCallInstruction() { }

	[Address(RVA = "0x22A5850", Offset = "0x22A4C50", Length = "0x405")]
	[Token(Token = "0x6000ADC")]
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	[Address(RVA = "0x22A57B0", Offset = "0x22A4BB0", Length = "0x9A")]
	[Token(Token = "0x6000ADD")]
	public static Instruction CreateGetValue() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AD8")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A5C60", Offset = "0x22A5060", Length = "0x2C")]
	[Token(Token = "0x6000ADA")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AD9")]
	public virtual int get_ProducedStack() { }

}

