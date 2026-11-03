namespace AOT;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x2000004")]
public class MonoPInvokeCallbackAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000003")]
	public MonoPInvokeCallbackAttribute(Type type) { }

}

