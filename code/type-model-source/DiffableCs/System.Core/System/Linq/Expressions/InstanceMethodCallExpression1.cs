namespace System.Linq.Expressions;

[Token(Token = "0x20000AF")]
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B1")]
	private object _arg0; //Field offset: 0x20

	[Token(Token = "0x170000D4")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000493")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2264890", Offset = "0x2263C90", Length = "0x32")]
	[Token(Token = "0x6000491")]
	public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000493")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2264730", Offset = "0x2263B30", Length = "0x91")]
	[Token(Token = "0x6000492")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x22647D0", Offset = "0x2263BD0", Length = "0xBD")]
	[Token(Token = "0x6000494")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

