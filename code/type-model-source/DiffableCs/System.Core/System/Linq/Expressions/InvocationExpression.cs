namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
[Token(Token = "0x2000086")]
public class InvocationExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016B")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016C")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18

	[ExcludeFromCodeCoverage]
	[Token(Token = "0x17000090")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x2265CA0", Offset = "0x22650A0", Length = "0x27")]
		[Token(Token = "0x60003E9")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700008F")]
	public Expression Expression
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008E")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
		[Token(Token = "0x60003E6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700008D")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2265C10", Offset = "0x2265010", Length = "0x82")]
	[Token(Token = "0x60003E4")]
	internal InvocationExpression(Expression expression, Type returnType) { }

	[Address(RVA = "0x2265B80", Offset = "0x2264F80", Length = "0x2F")]
	[Token(Token = "0x60003EA")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2265CA0", Offset = "0x22650A0", Length = "0x27")]
	[Token(Token = "0x60003E9")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003E7")]
	public Expression get_Expression() { }

	[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
	[Token(Token = "0x60003E6")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003E5")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2265BB0", Offset = "0x2264FB0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60003E8")]
	public override Expression GetArgument(int index) { }

	[Address(RVA = "0x2265BE0", Offset = "0x2264FE0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x60003EB")]
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

