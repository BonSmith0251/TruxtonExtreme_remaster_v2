namespace Steamworks;

[Token(Token = "0x200000C")]
public static class SteamGameServerNetworkingMessages
{

	[Address(RVA = "0x5E2D10", Offset = "0x5E2110", Length = "0x4E")]
	[Token(Token = "0x600013A")]
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x5E2D60", Offset = "0x5E2160", Length = "0x5C")]
	[Token(Token = "0x600013C")]
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	[Address(RVA = "0x5E2DC0", Offset = "0x5E21C0", Length = "0x4E")]
	[Token(Token = "0x600013B")]
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x5E2E10", Offset = "0x5E2210", Length = "0x74")]
	[Token(Token = "0x600013D")]
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }

	[Address(RVA = "0x5E2E90", Offset = "0x5E2290", Length = "0xC4")]
	[Token(Token = "0x6000139")]
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5E2F60", Offset = "0x5E2360", Length = "0x8D")]
	[Token(Token = "0x6000138")]
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

}

