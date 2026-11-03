namespace Mono.Interop;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x200004C")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60000AC")]
	public MonoPInvokeCallbackAttribute(Type t) { }

}

