namespace Steamworks;

[CallbackIdentity(1801)]
[Token(Token = "0x2000053")]
public struct GSStatsStored_t
{
	[Token(Token = "0x4000099")]
	public const int k_iCallback = 1801; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009A")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400009B")]
	public CSteamID m_steamIDUser; //Field offset: 0x4

}

