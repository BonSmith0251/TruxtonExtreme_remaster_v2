namespace System.Linq.Expressions;

[Token(Token = "0x2000087")]
internal sealed class InvocationExpressionN : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016D")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x20

	[Token(Token = "0x17000091")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x2265B30", Offset = "0x2264F30", Length = "0x46")]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 70
	}

	[Address(RVA = "0x2265AF0", Offset = "0x2264EF0", Length = "0x38")]
	[Token(Token = "0x60003EC")]
	public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	[Address(RVA = "0x2265B30", Offset = "0x2264F30", Length = "0x46")]
	[Token(Token = "0x60003EE")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2265A20", Offset = "0x2264E20", Length = "0x54")]
	[Token(Token = "0x60003ED")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2265A80", Offset = "0x2264E80", Length = "0x6F")]
	[Token(Token = "0x60003EF")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

