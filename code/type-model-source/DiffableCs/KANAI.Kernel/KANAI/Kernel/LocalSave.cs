namespace KANAI.Kernel;

[Token(Token = "0x200001E")]
public class LocalSave
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600010F")]
	public LocalSave() { }

	[Address(RVA = "0x1DEA760", Offset = "0x1DE9B60", Length = "0x3D")]
	[Token(Token = "0x600010B")]
	public static void Clear(string key = null) { }

	[Address(RVA = "0x1DEA6F0", Offset = "0x1DE9AF0", Length = "0x6E")]
	[Token(Token = "0x600010C")]
	public static void ClearInt64(string key) { }

	[Address(RVA = "0x863940", Offset = "0x862D40", Length = "0x114")]
	[Token(Token = "0x600010D")]
	public static T Get(string key) { }

	[Address(RVA = "0x1DEA7A0", Offset = "0x1DE9BA0", Length = "0x7")]
	[Token(Token = "0x6000106")]
	public static float GetFloat(string key) { }

	[Address(RVA = "0x1DEA840", Offset = "0x1DE9C40", Length = "0x7")]
	[Token(Token = "0x6000104")]
	public static int GetInt(string key) { }

	[Address(RVA = "0x1DEA7B0", Offset = "0x1DE9BB0", Length = "0x84")]
	[Token(Token = "0x6000108")]
	public static long GetInt64(string key) { }

	[Address(RVA = "0x1DEA850", Offset = "0x1DE9C50", Length = "0x19")]
	[Token(Token = "0x6000102")]
	public static string GetString(string key) { }

	[Address(RVA = "0x1DEA870", Offset = "0x1DE9C70", Length = "0x7")]
	[Token(Token = "0x6000101")]
	public static bool HasKey(string key) { }

	[Address(RVA = "0x1DEA880", Offset = "0x1DE9C80", Length = "0x7")]
	[Token(Token = "0x600010A")]
	public static void Save() { }

	[Address(RVA = "0x863A60", Offset = "0x862E60", Length = "0xDF")]
	[Token(Token = "0x600010E")]
	public static void Set(string key, T value) { }

	[Address(RVA = "0x1DEA890", Offset = "0x1DE9C90", Length = "0x8")]
	[Token(Token = "0x6000107")]
	public static void SetFloat(string key, float value) { }

	[Address(RVA = "0x1DEA930", Offset = "0x1DE9D30", Length = "0x8")]
	[Token(Token = "0x6000105")]
	public static void SetInt(string key, int value) { }

	[Address(RVA = "0x1DEA8A0", Offset = "0x1DE9CA0", Length = "0x85")]
	[Token(Token = "0x6000109")]
	public static void SetInt64(string key, long value) { }

	[Address(RVA = "0x1DEA940", Offset = "0x1DE9D40", Length = "0x8")]
	[Token(Token = "0x6000103")]
	public static void SetString(string key, string value) { }

}

