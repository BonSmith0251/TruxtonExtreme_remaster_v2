namespace Unity.Burst;

[Token(Token = "0x200002E")]
internal static class SafeStringArrayHelper
{

	[Address(RVA = "0x27E55B0", Offset = "0x27E49B0", Length = "0x27D")]
	[Token(Token = "0x60000E4")]
	public static String[] DeserialiseStringArraySafe(string input) { }

	[Address(RVA = "0x27E5830", Offset = "0x27E4C30", Length = "0x139")]
	[Token(Token = "0x60000E3")]
	public static string SerialiseStringArraySafe(String[] array) { }

}

