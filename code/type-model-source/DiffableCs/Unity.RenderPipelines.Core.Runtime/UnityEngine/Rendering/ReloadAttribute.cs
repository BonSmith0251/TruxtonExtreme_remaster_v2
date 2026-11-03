namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000061")]
public sealed class ReloadAttribute : Attribute
{
	[Token(Token = "0x2000062")]
	internal enum Package : int
	{
		Builtin = 0,
		Root = 1,
		BuiltinExtra = 2,
	}


	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000566")]
	public ReloadAttribute(String[] paths, Package package = 1) { }

	[Address(RVA = "0x2BE6690", Offset = "0x2BE5A90", Length = "0x77")]
	[Token(Token = "0x6000567")]
	public ReloadAttribute(string path, Package package = 1) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000568")]
	public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = 1) { }

}

