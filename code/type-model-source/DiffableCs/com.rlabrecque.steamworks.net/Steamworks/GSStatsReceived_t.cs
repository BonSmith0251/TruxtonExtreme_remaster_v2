namespace Steamworks;

[CallbackIdentity(1800)]
[Token(Token = "0x2000052")]
public struct GSStatsReceived_t
{
	[Token(Token = "0x4000096")]
	public const int k_iCallback = 1800; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000097")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000098")]
	public CSteamID m_steamIDUser; //Field offset: 0x4

}

