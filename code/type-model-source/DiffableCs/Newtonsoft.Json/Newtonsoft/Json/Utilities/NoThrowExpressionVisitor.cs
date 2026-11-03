namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000C0")]
internal class NoThrowExpressionVisitor : ExpressionVisitor
{
	[Token(Token = "0x400043C")]
	internal static readonly object ErrorResult; //Field offset: 0x0

	[Address(RVA = "0x212B870", Offset = "0x212AC70", Length = "0x73")]
	[Token(Token = "0x60005F9")]
	private static NoThrowExpressionVisitor() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005F8")]
	public NoThrowExpressionVisitor() { }

	[Address(RVA = "0x212B760", Offset = "0x212AB60", Length = "0x102")]
	[Token(Token = "0x60005F7")]
	protected virtual Expression VisitConditional(ConditionalExpression node) { }

}

