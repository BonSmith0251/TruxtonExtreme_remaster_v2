namespace System.Linq.Expressions;

[Token(Token = "0x20000A7")]
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A1")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x20

	[Token(Token = "0x170000CC")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x2264E20", Offset = "0x2264220", Length = "0x46")]
		[Token(Token = "0x6000473")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2264890", Offset = "0x2263C90", Length = "0x32")]
	[Token(Token = "0x6000471")]
	public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	[Address(RVA = "0x2264E20", Offset = "0x2264220", Length = "0x46")]
	[Token(Token = "0x6000473")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264D40", Offset = "0x2264140", Length = "0x54")]
	[Token(Token = "0x6000472")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2264DA0", Offset = "0x22641A0", Length = "0x76")]
	[Token(Token = "0x6000474")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

