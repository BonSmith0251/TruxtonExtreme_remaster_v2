namespace Steamworks;

[CallbackIdentity(339)]
[Token(Token = "0x2000039")]
public struct GameConnectedChatJoin_t
{
	[Token(Token = "0x400003B")]
	public const int k_iCallback = 339; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003C")]
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003D")]
	public CSteamID m_steamIDUser; //Field offset: 0x8

}

