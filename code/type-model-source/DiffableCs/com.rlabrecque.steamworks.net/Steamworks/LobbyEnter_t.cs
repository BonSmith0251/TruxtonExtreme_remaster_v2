namespace Steamworks;

[CallbackIdentity(504)]
[Token(Token = "0x200007B")]
public struct LobbyEnter_t
{
	[Token(Token = "0x4000144")]
	public const int k_iCallback = 504; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000145")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000146")]
	public uint m_rgfChatPermissions; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000147")]
	public bool m_bLocked; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000148")]
	public uint m_EChatRoomEnterResponse; //Field offset: 0x10

}

