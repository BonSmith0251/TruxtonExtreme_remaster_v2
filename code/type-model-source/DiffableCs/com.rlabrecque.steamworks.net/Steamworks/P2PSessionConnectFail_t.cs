namespace Steamworks;

[CallbackIdentity(1203)]
[Token(Token = "0x20000A2")]
public struct P2PSessionConnectFail_t
{
	[Token(Token = "0x40001B6")]
	public const int k_iCallback = 1203; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B7")]
	public CSteamID m_steamIDRemote; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001B8")]
	public byte m_eP2PSessionError; //Field offset: 0x8

}

