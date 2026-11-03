namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
[Token(Token = "0x200008E")]
public sealed class LabelExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017D")]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017E")]
	private readonly Expression <DefaultValue>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700009B")]
	public Expression DefaultValue
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600040C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000099")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x9DCD90", Offset = "0x9DC190", Length = "0x6")]
		[Token(Token = "0x600040A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700009A")]
	public LabelTarget Target
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600040B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000098")]
	public virtual Type Type
	{
		[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
		[Token(Token = "0x6000409")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2265D90", Offset = "0x2265190", Length = "0x82")]
	[Token(Token = "0x6000408")]
	internal LabelExpression(LabelTarget label, Expression defaultValue) { }

	[Address(RVA = "0x2265CD0", Offset = "0x22650D0", Length = "0x2F")]
	[Token(Token = "0x600040D")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600040C")]
	public Expression get_DefaultValue() { }

	[Address(RVA = "0x9DCD90", Offset = "0x9DC190", Length = "0x6")]
	[Token(Token = "0x600040A")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600040B")]
	public LabelTarget get_Target() { }

	[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
	[Token(Token = "0x6000409")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2265D00", Offset = "0x2265100", Length = "0x85")]
	[Token(Token = "0x600040E")]
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }

}

