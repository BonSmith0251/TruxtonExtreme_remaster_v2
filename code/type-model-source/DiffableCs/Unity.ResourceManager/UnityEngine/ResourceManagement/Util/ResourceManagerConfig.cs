namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000041")]
public static class ResourceManagerConfig
{

	[Address(RVA = "0x2E48C20", Offset = "0x2E48020", Length = "0x188")]
	[Token(Token = "0x6000174")]
	public static Array CreateArrayResult(Type type, Object[] allAssets) { }

	[Address(RVA = "0x8E9F80", Offset = "0x8E9380", Length = "0x8E")]
	[Token(Token = "0x6000175")]
	public static TObject CreateArrayResult(Object[] allAssets) { }

	[Address(RVA = "0x2E48DB0", Offset = "0x2E481B0", Length = "0x191")]
	[Token(Token = "0x6000176")]
	public static IList CreateListResult(Type type, Object[] allAssets) { }

	[Address(RVA = "0x8EA010", Offset = "0x8E9410", Length = "0xEF")]
	[Token(Token = "0x6000177")]
	public static TObject CreateListResult(Object[] allAssets) { }

	[Address(RVA = "0x2E48F50", Offset = "0x2E48350", Length = "0xED")]
	[Token(Token = "0x600016F")]
	public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey) { }

	[Address(RVA = "0x8EA100", Offset = "0x8E9500", Length = "0x7F")]
	[Token(Token = "0x6000178")]
	public static bool IsInstance() { }

	[Address(RVA = "0x2E49040", Offset = "0x2E48440", Length = "0x4F")]
	[Token(Token = "0x6000170")]
	public static bool IsPathRemote(string path) { }

	[Address(RVA = "0x2E49090", Offset = "0x2E48490", Length = "0xFF")]
	[Token(Token = "0x6000173")]
	private static bool PlatformCanLoadLocallyFromUrlPath() { }

	[Address(RVA = "0x2E49190", Offset = "0x2E48590", Length = "0x165")]
	[Token(Token = "0x6000172")]
	public static bool ShouldPathUseWebRequest(string path) { }

	[Address(RVA = "0x2E49300", Offset = "0x2E48700", Length = "0x3D")]
	[Token(Token = "0x6000171")]
	public static string StripQueryParameters(string path) { }

}

