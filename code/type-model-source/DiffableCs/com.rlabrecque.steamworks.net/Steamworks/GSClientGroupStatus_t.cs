namespace Steamworks;

[CallbackIdentity(208)]
[Token(Token = "0x200004E")]
public struct GSClientGroupStatus_t
{
	[Token(Token = "0x4000081")]
	public const int k_iCallback = 208; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000082")]
	public CSteamID m_SteamIDUser; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000083")]
	public CSteamID m_SteamIDGroup; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000084")]
	public bool m_bMember; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000085")]
	public bool m_bOfficer; //Field offset: 0x11

}

