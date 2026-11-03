namespace Steamworks;

[Token(Token = "0x200001E")]
public static class SteamNetworkingSockets
{

	[Address(RVA = "0x5F7850", Offset = "0x5F6C50", Length = "0x4F")]
	[Token(Token = "0x6000343")]
	public static EResult AcceptConnection(HSteamNetConnection hConn) { }

	[Address(RVA = "0x5F78A0", Offset = "0x5F6CA0", Length = "0x4F")]
	[Token(Token = "0x6000369")]
	public static bool BeginAsyncRequestFakeIP(int nNumPorts) { }

	[Address(RVA = "0x5F78F0", Offset = "0x5F6CF0", Length = "0x14C")]
	[Token(Token = "0x6000344")]
	public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	[Address(RVA = "0x5F7A40", Offset = "0x5F6E40", Length = "0x4F")]
	[Token(Token = "0x6000345")]
	public static bool CloseListenSocket(HSteamListenSocket hSocket) { }

	[Address(RVA = "0x5F7A90", Offset = "0x5F6E90", Length = "0x86")]
	[Token(Token = "0x6000353")]
	public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, Int32[] pLanePriorities, UInt16[] pLaneWeights) { }

	[Address(RVA = "0x5F7B20", Offset = "0x5F6F20", Length = "0xB1")]
	[Token(Token = "0x6000340")]
	public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F7CB0", Offset = "0x5F70B0", Length = "0xC3")]
	[Token(Token = "0x6000342")]
	public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F7BE0", Offset = "0x5F6FE0", Length = "0xCD")]
	[Token(Token = "0x6000363")]
	public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F7D80", Offset = "0x5F7180", Length = "0xC3")]
	[Token(Token = "0x600035D")]
	public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F7E50", Offset = "0x5F7250", Length = "0x4F")]
	[Token(Token = "0x600036D")]
	public static IntPtr CreateFakeUDPPort(int idxFakeServerPort) { }

	[Address(RVA = "0x5F7EA0", Offset = "0x5F72A0", Length = "0xAF")]
	[Token(Token = "0x6000361")]
	public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F7F50", Offset = "0x5F7350", Length = "0xB1")]
	[Token(Token = "0x600033F")]
	public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F80C0", Offset = "0x5F74C0", Length = "0xAF")]
	[Token(Token = "0x6000341")]
	public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F8010", Offset = "0x5F7410", Length = "0xAF")]
	[Token(Token = "0x600036B")]
	public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions) { }

	[Address(RVA = "0x5F8170", Offset = "0x5F7570", Length = "0x86")]
	[Token(Token = "0x6000357")]
	public static HSteamNetPollGroup CreatePollGroup() { }

	[Address(RVA = "0x5F8200", Offset = "0x5F7600", Length = "0x95")]
	[Token(Token = "0x6000352")]
	public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	[Address(RVA = "0x5F82A0", Offset = "0x5F76A0", Length = "0x4F")]
	[Token(Token = "0x6000358")]
	public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x5F82F0", Offset = "0x5F76F0", Length = "0x76")]
	[Token(Token = "0x600035C")]
	public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x5F8370", Offset = "0x5F7770", Length = "0x4F")]
	[Token(Token = "0x600034C")]
	public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn) { }

	[Address(RVA = "0x5F83C0", Offset = "0x5F77C0", Length = "0x51")]
	[Token(Token = "0x6000356")]
	public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails) { }

	[Address(RVA = "0x5F8420", Offset = "0x5F7820", Length = "0x77")]
	[Token(Token = "0x6000365")]
	public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x5F84A0", Offset = "0x5F78A0", Length = "0x5E")]
	[Token(Token = "0x600034E")]
	public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	[Address(RVA = "0x5F8500", Offset = "0x5F7900", Length = "0x10A")]
	[Token(Token = "0x6000349")]
	public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen) { }

	[Address(RVA = "0x5F8610", Offset = "0x5F7A10", Length = "0x87")]
	[Token(Token = "0x600034F")]
	public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes) { }

	[Address(RVA = "0x5F86A0", Offset = "0x5F7AA0", Length = "0x4F")]
	[Token(Token = "0x6000347")]
	public static long GetConnectionUserData(HSteamNetConnection hPeer) { }

	[Address(RVA = "0x5F86F0", Offset = "0x5F7AF0", Length = "0x109")]
	[Token(Token = "0x6000350")]
	public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf) { }

	[Address(RVA = "0x5F8800", Offset = "0x5F7C00", Length = "0x5E")]
	[Token(Token = "0x600036A")]
	public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo) { }

	[Address(RVA = "0x5F8860", Offset = "0x5F7C60", Length = "0x77")]
	[Token(Token = "0x6000362")]
	public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	[Address(RVA = "0x5F88E0", Offset = "0x5F7CE0", Length = "0x51")]
	[Token(Token = "0x6000360")]
	public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting) { }

	[Address(RVA = "0x5F8940", Offset = "0x5F7D40", Length = "0x50")]
	[Token(Token = "0x600035F")]
	public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() { }

	[Address(RVA = "0x5F8990", Offset = "0x5F7D90", Length = "0x47")]
	[Token(Token = "0x600035E")]
	public static ushort GetHostedDedicatedServerPort() { }

	[Address(RVA = "0x5F89E0", Offset = "0x5F7DE0", Length = "0x51")]
	[Token(Token = "0x6000354")]
	public static bool GetIdentity(out SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x5F8A40", Offset = "0x5F7E40", Length = "0x5E")]
	[Token(Token = "0x6000351")]
	public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	[Address(RVA = "0x5F8AA0", Offset = "0x5F7EA0", Length = "0x5E")]
	[Token(Token = "0x600036C")]
	public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr) { }

	[Address(RVA = "0x5F8B00", Offset = "0x5F7F00", Length = "0x47")]
	[Token(Token = "0x6000355")]
	public static ESteamNetworkingAvailability InitAuthentication() { }

	[Address(RVA = "0x5F8CF0", Offset = "0x5F80F0", Length = "0x76")]
	[Token(Token = "0x6000364")]
	public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	[Address(RVA = "0x5F8D70", Offset = "0x5F8170", Length = "0x76")]
	[Token(Token = "0x600035B")]
	public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	[Address(RVA = "0x5F8B50", Offset = "0x5F7F50", Length = "0xC7")]
	[Token(Token = "0x600034D")]
	public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5F8C20", Offset = "0x5F8020", Length = "0xC7")]
	[Token(Token = "0x600035A")]
	public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5F8DF0", Offset = "0x5F81F0", Length = "0x51")]
	[Token(Token = "0x6000367")]
	public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity) { }

	[Address(RVA = "0x5F8E50", Offset = "0x5F8250", Length = "0x47")]
	[Token(Token = "0x6000368")]
	public static void RunCallbacks() { }

	[Address(RVA = "0x5F8F30", Offset = "0x5F8330", Length = "0x75")]
	[Token(Token = "0x600034B")]
	public static void SendMessages(int nMessages, IntPtr[] pMessages, Int64[] pOutMessageNumberOrResult) { }

	[Address(RVA = "0x5F8EA0", Offset = "0x5F82A0", Length = "0x90")]
	[Token(Token = "0x600034A")]
	public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	[Address(RVA = "0x5F8FB0", Offset = "0x5F83B0", Length = "0x76")]
	[Token(Token = "0x6000366")]
	public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	[Address(RVA = "0x5F9030", Offset = "0x5F8430", Length = "0x113")]
	[Token(Token = "0x6000348")]
	public static void SetConnectionName(HSteamNetConnection hPeer, string pszName) { }

	[Address(RVA = "0x5F9150", Offset = "0x5F8550", Length = "0x5D")]
	[Token(Token = "0x6000359")]
	public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	[Address(RVA = "0x5F91B0", Offset = "0x5F85B0", Length = "0x5E")]
	[Token(Token = "0x6000346")]
	public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) { }

}

