namespace System.Linq.Expressions;

[Token(Token = "0x20000B7")]
internal sealed class ByRefParameterExpression : TypedParameterExpression
{

	[Address(RVA = "0x2254890", Offset = "0x2253C90", Length = "0x8")]
	[Token(Token = "0x60004B1")]
	internal ByRefParameterExpression(Type type, string name) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60004B2")]
	internal virtual bool GetIsByRef() { }

}

