namespace System.Linq.Expressions;

[Token(Token = "0x20000A8")]
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
{

	[Token(Token = "0x170000CD")]
	public virtual int ArgumentCount
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000477")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x22669E0", Offset = "0x2265DE0", Length = "0x65")]
	[Token(Token = "0x6000475")]
	public MethodCallExpression0(MethodInfo method) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000477")]
	public virtual int get_ArgumentCount() { }

	[Address(RVA = "0x2266940", Offset = "0x2265D40", Length = "0x4E")]
	[Token(Token = "0x6000476")]
	public virtual Expression GetArgument(int index) { }

	[Address(RVA = "0x2266990", Offset = "0x2265D90", Length = "0x4D")]
	[Token(Token = "0x6000478")]
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

