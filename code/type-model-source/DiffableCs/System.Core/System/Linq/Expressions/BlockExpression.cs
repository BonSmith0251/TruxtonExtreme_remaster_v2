namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
[Token(Token = "0x2000065")]
public class BlockExpression : Expression
{

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x1700005A")]
	internal override int ExpressionCount
	{
		[Address(RVA = "0x22536B0", Offset = "0x2252AB0", Length = "0x27")]
		[Token(Token = "0x6000296")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x17000056")]
	public ReadOnlyCollection<Expression> Expressions
	{
		[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
		[Token(Token = "0x600028F")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000058")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2253700", Offset = "0x2252B00", Length = "0x6")]
		[Token(Token = "0x6000293")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000059")]
	public virtual Type Type
	{
		[Address(RVA = "0x2253710", Offset = "0x2252B10", Length = "0x5B")]
		[Token(Token = "0x6000294")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000057")]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[Address(RVA = "0x1FCC1F0", Offset = "0x1FCB5F0", Length = "0x14")]
		[Token(Token = "0x6000290")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x2253660", Offset = "0x2252A60", Length = "0x49")]
	[Token(Token = "0x6000291")]
	internal BlockExpression() { }

	[Address(RVA = "0x22533F0", Offset = "0x22527F0", Length = "0x2F")]
	[Token(Token = "0x6000292")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x22536B0", Offset = "0x2252AB0", Length = "0x27")]
	[Token(Token = "0x6000296")]
	internal override int get_ExpressionCount() { }

	[Address(RVA = "0x22536E0", Offset = "0x2252AE0", Length = "0x14")]
	[Token(Token = "0x600028F")]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[Address(RVA = "0x2253700", Offset = "0x2252B00", Length = "0x6")]
	[Token(Token = "0x6000293")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2253710", Offset = "0x2252B10", Length = "0x5B")]
	[Token(Token = "0x6000294")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x1FCC1F0", Offset = "0x1FCB5F0", Length = "0x14")]
	[Token(Token = "0x6000290")]
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	[Address(RVA = "0x2253420", Offset = "0x2252820", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000295")]
	internal override Expression GetExpression(int index) { }

	[Address(RVA = "0x2253450", Offset = "0x2252850", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000297")]
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[Address(RVA = "0x2253480", Offset = "0x2252880", Length = "0x4E")]
	[Token(Token = "0x6000298")]
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[Address(RVA = "0x22534D0", Offset = "0x22528D0", Length = "0x15C")]
	[Token(Token = "0x600029A")]
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }

	[Address(RVA = "0x2253630", Offset = "0x2252A30", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000299")]
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

