namespace System.Linq.Expressions;

[Token(Token = "0x2000076")]
internal class FullConditionalExpression : ConditionalExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FF")]
	private readonly Expression _false; //Field offset: 0x20

	[Address(RVA = "0x2263BA0", Offset = "0x2262FA0", Length = "0x32")]
	[Token(Token = "0x60002F0")]
	internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60002F1")]
	internal virtual Expression GetFalse() { }

}

