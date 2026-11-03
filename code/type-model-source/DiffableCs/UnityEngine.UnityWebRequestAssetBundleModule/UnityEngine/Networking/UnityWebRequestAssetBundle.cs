namespace UnityEngine.Networking;

[Token(Token = "0x2000002")]
public static class UnityWebRequestAssetBundle
{

	[Address(RVA = "0x347AC90", Offset = "0x347A090", Length = "0xB7")]
	[Token(Token = "0x6000001")]
	public static UnityWebRequest GetAssetBundle(string uri) { }

	[Address(RVA = "0x347ABB0", Offset = "0x3479FB0", Length = "0xD3")]
	[Token(Token = "0x6000002")]
	public static UnityWebRequest GetAssetBundle(Uri uri) { }

	[Address(RVA = "0x347A8C0", Offset = "0x3479CC0", Length = "0xB9")]
	[Token(Token = "0x6000003")]
	public static UnityWebRequest GetAssetBundle(string uri, uint crc) { }

	[Address(RVA = "0x347AAD0", Offset = "0x3479ED0", Length = "0xDE")]
	[Token(Token = "0x6000004")]
	public static UnityWebRequest GetAssetBundle(Uri uri, uint crc) { }

	[Address(RVA = "0x347A980", Offset = "0x3479D80", Length = "0x142")]
	[Token(Token = "0x6000005")]
	public static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0) { }

}

