namespace System.Linq.Expressions;

[Token(Token = "0x20000B3")]
internal sealed class NewArrayInitExpression : NewArrayExpression
{

	[Token(Token = "0x170000D9")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x60004A4")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2267D80", Offset = "0x2267180", Length = "0x8")]
	[Token(Token = "0x60004A3")]
	internal NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x60004A4")]
	public virtual ExpressionType get_NodeType() { }

}

