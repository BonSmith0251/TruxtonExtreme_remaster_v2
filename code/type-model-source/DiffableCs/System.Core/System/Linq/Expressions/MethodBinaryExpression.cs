namespace System.Linq.Expressions;

[Token(Token = "0x2000048")]
internal class MethodBinaryExpression : SimpleBinaryExpression
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D5")]
	private readonly MethodInfo _method; //Field offset: 0x30

	[Address(RVA = "0x224EA60", Offset = "0x224DE60", Length = "0x54")]
	[Token(Token = "0x60001B6")]
	internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60001B7")]
	internal virtual MethodInfo GetMethod() { }

}

