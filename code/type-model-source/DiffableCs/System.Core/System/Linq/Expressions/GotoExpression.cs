namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
[Token(Token = "0x2000082")]
public sealed class GotoExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000164")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000165")]
	private readonly Expression <Value>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000166")]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000167")]
	private readonly GotoExpressionKind <Kind>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000085")]
	public GotoExpressionKind Kind
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003D4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000082")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2263EC0", Offset = "0x22632C0", Length = "0x6")]
		[Token(Token = "0x60003D1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000084")]
	public LabelTarget Target
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000081")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000083")]
	public Expression Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2263E10", Offset = "0x2263210", Length = "0xA3")]
	[Token(Token = "0x60003CF")]
	internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[Address(RVA = "0x2263D20", Offset = "0x2263120", Length = "0x2F")]
	[Token(Token = "0x60003D5")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60003D4")]
	public GotoExpressionKind get_Kind() { }

	[Address(RVA = "0x2263EC0", Offset = "0x22632C0", Length = "0x6")]
	[Token(Token = "0x60003D1")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003D3")]
	public LabelTarget get_Target() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003D0")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60003D2")]
	public Expression get_Value() { }

	[Address(RVA = "0x2263D50", Offset = "0x2263150", Length = "0xB7")]
	[Token(Token = "0x60003D6")]
	public GotoExpression Update(LabelTarget target, Expression value) { }

}

