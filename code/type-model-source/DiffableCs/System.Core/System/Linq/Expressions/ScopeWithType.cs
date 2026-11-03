namespace System.Linq.Expressions;

[Token(Token = "0x200006E")]
internal sealed class ScopeWithType : ScopeN
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000ED")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000064")]
	public virtual Type Type
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002C5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2269510", Offset = "0x2268910", Length = "0x32")]
	[Token(Token = "0x60002C4")]
	internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002C5")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x22693C0", Offset = "0x22687C0", Length = "0x144")]
	[Token(Token = "0x60002C6")]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

