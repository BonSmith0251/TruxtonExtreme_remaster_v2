namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
[Token(Token = "0x200009A")]
public sealed class LoopExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018D")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018E")]
	private readonly LabelTarget <BreakLabel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018F")]
	private readonly LabelTarget <ContinueLabel>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000B7")]
	public Expression Body
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000446")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B8")]
	public LabelTarget BreakLabel
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000447")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B9")]
	public LabelTarget ContinueLabel
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000448")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B6")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2266610", Offset = "0x2265A10", Length = "0x6")]
		[Token(Token = "0x6000445")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B5")]
	public virtual Type Type
	{
		[Address(RVA = "0x2266620", Offset = "0x2265A20", Length = "0x57")]
		[Token(Token = "0x6000444")]
		 get { } //Length: 87
	}

	[Address(RVA = "0x2266570", Offset = "0x2265970", Length = "0x9F")]
	[Token(Token = "0x6000443")]
	internal LoopExpression(Expression body, LabelTarget break, LabelTarget continue) { }

	[Address(RVA = "0x22664B0", Offset = "0x22658B0", Length = "0x2F")]
	[Token(Token = "0x6000449")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000446")]
	public Expression get_Body() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000447")]
	public LabelTarget get_BreakLabel() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000448")]
	public LabelTarget get_ContinueLabel() { }

	[Address(RVA = "0x2266610", Offset = "0x2265A10", Length = "0x6")]
	[Token(Token = "0x6000445")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2266620", Offset = "0x2265A20", Length = "0x57")]
	[Token(Token = "0x6000444")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x22664E0", Offset = "0x22658E0", Length = "0x8E")]
	[Token(Token = "0x600044A")]
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }

}

