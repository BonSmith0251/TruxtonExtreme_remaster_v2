namespace Steamworks;

[CallbackIdentity(1322)]
[Token(Token = "0x20000BA")]
public struct RemoteStoragePublishedFileUnsubscribed_t
{
	[Token(Token = "0x4000225")]
	public const int k_iCallback = 1322; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000226")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000227")]
	public AppId_t m_nAppID; //Field offset: 0x8

}

