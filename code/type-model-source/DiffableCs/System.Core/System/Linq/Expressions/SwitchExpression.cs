namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
[Token(Token = "0x20000BF")]
public sealed class SwitchExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C3")]
	private readonly Expression <SwitchValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C4")]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C5")]
	private readonly Expression <DefaultBody>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C6")]
	private readonly MethodInfo <Comparison>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000120")]
	public ReadOnlyCollection<SwitchCase> Cases
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600053A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000122")]
	public MethodInfo Comparison
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600053C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000121")]
	public Expression DefaultBody
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600053B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011F")]
	public Expression SwitchValue
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000539")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600053A")]
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600053C")]
	public MethodInfo get_Comparison() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600053B")]
	public Expression get_DefaultBody() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000539")]
	public Expression get_SwitchValue() { }

}

