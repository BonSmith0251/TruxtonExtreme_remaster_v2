namespace Steamworks;

[Token(Token = "0x20001B4")]
internal static class CSteamGameServerAPIContext
{
	[Token(Token = "0x4000AA4")]
	private static IntPtr m_pSteamClient; //Field offset: 0x0
	[Token(Token = "0x4000AA5")]
	private static IntPtr m_pSteamGameServer; //Field offset: 0x8
	[Token(Token = "0x4000AA6")]
	private static IntPtr m_pSteamUtils; //Field offset: 0x10
	[Token(Token = "0x4000AA7")]
	private static IntPtr m_pSteamNetworking; //Field offset: 0x18
	[Token(Token = "0x4000AA8")]
	private static IntPtr m_pSteamGameServerStats; //Field offset: 0x20
	[Token(Token = "0x4000AA9")]
	private static IntPtr m_pSteamHTTP; //Field offset: 0x28
	[Token(Token = "0x4000AAA")]
	private static IntPtr m_pSteamInventory; //Field offset: 0x30
	[Token(Token = "0x4000AAB")]
	private static IntPtr m_pSteamUGC; //Field offset: 0x38
	[Token(Token = "0x4000AAC")]
	private static IntPtr m_pSteamNetworkingUtils; //Field offset: 0x40
	[Token(Token = "0x4000AAD")]
	private static IntPtr m_pSteamNetworkingSockets; //Field offset: 0x48
	[Token(Token = "0x4000AAE")]
	private static IntPtr m_pSteamNetworkingMessages; //Field offset: 0x50

	[Address(RVA = "0x6060B0", Offset = "0x6054B0", Length = "0xEC")]
	[Token(Token = "0x60009B1")]
	internal static void Clear() { }

	[Address(RVA = "0x6061A0", Offset = "0x6055A0", Length = "0x36")]
	[Token(Token = "0x60009B3")]
	internal static IntPtr GetSteamClient() { }

	[Address(RVA = "0x606220", Offset = "0x605620", Length = "0x37")]
	[Token(Token = "0x60009B4")]
	internal static IntPtr GetSteamGameServer() { }

	[Address(RVA = "0x6061E0", Offset = "0x6055E0", Length = "0x37")]
	[Token(Token = "0x60009B7")]
	internal static IntPtr GetSteamGameServerStats() { }

	[Address(RVA = "0x606260", Offset = "0x605660", Length = "0x37")]
	[Token(Token = "0x60009B8")]
	internal static IntPtr GetSteamHTTP() { }

	[Address(RVA = "0x6062A0", Offset = "0x6056A0", Length = "0x37")]
	[Token(Token = "0x60009B9")]
	internal static IntPtr GetSteamInventory() { }

	[Address(RVA = "0x6063A0", Offset = "0x6057A0", Length = "0x37")]
	[Token(Token = "0x60009B6")]
	internal static IntPtr GetSteamNetworking() { }

	[Address(RVA = "0x6062E0", Offset = "0x6056E0", Length = "0x37")]
	[Token(Token = "0x60009BD")]
	internal static IntPtr GetSteamNetworkingMessages() { }

	[Address(RVA = "0x606320", Offset = "0x605720", Length = "0x37")]
	[Token(Token = "0x60009BC")]
	internal static IntPtr GetSteamNetworkingSockets() { }

	[Address(RVA = "0x606360", Offset = "0x605760", Length = "0x37")]
	[Token(Token = "0x60009BB")]
	internal static IntPtr GetSteamNetworkingUtils() { }

	[Address(RVA = "0x6063E0", Offset = "0x6057E0", Length = "0x37")]
	[Token(Token = "0x60009BA")]
	internal static IntPtr GetSteamUGC() { }

	[Address(RVA = "0x606420", Offset = "0x605820", Length = "0x37")]
	[Token(Token = "0x60009B5")]
	internal static IntPtr GetSteamUtils() { }

	[Address(RVA = "0x606460", Offset = "0x605860", Length = "0x675")]
	[Token(Token = "0x60009B2")]
	internal static bool Init() { }

}

