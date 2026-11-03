namespace Steamworks;

[CallbackIdentity(1324)]
[Token(Token = "0x20000BC")]
public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
{
	[Token(Token = "0x400022B")]
	public const int k_iCallback = 1324; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400022C")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400022D")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

