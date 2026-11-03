namespace Steamworks;

[CallbackIdentity(503)]
[Token(Token = "0x200007A")]
public struct LobbyInvite_t
{
	[Token(Token = "0x4000140")]
	public const int k_iCallback = 503; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000141")]
	public ulong m_ulSteamIDUser; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000142")]
	public ulong m_ulSteamIDLobby; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000143")]
	public ulong m_ulGameID; //Field offset: 0x10

}

