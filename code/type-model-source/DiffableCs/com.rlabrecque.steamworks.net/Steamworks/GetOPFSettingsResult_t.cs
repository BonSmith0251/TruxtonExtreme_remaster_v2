namespace Steamworks;

[CallbackIdentity(4624)]
[Token(Token = "0x2000100")]
public struct GetOPFSettingsResult_t
{
	[Token(Token = "0x400031C")]
	public const int k_iCallback = 4624; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400031D")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400031E")]
	public AppId_t m_unVideoAppID; //Field offset: 0x4

}

