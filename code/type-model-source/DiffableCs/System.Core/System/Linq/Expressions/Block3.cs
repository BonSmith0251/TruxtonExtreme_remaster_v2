namespace System.Linq.Expressions;

[Token(Token = "0x2000067")]
internal sealed class Block3 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DD")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000DE")]
	private readonly Expression _arg1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DF")]
	private readonly Expression _arg2; //Field offset: 0x20

	[Token(Token = "0x1700005C")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60002A2")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x2252810", Offset = "0x2251C10", Length = "0x9F")]
	[Token(Token = "0x60002A0")]
	internal Block3(Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60002A2")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2252650", Offset = "0x2251A50", Length = "0xA1")]
	[Token(Token = "0x60002A1")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22524D0", Offset = "0x22518D0", Length = "0xC")]
	[Token(Token = "0x60002A3")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2252700", Offset = "0x2251B00", Length = "0x104")]
	[Token(Token = "0x60002A4")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

