namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
[Token(Token = "0x20000A4")]
public class MethodCallExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400019E")]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x170000CA")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x2267880", Offset = "0x2266C80", Length = "0x27")]
		[Token(Token = "0x600046A")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000C8")]
	public MethodInfo Method
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000465")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C6")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x6000463")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000C9")]
	public Expression Object
	{
		[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
		[Token(Token = "0x6000466")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000C7")]
	public virtual Type Type
	{
		[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
		[Token(Token = "0x6000464")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x22669E0", Offset = "0x2265DE0", Length = "0x65")]
	[Token(Token = "0x6000461")]
	internal MethodCallExpression(MethodInfo method) { }

	[Address(RVA = "0x22677F0", Offset = "0x2266BF0", Length = "0x2F")]
	[Token(Token = "0x6000467")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2267880", Offset = "0x2266C80", Length = "0x27")]
	[Token(Token = "0x600046A")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000465")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x6000463")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
	[Token(Token = "0x6000466")]
	public Expression get_Object() { }

	[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
	[Token(Token = "0x6000464")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2267820", Offset = "0x2266C20", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000469")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000462")]
	internal override Expression GetInstance() { }

	[Address(RVA = "0x2267850", Offset = "0x2266C50", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000468")]
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

