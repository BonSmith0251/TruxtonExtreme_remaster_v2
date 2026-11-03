namespace System.Linq.Expressions;

[Token(Token = "0x200006D")]
internal class ScopeN : ScopeExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EC")]
	private IReadOnlyList<Expression> _body; //Field offset: 0x18

	[Token(Token = "0x17000062")]
	protected IReadOnlyList<Expression> Body
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002BF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000063")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x2269370", Offset = "0x2268770", Length = "0x46")]
		[Token(Token = "0x60002C1")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0x22525C0", Offset = "0x22519C0", Length = "0x82")]
	[Token(Token = "0x60002BE")]
	internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60002BF")]
	protected IReadOnlyList<Expression> get_Body() { }

	[Address(RVA = "0x2269370", Offset = "0x2268770", Length = "0x46")]
	[Token(Token = "0x60002C1")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2269180", Offset = "0x2268580", Length = "0x54")]
	[Token(Token = "0x60002C0")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22691E0", Offset = "0x22685E0", Length = "0x3A")]
	[Token(Token = "0x60002C2")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2269220", Offset = "0x2268620", Length = "0x146")]
	[Token(Token = "0x60002C3")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

