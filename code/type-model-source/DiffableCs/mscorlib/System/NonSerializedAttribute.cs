namespace System;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[Token(Token = "0x2000116")]
public sealed class NonSerializedAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60008CD")]
	public NonSerializedAttribute() { }

}

