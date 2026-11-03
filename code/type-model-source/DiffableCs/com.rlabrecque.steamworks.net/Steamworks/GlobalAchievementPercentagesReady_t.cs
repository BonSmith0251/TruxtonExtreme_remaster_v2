namespace Steamworks;

[CallbackIdentity(1110)]
[Token(Token = "0x20000F3")]
public struct GlobalAchievementPercentagesReady_t
{
	[Token(Token = "0x40002FD")]
	public const int k_iCallback = 1110; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002FE")]
	public ulong m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002FF")]
	public EResult m_eResult; //Field offset: 0x8

}

