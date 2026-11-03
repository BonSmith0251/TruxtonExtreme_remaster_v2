namespace Steamworks;

[CallbackIdentity(344)]
[Token(Token = "0x200003E")]
public struct FriendsGetFollowerCount_t
{
	[Token(Token = "0x400004B")]
	public const int k_iCallback = 344; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004D")]
	public CSteamID m_steamID; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400004E")]
	public int m_nCount; //Field offset: 0xC

}

