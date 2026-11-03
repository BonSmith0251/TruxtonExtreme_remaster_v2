namespace Steamworks;

[CallbackIdentity(211)]
[Token(Token = "0x2000051")]
public struct ComputeNewPlayerCompatibilityResult_t
{
	[Token(Token = "0x4000090")]
	public const int k_iCallback = 211; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000091")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000092")]
	public int m_cPlayersThatDontLikeCandidate; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000093")]
	public int m_cPlayersThatCandidateDoesntLike; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000094")]
	public int m_cClanPlayersThatDontLikeCandidate; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000095")]
	public CSteamID m_SteamIDCandidate; //Field offset: 0x10

}

