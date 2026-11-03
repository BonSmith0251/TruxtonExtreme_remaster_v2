namespace System.Linq.Expressions;

[Token(Token = "0x20000B9")]
internal sealed class PrimitiveParameterExpression : ParameterExpression
{

	[Token(Token = "0x170000E1")]
	public virtual Type Type
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x60004B6")]
		 get { } //Length: 56
	}

	[Address(RVA = "0xE36D30", Offset = "0xE36130", Length = "0x8")]
	[Token(Token = "0x60004B5")]
	internal PrimitiveParameterExpression`1(string name) { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x60004B6")]
	public virtual Type get_Type() { }

}

