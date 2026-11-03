namespace Mono.Util;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("UNITY")]
[Conditional("FULL_AOT_RUNTIME")]
[Conditional("MONOTOUCH")]
[Token(Token = "0x2000007")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000022")]
	public MonoPInvokeCallbackAttribute(Type t) { }

}

