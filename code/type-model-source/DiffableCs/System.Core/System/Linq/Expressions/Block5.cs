namespace System.Linq.Expressions;

[Token(Token = "0x2000069")]
internal sealed class Block5 : BlockExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E4")]
	private object _arg0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E5")]
	private readonly Expression _arg1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E6")]
	private readonly Expression _arg2; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E7")]
	private readonly Expression _arg3; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E8")]
	private readonly Expression _arg4; //Field offset: 0x30

	[Token(Token = "0x1700005E")]
	internal virtual int ExpressionCount
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x60002AC")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x2252D90", Offset = "0x2252190", Length = "0xC3")]
	[Token(Token = "0x60002AA")]
	internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x60002AC")]
	internal virtual int get_ExpressionCount() { }

	[Address(RVA = "0x2252B60", Offset = "0x2251F60", Length = "0xC9")]
	[Token(Token = "0x60002AB")]
	internal virtual Expression GetExpression(int index) { }

	[Address(RVA = "0x22524D0", Offset = "0x22518D0", Length = "0xC")]
	[Token(Token = "0x60002AD")]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2252C30", Offset = "0x2252030", Length = "0x154")]
	[Token(Token = "0x60002AE")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

