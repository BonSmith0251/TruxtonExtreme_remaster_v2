namespace System.Runtime.Versioning;

[Token(Token = "0x20003D1")]
internal static class BinaryCompatibility
{
	[Token(Token = "0x4000F20")]
	public static readonly bool TargetsAtLeast_Desktop_V4_5; //Field offset: 0x0
	[Token(Token = "0x4000F21")]
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; //Field offset: 0x1

	[Address(RVA = "0x1EF87A0", Offset = "0x1EF7BA0", Length = "0x48")]
	[Token(Token = "0x6001D7C")]
	private static BinaryCompatibility() { }

}

