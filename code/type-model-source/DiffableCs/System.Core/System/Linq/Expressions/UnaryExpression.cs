namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
[Token(Token = "0x20000C3")]
public sealed class UnaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D1")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D2")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D3")]
	private readonly Expression <Operand>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D4")]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000134")]
	public virtual bool CanReduce
	{
		[Address(RVA = "0x226D640", Offset = "0x226CA40", Length = "0x25")]
		[Token(Token = "0x6000557")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000132")]
	public bool IsLifted
	{
		[Address(RVA = "0x226D6F0", Offset = "0x226CAF0", Length = "0x26A")]
		[Token(Token = "0x6000554")]
		 get { } //Length: 618
	}

	[Token(Token = "0x17000133")]
	public bool IsLiftedToNull
	{
		[Address(RVA = "0x226D670", Offset = "0x226CA70", Length = "0x76")]
		[Token(Token = "0x6000555")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000135")]
	private bool IsPrefix
	{
		[Address(RVA = "0x226D960", Offset = "0x226CD60", Length = "0x4B")]
		[Token(Token = "0x6000559")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000131")]
	public MethodInfo Method
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000553")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012F")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000551")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000130")]
	public Expression Operand
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000552")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012E")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000550")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226D590", Offset = "0x226C990", Length = "0xA3")]
	[Token(Token = "0x600054F")]
	internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[Address(RVA = "0x226C150", Offset = "0x226B550", Length = "0x2F")]
	[Token(Token = "0x6000556")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x226C180", Offset = "0x226B580", Length = "0x140")]
	[Token(Token = "0x600055A")]
	private UnaryExpression FunctionalOp(Expression operand) { }

	[Address(RVA = "0x226D640", Offset = "0x226CA40", Length = "0x25")]
	[Token(Token = "0x6000557")]
	public virtual bool get_CanReduce() { }

	[Address(RVA = "0x226D6F0", Offset = "0x226CAF0", Length = "0x26A")]
	[Token(Token = "0x6000554")]
	public bool get_IsLifted() { }

	[Address(RVA = "0x226D670", Offset = "0x226CA70", Length = "0x76")]
	[Token(Token = "0x6000555")]
	public bool get_IsLiftedToNull() { }

	[Address(RVA = "0x226D960", Offset = "0x226CD60", Length = "0x4B")]
	[Token(Token = "0x6000559")]
	private bool get_IsPrefix() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000553")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000551")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000552")]
	public Expression get_Operand() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000550")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x226D440", Offset = "0x226C840", Length = "0x77")]
	[Token(Token = "0x6000558")]
	public virtual Expression Reduce() { }

	[Address(RVA = "0x226C2D0", Offset = "0x226B6D0", Length = "0x7FA")]
	[Token(Token = "0x600055D")]
	private Expression ReduceIndex() { }

	[Address(RVA = "0x226CAD0", Offset = "0x226BED0", Length = "0x61D")]
	[Token(Token = "0x600055C")]
	private Expression ReduceMember() { }

	[Address(RVA = "0x226D0F0", Offset = "0x226C4F0", Length = "0x349")]
	[Token(Token = "0x600055B")]
	private Expression ReduceVariable() { }

	[Address(RVA = "0x226D4C0", Offset = "0x226C8C0", Length = "0xC7")]
	[Token(Token = "0x600055E")]
	public UnaryExpression Update(Expression operand) { }

}

