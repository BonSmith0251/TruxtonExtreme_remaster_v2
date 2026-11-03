namespace KANAI.Network;

[Token(Token = "0x2000004")]
public static class API
{
	[Token(Token = "0x2000005")]
	internal enum EntryPoint : int
	{
		Auth = 0,
		Rpc = 1,
	}


	[Address(RVA = "0x1DFE710", Offset = "0x1DFDB10", Length = "0x4F")]
	[Token(Token = "0x6000004")]
	public static string CreateJsonString(string result) { }

	[Address(RVA = "0x1DFE760", Offset = "0x1DFDB60", Length = "0xB3")]
	[Token(Token = "0x6000006")]
	public static int GetClientError(HTTPRequest request) { }

	[Address(RVA = "0x1DFE820", Offset = "0x1DFDC20", Length = "0x4BE")]
	[Token(Token = "0x6000003")]
	public static int GetResponseJson(ref string json, HTTPRequest request, RequestCryptor cryptor, string lastPattern) { }

	[Address(RVA = "0x6DAB60", Offset = "0x6D9F60", Length = "0x307")]
	[Token(Token = "0x6000005")]
	public static JsonResponse<T> GetResult(HTTPRequest request, string forceJson = null) { }

}

