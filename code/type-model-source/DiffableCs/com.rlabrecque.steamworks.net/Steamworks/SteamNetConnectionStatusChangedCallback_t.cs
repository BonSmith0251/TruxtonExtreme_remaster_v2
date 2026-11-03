namespace Steamworks;

[CallbackIdentity(1221)]
[Token(Token = "0x20000A6")]
public struct SteamNetConnectionStatusChangedCallback_t
{
	[Token(Token = "0x40001C2")]
	public const int k_iCallback = 1221; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C3")]
	public HSteamNetConnection m_hConn; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001C4")]
	public SteamNetConnectionInfo_t m_info; //Field offset: 0x8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001C5")]
	public ESteamNetworkingConnectionState m_eOldState; //Field offset: 0xE8

}

