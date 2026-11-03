namespace Steamworks;

[CallbackIdentity(3409)]
[Token(Token = "0x20000D0")]
public struct GetUserItemVoteResult_t
{
	[Token(Token = "0x4000278")]
	public const int k_iCallback = 3409; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000279")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400027A")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400027B")]
	public bool m_bVotedUp; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x400027C")]
	public bool m_bVotedDown; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x400027D")]
	public bool m_bVoteSkipped; //Field offset: 0xE

}

