namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
[Token(Token = "0x2000005")]
internal class MonoTODOAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000005")]
	public MonoTODOAttribute() { }

}

