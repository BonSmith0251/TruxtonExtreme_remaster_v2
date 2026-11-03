namespace TMPro;

[Extension]
[Token(Token = "0x200001E")]
public static class TMPro_ExtensionMethods
{

	[Address(RVA = "0x2EC4870", Offset = "0x2EC3C70", Length = "0xAF")]
	[Extension]
	[Token(Token = "0x6000128")]
	public static string ArrayToString(Char[] chars) { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Extension]
	[Token(Token = "0x600012F")]
	public static bool Compare(Color a, Color b) { }

	[Address(RVA = "0x2EC4A60", Offset = "0x2EC3E60", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000137")]
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Address(RVA = "0x2EC4950", Offset = "0x2EC3D50", Length = "0x35")]
	[Extension]
	[Token(Token = "0x600012D")]
	public static bool Compare(Color32 a, Color32 b) { }

	[Address(RVA = "0x2EC4990", Offset = "0x2EC3D90", Length = "0xC3")]
	[Extension]
	[Token(Token = "0x6000138")]
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

	[Address(RVA = "0x2EC4920", Offset = "0x2EC3D20", Length = "0x24")]
	[Extension]
	[Token(Token = "0x600012E")]
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Address(RVA = "0x2AD1B50", Offset = "0x2AD0F50", Length = "0x2B")]
	[Extension]
	[Token(Token = "0x6000130")]
	public static bool CompareRGB(Color a, Color b) { }

	[Address(RVA = "0x93FCD0", Offset = "0x93F0D0", Length = "0x99")]
	[Extension]
	[Token(Token = "0x600012C")]
	public static int FindInstanceID(List<T> list, T target) { }

	[Address(RVA = "0x2EC4BA0", Offset = "0x2EC3FA0", Length = "0x44")]
	[Extension]
	[Token(Token = "0x6000134")]
	internal static Color32 GammaToLinear(Color32 c) { }

	[Address(RVA = "0x2EC4AF0", Offset = "0x2EC3EF0", Length = "0xA8")]
	[Token(Token = "0x6000135")]
	private static byte GammaToLinear(byte value) { }

	[Address(RVA = "0x2EC4C80", Offset = "0x2EC4080", Length = "0xF8")]
	[Extension]
	[Token(Token = "0x600012B")]
	public static string IntToString(Int32[] unicodes, int start, int length) { }

	[Address(RVA = "0x2EC4BF0", Offset = "0x2EC3FF0", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000129")]
	public static string IntToString(Int32[] unicodes) { }

	[Address(RVA = "0x2EC4D80", Offset = "0x2EC4180", Length = "0x2E")]
	[Extension]
	[Token(Token = "0x6000136")]
	public static Color MinAlpha(Color c1, Color c2) { }

	[Address(RVA = "0x2EC4DB0", Offset = "0x2EC41B0", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x6000131")]
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Address(RVA = "0x2EC4E90", Offset = "0x2EC4290", Length = "0xAC")]
	[Extension]
	[Token(Token = "0x6000126")]
	internal static int TagToInt(string s) { }

	[Address(RVA = "0x2EC4DB0", Offset = "0x2EC41B0", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x6000132")]
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Address(RVA = "0x2EC4F40", Offset = "0x2EC4340", Length = "0xDF")]
	[Extension]
	[Token(Token = "0x6000133")]
	public static Color32 Tint(Color32 c1, float tint) { }

	[Address(RVA = "0x2EC5020", Offset = "0x2EC4420", Length = "0x9F")]
	[Extension]
	[Token(Token = "0x6000127")]
	public static Int32[] ToIntArray(string text) { }

	[Address(RVA = "0x2EC50C0", Offset = "0x2EC44C0", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x600012A")]
	internal static string UintToString(List<UInt32> unicodes) { }

}

