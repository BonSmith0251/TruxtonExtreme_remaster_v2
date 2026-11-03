namespace Steamworks;

[CallbackIdentity(1323)]
[Token(Token = "0x20000BB")]
public struct RemoteStoragePublishedFileDeleted_t
{
	[Token(Token = "0x4000228")]
	public const int k_iCallback = 1323; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000229")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400022A")]
	public AppId_t m_nAppID; //Field offset: 0x8

}

