namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
[Token(Token = "0x200009E")]
public class MemberExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000197")]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000BE")]
	public Expression Expression
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600044F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BD")]
	public MemberInfo Member
	{
		[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
		[Token(Token = "0x600044E")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000BF")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
		[Token(Token = "0x6000453")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x22668D0", Offset = "0x2265CD0", Length = "0x65")]
	[Token(Token = "0x6000450")]
	internal MemberExpression(Expression expression) { }

	[Address(RVA = "0x2266680", Offset = "0x2265A80", Length = "0x2F")]
	[Token(Token = "0x6000455")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600044F")]
	public Expression get_Expression() { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x600044E")]
	public MemberInfo get_Member() { }

	[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
	[Token(Token = "0x6000453")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x22666B0", Offset = "0x2265AB0", Length = "0x27")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000454")]
	internal override MemberInfo GetMember() { }

	[Address(RVA = "0x2266790", Offset = "0x2265B90", Length = "0xAE")]
	[Token(Token = "0x6000451")]
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	[Address(RVA = "0x22666E0", Offset = "0x2265AE0", Length = "0xAE")]
	[Token(Token = "0x6000452")]
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	[Address(RVA = "0x2266840", Offset = "0x2265C40", Length = "0x86")]
	[Token(Token = "0x6000456")]
	public MemberExpression Update(Expression expression) { }

}

