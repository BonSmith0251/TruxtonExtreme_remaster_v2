namespace UnityEngine;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False)]
[Token(Token = "0x2000004")]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000003")]
	public WritableAttribute() { }

}

