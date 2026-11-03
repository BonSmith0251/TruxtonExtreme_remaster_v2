namespace System.Linq.Expressions;

[Token(Token = "0x2000046")]
internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D2")]
	private readonly LambdaExpression _conversion; //Field offset: 0x38

	[Address(RVA = "0x224EAC0", Offset = "0x224DEC0", Length = "0x66")]
	[Token(Token = "0x60001B1")]
	internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60001B2")]
	internal virtual LambdaExpression GetConversion() { }

}

