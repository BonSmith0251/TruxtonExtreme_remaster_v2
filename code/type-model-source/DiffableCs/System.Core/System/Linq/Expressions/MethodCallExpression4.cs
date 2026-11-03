namespace System.Linq.Expressions;

[Token(Token = "0x20000AC")]
internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A8")]
	private object _arg0; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A9")]
	private readonly Expression _arg1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AA")]
	private readonly Expression _arg2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001AB")]
	private readonly Expression _arg3; //Field offset: 0x30

	[Token(Token = "0x170000D1")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000487")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22672B0", Offset = "0x22666B0", Length = "0xC3")]
	[Token(Token = "0x6000485")]
	public MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000487")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2267080", Offset = "0x2266480", Length = "0xCD")]
	[Token(Token = "0x6000486")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2267150", Offset = "0x2266550", Length = "0x159")]
	[Token(Token = "0x6000488")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

