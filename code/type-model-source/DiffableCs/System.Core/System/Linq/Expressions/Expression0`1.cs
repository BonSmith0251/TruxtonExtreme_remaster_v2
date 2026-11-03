namespace System.Linq.Expressions;

[Token(Token = "0x2000093")]
internal sealed class Expression0 : Expression<TDelegate>
{

	[Token(Token = "0x170000AC")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600042B")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x1BB0380", Offset = "0x1BAF780", Length = "0x14")]
	[Token(Token = "0x600042A")]
	public Expression0`1(Expression body) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600042B")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0x1BB02D0", Offset = "0x1BAF6D0", Length = "0x2A")]
	[Token(Token = "0x600042C")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x1BB0300", Offset = "0x1BAF700", Length = "0x76")]
	[Token(Token = "0x600042D")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

