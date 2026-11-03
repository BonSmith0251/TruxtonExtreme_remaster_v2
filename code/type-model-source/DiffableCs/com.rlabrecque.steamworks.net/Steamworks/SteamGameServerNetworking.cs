namespace Steamworks;

[Token(Token = "0x200000B")]
public static class SteamGameServerNetworking
{

	[Address(RVA = "0x5E5740", Offset = "0x5E4B40", Length = "0x4E")]
	[Token(Token = "0x6000125")]
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	[Address(RVA = "0x5E5790", Offset = "0x5E4B90", Length = "0x4E")]
	[Token(Token = "0x6000129")]
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	[Address(RVA = "0x5E57E0", Offset = "0x5E4BE0", Length = "0x5C")]
	[Token(Token = "0x6000127")]
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	[Address(RVA = "0x5E5840", Offset = "0x5E4C40", Length = "0x4E")]
	[Token(Token = "0x6000126")]
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	[Address(RVA = "0x5E5890", Offset = "0x5E4C90", Length = "0x8E")]
	[Token(Token = "0x600012C")]
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	[Address(RVA = "0x5E5920", Offset = "0x5E4D20", Length = "0xA0")]
	[Token(Token = "0x600012A")]
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x5E59C0", Offset = "0x5E4DC0", Length = "0x8E")]
	[Token(Token = "0x600012B")]
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x5E5A50", Offset = "0x5E4E50", Length = "0x5C")]
	[Token(Token = "0x600012E")]
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x5E5AB0", Offset = "0x5E4EB0", Length = "0x5C")]
	[Token(Token = "0x600012D")]
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x5E5B10", Offset = "0x5E4F10", Length = "0x72")]
	[Token(Token = "0x6000135")]
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	[Address(RVA = "0x5E5B90", Offset = "0x5E4F90", Length = "0x4C")]
	[Token(Token = "0x6000137")]
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }

	[Address(RVA = "0x5E5BE0", Offset = "0x5E4FE0", Length = "0x5D")]
	[Token(Token = "0x6000128")]
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	[Address(RVA = "0x5E5C40", Offset = "0x5E5040", Length = "0x4C")]
	[Token(Token = "0x6000136")]
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	[Address(RVA = "0x5E5C90", Offset = "0x5E5090", Length = "0x8E")]
	[Token(Token = "0x6000134")]
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	[Address(RVA = "0x5E5D80", Offset = "0x5E5180", Length = "0x72")]
	[Token(Token = "0x6000132")]
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x5E5D20", Offset = "0x5E5120", Length = "0x5B")]
	[Token(Token = "0x6000130")]
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	[Address(RVA = "0x5E5E00", Offset = "0x5E5200", Length = "0x5C")]
	[Token(Token = "0x6000123")]
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	[Address(RVA = "0x5E5E60", Offset = "0x5E5260", Length = "0x8D")]
	[Token(Token = "0x6000124")]
	public static bool ReadP2PPacket(Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	[Address(RVA = "0x5E5F80", Offset = "0x5E5380", Length = "0x8E")]
	[Token(Token = "0x6000133")]
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x5E5EF0", Offset = "0x5E52F0", Length = "0x84")]
	[Token(Token = "0x6000131")]
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	[Address(RVA = "0x5E6010", Offset = "0x5E5410", Length = "0x85")]
	[Token(Token = "0x600012F")]
	public static bool SendDataOnSocket(SNetSocket_t hSocket, Byte[] pubData, uint cubData, bool bReliable) { }

	[Address(RVA = "0x5E60A0", Offset = "0x5E54A0", Length = "0x8D")]
	[Token(Token = "0x6000122")]
	public static bool SendP2PPacket(CSteamID steamIDRemote, Byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

}

