namespace System.Linq.Expressions;

[Token(Token = "0x200008B")]
internal sealed class InvocationExpression3 : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000171")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000172")]
	private readonly Expression _arg1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000173")]
	private readonly Expression _arg2; //Field offset: 0x30

	[Token(Token = "0x17000095")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60003FE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22654C0", Offset = "0x22648C0", Length = "0x56")]
	[Token(Token = "0x60003FC")]
	public InvocationExpression3(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60003FE")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2265300", Offset = "0x2264700", Length = "0xB9")]
	[Token(Token = "0x60003FD")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x22653C0", Offset = "0x22647C0", Length = "0xF5")]
	[Token(Token = "0x60003FF")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

