namespace System.Linq.Expressions;

[Token(Token = "0x200006B")]
internal class ScopeExpression : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EA")]
	private IReadOnlyList<ParameterExpression> _variables; //Field offset: 0x10

	[Token(Token = "0x17000060")]
	protected IReadOnlyList<ParameterExpression> VariablesList
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002B6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22538B0", Offset = "0x2252CB0", Length = "0x65")]
	[Token(Token = "0x60002B4")]
	internal ScopeExpression(IReadOnlyList<ParameterExpression> variables) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60002B6")]
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	[Address(RVA = "0x22690B0", Offset = "0x22684B0", Length = "0x3A")]
	[Token(Token = "0x60002B5")]
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[Address(RVA = "0x22690F0", Offset = "0x22684F0", Length = "0x87")]
	[Token(Token = "0x60002B7")]
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }

}

