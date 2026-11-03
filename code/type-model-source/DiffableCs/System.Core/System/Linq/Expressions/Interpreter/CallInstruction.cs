namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E8")]
internal abstract class CallInstruction : Instruction
{

	[Token(Token = "0x17000153")]
	public abstract int ArgumentCount
	{
		[Token(Token = "0x60005CB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000155")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x2232380", Offset = "0x2231780", Length = "0x14")]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000154")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2255220", Offset = "0x2254620", Length = "0x2C")]
		[Token(Token = "0x60005CC")]
		 get { } //Length: 44
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005D6")]
	protected CallInstruction() { }

	[Address(RVA = "0x22548A0", Offset = "0x2253CA0", Length = "0x23")]
	[Token(Token = "0x60005D0")]
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	[Address(RVA = "0x22548D0", Offset = "0x2253CD0", Length = "0x2C")]
	[Token(Token = "0x60005D1")]
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	[Address(RVA = "0x2254900", Offset = "0x2253D00", Length = "0x31")]
	[Token(Token = "0x60005D2")]
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	[Address(RVA = "0x2254940", Offset = "0x2253D40", Length = "0x57")]
	[Token(Token = "0x60005CD")]
	public static CallInstruction Create(MethodInfo info) { }

	[Address(RVA = "0x22549A0", Offset = "0x2253DA0", Length = "0x198")]
	[Token(Token = "0x60005CE")]
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	[Token(Token = "0x60005CB")]
	public abstract int get_ArgumentCount() { }

	[Address(RVA = "0x2232380", Offset = "0x2231780", Length = "0x14")]
	[Token(Token = "0x60005D3")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2255220", Offset = "0x2254620", Length = "0x2C")]
	[Token(Token = "0x60005CC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2254B40", Offset = "0x2253F40", Length = "0x516")]
	[Token(Token = "0x60005CF")]
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	[Address(RVA = "0x2255060", Offset = "0x2254460", Length = "0x58")]
	[Token(Token = "0x60005D5")]
	protected object InterpretLambdaInvoke(LightLambda targetLambda, Object[] args) { }

	[Address(RVA = "0x22550C0", Offset = "0x22544C0", Length = "0x15C")]
	[Token(Token = "0x60005D4")]
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

}

