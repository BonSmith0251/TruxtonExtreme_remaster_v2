namespace System.Linq.Expressions;

[Token(Token = "0x20000B1")]
internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B4")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B5")]
	private readonly Expression _arg1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B6")]
	private readonly Expression _arg2; //Field offset: 0x30

	[Token(Token = "0x170000D6")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600049B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2264CE0", Offset = "0x22640E0", Length = "0x56")]
	[Token(Token = "0x6000499")]
	public InstanceMethodCallExpression3(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x600049B")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264AE0", Offset = "0x2263EE0", Length = "0xB9")]
	[Token(Token = "0x600049A")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2264BA0", Offset = "0x2263FA0", Length = "0x13B")]
	[Token(Token = "0x600049C")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

