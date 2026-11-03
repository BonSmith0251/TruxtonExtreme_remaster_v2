namespace System.Linq.Expressions;

[Token(Token = "0x200006C")]
internal sealed class Scope1 : ScopeExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EB")]
	private object _body; //Field offset: 0x18

	[Token(Token = "0x17000061")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60002BB")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x22690A0", Offset = "0x22684A0", Length = "0x8")]
	[Token(Token = "0x60002B8")]
	internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	[Address(RVA = "0x22525C0", Offset = "0x22519C0", Length = "0x82")]
	[Token(Token = "0x60002B9")]
	private Scope1(IReadOnlyList<ParameterExpression> variables, object body) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60002BB")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2268EE0", Offset = "0x22682E0", Length = "0x79")]
	[Token(Token = "0x60002BA")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x2268F60", Offset = "0x2268360", Length = "0xC")]
	[Token(Token = "0x60002BC")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2268F70", Offset = "0x2268370", Length = "0x120")]
	[Token(Token = "0x60002BD")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

