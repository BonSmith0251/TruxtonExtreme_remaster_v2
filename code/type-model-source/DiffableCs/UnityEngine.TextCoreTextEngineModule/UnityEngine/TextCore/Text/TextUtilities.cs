namespace UnityEngine.TextCore.Text;

[Extension]
[Token(Token = "0x2000070")]
internal static class TextUtilities
{

	[Address(RVA = "0x31C9400", Offset = "0x31C8800", Length = "0x9F")]
	[Token(Token = "0x6000345")]
	public static int GetHashCodeCaseInSensitive(string s) { }

	[Address(RVA = "0x31C94A0", Offset = "0x31C88A0", Length = "0x8A")]
	[Token(Token = "0x6000346")]
	internal static int GetTextFontWeightIndex(TextFontWeight fontWeight) { }

	[Address(RVA = "0x31C9530", Offset = "0x31C8930", Length = "0x55")]
	[Token(Token = "0x6000344")]
	internal static char ToUpperFast(char c) { }

}

