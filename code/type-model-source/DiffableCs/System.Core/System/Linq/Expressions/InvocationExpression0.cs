namespace System.Linq.Expressions;

[Token(Token = "0x2000088")]
internal sealed class InvocationExpression0 : InvocationExpression
{

	[Token(Token = "0x17000092")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60003F2")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2264FA0", Offset = "0x22643A0", Length = "0x8")]
	[Token(Token = "0x60003F0")]
	public InvocationExpression0(Expression lambda, Type returnType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60003F2")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264F00", Offset = "0x2264300", Length = "0x4E")]
	[Token(Token = "0x60003F1")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2264F50", Offset = "0x2264350", Length = "0x49")]
	[Token(Token = "0x60003F3")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

