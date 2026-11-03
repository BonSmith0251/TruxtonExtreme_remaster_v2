namespace System.Linq.Expressions;

[Token(Token = "0x2000077")]
internal sealed class FullConditionalExpressionWithType : FullConditionalExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000100")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000073")]
	public virtual Type Type
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002F3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2263B50", Offset = "0x2262F50", Length = "0x44")]
	[Token(Token = "0x60002F2")]
	internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002F3")]
	public virtual Type get_Type() { }

}

