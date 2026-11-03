namespace System.Linq.Expressions;

[Token(Token = "0x2000096")]
internal sealed class Expression3 : Expression<TDelegate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000185")]
	private object _par0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000186")]
	private readonly ParameterExpression _par1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000187")]
	private readonly ParameterExpression _par2; //Field offset: 0x0

	[Token(Token = "0x170000AF")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000437")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1BB0AF0", Offset = "0x1BAFEF0", Length = "0x71")]
	[Token(Token = "0x6000436")]
	public Expression3`1(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000437")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0x1BB0840", Offset = "0x1BAFC40", Length = "0xA9")]
	[Token(Token = "0x6000438")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x1BB08F0", Offset = "0x1BAFCF0", Length = "0x1FE")]
	[Token(Token = "0x6000439")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

