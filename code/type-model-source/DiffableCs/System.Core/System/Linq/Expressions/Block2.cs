namespace System.Linq.Expressions;

[Token(Token = "0x2000066")]
internal sealed class Block2 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DB")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000DC")]
	private readonly Expression _arg1; //Field offset: 0x18

	[Token(Token = "0x1700005B")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600029D")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x22525C0", Offset = "0x22519C0", Length = "0x82")]
	[Token(Token = "0x600029B")]
	internal Block2(Expression arg0, Expression arg1) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600029D")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2252440", Offset = "0x2251840", Length = "0x8D")]
	[Token(Token = "0x600029C")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22524D0", Offset = "0x22518D0", Length = "0xC")]
	[Token(Token = "0x600029E")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x22524E0", Offset = "0x22518E0", Length = "0xDC")]
	[Token(Token = "0x600029F")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

