namespace Steamworks;

[CallbackIdentity(340)]
[Token(Token = "0x200003A")]
public struct GameConnectedChatLeave_t
{
	[Token(Token = "0x400003E")]
	public const int k_iCallback = 340; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003F")]
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000040")]
	public CSteamID m_steamIDUser; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000041")]
	public bool m_bKicked; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000042")]
	public bool m_bDropped; //Field offset: 0x11

}

