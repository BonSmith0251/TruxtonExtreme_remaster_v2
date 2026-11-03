namespace Steamworks;

[Token(Token = "0x2000017")]
public static class SteamMatchmakingServers
{

	[Address(RVA = "0x5F3DA0", Offset = "0x5F31A0", Length = "0x4E")]
	[Token(Token = "0x60002D7")]
	public static void CancelQuery(HServerListRequest hRequest) { }

	[Address(RVA = "0x5F3DF0", Offset = "0x5F31F0", Length = "0x4C")]
	[Token(Token = "0x60002DF")]
	public static void CancelServerQuery(HServerQuery hServerQuery) { }

	[Address(RVA = "0x5F3E40", Offset = "0x5F3240", Length = "0x4E")]
	[Token(Token = "0x60002DA")]
	public static int GetServerCount(HServerListRequest hRequest) { }

	[Address(RVA = "0x5F3E90", Offset = "0x5F3290", Length = "0x11C")]
	[Token(Token = "0x60002D6")]
	public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x5F3FB0", Offset = "0x5F33B0", Length = "0x4E")]
	[Token(Token = "0x60002D9")]
	public static bool IsRefreshing(HServerListRequest hRequest) { }

	[Address(RVA = "0x5F4000", Offset = "0x5F3400", Length = "0xC5")]
	[Token(Token = "0x60002DC")]
	public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F40D0", Offset = "0x5F34D0", Length = "0xC5")]
	[Token(Token = "0x60002DD")]
	public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F41A0", Offset = "0x5F35A0", Length = "0x4E")]
	[Token(Token = "0x60002D8")]
	public static void RefreshQuery(HServerListRequest hRequest) { }

	[Address(RVA = "0x5F41F0", Offset = "0x5F35F0", Length = "0x5C")]
	[Token(Token = "0x60002DB")]
	public static void RefreshServer(HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x5F4250", Offset = "0x5F3650", Length = "0x4E")]
	[Token(Token = "0x60002D5")]
	public static void ReleaseRequest(HServerListRequest hServerListRequest) { }

	[Address(RVA = "0x5F42A0", Offset = "0x5F36A0", Length = "0x10D")]
	[Token(Token = "0x60002D2")]
	public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F43B0", Offset = "0x5F37B0", Length = "0x10D")]
	[Token(Token = "0x60002D1")]
	public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F44C0", Offset = "0x5F38C0", Length = "0x10D")]
	[Token(Token = "0x60002D3")]
	public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F45D0", Offset = "0x5F39D0", Length = "0x10D")]
	[Token(Token = "0x60002CF")]
	public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F46E0", Offset = "0x5F3AE0", Length = "0xB0")]
	[Token(Token = "0x60002D0")]
	public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F4790", Offset = "0x5F3B90", Length = "0x10D")]
	[Token(Token = "0x60002D4")]
	public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) { }

	[Address(RVA = "0x5F48A0", Offset = "0x5F3CA0", Length = "0xC5")]
	[Token(Token = "0x60002DE")]
	public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) { }

}

