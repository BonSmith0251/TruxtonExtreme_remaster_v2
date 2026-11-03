namespace System.Linq.Expressions;

[Token(Token = "0x2000089")]
internal sealed class InvocationExpression1 : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016E")]
	private object _arg0; //Field offset: 0x20

	[Token(Token = "0x17000093")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60003F6")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22650F0", Offset = "0x22644F0", Length = "0x32")]
	[Token(Token = "0x60003F4")]
	public InvocationExpression1(Expression lambda, Type returnType, Expression arg0) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60003F6")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264FB0", Offset = "0x22643B0", Length = "0x91")]
	[Token(Token = "0x60003F5")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2265050", Offset = "0x2264450", Length = "0x9B")]
	[Token(Token = "0x60003F7")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

