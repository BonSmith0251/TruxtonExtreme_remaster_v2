namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Method (64))]
[Token(Token = "0x2000013")]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute
{

	[Address(RVA = "0x3165D30", Offset = "0x3165130", Length = "0x1A")]
	[Token(Token = "0x600002C")]
	public FreeFunctionAttribute() { }

	[Address(RVA = "0x3165D50", Offset = "0x3165150", Length = "0x1B")]
	[Token(Token = "0x600002D")]
	public FreeFunctionAttribute(string name) { }

	[Address(RVA = "0x3165D70", Offset = "0x3165170", Length = "0x2C")]
	[Token(Token = "0x600002E")]
	public FreeFunctionAttribute(string name, bool isThreadSafe) { }

}

