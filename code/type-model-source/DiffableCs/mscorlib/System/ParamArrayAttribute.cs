namespace System;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000123")]
public sealed class ParamArrayAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600095A")]
	public ParamArrayAttribute() { }

}

