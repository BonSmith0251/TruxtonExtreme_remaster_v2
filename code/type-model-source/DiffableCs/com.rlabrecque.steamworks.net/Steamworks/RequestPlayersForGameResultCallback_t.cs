namespace Steamworks;

[CallbackIdentity(5212)]
[Token(Token = "0x2000087")]
public struct RequestPlayersForGameResultCallback_t
{
	[Token(Token = "0x4000178")]
	public const int k_iCallback = 5212; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000179")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400017A")]
	public ulong m_ullSearchID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017B")]
	public CSteamID m_SteamIDPlayerFound; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017C")]
	public CSteamID m_SteamIDLobby; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017D")]
	public PlayerAcceptState_t m_ePlayerAcceptState; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400017E")]
	public int m_nPlayerIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017F")]
	public int m_nTotalPlayersFound; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000180")]
	public int m_nTotalPlayersAcceptedGame; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000181")]
	public int m_nSuggestedTeamIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000182")]
	public ulong m_ullUniqueGameID; //Field offset: 0x38

}

