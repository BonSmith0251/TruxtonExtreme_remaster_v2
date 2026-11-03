namespace Steamworks;

[CallbackIdentity(1315)]
[Token(Token = "0x20000B3")]
public struct RemoteStorageUnsubscribePublishedFileResult_t
{
	[Token(Token = "0x40001EF")]
	public const int k_iCallback = 1315; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F0")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001F1")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8

}

