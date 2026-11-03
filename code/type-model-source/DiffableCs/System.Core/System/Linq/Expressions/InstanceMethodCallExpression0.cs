namespace System.Linq.Expressions;

[Token(Token = "0x20000AE")]
internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
{

	[Token(Token = "0x170000D3")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600048F")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2264720", Offset = "0x2263B20", Length = "0x8")]
	[Token(Token = "0x600048D")]
	public InstanceMethodCallExpression0(MethodInfo method, Expression instance) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600048F")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264670", Offset = "0x2263A70", Length = "0x4E")]
	[Token(Token = "0x600048E")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x22646C0", Offset = "0x2263AC0", Length = "0x5D")]
	[Token(Token = "0x6000490")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

