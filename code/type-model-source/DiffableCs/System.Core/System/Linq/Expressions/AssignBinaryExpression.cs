namespace System.Linq.Expressions;

[Token(Token = "0x2000044")]
internal class AssignBinaryExpression : BinaryExpression
{

	[Token(Token = "0x1700004E")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2230420", Offset = "0x222F820", Length = "0x6")]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700004D")]
	public virtual Type Type
	{
		[Address(RVA = "0x2230430", Offset = "0x222F830", Length = "0x2A")]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2230410", Offset = "0x222F810", Length = "0x8")]
	[Token(Token = "0x60001AA")]
	internal AssignBinaryExpression(Expression left, Expression right) { }

	[Address(RVA = "0x2230420", Offset = "0x222F820", Length = "0x6")]
	[Token(Token = "0x60001AC")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2230430", Offset = "0x222F830", Length = "0x2A")]
	[Token(Token = "0x60001AB")]
	public virtual Type get_Type() { }

}

