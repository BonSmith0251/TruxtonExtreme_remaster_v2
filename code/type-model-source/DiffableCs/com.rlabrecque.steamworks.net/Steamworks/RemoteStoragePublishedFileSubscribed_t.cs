namespace Steamworks;

[CallbackIdentity(1321)]
[Token(Token = "0x20000B9")]
public struct RemoteStoragePublishedFileSubscribed_t
{
	[Token(Token = "0x4000222")]
	public const int k_iCallback = 1321; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000223")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000224")]
	public AppId_t m_nAppID; //Field offset: 0x8

}

