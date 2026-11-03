namespace Steamworks;

[CallbackIdentity(338)]
[Token(Token = "0x2000038")]
public struct GameConnectedClanChatMsg_t
{
	[Token(Token = "0x4000037")]
	public const int k_iCallback = 338; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000038")]
	public CSteamID m_steamIDClanChat; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000039")]
	public CSteamID m_steamIDUser; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003A")]
	public int m_iMessageID; //Field offset: 0x10

}

