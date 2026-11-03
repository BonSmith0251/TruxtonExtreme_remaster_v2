namespace Steamworks;

[CallbackIdentity(336)]
[Token(Token = "0x2000036")]
public struct FriendRichPresenceUpdate_t
{
	[Token(Token = "0x4000031")]
	public const int k_iCallback = 336; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000032")]
	public CSteamID m_steamIDFriend; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000033")]
	public AppId_t m_nAppID; //Field offset: 0x8

}

