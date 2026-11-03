namespace Steamworks;

[Token(Token = "0x200000D")]
public static class SteamGameServerNetworkingSockets
{

	[Address(RVA = "0x5E2FF0", Offset = "0x5E23F0", Length = "0x4C")]
	[Token(Token = "0x6000142")]
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	[Address(RVA = "0x5E3040", Offset = "0x5E2440", Length = "0x4C")]
	[Token(Token = "0x6000168")]
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	[Address(RVA = "0x5E3090", Offset = "0x5E2490", Length = "0x149")]
	[Token(Token = "0x6000143")]
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	[Address(RVA = "0x5E31E0", Offset = "0x5E25E0", Length = "0x4C")]
	[Token(Token = "0x6000144")]
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	[Address(RVA = "0x5E3230", Offset = "0x5E2630", Length = "0x83")]
	[Token(Token = "0x6000152")]
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, Int32[] pLanePriorities, UInt16[] pLaneWeights) { }

	[Address(RVA = "0x5E32C0", Offset = "0x5E26C0", Length = "0xAE")]
	[Token(Token = "0x600013F")]
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E3440", Offset = "0x5E2840", Length = "0xC0")]
	[Token(Token = "0x6000141")]
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E3370", Offset = "0x5E2770", Length = "0xCA")]
	[Token(Token = "0x6000162")]
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E3500", Offset = "0x5E2900", Length = "0xC0")]
	[Token(Token = "0x600015C")]
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E35C0", Offset = "0x5E29C0", Length = "0x4C")]
	[Token(Token = "0x600016C")]
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }

	[Address(RVA = "0x5E3610", Offset = "0x5E2A10", Length = "0xAC")]
	[Token(Token = "0x6000160")]
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E36C0", Offset = "0x5E2AC0", Length = "0xAE")]
	[Token(Token = "0x600013E")]
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E3820", Offset = "0x5E2C20", Length = "0xAC")]
	[Token(Token = "0x6000140")]
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E3770", Offset = "0x5E2B70", Length = "0xAC")]
	[Token(Token = "0x600016A")]
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5E38D0", Offset = "0x5E2CD0", Length = "0x83")]
	[Token(Token = "0x6000156")]
	public static HSteamNetPollGroup CreatePollGroup() { }

	[Address(RVA = "0x5E3960", Offset = "0x5E2D60", Length = "0x92")]
	[Token(Token = "0x6000151")]
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	[Address(RVA = "0x5E3A00", Offset = "0x5E2E00", Length = "0x4C")]
	[Token(Token = "0x6000157")]
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x5E3A50", Offset = "0x5E2E50", Length = "0x73")]
	[Token(Token = "0x600015B")]
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x5E3AD0", Offset = "0x5E2ED0", Length = "0x4C")]
	[Token(Token = "0x600014B")]
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	[Address(RVA = "0x5E3B20", Offset = "0x5E2F20", Length = "0x4E")]
	[Token(Token = "0x6000155")]
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	[Address(RVA = "0x5E3B70", Offset = "0x5E2F70", Length = "0x74")]
	[Token(Token = "0x6000164")]
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x5E3BF0", Offset = "0x5E2FF0", Length = "0x5B")]
	[Token(Token = "0x600014D")]
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	[Address(RVA = "0x5E3C50", Offset = "0x5E3050", Length = "0x107")]
	[Token(Token = "0x6000148")]
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	[Address(RVA = "0x5E3D60", Offset = "0x5E3160", Length = "0x84")]
	[Token(Token = "0x600014E")]
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	[Address(RVA = "0x5E3DF0", Offset = "0x5E31F0", Length = "0x4C")]
	[Token(Token = "0x6000146")]
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	[Address(RVA = "0x5E3E40", Offset = "0x5E3240", Length = "0x106")]
	[Token(Token = "0x600014F")]
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	[Address(RVA = "0x5E3F50", Offset = "0x5E3350", Length = "0x5B")]
	[Token(Token = "0x6000169")]
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	[Address(RVA = "0x5E3FB0", Offset = "0x5E33B0", Length = "0x74")]
	[Token(Token = "0x6000161")]
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	[Address(RVA = "0x5E4030", Offset = "0x5E3430", Length = "0x4E")]
	[Token(Token = "0x600015F")]
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	[Address(RVA = "0x5E4080", Offset = "0x5E3480", Length = "0x4D")]
	[Token(Token = "0x600015E")]
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	[Address(RVA = "0x5E40D0", Offset = "0x5E34D0", Length = "0x44")]
	[Token(Token = "0x600015D")]
	public static ushort GetHostedDedicatedServerPort() { }

	[Address(RVA = "0x5E4120", Offset = "0x5E3520", Length = "0x4E")]
	[Token(Token = "0x6000153")]
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x5E4170", Offset = "0x5E3570", Length = "0x5B")]
	[Token(Token = "0x6000150")]
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	[Address(RVA = "0x5E41D0", Offset = "0x5E35D0", Length = "0x5B")]
	[Token(Token = "0x600016B")]
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	[Address(RVA = "0x5E4230", Offset = "0x5E3630", Length = "0x44")]
	[Token(Token = "0x6000154")]
	public static ESteamNetworkingAvailability InitAuthentication() { }

	[Address(RVA = "0x5E4420", Offset = "0x5E3820", Length = "0x73")]
	[Token(Token = "0x6000163")]
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	[Address(RVA = "0x5E44A0", Offset = "0x5E38A0", Length = "0x73")]
	[Token(Token = "0x600015A")]
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x5E4280", Offset = "0x5E3680", Length = "0xC4")]
	[Token(Token = "0x600014C")]
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5E4350", Offset = "0x5E3750", Length = "0xC4")]
	[Token(Token = "0x6000159")]
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5E4520", Offset = "0x5E3920", Length = "0x4E")]
	[Token(Token = "0x6000166")]
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x5E4570", Offset = "0x5E3970", Length = "0x44")]
	[Token(Token = "0x6000167")]
	public static void RunCallbacks() { }

	[Address(RVA = "0x5E4650", Offset = "0x5E3A50", Length = "0x72")]
	[Token(Token = "0x600014A")]
	public static void SendMessages(int nMessages, IntPtr[] pMessages, Int64[] pOutMessageNumberOrResult) { }

	[Address(RVA = "0x5E45C0", Offset = "0x5E39C0", Length = "0x8D")]
	[Token(Token = "0x6000149")]
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	[Address(RVA = "0x5E46D0", Offset = "0x5E3AD0", Length = "0x73")]
	[Token(Token = "0x6000165")]
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x5E4750", Offset = "0x5E3B50", Length = "0x110")]
	[Token(Token = "0x6000147")]
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	[Address(RVA = "0x5E4870", Offset = "0x5E3C70", Length = "0x5A")]
	[Token(Token = "0x6000158")]
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x5E48D0", Offset = "0x5E3CD0", Length = "0x5B")]
	[Token(Token = "0x6000145")]
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

}

