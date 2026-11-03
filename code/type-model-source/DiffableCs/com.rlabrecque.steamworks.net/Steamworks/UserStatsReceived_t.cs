namespace Steamworks;

[CallbackIdentity(1101)]
[Token(Token = "0x20000EA")]
public struct UserStatsReceived_t
{
	[Token(Token = "0x40002D8")]
	public const int k_iCallback = 1101; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D9")]
	public ulong m_nGameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002DA")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002DB")]
	public CSteamID m_steamIDUser; //Field offset: 0xC

}

