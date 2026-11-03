namespace Steamworks;

[CallbackIdentity(1252)]
[Token(Token = "0x20000A5")]
public struct SteamNetworkingMessagesSessionFailed_t
{
	[Token(Token = "0x40001C0")]
	public const int k_iCallback = 1252; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C1")]
	public SteamNetConnectionInfo_t m_info; //Field offset: 0x0

}

