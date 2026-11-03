namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200015C")]
internal abstract class Instruction
{

	[Token(Token = "0x170001AE")]
	public override int ConsumedContinuations
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000731")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001AC")]
	public override int ConsumedStack
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600072F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001B1")]
	public int ContinuationsBalance
	{
		[Address(RVA = "0x2279130", Offset = "0x2278530", Length = "0x48")]
		[Token(Token = "0x6000734")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170001B2")]
	public abstract string InstructionName
	{
		[Token(Token = "0x6000736")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001AF")]
	public override int ProducedContinuations
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000732")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001AD")]
	public override int ProducedStack
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000730")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001B0")]
	public int StackBalance
	{
		[Address(RVA = "0x2279180", Offset = "0x2278580", Length = "0x48")]
		[Token(Token = "0x6000733")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600073A")]
	protected Instruction() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000731")]
	public override int get_ConsumedContinuations() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600072F")]
	public override int get_ConsumedStack() { }

	[Address(RVA = "0x2279130", Offset = "0x2278530", Length = "0x48")]
	[Token(Token = "0x6000734")]
	public int get_ContinuationsBalance() { }

	[Token(Token = "0x6000736")]
	public abstract string get_InstructionName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000732")]
	public override int get_ProducedContinuations() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000730")]
	public override int get_ProducedStack() { }

	[Address(RVA = "0x2279180", Offset = "0x2278580", Length = "0x48")]
	[Token(Token = "0x6000733")]
	public int get_StackBalance() { }

	[Address(RVA = "0x22790B0", Offset = "0x22784B0", Length = "0x13")]
	[Token(Token = "0x6000739")]
	protected static void NullCheck(object o) { }

	[Token(Token = "0x6000735")]
	public abstract int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x1FCFE00", Offset = "0x1FCF200", Length = "0x14")]
	[Token(Token = "0x6000738")]
	public override string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x22790D0", Offset = "0x22784D0", Length = "0x52")]
	[Token(Token = "0x6000737")]
	public virtual string ToString() { }

}

