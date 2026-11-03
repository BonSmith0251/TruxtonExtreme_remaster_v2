namespace Steamworks;

[CallbackIdentity(1111)]
[Token(Token = "0x20000F4")]
public struct LeaderboardUGCSet_t
{
	[Token(Token = "0x4000300")]
	public const int k_iCallback = 1111; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000301")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000302")]
	public SteamLeaderboard_t m_hSteamLeaderboard; //Field offset: 0x8

}

