namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
[Token(Token = "0x2000075")]
public class ConditionalExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FD")]
	private readonly Expression <Test>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000FE")]
	private readonly Expression <IfTrue>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000072")]
	public Expression IfFalse
	{
		[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
		[Token(Token = "0x60002EC")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000071")]
	public Expression IfTrue
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006E")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000070")]
	public Expression Test
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002EA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006F")]
	public virtual Type Type
	{
		[Address(RVA = "0x2230430", Offset = "0x222F830", Length = "0x2A")]
		[Token(Token = "0x60002E9")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x22558D0", Offset = "0x2254CD0", Length = "0x82")]
	[Token(Token = "0x60002E6")]
	internal ConditionalExpression(Expression test, Expression ifTrue) { }

	[Address(RVA = "0x2255550", Offset = "0x2254950", Length = "0x2F")]
	[Token(Token = "0x60002EE")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x60002EC")]
	public Expression get_IfFalse() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002EB")]
	public Expression get_IfTrue() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x60002E8")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002EA")]
	public Expression get_Test() { }

	[Address(RVA = "0x2230430", Offset = "0x222F830", Length = "0x2A")]
	[Token(Token = "0x60002E9")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2255580", Offset = "0x2254980", Length = "0x52")]
	[Token(Token = "0x60002ED")]
	internal override Expression GetFalse() { }

	[Address(RVA = "0x22555E0", Offset = "0x22549E0", Length = "0x219")]
	[Token(Token = "0x60002E7")]
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[Address(RVA = "0x2255800", Offset = "0x2254C00", Length = "0xC5")]
	[Token(Token = "0x60002EF")]
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }

}

