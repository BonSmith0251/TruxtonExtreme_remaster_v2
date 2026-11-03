namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TryExpressionProxy))]
[Token(Token = "0x20000C1")]
public sealed class TryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C9")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CA")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CB")]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001CC")]
	private readonly Expression <Finally>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001CD")]
	private readonly Expression <Fault>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000126")]
	public Expression Body
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000542")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000129")]
	public Expression Fault
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000545")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000128")]
	public Expression Finally
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000544")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000127")]
	public ReadOnlyCollection<CatchBlock> Handlers
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000543")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000125")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
		[Token(Token = "0x6000541")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000124")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000540")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226BC70", Offset = "0x226B070", Length = "0xC3")]
	[Token(Token = "0x600053F")]
	internal TryExpression(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[Address(RVA = "0x226BB40", Offset = "0x226AF40", Length = "0x2F")]
	[Token(Token = "0x6000546")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000542")]
	public Expression get_Body() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000545")]
	public Expression get_Fault() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000544")]
	public Expression get_Finally() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000543")]
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[Address(RVA = "0x226BD40", Offset = "0x226B140", Length = "0x6")]
	[Token(Token = "0x6000541")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000540")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x226BB70", Offset = "0x226AF70", Length = "0xFA")]
	[Token(Token = "0x6000547")]
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }

}

