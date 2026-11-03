namespace Steamworks;

[CallbackIdentity(103)]
[Token(Token = "0x20000DD")]
public struct SteamServersDisconnected_t
{
	[Token(Token = "0x40002A8")]
	public const int k_iCallback = 103; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A9")]
	public EResult m_eResult; //Field offset: 0x0

}

