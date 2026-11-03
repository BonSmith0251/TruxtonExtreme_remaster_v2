namespace System.Linq.Expressions;

[Token(Token = "0x2000045")]
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D1")]
	private readonly LambdaExpression _conversion; //Field offset: 0x20

	[Token(Token = "0x1700004F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x60001AF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000050")]
	public virtual Type Type
	{
		[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2233500", Offset = "0x2232900", Length = "0x32")]
	[Token(Token = "0x60001AD")]
	internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60001AF")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
	[Token(Token = "0x60001B0")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001AE")]
	internal virtual LambdaExpression GetConversion() { }

}

