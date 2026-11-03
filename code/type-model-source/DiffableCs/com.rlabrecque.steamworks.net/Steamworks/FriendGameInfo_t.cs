namespace Steamworks;

[Token(Token = "0x2000172")]
public struct FriendGameInfo_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E1")]
	public CGameID m_gameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009E2")]
	public uint m_unGameIP; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009E3")]
	public ushort m_usGamePort; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40009E4")]
	public ushort m_usQueryPort; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E5")]
	public CSteamID m_steamIDLobby; //Field offset: 0x10

}

