namespace Steamworks;

[Token(Token = "0x200001C")]
public static class SteamNetworking
{

	[Address(RVA = "0x5FA070", Offset = "0x5F9470", Length = "0x4E")]
	[Token(Token = "0x6000326")]
	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	[Address(RVA = "0x5FA0C0", Offset = "0x5F94C0", Length = "0x4E")]
	[Token(Token = "0x600032A")]
	public static bool AllowP2PPacketRelay(bool bAllow) { }

	[Address(RVA = "0x5FA110", Offset = "0x5F9510", Length = "0x5C")]
	[Token(Token = "0x6000328")]
	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel) { }

	[Address(RVA = "0x5FA170", Offset = "0x5F9570", Length = "0x4E")]
	[Token(Token = "0x6000327")]
	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	[Address(RVA = "0x5FA1C0", Offset = "0x5F95C0", Length = "0x8E")]
	[Token(Token = "0x600032D")]
	public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	[Address(RVA = "0x5FA250", Offset = "0x5F9650", Length = "0xA0")]
	[Token(Token = "0x600032B")]
	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x5FA2F0", Offset = "0x5F96F0", Length = "0x8E")]
	[Token(Token = "0x600032C")]
	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	[Address(RVA = "0x5FA380", Offset = "0x5F9780", Length = "0x5C")]
	[Token(Token = "0x600032F")]
	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x5FA3E0", Offset = "0x5F97E0", Length = "0x5C")]
	[Token(Token = "0x600032E")]
	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	[Address(RVA = "0x5FA440", Offset = "0x5F9840", Length = "0x72")]
	[Token(Token = "0x6000336")]
	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	[Address(RVA = "0x5FA4C0", Offset = "0x5F98C0", Length = "0x4C")]
	[Token(Token = "0x6000338")]
	public static int GetMaxPacketSize(SNetSocket_t hSocket) { }

	[Address(RVA = "0x5FA510", Offset = "0x5F9910", Length = "0x5D")]
	[Token(Token = "0x6000329")]
	public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	[Address(RVA = "0x5FA570", Offset = "0x5F9970", Length = "0x4C")]
	[Token(Token = "0x6000337")]
	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket) { }

	[Address(RVA = "0x5FA5C0", Offset = "0x5F99C0", Length = "0x8E")]
	[Token(Token = "0x6000335")]
	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	[Address(RVA = "0x5FA6B0", Offset = "0x5F9AB0", Length = "0x72")]
	[Token(Token = "0x6000333")]
	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x5FA650", Offset = "0x5F9A50", Length = "0x5B")]
	[Token(Token = "0x6000331")]
	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize) { }

	[Address(RVA = "0x5FA730", Offset = "0x5F9B30", Length = "0x5C")]
	[Token(Token = "0x6000324")]
	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0) { }

	[Address(RVA = "0x5FA790", Offset = "0x5F9B90", Length = "0x8D")]
	[Token(Token = "0x6000325")]
	public static bool ReadP2PPacket(Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0) { }

	[Address(RVA = "0x5FA8B0", Offset = "0x5F9CB0", Length = "0x8E")]
	[Token(Token = "0x6000334")]
	public static bool RetrieveData(SNetListenSocket_t hListenSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	[Address(RVA = "0x5FA820", Offset = "0x5F9C20", Length = "0x84")]
	[Token(Token = "0x6000332")]
	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	[Address(RVA = "0x5FA940", Offset = "0x5F9D40", Length = "0x85")]
	[Token(Token = "0x6000330")]
	public static bool SendDataOnSocket(SNetSocket_t hSocket, Byte[] pubData, uint cubData, bool bReliable) { }

	[Address(RVA = "0x5FA9D0", Offset = "0x5F9DD0", Length = "0x8D")]
	[Token(Token = "0x6000323")]
	public static bool SendP2PPacket(CSteamID steamIDRemote, Byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0) { }

}

