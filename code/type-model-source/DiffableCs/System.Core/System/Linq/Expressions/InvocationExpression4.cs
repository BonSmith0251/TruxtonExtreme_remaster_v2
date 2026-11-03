namespace System.Linq.Expressions;

[Token(Token = "0x200008C")]
internal sealed class InvocationExpression4 : InvocationExpression
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000174")]
	private object _arg0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000175")]
	private readonly Expression _arg1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000176")]
	private readonly Expression _arg2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000177")]
	private readonly Expression _arg3; //Field offset: 0x38

	[Token(Token = "0x17000096")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000402")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2265710", Offset = "0x2264B10", Length = "0x68")]
	[Token(Token = "0x6000400")]
	public InvocationExpression4(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000402")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2265520", Offset = "0x2264920", Length = "0xCD")]
	[Token(Token = "0x6000401")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x22655F0", Offset = "0x22649F0", Length = "0x119")]
	[Token(Token = "0x6000403")]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

