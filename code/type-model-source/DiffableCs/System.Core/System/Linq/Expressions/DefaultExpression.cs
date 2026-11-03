namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
[Token(Token = "0x200007B")]
public sealed class DefaultExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000104")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700007D")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2256780", Offset = "0x2255B80", Length = "0x6")]
		[Token(Token = "0x6000301")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700007C")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000300")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2256710", Offset = "0x2255B10", Length = "0x65")]
	[Token(Token = "0x60002FF")]
	internal DefaultExpression(Type type) { }

	[Address(RVA = "0x22566E0", Offset = "0x2255AE0", Length = "0x2F")]
	[Token(Token = "0x6000302")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2256780", Offset = "0x2255B80", Length = "0x6")]
	[Token(Token = "0x6000301")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000300")]
	public virtual Type get_Type() { }

}

