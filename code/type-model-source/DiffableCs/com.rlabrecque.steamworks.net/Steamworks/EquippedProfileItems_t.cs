namespace Steamworks;

[CallbackIdentity(351)]
[Token(Token = "0x2000045")]
public struct EquippedProfileItems_t
{
	[Token(Token = "0x4000061")]
	public const int k_iCallback = 351; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000062")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000063")]
	public CSteamID m_steamID; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000064")]
	public bool m_bHasAnimatedAvatar; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x4000065")]
	public bool m_bHasAvatarFrame; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000066")]
	public bool m_bHasProfileModifier; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x4000067")]
	public bool m_bHasProfileBackground; //Field offset: 0xF
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000068")]
	public bool m_bHasMiniProfileBackground; //Field offset: 0x10

}

