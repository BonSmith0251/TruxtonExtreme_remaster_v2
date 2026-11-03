namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
[Token(Token = "0x20000BA")]
public sealed class RuntimeVariablesExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BD")]
	private readonly ReadOnlyCollection<ParameterExpression> <Variables>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000E2")]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004B7")]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

}

