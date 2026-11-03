namespace Unity.Properties;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x200000B")]
public class DontCreatePropertyAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600001C")]
	public DontCreatePropertyAttribute() { }

}

