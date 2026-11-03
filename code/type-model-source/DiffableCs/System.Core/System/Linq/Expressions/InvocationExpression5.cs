namespace System.Linq.Expressions;

[Token(Token = "0x200008D")]
internal sealed class InvocationExpression5 : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000178")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000179")]
	private readonly Expression _arg1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017A")]
	private readonly Expression _arg2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017B")]
	private readonly Expression _arg3; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017C")]
	private readonly Expression _arg4; //Field offset: 0x40

	[Token(Token = "0x17000097")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x6000406")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22659A0", Offset = "0x2264DA0", Length = "0x7A")]
	[Token(Token = "0x6000404")]
	public InvocationExpression5(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x6000406")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2265780", Offset = "0x2264B80", Length = "0xE1")]
	[Token(Token = "0x6000405")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2265870", Offset = "0x2264C70", Length = "0x12F")]
	[Token(Token = "0x6000407")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

