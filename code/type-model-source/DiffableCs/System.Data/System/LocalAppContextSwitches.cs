namespace System;

[Token(Token = "0x2000006")]
internal static class LocalAppContextSwitches
{
	[Token(Token = "0x4000003")]
	private static int s_allowArbitraryTypeInstantiation; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	public static bool AllowArbitraryTypeInstantiation
	{
		[Address(RVA = "0x230F160", Offset = "0x230E560", Length = "0x62")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x230F160", Offset = "0x230E560", Length = "0x62")]
	[Token(Token = "0x6000008")]
	public static bool get_AllowArbitraryTypeInstantiation() { }

}

