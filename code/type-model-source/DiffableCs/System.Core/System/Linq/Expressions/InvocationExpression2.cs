namespace System.Linq.Expressions;

[Token(Token = "0x200008A")]
internal sealed class InvocationExpression2 : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016F")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000170")]
	private readonly Expression _arg1; //Field offset: 0x28

	[Token(Token = "0x17000094")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60003FA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22652B0", Offset = "0x22646B0", Length = "0x44")]
	[Token(Token = "0x60003F8")]
	public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60003FA")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2265130", Offset = "0x2264530", Length = "0xA5")]
	[Token(Token = "0x60003F9")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x22651E0", Offset = "0x22645E0", Length = "0xCA")]
	[Token(Token = "0x60003FB")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

