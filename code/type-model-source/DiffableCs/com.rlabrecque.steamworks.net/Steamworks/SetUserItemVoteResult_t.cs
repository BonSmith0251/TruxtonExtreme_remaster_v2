namespace Steamworks;

[CallbackIdentity(3408)]
[Token(Token = "0x20000CF")]
public struct SetUserItemVoteResult_t
{
	[Token(Token = "0x4000274")]
	public const int k_iCallback = 3408; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000275")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000276")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000277")]
	public bool m_bVoteUp; //Field offset: 0xC

}

