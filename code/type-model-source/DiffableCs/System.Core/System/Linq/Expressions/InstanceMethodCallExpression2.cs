namespace System.Linq.Expressions;

[Token(Token = "0x20000B0")]
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B2")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B3")]
	private readonly Expression _arg1; //Field offset: 0x28

	[Token(Token = "0x170000D5")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000497")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2264A90", Offset = "0x2263E90", Length = "0x44")]
	[Token(Token = "0x6000495")]
	public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000497")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x22648D0", Offset = "0x2263CD0", Length = "0xA5")]
	[Token(Token = "0x6000496")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2264980", Offset = "0x2263D80", Length = "0x103")]
	[Token(Token = "0x6000498")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

