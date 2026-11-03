namespace System.Linq.Expressions;

[Token(Token = "0x200006A")]
internal class BlockN : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E9")]
	private IReadOnlyList<Expression> _expressions; //Field offset: 0x10

	[Token(Token = "0x1700005F")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x2253920", Offset = "0x2252D20", Length = "0x46")]
		[Token(Token = "0x60002B1")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0x22538B0", Offset = "0x2252CB0", Length = "0x65")]
	[Token(Token = "0x60002AF")]
	internal BlockN(IReadOnlyList<Expression> expressions) { }

	[Address(RVA = "0x2253920", Offset = "0x2252D20", Length = "0x46")]
	[Token(Token = "0x60002B1")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2253770", Offset = "0x2252B70", Length = "0x54")]
	[Token(Token = "0x60002B0")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22537D0", Offset = "0x2252BD0", Length = "0x3A")]
	[Token(Token = "0x60002B2")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2253810", Offset = "0x2252C10", Length = "0x91")]
	[Token(Token = "0x60002B3")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

