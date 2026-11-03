namespace Steamworks;

[CallbackIdentity(333)]
[Token(Token = "0x2000033")]
public struct GameLobbyJoinRequested_t
{
	[Token(Token = "0x4000025")]
	public const int k_iCallback = 333; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000026")]
	public CSteamID m_steamIDLobby; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000027")]
	public CSteamID m_steamIDFriend; //Field offset: 0x8

}

