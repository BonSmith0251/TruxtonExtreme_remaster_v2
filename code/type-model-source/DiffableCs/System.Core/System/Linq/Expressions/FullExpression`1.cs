namespace System.Linq.Expressions;

[Token(Token = "0x2000098")]
internal sealed class FullExpression : ExpressionN<TDelegate>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000189")]
	private readonly string <NameCore>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018A")]
	private readonly bool <TailCallCore>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170000B1")]
	internal virtual string NameCore
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600043F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000B2")]
	internal virtual bool TailCallCore
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000440")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1C0F430", Offset = "0x1C0E830", Length = "0x5A")]
	[Token(Token = "0x600043E")]
	public FullExpression`1(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600043F")]
	internal virtual string get_NameCore() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000440")]
	internal virtual bool get_TailCallCore() { }

}

