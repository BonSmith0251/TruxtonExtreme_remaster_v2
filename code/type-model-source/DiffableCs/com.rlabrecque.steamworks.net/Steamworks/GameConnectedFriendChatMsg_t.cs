namespace Steamworks;

[CallbackIdentity(343)]
[Token(Token = "0x200003D")]
public struct GameConnectedFriendChatMsg_t
{
	[Token(Token = "0x4000048")]
	public const int k_iCallback = 343; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000049")]
	public CSteamID m_steamIDUser; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004A")]
	public int m_iMessageID; //Field offset: 0x8

}

