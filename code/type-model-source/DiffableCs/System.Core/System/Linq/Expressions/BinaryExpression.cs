namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
[Token(Token = "0x2000042")]
public class BinaryExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CE")]
	private readonly Expression <Right>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CF")]
	private readonly Expression <Left>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000042")]
	public virtual bool CanReduce
	{
		[Address(RVA = "0x2232350", Offset = "0x2231750", Length = "0x25")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000046")]
	public LambdaExpression Conversion
	{
		[Address(RVA = "0x2232380", Offset = "0x2231780", Length = "0x14")]
		[Token(Token = "0x600019F")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000047")]
	public bool IsLifted
	{
		[Address(RVA = "0x22325B0", Offset = "0x22319B0", Length = "0x1BA")]
		[Token(Token = "0x60001A1")]
		 get { } //Length: 442
	}

	[Token(Token = "0x17000049")]
	internal bool IsLiftedLogical
	{
		[Address(RVA = "0x22323A0", Offset = "0x22317A0", Length = "0x182")]
		[Token(Token = "0x60001A4")]
		internal get { } //Length: 386
	}

	[Token(Token = "0x17000048")]
	public bool IsLiftedToNull
	{
		[Address(RVA = "0x2232530", Offset = "0x2231930", Length = "0x76")]
		[Token(Token = "0x60001A2")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700004A")]
	internal bool IsReferenceComparison
	{
		[Address(RVA = "0x2232770", Offset = "0x2231B70", Length = "0xEC")]
		[Token(Token = "0x60001A5")]
		internal get { } //Length: 236
	}

	[Token(Token = "0x17000044")]
	public Expression Left
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000196")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000045")]
	public MethodInfo Method
	{
		[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
		[Token(Token = "0x6000197")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000043")]
	public Expression Right
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000195")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22322C0", Offset = "0x22316C0", Length = "0x82")]
	[Token(Token = "0x6000192")]
	internal BinaryExpression(Expression left, Expression right) { }

	[Address(RVA = "0x2230460", Offset = "0x222F860", Length = "0x2F")]
	[Token(Token = "0x60001A3")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2232350", Offset = "0x2231750", Length = "0x25")]
	[Token(Token = "0x6000193")]
	public virtual bool get_CanReduce() { }

	[Address(RVA = "0x2232380", Offset = "0x2231780", Length = "0x14")]
	[Token(Token = "0x600019F")]
	public LambdaExpression get_Conversion() { }

	[Address(RVA = "0x22325B0", Offset = "0x22319B0", Length = "0x1BA")]
	[Token(Token = "0x60001A1")]
	public bool get_IsLifted() { }

	[Address(RVA = "0x22323A0", Offset = "0x22317A0", Length = "0x182")]
	[Token(Token = "0x60001A4")]
	internal bool get_IsLiftedLogical() { }

	[Address(RVA = "0x2232530", Offset = "0x2231930", Length = "0x76")]
	[Token(Token = "0x60001A2")]
	public bool get_IsLiftedToNull() { }

	[Address(RVA = "0x2232770", Offset = "0x2231B70", Length = "0xEC")]
	[Token(Token = "0x60001A5")]
	internal bool get_IsReferenceComparison() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000196")]
	public Expression get_Left() { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x6000197")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000195")]
	public Expression get_Right() { }

	[Address(RVA = "0x2230490", Offset = "0x222F890", Length = "0x20")]
	[Token(Token = "0x600019B")]
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60001A0")]
	internal override LambdaExpression GetConversion() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000198")]
	internal override MethodInfo GetMethod() { }

	[Address(RVA = "0x22305B0", Offset = "0x222F9B0", Length = "0xA")]
	[Token(Token = "0x6000194")]
	private static bool IsOpAssignment(ExpressionType op) { }

	[Address(RVA = "0x2231D00", Offset = "0x2231100", Length = "0x7B")]
	[Token(Token = "0x600019A")]
	public virtual Expression Reduce() { }

	[Address(RVA = "0x22305C0", Offset = "0x222F9C0", Length = "0x72F")]
	[Token(Token = "0x600019E")]
	private Expression ReduceIndex() { }

	[Address(RVA = "0x2230CF0", Offset = "0x22300F0", Length = "0x507")]
	[Token(Token = "0x600019D")]
	private Expression ReduceMember() { }

	[Address(RVA = "0x2231200", Offset = "0x2230600", Length = "0x9B5")]
	[Token(Token = "0x60001A6")]
	internal Expression ReduceUserdefinedLifted() { }

	[Address(RVA = "0x2231BC0", Offset = "0x2230FC0", Length = "0x138")]
	[Token(Token = "0x600019C")]
	private Expression ReduceVariable() { }

	[Address(RVA = "0x2231D80", Offset = "0x2231180", Length = "0x537")]
	[Token(Token = "0x6000199")]
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

}

