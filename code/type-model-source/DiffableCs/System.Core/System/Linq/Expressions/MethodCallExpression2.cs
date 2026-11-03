namespace System.Linq.Expressions;

[Token(Token = "0x20000AA")]
internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A3")]
	private object _arg0; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A4")]
	private readonly Expression _arg1; //Field offset: 0x20

	[Token(Token = "0x170000CF")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600047F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2266D40", Offset = "0x2266140", Length = "0x9F")]
	[Token(Token = "0x600047D")]
	public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600047F")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2266BA0", Offset = "0x2265FA0", Length = "0xA5")]
	[Token(Token = "0x600047E")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2266C50", Offset = "0x2266050", Length = "0xEC")]
	[Token(Token = "0x6000480")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

