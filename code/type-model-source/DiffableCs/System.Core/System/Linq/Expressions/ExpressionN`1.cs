namespace System.Linq.Expressions;

[Token(Token = "0x2000097")]
internal class ExpressionN : Expression<TDelegate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000188")]
	private IReadOnlyList<ParameterExpression> _parameters; //Field offset: 0x0

	[Token(Token = "0x170000B0")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x1BB11E0", Offset = "0x1BB05E0", Length = "0x46")]
		[Token(Token = "0x600043B")]
		internal get { } //Length: 70
	}

	[Address(RVA = "0x1BB0540", Offset = "0x1BAF940", Length = "0x3D")]
	[Token(Token = "0x600043A")]
	public ExpressionN`1(Expression body, IReadOnlyList<ParameterExpression> parameters) { }

	[Address(RVA = "0x1BB11E0", Offset = "0x1BB05E0", Length = "0x46")]
	[Token(Token = "0x600043B")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0x1BB1060", Offset = "0x1BB0460", Length = "0xAE")]
	[Token(Token = "0x600043C")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x1BB1110", Offset = "0x1BB0510", Length = "0xC3")]
	[Token(Token = "0x600043D")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

