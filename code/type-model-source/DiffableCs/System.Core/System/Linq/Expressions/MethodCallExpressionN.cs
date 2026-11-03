namespace System.Linq.Expressions;

[Token(Token = "0x20000A6")]
internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A0")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x18

	[Token(Token = "0x170000CB")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x22677A0", Offset = "0x2266BA0", Length = "0x46")]
		[Token(Token = "0x600046F")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2264E70", Offset = "0x2264270", Length = "0x82")]
	[Token(Token = "0x600046D")]
	public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args) { }

	[Address(RVA = "0x22677A0", Offset = "0x2266BA0", Length = "0x46")]
	[Token(Token = "0x600046F")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x22676D0", Offset = "0x2266AD0", Length = "0x54")]
	[Token(Token = "0x600046E")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2267730", Offset = "0x2266B30", Length = "0x66")]
	[Token(Token = "0x6000470")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

