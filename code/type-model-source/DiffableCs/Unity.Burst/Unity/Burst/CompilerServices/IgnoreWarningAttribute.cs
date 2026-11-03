namespace Unity.Burst.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[Token(Token = "0x200005A")]
public class IgnoreWarningAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E51")]
	public IgnoreWarningAttribute(int warning) { }

}

