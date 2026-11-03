namespace Steamworks;

[CallbackIdentity(203)]
[Token(Token = "0x200004A")]
public struct GSClientKick_t
{
	[Token(Token = "0x4000073")]
	public const int k_iCallback = 203; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000074")]
	public CSteamID m_SteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000075")]
	public EDenyReason m_eDenyReason; //Field offset: 0x8

}

