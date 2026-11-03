namespace UnityEngine.Rendering;

[Token(Token = "0x20000ED")]
public static class DocumentationUtils
{

	[Address(RVA = "0x7D13C0", Offset = "0x7D07C0", Length = "0x22F")]
	[Token(Token = "0x6000861")]
	public static string GetHelpURL(TEnum mask = null) { }

	[Address(RVA = "0x2C0DBA0", Offset = "0x2C0CFA0", Length = "0x7B")]
	[Token(Token = "0x6000862")]
	public static bool TryGetHelpURL(Type type, out string url) { }

}

