namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
[Token(Token = "0x20000C2")]
public sealed class TypeBinaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CF")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D0")]
	private readonly Type <TypeOperand>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700012C")]
	public Expression Expression
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600054B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012B")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600054A")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700012A")]
	public virtual Type Type
	{
		[Address(RVA = "0x224EA20", Offset = "0x224DE20", Length = "0x32")]
		[Token(Token = "0x6000549")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700012D")]
	public Type TypeOperand
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600054C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226BE40", Offset = "0x226B240", Length = "0x93")]
	[Token(Token = "0x6000548")]
	internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	[Address(RVA = "0x226BD50", Offset = "0x226B150", Length = "0x2F")]
	[Token(Token = "0x600054D")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600054B")]
	public Expression get_Expression() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600054A")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x224EA20", Offset = "0x224DE20", Length = "0x32")]
	[Token(Token = "0x6000549")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600054C")]
	public Type get_TypeOperand() { }

	[Address(RVA = "0x226BD80", Offset = "0x226B180", Length = "0xB2")]
	[Token(Token = "0x600054E")]
	public TypeBinaryExpression Update(Expression expression) { }

}

