namespace Steamworks;

[CallbackIdentity(335)]
[Token(Token = "0x2000035")]
public struct ClanOfficerListResponse_t
{
	[Token(Token = "0x400002D")]
	public const int k_iCallback = 335; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002E")]
	public CSteamID m_steamIDClan; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002F")]
	public int m_cOfficers; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000030")]
	public byte m_bSuccess; //Field offset: 0xC

}

