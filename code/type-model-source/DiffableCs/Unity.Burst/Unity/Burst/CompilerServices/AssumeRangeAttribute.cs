namespace Unity.Burst.CompilerServices;

[AttributeUsage(10240)]
[Token(Token = "0x2000057")]
public class AssumeRangeAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E4A")]
	public AssumeRangeAttribute(long min, long max) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E4B")]
	public AssumeRangeAttribute(ulong min, ulong max) { }

}

