namespace Steamworks;

[CallbackIdentity(5701)]
[Token(Token = "0x20000AA")]
public struct SteamRemotePlaySessionConnected_t
{
	[Token(Token = "0x40001D0")]
	public const int k_iCallback = 5701; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D1")]
	public RemotePlaySessionID_t m_unSessionID; //Field offset: 0x0

}

