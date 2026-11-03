namespace Steamworks;

[CallbackIdentity(143)]
[Token(Token = "0x20000E1")]
public struct ValidateAuthTicketResponse_t
{
	[Token(Token = "0x40002B3")]
	public const int k_iCallback = 143; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B4")]
	public CSteamID m_SteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002B5")]
	public EAuthSessionResponse m_eAuthSessionResponse; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40002B6")]
	public CSteamID m_OwnerSteamID; //Field offset: 0xC

}

