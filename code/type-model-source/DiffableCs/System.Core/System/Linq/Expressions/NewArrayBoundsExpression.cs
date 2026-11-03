namespace System.Linq.Expressions;

[Token(Token = "0x20000B4")]
internal sealed class NewArrayBoundsExpression : NewArrayExpression
{

	[Token(Token = "0x170000DA")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2267D90", Offset = "0x2267190", Length = "0x6")]
		[Token(Token = "0x60004A6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2267D80", Offset = "0x2267180", Length = "0x8")]
	[Token(Token = "0x60004A5")]
	internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x2267D90", Offset = "0x2267190", Length = "0x6")]
	[Token(Token = "0x60004A6")]
	public virtual ExpressionType get_NodeType() { }

}

