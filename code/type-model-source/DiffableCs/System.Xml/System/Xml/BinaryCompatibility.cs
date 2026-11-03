namespace System.Xml;

[Token(Token = "0x20000E5")]
internal static class BinaryCompatibility
{

	[Token(Token = "0x170002E2")]
	public static bool TargetsAtLeast_Desktop_V4_5_2
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B9B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000B9B")]
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

