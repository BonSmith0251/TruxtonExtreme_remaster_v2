namespace System.Linq.Expressions;

[Token(Token = "0x20000AD")]
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AC")]
	private object _arg0; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AD")]
	private readonly Expression _arg1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AE")]
	private readonly Expression _arg2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AF")]
	private readonly Expression _arg3; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B0")]
	private readonly Expression _arg4; //Field offset: 0x38

	[Token(Token = "0x170000D2")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x600048B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22675F0", Offset = "0x22669F0", Length = "0xD5")]
	[Token(Token = "0x6000489")]
	public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x600048B")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2267380", Offset = "0x2266780", Length = "0xE1")]
	[Token(Token = "0x600048A")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2267470", Offset = "0x2266870", Length = "0x177")]
	[Token(Token = "0x600048C")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

