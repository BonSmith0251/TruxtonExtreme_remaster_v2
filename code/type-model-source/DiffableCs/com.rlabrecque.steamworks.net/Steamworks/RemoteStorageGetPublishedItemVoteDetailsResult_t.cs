namespace Steamworks;

[CallbackIdentity(1320)]
[Token(Token = "0x20000B8")]
public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
{
	[Token(Token = "0x400021B")]
	public const int k_iCallback = 1320; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400021D")]
	public PublishedFileId_t m_unPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021E")]
	public int m_nVotesFor; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400021F")]
	public int m_nVotesAgainst; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000220")]
	public int m_nReports; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000221")]
	public float m_fScore; //Field offset: 0x1C

}

