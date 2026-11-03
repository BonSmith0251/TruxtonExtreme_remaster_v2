namespace System.Linq.Expressions;

[Token(Token = "0x20000A9")]
internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A2")]
	private object _arg0; //Field offset: 0x18

	[Token(Token = "0x170000CE")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600047B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2264E70", Offset = "0x2264270", Length = "0x82")]
	[Token(Token = "0x6000479")]
	public MethodCallExpression1(MethodInfo method, Expression arg0) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600047B")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2266A50", Offset = "0x2265E50", Length = "0x91")]
	[Token(Token = "0x600047A")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2266AF0", Offset = "0x2265EF0", Length = "0xAD")]
	[Token(Token = "0x600047C")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

