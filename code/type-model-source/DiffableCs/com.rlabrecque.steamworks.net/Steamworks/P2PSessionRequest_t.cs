namespace Steamworks;

[CallbackIdentity(1202)]
[Token(Token = "0x20000A1")]
public struct P2PSessionRequest_t
{
	[Token(Token = "0x40001B4")]
	public const int k_iCallback = 1202; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B5")]
	public CSteamID m_steamIDRemote; //Field offset: 0x0

}

