namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x20001B6")]
internal struct LocalDefinition
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000379")]
	private readonly int <Index>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400037A")]
	private readonly ParameterExpression <Parameter>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170001F6")]
	public int Index
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000982")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001F7")]
	public ParameterExpression Parameter
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000983")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
	[Token(Token = "0x6000981")]
	internal LocalDefinition(int localIndex, ParameterExpression parameter) { }

	[Address(RVA = "0x229DC60", Offset = "0x229D060", Length = "0x94")]
	[Token(Token = "0x6000984")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000982")]
	public int get_Index() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000983")]
	public ParameterExpression get_Parameter() { }

	[Address(RVA = "0x229DD00", Offset = "0x229D100", Length = "0x5D")]
	[Token(Token = "0x6000985")]
	public virtual int GetHashCode() { }

}

