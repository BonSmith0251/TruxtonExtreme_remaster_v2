namespace System.Linq.Expressions;

[Token(Token = "0x2000094")]
internal sealed class Expression1 : Expression<TDelegate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000182")]
	private object _par0; //Field offset: 0x0

	[Token(Token = "0x170000AD")]
	internal virtual int ParameterCount
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600042F")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1BB0540", Offset = "0x1BAF940", Length = "0x3D")]
	[Token(Token = "0x600042E")]
	public Expression1`1(Expression body, ParameterExpression par0) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600042F")]
	internal virtual int get_ParameterCount() { }

	[Address(RVA = "0x1BB03A0", Offset = "0x1BAF7A0", Length = "0x77")]
	[Token(Token = "0x6000430")]
	internal virtual ParameterExpression GetParameter(int index) { }

	[Address(RVA = "0x1BB0420", Offset = "0x1BAF820", Length = "0x116")]
	[Token(Token = "0x6000431")]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

