namespace System.Linq.Expressions;

[Token(Token = "0x2000095")]
internal sealed class Expression2 : Expression<TDelegate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000183")]
	private object _par0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000184")]
	private readonly ParameterExpression _par1; //Field offset: 0x0

	[Token(Token = "0x170000AE")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000433")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1BB07E0", Offset = "0x1BAFBE0", Length = "0x5F")]
	[Token(Token = "0x6000432")]
	public Expression2`1(Expression body, ParameterExpression par0, ParameterExpression par1) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000433")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0x1BB0580", Offset = "0x1BAF980", Length = "0x90")]
	[Token(Token = "0x6000434")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x1BB0620", Offset = "0x1BAFA20", Length = "0x1B3")]
	[Token(Token = "0x6000435")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

