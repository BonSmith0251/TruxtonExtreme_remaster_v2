namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000043")]
public class UnityWebRequestUtilities
{
	[Token(Token = "0x40000A9")]
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL"; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600017E")]
	public UnityWebRequestUtilities() { }

	[Address(RVA = "0x2E50FD0", Offset = "0x2E503D0", Length = "0x9D")]
	[Token(Token = "0x600017A")]
	public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op) { }

	[Address(RVA = "0x2E511D0", Offset = "0x2E505D0", Length = "0x49")]
	[Conditional("ADDRESSABLES_LOG_ALL")]
	[Token(Token = "0x600017C")]
	internal static void Log(string msg) { }

	[Address(RVA = "0x2E51070", Offset = "0x2E50470", Length = "0x49")]
	[Token(Token = "0x600017D")]
	internal static void LogError(string msg) { }

	[Address(RVA = "0x2E510C0", Offset = "0x2E504C0", Length = "0x103")]
	[Token(Token = "0x600017B")]
	internal static void LogOperationResult(AsyncOperation op) { }

	[Address(RVA = "0x2E51220", Offset = "0x2E50620", Length = "0x141")]
	[Token(Token = "0x6000179")]
	public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result) { }

}

