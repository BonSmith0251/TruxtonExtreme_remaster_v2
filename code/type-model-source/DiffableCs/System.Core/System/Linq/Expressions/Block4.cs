namespace System.Linq.Expressions;

[Token(Token = "0x2000068")]
internal sealed class Block4 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E0")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E1")]
	private readonly Expression _arg1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E2")]
	private readonly Expression _arg2; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E3")]
	private readonly Expression _arg3; //Field offset: 0x28

	[Token(Token = "0x1700005D")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x60002A7")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x2252AA0", Offset = "0x2251EA0", Length = "0xB1")]
	[Token(Token = "0x60002A5")]
	internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x60002A7")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x22528B0", Offset = "0x2251CB0", Length = "0xB5")]
	[Token(Token = "0x60002A6")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22524D0", Offset = "0x22518D0", Length = "0xC")]
	[Token(Token = "0x60002A8")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2252970", Offset = "0x2251D70", Length = "0x12C")]
	[Token(Token = "0x60002A9")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

