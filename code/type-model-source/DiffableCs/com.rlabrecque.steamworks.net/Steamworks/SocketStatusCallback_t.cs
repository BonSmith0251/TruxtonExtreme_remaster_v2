namespace Steamworks;

[CallbackIdentity(1201)]
[Token(Token = "0x20000A3")]
public struct SocketStatusCallback_t
{
	[Token(Token = "0x40001B9")]
	public const int k_iCallback = 1201; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BA")]
	public SNetSocket_t m_hSocket; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001BB")]
	public SNetListenSocket_t m_hListenSocket; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001BC")]
	public CSteamID m_steamIDRemote; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BD")]
	public int m_eSNetSocketState; //Field offset: 0x10

}

