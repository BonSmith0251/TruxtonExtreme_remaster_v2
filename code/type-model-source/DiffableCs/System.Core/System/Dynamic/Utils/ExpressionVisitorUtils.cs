namespace System.Dynamic.Utils;

[Token(Token = "0x2000281")]
internal static class ExpressionVisitorUtils
{

	[Address(RVA = "0x22AF230", Offset = "0x22AE630", Length = "0x2AD")]
	[Token(Token = "0x6000C81")]
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }

	[Address(RVA = "0x22AF4E0", Offset = "0x22AE8E0", Length = "0x295")]
	[Token(Token = "0x6000C7F")]
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	[Address(RVA = "0x22AF780", Offset = "0x22AEB80", Length = "0x2BA")]
	[Token(Token = "0x6000C80")]
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

}

