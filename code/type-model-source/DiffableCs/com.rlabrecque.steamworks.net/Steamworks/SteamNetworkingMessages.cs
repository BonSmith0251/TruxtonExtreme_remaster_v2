namespace Steamworks;

[Token(Token = "0x200001D")]
public static class SteamNetworkingMessages
{

	[Address(RVA = "0x5F7550", Offset = "0x5F6950", Length = "0x51")]
	[Token(Token = "0x600033B")]
	public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x5F75B0", Offset = "0x5F69B0", Length = "0x5F")]
	[Token(Token = "0x600033D")]
	public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	[Address(RVA = "0x5F7610", Offset = "0x5F6A10", Length = "0x51")]
	[Token(Token = "0x600033C")]
	public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) { }

	[Address(RVA = "0x5F7670", Offset = "0x5F6A70", Length = "0x77")]
	[Token(Token = "0x600033E")]
	public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus) { }

	[Address(RVA = "0x5F76F0", Offset = "0x5F6AF0", Length = "0xC7")]
	[Token(Token = "0x600033A")]
	public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages) { }

	[Address(RVA = "0x5F77C0", Offset = "0x5F6BC0", Length = "0x90")]
	[Token(Token = "0x6000339")]
	public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

}

