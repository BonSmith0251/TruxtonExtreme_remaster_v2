namespace Steamworks;

[CallbackIdentity(5702)]
[Token(Token = "0x20000AB")]
public struct SteamRemotePlaySessionDisconnected_t
{
	[Token(Token = "0x40001D2")]
	public const int k_iCallback = 5702; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D3")]
	public RemotePlaySessionID_t m_unSessionID; //Field offset: 0x0

}

