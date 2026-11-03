namespace System.Linq.Expressions;

[Token(Token = "0x20000A5")]
internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400019F")]
	private readonly Expression _instance; //Field offset: 0x18

	[Address(RVA = "0x2264E70", Offset = "0x2264270", Length = "0x82")]
	[Token(Token = "0x600046B")]
	public InstanceMethodCallExpression(MethodInfo method, Expression instance) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600046C")]
	internal virtual Expression GetInstance() { }

}

