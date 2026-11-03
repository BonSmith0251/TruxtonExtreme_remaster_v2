namespace Steamworks;

[CallbackIdentity(201)]
[Token(Token = "0x2000048")]
public struct GSClientApprove_t
{
	[Token(Token = "0x400006C")]
	public const int k_iCallback = 201; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006D")]
	public CSteamID m_SteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400006E")]
	public CSteamID m_OwnerSteamID; //Field offset: 0x8

}

