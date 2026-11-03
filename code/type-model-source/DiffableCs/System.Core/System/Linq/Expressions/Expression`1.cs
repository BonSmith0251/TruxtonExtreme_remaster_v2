namespace System.Linq.Expressions;

[Token(Token = "0x2000091")]
public class Expression : LambdaExpression
{

	[Token(Token = "0x170000AB")]
	internal virtual Type PublicType
	{
		[Address(RVA = "0xE42860", Offset = "0xE41C60", Length = "0x39")]
		[Token(Token = "0x6000424")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x170000AA")]
	internal virtual Type TypeCore
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x6000423")]
		internal get { } //Length: 56
	}

	[Address(RVA = "0x1BB1640", Offset = "0x1BB0A40", Length = "0x8")]
	[Token(Token = "0x6000422")]
	internal Expression`1(Expression body) { }

	[Address(RVA = "0x1BB1230", Offset = "0x1BB0630", Length = "0x5A")]
	[Token(Token = "0x6000428")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x1BB1420", Offset = "0x1BB0820", Length = "0xD8")]
	[Token(Token = "0x6000425")]
	public TDelegate Compile() { }

	[Address(RVA = "0x1BB1290", Offset = "0x1BB0690", Length = "0xCC")]
	[Token(Token = "0x6000426")]
	public TDelegate Compile(bool preferInterpretation) { }

	[Address(RVA = "0xE42860", Offset = "0xE41C60", Length = "0x39")]
	[Token(Token = "0x6000424")]
	internal virtual Type get_PublicType() { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x6000423")]
	internal virtual Type get_TypeCore() { }

	[Address(RVA = "0x1BB1620", Offset = "0x1BB0A20", Length = "0x1B")]
	[ExcludeFromCodeCoverage]
	[Token(Token = "0x6000427")]
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

