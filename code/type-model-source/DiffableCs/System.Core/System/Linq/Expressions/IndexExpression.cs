namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
[Token(Token = "0x2000085")]
public sealed class IndexExpression : Expression, IArgumentProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000168")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000169")]
	private readonly Expression <Object>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016A")]
	private readonly PropertyInfo <Indexer>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700008C")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x22643D0", Offset = "0x22637D0", Length = "0x46")]
		[Token(Token = "0x60003E1")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700008B")]
	public PropertyInfo Indexer
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000088")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2264420", Offset = "0x2263820", Length = "0x6")]
		[Token(Token = "0x60003DC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700008A")]
	public Expression Object
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000089")]
	public virtual Type Type
	{
		[Address(RVA = "0x2264430", Offset = "0x2263830", Length = "0x7F")]
		[Token(Token = "0x60003DD")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x2264320", Offset = "0x2263720", Length = "0xAC")]
	[Token(Token = "0x60003DB")]
	internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	[Address(RVA = "0x2264210", Offset = "0x2263610", Length = "0x2F")]
	[Token(Token = "0x60003E2")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x22643D0", Offset = "0x22637D0", Length = "0x46")]
	[Token(Token = "0x60003E1")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003DF")]
	public PropertyInfo get_Indexer() { }

	[Address(RVA = "0x2264420", Offset = "0x2263820", Length = "0x6")]
	[Token(Token = "0x60003DC")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003DE")]
	public Expression get_Object() { }

	[Address(RVA = "0x2264430", Offset = "0x2263830", Length = "0x7F")]
	[Token(Token = "0x60003DD")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2264240", Offset = "0x2263640", Length = "0x54")]
	[Token(Token = "0x60003E0")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x22642A0", Offset = "0x22636A0", Length = "0x76")]
	[Token(Token = "0x60003E3")]
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }

}

