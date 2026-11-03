namespace Steamworks;

[CallbackIdentity(102)]
[Token(Token = "0x20000DC")]
public struct SteamServerConnectFailure_t
{
	[Token(Token = "0x40002A5")]
	public const int k_iCallback = 102; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A6")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002A7")]
	public bool m_bStillRetrying; //Field offset: 0x4

}

