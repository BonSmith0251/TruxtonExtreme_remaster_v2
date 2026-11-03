namespace Steamworks;

[Token(Token = "0x2000029")]
public static class SteamVideo
{

	[Address(RVA = "0x645620", Offset = "0x644A20", Length = "0xBA")]
	[Token(Token = "0x60004B2")]
	public static void GetOPFSettings(AppId_t unVideoAppID) { }

	[Address(RVA = "0x6456E0", Offset = "0x644AE0", Length = "0x16D")]
	[Token(Token = "0x60004B3")]
	public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize) { }

	[Address(RVA = "0x645850", Offset = "0x644C50", Length = "0xBA")]
	[Token(Token = "0x60004B0")]
	public static void GetVideoURL(AppId_t unVideoAppID) { }

	[Address(RVA = "0x645910", Offset = "0x644D10", Length = "0xC1")]
	[Token(Token = "0x60004B1")]
	public static bool IsBroadcasting(out int pnNumViewers) { }

}

