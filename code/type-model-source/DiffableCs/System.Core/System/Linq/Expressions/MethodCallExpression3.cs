namespace System.Linq.Expressions;

[Token(Token = "0x20000AB")]
internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A5")]
	private object _arg0; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A6")]
	private readonly Expression _arg1; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A7")]
	private readonly Expression _arg2; //Field offset: 0x28

	[Token(Token = "0x170000D0")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000483")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2266FC0", Offset = "0x22663C0", Length = "0xB1")]
	[Token(Token = "0x6000481")]
	public MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000483")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2266DE0", Offset = "0x22661E0", Length = "0xB9")]
	[Token(Token = "0x6000482")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2266EA0", Offset = "0x22662A0", Length = "0x11E")]
	[Token(Token = "0x6000484")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

