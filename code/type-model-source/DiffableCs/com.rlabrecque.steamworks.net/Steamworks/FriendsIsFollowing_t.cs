namespace Steamworks;

[CallbackIdentity(345)]
[Token(Token = "0x200003F")]
public struct FriendsIsFollowing_t
{
	[Token(Token = "0x400004F")]
	public const int k_iCallback = 345; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000051")]
	public CSteamID m_steamID; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000052")]
	public bool m_bIsFollowing; //Field offset: 0xC

}

