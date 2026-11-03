namespace UnityEngine.Bindings;

[AttributeUsage(6140, Inherited = False)]
[Token(Token = "0x2000008")]
[VisibleToOtherModules]
internal class VisibleToOtherModulesAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600000A")]
	public VisibleToOtherModulesAttribute() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600000B")]
	public VisibleToOtherModulesAttribute(String[] modules) { }

}

